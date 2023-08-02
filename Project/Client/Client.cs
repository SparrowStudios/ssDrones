using static CitizenFX.Core.Native.API;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SparrowStudios.Fivem.ssDrones.Models;
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
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum + (forward * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Backwards
                if (IsDisabledControlPressed(0, Controls.Movement.BACKWARDS.KeyIndex))
                {
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum - (forward * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Left
                if (IsDisabledControlPressed(0, Controls.Movement.LEFT.KeyIndex))
                {
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum - (right * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Right
                if (IsDisabledControlPressed(0, Controls.Movement.RIGHT.KeyIndex))
                {
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum + (right * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Down
                if (IsDisabledControlPressed(0, Controls.Movement.DOWN.KeyIndex))
                {
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum - (up * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #region Move Up
                if (IsDisabledControlPressed(0, Controls.Movement.UP.KeyIndex))
                {
                    movementMomentum = V3Utils.ClampMagnitude(movementMomentum + (up * drone.Agility), maxBoost);
                    didMove = true;
                }
                #endregion

                #endregion

                #region Camera Movement

                #region Move Up
                if (IsDisabledControlPressed(0, Controls.Camera.UP.KeyIndex))
                {
                    cameraRotation = cameraRotation + (new Vector3(1.0f, 0.0f, 0.0f) / Math.Max(2, zoom));
                }
                #endregion

                #region Move Down
                if (IsDisabledControlPressed(0, Controls.Camera.DOWN.KeyIndex))
                {
                    cameraRotation = cameraRotation - (new Vector3(1.0f, 0.0f, 0.0f) / Math.Max(2, zoom));
                }
                #endregion

                #region Move Left
                if (IsDisabledControlPressed(0, Controls.Camera.LEFT.KeyIndex))
                {
                    cameraRotation = cameraRotation + (new Vector3(0.0f, 0.0f, 1.0f) / Math.Max(2, zoom));
                }
                #endregion

                #region Move Right
                if (IsDisabledControlPressed(0, Controls.Camera.RIGHT.KeyIndex))
                {
                    cameraRotation = cameraRotation - (new Vector3(0.0f, 0.0f, 1.0f) / Math.Max(2, zoom));
                }
                #endregion

                #region Center Camera
                if (IsDisabledControlPressed(0, Controls.Camera.CENTER.KeyIndex))
                {
                    cameraRotation = Vector3.Zero;
                }
                #endregion

                #endregion

                #region Drone Heading
                if (IsDisabledControlPressed(0, Controls.Heading.RIGHT.KeyIndex))
                {
                    rotationMomentum = (float) Math.Max(-1.5, rotationMomentum - 0.02);
                }
                else if (IsDisabledControlPressed(0, Controls.Heading.LEFT.KeyIndex))
                {
                    rotationMomentum = (float)Math.Max(1.5, rotationMomentum + 0.02);
                }
                else
                {
                    if (rotationMomentum > 0.0f)
                    {
                        rotationMomentum = (float)Math.Max(0.0, rotationMomentum - 0.04);
                    }
                    else if (rotationMomentum < 0.0f)
                    {
                        rotationMomentum = (float)Math.Max(0.0, rotationMomentum + 0.04);
                    }
                }
                #endregion

                #region Zoom

                #region Zoom Out
                if (IsDisabledControlJustPressed(0, Controls.Zoom.OUT.KeyIndex))
                {
                    zoom = (float)Math.Max(0, zoom - 1);
                    SetCamFov(drone.Camera, 50.0f - (10.0f * zoom));
                }
                #endregion

                #region Zoom In
                if (IsDisabledControlJustPressed(0, Controls.Zoom.IN.KeyIndex))
                {
                    zoom = (float)Math.Max(4, zoom + 1);
                    SetCamFov(drone.Camera, 50.0f - (10.0f * zoom));
                }
                #endregion

                #endregion

                #region Toggle Nightvision
                if (drone.HasNightVision && IsDisabledControlJustPressed(0, Controls.TOGGLE_NIGHTVISION.KeyIndex))
                {
                    SetNightvision(!GetUsingnightvision());
                }
                #endregion

                #region Toggle Infared
                if (drone.HasInfared && IsDisabledControlJustPressed(0, Controls.TOGGLE_INFARED.KeyIndex))
                {
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

                await Delay(0);
            }
        }
        #endregion
    }
}
