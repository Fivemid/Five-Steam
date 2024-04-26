using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SetUserPublishedFileAction" class="bb_apilink">ISteamRemoteStorage::SetUserPublishedFileAction</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageSetUserPublishedFileActionResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageSetUserPublishedFileActionResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The published file id</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>the action that was attempted</summary>
        public WorkshopFileAction eAction;
    }
}