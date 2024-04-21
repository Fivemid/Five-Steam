using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public struct FiveSteamConstants
    {
        /// <summary>An Invalid App ID.</summary>
        public static readonly AppId k_uAppIdInvalid = 0x0;
        /// <summary>An Invalid Depot ID.</summary>
        public static readonly DepotId k_uDepotIdInvalid = 0x0;
        /// <summary>An Invalid Steam API Call handle.</summary>
        public static readonly SteamAPICall k_uAPICallInvalid = 0x0;
        /// missing documentation for k_uAccountIdInvalid
        public static readonly AccountID k_uAccountIdInvalid = 0;
        /// missing documentation for k_ulPartyBeaconIdInvalid
        public static readonly PartyBeaconID k_ulPartyBeaconIdInvalid = 0;
        /// <summary>An invalid user authentication ticket.</summary>
        public static readonly HAuthTicket k_HAuthTicketInvalid = 0;
        /// <summary>
        ///             Used in <a href="#CSteamID" class="bb_apilink">CSteamID</a> to mask out the
        ///             <a href="#AccountID_t" class="bb_apilink">AccountID_t</a>.
        ///         </summary>
        public const uint k_unSteamAccountIDMask = 0xFFFFFFFF;
        /// <summary>
        ///             Used in <a href="#CSteamID" class="bb_apilink">CSteamID</a> to mask out the account
        ///             instance.
        ///         </summary>
        public const uint k_unSteamAccountInstanceMask = 0x000FFFFF;
        /// missing documentation for k_unSteamUserDefaultInstance
        public const uint k_unSteamUserDefaultInstance = 1;
        /// <summary>
        ///             The maximum size (in UTF-8 bytes, including the null terminator) of the
        ///             <code class="bb_code bb_code_inline nohighlight">pchExtraInfo</code> parameter of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUser#TrackAppUsageEvent" class="bb_apilink">ISteamUser::TrackAppUsageEvent</a>.
        ///         </summary>
        public const int k_cchGameExtraInfoMax = 64;
        /// missing documentation for k_cchMaxSteamErrMsg
        public const int k_cchMaxSteamErrMsg = 1024;
        /// <summary>
        ///             The maximum length that a friends group name can be (not including the null-terminator!)
        ///         </summary>
        public const int k_cchMaxFriendsGroupName = 64;
        /// <summary>Deprecated - Unused.</summary>
        public const int k_cFriendsGroupLimit = 100;
        /// <summary>Invalid friends group identifier.</summary>
        public static readonly FriendsGroupID k_FriendsGroupID_Invalid = -1;
        /// <summary>
        ///             The maximum number of followers that will be returned in a
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsEnumerateFollowingList_t" class="bb_apilink">FriendsEnumerateFollowingList_t</a>
        ///             call result at once.
        ///         </summary>
        public const int k_cEnumerateFollowersMax = 50;
        /// missing documentation for k_usFriendGameInfoQueryPort_NotInitialized
        public const ushort k_usFriendGameInfoQueryPort_NotInitialized = 0xFFFF;
        /// missing documentation for k_usFriendGameInfoQueryPort_Error
        public const ushort k_usFriendGameInfoQueryPort_Error = 0xFFFE;
        /// <summary>
        ///             Maximum size in bytes that chat room, lobby, or chat/lobby member metadata may have.
        ///         </summary>
        public const uint k_cubChatMetadataMax = 8192;
        /// <summary>
        ///             The maximum size (in UTF-8 bytes, including the null terminator) supported for the game
        ///             server mod dir which is set with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetModDir" class="bb_apilink">ISteamGameServer::SetModDir</a>.
        ///         </summary>
        public const int k_cbMaxGameServerGameDir = 32;
        /// <summary>
        ///             The maximum size (in UTF-8 bytes, including the null terminator) supported for game
        ///             server map names which is set with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetMapName" class="bb_apilink">ISteamGameServer::SetMapName</a>.
        ///         </summary>
        public const int k_cbMaxGameServerMapName = 32;
        /// <summary>
        ///             The maximum size (in UTF-8 bytes, including the null terminator) supported for the game
        ///             server mod description which is set with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameDescription" class="bb_apilink">ISteamGameServer::SetGameDescription</a>.
        ///         </summary>
        public const int k_cbMaxGameServerGameDescription = 64;
        /// <summary>
        ///             The maximum size (in UTF-8 bytes, including the null terminator) supported for game
        ///             server names which is set with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetServerName" class="bb_apilink">ISteamGameServer::SetServerName</a>.
        ///         </summary>
        public const int k_cbMaxGameServerName = 64;
        /// <summary>
        ///             The maximum size (in UTF-8 bytes, including the null terminator) supported for game
        ///             server tags which is set with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameTags" class="bb_apilink">ISteamGameServer::SetGameTags</a>.
        ///         </summary>
        public const int k_cbMaxGameServerTags = 128;
        /// <summary>
        ///             The maximum size (in UTF-8 bytes, including the null terminator) supported for game
        ///             server data which is set with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameData" class="bb_apilink">ISteamGameServer::SetGameData</a>.
        ///         </summary>
        public const int k_cbMaxGameServerGameData = 2048;
        /// <summary></summary>
        public const int HSERVERQUERY_INVALID = unchecked((int)0xffffffff);
        /// <summary>This favorite game server has no flags set.</summary>
        public const uint k_unFavoriteFlagNone = 0x00;
        /// <summary>This favorite game server entry is for the favorites list.</summary>
        public const uint k_unFavoriteFlagFavorite = 0x01;
        /// <summary>This favorite game server entry is for the history list.</summary>
        public const uint k_unFavoriteFlagHistory = 0x02;
        /// <summary>
        ///             Defines the largest allowed file size for the Steam Cloud.<br />
        ///             Cloud files cannot be written in a single chunk over 100MiB and cannot be over 200MiB
        ///             total.
        ///         </summary>
        public const uint k_unMaxCloudFileChunkSize = 100 * 1024 * 1024;
        /// <summary>An invalid Workshop item handle.</summary>
        public static readonly PublishedFileId k_PublishedFileIdInvalid = 0;
        /// <summary>An invalid UGC Handle. This is often returned by functions signifying an error.</summary>
        public static readonly UGCHandle k_UGCHandleInvalid = 0xfffffffffffffffful;
        /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.</summary>
        public static readonly PublishedFileUpdateHandle k_PublishedFileUpdateHandleInvalid = 0xfffffffffffffffful;
        /// <summary>
        ///             Returned when an error has occured when using
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamOpen" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamOpen</a>.
        ///         </summary>
        public static readonly UGCFileWriteStreamHandle k_UGCFileStreamHandleInvalid = 0xfffffffffffffffful;
        /// <summary>The maximum size in bytes that a Workshop item title can be.</summary>
        public const uint k_cchPublishedDocumentTitleMax = 128 + 1;
        /// <summary>The maximum size in bytes that a Workshop item description can be.</summary>
        public const uint k_cchPublishedDocumentDescriptionMax = 8000;
        /// <summary>Unused.</summary>
        public const uint k_cchPublishedDocumentChangeDescriptionMax = 8000;
        /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.</summary>
        public const uint k_unEnumeratePublishedFilesMaxResults = 50;
        /// <summary>The maximum size in bytes that a Workshop item comma separated tag list can be.</summary>
        public const uint k_cchTagListMax = 1024 + 1;
        /// <summary>The maximum length that a Steam Cloud file path can be.</summary>
        public const uint k_cchFilenameMax = 260;
        /// <summary>The maximum size in bytes that a Workshop item URL can be.</summary>
        public const uint k_cchPublishedFileURLMax = 256;
        /// <summary>Only used internally in Steam.</summary>
        public const int k_cubAppProofOfPurchaseKeyMax = 240;
        /// <summary>
        ///             The maximum number of users that can be tagged in a screenshot using
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#TagUser" class="bb_apilink">ISteamScreenshots::TagUser</a>.
        ///         </summary>
        public const uint k_nScreenshotMaxTaggedUsers = 32;
        /// <summary>
        ///             The maximum number of workshop items that can be tagged in a screenshot using
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#TagPublishedFile" class="bb_apilink">ISteamScreenshots::TagPublishedFile</a>.
        ///         </summary>
        public const uint k_nScreenshotMaxTaggedPublishedFiles = 32;
        /// <summary>Unused.</summary>
        public const int k_cubUFSTagTypeMax = 255;
        /// <summary>
        ///             The maximum length in bytes of a location metadata string set on a screenshot using
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#SetLocation" class="bb_apilink">ISteamScreenshots::SetLocation</a>.
        ///         </summary>
        public const int k_cubUFSTagValueMax = 255;
        /// <summary>
        ///             Required width of a thumbnail provided to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddScreenshotToLibrary</a>. If you do not provide a thumbnail then one will be generated automatically.
        ///         </summary>
        public const int k_ScreenshotThumbWidth = 200;
        /// <summary>
        ///             Used to specify an invalid query handle. This is frequently returned if a call fails.
        ///         </summary>
        public static readonly UGCQueryHandle k_UGCQueryHandleInvalid = 0xfffffffffffffffful;
        /// <summary>
        ///             Used to specify an invalid item update handle. This is frequently returned if a call
        ///             fails.
        ///         </summary>
        public static readonly UGCUpdateHandle k_UGCUpdateHandleInvalid = 0xfffffffffffffffful;
        /// <summary>The maximum number of results that you'll receive for a query result.</summary>
        public const uint kNumUGCResultsPerPage = 50;
        /// <summary>
        ///             The maximum amount of bytes you can set with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemMetadata" class="bb_apilink">ISteamUGC::SetItemMetadata</a>.
        ///         </summary>
        public const uint k_cchDeveloperMetadataMax = 5000;
        /// <summary>
        ///             Indicates that a browser handle is invalid. You should initialize your own
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///             handles to this value and then set it back to this when the page closes.
        ///         </summary>
        public const uint INVALID_HTMLBROWSER = 0;
        /// <summary>
        ///             An invalid item instance id. This is usually returned when an operation has failed. It's
        ///             recommended that you initialize all new item instances with this value.
        ///         </summary>
        public static readonly SteamItemInstanceID k_SteamItemInstanceIDInvalid = ~0ul;
        /// <summary>An invalid Steam inventory result handle.</summary>
        public static readonly SteamInventoryResult k_SteamInventoryResultInvalid = -1;
        /// missing documentation for k_SteamInventoryUpdateHandleInvalid
        public static readonly SteamInventoryUpdateHandle k_SteamInventoryUpdateHandleInvalid = 0xfffffffffffffffful;
        /// missing documentation for k_nMaxTimelineRangeIDLength
        public const int k_nMaxTimelineRangeIDLength = 64;
        /// missing documentation for k_HSteamNetConnection_Invalid
        public static readonly HSteamNetConnection k_HSteamNetConnection_Invalid = 0;
        /// missing documentation for k_HSteamListenSocket_Invalid
        public static readonly HSteamListenSocket k_HSteamListenSocket_Invalid = 0;
        /// missing documentation for k_HSteamNetPollGroup_Invalid
        public static readonly HSteamNetPollGroup k_HSteamNetPollGroup_Invalid = 0;
        /// missing documentation for k_cchMaxSteamNetworkingErrMsg
        public const int k_cchMaxSteamNetworkingErrMsg = 1024;
        /// missing documentation for k_cchSteamNetworkingMaxConnectionCloseReason
        public const int k_cchSteamNetworkingMaxConnectionCloseReason = 128;
        /// missing documentation for k_cchSteamNetworkingMaxConnectionDescription
        public const int k_cchSteamNetworkingMaxConnectionDescription = 128;
        /// missing documentation for k_cchSteamNetworkingMaxConnectionAppName
        public const int k_cchSteamNetworkingMaxConnectionAppName = 32;
        /// missing documentation for k_nSteamNetworkConnectionInfoFlags_Unauthenticated
        public const int k_nSteamNetworkConnectionInfoFlags_Unauthenticated = 1;
        /// missing documentation for k_nSteamNetworkConnectionInfoFlags_Unencrypted
        public const int k_nSteamNetworkConnectionInfoFlags_Unencrypted = 2;
        /// missing documentation for k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers
        public const int k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers = 4;
        /// missing documentation for k_nSteamNetworkConnectionInfoFlags_Fast
        public const int k_nSteamNetworkConnectionInfoFlags_Fast = 8;
        /// missing documentation for k_nSteamNetworkConnectionInfoFlags_Relayed
        public const int k_nSteamNetworkConnectionInfoFlags_Relayed = 16;
        /// missing documentation for k_nSteamNetworkConnectionInfoFlags_DualWifi
        public const int k_nSteamNetworkConnectionInfoFlags_DualWifi = 32;
        /// missing documentation for k_cbMaxSteamNetworkingSocketsMessageSizeSend
        public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 512 * 1024;
        /// missing documentation for k_nSteamNetworkingSend_Unreliable
        public const int k_nSteamNetworkingSend_Unreliable = 0;
        /// missing documentation for k_nSteamNetworkingSend_NoNagle
        public const int k_nSteamNetworkingSend_NoNagle = 1;
        /// missing documentation for k_nSteamNetworkingSend_UnreliableNoNagle
        public const int k_nSteamNetworkingSend_UnreliableNoNagle = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoNagle;
        /// missing documentation for k_nSteamNetworkingSend_NoDelay
        public const int k_nSteamNetworkingSend_NoDelay = 4;
        /// missing documentation for k_nSteamNetworkingSend_UnreliableNoDelay
        public const int k_nSteamNetworkingSend_UnreliableNoDelay = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoDelay | k_nSteamNetworkingSend_NoNagle;
        /// missing documentation for k_nSteamNetworkingSend_Reliable
        public const int k_nSteamNetworkingSend_Reliable = 8;
        /// missing documentation for k_nSteamNetworkingSend_ReliableNoNagle
        public const int k_nSteamNetworkingSend_ReliableNoNagle = k_nSteamNetworkingSend_Reliable | k_nSteamNetworkingSend_NoNagle;
        /// missing documentation for k_nSteamNetworkingSend_UseCurrentThread
        public const int k_nSteamNetworkingSend_UseCurrentThread = 16;
        /// missing documentation for k_nSteamNetworkingSend_AutoRestartBrokenSession
        public const int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;
        /// missing documentation for k_cchMaxSteamNetworkingPingLocationString
        public const int k_cchMaxSteamNetworkingPingLocationString = 1024;
        /// missing documentation for k_nSteamNetworkingPing_Failed
        public const int k_nSteamNetworkingPing_Failed = -1;
        /// missing documentation for k_nSteamNetworkingPing_Unknown
        public const int k_nSteamNetworkingPing_Unknown = -2;
        /// missing documentation for k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default = -1;
        /// missing documentation for k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable = 0;
        /// missing documentation for k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay = 1;
        /// missing documentation for k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private = 2;
        /// missing documentation for k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public = 4;
        /// missing documentation for k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All = 0x7fffffff;
        /// missing documentation for k_SteamDatagramPOPID_dev
        public static readonly SteamNetworkingPOPID k_SteamDatagramPOPID_dev = ((uint)'d' << 16) | ((uint)'e' << 8) | (uint)'v';
        /// missing documentation for STEAMGAMESERVER_QUERY_PORT_SHARED
        public const ushort STEAMGAMESERVER_QUERY_PORT_SHARED = 0xffff;
        /// <summary>
        ///             Used with
        ///             <a href="https://partner.steamgames.com/doc/api/steam_gameserver#SteamGameServer_Init" class="bb_apilink">SteamGameServer_Init</a>
        ///             to enable GameSocketShare mode.
        ///         </summary>
        public const ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = STEAMGAMESERVER_QUERY_PORT_SHARED;
        /// missing documentation for k_cbSteamDatagramMaxSerializedTicket
        public const uint k_cbSteamDatagramMaxSerializedTicket = 512;
        /// missing documentation for k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData
        public const uint k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData = 2048;
        /// missing documentation for k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized
        public const uint k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized = 4096;
        /// missing documentation for k_cbSteamNetworkingSocketsFakeUDPPortRecommendedMTU
        public const int k_cbSteamNetworkingSocketsFakeUDPPortRecommendedMTU = 1200;
        /// missing documentation for k_cbSteamNetworkingSocketsFakeUDPPortMaxMessageSize
        public const int k_cbSteamNetworkingSocketsFakeUDPPortMaxMessageSize = 4096;
    }
}