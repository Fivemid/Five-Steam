using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamParties
    {
        public static ISteamParties.Instance Instance => Accessor();

        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamParties_v002", CallingConvention = Platform.CC)]
        private static extern ISteamParties.Instance Accessor();
        /// <summary><code>uint32 GetNumActiveBeacons();</code><br />
        /// This method has no parameters.<br />
        /// <br />
        /// Get the number of active party beacons created by <i>other</i> users for your game, that are visible to the current user.<br />
        /// <br />
        /// <b>Returns:</b> uint32</summary>
        /// 
        public static uint GetNumActiveBeacons() => Instance.GetNumActiveBeacons();
        /// <summary><code>PartyBeaconID_t GetBeaconByIndex( uint32 unIndex );</code><br />
        /// Use with <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetNumActiveBeacons" class="bb_apilink">ISteamParties::GetNumActiveBeacons</a> to iterate the active beacons visible to the current user. <b>unIndex</b> is a zero-based index, so iterate over the range [0, GetNumActiveBeacons() - 1]. The return is a <b>PartyBeaconID_t</b> that can be used with <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetBeaconDetails" class="bb_apilink">ISteamParties::GetBeaconDetails</a> to get information about the beacons suitable for display to the user. <br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamParties#PartyBeaconID_t" class="bb_apilink">PartyBeaconID_t</a></summary>
        /// <param name="unIndex "><a href="https://partner.steamgames.com/doc/api/uint32" class="bb_apilink">uint32</a>: Index of Beacon.</param>
        public static PartyBeaconID GetBeaconByIndex(uint unIndex) => Instance.GetBeaconByIndex(unIndex);
        /// <summary><code>bool GetBeaconDetails( PartyBeaconID_t ulBeaconID, CSteamID *pSteamIDBeaconOwner,SteamPartyBeaconLocation_t *pLocation, char *pchMetadata, int cchMetadata );</code><br />
        /// Get details about the specified beacon. You can use the <a href="https://partner.steamgames.com/doc/api/ISteamFriends" class="bb_apilink">ISteamFriends</a> API to get further details about <b>pSteamIDBeaconOwner</b>, and <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetBeaconLocationData" class="bb_apilink">ISteamParties::GetBeaconLocationData</a> to get further details about <b>pLocation</b>. The <b>pchMetadata</b> contents are specific to your game, and will be whatever was set (if anything) by the game process that created the beacon.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="ulBeaconID"><a href="https://partner.steamgames.com/doc/api/ISteamParties#PartyBeaconID_t" class="bb_apilink">PartyBeaconID_t</a>: Beacon ID to query.</param>
        /// <param name="pSteamIDBeaconOwner"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>*: Creator of the beacon.</param>
        /// <param name="pLocation"><a href="https://partner.steamgames.com/doc/api/ISteamParties#SteamPartyBeaconLocation_t" class="bb_apilink">SteamPartyBeaconLocation_t</a>*: Location the beacon has been posted.</param>
        /// <param name="pchMetadata">char*: Buffer to receive any additional metadata the game has set on this beacon (e.g. game mode). Will be NULL terminated on success</param>
        /// <param name="cchMetadata "><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: Size of the above buffer.</param>
        public static bool GetBeaconDetails(PartyBeaconID ulBeaconID, SteamId* pSteamIDBeaconOwner, SteamPartyBeaconLocation* pLocation, byte* pchMetadata, int cchMetadata) => Instance.GetBeaconDetails(ulBeaconID, pSteamIDBeaconOwner, pLocation, pchMetadata, cchMetadata);
        /// <summary><code>SteamAPICall_t JoinParty( PartyBeaconID_t ulBeaconID );</code><br />
        /// When the user indicates they wish to join the party advertised by a given beacon, call this method. On success, Steam will reserve a slot for this user in the party and return the necessary "join game" string to use to complete the connection.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/JoinParty_t" class="bb_apilink">JoinParty_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> if the beacon ID is invalid.</summary>
        /// <param name="ulBeacon"><a href="https://partner.steamgames.com/doc/api/ISteamParties#PartyBeaconID_t" class="bb_apilink">PartyBeaconID_t</a>: Beacon ID for the party you wish to join.</param>
        public static SteamAPICall JoinParty(PartyBeaconID ulBeaconID) => Instance.JoinParty(ulBeaconID);
        /// <summary><code>bool GetNumAvailableBeaconLocations( uint32 *puNumLocations );</code><br />
        /// Get the number of locations in which you are able to post a party beacon.<br />
        /// <br />
        /// Use this to size your result list for a call to <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetAvailableBeaconLocations" class="bb_apilink">ISteamParties::GetAvailableBeaconLocations</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="puNumLocations"><a href="https://partner.steamgames.com/doc/api/uint32" class="bb_apilink">uint32</a>*: Address of variable to receive the response number.</param>
        public static bool GetNumAvailableBeaconLocations(uint* puNumLocations) => Instance.GetNumAvailableBeaconLocations(puNumLocations);
        /// <summary><code>bool GetAvailableBeaconLocations( SteamPartyBeaconLocation_t *pLocationList, uint32 uMaxNumLocations );</code><br />
        /// Get the list of locations in which you can post a party beacon.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetNumAvailableBeaconLocations" class="bb_apilink">ISteamParties::GetNumAvailableBeaconLocations</a><br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="pLocationList"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamPartyBeaconLocation_t" class="bb_apilink">SteamPartyBeaconLocation_t</a>*: Output list of available beacon locations.</param>
        /// <param name="uMaxNumLocations"><a href="https://partner.steamgames.com/doc/api/uint32" class="bb_apilink">uint32</a>: The maximum number of entries to put into the above list. Should be &gt;= the result from GetNumAvailableBeaconLocations.</param>
        public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation* pLocationList, uint uMaxNumLocations) => Instance.GetAvailableBeaconLocations(pLocationList, uMaxNumLocations);
        /// <summary><code>SteamAPICall_t CreateBeacon( uint32 unOpenSlots, SteamPartyBeaconLocation_t *pBeaconLocation, const char *pchConnectString, const char *pchMetadata );</code><br />
        /// Create a beacon. You can only create one beacon at a time. Steam will display the beacon in the specified location, and let up to unOpenSlots users "follow" the beacon to your party. <br />
        /// <br />
        /// If users join your party through other matchmaking, adjust the number of remaining open slots using <a href="https://partner.steamgames.com/doc/api/ISteamParties#ChangeNumOpenSlots" class="bb_apilink">ISteamParties::ChangeNumOpenSlots</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/CreateBeaconCallback_t" class="bb_apilink">CreateBeaconCallback_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> if the process already has an active beacon, or if the location information is invalid.</summary>
        /// <param name="unOpenSlots"><a href="https://partner.steamgames.com/doc/api/uint32" class="bb_apilink">uint32</a>: Number of reservation slots to create for the beacon. Normally, this is the size of your desired party minus one (for the current user).</param>
        /// <param name="pBeaconLocation"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamPartyBeaconLocation_t" class="bb_apilink">SteamPartyBeaconLocation_t</a>*: Location information for the beacon. Should be one of the locations returned by <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetAvailableBeaconLocations" class="bb_apilink">ISteamParties::GetAvailableBeaconLocations</a>.</param>
        /// <param name="pchConnectString">char *: Connect string that will be given to the game on launch for a user that follows the beacon.</param>
        /// <param name="pchMetadata">char *: Additional game metadata that can be set on the beacon, and is exposed via <a href="https://partner.steamgames.com/doc/api/ISteamParties#GetBeaconDetails" class="bb_apilink">ISteamParties::GetBeaconDetails</a>.</param>
        public static SteamAPICall CreateBeacon(uint unOpenSlots, SteamPartyBeaconLocation* pBeaconLocation, UTF8StringPtr pchConnectString, UTF8StringPtr pchMetadata) => Instance.CreateBeacon(unOpenSlots, pBeaconLocation, pchConnectString, pchMetadata);
        /// <summary><code>void OnReservationCompleted( PartyBeaconID_t ulBeacon, CSteamID steamIDUser );</code><br />
        /// When a user follows your beacon, Steam will reserve one of the open party slots for them, and send your game a <a href="https://partner.steamgames.com/doc/api/ReservationNotificationCallback_t" class="bb_apilink">ReservationNotificationCallback_t</a> callback. When that user joins your party, call <b>OnReservationCompleted</b> to notify Steam that the user has joined successfully.</summary>
        /// <param name="ulBeacon"><a href="https://partner.steamgames.com/doc/api/steam_api#PartyBeaconID_t" class="bb_apilink">PartyBeaconID_t</a>: Beacon ID for the beacon created by your process.</param>
        /// <param name="steamIDUser"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: SteamID of the user joining your party.</param>
        public static void OnReservationCompleted(PartyBeaconID ulBeacon, SteamId steamIDUser) => Instance.OnReservationCompleted(ulBeacon, steamIDUser);
        /// missing documentation
        public static void CancelReservation(PartyBeaconID ulBeacon, SteamId steamIDUser) => Instance.CancelReservation(ulBeacon, steamIDUser);
        /// <summary><code>SteamAPICall_t ChangeNumOpenSlots( PartyBeaconID_t ulBeacon, uint32 unOpenSlots );</code><br />
        /// If a user joins your party through other matchmaking (perhaps a direct Steam friend, or your own matchmaking system), your game should reduce the number of open slots that Steam is managing through the party beacon. For example, if you created a beacon with five slots, and Steam sent you two <a href="https://partner.steamgames.com/doc/api/ReservationNotificationCallback_t" class="bb_apilink">ReservationNotificationCallback_t</a> callbacks, and then a third user joined directly, you would want to call <b>ChangeNumOpenSlots</b> with a value of 2 for unOpenSlots. That value represents the total number of <i>new</i> users that you would like Steam to send to your party.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ChangeNumOpenSlotsCallback_t" class="bb_apilink">ChangeNumOpenSlotsCallback_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> if the beacon ID is invalid.</summary>
        /// <param name="ulBeacon"><a href="https://partner.steamgames.com/doc/api/ISteamParties#PartyBeaconID_t" class="bb_apilink">PartyBeaconID_t</a>: Beacon ID for the beacon created by your process.</param>
        /// <param name="unOpenSlots"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The new number of open slots in your party.</param>
        public static SteamAPICall ChangeNumOpenSlots(PartyBeaconID ulBeacon, uint unOpenSlots) => Instance.ChangeNumOpenSlots(ulBeacon, unOpenSlots);
        /// <summary><code>bool DestroyBeacon( PartyBeaconID_t ulBeacon );</code><br />
        /// Call this method to destroy the Steam party beacon. This will immediately cause Steam to stop showing the beacon in the target location. Note that any users currently in-flight may still arrive at your party expecting to join.<br />
        /// <br />
        /// Your game should call this method when either the party has been filled and the game is beginning, or the user has decided to abandon creating a party. The beacon will be destroyed automatically when your game exits, but the preferred behavior is for the game to call <b>DestroyBeacon</b> at the right time.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="ulBeacon"><a href="https://partner.steamgames.com/doc/api/ISteamParties#PartyBeaconID_t" class="bb_apilink">PartyBeaconID_t</a>: Beacon ID to be destroyed.</param>
        public static bool DestroyBeacon(PartyBeaconID ulBeacon) => Instance.DestroyBeacon(ulBeacon);
        /// <summary><code>bool GetBeaconLocationData( SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, char *pchDataStringOut, int cchDataStringOut );</code><br />
        /// Query general metadata for the given beacon location. For instance the Name, or the URL for an icon if the location type supports icons (for example, the icon for a Steam Chat Room Group).<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="BeaconLocation"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamPartyBeaconLocation_t%20" class="bb_apilink">SteamPartyBeaconLocation_t </a>: Location to query.</param>
        /// <param name="eData"><a href="https://partner.steamgames.com/doc/api/steam_api#ESteamPartyBeaconLocationData%20" class="bb_apilink">ESteamPartyBeaconLocationData </a>: Type of location data you wish to get.</param>
        /// <param name="pchDataStringOut">char *: Output buffer for location data string. Will be NULL-terminated on success.</param>
        /// <param name="cchDataStringOut ">int: Size of buffer pointed to by pchDataStringOut.</param>
        public static bool GetBeaconLocationData(SteamPartyBeaconLocation BeaconLocation, SteamPartyBeaconLocationData eData, byte* pchDataStringOut, int cchDataStringOut) => Instance.GetBeaconLocationData(BeaconLocation, eData, pchDataStringOut, cchDataStringOut);
    }
}