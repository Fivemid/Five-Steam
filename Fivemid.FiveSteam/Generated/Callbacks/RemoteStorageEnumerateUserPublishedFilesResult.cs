using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EnumerateUserPublishedFiles" class="bb_apilink">ISteamRemoteStorage::EnumerateUserPublishedFiles</a>, <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EnumerateUserSharedWorkshopFiles" class="bb_apilink">ISteamRemoteStorage::EnumerateUserSharedWorkshopFiles</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageEnumerateUserPublishedFilesResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageEnumerateUserPublishedFilesResult;
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