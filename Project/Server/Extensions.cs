using static CitizenFX.Core.Native.API;
using CitizenFX.Core;
using System.Linq;

namespace SparrowStudios.Fivem.ssDrones.Server
{
    public static class Extensions
    {
        #region Supporting Functions
        #endregion

        #region Player Extensions
        public static string GetId(this Player p, string idPrefix)
        {
            string id = "";
            if (p != null && p.Identifiers != null)
            {
                id = p.Identifiers.Where(x => x.StartsWith(idPrefix))
                    .Select(x => x.Replace(idPrefix, "")).FirstOrDefault();

                if (string.IsNullOrWhiteSpace(id))
                {
                    id = "";
                }
            }

            return id;
        }
        public static string GetLicenseId(this Player player) => player.GetId("license:");
        public static string GetDiscordId(this Player player) => player.GetId("discord:");
        public static string GetSteamId(this Player player) => player.GetId("steam:");
        public static string GetXblId(this Player player) => player.GetId("xbl:");
        public static string GetLiveId(this Player player) => player.GetId("live:");
        public static bool HasAce(this Player player, string permission) => IsPlayerAceAllowed(player.Handle.ToString(), permission);
        #endregion
    }
}
