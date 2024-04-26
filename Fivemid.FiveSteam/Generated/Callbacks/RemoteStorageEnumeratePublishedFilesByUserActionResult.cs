using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EnumeratePublishedFilesByUserAction" class="bb_apilink">ISteamRemoteStorage::EnumeratePublishedFilesByUserAction</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageEnumeratePublishedFilesByUserActionResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageEnumeratePublishedFilesByUserActionResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>the action that was filtered on</summary>
        public WorkshopFileAction eAction;
        /// <summary></summary>
        public int nResultsReturned;
        /// <summary></summary>
        public int nTotalResultCount;
        /// <summary></summary>
        public FixedArray_ulong50 rgPublishedFileId;
        /// <summary></summary>
        public FixedArray_uint50 rgRTimeUpdated;
    }
}