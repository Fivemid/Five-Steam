using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamParties
    {
        public static ISteamParties.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamParties_v002", CallingConvention = Platform.CC)]
        private static extern ISteamParties.Instance Accessor();
        /// <summary></summary>
        public static uint GetNumActiveBeacons() => Instance.GetNumActiveBeacons();
        /// <summary></summary>
        public static PartyBeaconID GetBeaconByIndex(uint unIndex) => Instance.GetBeaconByIndex(unIndex);
        /// <summary></summary>
        public static bool GetBeaconDetails(PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, char* pchMetadata, int cchMetadata) => Instance.GetBeaconDetails(ulBeaconID, pSteamIDBeaconOwner, pLocation, pchMetadata, cchMetadata);
        /// <summary></summary>
        public static SteamAPICall JoinParty(PartyBeaconID ulBeaconID) => Instance.JoinParty(ulBeaconID);
        /// <summary></summary>
        public static bool GetNumAvailableBeaconLocations(uint* puNumLocations) => Instance.GetNumAvailableBeaconLocations(puNumLocations);
        /// <summary></summary>
        public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations) => Instance.GetAvailableBeaconLocations(pLocationList, uMaxNumLocations);
        /// <summary></summary>
        public static SteamAPICall CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata) => Instance.CreateBeacon(unOpenSlots, pBeaconLocation, pchConnectString, pchMetadata);
        /// <summary></summary>
        public static void OnReservationCompleted(PartyBeaconID ulBeacon, SteamId steamIDUser) => Instance.OnReservationCompleted(ulBeacon, steamIDUser);
        /// <summary></summary>
        public static void CancelReservation(PartyBeaconID ulBeacon, SteamId steamIDUser) => Instance.CancelReservation(ulBeacon, steamIDUser);
        /// <summary></summary>
        public static SteamAPICall ChangeNumOpenSlots(PartyBeaconID ulBeacon, uint unOpenSlots) => Instance.ChangeNumOpenSlots(ulBeacon, unOpenSlots);
        /// <summary></summary>
        public static bool DestroyBeacon(PartyBeaconID ulBeacon) => Instance.DestroyBeacon(ulBeacon);
        /// <summary></summary>
        public static bool GetBeaconLocationData(SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, char* pchDataStringOut, int cchDataStringOut) => Instance.GetBeaconLocationData(BeaconLocation, eData, pchDataStringOut, cchDataStringOut);
    }
}