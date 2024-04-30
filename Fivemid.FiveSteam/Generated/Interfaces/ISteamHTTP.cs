using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// A small and easy to use HTTP client to send and receive data from the web.</summary>
    public unsafe interface ISteamHTTP
    {
        public HTTPRequestHandle CreateHTTPRequest(HTTPMethod eHTTPRequestMethod, UTF8StringPtr pchAbsoluteURL);
        public bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);
        public bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);
        public bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, UTF8StringPtr pchHeaderValue);
        public bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, UTF8StringPtr pchParamName, UTF8StringPtr pchParamValue);
        public bool SendHTTPRequest(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle);
        public bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle);
        public bool DeferHTTPRequest(HTTPRequestHandle hRequest);
        public bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest);
        public bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, uint* unResponseHeaderSize);
        public bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, byte* pHeaderValueBuffer, uint unBufferSize);
        public bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, uint* unBodySize);
        public bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte* pBodyDataBuffer, uint unBufferSize);
        public bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte* pBodyDataBuffer, uint unBufferSize);
        public bool ReleaseHTTPRequest(HTTPRequestHandle hRequest);
        public bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, float* pflPercentOut);
        public bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, UTF8StringPtr pchContentType, byte* pubBody, uint unBodyLen);
        public HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify);
        public bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);
        public bool SetCookie(HTTPCookieContainerHandle hCookieContainer, UTF8StringPtr pchHost, UTF8StringPtr pchUrl, UTF8StringPtr pchCookie);
        public bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);
        public bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, UTF8StringPtr pchUserAgentInfo);
        public bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);
        public bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);
        public bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, bool* pbWasTimedOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_CreateHTTPRequest", CallingConvention = Platform.CC)]
        internal static extern HTTPRequestHandle CreateHTTPRequest(void* self, HTTPMethod eHTTPRequestMethod, UTF8StringPtr pchAbsoluteURL);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestContextValue", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestContextValue(void* self, HTTPRequestHandle hRequest, ulong ulContextValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestNetworkActivityTimeout", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestNetworkActivityTimeout(void* self, HTTPRequestHandle hRequest, uint unTimeoutSeconds);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestHeaderValue", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestHeaderValue(void* self, HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, UTF8StringPtr pchHeaderValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestGetOrPostParameter", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestGetOrPostParameter(void* self, HTTPRequestHandle hRequest, UTF8StringPtr pchParamName, UTF8StringPtr pchParamValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequest", CallingConvention = Platform.CC)]
        internal static extern bool SendHTTPRequest(void* self, HTTPRequestHandle hRequest, SteamAPICall* pCallHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SendHTTPRequestAndStreamResponse", CallingConvention = Platform.CC)]
        internal static extern bool SendHTTPRequestAndStreamResponse(void* self, HTTPRequestHandle hRequest, SteamAPICall* pCallHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_DeferHTTPRequest", CallingConvention = Platform.CC)]
        internal static extern bool DeferHTTPRequest(void* self, HTTPRequestHandle hRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_PrioritizeHTTPRequest", CallingConvention = Platform.CC)]
        internal static extern bool PrioritizeHTTPRequest(void* self, HTTPRequestHandle hRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderSize", CallingConvention = Platform.CC)]
        internal static extern bool GetHTTPResponseHeaderSize(void* self, HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, uint* unResponseHeaderSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseHeaderValue", CallingConvention = Platform.CC)]
        internal static extern bool GetHTTPResponseHeaderValue(void* self, HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, byte* pHeaderValueBuffer, uint unBufferSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodySize", CallingConvention = Platform.CC)]
        internal static extern bool GetHTTPResponseBodySize(void* self, HTTPRequestHandle hRequest, uint* unBodySize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPResponseBodyData", CallingConvention = Platform.CC)]
        internal static extern bool GetHTTPResponseBodyData(void* self, HTTPRequestHandle hRequest, byte* pBodyDataBuffer, uint unBufferSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPStreamingResponseBodyData", CallingConvention = Platform.CC)]
        internal static extern bool GetHTTPStreamingResponseBodyData(void* self, HTTPRequestHandle hRequest, uint cOffset, byte* pBodyDataBuffer, uint unBufferSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseHTTPRequest", CallingConvention = Platform.CC)]
        internal static extern bool ReleaseHTTPRequest(void* self, HTTPRequestHandle hRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPDownloadProgressPct", CallingConvention = Platform.CC)]
        internal static extern bool GetHTTPDownloadProgressPct(void* self, HTTPRequestHandle hRequest, float* pflPercentOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRawPostBody", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestRawPostBody(void* self, HTTPRequestHandle hRequest, UTF8StringPtr pchContentType, byte* pubBody, uint unBodyLen);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_CreateCookieContainer", CallingConvention = Platform.CC)]
        internal static extern HTTPCookieContainerHandle CreateCookieContainer(void* self, bool bAllowResponsesToModify);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_ReleaseCookieContainer", CallingConvention = Platform.CC)]
        internal static extern bool ReleaseCookieContainer(void* self, HTTPCookieContainerHandle hCookieContainer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetCookie", CallingConvention = Platform.CC)]
        internal static extern bool SetCookie(void* self, HTTPCookieContainerHandle hCookieContainer, UTF8StringPtr pchHost, UTF8StringPtr pchUrl, UTF8StringPtr pchCookie);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestCookieContainer", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestCookieContainer(void* self, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestUserAgentInfo", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestUserAgentInfo(void* self, HTTPRequestHandle hRequest, UTF8StringPtr pchUserAgentInfo);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestRequiresVerifiedCertificate(void* self, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS", CallingConvention = Platform.CC)]
        internal static extern bool SetHTTPRequestAbsoluteTimeoutMS(void* self, HTTPRequestHandle hRequest, uint unMilliseconds);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamHTTP_GetHTTPRequestWasTimedOut", CallingConvention = Platform.CC)]
        internal static extern bool GetHTTPRequestWasTimedOut(void* self, HTTPRequestHandle hRequest, bool* pbWasTimedOut);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamHTTP
        {
            public void* self;
            public HTTPRequestHandle CreateHTTPRequest(HTTPMethod eHTTPRequestMethod, UTF8StringPtr pchAbsoluteURL) => ISteamHTTP.CreateHTTPRequest(self, eHTTPRequestMethod, pchAbsoluteURL);
            public bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) => ISteamHTTP.SetHTTPRequestContextValue(self, hRequest, ulContextValue);
            public bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) => ISteamHTTP.SetHTTPRequestNetworkActivityTimeout(self, hRequest, unTimeoutSeconds);
            public bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, UTF8StringPtr pchHeaderValue) => ISteamHTTP.SetHTTPRequestHeaderValue(self, hRequest, pchHeaderName, pchHeaderValue);
            public bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, UTF8StringPtr pchParamName, UTF8StringPtr pchParamValue) => ISteamHTTP.SetHTTPRequestGetOrPostParameter(self, hRequest, pchParamName, pchParamValue);
            public bool SendHTTPRequest(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle) => ISteamHTTP.SendHTTPRequest(self, hRequest, pCallHandle);
            public bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle) => ISteamHTTP.SendHTTPRequestAndStreamResponse(self, hRequest, pCallHandle);
            public bool DeferHTTPRequest(HTTPRequestHandle hRequest) => ISteamHTTP.DeferHTTPRequest(self, hRequest);
            public bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) => ISteamHTTP.PrioritizeHTTPRequest(self, hRequest);
            public bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, uint* unResponseHeaderSize) => ISteamHTTP.GetHTTPResponseHeaderSize(self, hRequest, pchHeaderName, unResponseHeaderSize);
            public bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, byte* pHeaderValueBuffer, uint unBufferSize) => ISteamHTTP.GetHTTPResponseHeaderValue(self, hRequest, pchHeaderName, pHeaderValueBuffer, unBufferSize);
            public bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, uint* unBodySize) => ISteamHTTP.GetHTTPResponseBodySize(self, hRequest, unBodySize);
            public bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte* pBodyDataBuffer, uint unBufferSize) => ISteamHTTP.GetHTTPResponseBodyData(self, hRequest, pBodyDataBuffer, unBufferSize);
            public bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte* pBodyDataBuffer, uint unBufferSize) => ISteamHTTP.GetHTTPStreamingResponseBodyData(self, hRequest, cOffset, pBodyDataBuffer, unBufferSize);
            public bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) => ISteamHTTP.ReleaseHTTPRequest(self, hRequest);
            public bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, float* pflPercentOut) => ISteamHTTP.GetHTTPDownloadProgressPct(self, hRequest, pflPercentOut);
            public bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, UTF8StringPtr pchContentType, byte* pubBody, uint unBodyLen) => ISteamHTTP.SetHTTPRequestRawPostBody(self, hRequest, pchContentType, pubBody, unBodyLen);
            public HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) => ISteamHTTP.CreateCookieContainer(self, bAllowResponsesToModify);
            public bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) => ISteamHTTP.ReleaseCookieContainer(self, hCookieContainer);
            public bool SetCookie(HTTPCookieContainerHandle hCookieContainer, UTF8StringPtr pchHost, UTF8StringPtr pchUrl, UTF8StringPtr pchCookie) => ISteamHTTP.SetCookie(self, hCookieContainer, pchHost, pchUrl, pchCookie);
            public bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) => ISteamHTTP.SetHTTPRequestCookieContainer(self, hRequest, hCookieContainer);
            public bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, UTF8StringPtr pchUserAgentInfo) => ISteamHTTP.SetHTTPRequestUserAgentInfo(self, hRequest, pchUserAgentInfo);
            public bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) => ISteamHTTP.SetHTTPRequestRequiresVerifiedCertificate(self, hRequest, bRequireVerifiedCertificate);
            public bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) => ISteamHTTP.SetHTTPRequestAbsoluteTimeoutMS(self, hRequest, unMilliseconds);
            public bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, bool* pbWasTimedOut) => ISteamHTTP.GetHTTPRequestWasTimedOut(self, hRequest, pbWasTimedOut);
        }
    }
}