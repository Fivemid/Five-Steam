using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Sync Platforms flags. These can be used with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SetSyncPlatforms" class="bb_apilink">ISteamRemoteStorage::SetSyncPlatforms</a>
    /// to restrict a file to a specific OS.<br />
    /// <br />
    /// 
    /// </summary>
    public enum RemoteStoragePlatform : int
    {
        /// <summary>This file will not be downloaded on any platform.</summary>
        None = 0,
        /// <summary>This file will download on Windows.</summary>
        Windows = 1,
        /// <summary>This file will download on macOS.</summary>
        OSX = 2,
        /// <summary>This file will download on the Playstation 3.</summary>
        PS3 = 4,
        /// <summary>This file will download on SteamOS/Linux.</summary>
        Linux = 8,
        /// missing documentation for ERemoteStoragePlatform.k_ERemoteStoragePlatformSwitch
        Switch = 16,
        /// missing documentation for ERemoteStoragePlatform.k_ERemoteStoragePlatformAndroid
        Android = 32,
        /// missing documentation for ERemoteStoragePlatform.k_ERemoteStoragePlatformIOS
        IOS = 64,
        /// <summary>This file will download on every platform. This is the default.</summary>
        All = -1
    }
}