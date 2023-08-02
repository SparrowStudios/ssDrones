using static CitizenFX.Core.Native.API;
using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
