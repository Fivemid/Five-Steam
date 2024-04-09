using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FileDetailsResult_t</summary>
    public unsafe struct FileDetailsResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 m_ulFileSize</summary>
        public ulong ulFileSize;
        /// <summary>uint8 [20] m_FileSHA</summary>
        public FixedArray_byte20 FileSHA;
        /// <summary>uint32 m_unFlags</summary>
        public uint unFlags;
    }
}