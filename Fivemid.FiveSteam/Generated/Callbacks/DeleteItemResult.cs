using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when an attempt at deleting an item completes.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DeleteItem" class="bb_apilink">ISteamUGC::DeleteItem</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct DeleteItemResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DeleteItemResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The workshop item which was being deleted.</summary>
        public PublishedFileId nPublishedFileId;
    }
}