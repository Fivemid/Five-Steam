using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ItemInstalled_t</summary>
    public unsafe struct ItemInstalled
    {
        /// <summary>AppId_t m_unAppID</summary>
        public AppId unAppID;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
    }
}