using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
