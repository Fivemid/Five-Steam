using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the user has unsubscribed from a piece of UGC. Result from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UnsubscribeItem" class="bb_apilink">ISteamUGC::UnsubscribeItem</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UnsubscribePublishedFile" class="bb_apilink">ISteamRemoteStorage::UnsubscribePublishedFile</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageUnsubscribePublishedFileResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageUnsubscribePublishedFileResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The workshop item that the user unsubscribed from.</summary>
        public PublishedFileId nPublishedFileId;
    }
}