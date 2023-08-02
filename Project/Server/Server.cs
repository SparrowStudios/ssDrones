using static CitizenFX.Core.Native.API;
using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SparrowStudios.Fivem.ssDrones.Constants;

namespace SparrowStudios.Fivem.ssDrones.Server
{
    public class Server : BaseScript
    {
        #region Variables
        #endregion

        public Server()
        {

        }

        #region Ticks
        #endregion

        #region Commands
        [Command(Commands.DRONE)]
        private void OnCommandDrone([FromSource] Player sender, string[] args)
        {
            sender.TriggerEvent(Events.Client.DRONE_COMMAND, string.Join(" ", args));
        }
        #endregion

        #region Event Handlers
        #endregion

        #region Functions
        /// <summary>
        /// Logs a message to the console
        /// </summary>
        /// <param name="message">The message to log</param>
        public static void Log(string message) => Debug.WriteLine($"[{GetCurrentResourceName()}] LOG: {message}");
        #endregion
    }
}
