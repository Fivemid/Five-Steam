using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called whenever a friends' status changes.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestUserInformation" class="bb_apilink">ISteamFriends::RequestUserInformation</a>
    /// </summary>
    public unsafe struct PersonaStateChange : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.PersonaStateChange;
        /// <summary>Steam ID of the user who changed.</summary>
        public ulong ulSteamID;
        /// <summary>
        ///             A bit-wise union of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EPersonaChange" class="bb_apilink">EPersonaChange</a>
        ///             values.
        ///         </summary>
        public int nChangeFlags;
    }
}