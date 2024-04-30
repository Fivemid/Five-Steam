using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ISteamMatchmakingRulesResponse
    public unsafe interface ISteamMatchmakingRulesResponse
    {
        public void RulesResponded(UTF8StringPtr pchRule, UTF8StringPtr pchValue);
        public void RulesFailedToRespond();
        public void RulesRefreshComplete();
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingRulesResponse_RulesResponded", CallingConvention = Platform.CC)]
        internal static extern void RulesResponded(void* self, UTF8StringPtr pchRule, UTF8StringPtr pchValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingRulesResponse_RulesFailedToRespond", CallingConvention = Platform.CC)]
        internal static extern void RulesFailedToRespond(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingRulesResponse_RulesRefreshComplete", CallingConvention = Platform.CC)]
        internal static extern void RulesRefreshComplete(void* self);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamMatchmakingRulesResponse
        {
            public void* self;
            public void RulesResponded(UTF8StringPtr pchRule, UTF8StringPtr pchValue) => ISteamMatchmakingRulesResponse.RulesResponded(self, pchRule, pchValue);
            public void RulesFailedToRespond() => ISteamMatchmakingRulesResponse.RulesFailedToRespond(self);
            public void RulesRefreshComplete() => ISteamMatchmakingRulesResponse.RulesRefreshComplete(self);
        }
    }
}