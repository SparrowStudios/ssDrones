// ssDrones (https://github.com/SparrowStudios/ssDrones)
// Author: Jacob Paulin (JayPaulinCodes)
// Created: Jul 29 2023
// Updated: Aug 7 2023
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparrowStudios.Fivem.ssDrones.Models
{
    public class Drone
    {
        #region Properties
        /// <summary>
        /// The name of the drone
        /// </summary>
        public string Name { get; set; } = "Basit Drone";

        /// <summary>
        /// The model name of the drone
        /// </summary>
        public string Model { get; set; } = "ch_prop_casino_drone_02a";

        /// <summary>
        /// Wether or not the drone has infared vision
        /// </summary>
        public bool HasInfared { get; set; } = false;

        /// <summary>
        /// Wether or not the drone has night vision
        /// </summary>
        public bool HasNightVision { get; set; } = false;

        /// <summary>
        /// The maximum speed multipler the drone has
        /// </summary>
        public float Speed { get; set; } = 1.0f;

        /// <summary>
        /// The acceleration & deceleration multiplier
        /// </summary>
        public float Agility { get; set; } = 1.0f;

        /// <summary>
        /// How far from the controler the drone can be
        /// </summary>
        public float Range { get; set; } = 250.0f;
        
        
        public int Handle { get; set; }
        public int NetId { get; set; }
        public int SoundId { get; set; }
        public int Camera { get; set; }
        public int DroneScaleform { get; set; }
        public int ControlsScaleform { get; set; }
        #endregion
    }
}
