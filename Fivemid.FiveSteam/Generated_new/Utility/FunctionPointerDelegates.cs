using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public struct FunctionPointerDelegates
    {
        /// <summary>void (*)(void *) -> 1 -> void *</summary>
        public unsafe delegate void void_Ptr(void* arg0);
        /// <summary>void (*)(SteamInputActionEvent_t *) -> 1 -> SteamInputActionEvent*</summary>
        public unsafe delegate void SteamInputActionEventPtr(SteamInputActionEvent* arg0);
        /// <summary>void (*)(SteamNetConnectionStatusChangedCallback_t *) -> 1 -> SteamNetConnectionStatusChangedCallback*</summary>
        public unsafe delegate void SteamNetConnectionStatusChangedCallbackPtr(SteamNetConnectionStatusChangedCallback* arg0);
        /// <summary>void (*)(SteamNetAuthenticationStatus_t *) -> 1 -> SteamNetAuthenticationStatus*</summary>
        public unsafe delegate void SteamNetAuthenticationStatusPtr(SteamNetAuthenticationStatus* arg0);
        /// <summary>void (*)(SteamRelayNetworkStatus_t *) -> 1 -> SteamRelayNetworkStatus*</summary>
        public unsafe delegate void SteamRelayNetworkStatusPtr(SteamRelayNetworkStatus* arg0);
        /// <summary>void (*)(SteamNetworkingMessagesSessionRequest_t *) -> 1 -> SteamNetworkingMessagesSessionRequest*</summary>
        public unsafe delegate void SteamNetworkingMessagesSessionRequestPtr(SteamNetworkingMessagesSessionRequest* arg0);
        /// <summary>void (*)(SteamNetworkingMessagesSessionFailed_t *) -> 1 -> SteamNetworkingMessagesSessionFailed*</summary>
        public unsafe delegate void SteamNetworkingMessagesSessionFailedPtr(SteamNetworkingMessagesSessionFailed* arg0);
        /// <summary>void (*)(SteamNetworkingFakeIPResult_t *) -> 1 -> SteamNetworkingFakeIPResult*</summary>
        public unsafe delegate void SteamNetworkingFakeIPResultPtr(SteamNetworkingFakeIPResult* arg0);
        /// <summary>void (*)(ESteamNetworkingSocketsDebugOutputType, const char *) -> 2 -> UTF8StringPtr</summary>
        public unsafe delegate void SteamNetworkingSocketsDebugOutputType_UTF8StringPtr(SteamNetworkingSocketsDebugOutputType arg0, UTF8StringPtr arg1);
        /// <summary>void (*)(SteamNetworkingMessage_t *) -> 1 -> SteamNetworkingMessage*</summary>
        public unsafe delegate void SteamNetworkingMessagePtr(SteamNetworkingMessage* arg0);
    }
}