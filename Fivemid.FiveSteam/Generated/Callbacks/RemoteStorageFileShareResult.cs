using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileShare" class="bb_apilink">ISteamRemoteStorage::FileShare</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageFileShareResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageFileShareResult;
        /// <summary>The result of the operation</summary>
        public Result eResult;
        /// <summary>The handle that can be shared with users and features</summary>
        public UGCHandle hFile;
        /// <summary>The name of the file that was shared</summary>
        public UTF8String260 rgchFilename;
    }
}