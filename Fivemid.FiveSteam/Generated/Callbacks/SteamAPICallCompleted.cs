using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a SteamAPICall_t has completed (or failed)<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamAPICallCompleted
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamAPICallCompleted;
        /// <summary>The handle of the Steam API Call that completed.</summary>
        public SteamAPICall hAsyncCall;
        /// <summary>This is the k_iCallback constant which uniquely identifies the completed callback.</summary>
        public int iCallback;
        /// <summary>The size in bytes of the completed callback.</summary>
        public uint cubParam;
    }
}