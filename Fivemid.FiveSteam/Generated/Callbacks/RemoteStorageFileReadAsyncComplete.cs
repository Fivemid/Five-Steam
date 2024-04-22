using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Response when reading a file asyncrounously with <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileReadAsync" class="bb_apilink">ISteamRemoteStorage::FileReadAsync</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileReadAsync" class="bb_apilink">ISteamRemoteStorage::FileReadAsync</a></summary>
    public unsafe struct RemoteStorageFileReadAsyncComplete : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageFileReadAsyncComplete;
        /// <summary>Call handle of the async read which was made, must be passed to <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileReadAsyncComplete" class="bb_apilink">ISteamRemoteStorage::FileReadAsyncComplete</a> to get the data.</summary>
        public SteamAPICall hFileReadAsync;
        /// <summary>The result of the operation.<br />
        /// If the local read was successful this will be <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>, you can then call <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileReadAsyncComplete" class="bb_apilink">ISteamRemoteStorage::FileReadAsyncComplete</a> to get the data.</summary>
        public Result eResult;
        /// <summary>Offset into the file this read was at.</summary>
        public uint nOffset;
        /// <summary>Amount of bytes read - will be the &lt;= the amount requested.</summary>
        public uint cubRead;
    }
}