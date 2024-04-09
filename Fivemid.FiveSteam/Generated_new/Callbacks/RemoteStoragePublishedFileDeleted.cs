using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStoragePublishedFileDeleted_t</summary>
    public unsafe struct RemoteStoragePublishedFileDeleted
    {
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
    }
}