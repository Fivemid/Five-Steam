using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public static class FiveSteamConstants
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
        /// <summary>Used in <a href="#CSteamID" class="bb_apilink">CSteamID</a> to mask out the <a href="#AccountID_t" class="bb_apilink">AccountID_t</a>.</summary>
        public const uint k_unSteamAccountIDMask = 0xFFFFFFFF;
        /// <summary>Used in <a href="#CSteamID" class="bb_apilink">CSteamID</a> to mask out the account instance.</summary>
        public const uint k_unSteamAccountInstanceMask = 0x000FFFFF;
        /// missing documentation for k_unSteamUserDefaultInstance
        public const uint k_unSteamUserDefaultInstance = 1;
        /// <summary>The maximum size (in UTF-8 bytes, including the null terminator) of the <code class="bb_code bb_code_inline nohighlight">pchExtraInfo</code> parameter of <a href="https://partner.steamgames.com/doc/api/ISteamUser#TrackAppUsageEvent" class="bb_apilink">ISteamUser::TrackAppUsageEvent</a>.</summary>
        public const int k_cchGameExtraInfoMax = 64;
        /// missing documentation for k_cchMaxSteamErrMsg
        public const int k_cchMaxSteamErrMsg = 1024;
        /// <summary>The maximum length that a friends group name can be (not including the null-terminator!)</summary>
        public const int k_cchMaxFriendsGroupName = 64;
        /// <summary>Deprecated - Unused.</summary>
        public const int k_cFriendsGroupLimit = 100;
        /// <summary>Invalid friends group identifier.</summary>
        public static readonly FriendsGroupID k_FriendsGroupID_Invalid = -1;
        /// <summary>The maximum number of followers that will be returned in a <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsEnumerateFollowingList_t" class="bb_apilink">FriendsEnumerateFollowingList_t</a> call result at once.</summary>
        public const int k_cEnumerateFollowersMax = 50;
        /// missing documentation for k_usFriendGameInfoQueryPort_NotInitialized
        public const ushort k_usFriendGameInfoQueryPort_NotInitialized = 0xFFFF;
        /// missing documentation for k_usFriendGameInfoQueryPort_Error
        public const ushort k_usFriendGameInfoQueryPort_Error = 0xFFFE;
        /// <summary>Maximum size in bytes that chat room, lobby, or chat/lobby member metadata may have.</summary>
        public const uint k_cubChatMetadataMax = 8192;
        /// <summary>The maximum size (in UTF-8 bytes, including the null terminator) supported for the game server mod dir which is set with <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetModDir" class="bb_apilink">ISteamGameServer::SetModDir</a>.</summary>
        public const int k_cbMaxGameServerGameDir = 32;
        /// <summary>The maximum size (in UTF-8 bytes, including the null terminator) supported for game server map names which is set with <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetMapName" class="bb_apilink">ISteamGameServer::SetMapName</a>.</summary>
        public const int k_cbMaxGameServerMapName = 32;
        /// <summary>The maximum size (in UTF-8 bytes, including the null terminator) supported for the game server mod description which is set with <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameDescription" class="bb_apilink">ISteamGameServer::SetGameDescription</a>.</summary>
        public const int k_cbMaxGameServerGameDescription = 64;
        /// <summary>The maximum size (in UTF-8 bytes, including the null terminator) supported for game server names which is set with <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetServerName" class="bb_apilink">ISteamGameServer::SetServerName</a>.</summary>
        public const int k_cbMaxGameServerName = 64;
        /// <summary>The maximum size (in UTF-8 bytes, including the null terminator) supported for game server tags which is set with <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameTags" class="bb_apilink">ISteamGameServer::SetGameTags</a>.</summary>
        public const int k_cbMaxGameServerTags = 128;
        /// <summary>The maximum size (in UTF-8 bytes, including the null terminator) supported for game server data which is set with <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameData" class="bb_apilink">ISteamGameServer::SetGameData</a>.</summary>
        public const int k_cbMaxGameServerGameData = 2048;
        /// <summary></summary>
        public const int HSERVERQUERY_INVALID = unchecked((int)0xffffffff);
        /// <summary>This favorite game server has no flags set.</summary>
        public const uint k_unFavoriteFlagNone = 0x00;
        /// <summary>This favorite game server entry is for the favorites list.</summary>
        public const uint k_unFavoriteFlagFavorite = 0x01;
        /// <summary>This favorite game server entry is for the history list.</summary>
        public const uint k_unFavoriteFlagHistory = 0x02;
        /// <summary>Defines the largest allowed file size for the Steam Cloud.<br />
        /// Cloud files cannot be written in a single chunk over 100MiB and cannot be over 200MiB total.</summary>
        public const uint k_unMaxCloudFileChunkSize = 100 * 1024 * 1024;
        /// <summary>An invalid Workshop item handle.</summary>
        public static readonly PublishedFileId k_PublishedFileIdInvalid = 0;
        /// <summary>An invalid UGC Handle. This is often returned by functions signifying an error.</summary>
        public static readonly UGCHandle k_UGCHandleInvalid = 0xfffffffffffffffful;
        /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.</summary>
        public static readonly PublishedFileUpdateHandle k_PublishedFileUpdateHandleInvalid = 0xfffffffffffffffful;
        /// <summary>Returned when an error has occured when using <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#FileWriteStreamOpen" class="bb_apilink">ISteamRemoteStorage::FileWriteStreamOpen</a>.</summary>
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
        /// <summary>The maximum number of users that can be tagged in a screenshot using <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#TagUser" class="bb_apilink">ISteamScreenshots::TagUser</a>.</summary>
        public const uint k_nScreenshotMaxTaggedUsers = 32;
        /// <summary>The maximum number of workshop items that can be tagged in a screenshot using <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#TagPublishedFile" class="bb_apilink">ISteamScreenshots::TagPublishedFile</a>.</summary>
        public const uint k_nScreenshotMaxTaggedPublishedFiles = 32;
        /// <summary>Unused.</summary>
        public const int k_cubUFSTagTypeMax = 255;
        /// <summary>The maximum length in bytes of a location metadata string set on a screenshot using <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#SetLocation" class="bb_apilink">ISteamScreenshots::SetLocation</a>.</summary>
        public const int k_cubUFSTagValueMax = 255;
        /// <summary>Required width of a thumbnail provided to <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddScreenshotToLibrary</a>. If you do not provide a thumbnail then one will be generated automatically.</summary>
        public const int k_ScreenshotThumbWidth = 200;
        /// <summary>Used to specify an invalid query handle. This is frequently returned if a call fails.</summary>
        public static readonly UGCQueryHandle k_UGCQueryHandleInvalid = 0xfffffffffffffffful;
        /// <summary>Used to specify an invalid item update handle. This is frequently returned if a call fails.</summary>
        public static readonly UGCUpdateHandle k_UGCUpdateHandleInvalid = 0xfffffffffffffffful;
        /// <summary>The maximum number of results that you'll receive for a query result.</summary>
        public const uint kNumUGCResultsPerPage = 50;
        /// <summary>The maximum amount of bytes you can set with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemMetadata" class="bb_apilink">ISteamUGC::SetItemMetadata</a>.</summary>
        public const uint k_cchDeveloperMetadataMax = 5000;
        /// <summary>Indicates that a browser handle is invalid. You should initialize your own <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a> handles to this value and then set it back to this when the page closes.</summary>
        public const uint INVALID_HTMLBROWSER = 0;
        /// <summary>An invalid item instance id. This is usually returned when an operation has failed. It's recommended that you initialize all new item instances with this value.</summary>
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
        /// <summary><br />
        /// Max size of a single message that we can SEND.<br />
        /// Note: We might be wiling to receive larger messages, and our peer might, too.</summary>
        public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 512 * 1024;
        /// <summary>These values are used in bitmask parameters to functions such as <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SendMessageToConnection" class="bb_apilink">ISteamNetworkingSockets::SendMessageToConnection</a><br />
        /// <br />
        /// 
        /// <br />Unpack integer to string representation, including terminating '\0'.  Your string should be at least 5 bytes large.  (It will fail to compile if this is not the case.)</summary>
        public const int k_nSteamNetworkingSend_Unreliable = 0;
        /// <summary>
        /// <br />
        /// <br />
        /// NOTE: Don't just send every message without Nagle because you want packets to "get there quicker".  Make sure you understand the problem that Nagle is solving before disabling it.  If you are sending small messages, often many at the same time, then it is very likely that it will be more efficient to leave Nagle enabled.  A typical proper use of this flag is when you are sending what you know will be the last message sent for a while (e.g. the last in the server simulation tick to a particular client), and you use this flag to flush all messages.<br />
        /// <br /><a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#FlushMessagesToUser" class="bb_apilink">ISteamNetworkingMessages::FlushMessagesToUser</a>, <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#FlushMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::FlushMessagesOnConnection</a>
        /// By default, Nagle's algorithm is applied to all outbound messages.  This means that the message will NOT be sent immediately, in case further messages are sent soon after you send this, which can be grouped together.  Any time there is enough buffered data to fill a packet, the packets will be pushed out immediately, but partially-full packets not be sent until the Nagle timer expires.  See <br />
        /// <br />.<a href="https://en.wikipedia.org/wiki/Nagle%27s_algorithm" target="_blank" rel="noreferrer">Nagle's algorithm</a>Disable 
        /// <br />
        /// <br />
        /// Migration note: This is not exactly the same as k_EP2PSendUnreliable!  You probably want k_ESteamNetworkingSendType_UnreliableNoNagle<br />
        /// <br />
        /// The sending API does have some knowledge of the underlying connection, so if there is no NAT-traversal accomplished or there is a recognized adjustment happening on the connection, the packet will be batched until the connection is open again.<br />
        /// <br />Send the message unreliably. Can be lost.  Messages *can* be larger than a single MTU (UDP packet), but there is no retransmission, so if any piece of the message is lost, the entire message will be dropped.
        /// </summary>
        public const int k_nSteamNetworkingSend_NoNagle = 1;
        /// <summary>
        /// <br />
        /// <br />.  (But using this flag is more efficient since you only make one API call.)<a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#FlushMessagesToUser" class="bb_apilink">ISteamNetworkingMessages::FlushMessagesToUser</a> or <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#FlushMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::FlushMessagesOnConnection</a>Send a message unreliably, bypassing Nagle's algorithm for this message and any messages currently pending on the Nagle timer.  This is equivalent to using steamnetworkingtypes::k_ESteamNetworkingSend_Unreliable and then immediately flushing the messages using 
        /// <br />
        /// <br />
        /// NOTE: Don't just send every message without Nagle because you want packets to "get there quicker".  Make sure you understand the problem that Nagle is solving before disabling it.  If you are sending small messages, often many at the same time, then it is very likely that it will be more efficient to leave Nagle enabled.  A typical proper use of this flag is when you are sending what you know will be the last message sent for a while (e.g. the last in the server simulation tick to a particular client), and you use this flag to flush all messages.<br />
        /// <br /><a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#FlushMessagesToUser" class="bb_apilink">ISteamNetworkingMessages::FlushMessagesToUser</a>, <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#FlushMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::FlushMessagesOnConnection</a>
        /// By default, Nagle's algorithm is applied to all outbound messages.  This means that the message will NOT be sent immediately, in case further messages are sent soon after you send this, which can be grouped together.  Any time there is enough buffered data to fill a packet, the packets will be pushed out immediately, but partially-full packets not be sent until the Nagle timer expires.  See <br />
        /// <br />.<a href="https://en.wikipedia.org/wiki/Nagle%27s_algorithm" target="_blank" rel="noreferrer">Nagle's algorithm</a>Disable </summary>
        public const int k_nSteamNetworkingSend_UnreliableNoNagle = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoNagle;
        /// <summary>
        /// <br />
        /// <br />
        /// <br />If the message cannot be sent very soon (because the connection is still doing some initial handshaking, route negotiations, etc), then just drop it.  This is only applicable for unreliable messages.  Using this flag on reliable messages is invalid.
        /// <br />
        /// <br />.  (But using this flag is more efficient since you only make one API call.)<a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#FlushMessagesToUser" class="bb_apilink">ISteamNetworkingMessages::FlushMessagesToUser</a> or <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#FlushMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::FlushMessagesOnConnection</a>Send a message unreliably, bypassing Nagle's algorithm for this message and any messages currently pending on the Nagle timer.  This is equivalent to using steamnetworkingtypes::k_ESteamNetworkingSend_Unreliable and then immediately flushing the messages using </summary>
        public const int k_nSteamNetworkingSend_NoDelay = 4;
        /// <summary>
        /// <br />
        /// <br />
        /// NOTE: The Nagle algorithm is not used, and if the message is not dropped, any messages waiting on the Nagle timer are immediately flushed.<br />
        /// <br />
        /// If a message is dropped for these reasons, k_EResultIgnored will be returned.<br /><ul class="bb_ul "><li>the connection is not fully connected.  (E.g. the "Connecting" or "FindingRoute" states)<br />
        /// </li><li>there is a sufficiently large number of messages queued up already such that the current messagewill not be placed on the wire in the next ~200ms or so.</li></ul>
        /// <br />
        /// A message will be dropped under the following circumstances:<br />
        /// <br />Send an unreliable message, but if it cannot be sent relatively quickly, just drop it instead of queuing it.  This is useful for messages that are not useful if they are excessively delayed, such as voice data.
        /// <br />
        /// <br />
        /// <br />If the message cannot be sent very soon (because the connection is still doing some initial handshaking, route negotiations, etc), then just drop it.  This is only applicable for unreliable messages.  Using this flag on reliable messages is invalid.</summary>
        public const int k_nSteamNetworkingSend_UnreliableNoDelay = k_nSteamNetworkingSend_Unreliable | k_nSteamNetworkingSend_NoDelay | k_nSteamNetworkingSend_NoNagle;
        /// <summary>
        /// <br />
        /// <br />
        /// Migration note: This is NOT the same as k_EP2PSendReliable, it's more like k_EP2PSendReliableWithBuffering<br />
        /// <br /><a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#FlushMessagesToUser" class="bb_apilink">ISteamNetworkingMessages::FlushMessagesToUser</a>, <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#FlushMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::FlushMessagesOnConnection</a>
        /// The Nagle algorithm is used.  See notes on k_ESteamNetworkingSendType_Unreliable for more details.  See k_ESteamNetworkingSendType_ReliableNoNagle, <br />
        /// <br />Reliable message send. Can send up to k_cbMaxSteamNetworkingSocketsMessageSizeSend bytes in a single message.  Does fragmentation/re-assembly of messages under the hood, as well as a sliding window for efficient sends of large chunks of data.
        /// <br />
        /// <br />
        /// NOTE: The Nagle algorithm is not used, and if the message is not dropped, any messages waiting on the Nagle timer are immediately flushed.<br />
        /// <br />
        /// If a message is dropped for these reasons, k_EResultIgnored will be returned.<br /><ul class="bb_ul "><li>the connection is not fully connected.  (E.g. the "Connecting" or "FindingRoute" states)<br />
        /// </li><li>there is a sufficiently large number of messages queued up already such that the current messagewill not be placed on the wire in the next ~200ms or so.</li></ul>
        /// <br />
        /// A message will be dropped under the following circumstances:<br />
        /// <br />Send an unreliable message, but if it cannot be sent relatively quickly, just drop it instead of queuing it.  This is useful for messages that are not useful if they are excessively delayed, such as voice data.</summary>
        public const int k_nSteamNetworkingSend_Reliable = 8;
        /// <summary>
        /// Migration note: This is equivalent to k_EP2PSendReliable<br />
        /// <br />Send a message reliably, but bypass Nagle's algorithm.
        /// <br />
        /// <br />
        /// Migration note: This is NOT the same as k_EP2PSendReliable, it's more like k_EP2PSendReliableWithBuffering<br />
        /// <br /><a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#FlushMessagesToUser" class="bb_apilink">ISteamNetworkingMessages::FlushMessagesToUser</a>, <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#FlushMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::FlushMessagesOnConnection</a>
        /// The Nagle algorithm is used.  See notes on k_ESteamNetworkingSendType_Unreliable for more details.  See k_ESteamNetworkingSendType_ReliableNoNagle, <br />
        /// <br />Reliable message send. Can send up to k_cbMaxSteamNetworkingSocketsMessageSizeSend bytes in a single message.  Does fragmentation/re-assembly of messages under the hood, as well as a sliding window for efficient sends of large chunks of data.</summary>
        public const int k_nSteamNetworkingSend_ReliableNoNagle = k_nSteamNetworkingSend_Reliable | k_nSteamNetworkingSend_NoNagle;
        /// missing documentation for k_nSteamNetworkingSend_UseCurrentThread
        public const int k_nSteamNetworkingSend_UseCurrentThread = 16;
        /// missing documentation for k_nSteamNetworkingSend_AutoRestartBrokenSession
        public const int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;
        /// <summary>Max possible length of a ping location, in string format.  This is an extremely conservative worst case value which leaves room for future syntax enhancements.  Most strings in practice are a lot shorter. If you are storing many of these, you will very likely benefit from using dynamic memory.
        /// <br /></summary>
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
        /// <summary>Used with <a href="https://partner.steamgames.com/doc/api/steam_gameserver#SteamGameServer_Init" class="bb_apilink">SteamGameServer_Init</a> to enable GameSocketShare mode.</summary>
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