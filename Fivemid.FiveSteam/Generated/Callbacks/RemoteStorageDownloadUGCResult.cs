using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCDownload" class="bb_apilink">ISteamRemoteStorage::UGCDownload</a>, <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UGCDownloadToLocation" class="bb_apilink">ISteamRemoteStorage::UGCDownloadToLocation</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageDownloadUGCResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageDownloadUGCResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The handle to the file that was attempted to be downloaded.</summary>
        public UGCHandle hFile;
        /// <summary>ID of the app that created this file.</summary>
        public AppId nAppID;
        /// <summary>The size of the file that was downloaded, in bytes.</summary>
        public int nSizeInBytes;
        /// <summary>The name of the file that was downloaded.</summary>
        public UTF8String260 pchFileName;
        /// <summary>Steam ID of the user who created this content.</summary>
        public ulong ulSteamIDOwner;
    }
}