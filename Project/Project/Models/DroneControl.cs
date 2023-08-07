// ssDrones (https://github.com/SparrowStudios/ssDrones)
// Author: Jacob Paulin (JayPaulinCodes)
// Created: Jul 29 2023
// Updated: Aug 7 2023
// 
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace SparrowStudios.Fivem.ssDrones.Models
{
    public class DroneControl
    {
        public string Label { get; set; }
        public int KeyIndex { get; set; }
        
        public DroneControl(string label, int keyIndex)
        {
            Label = label;
            KeyIndex = keyIndex;
        }
    }
}
