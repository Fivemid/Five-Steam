using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Response when we have recieved the authentication URL after a call to <a href="https://partner.steamgames.com/doc/api/ISteamUser#RequestStoreAuthURL" class="bb_apilink">ISteamUser::RequestStoreAuthURL</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUser#RequestStoreAuthURL" class="bb_apilink">ISteamUser::RequestStoreAuthURL</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct StoreAuthURLResponse
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StoreAuthURLResponse;
        /// <summary>The authentication URL.</summary>
        public UTF8String512 szURL;
    }
}