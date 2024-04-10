using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageDownloadUGCResult_t</summary>
    public unsafe struct RemoteStorageDownloadUGCResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>UGCHandle_t m_hFile</summary>
        public UGCHandle hFile;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
        /// <summary>int32 m_nSizeInBytes</summary>
        public int nSizeInBytes;
        /// <summary>char [260] m_pchFileName</summary>
        public UTF8String260 pchFileName;
        /// <summary>uint64 m_ulSteamIDOwner</summary>
        public ulong ulSteamIDOwner;
    }
}