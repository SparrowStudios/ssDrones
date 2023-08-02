using static CitizenFX.Core.Native.API;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.UI;

namespace SparrowStudios.Fivem.ssDrones.Client
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
    }
}
