using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamAPICallCompleted_t</summary>
    public unsafe struct SteamAPICallCompleted : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamAPICallCompleted;
        /// <summary>SteamAPICall_t m_hAsyncCall</summary>
        public SteamAPICall hAsyncCall;
        /// <summary>int m_iCallback</summary>
        public int iCallback;
        /// <summary>uint32 m_cubParam</summary>
        public uint cubParam;
    }
}