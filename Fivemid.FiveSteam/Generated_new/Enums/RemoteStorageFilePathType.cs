using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ERemoteStorageFilePathType</summary>
    public enum RemoteStorageFilePathType : int
    {
        /// <summary>k_ERemoteStorageFilePathType_Invalid</summary>
        Invalid = 0,
        /// <summary>k_ERemoteStorageFilePathType_Absolute</summary>
        Absolute = 1,
        /// <summary>k_ERemoteStorageFilePathType_APIFilename</summary>
        APIFilename = 2
    }
}