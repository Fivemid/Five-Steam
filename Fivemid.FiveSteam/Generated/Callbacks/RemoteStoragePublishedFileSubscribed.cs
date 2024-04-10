using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStoragePublishedFileSubscribed_t</summary>
    public unsafe struct RemoteStoragePublishedFileSubscribed
    {
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
    }
}