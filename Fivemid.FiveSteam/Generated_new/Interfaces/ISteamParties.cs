using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamParties</summary>
    public unsafe interface ISteamParties
    {
        public uint GetNumActiveBeacons();
        public PartyBeaconID GetBeaconByIndex(uint unIndex);
        public bool GetBeaconDetails(PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, char* pchMetadata, int cchMetadata);
        public SteamAPICall JoinParty(PartyBeaconID ulBeaconID);
        public bool GetNumAvailableBeaconLocations(uint* puNumLocations);
        public bool GetAvailableBeaconLocations(SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations);
        public SteamAPICall CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata);
        public void OnReservationCompleted(PartyBeaconID ulBeacon, SteamId steamIDUser);
        public void CancelReservation(PartyBeaconID ulBeacon, SteamId steamIDUser);
        public SteamAPICall ChangeNumOpenSlots(PartyBeaconID ulBeacon, uint unOpenSlots);
        public bool DestroyBeacon(PartyBeaconID ulBeacon);
        public bool GetBeaconLocationData(SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, char* pchDataStringOut, int cchDataStringOut);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_GetNumActiveBeacons", CallingConvention = Platform.CC)]
        internal static extern uint GetNumActiveBeacons(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_GetBeaconByIndex", CallingConvention = Platform.CC)]
        internal static extern PartyBeaconID GetBeaconByIndex(void* self, uint unIndex);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_GetBeaconDetails", CallingConvention = Platform.CC)]
        internal static extern bool GetBeaconDetails(void* self, PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, char* pchMetadata, int cchMetadata);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_JoinParty", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall JoinParty(void* self, PartyBeaconID ulBeaconID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_GetNumAvailableBeaconLocations", CallingConvention = Platform.CC)]
        internal static extern bool GetNumAvailableBeaconLocations(void* self, uint* puNumLocations);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_GetAvailableBeaconLocations", CallingConvention = Platform.CC)]
        internal static extern bool GetAvailableBeaconLocations(void* self, SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_CreateBeacon", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall CreateBeacon(void* self, uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_OnReservationCompleted", CallingConvention = Platform.CC)]
        internal static extern void OnReservationCompleted(void* self, PartyBeaconID ulBeacon, SteamId steamIDUser);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_CancelReservation", CallingConvention = Platform.CC)]
        internal static extern void CancelReservation(void* self, PartyBeaconID ulBeacon, SteamId steamIDUser);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_ChangeNumOpenSlots", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall ChangeNumOpenSlots(void* self, PartyBeaconID ulBeacon, uint unOpenSlots);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_DestroyBeacon", CallingConvention = Platform.CC)]
        internal static extern bool DestroyBeacon(void* self, PartyBeaconID ulBeacon);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamParties_GetBeaconLocationData", CallingConvention = Platform.CC)]
        internal static extern bool GetBeaconLocationData(void* self, SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, char* pchDataStringOut, int cchDataStringOut);
        public struct Instance : ISteamParties
        {
            public void* self;
            public uint GetNumActiveBeacons() => ISteamParties.GetNumActiveBeacons(self);
            public PartyBeaconID GetBeaconByIndex(uint unIndex) => ISteamParties.GetBeaconByIndex(self, unIndex);
            public bool GetBeaconDetails(PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, char* pchMetadata, int cchMetadata) => ISteamParties.GetBeaconDetails(self, ulBeaconID, pSteamIDBeaconOwner, pLocation, pchMetadata, cchMetadata);
            public SteamAPICall JoinParty(PartyBeaconID ulBeaconID) => ISteamParties.JoinParty(self, ulBeaconID);
            public bool GetNumAvailableBeaconLocations(uint* puNumLocations) => ISteamParties.GetNumAvailableBeaconLocations(self, puNumLocations);
            public bool GetAvailableBeaconLocations(SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations) => ISteamParties.GetAvailableBeaconLocations(self, pLocationList, uMaxNumLocations);
            public SteamAPICall CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata) => ISteamParties.CreateBeacon(self, unOpenSlots, pBeaconLocation, pchConnectString, pchMetadata);
            public void OnReservationCompleted(PartyBeaconID ulBeacon, SteamId steamIDUser) => ISteamParties.OnReservationCompleted(self, ulBeacon, steamIDUser);
            public void CancelReservation(PartyBeaconID ulBeacon, SteamId steamIDUser) => ISteamParties.CancelReservation(self, ulBeacon, steamIDUser);
            public SteamAPICall ChangeNumOpenSlots(PartyBeaconID ulBeacon, uint unOpenSlots) => ISteamParties.ChangeNumOpenSlots(self, ulBeacon, unOpenSlots);
            public bool DestroyBeacon(PartyBeaconID ulBeacon) => ISteamParties.DestroyBeacon(self, ulBeacon);
            public bool GetBeaconLocationData(SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, char* pchDataStringOut, int cchDataStringOut) => ISteamParties.GetBeaconLocationData(self, BeaconLocation, eData, pchDataStringOut, cchDataStringOut);
        }
    }
}