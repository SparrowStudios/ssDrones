#region FiveM Mono v2 Server Using Statements
using CitizenFX.Core;
using CitizenFX.Server; // FiveM game related types (server only)
using CitizenFX.Server.Native; // Server natives (server only)
using CitizenFX.Shared.Native; // Shared natives (there for shared libraries)
using static CitizenFX.Server.Native.Natives;
using SharedNatives = CitizenFX.Shared.Native.Natives;
#endregion

namespace SparrowStudios.Fivem.Common.Server
{
    public static class Extensions
    {
        #region Player Extensions
        /// <summary>
        /// [BEST] - Get the R* identified of this player. Also known as the Social Club identifier.
        /// </summary>
        /// <param name="player"></param>
        /// <returns>String of the R* identifier, if present, or an empty string.</returns>
        public static string GetLicenseId(this Player player) => SSServerScript.GetLicenseId(player);

        /// <summary>
        /// [GOOD] - Get the Discord identified of this player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns>String of the Discord identifier, if present, or an empty string.</returns>
        public static string GetDiscordId(this Player player) => SSServerScript.GetDiscordId(player);

        /// <summary>
        /// [POOR] - Get the Steam identified of this player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns>String of the Steam identifier, if present, or an empty string.</returns>
        public static string GetSteamId(this Player player) => SSServerScript.GetSteamId(player);

        /// <summary>
        /// [BETTER] - Get the Xbox Live identified of this player. Xbox Live account must be actived.
        /// </summary>
        /// <param name="player"></param>
        /// <returns>String of the Xbox Live identifier, if present, or an empty string.</returns>
        public static string GetXblId(this Player player) => SSServerScript.GetXblId(player);

        /// <summary>
        /// [BETTER] - Gets the Xbox identifier of this player. Xbox App must be logged in.
        /// Unknown if the Xbox app must be running. Also known as the Passport Unique Identifier (Xbox account without Xbox Live activated)
        /// </summary>
        /// <param name="player"></param>
        /// <returns>String of the Xbox Live identifier, if present, or an empty string.</returns>
        public static string GetLiveId(this Player player) => SSServerScript.GetLiveId(player);

        /// <summary>
        /// Checks if the player has a specified permission.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="permission">Ace permission string</param>
        /// <returns>Boolean of the permission state</returns>
        public static bool HasAce(this Player player, string permission) => SSServerScript.DoesPlayerHaveAce(player, permission);
        #endregion
    }
}
