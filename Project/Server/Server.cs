// ssDrones (https://github.com/SparrowStudios/ssDrones)
// Author: Jacob Paulin (JayPaulinCodes)
// Created: Jul 29 2023
// Updated: Aug 7 2023
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using CitizenFX.Core;
using System;
using static CitizenFX.Core.Native.API;
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
        [EventHandler(Events.Server.LOG)]
        private void OnEventLog(string msg) => Log(msg);
        #endregion

        #region Functions
        /// <summary>
        /// Logs a message to the console
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Log(string message) => Debug.WriteLine($"[{GetCurrentResourceName()}] LOG: {message}");
        #endregion
    }
}
