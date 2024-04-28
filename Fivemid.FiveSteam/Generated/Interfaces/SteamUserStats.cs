using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamUserStats
    {
        public static ISteamUserStats.Instance Instance => Accessor();

        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamUserStats_v012", CallingConvention = Platform.CC)]
        private static extern ISteamUserStats.Instance Accessor();
        /// <summary><code>bool RequestCurrentStats();</code>Asynchronously request the user's current stats and achievements from the server.<br />
        /// <br />
        /// You must always call this first to get the initial status of stats and achievements.<br />
        /// Only after the resulting callback comes back can you start calling the rest of the stats and achievement functions for the current user.<br />
        /// <br />
        /// The equivalent function for other users is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserStatsReceived_t" class="bb_apilink">UserStatsReceived_t</a> callback.<br />
        /// Only returns <b>false</b> if there is no user logged in; otherwise, <b>true</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetStat" class="bb_apilink">ISteamUserStats::GetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetStat" class="bb_apilink">ISteamUserStats::SetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetAchievement" class="bb_apilink">ISteamUserStats::SetAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a></summary>
        /// 
        public static bool RequestCurrentStats() => Instance.RequestCurrentStats();
        /// <summary><code>bool GetStat( const char *pchName, int32 *pData );
        /// bool GetStat( const char *pchName, float *pData );</code><br />
        /// Gets the current value of the a stat for the current user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// To receive stats for other users use <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserStat" class="bb_apilink">ISteamUserStats::GetUserStat</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetStat" class="bb_apilink">ISteamUserStats::SetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UpdateAvgRateStat" class="bb_apilink">ISteamUserStats::UpdateAvgRateStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ResetAllStats" class="bb_apilink">ISteamUserStats::ResetAllStats</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> * / float *: The variable to return the stat value into.</param>
        public static bool GetStat(UTF8StringPtr pchName, int* pData) => Instance.GetStat(pchName, pData);
        /// <summary><code>bool GetStat( const char *pchName, int32 *pData );
        /// bool GetStat( const char *pchName, float *pData );</code><br />
        /// Gets the current value of the a stat for the current user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// To receive stats for other users use <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserStat" class="bb_apilink">ISteamUserStats::GetUserStat</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetStat" class="bb_apilink">ISteamUserStats::SetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UpdateAvgRateStat" class="bb_apilink">ISteamUserStats::UpdateAvgRateStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ResetAllStats" class="bb_apilink">ISteamUserStats::ResetAllStats</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> * / float *: The variable to return the stat value into.</param>
        public static bool GetStat(UTF8StringPtr pchName, float* pData) => Instance.GetStat(pchName, pData);
        /// <summary><code>bool SetStat( const char *pchName, int32 nData );
        /// bool SetStat( const char *pchName, float fData );</code><br />
        /// Sets / updates the value of a given stat for the current user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. Doing so allows Steam to persist the changes even in the event of a game crash or unexpected shutdown.<br />
        /// To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>.<br />
        /// <br />
        /// If this is returning false and everything appears correct, then check to ensure that your changes in the App Admin panel of the Steamworks website are published.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetStat" class="bb_apilink">ISteamUserStats::GetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UpdateAvgRateStat" class="bb_apilink">ISteamUserStats::UpdateAvgRateStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ResetAllStats" class="bb_apilink">ISteamUserStats::ResetAllStats</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="nData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> / float: The new value of the stat. This must be an absolute value, it will not increment or decrement for you.</param>
        public static bool SetStat(UTF8StringPtr pchName, int nData) => Instance.SetStat(pchName, nData);
        /// <summary><code>bool SetStat( const char *pchName, int32 nData );
        /// bool SetStat( const char *pchName, float fData );</code><br />
        /// Sets / updates the value of a given stat for the current user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. Doing so allows Steam to persist the changes even in the event of a game crash or unexpected shutdown.<br />
        /// To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>.<br />
        /// <br />
        /// If this is returning false and everything appears correct, then check to ensure that your changes in the App Admin panel of the Steamworks website are published.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type passed to this function must match the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetStat" class="bb_apilink">ISteamUserStats::GetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UpdateAvgRateStat" class="bb_apilink">ISteamUserStats::UpdateAvgRateStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ResetAllStats" class="bb_apilink">ISteamUserStats::ResetAllStats</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="nData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> / float: The new value of the stat. This must be an absolute value, it will not increment or decrement for you.</param>
        public static bool SetStat(UTF8StringPtr pchName, float fData) => Instance.SetStat(pchName, fData);
        /// <summary><code>bool UpdateAvgRateStat( const char *pchName, float flCountThisSession, double dSessionLength );</code><br />
        /// Updates an AVGRATE stat with new values.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state and is very cheap. Doing so allows Steam to persist the changes even in the event of a game crash or unexpected shutdown.<br />
        /// To submit the stats to the server you must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>.<br />
        /// <br />
        /// If this is returning false and everything appears correct, then check to ensure that your changes in the App Admin panel of the Steamworks website are published.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type must be AVGRATE in the Steamworks Partner backend.</li></ul></summary>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="flCountThisSession">float: The value accumulation since the last call to this function.</param>
        /// <param name="dSessionLength">double: The amount of time in seconds since the last call to this function.</param>
        public static bool UpdateAvgRateStat(UTF8StringPtr pchName, float flCountThisSession, double dSessionLength) => Instance.UpdateAvgRateStat(pchName, flCountThisSession, dSessionLength);
        /// <summary><code>bool GetAchievement( const char *pchName, bool *pbAchieved );</code><br />
        /// Gets the unlock status of the Achievement.<br />
        /// <br />
        /// The equivalent function for other users is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievement" class="bb_apilink">ISteamUserStats::GetUserAchievement</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The 'API Name' of the specified achievement exists in App Admin on the Steamworks website, and the changes are published.</li></ul><br />
        /// If the call is successful then the unlock status is returned via the <code class="bb_code bb_code_inline nohighlight">pbAchieved</code> parameter.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementDisplayAttribute" class="bb_apilink">ISteamUserStats::GetAchievementDisplayAttribute</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementName" class="bb_apilink">ISteamUserStats::GetAchievementName</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementIcon" class="bb_apilink">ISteamUserStats::GetAchievementIcon</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetAchievementAndUnlockTime</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAchievedPercent" class="bb_apilink">ISteamUserStats::GetAchievementAchievedPercent</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="pbAchieved">bool *: Returns the unlock status of the achievement.</param>
        public static bool GetAchievement(UTF8StringPtr pchName, bool* pbAchieved) => Instance.GetAchievement(pchName, pbAchieved);
        /// <summary><code>bool SetAchievement( const char *pchName );</code><br />
        /// Unlocks an achievement.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// You can unlock an achievement multiple times so you don't need to worry about only setting achievements that aren't already set. This call only modifies Steam's in-memory state so it is quite cheap. To send the unlock status to the server and to trigger the Steam overlay notification you must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified achievement "API Name" exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ResetAllStats" class="bb_apilink">ISteamUserStats::ResetAllStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetAchievementAndUnlockTime</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievement" class="bb_apilink">ISteamUserStats::GetAchievement</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the Achievement to unlock.</param>
        public static bool SetAchievement(UTF8StringPtr pchName) => Instance.SetAchievement(pchName);
        /// <summary><code>bool ClearAchievement( const char *pchName );</code><br />
        /// Resets the unlock status of an achievement.<br />
        /// <br />
        /// This is primarily only ever used for testing.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// This call only modifies Steam's in-memory state so it is quite cheap. To send the unlock status to the server and to trigger the Steam overlay notification you must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified achievement "API Name" exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ResetAllStats" class="bb_apilink">ISteamUserStats::ResetAllStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetAchievementAndUnlockTime</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievement" class="bb_apilink">ISteamUserStats::GetAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetAchievement" class="bb_apilink">ISteamUserStats::SetAchievement</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the Achievement to reset.</param>
        public static bool ClearAchievement(UTF8StringPtr pchName) => Instance.ClearAchievement(pchName);
        /// <summary><code>bool GetAchievementAndUnlockTime( const char *pchName, bool *pbAchieved, uint32 *punUnlockTime );</code><br />
        /// Gets the achievement status, and the time it was unlocked if unlocked.<br />
        /// <br />
        /// If the return value is true, but the unlock time is zero, that means it was unlocked before Steam began tracking achievement unlock times (December 2009). The time is provided in Unix epoch format, seconds since January 1, 1970 UTC.<br />
        /// <br />
        /// The equivalent function for other users is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetUserAchievementAndUnlockTime</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The 'API Name' of the specified achievement exists in App Admin on the Steamworks website, and the changes are published.</li></ul><br />
        /// If the call is successful then the achieved status and unlock time are provided via the arguments <code class="bb_code bb_code_inline nohighlight">pbAchieved</code> and <code class="bb_code bb_code_inline nohighlight">punUnlockTime</code>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievement" class="bb_apilink">ISteamUserStats::GetAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementDisplayAttribute" class="bb_apilink">ISteamUserStats::GetAchievementDisplayAttribute</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementName" class="bb_apilink">ISteamUserStats::GetAchievementName</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementIcon" class="bb_apilink">ISteamUserStats::GetAchievementIcon</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="pbAchieved">bool *: Returns whether the current user has unlocked the achievement.</param>
        /// <param name="punUnlockTime"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the time that the achievement was unlocked; if pbAchieved is true.</param>
        public static bool GetAchievementAndUnlockTime(UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime) => Instance.GetAchievementAndUnlockTime(pchName, pbAchieved, punUnlockTime);
        /// <summary><code>bool StoreStats();</code>Send the changed stats and achievements data to the server for permanent storage.<br />
        /// <br />
        /// If this fails then nothing is sent to the server. It's advisable to keep trying until the call is successful.<br />
        /// <br />
        /// This call can be rate limited. Call frequency should be on the order of minutes, rather than seconds. You should only be calling this during major state changes such as the end of a round, the map changing, or the user leaving a server. This call is required to display the achievement unlock notification dialog though, so if you have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetAchievement" class="bb_apilink">ISteamUserStats::SetAchievement</a> then it's advisable to call this soon after that.<br />
        /// <br />
        /// If you have stats or achievements that you have saved locally but haven't uploaded with this function when your application process ends then this function will automatically be called.<br />
        /// <br />
        /// You can find additional debug information written to the <code class="bb_code bb_code_inline nohighlight">%steam_install%\logs\stats_log.txt</code> file.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserStatsStored_t" class="bb_apilink">UserStatsStored_t</a> callback.<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserAchievementStored_t" class="bb_apilink">UserAchievementStored_t</a> callback.<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The current game has stats associated with it in the Steamworks Partner backend, and those stats are published.</li></ul><br />
        /// If the call is successful you will receive a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserStatsStored_t" class="bb_apilink">UserStatsStored_t</a> callback.<br />
        /// <br />
        /// If <code class="bb_code bb_code_inline nohighlight">m_eResult</code> has a result of <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a>, then one or more stats uploaded has been rejected, either because they broke constraints or were out of date. In this case the server sends back updated values and the stats should be updated locally to keep in sync. You do not need to call RequestCurrentStats again in this case.<br />
        /// <br />
        /// If one or more achievements has been unlocked then this will also trigger a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserAchievementStored_t" class="bb_apilink">UserAchievementStored_t</a> callback.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetStat" class="bb_apilink">ISteamUserStats::SetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetAchievement" class="bb_apilink">ISteamUserStats::SetAchievement</a></summary>
        /// 
        public static bool StoreStats() => Instance.StoreStats();
        /// <summary><code>int GetAchievementIcon( const char *pchName );</code><br />
        /// Gets the icon for an achievement.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserAchievementIconFetched_t" class="bb_apilink">UserAchievementIconFetched_t</a> callback.<br />
        /// The image is returned as a handle to be used with <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageRGBA" class="bb_apilink">ISteamUtils::GetImageRGBA</a> to get the actual image data.<br />
        /// <br />
        /// An invalid handle of <b>0</b> will be returned under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has not completed and successfully returned its callback.<br />
        /// 	</li><li> The specified achievement does not exist in App Admin on the Steamworks website, or the changes are not published.<br />
        /// 	</li><li> Steam is still fetching the image data from the server. This will trigger a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserAchievementIconFetched_t" class="bb_apilink">UserAchievementIconFetched_t</a> callback which will notify you when the image data is ready and provide you with a new handle. If the <code class="bb_code bb_code_inline nohighlight">m_nIconHandle</code> in the callback is still <b>0</b>, then there is no image set for the specified achievement.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievement" class="bb_apilink">ISteamUserStats::GetAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementName" class="bb_apilink">ISteamUserStats::GetAchievementName</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetAchievementAndUnlockTime</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAchievedPercent" class="bb_apilink">ISteamUserStats::GetAchievementAchievedPercent</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementDisplayAttribute" class="bb_apilink">ISteamUserStats::GetAchievementDisplayAttribute</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        public static int GetAchievementIcon(UTF8StringPtr pchName) => Instance.GetAchievementIcon(pchName);
        /// <summary><code>const char * GetAchievementDisplayAttribute( const char *pchName, const char *pchKey );</code><br />
        /// Get general attributes for an achievement. Currently provides: Name, Description, and Hidden status.<br />
        /// <br />
        /// This receives the value from a dictionary/map keyvalue store, so you must provide one of the following keys.<br />
        /// <ul class="bb_ul ">	<li> "<b>name</b>" to retrive the localized achievement name in UTF8<br />
        /// 	</li><li> "<b>desc</b>" to retrive the localized achievement description in UTF8<br />
        /// 	</li><li> "<b>hidden</b>" for retrieving if an achievement is hidden. Returns "0" when not hidden, "1" when hidden</li></ul><br />
        /// This localization is provided based on the games language if it's set, otherwise it checks if a localization is avilable for the users Steam UI Language. If that fails too, then it falls back to english.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// This function returns the value as a string upon success if all of the following conditions are met; otherwise, an empty string: <b>""</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The specified achievement exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> The specified <code class="bb_code bb_code_inline nohighlight">pchKey</code> is valid.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievement" class="bb_apilink">ISteamUserStats::GetAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementName" class="bb_apilink">ISteamUserStats::GetAchievementName</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementIcon" class="bb_apilink">ISteamUserStats::GetAchievementIcon</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetAchievementAndUnlockTime</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="pchKey">const char *: The 'key' to get a value for.</param>
        public static UTF8StringPtr GetAchievementDisplayAttribute(UTF8StringPtr pchName, UTF8StringPtr pchKey) => Instance.GetAchievementDisplayAttribute(pchName, pchKey);
        /// <summary><code>bool IndicateAchievementProgress( const char *pchName, uint32 nCurProgress, uint32 nMaxProgress );</code><br />
        /// Shows the user a pop-up notification with the current progress of an achievement.<br />
        /// <br />
        /// Calling this function will NOT set the progress or unlock the achievement, the game must do that manually by calling <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetStat" class="bb_apilink">ISteamUserStats::SetStat</a>!<br />
        /// <br />
        /// The notification looks like this:<br />
        /// <img src="https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/steamworks_docs/english/achievement_progress.png" alt="achievement_progress.png" title="achievement_progress.png" /><br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserStatsStored_t" class="bb_apilink">UserStatsStored_t</a> callback.<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserAchievementStored_t" class="bb_apilink">UserAchievementStored_t</a> callback.<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The specified achievement exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> The specified achievement is not already unlocked.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">nCurProgress</code> is less than <code class="bb_code bb_code_inline nohighlight">nMaxProgress</code>.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetAchievement" class="bb_apilink">ISteamUserStats::SetAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SetStat" class="bb_apilink">ISteamUserStats::SetStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#SetOverlayNotificationPosition" class="bb_apilink">ISteamUtils::SetOverlayNotificationPosition</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#SetOverlayNotificationInset" class="bb_apilink">ISteamUtils::SetOverlayNotificationInset</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="nCurProgress"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The current progress.</param>
        /// <param name="nMaxProgress"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The progress required to unlock the achievement.</param>
        public static bool IndicateAchievementProgress(UTF8StringPtr pchName, uint nCurProgress, uint nMaxProgress) => Instance.IndicateAchievementProgress(pchName, nCurProgress, nMaxProgress);
        /// <summary><code>uint32 GetNumAchievements();</code>Get the number of achievements defined in the App Admin panel of the Steamworks website.<br />
        /// <br />
        /// This is used for iterating through all of the achievements with <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementName" class="bb_apilink">ISteamUserStats::GetAchievementName</a>.<br />
        /// <br />
        /// In general games should not need these functions because they should have a list of existing achievements compiled into them.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The number of achievements. Returns <b>0</b> if <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has not been called and successfully returned its callback, or the current App ID has no achievements.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementName" class="bb_apilink">ISteamUserStats::GetAchievementName</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>int numAchievements = SteamUserStats()-&gt;GetNumAchievements();
        /// for ( int i = 0; i &lt; numAchievements; ++i )
        /// {
        /// 	const char *achName = SteamUserStats()-&gt;GetAchievementName( i );
        /// 	if ( achName )
        /// 	{
        /// 		printf( "%s", achName );
        /// 	}
        /// }</code></summary>
        /// 
        public static uint GetNumAchievements() => Instance.GetNumAchievements();
        /// <summary><code>const char * GetAchievementName( uint32 iAchievement );</code><br />
        /// Gets the 'API name' for an achievement index between 0 and <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetNumAchievements" class="bb_apilink">ISteamUserStats::GetNumAchievements</a>.<br />
        /// <br />
        /// This function must be used in cojunction with <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetNumAchievements" class="bb_apilink">ISteamUserStats::GetNumAchievements</a> to loop over the list of achievements.<br />
        /// <br />
        /// In general games should not need these functions as they should have the list of achievements compiled into them.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The 'API Name' of the achievement, returns an empty string if <code class="bb_code bb_code_inline nohighlight">iAchievement</code> is not a valid index. <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> must have been called and successfully returned its callback, and the current App ID must have achievements.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>int numAchievements = SteamUserStats()-&gt;GetNumAchievements();
        /// for ( int i = 0; i &lt; numAchievements; ++i )
        /// {
        /// 	const char *achName = SteamUserStats()-&gt;GetAchievementName( i );
        /// 	if ( achName )
        /// 	{
        /// 		printf( "%s", achName );
        /// 	}
        /// }</code></summary>
        /// <param name="iAchievement"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: Index of the achievement.</param>
        public static UTF8StringPtr GetAchievementName(uint iAchievement) => Instance.GetAchievementName(iAchievement);
        /// <summary><code>SteamAPICall_t RequestUserStats( CSteamID steamIDUser );</code><br />
        /// Asynchronously downloads stats and achievements for the specified user from the server.<br />
        /// <br />
        /// These stats are not automatically updated; you'll need to call this function again to refresh any data that may have change.<br />
        /// <br />
        /// To keep from using too much memory, an least recently used cache (LRU) is maintained and other user's stats will occasionally be unloaded. When this happens a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserStatsUnloaded_t" class="bb_apilink">UserStatsUnloaded_t</a> callback is sent. After receiving this callback the user's stats will be unavailable until this function is called again.<br />
        /// <br />
        /// The equivalent function for the local user is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, the equivalent function for game servers is <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UserStatsReceived_t" class="bb_apilink">UserStatsReceived_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievement" class="bb_apilink">ISteamUserStats::GetUserAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetUserAchievementAndUnlockTime</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserStat" class="bb_apilink">ISteamUserStats::GetUserStat</a></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to request stats for.</param>
        public static SteamAPICall RequestUserStats(SteamId steamIDUser) => Instance.RequestUserStats(steamIDUser);
        /// <summary><code>bool GetUserStat( CSteamID steamIDUser, const char *pchName, int32 *pData );
        /// bool GetUserStat( CSteamID steamIDUser, const char *pchName, float *pData );</code><br />
        /// Gets the current value of the a stat for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// The equivalent function for the local user is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetStat" class="bb_apilink">ISteamUserStats::GetStat</a>, the equivalent function for game servers is <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#GetUserStat" class="bb_apilink">ISteamGameServerStats::GetUserStat</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type does not match the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievement" class="bb_apilink">ISteamUserStats::GetUserAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetUserAchievementAndUnlockTime</a></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to get the stat for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> * / float *: The variable to return the stat value into.</param>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary><code>bool GetUserStat( CSteamID steamIDUser, const char *pchName, int32 *pData );
        /// bool GetUserStat( CSteamID steamIDUser, const char *pchName, float *pData );</code><br />
        /// Gets the current value of the a stat for the specified user.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// The equivalent function for the local user is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetStat" class="bb_apilink">ISteamUserStats::GetStat</a>, the equivalent function for game servers is <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#GetUserStat" class="bb_apilink">ISteamGameServerStats::GetUserStat</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type does not match the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievement" class="bb_apilink">ISteamUserStats::GetUserAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetUserAchievementAndUnlockTime</a></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to get the stat for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> * / float *: The variable to return the stat value into.</param>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary><code>bool GetUserAchievement( CSteamID steamIDUser, const char *pchName, bool *pbAchieved );</code><br />
        /// Gets the unlock status of the Achievement.<br />
        /// <br />
        /// The equivalent function for the local user is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievement" class="bb_apilink">ISteamUserStats::GetAchievement</a>, the equivalent function for game servers is <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#GetUserAchievement" class="bb_apilink">ISteamGameServerStats::GetUserAchievement</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The 'API Name' of the specified achievement exists in App Admin on the Steamworks website, and the changes are published.</li></ul><br />
        /// If the call is successful then the unlock status is returned via the <code class="bb_code bb_code_inline nohighlight">pbAchieved</code> parameter.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserStat" class="bb_apilink">ISteamUserStats::GetUserStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetUserAchievementAndUnlockTime</a></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to get the achievement for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="pbAchieved">bool *: Returns the unlock status of the achievement.</param>
        public static bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved) => Instance.GetUserAchievement(steamIDUser, pchName, pbAchieved);
        /// <summary><code>bool GetUserAchievementAndUnlockTime( CSteamID steamIDUser, const char *pchName, bool *pbAchieved, uint32 *punUnlockTime );</code><br />
        /// Gets the achievement status, and the time it was unlocked if unlocked.<br />
        /// <br />
        /// If the return value is true, but the unlock time is zero, that means it was unlocked before Steam began tracking achievement unlock times (December 2009). The time is provided in Unix epoch format, seconds since January 1, 1970 UTC.<br />
        /// <br />
        /// The equivalent function for the local user is <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAndUnlockTime" class="bb_apilink">ISteamUserStats::GetAchievementAndUnlockTime</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The 'API Name' of the specified achievement exists in App Admin on the Steamworks website, and the changes are published.</li></ul><br />
        /// If the call is successful then the achieved status and unlock time are provided via the arguments <code class="bb_code bb_code_inline nohighlight">pbAchieved</code> and <code class="bb_code bb_code_inline nohighlight">punUnlockTime</code>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserAchievement" class="bb_apilink">ISteamUserStats::GetUserAchievement</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetUserStat" class="bb_apilink">ISteamUserStats::GetUserStat</a></summary>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of the user to get the achievement for.</param>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="pbAchieved">bool *: Returns whether the current user has unlocked the achievement.</param>
        /// <param name="punUnlockTime"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the time that the achievement was unlocked; if pbAchieved is true.</param>
        public static bool GetUserAchievementAndUnlockTime(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime) => Instance.GetUserAchievementAndUnlockTime(steamIDUser, pchName, pbAchieved, punUnlockTime);
        /// <summary><code>bool ResetAllStats( bool bAchievementsToo );</code><br />
        /// Resets the current users stats and, optionally achievements.<br />
        /// <br />
        /// This automatically calls <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a> to persist the changes to the server. This should typically only be used for testing purposes during development. Ensure that you sync up your stats with the new default values provided by Steam after calling this by calling <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> indicating success if <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> has been called and successfully returned its callback; otherwise <b>false</b>.</summary>
        /// <param name="bAchievementsToo">bool: Also reset the user's achievements?</param>
        public static bool ResetAllStats(bool bAchievementsToo) => Instance.ResetAllStats(bAchievementsToo);
        /// <summary><code>SteamAPICall_t FindOrCreateLeaderboard( const char *pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType );</code><br />
        /// Gets a leaderboard by name, it will create it if it's not yet created.<br />
        /// <br />
        /// You must call either this or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> to obtain the leaderboard handle which is valid for the game session for each leaderboard you wish to access prior to calling any other Leaderboard functions.<br />
        /// <br />
        /// Leaderboards created with this function will not automatically show up in the Steam Community. You must manually set the Community Name field in the App Admin panel of the Steamworks website. As such it's generally recommended to prefer creating the leaderboards in the App Admin panel on the Steamworks website and using <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> unless you're expected to have a large amount of dynamically created leaderboards.<br />
        /// <br />
        /// You should never pass <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_ELeaderboardSortMethodNone" class="bb_apilink">k_ELeaderboardSortMethodNone</a> for <code class="bb_code bb_code_inline nohighlight">eLeaderboardSortMethod</code> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_ELeaderboardDisplayTypeNone" class="bb_apilink">k_ELeaderboardDisplayTypeNone</a> for <code class="bb_code bb_code_inline nohighlight">eLeaderboardDisplayType</code> as this is undefined behavior.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardFindResult_t" class="bb_apilink">LeaderboardFindResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardEntryCount" class="bb_apilink">ISteamUserStats::GetLeaderboardEntryCount</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UploadLeaderboardScore" class="bb_apilink">ISteamUserStats::UploadLeaderboardScore</a></summary>
        /// <param name="pchLeaderboardName">const char *: The name of the leaderboard to find or create. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchLeaderboardNameMax" class="bb_apilink">k_cchLeaderboardNameMax</a>.</param>
        /// <param name="eLeaderboardSortMethod"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ELeaderboardSortMethod" class="bb_apilink">ELeaderboardSortMethod</a>: The sort order of the new leaderboard if it's created.</param>
        /// <param name="eLeaderboardDisplayType"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ELeaderboardDisplayType" class="bb_apilink">ELeaderboardDisplayType</a>: The display type (used by the Steam Community web site) of the new leaderboard if it's created.</param>
        public static SteamAPICall FindOrCreateLeaderboard(UTF8StringPtr pchLeaderboardName, LeaderboardSortMethod eLeaderboardSortMethod, LeaderboardDisplayType eLeaderboardDisplayType) => Instance.FindOrCreateLeaderboard(pchLeaderboardName, eLeaderboardSortMethod, eLeaderboardDisplayType);
        /// <summary><code>SteamAPICall_t FindLeaderboard( const char *pchLeaderboardName );</code><br />
        /// Gets a leaderboard by name.<br />
        /// <br />
        /// You must call either this or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a> to obtain the leaderboard handle which is valid for the game session for each leaderboard you wish to access prior to calling any other Leaderboard functions.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardFindResult_t" class="bb_apilink">LeaderboardFindResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardEntryCount" class="bb_apilink">ISteamUserStats::GetLeaderboardEntryCount</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UploadLeaderboardScore" class="bb_apilink">ISteamUserStats::UploadLeaderboardScore</a></summary>
        /// <param name="pchLeaderboardName">const char *: The name of the leaderboard to find. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchLeaderboardNameMax" class="bb_apilink">k_cchLeaderboardNameMax</a>.</param>
        public static SteamAPICall FindLeaderboard(UTF8StringPtr pchLeaderboardName) => Instance.FindLeaderboard(pchLeaderboardName);
        /// <summary><code>const char * GetLeaderboardName( SteamLeaderboard_t hSteamLeaderboard );</code><br />
        /// Returns the name of a leaderboard handle.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The name of the leaderboard. Returns an empty string if the leaderboard handle is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardEntryCount" class="bb_apilink">ISteamUserStats::GetLeaderboardEntryCount</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardSortMethod" class="bb_apilink">ISteamUserStats::GetLeaderboardSortMethod</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardDisplayType" class="bb_apilink">ISteamUserStats::GetLeaderboardDisplayType</a></summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        public static UTF8StringPtr GetLeaderboardName(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardName(hSteamLeaderboard);
        /// <summary><code>int GetLeaderboardEntryCount( SteamLeaderboard_t hSteamLeaderboard );</code><br />
        /// Returns the total number of entries in a leaderboard.<br />
        /// <br />
        /// This is cached on a per leaderboard basis upon the first call to <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a> and is refreshed on each successful call to <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntriesForUsers" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntriesForUsers</a>, and <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UploadLeaderboardScore" class="bb_apilink">ISteamUserStats::UploadLeaderboardScore</a>.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of entries in the leaderboard. Returns 0 if the leaderboard handle is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardName" class="bb_apilink">ISteamUserStats::GetLeaderboardName</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardSortMethod" class="bb_apilink">ISteamUserStats::GetLeaderboardSortMethod</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardDisplayType" class="bb_apilink">ISteamUserStats::GetLeaderboardDisplayType</a></summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        public static int GetLeaderboardEntryCount(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardEntryCount(hSteamLeaderboard);
        /// <summary><code>ELeaderboardSortMethod GetLeaderboardSortMethod( SteamLeaderboard_t hSteamLeaderboard );</code><br />
        /// Returns the sort order of a leaderboard handle.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ELeaderboardSortMethod" class="bb_apilink">ELeaderboardSortMethod</a><br />
        /// The sort method of the leaderboard. Returns <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_ELeaderboardSortMethodNone" class="bb_apilink">k_ELeaderboardSortMethodNone</a> if the leaderboard handle is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardName" class="bb_apilink">ISteamUserStats::GetLeaderboardName</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardDisplayType" class="bb_apilink">ISteamUserStats::GetLeaderboardDisplayType</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardEntryCount" class="bb_apilink">ISteamUserStats::GetLeaderboardEntryCount</a></summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        public static LeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardSortMethod(hSteamLeaderboard);
        /// <summary><code>ELeaderboardDisplayType GetLeaderboardDisplayType( SteamLeaderboard_t hSteamLeaderboard );</code><br />
        /// Returns the display type of a leaderboard handle.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ELeaderboardDisplayType" class="bb_apilink">ELeaderboardDisplayType</a><br />
        /// The display type of the leaderboard. Returns <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_ELeaderboardDisplayTypeNone" class="bb_apilink">k_ELeaderboardDisplayTypeNone</a> if the leaderboard handle is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardName" class="bb_apilink">ISteamUserStats::GetLeaderboardName</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardSortMethod" class="bb_apilink">ISteamUserStats::GetLeaderboardSortMethod</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardEntryCount" class="bb_apilink">ISteamUserStats::GetLeaderboardEntryCount</a></summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        public static LeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardDisplayType(hSteamLeaderboard);
        /// <summary><code>SteamAPICall_t DownloadLeaderboardEntries( SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd );</code><br />
        /// Fetches a series of leaderboard entries for a specified leaderboard.<br />
        /// <br />
        /// You can ask for more entries than exist, then this will return as many as do exist.<br />
        /// <br />
        /// If you want to download entries for an arbitrary set of users, such as all of the users on a server then you can use <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntriesForUsers" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntriesForUsers</a> which takes an array of Steam IDs.<br />
        /// <br />
        /// You must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a> to get a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a> prior to calling this function.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardScoresDownloaded_t" class="bb_apilink">LeaderboardScoresDownloaded_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetDownloadedLeaderboardEntry" class="bb_apilink">ISteamUserStats::GetDownloadedLeaderboardEntry</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UploadLeaderboardScore" class="bb_apilink">ISteamUserStats::UploadLeaderboardScore</a></summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        /// <param name="eLeaderboardDataRequest"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ELeaderboardDataRequest" class="bb_apilink">ELeaderboardDataRequest</a>: The type of data request to make.</param>
        /// <param name="nRangeStart">int: The index to start downloading entries relative to eLeaderboardDataRequest.</param>
        /// <param name="nRangeEnd">int: The last index to retrieve entries for relative to eLeaderboardDataRequest.</param>
        public static SteamAPICall DownloadLeaderboardEntries(SteamLeaderboard hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) => Instance.DownloadLeaderboardEntries(hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
        /// <summary><code>SteamAPICall_t DownloadLeaderboardEntriesForUsers( SteamLeaderboard_t hSteamLeaderboard, CSteamID *prgUsers, int cUsers );</code><br />
        /// Fetches leaderboard entries for an arbitrary set of users on a specified leaderboard.<br />
        /// <br />
        /// A maximum of 100 users can be downloaded at a time, with only one outstanding call at a time. If a user doesn't have an entry on the specified leaderboard, they won't be included in the result.<br />
        /// <br />
        /// If you want to download entries based on their ranking or friends of the current user then you should use <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>.<br />
        /// <br />
        /// You must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a> to get a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a> prior to calling this function.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardScoresDownloaded_t" class="bb_apilink">LeaderboardScoresDownloaded_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> indicating an error if the number of users is greater than 100 or if one of the Steam IDs is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetDownloadedLeaderboardEntry" class="bb_apilink">ISteamUserStats::GetDownloadedLeaderboardEntry</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UploadLeaderboardScore" class="bb_apilink">ISteamUserStats::UploadLeaderboardScore</a></summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        /// <param name="prgUsers"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a> *: An array of Steam IDs to get the leaderboard entries for.</param>
        /// <param name="cUsers">int: The number of elements in the <code class="bb_code bb_code_inline nohighlight">prgUsers</code> array.</param>
        public static SteamAPICall DownloadLeaderboardEntriesForUsers(SteamLeaderboard hSteamLeaderboard, SteamId* prgUsers, int cUsers) => Instance.DownloadLeaderboardEntriesForUsers(hSteamLeaderboard, prgUsers, cUsers);
        /// <summary><code>bool GetDownloadedLeaderboardEntry( SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, LeaderboardEntry_t *pLeaderboardEntry, int32 *pDetails, int cDetailsMax );</code><br />
        /// Retrieves the data for a single leaderboard entry.<br />
        /// <br />
        /// You should use a for loop from 0 to <code class="bb_code bb_code_inline nohighlight">LeaderboardScoresDownloaded_t.m_cEntryCount</code> to get all the downloaded entries. Once you've accessed all the entries, the data will be freed, and the <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboardEntries_t" class="bb_apilink">SteamLeaderboardEntries_t</a> handle will become invalid.<br />
        /// <br />
        /// Optionally details may be returned for the entry via the <code class="bb_code bb_code_inline nohighlight">pDetails</code>. If this is NULL then <code class="bb_code bb_code_inline nohighlight">cDetailsMax</code> MUST be <b>0</b>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hSteamLeaderboardEntries</code> must be a valid handle from the last received <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardScoresDownloaded_t" class="bb_apilink">LeaderboardScoresDownloaded_t</a> call result.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">index</code> must be between 0 and <code class="bb_code bb_code_inline nohighlight">LeaderboardScoresDownloaded_t.m_cEntryCount</code></li></ul><br />
        /// If the call is successful then the entry is returned via the parameter <code class="bb_code bb_code_inline nohighlight">pLeaderboardEntry</code> and if <code class="bb_code bb_code_inline nohighlight">cDetailsMax</code> is not 0 then <code class="bb_code bb_code_inline nohighlight">pDetails</code> is filled with the unlock details.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UploadLeaderboardScore" class="bb_apilink">ISteamUserStats::UploadLeaderboardScore</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>void OnLeaderboardScoresDownloaded( LeaderboardScoresDownloaded_t *pCallback )
        /// {
        ///     for ( int i = 0; i &lt; pCallback-&gt;m_cEntryCount; i++ )
        ///     {
        ///         LeaderboardEntry_t leaderboardEntry;
        ///         int32 details[3]; // We know that we store this many initially.
        ///         SteamUserStats()-&gt;GetDownloadedLeaderboardEntry( pCallback-&gt;m_hSteamLeaderboardEntries, i, &amp;leaderboardEntry, details, 3 );
        /// 
        ///         assert( leaderboardEntry.m_cDetails == 3 );
        ///         //...
        ///     }
        /// }</code></summary>
        /// <param name="hSteamLeaderboardEntries"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboardEntries_t" class="bb_apilink">SteamLeaderboardEntries_t</a>: A leaderboard entries handle obtained from the most recently received <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardScoresDownloaded_t" class="bb_apilink">LeaderboardScoresDownloaded_t</a> call result.</param>
        /// <param name="index">int: The index of the leaderboard entry to receive, must be between 0 and <code class="bb_code bb_code_inline nohighlight">LeaderboardScoresDownloaded_t.m_cEntryCount</code>.</param>
        /// <param name="pLeaderboardEntry"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardEntry_t" class="bb_apilink">LeaderboardEntry_t</a> *: Variable where the entry will be returned to.</param>
        /// <param name="pDetails"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> *: A preallocated array where the details of this entry get returned into.</param>
        /// <param name="cDetailsMax">int: The length of the <code class="bb_code bb_code_inline nohighlight">pDetails</code> array.</param>
        public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries hSteamLeaderboardEntries, int index, LeaderboardEntry* pLeaderboardEntry, int* pDetails, int cDetailsMax) => Instance.GetDownloadedLeaderboardEntry(hSteamLeaderboardEntries, index, pLeaderboardEntry, pDetails, cDetailsMax);
        /// <summary><code>SteamAPICall_t UploadLeaderboardScore( SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int32 nScore, const int32 *pScoreDetails, int cScoreDetailsCount );</code><br />
        /// Uploads a user score to a specified leaderboard.<br />
        /// <br />
        /// Details are optional game-defined information which outlines how the user got that score. For example if it's a racing style time based leaderboard you could store the timestamps when the player hits each checkpoint. If you have collectibles along the way you could use bit fields as booleans to store the items the player picked up in the playthrough.<br />
        /// <br />
        /// Uploading scores to Steam is rate limited to 10 uploads per 10 minutes and you may only have one outstanding call to this function at a time.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardScoreUploaded_t" class="bb_apilink">LeaderboardScoreUploaded_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#AttachLeaderboardUGC" class="bb_apilink">ISteamUserStats::AttachLeaderboardUGC</a></summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        /// <param name="eLeaderboardUploadScoreMethod"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#ELeaderboardUploadScoreMethod" class="bb_apilink">ELeaderboardUploadScoreMethod</a>: Do you want to force the score to change, or keep the previous score if it was better?</param>
        /// <param name="nScore"><a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>: The score to upload.</param>
        /// <param name="pScoreDetails">const <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a> *: Optional: Array containing the details surrounding the unlocking of this score.</param>
        /// <param name="cScoreDetailsCount">int: The number of elements in <code class="bb_code bb_code_inline nohighlight">pScoreDetails</code>. Must not exceed k_cLeaderboardDetailsMax</param>
        public static SteamAPICall UploadLeaderboardScore(SteamLeaderboard hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int* pScoreDetails, int cScoreDetailsCount) => Instance.UploadLeaderboardScore(hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
        /// <summary><code>SteamAPICall_t AttachLeaderboardUGC( SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC );</code><br />
        /// Attaches a piece of user generated content the current user's entry on a leaderboard.<br />
        /// <br />
        /// This content could be a replay of the user achieving the score or a ghost to race against. The attached handle will be available when the entry is retrieved and can be accessed by other users using <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetDownloadedLeaderboardEntry" class="bb_apilink">ISteamUserStats::GetDownloadedLeaderboardEntry</a> which contains <code class="bb_code bb_code_inline nohighlight">LeaderboardEntry_t.m_hUGC</code>. To create and download user generated content see the documentation for the Steam Workshop.<br />
        /// <br />
        /// Once attached, the content will be available even if the underlying Cloud file is changed or deleted by the user.<br />
        /// <br />
        /// You must call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a> to get a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a> prior to calling this function.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardUGCSet_t" class="bb_apilink">LeaderboardUGCSet_t</a> call result.</summary>
        /// <param name="hSteamLeaderboard"><a href="https://partner.steamgames.com/doc/api/ISteamUserStats#SteamLeaderboard_t" class="bb_apilink">SteamLeaderboard_t</a>: A leaderboard handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>.</param>
        /// <param name="hUGC"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCHandle_t" class="bb_apilink">UGCHandle_t</a>: Handle to a piece of user generated content that was shared using <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileShare" class="bb_apilink">ISteamRemoteStorage::FileShare</a>.</param>
        public static SteamAPICall AttachLeaderboardUGC(SteamLeaderboard hSteamLeaderboard, UGCHandle hUGC) => Instance.AttachLeaderboardUGC(hSteamLeaderboard, hUGC);
        /// <summary><code>SteamAPICall_t GetNumberOfCurrentPlayers();</code>Asynchronously retrieves the total number of players currently playing the current game. Both online and in offline mode.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#NumberOfCurrentPlayers_t" class="bb_apilink">NumberOfCurrentPlayers_t</a> call result.</summary>
        /// 
        public static SteamAPICall GetNumberOfCurrentPlayers() => Instance.GetNumberOfCurrentPlayers();
        /// <summary><code>SteamAPICall_t RequestGlobalAchievementPercentages();</code>Asynchronously fetch the data for the percentage of players who have received each achievement for the current game globally.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this!<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GlobalAchievementPercentagesReady_t" class="bb_apilink">GlobalAchievementPercentagesReady_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetMostAchievedAchievementInfo" class="bb_apilink">ISteamUserStats::GetMostAchievedAchievementInfo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetNextMostAchievedAchievementInfo" class="bb_apilink">ISteamUserStats::GetNextMostAchievedAchievementInfo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAchievedPercent" class="bb_apilink">ISteamUserStats::GetAchievementAchievedPercent</a></summary>
        /// 
        public static SteamAPICall RequestGlobalAchievementPercentages() => Instance.RequestGlobalAchievementPercentages();
        /// <summary><code>int GetMostAchievedAchievementInfo( char *pchName, uint32 unNameBufLen, float *pflPercent, bool *pbAchieved );</code><br />
        /// Gets the info on the most achieved achievement for the game.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Returns <b>-1</b> if <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a> has not been called or if there are no global achievement percentages for this app Id.<br />
        /// <br />
        /// If the call is successful it returns an iterator which should be used with <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetNextMostAchievedAchievementInfo" class="bb_apilink">ISteamUserStats::GetNextMostAchievedAchievementInfo</a>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetNextMostAchievedAchievementInfo" class="bb_apilink">ISteamUserStats::GetNextMostAchievedAchievementInfo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementAchievedPercent" class="bb_apilink">ISteamUserStats::GetAchievementAchievedPercent</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>const int ACH_NAME_MAX_LENGTH = 64;
        /// char[ACH_NAME_MAX_LENGTH] achName;
        /// float achPercent;
        /// float achUnlocked;
        /// 
        /// int i = SteamUserStats()-&gt;GetMostAchievedAchievementInfo( achName, ACH_NAME_MAX_LENGTH, achPercent, achUnlocked );
        /// while ( i != -1 )
        /// {
        /// 	printf( "AchievementInfo - name: %s, percent: %f, unlocked: %d", achName, achPercent, achUnlocked );
        /// 	// Do something like add/update this info in your local achievement object or display it to the user.
        /// 
        /// 	i = SteamUserStats()-&gt;GetNextMostAchievedAchievementInfo( i, achName, ACH_NAME_MAX_LENGTH, achPercent, achUnlocked );
        /// }</code></summary>
        /// <param name="pchName">char *: String buffer to return the 'API Name' of the achievement into.</param>
        /// <param name="unNameBufLen"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size in bytes of pchName, should be at least as long as your longest achievement 'API Name'.</param>
        /// <param name="pflPercent">float *: Variable to return the percentage of people that have unlocked this achievement from 0 to 100.</param>
        /// <param name="pbAchieved">bool *: Variable to return whether the current user has unlocked this achievement.</param>
        public static int GetMostAchievedAchievementInfo(byte* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved) => Instance.GetMostAchievedAchievementInfo(pchName, unNameBufLen, pflPercent, pbAchieved);
        /// <summary><code>int GetNextMostAchievedAchievementInfo( int iIteratorPrevious, char *pchName, uint32 unNameBufLen, float *pflPercent, bool *pbAchieved );</code><br />
        /// Gets the info on the next most achieved achievement for the game.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Returns <b>-1</b> if <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a> has not been called or if there are no global achievement percentages for this app Id.<br />
        /// <br />
        /// If the call is successful it returns an iterator which should be used with subsequent calls to this function.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>const int ACH_NAME_MAX_LENGTH = 64;
        /// char[ACH_NAME_MAX_LENGTH] achName;
        /// float achPercent;
        /// float achUnlocked;
        /// 
        /// int i = SteamUserStats()-&gt;GetMostAchievedAchievementInfo( achName, ACH_NAME_MAX_LENGTH, achPercent, achUnlocked );
        /// while ( i != -1 )
        /// {
        /// 	printf( "AchievementInfo - name: %s, percent: %f, unlocked: %d", achName, achPercent, achUnlocked );
        /// 	// Do something like add/update this info in your local achievement object or display it to the user.
        /// 
        /// 	i = SteamUserStats()-&gt;GetNextMostAchievedAchievementInfo( i, achName, ACH_NAME_MAX_LENGTH, achPercent, achUnlocked );
        /// }</code></summary>
        /// <param name="iIteratorPrevious">int: Iterator returned from the previous call to this function or from <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetMostAchievedAchievementInfo" class="bb_apilink">ISteamUserStats::GetMostAchievedAchievementInfo</a></param>
        /// <param name="pchName">char *: String buffer to return the 'API Name' of the achievement into.</param>
        /// <param name="unNameBufLen"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size in bytes of pchName, should be at least as long as your longest achievement 'API Name'.</param>
        /// <param name="pflPercent">float *: Variable to return the percentage of people that have unlocked this achievement from 0 to 100.</param>
        /// <param name="pbAchieved">bool *: Variable to return whether the current user has unlocked this achievement.</param>
        public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, byte* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved) => Instance.GetNextMostAchievedAchievementInfo(iIteratorPrevious, pchName, unNameBufLen, pflPercent, pbAchieved);
        /// <summary><code>bool GetAchievementAchievedPercent( const char *pchName, float *pflPercent );</code><br />
        /// Returns the percentage of users who have unlocked the specified achievement.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success; otherwise <b>false</b> if <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a> has not been called or if the specified 'API Name' does not exist in the global achievement percentages.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetMostAchievedAchievementInfo" class="bb_apilink">ISteamUserStats::GetMostAchievedAchievementInfo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetNextMostAchievedAchievementInfo" class="bb_apilink">ISteamUserStats::GetNextMostAchievedAchievementInfo</a></summary>
        /// <param name="pchName">const char *: The 'API Name' of the achievement.</param>
        /// <param name="pflPercent">float *: Variable to return the percentage of people that have unlocked this achievement from 0 to 100.</param>
        public static bool GetAchievementAchievedPercent(UTF8StringPtr pchName, float* pflPercent) => Instance.GetAchievementAchievedPercent(pchName, pflPercent);
        /// <summary><code>SteamAPICall_t RequestGlobalStats( int nHistoryDays );</code><br />
        /// Asynchronously fetches global stats data, which is available for stats marked as "aggregated" in the App Admin panel of the Steamworks website.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GlobalStatsReceived_t" class="bb_apilink">GlobalStatsReceived_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetGlobalStat" class="bb_apilink">ISteamUserStats::GetGlobalStat</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetGlobalStatHistory" class="bb_apilink">ISteamUserStats::GetGlobalStatHistory</a></summary>
        /// <param name="nHistoryDays">int: How many days of day-by-day history to retrieve in addition to the overall totals. The limit is 60.</param>
        public static SteamAPICall RequestGlobalStats(int nHistoryDays) => Instance.RequestGlobalStats(nHistoryDays);
        /// <summary><code>bool GetGlobalStat( const char *pchStatName, int64 *pData );
        /// bool GetGlobalStat( const char *pchStatName, double *pData );</code><br />
        /// Gets the lifetime totals for an aggregated stat.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type matches the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetGlobalStatHistory" class="bb_apilink">ISteamUserStats::GetGlobalStatHistory</a></summary>
        /// <param name="pchStatName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int64" class="bb_apilink">int64</a> * / double *: The variable to return the stat value into.</param>
        public static bool GetGlobalStat(UTF8StringPtr pchStatName, long* pData) => Instance.GetGlobalStat(pchStatName, pData);
        /// <summary><code>bool GetGlobalStat( const char *pchStatName, int64 *pData );
        /// bool GetGlobalStat( const char *pchStatName, double *pData );</code><br />
        /// Gets the lifetime totals for an aggregated stat.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function returns <b>true</b> upon success if all of the following conditions are met; otherwise, <b>false</b>.<br />
        /// <ul class="bb_ul ">	<li> The specified stat exists in App Admin on the Steamworks website, and the changes are published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> has completed and successfully returned its callback.<br />
        /// 	</li><li> The type matches the type listed in the App Admin panel of the Steamworks website.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetGlobalStatHistory" class="bb_apilink">ISteamUserStats::GetGlobalStatHistory</a></summary>
        /// <param name="pchStatName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData"><a href="https://partner.steamgames.com/doc/api/steam_api#int64" class="bb_apilink">int64</a> * / double *: The variable to return the stat value into.</param>
        public static bool GetGlobalStat(UTF8StringPtr pchStatName, double* pData) => Instance.GetGlobalStat(pchStatName, pData);
        /// <summary><code>int32 GetGlobalStatHistory( const char *pchStatName, int64 *pData, uint32 cubData );
        /// int32 GetGlobalStatHistory( const char *pchStatName, double *pData, uint32 cubData );</code><br />
        /// Gets the daily history for an aggregated stat.<br />
        /// <br />
        /// pData will be filled with daily values, starting with today.<br />
        /// So when called, pData[0] will be today, pData[1] will be yesterday, and pData[2] will be two days ago, etc.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a><br />
        /// The number of elements returned in the <code class="bb_code bb_code_inline nohighlight">pData</code> array.<br />
        /// <br />
        /// A value of <b>0</b> indicates failure for one of the following reasons:<br />
        /// <ul class="bb_ul ">	<li> The specified stat does not exist in App Admin on the Steamworks website, or the changes aren't published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> has not been called or returned its callback, with at least 1 day of history.<br />
        /// 	</li><li> The type does not match the type listed in the App Admin panel of the Steamworks website.<br />
        /// 	</li><li> There is no history available.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetGlobalStat" class="bb_apilink">ISteamUserStats::GetGlobalStat</a></summary>
        /// <param name="pchStatName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData">double *: Array that the daily history will be returned into.</param>
        /// <param name="cubData"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The total size <b>in bytes</b> of the <code class="bb_code bb_code_inline nohighlight">pData</code> array.</param>
        public static int GetGlobalStatHistory(UTF8StringPtr pchStatName, long* pData, uint cubData) => Instance.GetGlobalStatHistory(pchStatName, pData, cubData);
        /// <summary><code>int32 GetGlobalStatHistory( const char *pchStatName, int64 *pData, uint32 cubData );
        /// int32 GetGlobalStatHistory( const char *pchStatName, double *pData, uint32 cubData );</code><br />
        /// Gets the daily history for an aggregated stat.<br />
        /// <br />
        /// pData will be filled with daily values, starting with today.<br />
        /// So when called, pData[0] will be today, pData[1] will be yesterday, and pData[2] will be two days ago, etc.<br />
        /// <br />
        /// You must have called <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> and it needs to return successfully via its callback prior to calling this.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a><br />
        /// The number of elements returned in the <code class="bb_code bb_code_inline nohighlight">pData</code> array.<br />
        /// <br />
        /// A value of <b>0</b> indicates failure for one of the following reasons:<br />
        /// <ul class="bb_ul ">	<li> The specified stat does not exist in App Admin on the Steamworks website, or the changes aren't published.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a> has not been called or returned its callback, with at least 1 day of history.<br />
        /// 	</li><li> The type does not match the type listed in the App Admin panel of the Steamworks website.<br />
        /// 	</li><li> There is no history available.</li></ul><br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetGlobalStat" class="bb_apilink">ISteamUserStats::GetGlobalStat</a></summary>
        /// <param name="pchStatName">const char *: The 'API Name' of the stat. Must not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cchStatNameMax" class="bb_apilink">k_cchStatNameMax</a>.</param>
        /// <param name="pData">double *: Array that the daily history will be returned into.</param>
        /// <param name="cubData"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The total size <b>in bytes</b> of the <code class="bb_code bb_code_inline nohighlight">pData</code> array.</param>
        public static int GetGlobalStatHistory(UTF8StringPtr pchStatName, double* pData, uint cubData) => Instance.GetGlobalStatHistory(pchStatName, pData, cubData);
        /// missing documentation
        public static bool GetAchievementProgressLimits(UTF8StringPtr pchName, int* pnMinProgress, int* pnMaxProgress) => Instance.GetAchievementProgressLimits(pchName, pnMinProgress, pnMaxProgress);
        /// missing documentation
        public static bool GetAchievementProgressLimits(UTF8StringPtr pchName, float* pfMinProgress, float* pfMaxProgress) => Instance.GetAchievementProgressLimits(pchName, pfMinProgress, pfMaxProgress);
    }
}