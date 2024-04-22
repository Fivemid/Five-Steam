using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Marks the return of a request officer list call.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestClanOfficerList" class="bb_apilink">ISteamFriends::RequestClanOfficerList</a></summary>
    public unsafe struct ClanOfficerListResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ClanOfficerListResponse;
        /// <summary>The Steam group that we just got the officer list for.</summary>
        public SteamId steamIDClan;
        /// <summary>The number of officers in the group. This is the same as <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOfficerCount" class="bb_apilink">ISteamFriends::GetClanOfficerCount</a>.</summary>
        public int cOfficers;
        /// <summary>Was the call successful? If it wasn't this may indicate a temporary loss of connection to Steam.<br />
        /// If this returns <b>true</b>, this does not necessarily mean that all of the info for this Steam group has been downloaded.</summary>
        public byte bSuccess;
    }
}