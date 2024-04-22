using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerStats
    {
        public static ISteamGameServerStats.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServerStats_v001", CallingConvention = Platform.CC)]
        private static extern ISteamGameServerStats.Instance Accessor();
        /// <summary><code>SteamAPICall_t RequestUserStats( CSteamID steamIDUser );</code><br />
        /// Asynchronously downloads stats and achievements for the specified user from the server.<br />
        /// <br />
        /// These stats will only be auto-updated for clients currently playing on the server. For other users you'll need to call this function again to refresh any data.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#GSStatsReceived_t" class="bb_apilink">GSStatsReceived_t</a> call result.</summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to request the stats for.</param>
        public static SteamAPICall RequestUserStats(SteamId steamIDUser) => Instance.RequestUserStats(steamIDUser);
        /// <summary><code>bool GetUserStat( CSteamID steamIDUser, const char *pchName, int32 *pData );
        /// bool GetUserStat( CSteamID steamIDUser, const char *pchName, float *pData );</code><br />
        /// Gets the current value of the a stat for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.</li></ul></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to get the stat for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> * / float *: The variable to return the stat value into.</param>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary><code>bool GetUserStat( CSteamID steamIDUser, const char *pchName, int32 *pData );
        /// bool GetUserStat( CSteamID steamIDUser, const char *pchName, float *pData );</code><br />
        /// Gets the current value of the a stat for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.</li></ul></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to get the stat for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> * / float *: The variable to return the stat value into.</param>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary><code>bool GetUserAchievement( CSteamID steamIDUser, const char *pchName, bool *pbAchieved );</code><br />
        /// Gets the unlock status of the Achievement.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The 'API Name' of the specified achievement exists in App Admin on the Steamworks website, and the changes are published.</li></ul><br />
        /// If the call is successful then the unlock status is returned via the <code class="bb_code bb_code_inline nohighlight">pbAchieved</code> parameter.</summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to get the achievement for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="pbAchieved">bool *: Returns the unlock status of the achievement.</param>
        public static bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved) => Instance.GetUserAchievement(steamIDUser, pchName, pbAchieved);
        /// <summary><code>bool SetUserStat( CSteamID steamIDUser, const char *pchName, int32 nData );
        /// bool SetUserStat( CSteamID steamIDUser, const char *pchName, float fData );</code><br />
        /// Sets / updates the value of a given stat for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#StoreUserStats" class="bb_apilink">ISteamGameServerStats::StoreUserStats</a>.<br />
        /// <br />
        /// <b>NOTE:</b> These updates will work only on stats that game servers are allowed to edit. If the "Set By" field for this stat is "Official GS" then only game servers that have been declared as officially controlled by you will be able to set it. To do this you must set the IP range of your official servers in the <a href="https://partner.steamgames.com/apps/dedicatedservers/" target="_blank" rel="noreferrer">Dedicated Servers</a> section of App Admin.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback for the specified user.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.<br />
        /// 	</li><li> The stat must be allowed to be set by game server.</li></ul></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to set the stat on.</param>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="nData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> / float: The new value of the stat. This must be an absolute value, it will not increment or decrement for you.</param>
        public static bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int nData) => Instance.SetUserStat(steamIDUser, pchName, nData);
        /// <summary><code>bool SetUserStat( CSteamID steamIDUser, const char *pchName, int32 nData );
        /// bool SetUserStat( CSteamID steamIDUser, const char *pchName, float fData );</code><br />
        /// Sets / updates the value of a given stat for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#StoreUserStats" class="bb_apilink">ISteamGameServerStats::StoreUserStats</a>.<br />
        /// <br />
        /// <b>NOTE:</b> These updates will work only on stats that game servers are allowed to edit. If the "Set By" field for this stat is "Official GS" then only game servers that have been declared as officially controlled by you will be able to set it. To do this you must set the IP range of your official servers in the <a href="https://partner.steamgames.com/apps/dedicatedservers/" target="_blank" rel="noreferrer">Dedicated Servers</a> section of App Admin.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback for the specified user.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.<br />
        /// 	</li><li> The stat must be allowed to be set by game server.</li></ul></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to set the stat on.</param>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="nData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> / float: The new value of the stat. This must be an absolute value, it will not increment or decrement for you.</param>
        public static bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float fData) => Instance.SetUserStat(steamIDUser, pchName, fData);
        /// <summary><code>bool UpdateUserAvgRateStat( CSteamID steamIDUser, const char *pchName, float flCountThisSession, double dSessionLength );</code><br />
        /// Updates an AVGRATE stat with new values for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#StoreUserStats" class="bb_apilink">ISteamGameServerStats::StoreUserStats</a>.<br />
        /// <br />
        /// <b>NOTE:</b> These updates will work only on stats that game servers are allowed to edit. If the "Set By" field for this stat is "Official GS" then only game servers that have been declared as officially controlled by you will be able to set it. To do this you must set the IP range of your official servers in the <a href="https://partner.steamgames.com/apps/dedicatedservers/" target="_blank" rel="noreferrer">Dedicated Servers</a> section of App Admin.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback for the specified user.<br />
        /// 	</li><li> The type must be AVGRATE in the Steamworks Partner backend.<br />
        /// 	</li><li> The stat must be allowed to be set by game server.</li></ul></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to update the AVGRATE stat for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="flCountThisSession">float: The value accumulation since the last call to this function.</param>
        /// <param name="dSessionLength">double: The amount of time in seconds since the last call to this function.</param>
        public static bool UpdateUserAvgRateStat(SteamId steamIDUser, UTF8StringPtr pchName, float flCountThisSession, double dSessionLength) => Instance.UpdateUserAvgRateStat(steamIDUser, pchName, flCountThisSession, dSessionLength);
        /// <summary><code>bool SetUserAchievement( CSteamID steamIDUser, const char *pchName );</code><br />
        /// Unlocks an achievement for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#StoreUserStats" class="bb_apilink">ISteamGameServerStats::StoreUserStats</a>.<br />
        /// <br />
        /// <b>NOTE:</b> This will work only on achievements that game servers are allowed to set. If the "Set By" field for this achievement is "Official GS" then only game servers that have been declared as officially controlled by you will be able to set it. To do this you must set the IP range of your official servers in the <a href="https://partner.steamgames.com/apps/dedicatedservers/" target="_blank" rel="noreferrer">Dedicated Servers</a> section of App Admin.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified achievement "API Name" exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback for the specified user.<br />
        /// 	</li><li> The stat must be allowed to be set by game server.</li></ul></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to unlock the achievement for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the Achievement to unlock.</param>
        public static bool SetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName) => Instance.SetUserAchievement(steamIDUser, pchName);
        /// <summary><code>bool ClearUserAchievement( CSteamID steamIDUser, const char *pchName );</code><br />
        /// Resets the unlock status of an achievement for the specified user.<br />
        /// <br />
        /// This is primarily only ever used for testing.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#StoreUserStats" class="bb_apilink">ISteamGameServerStats::StoreUserStats</a>.<br />
        /// <br />
        /// <b>NOTE:</b> This will work only on achievements that game servers are allowed to set. If the "Set By" field for this achievement is "Official GS" then only game servers that have been declared as officially controlled by you will be able to set it. To do this you must set the IP range of your official servers in the <a href="https://partner.steamgames.com/apps/dedicatedservers/" target="_blank" rel="noreferrer">Dedicated Servers</a> section of App Admin.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified achievement "API Name" exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> has completed and successfully returned its callback for the specified user.<br />
        /// 	</li><li> The stat must be allowed to be set by game server.</li></ul></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to clear the achievement for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the Achievement to reset.</param>
        public static bool ClearUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName) => Instance.ClearUserAchievement(steamIDUser, pchName);
        /// <summary><code>SteamAPICall_t StoreUserStats( CSteamID steamIDUser );</code><br />
        /// Send the changed stats and achievements data to the server for permanent storage for the specified user.<br />
        /// <br />
        /// If this fails then nothing is sent to the server. It's advisable to keep trying until the call is successful.<br />
        /// <br />
        /// This call can be rate limited. Call frequency should be on the order of minutes, rather than seconds. You should only be calling this during major state changes such as the end of a round, the map changing, or the user leaving a server.<br />
        /// <br />
        /// If you have stats or achievements that you have saved locally but haven't uploaded with this function when your application process ends then this function will automatically be called.<br />
        /// <br />
        /// You can find additional debug information written to the <code class="bb_code bb_code_inline nohighlight">%steam_install%\logs\stats_log.txt</code> file.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#GSStatsStored_t" class="bb_apilink">GSStatsStored_t</a> call result.<br />
        /// If <code class="bb_code bb_code_inline nohighlight">m_eResult</code> has a result of <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a>, then one or more stats uploaded has been rejected, either because they broke constraints or were out of date. In this case the server sends back updated values and the stats should be updated locally to keep in sync.</summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to store the stats of.</param>
        public static SteamAPICall StoreUserStats(SteamId steamIDUser) => Instance.StoreUserStats(steamIDUser);
    }
}