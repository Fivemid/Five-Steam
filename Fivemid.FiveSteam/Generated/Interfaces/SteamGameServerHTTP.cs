using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerHTTP
    {
        public static ISteamHTTP.Instance Instance => Accessor();

        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamGameServerHTTP_v003", CallingConvention = Platform.CC)]
        private static extern ISteamHTTP.Instance Accessor();
        /// <summary><code>HTTPRequestHandle CreateHTTPRequest( EHTTPMethod eHTTPRequestMethod, const char *pchAbsoluteURL );</code><br />
        /// Initializes a new HTTP request.<br />
        /// <br />
        /// Requires the method such as GET or POST and the absolute URL for the request. Both http and https are supported, so this string must start with "<a href="http://%22" target="_blank" rel="noreferrer">http://"</a> or "<a href="https://%22" target="_blank" rel="noreferrer">https://"</a> and should look like <a href="http://%22http://store.steampowered.com/app/10/%22" target="_blank" rel="noreferrer">"http://store.steampowered.com/app/10/"</a> or similar. This call returns a handle that you can use to make further calls to setup and then send the HTTP request with <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequest" target="_blank" rel="noreferrer">HTTP::SendHTTPRequest</a> or <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a>.<br />
        /// <br />
        /// Don't forget to free the HTTP request when you're done with it to prevent leaking memory by calling <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#ReleaseHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::ReleaseHTTPRequest" target="_blank" rel="noreferrer">HTTP::ReleaseHTTPRequest</a>!<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a><br />
        /// Returns a new request handle to be used with future calls to SteamHTTP functions. Returns <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#INVALID_HTTPREQUEST_HANDLE" class="bb_apilink">INVALID_HTTPREQUEST_HANDLE</a> if <code class="bb_code bb_code_inline nohighlight">pchAbsoluteURL</code> is <b>NULL</b> or empty ("").</summary>
        /// <param name="eHTTPRequestMethod"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#EHTTPMethod" class="bb_apilink">EHTTPMethod</a>: The type of request to make with this request.</param>
        /// <param name="pchAbsoluteURL">const char *: The url to request. Must start with "<a href="http://%22" target="_blank" rel="noreferrer">http://"</a> or "<a href="https://%22" target="_blank" rel="noreferrer">https://"</a>.</param>
        public static HTTPRequestHandle CreateHTTPRequest(HTTPMethod eHTTPRequestMethod, UTF8StringPtr pchAbsoluteURL) => Instance.CreateHTTPRequest(eHTTPRequestMethod, pchAbsoluteURL);
        /// <summary><code>bool SetHTTPRequestContextValue( HTTPRequestHandle hRequest, uint64 ulContextValue );</code><br />
        /// Set a context value for the request, which will be returned in the <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> callback after sending the request.<br />
        /// <br />
        /// This allows the caller to set a context ID that can enable attribution of a particular callback to a particular request.<br />
        /// <br />
        /// Must be called before sending the request.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon successfully setting the context value.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has already been sent.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set the context value on.</param>
        /// <param name="ulContextValue"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a>: The context value to set.</param>
        public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) => Instance.SetHTTPRequestContextValue(hRequest, ulContextValue);
        /// <summary><code>bool SetHTTPRequestNetworkActivityTimeout( HTTPRequestHandle hRequest, uint32 unTimeoutSeconds );</code><br />
        /// Set the timeout in seconds for the HTTP request.<br />
        /// <br />
        /// The default timeout is 60 seconds if you don't call this. This can get bumped everytime we get more data. Use <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SetHTTPRequestAbsoluteTimeoutMS" class="bb_apilink">ISteam</a><a href="HTTP::SetHTTPRequestAbsoluteTimeoutMS" target="_blank" rel="noreferrer">HTTP::SetHTTPRequestAbsoluteTimeoutMS</a> if you need a strict maximum timeout.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon successfully setting the timeout.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has already been sent.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set the timeout on.</param>
        /// <param name="unTimeoutSeconds"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The length of the timeout period in seconds.</param>
        public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) => Instance.SetHTTPRequestNetworkActivityTimeout(hRequest, unTimeoutSeconds);
        /// <summary><code>bool SetHTTPRequestHeaderValue( HTTPRequestHandle hRequest, const char *pchHeaderName, const char *pchHeaderValue );</code><br />
        /// Set a request header value for the HTTP request.<br />
        /// <br />
        /// Must be called before sending the request.<br />
        /// <br />
        /// A full list of standard request fields are available here on <a href="https://en.wikipedia.org/wiki/List_of_HTTP_header_fields#Request_fields" target="_blank" rel="noreferrer">wikipedia</a>. The User-Agent field is explicitly disallowed as it gets overwritten when the request is sent.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon successfully setting the header value.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has already been sent.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pchHeaderName</code> is <b>"User-Agent"</b>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pchHeaderName</code> or <code class="bb_code bb_code_inline nohighlight">pchHeaderValue</code> are <b>NULL</b>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set the header value for.</param>
        /// <param name="pchHeaderName">const char *: The header name field.</param>
        /// <param name="pchHeaderValue">const char *: Value to associate with the header name field.</param>
        public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, UTF8StringPtr pchHeaderValue) => Instance.SetHTTPRequestHeaderValue(hRequest, pchHeaderName, pchHeaderValue);
        /// <summary><code>bool SetHTTPRequestGetOrPostParameter( HTTPRequestHandle hRequest, const char *pchParamName, const char *pchParamValue );</code><br />
        /// Set a GET or POST parameter value on the HTTP request.<br />
        /// <br />
        /// Must be called prior to sending the request.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon successfully setting the parameter.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has already been sent.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pchParamName</code> or <code class="bb_code bb_code_inline nohighlight">pchParamValue</code> are <b>NULL</b>.<br />
        /// 	</li><li> The request method set in <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#CreateHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::CreateHTTPRequest" target="_blank" rel="noreferrer">HTTP::CreateHTTPRequest</a> is not <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPMethodGET" class="bb_apilink">k_EHTTPMethodGET</a>, <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPMethodHEAD" class="bb_apilink">k_EHTTPMethodHEAD</a>, or <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPMethodPOST" class="bb_apilink">k_EHTTPMethodPOST</a>.<br />
        /// 	</li><li> If the request method is <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPMethodPOST" class="bb_apilink">k_EHTTPMethodPOST</a> and a POST body has already been set with <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SetHTTPRequestRawPostBody" class="bb_apilink">ISteam</a><a href="HTTP::SetHTTPRequestRawPostBody" target="_blank" rel="noreferrer">HTTP::SetHTTPRequestRawPostBody</a>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set the parameter on.</param>
        /// <param name="pchParamName">const char *: Parameter name field.</param>
        /// <param name="pchParamValue">const char *: Value to associate with the name field.</param>
        public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, UTF8StringPtr pchParamName, UTF8StringPtr pchParamValue) => Instance.SetHTTPRequestGetOrPostParameter(hRequest, pchParamName, pchParamValue);
        /// <summary><code>bool SendHTTPRequest( HTTPRequestHandle hRequest, SteamAPICall_t *pCallHandle );</code><br />
        /// Sends an HTTP request.<br />
        /// <br />
        /// This call is asynchronous and provides a call result handle which you must use to track the call to its completion. If you have multiple requests in flight at the same time you can use <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#PrioritizeHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::PrioritizeHTTPRequest" target="_blank" rel="noreferrer">HTTP::PrioritizeHTTPRequest</a> or <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#DeferHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::DeferHTTPRequest" target="_blank" rel="noreferrer">HTTP::DeferHTTPRequest</a> to set the priority of the request.<br />
        /// <br />
        /// If the user is in offline mode in Steam, then this will add an only-if-cached cache-control header and only do a local cache lookup rather than sending any actual remote request.<br />
        /// <br />
        /// If the data you are expecting is large, you can use <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a> to stream the data in chunks.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> callback.<br />
        /// Returns <b>true</b> upon successfully setting the parameter.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has already been sent.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pCallHandle</code> is <b>NULL</b>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to send.</param>
        /// <param name="pCallHandle"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> *: Returns a call result handle to receive the response.</param>
        public static bool SendHTTPRequest(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle) => Instance.SendHTTPRequest(hRequest, pCallHandle);
        /// <summary><code>bool SendHTTPRequestAndStreamResponse( HTTPRequestHandle hRequest, SteamAPICall_t *pCallHandle );</code><br />
        /// Sends an HTTP request and streams the response back in chunks.<br />
        /// <br />
        /// This call is asynchronous and provides a call result handle which you must use to track the call to its completion. Typically you'll want to allocate a buffer associated with the request handle using the <code class="bb_code bb_code_inline nohighlight">Content-Length</code> HTTP response field to receive the total size of the data when you receive the header via <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHeadersReceived_t" class="bb_apilink">HTTPRequestHeadersReceived_t</a>. You can then append data to that buffer as it comes in.<br />
        /// <br />
        /// If you have multiple requests in flight at the same time you can use <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#PrioritizeHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::PrioritizeHTTPRequest" target="_blank" rel="noreferrer">HTTP::PrioritizeHTTPRequest</a> or <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#DeferHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::DeferHTTPRequest" target="_blank" rel="noreferrer">HTTP::DeferHTTPRequest</a> to set the priority of the request.<br />
        /// <br />
        /// If the user is in offline mode in Steam, then this will add an only-if-cached cache-control header and only do a local cache lookup rather than sending any actual remote request.<br />
        /// <br />
        /// If the data you are expecting is small (on the order of a few megabytes or less) then you'll likely want to use <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequest" target="_blank" rel="noreferrer">HTTP::SendHTTPRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a> callback.<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHeadersReceived_t" class="bb_apilink">HTTPRequestHeadersReceived_t</a> callback.<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> callback.<br />
        /// Returns <b>true</b> upon successfully setting the parameter.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has already been sent.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pCallHandle</code> is <b>NULL</b>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to send.</param>
        /// <param name="pCallHandle"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> *: Returns a call result handle to receive the response.</param>
        public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, SteamAPICall* pCallHandle) => Instance.SendHTTPRequestAndStreamResponse(hRequest, pCallHandle);
        /// <summary><code>bool DeferHTTPRequest( HTTPRequestHandle hRequest );</code><br />
        /// Defers a request which has already been sent by moving it at the back of the queue.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> if the request has been successfully defered. Otherwise <b>false</b> if <code class="bb_code bb_code_inline nohighlight">hRequest</code> is an invalid handle, or if the request has not been sent yet.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequest" target="_blank" rel="noreferrer">HTTP::SendHTTPRequest</a>, <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to defer.</param>
        public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) => Instance.DeferHTTPRequest(hRequest);
        /// <summary><code>bool PrioritizeHTTPRequest( HTTPRequestHandle hRequest );</code><br />
        /// Prioritizes a request which has already been sent by moving it at the front of the queue.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> if the request has been successfully prioritized. Otherwise <b>false</b> if <code class="bb_code bb_code_inline nohighlight">hRequest</code> is an invalid handle, or if the request has not been sent yet.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequest" target="_blank" rel="noreferrer">HTTP::SendHTTPRequest</a>, <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to prioritize.</param>
        public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) => Instance.PrioritizeHTTPRequest(hRequest);
        /// <summary><code>bool GetHTTPResponseHeaderSize( HTTPRequestHandle hRequest, const char *pchHeaderName, uint32 *unResponseHeaderSize );</code><br />
        /// Checks if a header is present in an HTTP response and returns its size.<br />
        /// <br />
        /// This must be called after the HTTP request has completed and returned the HTTP response via the <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> call result associated with this request handle. If the response header exists in the response, then you can allocate a correctly sized buffer to get the associated value with <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPResponseHeaderValue" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPResponseHeaderValue" target="_blank" rel="noreferrer">HTTP::GetHTTPResponseHeaderValue</a>.<br />
        /// <br />
        /// Here is a list of standard response header names on <a href="https://en.wikipedia.org/wiki/List_of_HTTP_header_fields#Response_fields" target="_blank" rel="noreferrer">wikipedia</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> if the header name is present in the response and <code class="bb_code bb_code_inline nohighlight">unResponseHeaderSize</code> has been filled with the size of the header value.<br />
        /// Otherwise, returns <b>false</b> and sets <code class="bb_code bb_code_inline nohighlight">unResponseHeaderSize</code> to <b>0</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has not been sent or has not completed.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pchHeaderName</code> is <b>NULL</b>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unResponseHeaderSize</code> is <b>NULL</b>.<br />
        /// 	</li><li> The header name is not present in the response.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to check for the response header name.</param>
        /// <param name="pchHeaderName">const char *: The header name to check.</param>
        /// <param name="unResponseHeaderSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the size of the response header, if it is present in the response.</param>
        public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, uint* unResponseHeaderSize) => Instance.GetHTTPResponseHeaderSize(hRequest, pchHeaderName, unResponseHeaderSize);
        /// <summary><code>bool GetHTTPResponseHeaderValue( HTTPRequestHandle hRequest, const char *pchHeaderName, uint8 *pHeaderValueBuffer, uint32 unBufferSize );</code><br />
        /// Gets a header value from an HTTP response.<br />
        /// <br />
        /// This must be called after the HTTP request has completed and returned the HTTP response via the <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> call result associated with this request handle. You should first call <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPResponseHeaderSize" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPResponseHeaderSize" target="_blank" rel="noreferrer">HTTP::GetHTTPResponseHeaderSize</a> to check for the presence of the header and to get the size. You can then allocate a buffer with that size and pass it into this function.<br />
        /// <br />
        /// Here is a list of standard response header names on <a href="https://en.wikipedia.org/wiki/List_of_HTTP_header_fields#Response_fields" target="_blank" rel="noreferrer">wikipedia</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success indicating that <code class="bb_code bb_code_inline nohighlight">pHeaderValueBuffer</code> has been filled with the header value.<br />
        /// Otherwise, returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has not been sent or has not completed.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pchHeaderName</code> is <b>NULL</b>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pHeaderValueBuffer</code> is <b>NULL</b>.<br />
        /// 	</li><li> The header name is not present in the response.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unBufferSize</code> is not large enough to hold the value.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to get the response header value for.</param>
        /// <param name="pchHeaderName">const char *: The header name to get the header value for.</param>
        /// <param name="pHeaderValueBuffer"><a href="https://partner.steamgames.com/doc/api/steam_api#uint8" class="bb_apilink">uint8</a> *: The buffer where the value will be copied into.</param>
        /// <param name="unBufferSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: This should be the size of <code class="bb_code bb_code_inline nohighlight">pHeaderValueBuffer</code> in bytes.</param>
        public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, UTF8StringPtr pchHeaderName, byte* pHeaderValueBuffer, uint unBufferSize) => Instance.GetHTTPResponseHeaderValue(hRequest, pchHeaderName, pHeaderValueBuffer, unBufferSize);
        /// <summary><code>bool GetHTTPResponseBodySize( HTTPRequestHandle hRequest, uint32 *unBodySize );</code><br />
        /// Gets the size of the body data from an HTTP response.<br />
        /// <br />
        /// This must be called after the HTTP request has completed and returned the HTTP response via the <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> or <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a> associated with this request handle. If this returns successfully, then you can allocate a buffer with the provided size to fill with the data obtained from <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPResponseBodyData" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPResponseBodyData" target="_blank" rel="noreferrer">HTTP::GetHTTPResponseBodyData</a> or <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPStreamingResponseBodyData" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPStreamingResponseBodyData" target="_blank" rel="noreferrer">HTTP::GetHTTPStreamingResponseBodyData</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success indicating that <code class="bb_code bb_code_inline nohighlight">unBodySize</code> has been filled with the size.<br />
        /// Otherwise, returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has not been sent or has not completed.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unBodySize</code> is <b>NULL</b>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to get the response body size for.</param>
        /// <param name="unBodySize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the size of the response body.</param>
        public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, uint* unBodySize) => Instance.GetHTTPResponseBodySize(hRequest, unBodySize);
        /// <summary><code>bool GetHTTPResponseBodyData( HTTPRequestHandle hRequest, uint8 *pBodyDataBuffer, uint32 unBufferSize );</code><br />
        /// Gets the body data from an HTTP response.<br />
        /// <br />
        /// This must be called after the HTTP request has completed and returned the HTTP response via the <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> call result associated with this request handle. You should first call <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPResponseBodySize" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPResponseBodySize" target="_blank" rel="noreferrer">HTTP::GetHTTPResponseBodySize</a> or use the <code class="bb_code bb_code_inline nohighlight">m_unBodySize</code> variable provided in the call result, you can then allocate a buffer with that size to pass into this function.<br />
        /// <br />
        /// This is only for HTTP requests which were sent with <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequest" target="_blank" rel="noreferrer">HTTP::SendHTTPRequest</a>. Use <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPStreamingResponseBodyData" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPStreamingResponseBodyData" target="_blank" rel="noreferrer">HTTP::GetHTTPStreamingResponseBodyData</a> if you're using streaming HTTP requests via <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success indicating that <code class="bb_code bb_code_inline nohighlight">pBodyDataBuffer</code> has been filled with the body data.<br />
        /// Otherwise, returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has not been sent or has not completed.<br />
        /// 	</li><li> The request is a streaming request.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">pBodyDataBuffer</code> is <b>NULL</b>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unBufferSize</code> is not the same size that was provided by <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPResponseBodySize" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPResponseBodySize" target="_blank" rel="noreferrer">HTTP::GetHTTPResponseBodySize</a>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to get the response body data for.</param>
        /// <param name="pBodyDataBuffer"><a href="https://partner.steamgames.com/doc/api/steam_api#uint8" class="bb_apilink">uint8</a> *: The buffer where the data will be copied into.</param>
        /// <param name="unBufferSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: This should be the size of <code class="bb_code bb_code_inline nohighlight">pBodyDataBuffer</code> in bytes.</param>
        public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte* pBodyDataBuffer, uint unBufferSize) => Instance.GetHTTPResponseBodyData(hRequest, pBodyDataBuffer, unBufferSize);
        /// <summary><code>bool GetHTTPStreamingResponseBodyData( HTTPRequestHandle hRequest, uint32 cOffset, uint8 *pBodyDataBuffer, uint32 unBufferSize );</code><br />
        /// Gets the body data from a streaming HTTP response.<br />
        /// <br />
        /// This must be called after data is received from a streaming HTTP request via the <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a> callback associated with this request handle. Typically you'll want to allocate a buffer associated with the request handle using the <code class="bb_code bb_code_inline nohighlight">Content-Length</code> HTTP response field to receive the total size of the data when you receive the header via <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHeadersReceived_t" class="bb_apilink">HTTPRequestHeadersReceived_t</a>. You can then append data to that buffer as it comes in.<br />
        /// <br />
        /// This is only for streaming HTTP requests which were sent with <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a>. Use <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPResponseBodyData" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPResponseBodyData" target="_blank" rel="noreferrer">HTTP::GetHTTPResponseBodyData</a> if you're using <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequest" target="_blank" rel="noreferrer">HTTP::SendHTTPRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success indicating that <code class="bb_code bb_code_inline nohighlight">pBodyDataBuffer</code> has been filled with the body data.<br />
        /// Otherwise, returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has not been sent or has not completed.<br />
        /// 	</li><li> The request is not a streaming request.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">cOffset</code> is not the same offset that was provided by <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a>.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unBufferSize</code> is not the same size that was provided by <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to get the response body data for.</param>
        /// <param name="cOffset"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: This must be the offset provided by <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a>.</param>
        /// <param name="pBodyDataBuffer"><a href="https://partner.steamgames.com/doc/api/steam_api#uint8" class="bb_apilink">uint8</a> *: Returns the data by copying it into this buffer.</param>
        /// <param name="unBufferSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: This must be the size provided by <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a>.</param>
        public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte* pBodyDataBuffer, uint unBufferSize) => Instance.GetHTTPStreamingResponseBodyData(hRequest, cOffset, pBodyDataBuffer, unBufferSize);
        /// <summary><code>bool ReleaseHTTPRequest( HTTPRequestHandle hRequest );</code><br />
        /// Releases an HTTP request handle, freeing the memory allocated within Steam.<br />
        /// <br />
        /// You MUST call this when you are done using each HTTPRequestHandle that you obtained via <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#CreateHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::CreateHTTPRequest" target="_blank" rel="noreferrer">HTTP::CreateHTTPRequest</a>!<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> if the the handle was released successfully, <b>false</b> only if the handle is invalid.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to release.</param>
        public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) => Instance.ReleaseHTTPRequest(hRequest);
        /// <summary><code>bool GetHTTPDownloadProgressPct( HTTPRequestHandle hRequest, float *pflPercentOut );</code><br />
        /// Gets progress on downloading the body for the request.<br />
        /// <br />
        /// This will be zero unless a response header has already been received which included a content-length field. For responses that contain no content-length it will report zero for the duration of the request as the size is unknown until the connection closes.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success if the download percentage was successfully returned. Otherwise, <b>false</b> if the handle is invalid or <code class="bb_code bb_code_inline nohighlight">pflPercentOut</code> is <b>NULL</b>.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to get the download percentage for.</param>
        /// <param name="pflPercentOut">float *: Returns the download percentage if the call was successful.</param>
        public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, float* pflPercentOut) => Instance.GetHTTPDownloadProgressPct(hRequest, pflPercentOut);
        /// <summary><code>bool SetHTTPRequestRawPostBody( HTTPRequestHandle hRequest, const char *pchContentType, uint8 *pubBody, uint32 unBodyLen );</code><br />
        /// Sets the body for an HTTP Post request.<br />
        /// <br />
        /// Will fail and return false on a GET request, and will fail if POST params have already been set for the request. Setting this raw body makes it the only contents for the post, the <code class="bb_code bb_code_inline nohighlight">pchContentType</code> parameter will set the "content-type" header for the request to inform the server how to interpret the body.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success indicating that the content-type field and the body data have been set.<br />
        /// Otherwise, returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The HTTP Method set in <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#CreateHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::CreateHTTPRequest" target="_blank" rel="noreferrer">HTTP::CreateHTTPRequest</a> is not <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPMethodPOST" class="bb_apilink">k_EHTTPMethodPOST</a>, <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPMethodPUT" class="bb_apilink">k_EHTTPMethodPUT</a>, or <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPMethodPATCH" class="bb_apilink">k_EHTTPMethodPATCH</a>.<br />
        /// 	</li><li> A POST body has already been set for this request either via this function or with <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SetHTTPRequestGetOrPostParameter" class="bb_apilink">ISteam</a><a href="HTTP::SetHTTPRequestGetOrPostParameter" target="_blank" rel="noreferrer">HTTP::SetHTTPRequestGetOrPostParameter</a>.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set the post body on.</param>
        /// <param name="pchContentType">const char *: Sets the value of the calls "content-type" http header.</param>
        /// <param name="pubBody"><a href="https://partner.steamgames.com/doc/api/steam_api#uint8" class="bb_apilink">uint8</a> *: The raw POST body data to set.</param>
        /// <param name="unBodyLen"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The length of the body data passed into <code class="bb_code bb_code_inline nohighlight">pubBody</code>.</param>
        public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, UTF8StringPtr pchContentType, byte* pubBody, uint unBodyLen) => Instance.SetHTTPRequestRawPostBody(hRequest, pchContentType, pubBody, unBodyLen);
        /// <summary><code>HTTPCookieContainerHandle CreateCookieContainer( bool bAllowResponsesToModify );</code><br />
        /// Creates a cookie container to store cookies during the lifetime of the process.<br />
        /// <br />
        /// This API is just for during process lifetime, after Steam restarts no cookies are persisted and you have no way to access the cookie container across repeat executions of your process.<br />
        /// <br />
        /// If <code class="bb_code bb_code_inline nohighlight">bAllowResponsesToModify</code> is <b>true</b> then any response to your requests using this cookie container may add new cookies to the container which may be transmitted with future requests. Otherwise, if it's <b>false</b> then only cookies you explicitly set will be sent.<br />
        /// <br />
        /// You can associate the cookie container with a http request by using <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SetHTTPRequestCookieContainer" class="bb_apilink">ISteam</a><a href="HTTP::SetHTTPRequestCookieContainer" target="_blank" rel="noreferrer">HTTP::SetHTTPRequestCookieContainer</a>, and you can set a cookie using <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SetCookie" class="bb_apilink">ISteam</a><a href="HTTP::SetCookie" target="_blank" rel="noreferrer">HTTP::SetCookie</a>.<br />
        /// <br />
        /// Don't forget to free the container when you're done with it to prevent leaking memory by calling <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#ReleaseCookieContainer" class="bb_apilink">ISteam</a><a href="HTTP::ReleaseCookieContainer" target="_blank" rel="noreferrer">HTTP::ReleaseCookieContainer</a>!<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPCookieContainerHandle" class="bb_apilink">HTTPCookieContainerHandle</a><br />
        /// Returns a new cookie container handle to be used with future calls to SteamHTTP functions.</summary>
        /// <param name="bAllowResponsesToModify">bool: Set whether the server can set cookies in this container.</param>
        public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) => Instance.CreateCookieContainer(bAllowResponsesToModify);
        /// <summary><code>bool ReleaseCookieContainer( HTTPCookieContainerHandle hCookieContainer );</code><br />
        /// Releases a cookie container, freeing the memory allocated within Steam.<br />
        /// <br />
        /// You MUST call this when you are done using each HTTPCookieContainerHandle that you obtained via <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#CreateCookieContainer" class="bb_apilink">ISteam</a><a href="HTTP::CreateCookieContainer" target="_blank" rel="noreferrer">HTTP::CreateCookieContainer</a>!<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> if the handle has been freed; otherwise, <b>false</b> if the handle was invalid.</summary>
        /// <param name="hCookieContainer"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPCookieContainerHandle" class="bb_apilink">HTTPCookieContainerHandle</a>: The cookie container handle to release.</param>
        public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) => Instance.ReleaseCookieContainer(hCookieContainer);
        /// <summary><code>bool SetCookie( HTTPCookieContainerHandle hCookieContainer, const char *pchHost, const char *pchUrl, const char *pchCookie );</code><br />
        /// Adds a cookie to the specified cookie container that will be used with future requests.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> if the cookie was set successfully. Otherwise, <b>false</b> if the request handle was invalid or if there was a security issue parsing the cookie.</summary>
        /// <param name="hCookieContainer"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPCookieContainerHandle" class="bb_apilink">HTTPCookieContainerHandle</a>: The cookie container to set the the cookie in.</param>
        /// <param name="pchHost">const char *: The host to set this cookie for.</param>
        /// <param name="pchUrl">const char *: The url to set this cookie for.</param>
        /// <param name="pchCookie">const char *: The cookie to set.</param>
        public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, UTF8StringPtr pchHost, UTF8StringPtr pchUrl, UTF8StringPtr pchCookie) => Instance.SetCookie(hCookieContainer, pchHost, pchUrl, pchCookie);
        /// <summary><code>bool SetHTTPRequestCookieContainer( HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer );</code><br />
        /// Associates a cookie container to use for an HTTP request.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon successfully setting the cookie container.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">hCookieContainer</code> was invalid.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to associate the cookie container with.</param>
        /// <param name="hCookieContainer"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPCookieContainerHandle" class="bb_apilink">HTTPCookieContainerHandle</a>: The cookie container handle to associate with the request handle.</param>
        public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) => Instance.SetHTTPRequestCookieContainer(hRequest, hCookieContainer);
        /// <summary><code>bool SetHTTPRequestUserAgentInfo( HTTPRequestHandle hRequest, const char *pchUserAgentInfo );</code><br />
        /// Set additional user agent info for a request.<br />
        /// <br />
        /// This doesn't clobber the normal user agent, it just adds the extra info on the end. Sending <b>NULL</b> or an empty string resets the user agent info to the default value.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success indicating that the user agent has been updated. Otherwise, <b>false</b> if the request handle is invalid.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set the user agent info for.</param>
        /// <param name="pchUserAgentInfo">const char *: The string to append to the end of the user agent.</param>
        public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, UTF8StringPtr pchUserAgentInfo) => Instance.SetHTTPRequestUserAgentInfo(hRequest, pchUserAgentInfo);
        /// <summary><code>bool SetHTTPRequestRequiresVerifiedCertificate( HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate );</code><br />
        /// Sets that the HTTPS request should require verified SSL certificate via machines certificate trust store.<br />
        /// <br />
        /// This currently only works Windows and macOS.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success. Otherwise, <b>false</b> if the request handle is invalid.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set whether the request requires a verified certificate.</param>
        /// <param name="bRequireVerifiedCertificate">bool: Turn on verified certificate?</param>
        public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) => Instance.SetHTTPRequestRequiresVerifiedCertificate(hRequest, bRequireVerifiedCertificate);
        /// <summary><code>bool SetHTTPRequestAbsoluteTimeoutMS( HTTPRequestHandle hRequest, uint32 unMilliseconds );</code><br />
        /// Set an absolute timeout in milliseconds for the HTTP request.<br />
        /// <br />
        /// This is the total time timeout which is different than the network activity timeout which is set with <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SetHTTPRequestNetworkActivityTimeout" class="bb_apilink">ISteam</a><a href="HTTP::SetHTTPRequestNetworkActivityTimeout" target="_blank" rel="noreferrer">HTTP::SetHTTPRequestNetworkActivityTimeout</a> which can bump everytime we get more data.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon successfully setting the timeout.<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has already been sent.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to set the timeout on.</param>
        /// <param name="unMilliseconds"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The length of the timeout period in milliseconds.</param>
        public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) => Instance.SetHTTPRequestAbsoluteTimeoutMS(hRequest, unMilliseconds);
        /// <summary><code>bool GetHTTPRequestWasTimedOut( HTTPRequestHandle hRequest, bool *pbWasTimedOut );</code><br />
        /// Check if the reason the request failed was because we timed it out (rather than some harder failure).<br />
        /// <br />
        /// You'll want to call this within the context of <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestCompleted_t" class="bb_apilink">HTTPRequestCompleted_t</a> if <code class="bb_code bb_code_inline nohighlight">m_bRequestSuccessful</code> is <b>false</b>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Returns <b>true</b> upon success if we successfully checked .<br />
        /// Returns <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">hRequest</code> was invalid.<br />
        /// 	</li><li> The request has not been sent or has not completed.</li></ul></summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHandle" class="bb_apilink">HTTPRequestHandle</a>: The request handle to check the failure reason for.</param>
        /// <param name="pbWasTimedOut">bool *: Returns whether the request was timed out or not.</param>
        public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, bool* pbWasTimedOut) => Instance.GetHTTPRequestWasTimedOut(hRequest, pbWasTimedOut);
    }
}