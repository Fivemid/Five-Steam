using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageEnumerateUserSharedWorkshopFilesResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageEnumerateUserSharedWorkshopFilesResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary></summary>
        public int nResultsReturned;
        /// <summary></summary>
        public int nTotalResultCount;
        /// <summary></summary>
        public FixedArray_ulong50 rgPublishedFileId;
    }
}