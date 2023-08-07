// ssDrones (https://github.com/SparrowStudios/ssDrones)
// Author: Jacob Paulin (JayPaulinCodes)
// Created: Jul 29 2023
// Updated: Aug 7 2023
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparrowStudios.Fivem.ssDrones.Models
{
    public class DroneBuilder
    {
        private Drone _drone = new Drone();

        public DroneBuilder()
        {
            this.Reset();
        }

        #region Methods
        public void Reset() 
            => this._drone = new Drone();

        public Drone Build()
        {
            Drone drone = this._drone;
            this.Reset();
            return drone;
        }

        public DroneBuilder SetName(string name)
        {
            this._drone.Name = name;
            return this;
        }

        public DroneBuilder SetModel(string model)
        {
            this._drone.Model = model;
            return this;
        }

        public DroneBuilder SetInfared(bool hasInfared)
        {
            this._drone.HasInfared = hasInfared;
            return this;
        }

        public DroneBuilder EnableInfared() 
            => this.SetInfared(true);

        public DroneBuilder DisableInfared() 
            => this.SetInfared(false);

        public DroneBuilder SetNightVision(bool hasNightVision)
        {
            this._drone.HasNightVision = hasNightVision;
            return this;
        }

        public DroneBuilder EnableNightVision()
            => this.SetNightVision(true);

        public DroneBuilder DisableNightVision()
            => this.SetNightVision(false);

        public DroneBuilder SetSpeed(float speed)
        {
            this._drone.Speed = speed;
            return this;
        }

        public DroneBuilder SetAgility(float agility)
        {
            this._drone.Agility = agility;
            return this;
        }

        public DroneBuilder SetRange(float range)
        {
            this._drone.Range = range;
            return this;
        }
        #endregion
    }
}
