using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Ways in which a local file may be changed by Steam during the application session. See <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChange" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChange</a>.<br />
    /// <br />
    /// </summary>
    public enum RemoteStorageLocalFileChangeType : int
    {
        /// <summary>Unused.</summary>
        RemoteStorageLocalFileChange_Invalid = 0,
        /// <summary>The file contents changed.</summary>
        RemoteStorageLocalFileChange_FileUpdated = 1,
        /// <summary>The file was deleted.</summary>
        RemoteStorageLocalFileChange_FileDeleted = 2
    }
}