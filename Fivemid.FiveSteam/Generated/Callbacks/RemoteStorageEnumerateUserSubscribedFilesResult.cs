using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EnumerateUserSubscribedFiles" class="bb_apilink">ISteamRemoteStorage::EnumerateUserSubscribedFiles</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageEnumerateUserSubscribedFilesResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageEnumerateUserSubscribedFilesResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary></summary>
        public int nResultsReturned;
        /// <summary></summary>
        public int nTotalResultCount;
        /// <summary></summary>
        public FixedArray_ulong50 rgPublishedFileId;
        /// <summary></summary>
        public FixedArray_uint50 rgRTimeSubscribed;
    }
}