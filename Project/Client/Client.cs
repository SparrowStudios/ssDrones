using System.Threading.Tasks;
using CitizenFX.Core;
using System;
using System.Linq;
using SparrowStudios.Fivem.ssDrones.Models;
using static CitizenFX.Core.Native.API;
using static SparrowStudios.Fivem.ssDrones.Constants;

namespace SparrowStudios.Fivem.ssDrones.Client
{
    public class Client : BaseScript
    {
        #region Variables
        public static Player ClientPlayer => Game.Player;
        public static Ped ClientPed => Game.PlayerPed;
        public static Vehicle ClientCurrentVehicle => ClientPed?.CurrentVehicle;
        public static Vehicle ClientLastVehicle => ClientPed?.LastVehicle;
        public Drone CurrentDrone;
        #endregion

        public Client()
        {

        }

        #region Ticks
        #endregion

        #region Event Handlers
        [EventHandler(Events.Client.DRONE_COMMAND)]
        private void OnEventDroneCommand(string droneName)
        {
            Drone targetDrone = Drones.BasitDrone;

            if (!string.IsNullOrEmpty(droneName) && Drones.List.FirstOrDefault(_drone => _drone.Name == droneName) != null) 
            { 
                targetDrone = Drones.List.FirstOrDefault(_drone => _drone.Name == droneName);
            }

            SpawnDrone(targetDrone);
        }
        #endregion

        #region Functions
        private static void Log(string message) => Debug.WriteLine($"[ssDrones] DEBUG: {message}");

