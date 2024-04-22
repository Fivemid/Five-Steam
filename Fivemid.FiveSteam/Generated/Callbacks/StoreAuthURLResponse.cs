using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Response when we have recieved the authentication URL after a call to <a href="https://partner.steamgames.com/doc/api/ISteamUser#RequestStoreAuthURL" class="bb_apilink">ISteamUser::RequestStoreAuthURL</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUser#RequestStoreAuthURL" class="bb_apilink">ISteamUser::RequestStoreAuthURL</a></summary>
    public unsafe struct StoreAuthURLResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StoreAuthURLResponse;
        /// <summary>The authentication URL.</summary>
        public UTF8String512 szURL;
    }
}