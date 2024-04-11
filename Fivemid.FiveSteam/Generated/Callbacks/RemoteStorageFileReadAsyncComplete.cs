using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageFileReadAsyncComplete_t</summary>
    public unsafe struct RemoteStorageFileReadAsyncComplete : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageFileReadAsyncComplete;
        /// <summary>SteamAPICall_t m_hFileReadAsync</summary>
        public SteamAPICall hFileReadAsync;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint32 m_nOffset</summary>
        public uint nOffset;
        /// <summary>uint32 m_cubRead</summary>
        public uint cubRead;
    }
}