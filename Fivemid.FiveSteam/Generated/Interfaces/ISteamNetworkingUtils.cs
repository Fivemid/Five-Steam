using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Misc networking utilities for checking the local networking environment and estimating pings.<br />
    /// <br />
    /// Related documents:<br />
    /// <ul class="bb_ul "><li> <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets" class="bb_doclink">ISteamNetworkingSockets Interface</a> Connection-handle-oriented interface for sending and receiving messages.<br />
    /// </li><li> <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes" class="bb_doclink">steamnetworkingtypes.h</a> Miscellaneous types and utilities.<br />
    /// </li><li> <a href="https://partner.steamgames.com/doc/features/multiplayer/networking" class="bb_doclink">Steam Networking</a> overview of the different networking APIs.</li></ul><br />
    /// Member functions for ISteamNetworkingUtils are called through the global accessor function SteamNetworkingUtils().</summary>
    public unsafe interface ISteamNetworkingUtils
    {
        public SteamNetworkingMessage* AllocateMessage(int cbAllocateBuffer);
        public void InitRelayNetworkAccess();
        public SteamNetworkingAvailability GetRelayNetworkStatus(SteamRelayNetworkStatus* pDetails);
        public float GetLocalPingLocation(ref SteamNetworkPingLocation result);
        public int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation location1, ref SteamNetworkPingLocation location2);
        public int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation remoteLocation);
        public void ConvertPingLocationToString(ref SteamNetworkPingLocation location, byte* pszBuf, int cchBufSize);
        public bool ParsePingLocationString(UTF8StringPtr pszString, ref SteamNetworkPingLocation result);
        public bool CheckPingDataUpToDate(float flMaxAgeSeconds);
        public int GetPingToDataCenter(SteamNetworkingPOPID popID, SteamNetworkingPOPID* pViaRelayPoP);
        public int GetDirectPingToPOP(SteamNetworkingPOPID popID);
        public int GetPOPCount();
        public int GetPOPList(SteamNetworkingPOPID* list, int nListSz);
        public SteamNetworkingMicroseconds GetLocalTimestamp();
        public void SetDebugOutputFunction(SteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc);
        public bool IsFakeIPv4(uint nIPv4);
        public SteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4);
        public Result GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, SteamNetworkingIdentity* pOutRealIdentity);
        public bool SetGlobalConfigValueInt32(SteamNetworkingConfigValueType eValue, int val);
        public bool SetGlobalConfigValueFloat(SteamNetworkingConfigValueType eValue, float val);
        public bool SetGlobalConfigValueString(SteamNetworkingConfigValueType eValue, UTF8StringPtr val);
        public bool SetGlobalConfigValuePtr(SteamNetworkingConfigValueType eValue, void* val);
        public bool SetConnectionConfigValueInt32(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, int val);
        public bool SetConnectionConfigValueFloat(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, float val);
        public bool SetConnectionConfigValueString(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, UTF8StringPtr val);
        public bool SetGlobalCallback_SteamNetConnectionStatusChanged(FnSteamNetConnectionStatusChanged fnCallback);
        public bool SetGlobalCallback_SteamNetAuthenticationStatusChanged(FnSteamNetAuthenticationStatusChanged fnCallback);
        public bool SetGlobalCallback_SteamRelayNetworkStatusChanged(FnSteamRelayNetworkStatusChanged fnCallback);
        public bool SetGlobalCallback_FakeIPResult(FnSteamNetworkingFakeIPResult fnCallback);
        public bool SetGlobalCallback_MessagesSessionRequest(FnSteamNetworkingMessagesSessionRequest fnCallback);
        public bool SetGlobalCallback_MessagesSessionFailed(FnSteamNetworkingMessagesSessionFailed fnCallback);
        public bool SetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType eDataType, void* pArg);
        public bool SetConfigValueStruct(ref SteamNetworkingConfigValue opt, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj);
        public SteamNetworkingGetConfigValueResult GetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType* pOutDataType, void* pResult, int* cbResult);
        public UTF8StringPtr GetConfigValueInfo(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigDataType* pOutDataType, SteamNetworkingConfigScope* pOutScope);
        public SteamNetworkingConfigValueType IterateGenericEditableConfigValues(SteamNetworkingConfigValueType eCurrent, bool bEnumerateDevVars);
        public void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, byte* buf, uint cbBuf, bool bWithPort);
        public bool SteamNetworkingIPAddr_ParseString(SteamNetworkingIPAddr* pAddr, UTF8StringPtr pszStr);
        public SteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr);
        public void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, byte* buf, uint cbBuf);
        public bool SteamNetworkingIdentity_ParseString(SteamNetworkingIdentity* pIdentity, UTF8StringPtr pszStr);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_AllocateMessage", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingMessage* AllocateMessage(void* self, int cbAllocateBuffer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_InitRelayNetworkAccess", CallingConvention = Platform.CC)]
        internal static extern void InitRelayNetworkAccess(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetRelayNetworkStatus", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingAvailability GetRelayNetworkStatus(void* self, SteamRelayNetworkStatus* pDetails);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetLocalPingLocation", CallingConvention = Platform.CC)]
        internal static extern float GetLocalPingLocation(void* self, ref SteamNetworkPingLocation result);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations", CallingConvention = Platform.CC)]
        internal static extern int EstimatePingTimeBetweenTwoLocations(void* self, ref SteamNetworkPingLocation location1, ref SteamNetworkPingLocation location2);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_EstimatePingTimeFromLocalHost", CallingConvention = Platform.CC)]
        internal static extern int EstimatePingTimeFromLocalHost(void* self, ref SteamNetworkPingLocation remoteLocation);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_ConvertPingLocationToString", CallingConvention = Platform.CC)]
        internal static extern void ConvertPingLocationToString(void* self, ref SteamNetworkPingLocation location, byte* pszBuf, int cchBufSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_ParsePingLocationString", CallingConvention = Platform.CC)]
        internal static extern bool ParsePingLocationString(void* self, UTF8StringPtr pszString, ref SteamNetworkPingLocation result);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_CheckPingDataUpToDate", CallingConvention = Platform.CC)]
        internal static extern bool CheckPingDataUpToDate(void* self, float flMaxAgeSeconds);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetPingToDataCenter", CallingConvention = Platform.CC)]
        internal static extern int GetPingToDataCenter(void* self, SteamNetworkingPOPID popID, SteamNetworkingPOPID* pViaRelayPoP);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetDirectPingToPOP", CallingConvention = Platform.CC)]
        internal static extern int GetDirectPingToPOP(void* self, SteamNetworkingPOPID popID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetPOPCount", CallingConvention = Platform.CC)]
        internal static extern int GetPOPCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetPOPList", CallingConvention = Platform.CC)]
        internal static extern int GetPOPList(void* self, SteamNetworkingPOPID* list, int nListSz);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetLocalTimestamp", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingMicroseconds GetLocalTimestamp(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetDebugOutputFunction", CallingConvention = Platform.CC)]
        internal static extern void SetDebugOutputFunction(void* self, SteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_IsFakeIPv4", CallingConvention = Platform.CC)]
        internal static extern bool IsFakeIPv4(void* self, uint nIPv4);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetIPv4FakeIPType", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingFakeIPType GetIPv4FakeIPType(void* self, uint nIPv4);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetRealIdentityForFakeIP", CallingConvention = Platform.CC)]
        internal static extern Result GetRealIdentityForFakeIP(void* self, ref SteamNetworkingIPAddr fakeIP, SteamNetworkingIdentity* pOutRealIdentity);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValueInt32", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalConfigValueInt32(void* self, SteamNetworkingConfigValueType eValue, int val);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValueFloat", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalConfigValueFloat(void* self, SteamNetworkingConfigValueType eValue, float val);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValueString", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalConfigValueString(void* self, SteamNetworkingConfigValueType eValue, UTF8StringPtr val);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalConfigValuePtr", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalConfigValuePtr(void* self, SteamNetworkingConfigValueType eValue, void* val);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetConnectionConfigValueInt32", CallingConvention = Platform.CC)]
        internal static extern bool SetConnectionConfigValueInt32(void* self, HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, int val);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetConnectionConfigValueFloat", CallingConvention = Platform.CC)]
        internal static extern bool SetConnectionConfigValueFloat(void* self, HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, float val);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetConnectionConfigValueString", CallingConvention = Platform.CC)]
        internal static extern bool SetConnectionConfigValueString(void* self, HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, UTF8StringPtr val);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_SteamNetConnectionStatusChanged", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalCallback_SteamNetConnectionStatusChanged(void* self, FnSteamNetConnectionStatusChanged fnCallback);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_SteamNetAuthenticationStatusChanged", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalCallback_SteamNetAuthenticationStatusChanged(void* self, FnSteamNetAuthenticationStatusChanged fnCallback);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_SteamRelayNetworkStatusChanged", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalCallback_SteamRelayNetworkStatusChanged(void* self, FnSteamRelayNetworkStatusChanged fnCallback);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_FakeIPResult", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalCallback_FakeIPResult(void* self, FnSteamNetworkingFakeIPResult fnCallback);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_MessagesSessionRequest", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalCallback_MessagesSessionRequest(void* self, FnSteamNetworkingMessagesSessionRequest fnCallback);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetGlobalCallback_MessagesSessionFailed", CallingConvention = Platform.CC)]
        internal static extern bool SetGlobalCallback_MessagesSessionFailed(void* self, FnSteamNetworkingMessagesSessionFailed fnCallback);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetConfigValue", CallingConvention = Platform.CC)]
        internal static extern bool SetConfigValue(void* self, SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType eDataType, void* pArg);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SetConfigValueStruct", CallingConvention = Platform.CC)]
        internal static extern bool SetConfigValueStruct(void* self, ref SteamNetworkingConfigValue opt, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetConfigValue", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingGetConfigValueResult GetConfigValue(void* self, SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType* pOutDataType, void* pResult, int* cbResult);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_GetConfigValueInfo", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetConfigValueInfo(void* self, SteamNetworkingConfigValueType eValue, SteamNetworkingConfigDataType* pOutDataType, SteamNetworkingConfigScope* pOutScope);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_IterateGenericEditableConfigValues", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingConfigValueType IterateGenericEditableConfigValues(void* self, SteamNetworkingConfigValueType eCurrent, bool bEnumerateDevVars);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString", CallingConvention = Platform.CC)]
        internal static extern void SteamNetworkingIPAddr_ToString(void* self, ref SteamNetworkingIPAddr addr, byte* buf, uint cbBuf, bool bWithPort);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString", CallingConvention = Platform.CC)]
        internal static extern bool SteamNetworkingIPAddr_ParseString(void* self, SteamNetworkingIPAddr* pAddr, UTF8StringPtr pszStr);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIPAddr_GetFakeIPType", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(void* self, ref SteamNetworkingIPAddr addr);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIdentity_ToString", CallingConvention = Platform.CC)]
        internal static extern void SteamNetworkingIdentity_ToString(void* self, ref SteamNetworkingIdentity identity, byte* buf, uint cbBuf);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString", CallingConvention = Platform.CC)]
        internal static extern bool SteamNetworkingIdentity_ParseString(void* self, SteamNetworkingIdentity* pIdentity, UTF8StringPtr pszStr);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamNetworkingUtils
        {
            public void* self;
            public SteamNetworkingMessage* AllocateMessage(int cbAllocateBuffer) => ISteamNetworkingUtils.AllocateMessage(self, cbAllocateBuffer);
            public void InitRelayNetworkAccess() => ISteamNetworkingUtils.InitRelayNetworkAccess(self);
            public SteamNetworkingAvailability GetRelayNetworkStatus(SteamRelayNetworkStatus* pDetails) => ISteamNetworkingUtils.GetRelayNetworkStatus(self, pDetails);
            public float GetLocalPingLocation(ref SteamNetworkPingLocation result) => ISteamNetworkingUtils.GetLocalPingLocation(self, ref result);
            public int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation location1, ref SteamNetworkPingLocation location2) => ISteamNetworkingUtils.EstimatePingTimeBetweenTwoLocations(self, ref location1, ref location2);
            public int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation remoteLocation) => ISteamNetworkingUtils.EstimatePingTimeFromLocalHost(self, ref remoteLocation);
            public void ConvertPingLocationToString(ref SteamNetworkPingLocation location, byte* pszBuf, int cchBufSize) => ISteamNetworkingUtils.ConvertPingLocationToString(self, ref location, pszBuf, cchBufSize);
            public bool ParsePingLocationString(UTF8StringPtr pszString, ref SteamNetworkPingLocation result) => ISteamNetworkingUtils.ParsePingLocationString(self, pszString, ref result);
            public bool CheckPingDataUpToDate(float flMaxAgeSeconds) => ISteamNetworkingUtils.CheckPingDataUpToDate(self, flMaxAgeSeconds);
            public int GetPingToDataCenter(SteamNetworkingPOPID popID, SteamNetworkingPOPID* pViaRelayPoP) => ISteamNetworkingUtils.GetPingToDataCenter(self, popID, pViaRelayPoP);
            public int GetDirectPingToPOP(SteamNetworkingPOPID popID) => ISteamNetworkingUtils.GetDirectPingToPOP(self, popID);
            public int GetPOPCount() => ISteamNetworkingUtils.GetPOPCount(self);
            public int GetPOPList(SteamNetworkingPOPID* list, int nListSz) => ISteamNetworkingUtils.GetPOPList(self, list, nListSz);
            public SteamNetworkingMicroseconds GetLocalTimestamp() => ISteamNetworkingUtils.GetLocalTimestamp(self);
            public void SetDebugOutputFunction(SteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) => ISteamNetworkingUtils.SetDebugOutputFunction(self, eDetailLevel, pfnFunc);
            public bool IsFakeIPv4(uint nIPv4) => ISteamNetworkingUtils.IsFakeIPv4(self, nIPv4);
            public SteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4) => ISteamNetworkingUtils.GetIPv4FakeIPType(self, nIPv4);
            public Result GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, SteamNetworkingIdentity* pOutRealIdentity) => ISteamNetworkingUtils.GetRealIdentityForFakeIP(self, ref fakeIP, pOutRealIdentity);
            public bool SetGlobalConfigValueInt32(SteamNetworkingConfigValueType eValue, int val) => ISteamNetworkingUtils.SetGlobalConfigValueInt32(self, eValue, val);
            public bool SetGlobalConfigValueFloat(SteamNetworkingConfigValueType eValue, float val) => ISteamNetworkingUtils.SetGlobalConfigValueFloat(self, eValue, val);
            public bool SetGlobalConfigValueString(SteamNetworkingConfigValueType eValue, UTF8StringPtr val) => ISteamNetworkingUtils.SetGlobalConfigValueString(self, eValue, val);
            public bool SetGlobalConfigValuePtr(SteamNetworkingConfigValueType eValue, void* val) => ISteamNetworkingUtils.SetGlobalConfigValuePtr(self, eValue, val);
            public bool SetConnectionConfigValueInt32(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, int val) => ISteamNetworkingUtils.SetConnectionConfigValueInt32(self, hConn, eValue, val);
            public bool SetConnectionConfigValueFloat(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, float val) => ISteamNetworkingUtils.SetConnectionConfigValueFloat(self, hConn, eValue, val);
            public bool SetConnectionConfigValueString(HSteamNetConnection hConn, SteamNetworkingConfigValueType eValue, UTF8StringPtr val) => ISteamNetworkingUtils.SetConnectionConfigValueString(self, hConn, eValue, val);
            public bool SetGlobalCallback_SteamNetConnectionStatusChanged(FnSteamNetConnectionStatusChanged fnCallback) => ISteamNetworkingUtils.SetGlobalCallback_SteamNetConnectionStatusChanged(self, fnCallback);
            public bool SetGlobalCallback_SteamNetAuthenticationStatusChanged(FnSteamNetAuthenticationStatusChanged fnCallback) => ISteamNetworkingUtils.SetGlobalCallback_SteamNetAuthenticationStatusChanged(self, fnCallback);
            public bool SetGlobalCallback_SteamRelayNetworkStatusChanged(FnSteamRelayNetworkStatusChanged fnCallback) => ISteamNetworkingUtils.SetGlobalCallback_SteamRelayNetworkStatusChanged(self, fnCallback);
            public bool SetGlobalCallback_FakeIPResult(FnSteamNetworkingFakeIPResult fnCallback) => ISteamNetworkingUtils.SetGlobalCallback_FakeIPResult(self, fnCallback);
            public bool SetGlobalCallback_MessagesSessionRequest(FnSteamNetworkingMessagesSessionRequest fnCallback) => ISteamNetworkingUtils.SetGlobalCallback_MessagesSessionRequest(self, fnCallback);
            public bool SetGlobalCallback_MessagesSessionFailed(FnSteamNetworkingMessagesSessionFailed fnCallback) => ISteamNetworkingUtils.SetGlobalCallback_MessagesSessionFailed(self, fnCallback);
            public bool SetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType eDataType, void* pArg) => ISteamNetworkingUtils.SetConfigValue(self, eValue, eScopeType, scopeObj, eDataType, pArg);
            public bool SetConfigValueStruct(ref SteamNetworkingConfigValue opt, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj) => ISteamNetworkingUtils.SetConfigValueStruct(self, ref opt, eScopeType, scopeObj);
            public SteamNetworkingGetConfigValueResult GetConfigValue(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigScope eScopeType, IntPtr scopeObj, SteamNetworkingConfigDataType* pOutDataType, void* pResult, int* cbResult) => ISteamNetworkingUtils.GetConfigValue(self, eValue, eScopeType, scopeObj, pOutDataType, pResult, cbResult);
            public UTF8StringPtr GetConfigValueInfo(SteamNetworkingConfigValueType eValue, SteamNetworkingConfigDataType* pOutDataType, SteamNetworkingConfigScope* pOutScope) => ISteamNetworkingUtils.GetConfigValueInfo(self, eValue, pOutDataType, pOutScope);
            public SteamNetworkingConfigValueType IterateGenericEditableConfigValues(SteamNetworkingConfigValueType eCurrent, bool bEnumerateDevVars) => ISteamNetworkingUtils.IterateGenericEditableConfigValues(self, eCurrent, bEnumerateDevVars);
            public void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, byte* buf, uint cbBuf, bool bWithPort) => ISteamNetworkingUtils.SteamNetworkingIPAddr_ToString(self, ref addr, buf, cbBuf, bWithPort);
            public bool SteamNetworkingIPAddr_ParseString(SteamNetworkingIPAddr* pAddr, UTF8StringPtr pszStr) => ISteamNetworkingUtils.SteamNetworkingIPAddr_ParseString(self, pAddr, pszStr);
            public SteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr) => ISteamNetworkingUtils.SteamNetworkingIPAddr_GetFakeIPType(self, ref addr);
            public void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, byte* buf, uint cbBuf) => ISteamNetworkingUtils.SteamNetworkingIdentity_ToString(self, ref identity, buf, cbBuf);
            public bool SteamNetworkingIdentity_ParseString(SteamNetworkingIdentity* pIdentity, UTF8StringPtr pszStr) => ISteamNetworkingUtils.SteamNetworkingIdentity_ParseString(self, pIdentity, pszStr);
        }
    }
}