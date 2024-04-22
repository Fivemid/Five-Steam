using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the user has added or removed an item to/from their subscriptions for the returned appid.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubscribeItem" class="bb_apilink">ISteamUGC::SubscribeItem</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UnsubscribeItem" class="bb_apilink">ISteamUGC::UnsubscribeItem</a></summary>
    public unsafe struct UserSubscribedItemsListChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserSubscribedItemsListChanged;
        /// <summary>The related appid.</summary>
        public AppId nAppID;
    }
}