using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#CommitPublishedFileUpdate" class="bb_apilink">ISteamRemoteStorage::CommitPublishedFileUpdate</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageUpdatePublishedFileResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageUpdatePublishedFileResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary></summary>
        public PublishedFileId nPublishedFileId;
        /// <summary></summary>
        public bool bUserNeedsToAcceptWorkshopLegalAgreement;
    }
}