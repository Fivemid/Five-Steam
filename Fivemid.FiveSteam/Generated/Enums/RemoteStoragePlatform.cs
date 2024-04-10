using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ERemoteStoragePlatform</summary>
    public enum RemoteStoragePlatform : int
    {
        /// <summary>k_ERemoteStoragePlatformNone</summary>
        None = 0,
        /// <summary>k_ERemoteStoragePlatformWindows</summary>
        Windows = 1,
        /// <summary>k_ERemoteStoragePlatformOSX</summary>
        OSX = 2,
        /// <summary>k_ERemoteStoragePlatformPS3</summary>
        PS3 = 4,
        /// <summary>k_ERemoteStoragePlatformLinux</summary>
        Linux = 8,
        /// <summary>k_ERemoteStoragePlatformSwitch</summary>
        Switch = 16,
        /// <summary>k_ERemoteStoragePlatformAndroid</summary>
        Android = 32,
        /// <summary>k_ERemoteStoragePlatformIOS</summary>
        IOS = 64,
        /// <summary>k_ERemoteStoragePlatformAll</summary>
        All = -1
    }
}