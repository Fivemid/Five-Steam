using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ERemoteStorageLocalFileChange</summary>
    public enum RemoteStorageLocalFileChangeType : int
    {
        /// <summary>k_ERemoteStorageLocalFileChange_Invalid</summary>
        RemoteStorageLocalFileChange_Invalid = 0,
        /// <summary>k_ERemoteStorageLocalFileChange_FileUpdated</summary>
        RemoteStorageLocalFileChange_FileUpdated = 1,
        /// <summary>k_ERemoteStorageLocalFileChange_FileDeleted</summary>
        RemoteStorageLocalFileChange_FileDeleted = 2
    }
}