using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamNetworkingUtils_SteamAPI
    {
        public static ISteamNetworkingUtils.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingUtils_SteamAPI_v004", CallingConvention = Platform.CC)]
        private static extern ISteamNetworkingUtils.Instance Accessor();
        /// <summary></summary>
        public static SteamNetworkingMessage* AllocateMessage(int cbAllocateBuffer) => Instance.AllocateMessage(cbAllocateBuffer);
        /// <summary></summary>
        public static void InitRelayNetworkAccess() => Instance.InitRelayNetworkAccess();
        /// <summary></summary>
        public static SteamNetworkingAvailability GetRelayNetworkStatus(SteamRelayNetworkStatus* pDetails) => Instance.GetRelayNetworkStatus(pDetails);
        /// <summary></summary>
        public static float GetLocalPingLocation(ref SteamNetworkPingLocation result) => Instance.GetLocalPingLocation(ref result);
        /// <summary></summary>
        public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation location1, ref SteamNetworkPingLocation location2) => Instance.EstimatePingTimeBetweenTwoLocations(ref location1, ref location2);
        /// <summary></summary>
        public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation remoteLocation) => Instance.EstimatePingTimeFromLocalHost(ref remoteLocation);
        /// <summary></summary>
        public static void ConvertPingLocationToString(ref SteamNetworkPingLocation location, char* pszBuf, int cchBufSize) => Instance.ConvertPingLocationToString(ref location, pszBuf, cchBufSize);
        /// <summary></summary>
        public static bool ParsePingLocationString(UTF8StringPtr pszString, ref SteamNetworkPingLocation result) => Instance.ParsePingLocationString(pszString, ref result);
        /// <summary></summary>
        public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) => Instance.CheckPingDataUpToDate(flMaxAgeSeconds);
        /// <summary></summary>
        public static int GetPingToDataCenter(SteamNetworkingPOPID popID, SteamNetworkingPOPID* pViaRelayPoP) => Instance.GetPingToDataCenter(popID, pViaRelayPoP);
        /// <summary></summary>
        public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) => Instance.GetDirectPingToPOP(popID);
        /// <summary></summary>
        public static int GetPOPCount() => Instance.GetPOPCount();
        /// <summary></summary>
        public static int GetPOPList(SteamNetworkingPOPID* list, int nListSz) => Instance.GetPOPList(list, nListSz);
        /// <summary></summary>
        public static SteamNetworkingMicroseconds GetLocalTimestamp() => Instance.GetLocalTimestamp();
        /// <summary></summary>
        public static void SetDebugOutputFunction(SteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) => Instance.SetDebugOutputFunction(eDetailLevel, pfnFunc);
        /// <summary></summary>
        public static bool IsFakeIPv4(uint nIPv4) => Instance.IsFakeIPv4(nIPv4);
        /// <summary></summary>
        public static SteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) => Instance.GetIPv4FakeIPType(nIPv4);
        /// <summary></summary>
        public static Result GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, SteamNetworkingIdentity* pOutRealIdentity) => Instance.GetRealIdentityForFakeIP(ref fakeIP, pOutRealIdentity);
        /// <summary></summary>
        public static bool SetGlobalConfigValueInt32(SteamNetworkingConfigValueType eValue, int val) => Instance.SetGlobalConfigValueInt32(eValue, val);
        /// <summary></summary>
        public static bool SetGlobalConfigValueFloat(SteamNetworkingConfigValueType eValue, float val) => Instance.SetGlobalConfigValueFloat(eValue, val);
        /// <summary></summary>
        public static bool SetGlobalConfigValueString(SteamNetworkingConfigValueType eValue, UTF8StringPtr val) => Instance.SetGlobalConfigValueString(eValue, val);
        /// <summary></summary>
        public static bool SetGlobalConfigValuePtr(SteamNetworkingConfigValueType eValue, void* val) => Instance.SetGlobalConfigValuePtr(eValue, val);
        /// <summary></summary>
        public static bool SetConnectionConfigValueInt32(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, int val) => Instance.SetConnectionConfigValueInt32(hConn, eValue, val);
        /// <summary></summary>
        public static bool SetConnectionConfigValueFloat(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, float val) => Instance.SetConnectionConfigValueFloat(hConn, eValue, val);
        /// <summary></summary>
        public static bool SetConnectionConfigValueString(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, UTF8StringPtr val) => Instance.SetConnectionConfigValueString(hConn, eValue, val);
        /// <summary></summary>
        public static bool SetGlobalCallback_SteamNetConnectionStatusChanged(FnSteamNetConnectionStatusChanged fnCallback) => Instance.SetGlobalCallback_SteamNetConnectionStatusChanged(fnCallback);
        /// <summary></summary>
        public static bool SetGlobalCallback_SteamNetAuthenticationStatusChanged(FnSteamNetAuthenticationStatusChanged fnCallback) => Instance.SetGlobalCallback_SteamNetAuthenticationStatusChanged(fnCallback);
        /// <summary></summary>
        public static bool SetGlobalCallback_SteamRelayNetworkStatusChanged(FnSteamRelayNetworkStatusChanged fnCallback) => Instance.SetGlobalCallback_SteamRelayNetworkStatusChanged(fnCallback);
        /// <summary></summary>
        public static bool SetGlobalCallback_FakeIPResult(FnSteamNetworkingFakeIPResult fnCallback) => Instance.SetGlobalCallback_FakeIPResult(fnCallback);
        /// <summary></summary>
        public static bool SetGlobalCallback_MessagesSessionRequest(FnSteamNetworkingMessagesSessionRequest fnCallback) => Instance.SetGlobalCallback_MessagesSessionRequest(fnCallback);
        /// <summary></summary>
        public static bool SetGlobalCallback_MessagesSessionFailed(FnSteamNetworkingMessagesSessionFailed fnCallback) => Instance.SetGlobalCallback_MessagesSessionFailed(fnCallback);
        /// <summary></summary>
        public static bool SetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType eDataType, void* pArg) => Instance.SetConfigValue(eValue, eScopeType, scopeObj, eDataType, pArg);
        /// <summary></summary>
        public static bool SetConfigValueStruct(ref SteamNetworkingConfigValue opt, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj) => Instance.SetConfigValueStruct(ref opt, eScopeType, scopeObj);
        /// <summary></summary>
        public static SteamNetworkingGetConfigValueResult GetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType* pOutDataType, void* pResult, int* cbResult) => Instance.GetConfigValue(eValue, eScopeType, scopeObj, pOutDataType, pResult, cbResult);
        /// <summary></summary>
        public static UTF8StringPtr GetConfigValueInfo(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigDataType* pOutDataType, SteamNetworkingConfigScope* pOutScope) => Instance.GetConfigValueInfo(eValue, pOutDataType, pOutScope);
        /// <summary></summary>
        public static SteamNetworkingConfigValueType IterateGenericEditableConfigValues(SteamNetworkingConfigValueType eCurrent, bool bEnumerateDevVars) => Instance.IterateGenericEditableConfigValues(eCurrent, bEnumerateDevVars);
        /// <summary></summary>
        public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, char* buf, uint cbBuf, bool bWithPort) => Instance.SteamNetworkingIPAddr_ToString(ref addr, buf, cbBuf, bWithPort);
        /// <summary></summary>
        public static bool SteamNetworkingIPAddr_ParseString(SteamNetworkingIPAddr* pAddr, UTF8StringPtr pszStr) => Instance.SteamNetworkingIPAddr_ParseString(pAddr, pszStr);
        /// <summary></summary>
        public static SteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) => Instance.SteamNetworkingIPAddr_GetFakeIPType(ref addr);
        /// <summary></summary>
        public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, char* buf, uint cbBuf) => Instance.SteamNetworkingIdentity_ToString(ref identity, buf, cbBuf);
        /// <summary></summary>
        public static bool SteamNetworkingIdentity_ParseString(SteamNetworkingIdentity* pIdentity, UTF8StringPtr pszStr) => Instance.SteamNetworkingIdentity_ParseString(pIdentity, pszStr);
    }
}