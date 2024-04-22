using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a workshop item has been installed or updated.<br />
    /// <br />
    /// <b>NOTE:</b> This callback goes out to all running applications, ensure that the app ID associated with the item matches what you expect.<br />
    /// <br />
    /// </summary>
    public unsafe struct ItemInstalled : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ItemInstalled;
        /// <summary>The app ID associated with this workshop item.</summary>
        public AppId unAppID;
        /// <summary>The workshop item that has finished installing. This can be used with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemInstallInfo" class="bb_apilink">ISteamUGC::GetItemInstallInfo</a> to access the information about the item.</summary>
        public PublishedFileId nPublishedFileId;
    }
}