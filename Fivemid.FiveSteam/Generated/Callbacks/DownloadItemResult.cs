using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when a workshop item has been downloaded.<br />
    /// <br />
    /// <b>NOTE:</b> This callback goes out to all running applications, ensure that the app ID
    /// associated with the item matches what you expect.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DownloadItem" class="bb_apilink">ISteamUGC::DownloadItem</a>
    /// </summary>
    public unsafe struct DownloadItemResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DownloadItemResult;
        /// <summary>The app ID associated with this workshop item.</summary>
        public AppId unAppID;
        /// <summary>The workshop item that has finished downloading.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
    }
}