        private async Task SpawnDrone(Drone drone)
        {
            // Fade the screen
            DoScreenFadeOut(500);
            await Delay(500);

            // Spawn the drone object
            Entity droneObj = await drone.CreateObject(ClientPed.Position);
            drone.Handle = droneObj.Handle;
            drone.NetId = droneObj.NetworkId;

            // Create the camera
            Camera droneCam = await drone.CreateCamera();
            drone.Camera = droneCam.Handle;

            // Setup on the drone object
            SetEntityAsMissionEntity(droneObj.Handle, true, true);
            SetObjectPhysicsParams(droneObj.Handle, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f);

            // Scaleform stuffzz here
            drone.DroneScaleform = await ScaleformUtils.LoadMove("DRONE_CAM");
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_EMP_METER_IS_VISIBLE", false);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_INFO_LIST_IS_VISIBLE", false);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_SOUND_WAVE_IS_VISIBLE", false);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_TRANQUILIZE_METER_IS_VISIBLE", false);
            
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_DETONATE_METER_IS_VISIBLE", false);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_SHOCK_METER_IS_VISIBLE", false);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_RETICLE_IS_VISIBLE", false);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_BOOST_METER_IS_VISIBLE", false);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_HEADING_METER_IS_VISIBLE", true);
            ScaleformUtils.PopBool(drone.DroneScaleform, "SET_ZOOM_METER_IS_VISIBLE", true);

            ScaleformUtils.PopInt(drone.DroneScaleform, "SET_ZOOM", 0);

            ScaleformUtils.StartPopMulti(drone.DroneScaleform, "SET_ZOOM_LABEL");
            ScaleformUtils.PopMultiInt(0);
            ScaleformUtils.PopMultiString("DRONE_ZOOM_1");
            ScaleformUtils.EndPopMulti();

            ScaleformUtils.StartPopMulti(drone.DroneScaleform, "SET_ZOOM_LABEL");
            ScaleformUtils.PopMultiInt(1);
            ScaleformUtils.PopMultiString("");
            ScaleformUtils.EndPopMulti();

            ScaleformUtils.StartPopMulti(drone.DroneScaleform, "SET_ZOOM_LABEL");
            ScaleformUtils.PopMultiInt(2);
            ScaleformUtils.PopMultiString("DRONE_ZOOM_2");
            ScaleformUtils.EndPopMulti();

            ScaleformUtils.StartPopMulti(drone.DroneScaleform, "SET_ZOOM_LABEL");
            ScaleformUtils.PopMultiInt(3);
            ScaleformUtils.PopMultiString("");
            ScaleformUtils.EndPopMulti();

            ScaleformUtils.StartPopMulti(drone.DroneScaleform, "SET_ZOOM_LABEL");
            ScaleformUtils.PopMultiInt(4);
            ScaleformUtils.PopMultiString("DRONE_ZOOM_3");
            ScaleformUtils.EndPopMulti();

            // Set & play the sounds from the drone
            drone.SoundId = GetSoundId();
            PlaySoundFromEntity(drone.SoundId, "Flight_Loop", droneObj.Handle, "DLC_BTL_Drone_Sounds", true, 0);

            // Fade the screen back in
            DoScreenFadeIn(500);

            // Set the curren drone var
            CurrentDrone = drone;

            // Start listening for control inputs
            ListenForDroneControls(drone);
        }

        private async Task ListenForDroneControls(Drone drone)
        {
            // Init vars
            float zoom = 0.0f;
            float heading = 0.0f;
            float rotationMomentum = 0.0f;
            Vector3 movementMomentum = Vector3.Zero;
            Vector3 cameraRotation = Vector3.Zero;

            // Hide the radar
            DisplayRadar(false);

            // Start the loop
            while (true)
            {
                // Init vars
                Vector3 forward = Vector3.Zero;
                Vector3 right = Vector3.Zero;
                Vector3 up = Vector3.Zero;
                Vector3 position = Vector3.Zero;
                GetEntityMatrix(drone.Handle, ref forward, ref right, ref up, ref position);

                // Get the distance from the player
                float distance = ClientPed.Position.DistanceTo(position);

                // Disable controls this frame
                DisableAllControlActions(0);

                // Disable collision betwen the player and the drone this frame
                SetEntityNoCollisionEntity(ClientPed.Handle, drone.Handle, true);

                // Play the animation on the player
                if (!IsEntityPlayingAnim(ClientPed.Handle, "anim@heists@ornate_bank@hack", "hack_loop", 3))
                {
                    TaskPlayAnim(ClientPed.Handle, "anim@heists@ornate_bank@hack", "hack_loop", 8.0f, 8.0f, -1, 2, 1.0f, false, false, false);
                }

                #region Drone Movement
                bool didMove = false;
                float maxBoost = 250.0f * drone.Speed;

                #region Move Forward
                if (IsDisabledControlPressed(0, Controls.Movement.FORWARD.KeyIndex))
                {
                    Log($"{Controls.Movement.FORWARD.Label} pushed");
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum + (forward * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Backwards
                if (IsDisabledControlPressed(0, Controls.Movement.BACKWARDS.KeyIndex))
                {
                    Log($"{Controls.Movement.BACKWARDS.Label} pushed");
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum - (forward * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Left
                if (IsDisabledControlPressed(0, Controls.Movement.LEFT.KeyIndex))
                {
                    Log($"{Controls.Movement.LEFT.Label} pushed");
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum - (right * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Right
                if (IsDisabledControlPressed(0, Controls.Movement.RIGHT.KeyIndex))
                {
                    Log($"{Controls.Movement.RIGHT.Label} pushed");
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum + (right * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Down
                if (IsDisabledControlPressed(0, Controls.Movement.DOWN.KeyIndex))
                {
                    Log($"{Controls.Movement.DOWN.Label} pushed");
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum - (up * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Up
                if (IsDisabledControlPressed(0, Controls.Movement.UP.KeyIndex))
                {
                    Log($"{Controls.Movement.UP.Label} pushed");
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum + (up * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #endregion

                #region Camera Movement

                #region Move Up
                if (IsDisabledControlPressed(0, Controls.Camera.UP.KeyIndex))
                {
                    Log($"{Controls.Camera.UP.Label} pushed");
                    cameraRotation = cameraRotation + (new Vector3(1.0f, 0.0f, 0.0f) / Math.Max(2, zoom));
                }
                #endregion

                #region Move Down
                if (IsDisabledControlPressed(0, Controls.Camera.DOWN.KeyIndex))
                {
                    Log($"{Controls.Camera.DOWN.Label} pushed");
                    cameraRotation = cameraRotation - (new Vector3(1.0f, 0.0f, 0.0f) / Math.Max(2, zoom));
                }
                #endregion

                #region Move Left
                if (IsDisabledControlPressed(0, Controls.Camera.LEFT.KeyIndex))
                {
                    Log($"{Controls.Camera.LEFT.Label} pushed");
                    cameraRotation = cameraRotation + (new Vector3(0.0f, 0.0f, 1.0f) / Math.Max(2f, zoom));
                }
                #endregion

                #region Move Right
                if (IsDisabledControlPressed(0, Controls.Camera.RIGHT.KeyIndex))
                {
                    Log($"{Controls.Camera.RIGHT.Label} pushed");
                    cameraRotation = cameraRotation - (new Vector3(0.0f, 0.0f, 1.0f) / Math.Max(2, zoom));
                }
                #endregion

                #region Center Camera
                if (IsDisabledControlPressed(0, Controls.Camera.CENTER.KeyIndex))
                {
                    Log($"{Controls.Camera.CENTER.Label} pushed");
                    cameraRotation = Vector3.Zero;
                }
                #endregion

                #endregion

                #region Drone Heading
                if (IsDisabledControlPressed(0, Controls.Heading.RIGHT.KeyIndex))
                {
                    Log($"{Controls.Heading.RIGHT.Label} pushed");
                    rotationMomentum = (float) Math.Max(-1.5f, rotationMomentum - 0.02f);
                }
                else if (IsDisabledControlPressed(0, Controls.Heading.LEFT.KeyIndex))
                {
                    Log($"{Controls.Heading.LEFT.Label} pushed");
                    rotationMomentum = (float) Math.Min(1.5f, rotationMomentum + 0.02f);
                }
                else
                {
                    if (rotationMomentum > 0.0f)
                    {
                        rotationMomentum = (float) Math.Max(0.0f, rotationMomentum - 0.04f);
                    }
                    else if (rotationMomentum < 0.0f)
                    {
                        rotationMomentum = (float) Math.Min(0.0f, rotationMomentum + 0.04f);
                    }
                }
                #endregion

                #region Zoom

                #region Zoom Out
                if (IsDisabledControlJustPressed(0, Controls.Zoom.OUT.KeyIndex))
                {
                    Log($"{Controls.Zoom.OUT.Label} pushed");
                    zoom = (float)Math.Max(0, zoom - 1);
                    SetCamFov(drone.Camera, 50.0f - (10.0f * zoom));
                }
                #endregion

                #region Zoom In
                if (IsDisabledControlJustPressed(0, Controls.Zoom.IN.KeyIndex))
                {
                    Log($"{Controls.Zoom.IN.Label} pushed");
                    zoom = (float)Math.Min(4, zoom + 1);
                    SetCamFov(drone.Camera, 50.0f - (10.0f * zoom));
                }
                #endregion

                #endregion

                #region Toggle Nightvision
                if (drone.HasNightVision && IsDisabledControlJustPressed(0, Controls.TOGGLE_NIGHTVISION.KeyIndex))
                {
                    Log($"{Controls.TOGGLE_NIGHTVISION.Label} pushed");
                    SetNightvision(!GetUsingnightvision());
                }
                #endregion

                #region Toggle Infared
                if (drone.HasInfared && IsDisabledControlJustPressed(0, Controls.TOGGLE_INFARED.KeyIndex))
                {
                    Log($"{Controls.TOGGLE_INFARED.Label} pushed");
                    SetSeethrough(!GetUsingseethrough());
                    SeethroughSetMaxThickness(1.0f);
                    SeethroughSetNoiseAmountMin(0.0f);
                    SeethroughSetNoiseAmountMax(0.1f);
                    SeethroughSetFadeStartDistance(5000.0f);
                    SeethroughSetFadeEndDistance(6000.0f);
                }
                #endregion

                #region Disconnect Drone
                if (IsDisabledControlJustReleased(0, Controls.DISCONNECT.KeyIndex))
                {
                    Log($"{Controls.DISCONNECT.Label} pushed");

                    PointCamAtEntity(drone.Camera, ClientPed.Handle, 0.0f, 0.0f, 0.0f, true);

                    Vector3 dronePos = GetEntityCoords(drone.Handle, true);
                    float _distance = Vdist(dronePos.X, dronePos.Y, dronePos.Z, ClientPed.Position.X, ClientPed.Position.Y, ClientPed.Position.Z);

                    await Delay(100);

                    while (_distance > 3.0)
                    {
                        dronePos = GetEntityCoords(drone.Handle, true);
                        Vector3 direction = V3Utils.ClampMagnitude((dronePos - ClientPed.Position) * 10.0f, (250.0f * drone.Speed)) * -1.0f;

                        DisableAllControlActions(0);
                        SetEntityNoCollisionEntity(ClientPed.Handle, drone.Handle, true);

                        ApplyForceToEntity(drone.Handle, 0, direction.X, direction.Y, 20.0f + (dronePos.DistanceTo2D(ClientPed.Position) <= 5.0f ? direction.Z : 0.0f), 0.0f, 0.0f ,0.0f, 0, false, true, true, false, true);

                        _distance = Vdist(dronePos.X, dronePos.Y, dronePos.Z, ClientPed.Position.X, ClientPed.Position.Y, ClientPed.Position.Z);
                        SetTimecycleModifierStrength(_distance / drone.Range);
                        await Delay(0);
                    }

                    StopCamPointing(drone.Camera);
                    drone.Disconnect();
                    await drone.DestroyCamera();
                    return;
                }
                #endregion

                // Doing movement
                heading += rotationMomentum * drone.Agility;

                if (!didMove & V3Utils.Magnitude(movementMomentum) > 0.0f)
                {
                    movementMomentum -= movementMomentum / 10.0f * drone.Agility;
                }

                ApplyForceToEntity(drone.Handle, 0, movementMomentum.X, movementMomentum.Y, movementMomentum.Z + 20.0f, 0.0f, 0.0f, 0.0f, 0, false, true, true, false, true);
                SetEntityHeading(drone.Handle, heading);
                SetCamRot(drone.Camera, cameraRotation.X, cameraRotation.Y, cameraRotation.Z + heading, 2);

                SetTimecycleModifierStrength(distance / drone.Range);
                //DrawTextOnScreen($"Movement Momentum: X: {movementMomentum.X}, Y: {movementMomentum.Y}, Z: {movementMomentum.Z}", 0.015f, 0.015f, 0.35f, Alignment.Left, 6, false);

                await Delay(0);
            }
        }
        #endregion

        #region Hud Functions
        /// <summary>
        /// Draw text on the screen at the provided x and y locations.
        /// </summary>
        /// <param name="text">The text to display.</param>
        /// <param name="xPosition">The x position for the text draw origin.</param>
        /// <param name="yPosition">The y position for the text draw origin.</param>
        public static void DrawTextOnScreen(string text, float xPosition, float yPosition) =>
            DrawTextOnScreen(text, xPosition, yPosition, size: 0.48f);

        /// <summary>
        /// Draw text on the screen at the provided x and y locations.
        /// </summary>
        /// <param name="text">The text to display.</param>
        /// <param name="xPosition">The x position for the text draw origin.</param>
        /// <param name="yPosition">The y position for the text draw origin.</param>
        /// <param name="size">The size of the text.</param>
        public static void DrawTextOnScreen(string text, float xPosition, float yPosition, float size) =>
            DrawTextOnScreen(text, xPosition, yPosition, size, CitizenFX.Core.UI.Alignment.Left);

        /// <summary>
        /// Draw text on the screen at the provided x and y locations.
        /// </summary>
        /// <param name="text">The text to display.</param>
        /// <param name="xPosition">The x position for the text draw origin.</param>
        /// <param name="yPosition">The y position for the text draw origin.</param>
        /// <param name="size">The size of the text.</param>
        /// <param name="justification">Align the text. 0: center, 1: left, 2: right</param>
        public static void DrawTextOnScreen(string text, float xPosition, float yPosition, float size, CitizenFX.Core.UI.Alignment justification) =>
            DrawTextOnScreen(text, xPosition, yPosition, size, justification, 6);

        /// <summary>
        /// Draw text on the screen at the provided x and y locations.
        /// </summary>
        /// <param name="text">The text to display.</param>
        /// <param name="xPosition">The x position for the text draw origin.</param>
        /// <param name="yPosition">The y position for the text draw origin.</param>
        /// <param name="size">The size of the text.</param>
        /// <param name="justification">Align the text. 0: center, 1: left, 2: right</param>
        /// <param name="font">Specify the font to use (0-8).</param>
        public static void DrawTextOnScreen(string text, float xPosition, float yPosition, float size, CitizenFX.Core.UI.Alignment justification, int font) =>
            DrawTextOnScreen(text, xPosition, yPosition, size, justification, font, false);

        /// <summary>
        /// Draw text on the screen at the provided x and y locations.
        /// </summary>
        /// <param name="text">The text to display.</param>
        /// <param name="xPosition">The x position for the text draw origin.</param>
        /// <param name="yPosition">The y position for the text draw origin.</param>
        /// <param name="size">The size of the text.</param>
        /// <param name="justification">Align the text. 0: center, 1: left, 2: right</param>
        /// <param name="font">Specify the font to use (0-8).</param>
        /// <param name="disableTextOutline">Disables the default text outline.</param>
        public static void DrawTextOnScreen(string text, float xPosition, float yPosition, float size, CitizenFX.Core.UI.Alignment justification, int font, bool disableTextOutline)
        {
            if (IsHudPreferenceSwitchedOn() && !IsPlayerSwitchInProgress() && IsScreenFadedIn() && !IsPauseMenuActive() && !IsFrontendFading() && !IsPauseMenuRestarting() && !IsHudHidden())
            {
                SetTextFont(font);
                SetTextScale(1.0f, size);
                if (justification == CitizenFX.Core.UI.Alignment.Right)
                {
                    SetTextWrap(0f, xPosition);
                }
                SetTextJustification((int)justification);
                if (!disableTextOutline) { SetTextOutline(); }
                BeginTextCommandDisplayText("STRING");
                AddTextComponentSubstringPlayerName(text);
                EndTextCommandDisplayText(xPosition, yPosition);
            }
        }
        #endregion

    }
}
