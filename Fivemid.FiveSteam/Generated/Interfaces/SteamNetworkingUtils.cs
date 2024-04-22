using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamNetworkingUtils
    {
        public static ISteamNetworkingUtils.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingUtils_SteamAPI_v004", CallingConvention = Platform.CC)]
        private static extern ISteamNetworkingUtils.Instance Accessor();
        /// <summary><code>SteamNetworkingMessage_t *AllocateMessage( int cbAllocateBuffer ) </code>Allocate and initialize a message object.  Usually the reason you call this is to pass it to <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SendMessages" class="bb_apilink">ISteamNetworkingSockets::SendMessages</a>.  The returned object will have all of the relevant fields cleared to zero.<br />
        /// <br />
        /// Optionally you can also request that this system allocate space to hold the payload itself.  If cbAllocateBuffer is nonzero, the system will allocate memory to hold a payload of at least cbAllocateBuffer bytes.  m_pData will point to the allocated buffer, m_cbSize will be set to the size, and m_pfnFreeData will be set to the proper function to free up the buffer.<br />
        /// <br />
        /// If cbAllocateBuffer=0, then no buffer is allocated.  m_pData will be NULL, m_cbSize will be zero, and m_pfnFreeData will be NULL.  You will need to set each of these.</summary>
        /// 
        public static SteamNetworkingMessage* AllocateMessage(int cbAllocateBuffer) => Instance.AllocateMessage(cbAllocateBuffer);
        /// <summary><code>void InitRelayNetworkAccess();</code>If you know that you are going to be using the relay network (for example, because you anticipate making P2P connections), call this to initialize the relay network.  If you do not call this, the initialization will be delayed until the first time you use a feature that requires access to the relay network, which will delay that first access.<br />
        /// <br />
        /// You can also call this to force a retry if the previous attempt has failed.  Performing any action that requires access to the relay network will also trigger a retry, and so calling this function is never strictly necessary, but it can be useful to call it a program launch time, if access to the relay network is anticipated.  Use <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#GetRelayNetworkStatus" class="bb_apilink">ISteamNetworkingUtils::GetRelayNetworkStatus</a> or listen for <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamRelayNetworkStatus_t%20" class="bb_apilink">SteamRelayNetworkStatus_t </a> callbacks to know when initialization has completed.  Typically initialization completes in a few seconds.<br />
        /// <br />
        /// Note: dedicated servers hosted in known data centers do *not* need to call this, since they do not make routing decisions.  However, if the dedicated server will be using P2P functionality, it will act as a "client" and this should be called.</summary>
        /// 
        public static void InitRelayNetworkAccess() => Instance.InitRelayNetworkAccess();
        /// <summary><code>ESteamNetworkingAvailability GetRelayNetworkStatus( SteamRelayNetworkStatus_t *pDetails );</code>Fetch current status of the relay network.<br />
        /// <br />
        /// <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamRelayNetworkStatus_t" class="bb_apilink">SteamRelayNetworkStatus_t</a> is also a callback.  It will be triggered on both the user and gameserver interfaces any time the status changes, or ping measurement starts or stops.<br />
        /// <br />
        /// SteamRelayNetworkStatus_t::m_eAvail is returned.  If you want more details, you can pass a non-NULL value.</summary>
        /// 
        public static SteamNetworkingAvailability GetRelayNetworkStatus(SteamRelayNetworkStatus* pDetails) => Instance.GetRelayNetworkStatus(pDetails);
        /// <summary><code>float GetLocalPingLocation( SteamNetworkPingLocation_t &amp;result );</code><br />
        /// Return location info for the current host.  Returns the approximate age of the data, in seconds, or -1 if no data is available.<br />
        /// <br />
        /// It takes a few seconds to initialize access to the relay network.  If you call this very soon after calling <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#InitializeRelayNetworkAccess" class="bb_apilink">ISteamNetworkingUtils::InitializeRelayNetworkAccess</a>, the data may not be available yet.<br />
        /// <br />
        /// This always return the most up-to-date information we have available right now, even if we are in the middle of re-calculating ping times.</summary>
        /// 
        public static float GetLocalPingLocation(ref SteamNetworkPingLocation result) => Instance.GetLocalPingLocation(ref result);
        /// <summary><code>int EstimatePingTimeBetweenTwoLocations( const SteamNetworkPingLocation_t &amp;location1, const SteamNetworkPingLocation_t &amp;location2 );</code><br />
        /// Estimate the round-trip latency between two arbitrary locations, in milliseconds.  This is a conservative estimate, based on routing through the relay network.  For most basic relayed connections, this ping time will be pretty accurate, since it will be based on the route likely to be actually used.<br />
        /// <br />
        /// If a direct IP route is used (perhaps via NAT traversal), then the route will be different, and the ping time might be better.  Or it might actually be a bit worse!  Standard IP routing is frequently suboptimal!<br />
        /// <br />
        /// But even in this case, the estimate obtained using this method is a reasonable upper bound on the ping time.  (Also it has the advantage of returning immediately and not sending any packets.)<br />
        /// <br />
        /// In a few cases we might not able to estimate the route.  In this case a negative value is returned.  k_nSteamNetworkingPing_Failed means the reason was because of some networking difficulty.  (Failure to ping, etc)  k_nSteamNetworkingPing_Unknown is returned if we cannot currently answer the question for some other reason.<br />
        /// <br />
        /// Do you need to be able to do this from a backend/matchmaking server?  You are looking for the "game coordinator" library.  See <a href="https://partner.steamgames.com/doc/api/steamdatagramrelay" class="bb_apilink">steamdatagramrelay</a> for more info on how to obtain the game coordinator SDK.</summary>
        /// 
        public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation location1, ref SteamNetworkPingLocation location2) => Instance.EstimatePingTimeBetweenTwoLocations(ref location1, ref location2);
        /// <summary><code>int EstimatePingTimeFromLocalHost( const SteamNetworkPingLocation_t &amp;remoteLocation );</code>Same as EstimatePingTime, but assumes that one location is the local host.  This is a bit faster, especially if you need to calculate a bunch of these in a loop to find the fastest one.<br />
        /// <br />
        /// In rare cases this might return a slightly different estimate than combining GetLocalPingLocation with EstimatePingTimeBetweenTwoLocations.  That's because this function uses a slightly more complete set of information about what route would be taken.</summary>
        /// 
        public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation remoteLocation) => Instance.EstimatePingTimeFromLocalHost(ref remoteLocation);
        /// <summary><code>void ConvertPingLocationToString( const SteamNetworkPingLocation_t &amp;location, char *pszBuf, int cchBufSize );</code>Convert a ping location into a text format suitable for sending over the wire.  The format is a compact and human readable.  However, it is subject to change so please do not parse it yourself.  Your buffer must be at least k_cchMaxSteamNetworkingPingLocationString bytes.</summary>
        /// 
        public static void ConvertPingLocationToString(ref SteamNetworkPingLocation location, char* pszBuf, int cchBufSize) => Instance.ConvertPingLocationToString(ref location, pszBuf, cchBufSize);
        /// <summary><code>bool ParsePingLocationString( const char *pszString, SteamNetworkPingLocation_t &amp;result );</code>Parse back SteamNetworkPingLocation_t string.  Returns false if we couldn't understand the string.</summary>
        /// 
        public static bool ParsePingLocationString(UTF8StringPtr pszString, ref SteamNetworkPingLocation result) => Instance.ParsePingLocationString(pszString, ref result);
        /// <summary><code>bool CheckPingDataUpToDate( float flMaxAgeSeconds );</code>Check if the ping data of sufficient recency is available, and if it's too old, start refreshing it.<br />
        /// <br />
        /// Please only call this function when you <i>really</i> do need to force an immediate refresh of the data.  (For example, in response to a specific user input to refresh this information.)  Don't call it "just in case", before every connection, etc.  That will cause extra traffic to be sent for no benefit. The library will automatically refresh the information as needed.<br />
        /// <br />
        /// Returns true if sufficiently recent data is already available.<br />
        /// <br />
        /// Returns false if sufficiently recent data is not available.  In this case, ping measurement is initiated, if it is not already active.  (You cannot restart a measurement already in progress.)</summary>
        /// 
        public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) => Instance.CheckPingDataUpToDate(flMaxAgeSeconds);
        /// <summary><code>int GetPingToDataCenter( SteamNetworkingPOPID popID, SteamNetworkingPOPID *pViaRelayPoP );</code>Fetch ping time of best available relayed route from this host to the specified data center.</summary>
        /// 
        public static int GetPingToDataCenter(SteamNetworkingPOPID popID, SteamNetworkingPOPID* pViaRelayPoP) => Instance.GetPingToDataCenter(popID, pViaRelayPoP);
        /// <summary><code>int GetDirectPingToPOP( SteamNetworkingPOPID popID );</code>Get *direct* ping time to the relays at the point of presence.</summary>
        /// 
        public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) => Instance.GetDirectPingToPOP(popID);
        /// <summary><code>int GetPOPCount();</code>Get number of network points of presence in the config</summary>
        /// 
        public static int GetPOPCount() => Instance.GetPOPCount();
        /// <summary><code>int GetPOPList( SteamNetworkingPOPID *list, int nListSz );</code>Get list of all POP IDs.  Returns the number of entries that were filled into your list.</summary>
        /// 
        public static int GetPOPList(SteamNetworkingPOPID* list, int nListSz) => Instance.GetPOPList(list, nListSz);
        /// <summary><code>SteamNetworkingMicroseconds GetLocalTimestamp();</code><br />
        /// A general purpose high resolution local timer with the following properties:<br />
        /// <ul class="bb_ul "><li> Monotonicity is guaranteed.<br />
        /// </li><li> The initial value will be at least 24*3600*30*1e6, i.e. about 30 days worth of microseconds.  In this way, the timestamp value of 0 will always be at least "30 days ago".  Also, negative numbers will never be returned.<br />
        /// </li><li> Wraparound / overflow is not a practical concern.</li></ul><br />
        /// SteamNetworkingMessage_t::m_usecTimeReceived contains a timestamp that is from the same timer.<br />
        /// <br />
        /// If you are running under the debugger and stop the process, the clock might not advance the full wall clock time that has elapsed between calls.  If the process is not blocked from normal operation, the timestamp values will track wall clock time, even if you don't call the function frequently.<br />
        /// <br />
        /// The value is only meaningful for this run of the process.  Don't compare it to values obtained on another computer, or other runs of the same process.</summary>
        /// 
        public static SteamNetworkingMicroseconds GetLocalTimestamp() => Instance.GetLocalTimestamp();
        /// <summary><code>void SetDebugOutputFunction( ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc );</code><br />
        /// Set a function to receive network-related information that is useful for debugging.<br />
        /// <br />
        /// This can be extremely useful during development, but it can also be useful for troubleshooting problems with tech savvy end users.  If you have a console or other log that customers can examine, these log messages can often be helpful to troubleshoot network issues.(Especially any warning/error messages.)<br />
        /// <br />
        /// The detail level indicates what message to invoke your callback on.  Lower numeric value means more important, and the value you pass is the lowest priority (highest numeric value) you wish to receive callbacks for.  Except when debugging, you should only use k_ESteamNetworkingSocketsDebugOutputType_Msg or k_ESteamNetworkingSocketsDebugOutputType_Warning.  For best performance, do NOT request a high detail level and then filter out messages in your callback.  Instead, call this function to adjust the desired level of detail.<br />
        /// <br />
        /// The value here controls the detail level for most messages.  You can control the detail level for various subsystems (perhaps only for certain connections) by adjusting the configuration values k_ESteamNetworkingConfig_LogLevel_Xxxxx.<br />
        /// <br />
        /// <b>IMPORTANT</b>: This may be called from a service thread, while we own a mutex, etc.  <i>Your callback function must be threadsafe and fast!</i>  Do not make any other Steamworks calls from within the handler.</summary>
        /// 
        public static void SetDebugOutputFunction(SteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) => Instance.SetDebugOutputFunction(eDetailLevel, pfnFunc);
        /// <summary><code>bool IsFakeIPv4( uint32 nIPv4 );</code><br />
        /// Return true if an IPv4 address is one that might be used as a "fake" one.  This function is fast; it just does some logical tests on the IP and does not need to do any lookup operations.</summary>
        /// 
        public static bool IsFakeIPv4(uint nIPv4) => Instance.IsFakeIPv4(nIPv4);
        /// missing documentation
        public static SteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) => Instance.GetIPv4FakeIPType(nIPv4);
        /// <summary><code>EResult GetRealIdentityForFakeIP( const SteamNetworkingIPAddr &amp;fakeIP, SteamNetworkingIdentity *pOutRealIdentity );</code><br />
        /// Get the real identity associated with a given FakeIP.<br />
        /// <br />
        /// On failure, returns:<br />
        /// <ul class="bb_ul "><li> k_EResultInvalidParam: the IP is not a FakeIP.<br />
        /// </li><li> k_EResultNoMatch: we don't recognize that FakeIP and don't know the corresponding identity.</li></ul><br />
        /// FakeIP's used by active connections, or the FakeIPs assigned to local identities, will always work.  FakeIPs for recently destroyed connections will continue to return results for a little while, but not forever.  At some point, we will forget FakeIPs to save space.  It's reasonably safe to assume that you can read back the real identity of a connection very soon after it is destroyed.  But do not wait indefinitely.<br />
        /// 
        /// </summary>
        /// 
        public static Result GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, SteamNetworkingIdentity* pOutRealIdentity) => Instance.GetRealIdentityForFakeIP(ref fakeIP, pOutRealIdentity);
        /// missing documentation
        public static bool SetGlobalConfigValueInt32(SteamNetworkingConfigValueType eValue, int val) => Instance.SetGlobalConfigValueInt32(eValue, val);
        /// missing documentation
        public static bool SetGlobalConfigValueFloat(SteamNetworkingConfigValueType eValue, float val) => Instance.SetGlobalConfigValueFloat(eValue, val);
        /// missing documentation
        public static bool SetGlobalConfigValueString(SteamNetworkingConfigValueType eValue, UTF8StringPtr val) => Instance.SetGlobalConfigValueString(eValue, val);
        /// missing documentation
        public static bool SetGlobalConfigValuePtr(SteamNetworkingConfigValueType eValue, void* val) => Instance.SetGlobalConfigValuePtr(eValue, val);
        /// missing documentation
        public static bool SetConnectionConfigValueInt32(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, int val) => Instance.SetConnectionConfigValueInt32(hConn, eValue, val);
        /// missing documentation
        public static bool SetConnectionConfigValueFloat(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, float val) => Instance.SetConnectionConfigValueFloat(hConn, eValue, val);
        /// missing documentation
        public static bool SetConnectionConfigValueString(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, UTF8StringPtr val) => Instance.SetConnectionConfigValueString(hConn, eValue, val);
        /// missing documentation
        public static bool SetGlobalCallback_SteamNetConnectionStatusChanged(FnSteamNetConnectionStatusChanged fnCallback) => Instance.SetGlobalCallback_SteamNetConnectionStatusChanged(fnCallback);
        /// missing documentation
        public static bool SetGlobalCallback_SteamNetAuthenticationStatusChanged(FnSteamNetAuthenticationStatusChanged fnCallback) => Instance.SetGlobalCallback_SteamNetAuthenticationStatusChanged(fnCallback);
        /// missing documentation
        public static bool SetGlobalCallback_SteamRelayNetworkStatusChanged(FnSteamRelayNetworkStatusChanged fnCallback) => Instance.SetGlobalCallback_SteamRelayNetworkStatusChanged(fnCallback);
        /// missing documentation
        public static bool SetGlobalCallback_FakeIPResult(FnSteamNetworkingFakeIPResult fnCallback) => Instance.SetGlobalCallback_FakeIPResult(fnCallback);
        /// missing documentation
        public static bool SetGlobalCallback_MessagesSessionRequest(FnSteamNetworkingMessagesSessionRequest fnCallback) => Instance.SetGlobalCallback_MessagesSessionRequest(fnCallback);
        /// missing documentation
        public static bool SetGlobalCallback_MessagesSessionFailed(FnSteamNetworkingMessagesSessionFailed fnCallback) => Instance.SetGlobalCallback_MessagesSessionFailed(fnCallback);
        /// <summary><code>bool SetConfigValue( ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, intptr_t scopeObj,
        /// 	ESteamNetworkingConfigDataType eDataType, const void *pArg );</code><br />
        /// <br />
        /// Set a configuration value.<br />
        /// <ul class="bb_ul "><li> eValue: which value is being set<br />
        /// </li><li> eScope: Onto what type of object are you applying the setting?<br />
        /// </li><li> scopeArg: Which object you want to change?  (Ignored for global scope).  E.g. connection handle, listen socket handle, interface pointer, etc.<br />
        /// </li><li> eDataType: What type of data is in the buffer at pValue?  This must match the type of the variable exactly!<br />
        /// </li><li> pArg: Value to set it to.<br />
        /// <br />
        /// You can pass NULL to remove a non-global setting at this scope, causing the value for that object to use global defaults.  Or at global scope, passing NULL will reset any custom value and restore it to the system default.<br />
        /// <br />
        /// NOTE: When setting pointers (e.g. callback functions), do not pass the function pointer directly. Your argument should be a pointer to a function pointer.</li></ul></summary>
        /// 
        public static bool SetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType eDataType, void* pArg) => Instance.SetConfigValue(eValue, eScopeType, scopeObj, eDataType, pArg);
        /// missing documentation
        public static bool SetConfigValueStruct(ref SteamNetworkingConfigValue opt, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj) => Instance.SetConfigValueStruct(ref opt, eScopeType, scopeObj);
        /// missing documentation
        public static SteamNetworkingGetConfigValueResult GetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType* pOutDataType, void* pResult, int* cbResult) => Instance.GetConfigValue(eValue, eScopeType, scopeObj, pOutDataType, pResult, cbResult);
        /// missing documentation
        public static UTF8StringPtr GetConfigValueInfo(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigDataType* pOutDataType, SteamNetworkingConfigScope* pOutScope) => Instance.GetConfigValueInfo(eValue, pOutDataType, pOutScope);
        /// <summary><code>ESteamNetworkingConfigValue IterateGenericEditableConfigValues( ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars );</code><br />
        /// Iterate the list of all configuration values in the current environment that it might be possible to display or edit using a generic UI.  To get the first iterable value, pass k_ESteamNetworkingConfig_Invalid.  Returns k_ESteamNetworkingConfig_Invalid to signal end of list.<br />
        /// <br />
        /// The bEnumerateDevVars argument can be used to include "dev" vars.  These are vars that are recommended to only be editable in "debug" or "dev" mode and typically should not be shown in a retail environment where a malicious local user might use this to cheat.</summary>
        /// 
        public static SteamNetworkingConfigValueType IterateGenericEditableConfigValues(SteamNetworkingConfigValueType eCurrent, bool bEnumerateDevVars) => Instance.IterateGenericEditableConfigValues(eCurrent, bEnumerateDevVars);
        /// missing documentation
        public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, char* buf, uint cbBuf, bool bWithPort) => Instance.SteamNetworkingIPAddr_ToString(ref addr, buf, cbBuf, bWithPort);
        /// missing documentation
        public static bool SteamNetworkingIPAddr_ParseString(SteamNetworkingIPAddr* pAddr, UTF8StringPtr pszStr) => Instance.SteamNetworkingIPAddr_ParseString(pAddr, pszStr);
        /// missing documentation
        public static SteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) => Instance.SteamNetworkingIPAddr_GetFakeIPType(ref addr);
        /// missing documentation
        public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, char* buf, uint cbBuf) => Instance.SteamNetworkingIdentity_ToString(ref identity, buf, cbBuf);
        /// missing documentation
        public static bool SteamNetworkingIdentity_ParseString(SteamNetworkingIdentity* pIdentity, UTF8StringPtr pszStr) => Instance.SteamNetworkingIdentity_ParseString(pIdentity, pszStr);
    }
}