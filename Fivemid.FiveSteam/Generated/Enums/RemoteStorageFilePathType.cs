using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>For APIs that may return file paths in different forms. See <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetLocalFileChange" class="bb_apilink">ISteamRemoteStorage::GetLocalFileChange</a>.<br />
    /// <br />
    /// </summary>
    public enum RemoteStorageFilePathType : int
    {
        /// <summary>Unused.</summary>
        Invalid = 0,
        /// <summary>An absolute disk path is provided. This type of path is used for files managed via AutoCloud.</summary>
        Absolute = 1,
        /// <summary>An ISteamRemoteStorage API relative path is provided. This type of path is used for files managed via the ISteamRemoteStorage API methods (FileWrite, FileRead, etc).</summary>
        APIFilename = 2
    }
}