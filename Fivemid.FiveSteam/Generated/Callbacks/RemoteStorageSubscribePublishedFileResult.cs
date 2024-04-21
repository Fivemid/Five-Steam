using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when the user has subscribed to a piece of UGC. Result from
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubscribeItem" class="bb_apilink">ISteamUGC::SubscribeItem</a>.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SubscribePublishedFile" class="bb_apilink">ISteamRemoteStorage::SubscribePublishedFile</a>
    /// </summary>
    public unsafe struct RemoteStorageSubscribePublishedFileResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageSubscribePublishedFileResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The workshop item that the user subscribed to.</summary>
        public PublishedFileId nPublishedFileId;
    }
}