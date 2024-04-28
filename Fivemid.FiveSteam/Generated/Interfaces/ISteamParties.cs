using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// This API can be used to selectively advertise your multiplayer game session in a Steam chat room group. Tell Steam the number of player spots that are available for your party, and a join-game string, and it will show a beacon in the selected group and allow that many users to “follow” the beacon to your party. Adjust the number of open slots if other players join through alternate matchmaking methods. <br />
    /// <br />
    /// For example, you can use ISteamParties in conjunction with a private lobby. Create a private lobby, and then use <a href="https://partner.steamgames.com/doc/api/ISteamParties#CreateBeacon" class="bb_apilink">ISteamParties::CreateBeacon</a> to create a party "beacon" for the number of players desired. The game connect string should indicate the ID of the private lobby. <br />
    /// <br />
    /// The beacon will appear in Steam in the specified location (e.g. a Chat Room Group), and also via the in-game ISteamParties API as described below. Steam creates "reservation" slots for the number of desired players. Whenever a user follows the beacon, Steam will hold a reservation slot for them and launch the game using the given connect string. <br />
    /// <br />
    /// The game session that created the beacon will be notified of this reservation, so the game can display the appropriate "User &lt;username&gt; is joining your party" or some other indicator. Once the user joins successfully, the game session should call  <a href="https://partner.steamgames.com/doc/api/ISteamParties#OnReservationCompleted" class="bb_apilink">ISteamParties::OnReservationCompleted</a> to tell Steam that the user successfully joined (otherwise, Steam will eventually timeout their reservation and re-open the slot). <br />
    /// <br />
    /// When all of the beacon slots are occupied - either by reservations for users still launching the game, or completed slots for users in the party - Steam will hide and disable the beacon. <br />
    /// <br />
    /// To cancel the beacon - for instance when the party is full and the game begins - call <a href="https://partner.steamgames.com/doc/api/ISteamParties#DestroyBeacon" class="bb_apilink">ISteamParties::DestroyBeacon</a>.<br />
    /// <br />
    /// The client side of this operation - seeing and following beacons - can also be managed by your game. Using <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetNumActiveBeacons" class="bb_apilink">ISteamParties::GetNumActiveBeacons</a> and <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetBeaconDetails" class="bb_apilink">ISteamParties::GetBeaconDetails</a>, your game can get a list of beacons from other users that are currently active in locations relevant to the current user. If the user desires, call <a href="https://partner.steamgames.com/doc/api/ISteamParties#JoinParty" class="bb_apilink">ISteamParties::JoinParty</a> to "follow" one of those beacons.</summary>
    public unsafe interface ISteamParties
    {
        public uint GetNumActiveBeacons();
        public PartyBeaconID GetBeaconByIndex(uint unIndex);
        public bool GetBeaconDetails(PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, byte* pchMetadata, int cchMetadata);
        public SteamAPICall JoinParty(PartyBeaconID ulBeaconID);
        public bool GetNumAvailableBeaconLocations(uint* puNumLocations);
        public bool GetAvailableBeaconLocations(SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations);
        public SteamAPICall CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata);
        public void OnReservationCompleted(PartyBeaconID ulBeacon, SteamId steamIDUser);
        public void CancelReservation(PartyBeaconID ulBeacon, SteamId steamIDUser);
        public SteamAPICall ChangeNumOpenSlots(PartyBeaconID ulBeacon, uint unOpenSlots);
        public bool DestroyBeacon(PartyBeaconID ulBeacon);
        public bool GetBeaconLocationData(SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, byte* pchDataStringOut, int cchDataStringOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_GetNumActiveBeacons", CallingConvention = Platform.CC)]
        internal static extern uint GetNumActiveBeacons(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_GetBeaconByIndex", CallingConvention = Platform.CC)]
        internal static extern PartyBeaconID GetBeaconByIndex(void* self, uint unIndex);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_GetBeaconDetails", CallingConvention = Platform.CC)]
        internal static extern bool GetBeaconDetails(void* self, PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, byte* pchMetadata, int cchMetadata);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_JoinParty", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall JoinParty(void* self, PartyBeaconID ulBeaconID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_GetNumAvailableBeaconLocations", CallingConvention = Platform.CC)]
        internal static extern bool GetNumAvailableBeaconLocations(void* self, uint* puNumLocations);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_GetAvailableBeaconLocations", CallingConvention = Platform.CC)]
        internal static extern bool GetAvailableBeaconLocations(void* self, SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_CreateBeacon", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall CreateBeacon(void* self, uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_OnReservationCompleted", CallingConvention = Platform.CC)]
        internal static extern void OnReservationCompleted(void* self, PartyBeaconID ulBeacon, SteamId steamIDUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_CancelReservation", CallingConvention = Platform.CC)]
        internal static extern void CancelReservation(void* self, PartyBeaconID ulBeacon, SteamId steamIDUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_ChangeNumOpenSlots", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall ChangeNumOpenSlots(void* self, PartyBeaconID ulBeacon, uint unOpenSlots);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_DestroyBeacon", CallingConvention = Platform.CC)]
        internal static extern bool DestroyBeacon(void* self, PartyBeaconID ulBeacon);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParties_GetBeaconLocationData", CallingConvention = Platform.CC)]
        internal static extern bool GetBeaconLocationData(void* self, SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, byte* pchDataStringOut, int cchDataStringOut);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamParties
        {
            public void* self;
            public uint GetNumActiveBeacons() => ISteamParties.GetNumActiveBeacons(self);
            public PartyBeaconID GetBeaconByIndex(uint unIndex) => ISteamParties.GetBeaconByIndex(self, unIndex);
            public bool GetBeaconDetails(PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, byte* pchMetadata, int cchMetadata) => ISteamParties.GetBeaconDetails(self, ulBeaconID, pSteamIDBeaconOwner, pLocation, pchMetadata, cchMetadata);
            public SteamAPICall JoinParty(PartyBeaconID ulBeaconID) => ISteamParties.JoinParty(self, ulBeaconID);
            public bool GetNumAvailableBeaconLocations(uint* puNumLocations) => ISteamParties.GetNumAvailableBeaconLocations(self, puNumLocations);
            public bool GetAvailableBeaconLocations(SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations) => ISteamParties.GetAvailableBeaconLocations(self, pLocationList, uMaxNumLocations);
            public SteamAPICall CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata) => ISteamParties.CreateBeacon(self, unOpenSlots, pBeaconLocation, pchConnectString, pchMetadata);
            public void OnReservationCompleted(PartyBeaconID ulBeacon, SteamId steamIDUser) => ISteamParties.OnReservationCompleted(self, ulBeacon, steamIDUser);
            public void CancelReservation(PartyBeaconID ulBeacon, SteamId steamIDUser) => ISteamParties.CancelReservation(self, ulBeacon, steamIDUser);
            public SteamAPICall ChangeNumOpenSlots(PartyBeaconID ulBeacon, uint unOpenSlots) => ISteamParties.ChangeNumOpenSlots(self, ulBeacon, unOpenSlots);
            public bool DestroyBeacon(PartyBeaconID ulBeacon) => ISteamParties.DestroyBeacon(self, ulBeacon);
            public bool GetBeaconLocationData(SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, byte* pchDataStringOut, int cchDataStringOut) => ISteamParties.GetBeaconLocationData(self, BeaconLocation, eData, pchDataStringOut, cchDataStringOut);
        }
    }
}