using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>If a Steam app is flagged for supporting dynamic Steam Cloud sync, and a sync occurs, this callback will be posted to the app if any local files changed.<br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChangeCount" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChangeCount</a>, <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChange" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChange</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct RemoteStorageLocalFileChange
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageLocalFileChange;
    }
}