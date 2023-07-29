#region FiveM Mono v2 Server Using Statements
using CitizenFX.Core;
using CitizenFX.Server; // FiveM game related types (server only)
using CitizenFX.Server.Native; // Server natives (server only)
using CitizenFX.Shared.Native; // Shared natives (there for shared libraries)
using static CitizenFX.Server.Native.Natives;
using SharedNatives = CitizenFX.Shared.Native.Natives;
#endregion

using System.Linq;

namespace SparrowStudios.Fivem.Common.Server
{
    public class SSServerScript : BaseScript
    {
        /// <summary>
        /// Logs a message to the console
        /// </summary>
        /// <param name="message">The message to log</param>
        public static void Log(string message) => Debug.WriteLine($"[{GetCurrentResourceName()}] LOG: {message}");

        /// <summary>
        /// [BEST] - Gets the R* license identifier (Social Club account)
        /// </summary>
        /// <param name="p">Player to get the identifier for.</param>
        /// <returns>String of the license identifier, if present, or an empty string</returns>
        public static string GetLicenseId(Player p) => GetId(p, "license:");

        /// <summary>
        /// [GOOD] - Gets the Discord identifier. Discord must be open and FiveM must be authorized.
        /// </summary>
        /// <param name="p">Player to get the identifier for.</param>
        /// <returns>String of the Discord identifier, if present, or an empty string</returns>
        public static string GetDiscordId(Player p) => GetId(p, "discord:");

        /// <summary>
        /// [POOR] - Gets the Steam identifier. Steam must be open.
        /// </summary>
        /// <param name="p">Player to get the identifier for.</param>
        /// <returns>String of the Steam identifier, if present, or an empty string</returns>
        public static string GetSteamId(Player p) => GetId(p, "steam:");

        /// <summary>
        /// [GOOD] - Gets the Xbox Live identifier. Xbox Live account must be actived.
        /// </summary>
        /// <param name="p">Player to get the identifier for.</param>
        /// <returns>String of the Xbox Live identifier, if present, or an empty string</returns>
        public static string GetXblId(Player p) => GetId(p, "xbl:");

        /// <summary>
        /// [GOOD] - Gets the Xbox identifier. Xbox App must be logged in.
        /// Unknown if the Xbox app must be running. Also known as the Passport Unique Identifier (Xbox account without Xbox Live activated)
        /// </summary>
        /// <param name="p">Player to get the identifier for.</param>
        /// <returns>String of the Xbox identifier, if present, or an empty string</returns>
        public static string GetLiveId(Player p) => GetId(p, "live:");

        private static string GetId(Player p, string idPrefix)
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

        public static bool DoesPlayerHaveAce(Player player, string permission)
        {
            return IsPlayerAceAllowed(player.Handle.ToString(), permission);
        }
    }
}
