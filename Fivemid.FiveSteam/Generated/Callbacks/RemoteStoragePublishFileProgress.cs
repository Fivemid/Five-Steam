using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishWorkshopFile" class="bb_apilink">ISteamRemoteStorage::PublishWorkshopFile</a>, <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishVideo" class="bb_apilink">ISteamRemoteStorage::PublishVideo</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStoragePublishFileProgress : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStoragePublishFileProgress;
        /// <summary></summary>
        public double dPercentFile;
        /// <summary></summary>
        public bool bPreview;
    }
}