using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Triggered when a chunk of data is received from a streaming HTTP request.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#SendHTTPRequestAndStreamResponse" class="bb_apilink">ISteam</a><a href="HTTP::SendHTTPRequestAndStreamResponse" target="_blank" rel="noreferrer">HTTP::SendHTTPRequestAndStreamResponse</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTTPRequestDataReceived : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTTPRequestDataReceived;
        /// <summary>Handle value for the request that has received data.</summary>
        public HTTPRequestHandle hRequest;
        /// <summary>Context value that the user defined on the request that this callback is associated with, 0 if<br />
        /// no context value was set.</summary>
        public ulong ulContextValue;
        /// <summary>Offset to provide to <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPStreamingResponseBodyData" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPStreamingResponseBodyData" target="_blank" rel="noreferrer">HTTP::GetHTTPStreamingResponseBodyData</a> to get this chunk of data</summary>
        public uint cOffset;
        /// <summary>Size in bytes to provide to <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#GetHTTPStreamingResponseBodyData" class="bb_apilink">ISteam</a><a href="HTTP::GetHTTPStreamingResponseBodyData" target="_blank" rel="noreferrer">HTTP::GetHTTPStreamingResponseBodyData</a> to get this chunk of data</summary>
        public uint cBytesReceived;
    }
}