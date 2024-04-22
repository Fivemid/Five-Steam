using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>After creating a beacon, when a user "follows" that beacon Steam will send you this callback to know that you should be prepared for the user to join your game. When they do join, be sure to call <a href="https://partner.steamgames.com/doc/api/ISteamParties#OnReservationCompleted" class="bb_apilink">ISteamParties::OnReservationCompleted</a> to let Steam know.<br />
    /// <br />
    /// </summary>
    public unsafe struct ReservationNotificationCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ReservationNotificationCallback;
        /// <summary>Beacon ID of your beacon.</summary>
        public PartyBeaconID ulBeaconID;
        /// <summary>SteamID of the user following your beacon.</summary>
        public SteamId steamIDJoiner;
    }
}