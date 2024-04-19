using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public struct FiveSteamConstants
    {
        /// <summary>k_uAppIdInvalid</summary>
        public static readonly AppId k_uAppIdInvalid = 0x0;
        /// <summary>k_uDepotIdInvalid</summary>
        public static readonly DepotId k_uDepotIdInvalid = 0x0;
        /// <summary>k_uAPICallInvalid</summary>
        public static readonly SteamAPICall k_uAPICallInvalid = 0x0;
        /// <summary>k_uAccountIdInvalid</summary>
        public static readonly AccountID k_uAccountIdInvalid = 0;
        /// <summary>k_ulPartyBeaconIdInvalid</summary>
        public static readonly PartyBeaconID k_ulPartyBeaconIdInvalid = 0;
        /// <summary>k_HAuthTicketInvalid</summary>
        public static readonly HAuthTicket k_HAuthTicketInvalid = 0;
        /// <summary>k_unSteamAccountIDMask</summary>
        public const uint k_unSteamAccountIDMask = 0xFFFFFFFF;
        /// <summary>k_unSteamAccountInstanceMask</summary>
        public const uint k_unSteamAccountInstanceMask = 0x000FFFFF;
        /// <summary>k_unSteamUserDefaultInstance</summary>
        public const uint k_unSteamUserDefaultInstance = 1;
        /// <summary>k_cchGameExtraInfoMax</summary>
        public const int k_cchGameExtraInfoMax = 64;
        /// <summary>k_cchMaxSteamErrMsg</summary>
        public const int k_cchMaxSteamErrMsg = 1024;
        /// <summary>k_cchMaxFriendsGroupName</summary>
        public const int k_cchMaxFriendsGroupName = 64;
        /// <summary>k_cFriendsGroupLimit</summary>
        public const int k_cFriendsGroupLimit = 100;
        /// <summary>k_FriendsGroupID_Invalid</summary>
        public static readonly FriendsGroupID k_FriendsGroupID_Invalid = -1;
        /// <summary>k_cEnumerateFollowersMax</summary>
        public const int k_cEnumerateFollowersMax = 50;
        /// <summary>k_usFriendGameInfoQueryPort_NotInitialized</summary>
        public const ushort k_usFriendGameInfoQueryPort_NotInitialized = 0xFFFF;
        /// <summary>k_usFriendGameInfoQueryPort_Error</summary>
        public const ushort k_usFriendGameInfoQueryPort_Error = 0xFFFE;
        /// <summary>k_cubChatMetadataMax</summary>
        public const uint k_cubChatMetadataMax = 8192;
        /// <summary>k_cbMaxGameServerGameDir</summary>
        public const int k_cbMaxGameServerGameDir = 32;
        /// <summary>k_cbMaxGameServerMapName</summary>
        public const int k_cbMaxGameServerMapName = 32;
        /// <summary>k_cbMaxGameServerGameDescription</summary>
        public const int k_cbMaxGameServerGameDescription = 64;
        /// <summary>k_cbMaxGameServerName</summary>
        public const int k_cbMaxGameServerName = 64;
        /// <summary>k_cbMaxGameServerTags</summary>
        public const int k_cbMaxGameServerTags = 128;
        /// <summary>k_cbMaxGameServerGameData</summary>
        public const int k_cbMaxGameServerGameData = 2048;
        /// <summary>HSERVERQUERY_INVALID</summary>
        public const int HSERVERQUERY_INVALID = unchecked((int)0xffffffff);
        /// <summary>k_unFavoriteFlagNone</summary>
        public const uint k_unFavoriteFlagNone = 0x00;
        /// <summary>k_unFavoriteFlagFavorite</summary>
        public const uint k_unFavoriteFlagFavorite = 0x01;
        /// <summary>k_unFavoriteFlagHistory</summary>
        public const uint k_unFavoriteFlagHistory = 0x02;
        /// <summary>k_unMaxCloudFileChunkSize</summary>
        public const uint k_unMaxCloudFileChunkSize = 100 * 1024 * 1024;
        /// <summary>k_PublishedFileIdInvalid</summary>
        public static readonly PublishedFileId k_PublishedFileIdInvalid = 0;
        /// <summary>k_UGCHandleInvalid</summary>
        public static readonly UGCHandle k_UGCHandleInvalid = 0xfffffffffffffffful;
        /// <summary>k_PublishedFileUpdateHandleInvalid</summary>
        public static readonly PublishedFileUpdateHandle k_PublishedFileUpdateHandleInvalid = 0xfffffffffffffffful;
        /// <summary>k_UGCFileStreamHandleInvalid</summary>
        public static readonly UGCFileWriteStreamHandle k_UGCFileStreamHandleInvalid = 0xfffffffffffffffful;
        /// <summary>k_cchPublishedDocumentTitleMax</summary>
        public const uint k_cchPublishedDocumentTitleMax = 128 + 1;
        /// <summary>k_cchPublishedDocumentDescriptionMax</summary>
        public const uint k_cchPublishedDocumentDescriptionMax = 8000;
        /// <summary>k_cchPublishedDocumentChangeDescriptionMax</summary>
        public const uint k_cchPublishedDocumentChangeDescriptionMax = 8000;
        /// <summary>k_unEnumeratePublishedFilesMaxResults</summary>
        public const uint k_unEnumeratePublishedFilesMaxResults = 50;
        /// <summary>k_cchTagListMax</summary>
        public const uint k_cchTagListMax = 1024 + 1;
        /// <summary>k_cchFilenameMax</summary>
        public const uint k_cchFilenameMax = 260;
        /// <summary>k_cchPublishedFileURLMax</summary>
        public const uint k_cchPublishedFileURLMax = 256;
        /// <summary>k_cubAppProofOfPurchaseKeyMax</summary>
        public const int k_cubAppProofOfPurchaseKeyMax = 240;
        /// <summary>k_nScreenshotMaxTaggedUsers</summary>
        public const uint k_nScreenshotMaxTaggedUsers = 32;
        /// <summary>k_nScreenshotMaxTaggedPublishedFiles</summary>
        public const uint k_nScreenshotMaxTaggedPublishedFiles = 32;
        /// <summary>k_cubUFSTagTypeMax</summary>
        public const int k_cubUFSTagTypeMax = 255;
        /// <summary>k_cubUFSTagValueMax</summary>
        public const int k_cubUFSTagValueMax = 255;
        /// <summary>k_ScreenshotThumbWidth</summary>
        public const int k_ScreenshotThumbWidth = 200;
        /// <summary>k_UGCQueryHandleInvalid</summary>
        public static readonly UGCQueryHandle k_UGCQueryHandleInvalid = 0xfffffffffffffffful;
        /// <summary>k_UGCUpdateHandleInvalid</summary>
        public static readonly UGCUpdateHandle k_UGCUpdateHandleInvalid = 0xfffffffffffffffful;
        /// <summary>kNumUGCResultsPerPage</summary>
        public const uint kNumUGCResultsPerPage = 50;
        /// <summary>k_cchDeveloperMetadataMax</summary>
        public const uint k_cchDeveloperMetadataMax = 5000;
        /// <summary>INVALID_HTMLBROWSER</summary>
        public const uint INVALID_HTMLBROWSER = 0;
        /// <summary>k_SteamItemInstanceIDInvalid</summary>
        public static readonly SteamItemInstanceID k_SteamItemInstanceIDInvalid = ~0ul;
        /// <summary>k_SteamInventoryResultInvalid</summary>
        public static readonly SteamInventoryResult k_SteamInventoryResultInvalid = -1;
        /// <summary>k_SteamInventoryUpdateHandleInvalid</summary>
        public static readonly SteamInventoryUpdateHandle k_SteamInventoryUpdateHandleInvalid = 0xfffffffffffffffful;
        /// <summary>k_nMaxTimelineRangeIDLength</summary>
        public const int k_nMaxTimelineRangeIDLength = 64;
        /// <summary>k_HSteamNetConnection_Invalid</summary>
        public static readonly HSteamNetConnection k_HSteamNetConnection_Invalid = 0;
        /// <summary>k_HSteamListenSocket_Invalid</summary>
        public static readonly HSteamListenSocket k_HSteamListenSocket_Invalid = 0;
        /// <summary>k_HSteamNetPollGroup_Invalid</summary>
        public static readonly HSteamNetPollGroup k_HSteamNetPollGroup_Invalid = 0;
        /// <summary>k_cchMaxSteamNetworkingErrMsg</summary>
        public const int k_cchMaxSteamNetworkingErrMsg = 1024;
        /// <summary>k_cchSteamNetworkingMaxConnectionCloseReason</summary>
        public const int k_cchSteamNetworkingMaxConnectionCloseReason = 128;
        /// <summary>k_cchSteamNetworkingMaxConnectionDescription</summary>
        public const int k_cchSteamNetworkingMaxConnectionDescription = 128;
        /// <summary>k_cchSteamNetworkingMaxConnectionAppName</summary>
        public const int k_cchSteamNetworkingMaxConnectionAppName = 32;
        /// <summary>k_nSteamNetworkConnectionInfoFlags_Unauthenticated</summary>
        public const int k_nSteamNetworkConnectionInfoFlags_Unauthenticated = 1;
        /// <summary>k_nSteamNetworkConnectionInfoFlags_Unencrypted</summary>
        public const int k_nSteamNetworkConnectionInfoFlags_Unencrypted = 2;
        /// <summary>k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers</summary>
        public const int k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers = 4;
        /// <summary>k_nSteamNetworkConnectionInfoFlags_Fast</summary>
        public const int k_nSteamNetworkConnectionInfoFlags_Fast = 8;
        /// <summary>k_nSteamNetworkConnectionInfoFlags_Relayed</summary>
        public const int k_nSteamNetworkConnectionInfoFlags_Relayed = 16;
        /// <summary>k_nSteamNetworkConnectionInfoFlags_DualWifi</summary>
        public const int k_nSteamNetworkConnectionInfoFlags_DualWifi = 32;
        /// <summary>k_cbMaxSteamNetworkingSocketsMessageSizeSend</summary>
        public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 512 * 1024;
        /// <summary>k_nSteamNetworkingSend_Unreliable</summary>
        public const int k_nSteamNetworkingSend_Unreliable = 0;
        /// <summary>k_nSteamNetworkingSend_NoNagle</summary>
        public const int k_nSteamNetworkingSend_NoNagle = 1;
        /// <summary>k_nSteamNetworkingSend_UnreliableNoNagle</summary>
        public const int k_nSteamNetworkingSend_UnreliableNoNagle = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoNagle;
        /// <summary>k_nSteamNetworkingSend_NoDelay</summary>
        public const int k_nSteamNetworkingSend_NoDelay = 4;
        /// <summary>k_nSteamNetworkingSend_UnreliableNoDelay</summary>
        public const int k_nSteamNetworkingSend_UnreliableNoDelay = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoDelay | k_nSteamNetworkingSend_NoNagle;
        /// <summary>k_nSteamNetworkingSend_Reliable</summary>
        public const int k_nSteamNetworkingSend_Reliable = 8;
        /// <summary>k_nSteamNetworkingSend_ReliableNoNagle</summary>
        public const int k_nSteamNetworkingSend_ReliableNoNagle = k_nSteamNetworkingSend_Reliable | k_nSteamNetworkingSend_NoNagle;
        /// <summary>k_nSteamNetworkingSend_UseCurrentThread</summary>
        public const int k_nSteamNetworkingSend_UseCurrentThread = 16;
        /// <summary>k_nSteamNetworkingSend_AutoRestartBrokenSession</summary>
        public const int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;
        /// <summary>k_cchMaxSteamNetworkingPingLocationString</summary>
        public const int k_cchMaxSteamNetworkingPingLocationString = 1024;
        /// <summary>k_nSteamNetworkingPing_Failed</summary>
        public const int k_nSteamNetworkingPing_Failed = -1;
        /// <summary>k_nSteamNetworkingPing_Unknown</summary>
        public const int k_nSteamNetworkingPing_Unknown = -2;
        /// <summary>k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default</summary>
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default = -1;
        /// <summary>k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable</summary>
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable = 0;
        /// <summary>k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay</summary>
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay = 1;
        /// <summary>k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private</summary>
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private = 2;
        /// <summary>k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public</summary>
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public = 4;
        /// <summary>k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All</summary>
        public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All = 0x7fffffff;
        /// <summary>k_SteamDatagramPOPID_dev</summary>
        public static readonly SteamNetworkingPOPID k_SteamDatagramPOPID_dev = ((uint)'d' << 16) | ((uint)'e' << 8) | (uint)'v';
        /// <summary>STEAMGAMESERVER_QUERY_PORT_SHARED</summary>
        public const ushort STEAMGAMESERVER_QUERY_PORT_SHARED = 0xffff;
        /// <summary>MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE</summary>
        public const ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = STEAMGAMESERVER_QUERY_PORT_SHARED;
        /// <summary>k_cbSteamDatagramMaxSerializedTicket</summary>
        public const uint k_cbSteamDatagramMaxSerializedTicket = 512;
        /// <summary>k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData</summary>
        public const uint k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData = 2048;
        /// <summary>k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized</summary>
        public const uint k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized = 4096;
        /// <summary>k_cbSteamNetworkingSocketsFakeUDPPortRecommendedMTU</summary>
        public const int k_cbSteamNetworkingSocketsFakeUDPPortRecommendedMTU = 1200;
        /// <summary>k_cbSteamNetworkingSocketsFakeUDPPortMaxMessageSize</summary>
        public const int k_cbSteamNetworkingSocketsFakeUDPPortMaxMessageSize = 4096;
    }
}