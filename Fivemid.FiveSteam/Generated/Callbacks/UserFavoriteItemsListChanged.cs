using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the user has added or removed an item to/from their favorites.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemToFavorites" class="bb_apilink">ISteamUGC::AddItemToFavorites</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveItemFromFavorites" class="bb_apilink">ISteamUGC::RemoveItemFromFavorites</a></summary>
    public unsafe struct UserFavoriteItemsListChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserFavoriteItemsListChanged;
        /// <summary>The item which was added/removed.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>Was it added (<b>true</b>) or removed (<b>false</b>) from the user's favorites?</summary>
        public bool bWasAddRequest;
    }
}