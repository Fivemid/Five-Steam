using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStoragePublishedFileUnsubscribed_t</summary>
    public unsafe struct RemoteStoragePublishedFileUnsubscribed
    {
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
    }
}