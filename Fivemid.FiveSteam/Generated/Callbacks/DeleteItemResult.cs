using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when an attempt at deleting an item completes.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DeleteItem" class="bb_apilink">ISteamUGC::DeleteItem</a></summary>
    public unsafe struct DeleteItemResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DeleteItemResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The workshop item which was being deleted.</summary>
        public PublishedFileId nPublishedFileId;
    }
}