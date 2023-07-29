#region FiveM Mono v2 Client Using Statements
using CitizenFX.Core;
using CitizenFX.FiveM; // FiveM game related types (client only)
using CitizenFX.FiveM.Native; // FiveM natives (client only)
using CitizenFX.Shared.Native; // Shared natives (there for shared libraries)
using SharedNatives = CitizenFX.Shared.Native.Natives;
using static CitizenFX.FiveM.Native.Natives;
#endregion

using System;
using System.Threading.Tasks;

namespace SparrowStudios.Fivem.Common.Client
{
    public static class Extensions
    {
        #region Entity Extensions
        /// <summary>
        /// Corrects the entity's heading so that 90 degrees equals East, and 270 degrees equals West.
        /// This fixes the issue from Rockstar where 90 degrees was West, and 270 degrees was East.
        /// </summary>
        public static float CorrectHeading(this Entity e)
        {
            float hdg = 360 - e.Heading;
            if (hdg > 360)
            {
                hdg -= 360;
            }
            return hdg;
        }

        /// <summary>
        /// Get the street and cross street at the entity. If there is no cross street, an empty string is used.
        /// </summary>
        public static string[] GetStreetAndCrossAtEntityPosition(this Entity e) => GetStreetAndCrossAtCoords(e.Position);

        /// <summary>
        /// Get the street and cross street at the entity. If no cross street exists, just the primary street is returned.
        /// <param name="separator">The string used to separate the primary and cross street.</param>
        /// </summary>
        public static string GetStreetAndCrossWholeAtEntityPosition(this Entity e, string separator) => GetStreetAndCrossWholeAtCoords(e.Position, separator);

        /// <summary>
        /// Sets the specified entity as networked so it may be controlled by any client, not just the host.
        /// <param name="canMigrate">If the entity's control can move between clients.</param>
        /// </summary>
        public static async void Network(this Entity e)
        {
            if (!Entity.Exists(e))
            {
                Debug.WriteLine("Failed to network entity, entity does not exist!");
                return;
            }

            int start = Game.GameTime;
            while (!NetworkGetEntityIsNetworked(e.Handle) && (Game.GameTime - start) < 5000)
            {
                NetworkRegisterEntityAsNetworked(e.Handle);
                await BaseScript.Delay(100);
            }

            int netId = e.NetworkId;
            SSClientScript.SetNetworkIdNetworked(netId);

            Debug.WriteLine($"Got network ID {netId} from entity ID {e.Handle}");
        }

        /// <summary>
        /// Get the speed of the entity in mph or kmh.
        /// <param name="units">The units to convert the speed into. Either mph or kmh.</param>
        /// </summary>
        public static float Speed(this Entity entity, string units = "mph") =>
            units == "mph" ? GetEntitySpeed(entity.Handle) * 2.236936f : (units == "kmh" ? GetEntitySpeed(entity.Handle) * 3.6f : 0f);

        public static async Task RequestControl(this Entity entity)
        {
            NetworkRequestControlOfEntity(entity.Handle);
            int timeout = 4;
            while (!NetworkHasControlOfEntity(entity.Handle) && timeout > 0)
            {
                await BaseScript.Delay(250);
                timeout--;
            }

            if (!NetworkHasControlOfEntity(entity.Handle))
            {
                Debug.WriteLine("unable to get control of entity");
            }
        }
        #endregion

        #region Ped Extensions
        /// <summary>
        /// Determine if a ped can do an action (meaning not cuffed, dead, stunned, etc.)
        /// </summary>
        /// <param name="ped">The ped to check against</param>
        /// <returns></returns>
        public static bool CannotDoAction(this Ped ped) => DecorGetBool(ped.Handle, "IsDead") || ped.IsCuffed || ped.IsDead || ped.IsBeingStunned || ped.IsClimbing || ped.IsDiving || ped.IsFalling || ped.IsGettingIntoAVehicle || ped.IsJumping || ped.IsJumpingOutOfVehicle || ped.IsRagdoll || ped.IsSwimmingUnderWater || ped.IsVaulting;

        /// <summary>
        /// Gets the closest vehicle entity to the ped with a restricting radius.
        /// </summary>
        /// <param name="limitRadius">Maximum radius to search for a vehicle entity.</param>
        public static Vehicle GetClosestVehicleToPed(this Ped ped, float limitRadius = 2.0f)
        {
            // Create a raycast to find the closest vehicle in a radius around the client
            Vector3 pos = ped.Position;
            RaycastResult raycast = World.RaycastCapsule(pos, pos, limitRadius, (IntersectOptions)10, ped);

            // Ensure that the raycast hit a vehicle
            return raycast.DitHitEntity && Entity.Exists(raycast.HitEntity) && raycast.HitEntity.Model.IsVehicle
                ? (Vehicle)raycast.HitEntity
                : null;
        }
        #endregion

        #region Vector3 Extensions
        /// <summary>
        /// Get the distance in units between two points, taking the Z-axis into consideration.
        /// <param name="v2">The second point.</param>
        /// </summary>
        public static float DistanceTo(this Vector3 v1, Vector3 v2) => CalculateDistanceTo(v1, v2, true);

        /// <summary>
        /// Get the distance in units between two points.
        /// <param name="v2">The second point.</param>
        /// </summary>
        public static float DistanceTo2D(this Vector3 v1, Vector3 v2) => CalculateDistanceTo(v1, v2, false);

        private static float CalculateDistanceTo(Vector3 v1, Vector3 v2, bool useZ)
        {
            if (useZ)
            {
                return (float)Math.Sqrt(v1.DistanceToSquared(v2));
            }
            else
            {
                return (float)Math.Sqrt(Math.Pow(v2.X - v1.X, 2) + Math.Pow(v2.Y - v1.Y, 2));
            }
        }

        /// <summary>
        /// Get the street and cross street at the position. If there is no cross street, an empty string is use.
        /// </summary>
        public static string[] GetStreetAndCrossAtCoords(this Vector3 pos)
        {
            Vector3 outpos = Vector3.Zero;
            GetNthClosestVehicleNode(pos.X, pos.Y, pos.Z, 0, ref outpos, 0, 0, 0);
            uint crossing = 1;
            uint p1 = 1;
            GetStreetNameAtCoord(pos.X, pos.Y, pos.Z, ref p1, ref crossing);
            string crossName = GetStreetNameFromHashKey(crossing);
            string suffix = (crossName != "" && crossName != "NULL" && crossName != null) ? crossName : "";

            return new string[] { World.GetStreetName(pos), suffix };
        }

        /// <summary>
        /// Get the street and cross street at the position. If no cross street exists, just the primary street is returned.
        /// <param name="separator">The string used to separate the primary and cross street.</param>
        /// </summary>
        public static string GetStreetAndCrossWholeAtCoords(this Vector3 pos, string separator)
        {
            string[] text = GetStreetAndCrossAtCoords(pos);
            return text[1] == "" ? text[0] : string.Join(separator, GetStreetAndCrossAtCoords(pos));
        }
        #endregion
    }
}
