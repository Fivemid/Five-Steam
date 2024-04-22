using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EnumeratePublishedWorkshopFiles" class="bb_apilink">ISteamRemoteStorage::EnumeratePublishedWorkshopFiles</a></summary>
    public unsafe struct RemoteStorageEnumerateWorkshopFilesResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageEnumerateWorkshopFilesResult;
        /// <summary></summary>
        public Result eResult;
        /// <summary></summary>
        public int nResultsReturned;
        /// <summary></summary>
        public int nTotalResultCount;
        /// <summary></summary>
        public FixedArray_ulong50 rgPublishedFileId;
        /// <summary></summary>
        public FixedArray_float50 rgScore;
        /// <summary></summary>
        public AppId nAppId;
        /// <summary></summary>
        public uint unStartIndex;
    }
}