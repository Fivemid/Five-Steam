using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Result when an HTTP request completes.<br />
    /// If you're using
    /// <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPStreamingResponseBodyData" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPStreamingResponseBodyData" target="_blank" rel="noreferrer">HTTP::GetHTTPStreamingResponseBodyData</a>
    /// then you should be using the
    /// <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestHeadersReceived_t" class="bb_apilink">HTTPRequestHeadersReceived_t</a>
    /// or
    /// <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#HTTPRequestDataReceived_t" class="bb_apilink">HTTPRequestDataReceived_t</a>.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequest" target="_blank" rel="noreferrer">HTTP::SendHTTPRequest</a>,
    /// <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a>
    /// </summary>
    public unsafe struct HTTPRequestCompleted : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTTPRequestCompleted;
        /// <summary>
        ///             Handle for the request that has completed. You should call
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#ReleaseHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::ReleaseHTTPRequest" target="_blank" rel="noreferrer">HTTP::ReleaseHTTPRequest</a>
        ///             on this handle to free the resources when you're done using it, which is typically in
        ///             this callback.
        ///         </summary>
        public HTTPRequestHandle hRequest;
        /// <summary>
        ///             Context value that the user defined on the request with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SetHTTPRequestContextValue" class="bb_apilink">ISteam</a><a href="HTTP::SetHTTPRequestContextValue" target="_blank" rel="noreferrer">HTTP::SetHTTPRequestContextValue</a>
        ///             that this callback is associated with. <b>0</b> if<br />
        ///             no context value was set.
        ///         </summary>
        public ulong ulContextValue;
        /// <summary>
        ///             This will be <b>true</b> if the request actually got any sort of response from
        ///             the server (even an error).<br />
        ///             Otherwise it will be <b>false</b> if the request failed due to an internal
        ///             error or client side network failure.
        ///         </summary>
        public bool bRequestSuccessful;
        /// <summary>
        ///             Will be the HTTP status code value returned by the server.<br />
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#k_EHTTPStatusCode200OK" class="bb_apilink">k_EHTTPStatusCode200OK</a>
        ///             is the normal OK response, if you get something else you probably need to treat it as a
        ///             failure.
        ///         </summary>
        public HTTPStatusCode eStatusCode;
        /// <summary>
        ///             The size of the request body in bytes. This is the same as
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPResponseBodySize" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPResponseBodySize" target="_blank" rel="noreferrer">HTTP::GetHTTPResponseBodySize</a>.
        ///         </summary>
        public uint unBodySize;
    }
}