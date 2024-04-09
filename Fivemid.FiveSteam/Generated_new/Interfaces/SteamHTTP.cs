using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamHTTP
    {
        public static ISteamHTTP.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamHTTP_v003", CallingConvention = Platform.CC)]
        private static extern ISteamHTTP.Instance Accessor();
        /// <summary></summary>
        public static HTTPRequestHandle CreateHTTPRequest(HTTPMethod eHTTPRequestMethod, UTF8StringPtr pchAbsoluteURL) => Instance.CreateHTTPRequest(eHTTPRequestMethod, pchAbsoluteURL);
        /// <summary></summary>
        public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) => Instance.SetHTTPRequestContextValue(hRequest, ulContextValue);
        /// <summary></summary>
        public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) => Instance.SetHTTPRequestNetworkActivityTimeout(hRequest, unTimeoutSeconds);
        /// <summary></summary>
        public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, UTF8StringPtr pchHeaderValue) => Instance.SetHTTPRequestHeaderValue(hRequest, pchHeaderName, pchHeaderValue);
        /// <summary></summary>
        public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, UTF8StringPtr pchParamName, UTF8StringPtr pchParamValue) => Instance.SetHTTPRequestGetOrPostParameter(hRequest, pchParamName, pchParamValue);
        /// <summary></summary>
        public static bool SendHTTPRequest(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle) => Instance.SendHTTPRequest(hRequest, pCallHandle);
        /// <summary></summary>
        public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle) => Instance.SendHTTPRequestAndStreamResponse(hRequest, pCallHandle);
        /// <summary></summary>
        public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) => Instance.DeferHTTPRequest(hRequest);
        /// <summary></summary>
        public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) => Instance.PrioritizeHTTPRequest(hRequest);
        /// <summary></summary>
        public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, uint* unResponseHeaderSize) => Instance.GetHTTPResponseHeaderSize(hRequest, pchHeaderName, unResponseHeaderSize);
        /// <summary></summary>
        public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, byte* pHeaderValueBuffer, uint unBufferSize) => Instance.GetHTTPResponseHeaderValue(hRequest, pchHeaderName, pHeaderValueBuffer, unBufferSize);
        /// <summary></summary>
        public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, uint* unBodySize) => Instance.GetHTTPResponseBodySize(hRequest, unBodySize);
        /// <summary></summary>
        public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte* pBodyDataBuffer, uint unBufferSize) => Instance.GetHTTPResponseBodyData(hRequest, pBodyDataBuffer, unBufferSize);
        /// <summary></summary>
        public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte* pBodyDataBuffer, uint unBufferSize) => Instance.GetHTTPStreamingResponseBodyData(hRequest, cOffset, pBodyDataBuffer, unBufferSize);
        /// <summary></summary>
        public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) => Instance.ReleaseHTTPRequest(hRequest);
        /// <summary></summary>
        public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, float* pflPercentOut) => Instance.GetHTTPDownloadProgressPct(hRequest, pflPercentOut);
        /// <summary></summary>
        public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, UTF8StringPtr pchContentType, byte* pubBody, uint unBodyLen) => Instance.SetHTTPRequestRawPostBody(hRequest, pchContentType, pubBody, unBodyLen);
        /// <summary></summary>
        public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) => Instance.CreateCookieContainer(bAllowResponsesToModify);
        /// <summary></summary>
        public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) => Instance.ReleaseCookieContainer(hCookieContainer);
        /// <summary></summary>
        public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, UTF8StringPtr pchHost, UTF8StringPtr pchUrl, UTF8StringPtr pchCookie) => Instance.SetCookie(hCookieContainer, pchHost, pchUrl, pchCookie);
        /// <summary></summary>
        public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) => Instance.SetHTTPRequestCookieContainer(hRequest, hCookieContainer);
        /// <summary></summary>
        public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, UTF8StringPtr pchUserAgentInfo) => Instance.SetHTTPRequestUserAgentInfo(hRequest, pchUserAgentInfo);
        /// <summary></summary>
        public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) => Instance.SetHTTPRequestRequiresVerifiedCertificate(hRequest, bRequireVerifiedCertificate);
        /// <summary></summary>
        public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) => Instance.SetHTTPRequestAbsoluteTimeoutMS(hRequest, unMilliseconds);
        /// <summary></summary>
        public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, bool* pbWasTimedOut) => Instance.GetHTTPRequestWasTimedOut(hRequest, pbWasTimedOut);
    }
}