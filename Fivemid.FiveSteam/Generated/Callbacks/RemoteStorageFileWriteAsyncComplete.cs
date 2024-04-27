using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Response when writing a file asyncrounously with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteAsync" class="bb_apilink">ISteamRemoteStorage::FileWriteAsync</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteAsync" class="bb_apilink">ISteamRemoteStorage::FileWriteAsync</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageFileWriteAsyncComplete
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageFileWriteAsyncComplete;
        /// <summary>The result of the operation.<br />
        /// If the local write was successful then this will be <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> - any other value likely indicates that the filename is invalid or the available quota would have been exceeded by the requested write. Any attempt to write files that exceed this size will return an EResult of <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a>. Writing files to the cloud is limited to 100MiB.</summary>
        public Result eResult;
    }
}