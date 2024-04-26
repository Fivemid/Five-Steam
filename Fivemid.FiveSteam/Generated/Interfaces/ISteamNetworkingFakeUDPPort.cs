using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ISteamNetworkingFakeUDPPort
    public unsafe interface ISteamNetworkingFakeUDPPort
    {
        public void DestroyFakeUDPPort();
        public Result SendMessageToFakeIP(ref SteamNetworkingIPAddr remoteAddress, void* pData, uint cbData, int nSendFlags);
        public int ReceiveMessages(SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        public void ScheduleCleanup(ref SteamNetworkingIPAddr remoteAddress);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingFakeUDPPort_DestroyFakeUDPPort", CallingConvention = Platform.CC)]
        internal static extern void DestroyFakeUDPPort(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingFakeUDPPort_SendMessageToFakeIP", CallingConvention = Platform.CC)]
        internal static extern Result SendMessageToFakeIP(void* self, ref SteamNetworkingIPAddr remoteAddress, void* pData, uint cbData, int nSendFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingFakeUDPPort_ReceiveMessages", CallingConvention = Platform.CC)]
        internal static extern int ReceiveMessages(void* self, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingFakeUDPPort_ScheduleCleanup", CallingConvention = Platform.CC)]
        internal static extern void ScheduleCleanup(void* self, ref SteamNetworkingIPAddr remoteAddress);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamNetworkingFakeUDPPort
        {
            public void* self;
            public void DestroyFakeUDPPort() => ISteamNetworkingFakeUDPPort.DestroyFakeUDPPort(self);
            public Result SendMessageToFakeIP(ref SteamNetworkingIPAddr remoteAddress, void* pData, uint cbData, int nSendFlags) => ISteamNetworkingFakeUDPPort.SendMessageToFakeIP(self, ref remoteAddress, pData, cbData, nSendFlags);
            public int ReceiveMessages(SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => ISteamNetworkingFakeUDPPort.ReceiveMessages(self, ppOutMessages, nMaxMessages);
            public void ScheduleCleanup(ref SteamNetworkingIPAddr remoteAddress) => ISteamNetworkingFakeUDPPort.ScheduleCleanup(self, ref remoteAddress);
        }
    }
}