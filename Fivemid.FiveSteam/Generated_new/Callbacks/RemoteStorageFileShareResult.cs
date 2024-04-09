using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageFileShareResult_t</summary>
    public unsafe struct RemoteStorageFileShareResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>UGCHandle_t m_hFile</summary>
        public UGCHandle hFile;
        /// <summary>char [260] m_rgchFilename</summary>
        public UTF8String260 rgchFilename;
    }
}