using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called after requesting the details of a specific file.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetFileDetails" class="bb_apilink">ISteamApps::GetFileDetails</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct FileDetailsResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FileDetailsResult;
        /// <summary>Was the call successful? <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> if it was; otherwise, <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFileNotFound" class="bb_apilink">k_EResultFileNotFound</a> if the file was not found. None of the other fields are filled out if the call was not successful.</summary>
        public Result eResult;
        /// <summary>The original file size in bytes.</summary>
        public ulong ulFileSize;
        /// <summary>The original file SHA1 hash.</summary>
        public FixedArray_byte20 FileSHA;
        /// <summary></summary>
        public uint unFlags;
    }
}