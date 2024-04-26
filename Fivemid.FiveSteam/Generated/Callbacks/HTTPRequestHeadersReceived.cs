using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Triggered when HTTP headers are received from a streaming HTTP request.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTTPRequestHeadersReceived : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTTPRequestHeadersReceived;
        /// <summary>Handle value for the request that has received headers.</summary>
        public HTTPRequestHandle hRequest;
        /// <summary>Context value that the user defined on the request that this callback is associated with, 0 if<br />
        /// no context value was set.</summary>
        public ulong ulContextValue;
    }
}