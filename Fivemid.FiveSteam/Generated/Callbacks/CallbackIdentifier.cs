using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public enum CallbackIdentifier : int
    {
        /// <summary>SteamServersConnected_t</summary>
        SteamServersConnected = 101,
        /// <summary>SteamServerConnectFailure_t</summary>
        SteamServerConnectFailure = 102,
        /// <summary>SteamServersDisconnected_t</summary>
        SteamServersDisconnected = 103,
        /// <summary>ClientGameServerDeny_t</summary>
        ClientGameServerDeny = 113,
        /// <summary>IPCFailure_t</summary>
        IPCFailure = 117,
        /// <summary>LicensesUpdated_t</summary>
        LicensesUpdated = 125,
        /// <summary>ValidateAuthTicketResponse_t</summary>
        ValidateAuthTicketResponse = 143,
        /// <summary>MicroTxnAuthorizationResponse_t</summary>
        MicroTxnAuthorizationResponse = 152,
        /// <summary>EncryptedAppTicketResponse_t</summary>
        EncryptedAppTicketResponse = 154,
        /// <summary>GetAuthSessionTicketResponse_t</summary>
        GetAuthSessionTicketResponse = 163,
        /// <summary>GameWebCallback_t</summary>
        GameWebCallback = 164,
        /// <summary>StoreAuthURLResponse_t</summary>
        StoreAuthURLResponse = 165,
        /// <summary>MarketEligibilityResponse_t</summary>
        MarketEligibilityResponse = 166,
        /// <summary>DurationControl_t</summary>
        DurationControl = 167,
        /// <summary>GetTicketForWebApiResponse_t</summary>
        GetTicketForWebApiResponse = 168,
        /// <summary>PersonaStateChange_t</summary>
        PersonaStateChange = 304,
        /// <summary>GameOverlayActivated_t</summary>
        GameOverlayActivated = 331,
        /// <summary>GameServerChangeRequested_t</summary>
        GameServerChangeRequested = 332,
        /// <summary>GameLobbyJoinRequested_t</summary>
        GameLobbyJoinRequested = 333,
        /// <summary>AvatarImageLoaded_t</summary>
        AvatarImageLoaded = 334,
        /// <summary>ClanOfficerListResponse_t</summary>
        ClanOfficerListResponse = 335,
        /// <summary>FriendRichPresenceUpdate_t</summary>
        FriendRichPresenceUpdate = 336,
        /// <summary>GameRichPresenceJoinRequested_t</summary>
        GameRichPresenceJoinRequested = 337,
        /// <summary>GameConnectedClanChatMsg_t</summary>
        GameConnectedClanChatMsg = 338,
        /// <summary>GameConnectedChatJoin_t</summary>
        GameConnectedChatJoin = 339,
        /// <summary>GameConnectedChatLeave_t</summary>
        GameConnectedChatLeave = 340,
        /// <summary>DownloadClanActivityCountsResult_t</summary>
        DownloadClanActivityCountsResult = 341,
        /// <summary>JoinClanChatRoomCompletionResult_t</summary>
        JoinClanChatRoomCompletionResult = 342,
        /// <summary>GameConnectedFriendChatMsg_t</summary>
        GameConnectedFriendChatMsg = 343,
        /// <summary>FriendsGetFollowerCount_t</summary>
        FriendsGetFollowerCount = 344,
        /// <summary>FriendsIsFollowing_t</summary>
        FriendsIsFollowing = 345,
        /// <summary>FriendsEnumerateFollowingList_t</summary>
        FriendsEnumerateFollowingList = 346,
        /// <summary>SetPersonaNameResponse_t</summary>
        SetPersonaNameResponse = 347,
        /// <summary>UnreadChatMessagesChanged_t</summary>
        UnreadChatMessagesChanged = 348,
        /// <summary>OverlayBrowserProtocolNavigation_t</summary>
        OverlayBrowserProtocolNavigation = 349,
        /// <summary>EquippedProfileItemsChanged_t</summary>
        EquippedProfileItemsChanged = 350,
        /// <summary>EquippedProfileItems_t</summary>
        EquippedProfileItems = 351,
        /// <summary>IPCountry_t</summary>
        IPCountry = 701,
        /// <summary>LowBatteryPower_t</summary>
        LowBatteryPower = 702,
        /// <summary>SteamAPICallCompleted_t</summary>
        SteamAPICallCompleted = 703,
        /// <summary>SteamShutdown_t</summary>
        SteamShutdown = 704,
        /// <summary>CheckFileSignature_t</summary>
        CheckFileSignature = 705,
        /// <summary>GamepadTextInputDismissed_t</summary>
        GamepadTextInputDismissed = 714,
        /// <summary>AppResumingFromSuspend_t</summary>
        AppResumingFromSuspend = 736,
        /// <summary>FloatingGamepadTextInputDismissed_t</summary>
        FloatingGamepadTextInputDismissed = 738,
        /// <summary>FilterTextDictionaryChanged_t</summary>
        FilterTextDictionaryChanged = 739,
        /// <summary>FavoritesListChanged_t</summary>
        FavoritesListChanged = 502,
        /// <summary>LobbyInvite_t</summary>
        LobbyInvite = 503,
        /// <summary>LobbyEnter_t</summary>
        LobbyEnter = 504,
        /// <summary>LobbyDataUpdate_t</summary>
        LobbyDataUpdate = 505,
        /// <summary>LobbyChatUpdate_t</summary>
        LobbyChatUpdate = 506,
        /// <summary>LobbyChatMsg_t</summary>
        LobbyChatMsg = 507,
        /// <summary>LobbyGameCreated_t</summary>
        LobbyGameCreated = 509,
        /// <summary>LobbyMatchList_t</summary>
        LobbyMatchList = 510,
        /// <summary>LobbyKicked_t</summary>
        LobbyKicked = 512,
        /// <summary>LobbyCreated_t</summary>
        LobbyCreated = 513,
        /// <summary>PSNGameBootInviteResult_t</summary>
        PSNGameBootInviteResult = 515,
        /// <summary>FavoritesListAccountsUpdated_t</summary>
        FavoritesListAccountsUpdated = 516,
        /// <summary>SearchForGameProgressCallback_t</summary>
        SearchForGameProgressCallback = 5201,
        /// <summary>SearchForGameResultCallback_t</summary>
        SearchForGameResultCallback = 5202,
        /// <summary>RequestPlayersForGameProgressCallback_t</summary>
        RequestPlayersForGameProgressCallback = 5211,
        /// <summary>RequestPlayersForGameResultCallback_t</summary>
        RequestPlayersForGameResultCallback = 5212,
        /// <summary>RequestPlayersForGameFinalResultCallback_t</summary>
        RequestPlayersForGameFinalResultCallback = 5213,
        /// <summary>SubmitPlayerResultResultCallback_t</summary>
        SubmitPlayerResultResultCallback = 5214,
        /// <summary>EndGameResultCallback_t</summary>
        EndGameResultCallback = 5215,
        /// <summary>JoinPartyCallback_t</summary>
        JoinPartyCallback = 5301,
        /// <summary>CreateBeaconCallback_t</summary>
        CreateBeaconCallback = 5302,
        /// <summary>ReservationNotificationCallback_t</summary>
        ReservationNotificationCallback = 5303,
        /// <summary>ChangeNumOpenSlotsCallback_t</summary>
        ChangeNumOpenSlotsCallback = 5304,
        /// <summary>AvailableBeaconLocationsUpdated_t</summary>
        AvailableBeaconLocationsUpdated = 5305,
        /// <summary>ActiveBeaconsUpdated_t</summary>
        ActiveBeaconsUpdated = 5306,
        /// <summary>RemoteStorageFileShareResult_t</summary>
        RemoteStorageFileShareResult = 1307,
        /// <summary>RemoteStoragePublishFileResult_t</summary>
        RemoteStoragePublishFileResult = 1309,
        /// <summary>RemoteStorageDeletePublishedFileResult_t</summary>
        RemoteStorageDeletePublishedFileResult = 1311,
        /// <summary>RemoteStorageEnumerateUserPublishedFilesResult_t</summary>
        RemoteStorageEnumerateUserPublishedFilesResult = 1312,
        /// <summary>RemoteStorageSubscribePublishedFileResult_t</summary>
        RemoteStorageSubscribePublishedFileResult = 1313,
        /// <summary>RemoteStorageEnumerateUserSubscribedFilesResult_t</summary>
        RemoteStorageEnumerateUserSubscribedFilesResult = 1314,
        /// <summary>RemoteStorageUnsubscribePublishedFileResult_t</summary>
        RemoteStorageUnsubscribePublishedFileResult = 1315,
        /// <summary>RemoteStorageUpdatePublishedFileResult_t</summary>
        RemoteStorageUpdatePublishedFileResult = 1316,
        /// <summary>RemoteStorageDownloadUGCResult_t</summary>
        RemoteStorageDownloadUGCResult = 1317,
        /// <summary>RemoteStorageGetPublishedFileDetailsResult_t</summary>
        RemoteStorageGetPublishedFileDetailsResult = 1318,
        /// <summary>RemoteStorageEnumerateWorkshopFilesResult_t</summary>
        RemoteStorageEnumerateWorkshopFilesResult = 1319,
        /// <summary>RemoteStorageGetPublishedItemVoteDetailsResult_t</summary>
        RemoteStorageGetPublishedItemVoteDetailsResult = 1320,
        /// <summary>RemoteStoragePublishedFileSubscribed_t</summary>
        RemoteStoragePublishedFileSubscribed = 1321,
        /// <summary>RemoteStoragePublishedFileUnsubscribed_t</summary>
        RemoteStoragePublishedFileUnsubscribed = 1322,
        /// <summary>RemoteStoragePublishedFileDeleted_t</summary>
        RemoteStoragePublishedFileDeleted = 1323,
        /// <summary>RemoteStorageUpdateUserPublishedItemVoteResult_t</summary>
        RemoteStorageUpdateUserPublishedItemVoteResult = 1324,
        /// <summary>RemoteStorageUserVoteDetails_t</summary>
        RemoteStorageUserVoteDetails = 1325,
        /// <summary>RemoteStorageEnumerateUserSharedWorkshopFilesResult_t</summary>
        RemoteStorageEnumerateUserSharedWorkshopFilesResult = 1326,
        /// <summary>RemoteStorageSetUserPublishedFileActionResult_t</summary>
        RemoteStorageSetUserPublishedFileActionResult = 1327,
        /// <summary>RemoteStorageEnumeratePublishedFilesByUserActionResult_t</summary>
        RemoteStorageEnumeratePublishedFilesByUserActionResult = 1328,
        /// <summary>RemoteStoragePublishFileProgress_t</summary>
        RemoteStoragePublishFileProgress = 1329,
        /// <summary>RemoteStoragePublishedFileUpdated_t</summary>
        RemoteStoragePublishedFileUpdated = 1330,
        /// <summary>RemoteStorageFileWriteAsyncComplete_t</summary>
        RemoteStorageFileWriteAsyncComplete = 1331,
        /// <summary>RemoteStorageFileReadAsyncComplete_t</summary>
        RemoteStorageFileReadAsyncComplete = 1332,
        /// <summary>RemoteStorageLocalFileChange_t</summary>
        RemoteStorageLocalFileChange = 1333,
        /// <summary>UserStatsReceived_t</summary>
        UserStatsReceived = 1101,
        /// <summary>UserStatsStored_t</summary>
        UserStatsStored = 1102,
        /// <summary>UserAchievementStored_t</summary>
        UserAchievementStored = 1103,
        /// <summary>LeaderboardFindResult_t</summary>
        LeaderboardFindResult = 1104,
        /// <summary>LeaderboardScoresDownloaded_t</summary>
        LeaderboardScoresDownloaded = 1105,
        /// <summary>LeaderboardScoreUploaded_t</summary>
        LeaderboardScoreUploaded = 1106,
        /// <summary>NumberOfCurrentPlayers_t</summary>
        NumberOfCurrentPlayers = 1107,
        /// <summary>UserStatsUnloaded_t</summary>
        UserStatsUnloaded = 1108,
        /// <summary>UserAchievementIconFetched_t</summary>
        UserAchievementIconFetched = 1109,
        /// <summary>GlobalAchievementPercentagesReady_t</summary>
        GlobalAchievementPercentagesReady = 1110,
        /// <summary>LeaderboardUGCSet_t</summary>
        LeaderboardUGCSet = 1111,
        /// <summary>PS3TrophiesInstalled_t</summary>
        PS3TrophiesInstalled = 1112,
        /// <summary>GlobalStatsReceived_t</summary>
        GlobalStatsReceived = 1112,
        /// <summary>DlcInstalled_t</summary>
        DlcInstalled = 1005,
        /// <summary>NewUrlLaunchParameters_t</summary>
        NewUrlLaunchParameters = 1014,
        /// <summary>AppProofOfPurchaseKeyResponse_t</summary>
        AppProofOfPurchaseKeyResponse = 1021,
        /// <summary>FileDetailsResult_t</summary>
        FileDetailsResult = 1023,
        /// <summary>TimedTrialStatus_t</summary>
        TimedTrialStatus = 1030,
        /// <summary>P2PSessionRequest_t</summary>
        P2PSessionRequest = 1202,
        /// <summary>P2PSessionConnectFail_t</summary>
        P2PSessionConnectFail = 1203,
        /// <summary>SocketStatusCallback_t</summary>
        SocketStatusCallback = 1201,
        /// <summary>ScreenshotReady_t</summary>
        ScreenshotReady = 2301,
        /// <summary>ScreenshotRequested_t</summary>
        ScreenshotRequested = 2302,
        /// <summary>PlaybackStatusHasChanged_t</summary>
        PlaybackStatusHasChanged = 4001,
        /// <summary>VolumeHasChanged_t</summary>
        VolumeHasChanged = 4002,
        /// <summary>MusicPlayerRemoteWillActivate_t</summary>
        MusicPlayerRemoteWillActivate = 4101,
        /// <summary>MusicPlayerRemoteWillDeactivate_t</summary>
        MusicPlayerRemoteWillDeactivate = 4102,
        /// <summary>MusicPlayerRemoteToFront_t</summary>
        MusicPlayerRemoteToFront = 4103,
        /// <summary>MusicPlayerWillQuit_t</summary>
        MusicPlayerWillQuit = 4104,
        /// <summary>MusicPlayerWantsPlay_t</summary>
        MusicPlayerWantsPlay = 4105,
        /// <summary>MusicPlayerWantsPause_t</summary>
        MusicPlayerWantsPause = 4106,
        /// <summary>MusicPlayerWantsPlayPrevious_t</summary>
        MusicPlayerWantsPlayPrevious = 4107,
        /// <summary>MusicPlayerWantsPlayNext_t</summary>
        MusicPlayerWantsPlayNext = 4108,
        /// <summary>MusicPlayerWantsShuffled_t</summary>
        MusicPlayerWantsShuffled = 4109,
        /// <summary>MusicPlayerWantsLooped_t</summary>
        MusicPlayerWantsLooped = 4110,
        /// <summary>MusicPlayerWantsVolume_t</summary>
        MusicPlayerWantsVolume = 4011,
        /// <summary>MusicPlayerSelectsQueueEntry_t</summary>
        MusicPlayerSelectsQueueEntry = 4012,
        /// <summary>MusicPlayerSelectsPlaylistEntry_t</summary>
        MusicPlayerSelectsPlaylistEntry = 4013,
        /// <summary>MusicPlayerWantsPlayingRepeatStatus_t</summary>
        MusicPlayerWantsPlayingRepeatStatus = 4114,
        /// <summary>HTTPRequestCompleted_t</summary>
        HTTPRequestCompleted = 2101,
        /// <summary>HTTPRequestHeadersReceived_t</summary>
        HTTPRequestHeadersReceived = 2102,
        /// <summary>HTTPRequestDataReceived_t</summary>
        HTTPRequestDataReceived = 2103,
        /// <summary>SteamInputDeviceConnected_t</summary>
        SteamInputDeviceConnected = 2801,
        /// <summary>SteamInputDeviceDisconnected_t</summary>
        SteamInputDeviceDisconnected = 2802,
        /// <summary>SteamInputConfigurationLoaded_t</summary>
        SteamInputConfigurationLoaded = 2803,
        /// <summary>SteamInputGamepadSlotChange_t</summary>
        SteamInputGamepadSlotChange = 2804,
        /// <summary>SteamUGCQueryCompleted_t</summary>
        SteamUGCQueryCompleted = 3401,
        /// <summary>SteamUGCRequestUGCDetailsResult_t</summary>
        SteamUGCRequestUGCDetailsResult = 3402,
        /// <summary>CreateItemResult_t</summary>
        CreateItemResult = 3403,
        /// <summary>SubmitItemUpdateResult_t</summary>
        SubmitItemUpdateResult = 3404,
        /// <summary>ItemInstalled_t</summary>
        ItemInstalled = 3405,
        /// <summary>DownloadItemResult_t</summary>
        DownloadItemResult = 3406,
        /// <summary>UserFavoriteItemsListChanged_t</summary>
        UserFavoriteItemsListChanged = 3407,
        /// <summary>SetUserItemVoteResult_t</summary>
        SetUserItemVoteResult = 3408,
        /// <summary>GetUserItemVoteResult_t</summary>
        GetUserItemVoteResult = 3409,
        /// <summary>StartPlaytimeTrackingResult_t</summary>
        StartPlaytimeTrackingResult = 3410,
        /// <summary>StopPlaytimeTrackingResult_t</summary>
        StopPlaytimeTrackingResult = 3411,
        /// <summary>AddUGCDependencyResult_t</summary>
        AddUGCDependencyResult = 3412,
        /// <summary>RemoveUGCDependencyResult_t</summary>
        RemoveUGCDependencyResult = 3413,
        /// <summary>AddAppDependencyResult_t</summary>
        AddAppDependencyResult = 3414,
        /// <summary>RemoveAppDependencyResult_t</summary>
        RemoveAppDependencyResult = 3415,
        /// <summary>GetAppDependenciesResult_t</summary>
        GetAppDependenciesResult = 3416,
        /// <summary>DeleteItemResult_t</summary>
        DeleteItemResult = 3417,
        /// <summary>UserSubscribedItemsListChanged_t</summary>
        UserSubscribedItemsListChanged = 3418,
        /// <summary>WorkshopEULAStatus_t</summary>
        WorkshopEULAStatus = 3420,
        /// <summary>HTML_BrowserReady_t</summary>
        HTML_BrowserReady = 4501,
        /// <summary>HTML_NeedsPaint_t</summary>
        HTML_NeedsPaint = 4502,
        /// <summary>HTML_StartRequest_t</summary>
        HTML_StartRequest = 4503,
        /// <summary>HTML_CloseBrowser_t</summary>
        HTML_CloseBrowser = 4504,
        /// <summary>HTML_URLChanged_t</summary>
        HTML_URLChanged = 4505,
        /// <summary>HTML_FinishedRequest_t</summary>
        HTML_FinishedRequest = 4506,
        /// <summary>HTML_OpenLinkInNewTab_t</summary>
        HTML_OpenLinkInNewTab = 4507,
        /// <summary>HTML_ChangedTitle_t</summary>
        HTML_ChangedTitle = 4508,
        /// <summary>HTML_SearchResults_t</summary>
        HTML_SearchResults = 4509,
        /// <summary>HTML_CanGoBackAndForward_t</summary>
        HTML_CanGoBackAndForward = 4510,
        /// <summary>HTML_HorizontalScroll_t</summary>
        HTML_HorizontalScroll = 4511,
        /// <summary>HTML_VerticalScroll_t</summary>
        HTML_VerticalScroll = 4512,
        /// <summary>HTML_LinkAtPosition_t</summary>
        HTML_LinkAtPosition = 4513,
        /// <summary>HTML_JSAlert_t</summary>
        HTML_JSAlert = 4514,
        /// <summary>HTML_JSConfirm_t</summary>
        HTML_JSConfirm = 4515,
        /// <summary>HTML_FileOpenDialog_t</summary>
        HTML_FileOpenDialog = 4516,
        /// <summary>HTML_NewWindow_t</summary>
        HTML_NewWindow = 4521,
        /// <summary>HTML_SetCursor_t</summary>
        HTML_SetCursor = 4522,
        /// <summary>HTML_StatusText_t</summary>
        HTML_StatusText = 4523,
        /// <summary>HTML_ShowToolTip_t</summary>
        HTML_ShowToolTip = 4524,
        /// <summary>HTML_UpdateToolTip_t</summary>
        HTML_UpdateToolTip = 4525,
        /// <summary>HTML_HideToolTip_t</summary>
        HTML_HideToolTip = 4526,
        /// <summary>HTML_BrowserRestarted_t</summary>
        HTML_BrowserRestarted = 4527,
        /// <summary>SteamInventoryResultReady_t</summary>
        SteamInventoryResultReady = 4700,
        /// <summary>SteamInventoryFullUpdate_t</summary>
        SteamInventoryFullUpdate = 4701,
        /// <summary>SteamInventoryDefinitionUpdate_t</summary>
        SteamInventoryDefinitionUpdate = 4702,
        /// <summary>SteamInventoryEligiblePromoItemDefIDs_t</summary>
        SteamInventoryEligiblePromoItemDefIDs = 4703,
        /// <summary>SteamInventoryStartPurchaseResult_t</summary>
        SteamInventoryStartPurchaseResult = 4704,
        /// <summary>SteamInventoryRequestPricesResult_t</summary>
        SteamInventoryRequestPricesResult = 4705,
        /// <summary>GetVideoURLResult_t</summary>
        GetVideoURLResult = 4611,
        /// <summary>GetOPFSettingsResult_t</summary>
        GetOPFSettingsResult = 4624,
        /// <summary>SteamParentalSettingsChanged_t</summary>
        SteamParentalSettingsChanged = 5001,
        /// <summary>SteamRemotePlaySessionConnected_t</summary>
        SteamRemotePlaySessionConnected = 5701,
        /// <summary>SteamRemotePlaySessionDisconnected_t</summary>
        SteamRemotePlaySessionDisconnected = 5702,
        /// <summary>SteamRemotePlayTogetherGuestInvite_t</summary>
        SteamRemotePlayTogetherGuestInvite = 5703,
        /// <summary>SteamNetworkingMessagesSessionRequest_t</summary>
        SteamNetworkingMessagesSessionRequest = 1251,
        /// <summary>SteamNetworkingMessagesSessionFailed_t</summary>
        SteamNetworkingMessagesSessionFailed = 1252,
        /// <summary>SteamNetConnectionStatusChangedCallback_t</summary>
        SteamNetConnectionStatusChangedCallback = 1221,
        /// <summary>SteamNetAuthenticationStatus_t</summary>
        SteamNetAuthenticationStatus = 1222,
        /// <summary>SteamRelayNetworkStatus_t</summary>
        SteamRelayNetworkStatus = 1281,
        /// <summary>GSClientApprove_t</summary>
        GSClientApprove = 201,
        /// <summary>GSClientDeny_t</summary>
        GSClientDeny = 202,
        /// <summary>GSClientKick_t</summary>
        GSClientKick = 203,
        /// <summary>GSClientAchievementStatus_t</summary>
        GSClientAchievementStatus = 206,
        /// <summary>GSPolicyResponse_t</summary>
        GSPolicyResponse = 115,
        /// <summary>GSGameplayStats_t</summary>
        GSGameplayStats = 207,
        /// <summary>GSClientGroupStatus_t</summary>
        GSClientGroupStatus = 208,
        /// <summary>GSReputation_t</summary>
        GSReputation = 209,
        /// <summary>AssociateWithClanResult_t</summary>
        AssociateWithClanResult = 210,
        /// <summary>ComputeNewPlayerCompatibilityResult_t</summary>
        ComputeNewPlayerCompatibilityResult = 211,
        /// <summary>GSStatsReceived_t</summary>
        GSStatsReceived = 1800,
        /// <summary>GSStatsStored_t</summary>
        GSStatsStored = 1801,
        /// <summary>GSStatsUnloaded_t</summary>
        GSStatsUnloaded = 1108,
        /// <summary>SteamNetworkingFakeIPResult_t</summary>
        SteamNetworkingFakeIPResult = 1223
    }
}