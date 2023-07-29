#region FiveM Mono v2 Client Using Statements
using CitizenFX.Core;
using CitizenFX.FiveM; // FiveM game related types (client only)
using CitizenFX.FiveM.Native; // FiveM natives (client only)
using CitizenFX.Shared.Native; // Shared natives (there for shared libraries)
using SharedNatives = CitizenFX.Shared.Native.Natives;
using static CitizenFX.FiveM.Native.Natives;
#endregion

using SparrowStudios.Fivem.Common.Models;
using SparrowStudios.Fivem.Common.Client.Models;

using System.Threading.Tasks;

namespace SparrowStudios.Fivem.Common.Client
{
    public class SSClientScript : BaseScript
    {
        /// <summary>
        /// Logs a message to the console
        /// </summary>
        /// <param name="message">The message to log</param>
        public static void Log(string message) => Debug.WriteLine($"[{GetCurrentResourceName()}] LOG: {message}");

        /// <summary>
        /// Gets the local player's Player
        /// </summary>
        public static Player ClientPlayer => Game.Player;

        /// <summary>
        /// Gets the local player's Character
        /// </summary>
        public static Ped ClientPed => Game.PlayerPed;

        /// <summary>
        /// Gets the local player's current vehicle
        /// </summary>
        public static Vehicle ClientCurrentVehicle => ClientPed?.CurrentVehicle;

        /// <summary>
        /// Gets the local player's current vehicle if they are in one, otherwise the last vehicle they were in
        /// </summary>
        public static Vehicle ClientLastVehicle => ClientPed?.LastVehicle;

        /// <summary>
        /// This function should be called when the client wants/needs to network a network ID.
        /// </summary>
        public static void SetNetworkIdNetworked(int netId)
        {
            SetNetworkIdExistsOnAllMachines(netId, true);
            SetNetworkIdCanMigrate(netId, true);
        }

        /// <summary>
        /// `.FromNetworkId()` but with extra checks and option to request control.
        /// </summary>
        /// <param name="networkId">Network ID of entity</param>
        /// <param name="networkControl">If you want to request control</param>
        /// <returns>Entity or null</returns>
        public static async Task<Entity> GetEntityFromNetwork(int networkId, bool networkControl = true)
        {
            if (networkId == 0 || !NetworkDoesNetworkIdExist(networkId))
            {
                Debug.WriteLine($"Could not request network ID {networkId} because it does not exist!");
                return null;
            }

            if (networkControl)
            {
                int timeout = 0;
                while (!NetworkHasControlOfNetworkId(networkId) && timeout < 4)
                {
                    timeout++;
                    NetworkRequestControlOfNetworkId(networkId);
                    await Delay(500);
                }

                if (!NetworkHasControlOfNetworkId(networkId))
                {
                    Debug.WriteLine($"Could not request control of network ID {networkId}.");
                    return null;
                }
            }

            return Entity.FromNetworkId(networkId);
        }

        #region HUD Class
        public static class Hud
        {
            /// <summary>
            /// Should be called every frame to draw text on the screen.
            /// </summary>
            /// <param name="x">X location of text.</param>
            /// <param name="y">Y location of text.</param>
            /// <param name="scale">Size of text.</param>
            public static void DrawText2D(float x, float y, float scale, string text, int r, int g, int b, int a, Alignment alignment = Alignment.Left)
            {
                Minimap anchor = MinimapAnchor.GetMinimapAnchor();
                x = anchor.X + (anchor.Width * x);
                y = anchor.Y - y;
                
                SetTextFont(4);
                SetTextProportional(false);
                SetTextScale(scale, scale);
                SetTextColour(r, g, b, a);
                SetTextDropshadow(0, 0, 0, 0, 255);
                SetTextEdge(2, 0, 0, 0, 255);
                SetTextDropShadow();
                SetTextOutline();

                if (alignment == Alignment.Center)
                {
                    SetTextJustification(0);
                }
                else if (alignment == Alignment.Right)
                {
                    SetTextWrap(0, x);
                    SetTextJustification(2);
                }

                SetTextEntry("STRING");
                AddTextComponentString(text);
                DrawText(x, y);
            }

            /// <summary>
            /// Should be called every frame to draw text in the game world.
            /// </summary>
            /// <param name="pos">Location of text in the game world.</param>
            /// <param name="drawBackground">If a black box should be drawn behind the text to give it more contrast.</param>
            /// <param name="font">The font type to use for the text.</param>
            public static void DrawText3D(Vector3 pos, string text, bool drawBackground = true, int font = 4)
            {
                float screenX = 0f, screenY = 0f;
                World3dToScreen2d(pos.X, pos.Y, pos.Z, ref screenX, ref screenY);

                SetTextScale(0.35f, 0.35f);
                SetTextFont(font);
                SetTextProportional(true);
                SetTextColour(255, 255, 255, 215);
                SetTextEntry("STRING");
                SetTextCentre(true);
                AddTextComponentString(text);
                DrawText(screenX, screenY);
                if (drawBackground)
                {
                    DrawRect(screenX, screenY + 0.0125f, (float)text.Length / 300, 0.03f, 41, 11, 41, 68);
                }
            }

            public static void DrawImageNotification(string picture, int icon, string title, string subtitle, string message)
            {
                SetNotificationTextEntry("STRING");
                AddTextComponentString(message);
                SetNotificationMessage(picture, picture, true, icon, title, subtitle);
            }

            public static void DrawRect(float x, float y, float width, float height, int r, int g, int b, int a)
            {
                Minimap anchor = MinimapAnchor.GetMinimapAnchor();
                DrawRect(anchor.LeftX + x + (width / 2), anchor.BottomY - y + (height / 2), width, height, r, g, b, a);
            }

            /// <summary>
            /// Show a chat message to the client.
            /// </summary>
            public static void DisplayChatMessage(string text) => Events.TriggerEvent("chat:addMessage", text);

            /// <summary>
            /// Returns if the HUD is hidden.
            /// </summary>
            public static bool IsHudHidden => IsHudHidden();

            /// <summary>
            /// Returns if the Radar is hidden.
            /// </summary>
            public static bool IsRadarHidden => IsRadarHidden();
        }
        #endregion
    }
}
