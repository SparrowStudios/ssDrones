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

namespace SparrowStudios.Fivem.ssDrones.Client
{
    public class V3Utils
    {
        public static float SqrMagnitude(Vector3 value)
            => value.X * value.X + value.Y * value.Y + value.Z * value.Z;

        public static float Magnitude(Vector3 value)
            => (float) Math.Sqrt(value.X * value.X + value.Y * value.Y + value.Z * value.Z);

        public static Vector3 Div(Vector3 value, float div)
            => new Vector3(value.X / div, value.Y / div, value.Z / div);

        public static Vector3 Mul(Vector3 value, float mul)
            => value * mul;

        public static Vector3 SetNormalize(Vector3 value)
        {
            float num = Magnitude(value);

            if (num == 1)
            {
                return value;
            }
            else if (num > 1e-5)
            {
                value = Div(value, num);
            }
            else
            {
                value = Vector3.Zero;
            }
            
            return value;
        }

        public static Vector3 ClampMagnitude(Vector3 value, float max)
        {
            if (SqrMagnitude(value) > max * max)
            {
                value = SetNormalize(value);
                value = Mul(value, max);
            }

            return value;
        }
    }
}
