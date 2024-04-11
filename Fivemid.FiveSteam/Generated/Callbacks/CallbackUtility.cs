using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public static unsafe class CallbackUtility
    {
        public static void ToEntity(CallbackIdentifier id, void* data, ref global::Unity.Entities.EntityCommandBuffer ecb)
        {
            var entity = ecb.CreateEntity();
            ecb.AddComponent<FiveSteamCallback>(entity);
            switch (id)
            {
                case CallbackIdentifier.SteamServersConnected:
                    ecb.AddComponent(entity, *(SteamServersConnected*)data);
                    break;
                case CallbackIdentifier.SteamServerConnectFailure:
                    ecb.AddComponent(entity, *(SteamServerConnectFailure*)data);
                    break;
                case CallbackIdentifier.SteamServersDisconnected:
                    ecb.AddComponent(entity, *(SteamServersDisconnected*)data);
                    break;
                case CallbackIdentifier.ClientGameServerDeny:
                    ecb.AddComponent(entity, *(ClientGameServerDeny*)data);
                    break;
                case CallbackIdentifier.IPCFailure:
                    ecb.AddComponent(entity, *(IPCFailure*)data);
                    break;
                case CallbackIdentifier.LicensesUpdated:
                    ecb.AddComponent(entity, *(LicensesUpdated*)data);
                    break;
                case CallbackIdentifier.ValidateAuthTicketResponse:
                    ecb.AddComponent(entity, *(ValidateAuthTicketResponse*)data);
                    break;
                case CallbackIdentifier.MicroTxnAuthorizationResponse:
                    ecb.AddComponent(entity, *(MicroTxnAuthorizationResponse*)data);
                    break;
                case CallbackIdentifier.EncryptedAppTicketResponse:
                    ecb.AddComponent(entity, *(EncryptedAppTicketResponse*)data);
                    break;
                case CallbackIdentifier.GetAuthSessionTicketResponse:
                    ecb.AddComponent(entity, *(GetAuthSessionTicketResponse*)data);
                    break;
                case CallbackIdentifier.GameWebCallback:
                    ecb.AddComponent(entity, *(GameWebCallback*)data);
                    break;
                case CallbackIdentifier.StoreAuthURLResponse:
                    ecb.AddComponent(entity, *(StoreAuthURLResponse*)data);
                    break;
                case CallbackIdentifier.MarketEligibilityResponse:
                    ecb.AddComponent(entity, *(MarketEligibilityResponse*)data);
                    break;
                case CallbackIdentifier.DurationControl:
                    ecb.AddComponent(entity, *(DurationControl*)data);
                    break;
                case CallbackIdentifier.GetTicketForWebApiResponse:
                    ecb.AddComponent(entity, *(GetTicketForWebApiResponse*)data);
                    break;
                case CallbackIdentifier.PersonaStateChange:
                    ecb.AddComponent(entity, *(PersonaStateChange*)data);
                    break;
                case CallbackIdentifier.GameOverlayActivated:
                    ecb.AddComponent(entity, *(GameOverlayActivated*)data);
                    break;
                case CallbackIdentifier.GameServerChangeRequested:
                    ecb.AddComponent(entity, *(GameServerChangeRequested*)data);
                    break;
                case CallbackIdentifier.GameLobbyJoinRequested:
                    ecb.AddComponent(entity, *(GameLobbyJoinRequested*)data);
                    break;
                case CallbackIdentifier.AvatarImageLoaded:
                    ecb.AddComponent(entity, *(AvatarImageLoaded*)data);
                    break;
                case CallbackIdentifier.ClanOfficerListResponse:
                    ecb.AddComponent(entity, *(ClanOfficerListResponse*)data);
                    break;
                case CallbackIdentifier.FriendRichPresenceUpdate:
                    ecb.AddComponent(entity, *(FriendRichPresenceUpdate*)data);
                    break;
                case CallbackIdentifier.GameRichPresenceJoinRequested:
                    ecb.AddComponent(entity, *(GameRichPresenceJoinRequested*)data);
                    break;
                case CallbackIdentifier.GameConnectedClanChatMsg:
                    ecb.AddComponent(entity, *(GameConnectedClanChatMsg*)data);
                    break;
                case CallbackIdentifier.GameConnectedChatJoin:
                    ecb.AddComponent(entity, *(GameConnectedChatJoin*)data);
                    break;
                case CallbackIdentifier.GameConnectedChatLeave:
                    ecb.AddComponent(entity, *(GameConnectedChatLeave*)data);
                    break;
                case CallbackIdentifier.DownloadClanActivityCountsResult:
                    ecb.AddComponent(entity, *(DownloadClanActivityCountsResult*)data);
                    break;
                case CallbackIdentifier.JoinClanChatRoomCompletionResult:
                    ecb.AddComponent(entity, *(JoinClanChatRoomCompletionResult*)data);
                    break;
                case CallbackIdentifier.GameConnectedFriendChatMsg:
                    ecb.AddComponent(entity, *(GameConnectedFriendChatMsg*)data);
                    break;
                case CallbackIdentifier.FriendsGetFollowerCount:
                    ecb.AddComponent(entity, *(FriendsGetFollowerCount*)data);
                    break;
                case CallbackIdentifier.FriendsIsFollowing:
                    ecb.AddComponent(entity, *(FriendsIsFollowing*)data);
                    break;
                case CallbackIdentifier.FriendsEnumerateFollowingList:
                    ecb.AddComponent(entity, *(FriendsEnumerateFollowingList*)data);
                    break;
                case CallbackIdentifier.SetPersonaNameResponse:
                    ecb.AddComponent(entity, *(SetPersonaNameResponse*)data);
                    break;
                case CallbackIdentifier.UnreadChatMessagesChanged:
                    ecb.AddComponent(entity, *(UnreadChatMessagesChanged*)data);
                    break;
                case CallbackIdentifier.OverlayBrowserProtocolNavigation:
                    ecb.AddComponent(entity, *(OverlayBrowserProtocolNavigation*)data);
                    break;
                case CallbackIdentifier.EquippedProfileItemsChanged:
                    ecb.AddComponent(entity, *(EquippedProfileItemsChanged*)data);
                    break;
                case CallbackIdentifier.EquippedProfileItems:
                    ecb.AddComponent(entity, *(EquippedProfileItems*)data);
                    break;
                case CallbackIdentifier.IPCountry:
                    ecb.AddComponent(entity, *(IPCountry*)data);
                    break;
                case CallbackIdentifier.LowBatteryPower:
                    ecb.AddComponent(entity, *(LowBatteryPower*)data);
                    break;
                case CallbackIdentifier.SteamAPICallCompleted:
                    ecb.AddComponent(entity, *(SteamAPICallCompleted*)data);
                    break;
                case CallbackIdentifier.SteamShutdown:
                    ecb.AddComponent(entity, *(SteamShutdown*)data);
                    break;
                case CallbackIdentifier.CheckFileSignature:
                    ecb.AddComponent(entity, *(CheckFileSignature*)data);
                    break;
                case CallbackIdentifier.GamepadTextInputDismissed:
                    ecb.AddComponent(entity, *(GamepadTextInputDismissed*)data);
                    break;
                case CallbackIdentifier.AppResumingFromSuspend:
                    ecb.AddComponent(entity, *(AppResumingFromSuspend*)data);
                    break;
                case CallbackIdentifier.FloatingGamepadTextInputDismissed:
                    ecb.AddComponent(entity, *(FloatingGamepadTextInputDismissed*)data);
                    break;
                case CallbackIdentifier.FilterTextDictionaryChanged:
                    ecb.AddComponent(entity, *(FilterTextDictionaryChanged*)data);
                    break;
                case CallbackIdentifier.FavoritesListChanged:
                    ecb.AddComponent(entity, *(FavoritesListChanged*)data);
                    break;
                case CallbackIdentifier.LobbyInvite:
                    ecb.AddComponent(entity, *(LobbyInvite*)data);
                    break;
                case CallbackIdentifier.LobbyEnter:
                    ecb.AddComponent(entity, *(LobbyEnter*)data);
                    break;
                case CallbackIdentifier.LobbyDataUpdate:
                    ecb.AddComponent(entity, *(LobbyDataUpdate*)data);
                    break;
                case CallbackIdentifier.LobbyChatUpdate:
                    ecb.AddComponent(entity, *(LobbyChatUpdate*)data);
                    break;
                case CallbackIdentifier.LobbyChatMsg:
                    ecb.AddComponent(entity, *(LobbyChatMsg*)data);
                    break;
                case CallbackIdentifier.LobbyGameCreated:
                    ecb.AddComponent(entity, *(LobbyGameCreated*)data);
                    break;
                case CallbackIdentifier.LobbyMatchList:
                    ecb.AddComponent(entity, *(LobbyMatchList*)data);
                    break;
                case CallbackIdentifier.LobbyKicked:
                    ecb.AddComponent(entity, *(LobbyKicked*)data);
                    break;
                case CallbackIdentifier.LobbyCreated:
                    ecb.AddComponent(entity, *(LobbyCreated*)data);
                    break;
                case CallbackIdentifier.PSNGameBootInviteResult:
                    ecb.AddComponent(entity, *(PSNGameBootInviteResult*)data);
                    break;
                case CallbackIdentifier.FavoritesListAccountsUpdated:
                    ecb.AddComponent(entity, *(FavoritesListAccountsUpdated*)data);
                    break;
                case CallbackIdentifier.SearchForGameProgressCallback:
                    ecb.AddComponent(entity, *(SearchForGameProgressCallback*)data);
                    break;
                case CallbackIdentifier.SearchForGameResultCallback:
                    ecb.AddComponent(entity, *(SearchForGameResultCallback*)data);
                    break;
                case CallbackIdentifier.RequestPlayersForGameProgressCallback:
                    ecb.AddComponent(entity, *(RequestPlayersForGameProgressCallback*)data);
                    break;
                case CallbackIdentifier.RequestPlayersForGameResultCallback:
                    ecb.AddComponent(entity, *(RequestPlayersForGameResultCallback*)data);
                    break;
                case CallbackIdentifier.RequestPlayersForGameFinalResultCallback:
                    ecb.AddComponent(entity, *(RequestPlayersForGameFinalResultCallback*)data);
                    break;
                case CallbackIdentifier.SubmitPlayerResultResultCallback:
                    ecb.AddComponent(entity, *(SubmitPlayerResultResultCallback*)data);
                    break;
                case CallbackIdentifier.EndGameResultCallback:
                    ecb.AddComponent(entity, *(EndGameResultCallback*)data);
                    break;
                case CallbackIdentifier.JoinPartyCallback:
                    ecb.AddComponent(entity, *(JoinPartyCallback*)data);
                    break;
                case CallbackIdentifier.CreateBeaconCallback:
                    ecb.AddComponent(entity, *(CreateBeaconCallback*)data);
                    break;
                case CallbackIdentifier.ReservationNotificationCallback:
                    ecb.AddComponent(entity, *(ReservationNotificationCallback*)data);
                    break;
                case CallbackIdentifier.ChangeNumOpenSlotsCallback:
                    ecb.AddComponent(entity, *(ChangeNumOpenSlotsCallback*)data);
                    break;
                case CallbackIdentifier.AvailableBeaconLocationsUpdated:
                    ecb.AddComponent(entity, *(AvailableBeaconLocationsUpdated*)data);
                    break;
                case CallbackIdentifier.ActiveBeaconsUpdated:
                    ecb.AddComponent(entity, *(ActiveBeaconsUpdated*)data);
                    break;
                case CallbackIdentifier.RemoteStorageFileShareResult:
                    ecb.AddComponent(entity, *(RemoteStorageFileShareResult*)data);
                    break;
                case CallbackIdentifier.RemoteStoragePublishFileResult:
                    ecb.AddComponent(entity, *(RemoteStoragePublishFileResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageDeletePublishedFileResult:
                    ecb.AddComponent(entity, *(RemoteStorageDeletePublishedFileResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageEnumerateUserPublishedFilesResult:
                    ecb.AddComponent(entity, *(RemoteStorageEnumerateUserPublishedFilesResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageSubscribePublishedFileResult:
                    ecb.AddComponent(entity, *(RemoteStorageSubscribePublishedFileResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageEnumerateUserSubscribedFilesResult:
                    ecb.AddComponent(entity, *(RemoteStorageEnumerateUserSubscribedFilesResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageUnsubscribePublishedFileResult:
                    ecb.AddComponent(entity, *(RemoteStorageUnsubscribePublishedFileResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageUpdatePublishedFileResult:
                    ecb.AddComponent(entity, *(RemoteStorageUpdatePublishedFileResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageDownloadUGCResult:
                    ecb.AddComponent(entity, *(RemoteStorageDownloadUGCResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageGetPublishedFileDetailsResult:
                    ecb.AddComponent(entity, *(RemoteStorageGetPublishedFileDetailsResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageEnumerateWorkshopFilesResult:
                    ecb.AddComponent(entity, *(RemoteStorageEnumerateWorkshopFilesResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageGetPublishedItemVoteDetailsResult:
                    ecb.AddComponent(entity, *(RemoteStorageGetPublishedItemVoteDetailsResult*)data);
                    break;
                case CallbackIdentifier.RemoteStoragePublishedFileSubscribed:
                    ecb.AddComponent(entity, *(RemoteStoragePublishedFileSubscribed*)data);
                    break;
                case CallbackIdentifier.RemoteStoragePublishedFileUnsubscribed:
                    ecb.AddComponent(entity, *(RemoteStoragePublishedFileUnsubscribed*)data);
                    break;
                case CallbackIdentifier.RemoteStoragePublishedFileDeleted:
                    ecb.AddComponent(entity, *(RemoteStoragePublishedFileDeleted*)data);
                    break;
                case CallbackIdentifier.RemoteStorageUpdateUserPublishedItemVoteResult:
                    ecb.AddComponent(entity, *(RemoteStorageUpdateUserPublishedItemVoteResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageUserVoteDetails:
                    ecb.AddComponent(entity, *(RemoteStorageUserVoteDetails*)data);
                    break;
                case CallbackIdentifier.RemoteStorageEnumerateUserSharedWorkshopFilesResult:
                    ecb.AddComponent(entity, *(RemoteStorageEnumerateUserSharedWorkshopFilesResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageSetUserPublishedFileActionResult:
                    ecb.AddComponent(entity, *(RemoteStorageSetUserPublishedFileActionResult*)data);
                    break;
                case CallbackIdentifier.RemoteStorageEnumeratePublishedFilesByUserActionResult:
                    ecb.AddComponent(entity, *(RemoteStorageEnumeratePublishedFilesByUserActionResult*)data);
                    break;
                case CallbackIdentifier.RemoteStoragePublishFileProgress:
                    ecb.AddComponent(entity, *(RemoteStoragePublishFileProgress*)data);
                    break;
                case CallbackIdentifier.RemoteStoragePublishedFileUpdated:
                    ecb.AddComponent(entity, *(RemoteStoragePublishedFileUpdated*)data);
                    break;
                case CallbackIdentifier.RemoteStorageFileWriteAsyncComplete:
                    ecb.AddComponent(entity, *(RemoteStorageFileWriteAsyncComplete*)data);
                    break;
                case CallbackIdentifier.RemoteStorageFileReadAsyncComplete:
                    ecb.AddComponent(entity, *(RemoteStorageFileReadAsyncComplete*)data);
                    break;
                case CallbackIdentifier.RemoteStorageLocalFileChange:
                    ecb.AddComponent(entity, *(RemoteStorageLocalFileChange*)data);
                    break;
                case CallbackIdentifier.UserStatsReceived:
                    ecb.AddComponent(entity, *(UserStatsReceived*)data);
                    break;
                case CallbackIdentifier.UserStatsStored:
                    ecb.AddComponent(entity, *(UserStatsStored*)data);
                    break;
                case CallbackIdentifier.UserAchievementStored:
                    ecb.AddComponent(entity, *(UserAchievementStored*)data);
                    break;
                case CallbackIdentifier.LeaderboardFindResult:
                    ecb.AddComponent(entity, *(LeaderboardFindResult*)data);
                    break;
                case CallbackIdentifier.LeaderboardScoresDownloaded:
                    ecb.AddComponent(entity, *(LeaderboardScoresDownloaded*)data);
                    break;
                case CallbackIdentifier.LeaderboardScoreUploaded:
                    ecb.AddComponent(entity, *(LeaderboardScoreUploaded*)data);
                    break;
                case CallbackIdentifier.NumberOfCurrentPlayers:
                    ecb.AddComponent(entity, *(NumberOfCurrentPlayers*)data);
                    break;
                case CallbackIdentifier.UserStatsUnloaded:
                    ecb.AddComponent(entity, *(UserStatsUnloaded*)data);
                    ecb.AddComponent(entity, *(GSStatsUnloaded*)data);
                    break;
                case CallbackIdentifier.UserAchievementIconFetched:
                    ecb.AddComponent(entity, *(UserAchievementIconFetched*)data);
                    break;
                case CallbackIdentifier.GlobalAchievementPercentagesReady:
                    ecb.AddComponent(entity, *(GlobalAchievementPercentagesReady*)data);
                    break;
                case CallbackIdentifier.LeaderboardUGCSet:
                    ecb.AddComponent(entity, *(LeaderboardUGCSet*)data);
                    break;
                case CallbackIdentifier.PS3TrophiesInstalled:
                    ecb.AddComponent(entity, *(PS3TrophiesInstalled*)data);
                    ecb.AddComponent(entity, *(GlobalStatsReceived*)data);
                    break;
                case CallbackIdentifier.DlcInstalled:
                    ecb.AddComponent(entity, *(DlcInstalled*)data);
                    break;
                case CallbackIdentifier.NewUrlLaunchParameters:
                    ecb.AddComponent(entity, *(NewUrlLaunchParameters*)data);
                    break;
                case CallbackIdentifier.AppProofOfPurchaseKeyResponse:
                    ecb.AddComponent(entity, *(AppProofOfPurchaseKeyResponse*)data);
                    break;
                case CallbackIdentifier.FileDetailsResult:
                    ecb.AddComponent(entity, *(FileDetailsResult*)data);
                    break;
                case CallbackIdentifier.TimedTrialStatus:
                    ecb.AddComponent(entity, *(TimedTrialStatus*)data);
                    break;
                case CallbackIdentifier.P2PSessionRequest:
                    ecb.AddComponent(entity, *(P2PSessionRequest*)data);
                    break;
                case CallbackIdentifier.P2PSessionConnectFail:
                    ecb.AddComponent(entity, *(P2PSessionConnectFail*)data);
                    break;
                case CallbackIdentifier.SocketStatusCallback:
                    ecb.AddComponent(entity, *(SocketStatusCallback*)data);
                    break;
                case CallbackIdentifier.ScreenshotReady:
                    ecb.AddComponent(entity, *(ScreenshotReady*)data);
                    break;
                case CallbackIdentifier.ScreenshotRequested:
                    ecb.AddComponent(entity, *(ScreenshotRequested*)data);
                    break;
                case CallbackIdentifier.PlaybackStatusHasChanged:
                    ecb.AddComponent(entity, *(PlaybackStatusHasChanged*)data);
                    break;
                case CallbackIdentifier.VolumeHasChanged:
                    ecb.AddComponent(entity, *(VolumeHasChanged*)data);
                    break;
                case CallbackIdentifier.MusicPlayerRemoteWillActivate:
                    ecb.AddComponent(entity, *(MusicPlayerRemoteWillActivate*)data);
                    break;
                case CallbackIdentifier.MusicPlayerRemoteWillDeactivate:
                    ecb.AddComponent(entity, *(MusicPlayerRemoteWillDeactivate*)data);
                    break;
                case CallbackIdentifier.MusicPlayerRemoteToFront:
                    ecb.AddComponent(entity, *(MusicPlayerRemoteToFront*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWillQuit:
                    ecb.AddComponent(entity, *(MusicPlayerWillQuit*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsPlay:
                    ecb.AddComponent(entity, *(MusicPlayerWantsPlay*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsPause:
                    ecb.AddComponent(entity, *(MusicPlayerWantsPause*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsPlayPrevious:
                    ecb.AddComponent(entity, *(MusicPlayerWantsPlayPrevious*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsPlayNext:
                    ecb.AddComponent(entity, *(MusicPlayerWantsPlayNext*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsShuffled:
                    ecb.AddComponent(entity, *(MusicPlayerWantsShuffled*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsLooped:
                    ecb.AddComponent(entity, *(MusicPlayerWantsLooped*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsVolume:
                    ecb.AddComponent(entity, *(MusicPlayerWantsVolume*)data);
                    break;
                case CallbackIdentifier.MusicPlayerSelectsQueueEntry:
                    ecb.AddComponent(entity, *(MusicPlayerSelectsQueueEntry*)data);
                    break;
                case CallbackIdentifier.MusicPlayerSelectsPlaylistEntry:
                    ecb.AddComponent(entity, *(MusicPlayerSelectsPlaylistEntry*)data);
                    break;
                case CallbackIdentifier.MusicPlayerWantsPlayingRepeatStatus:
                    ecb.AddComponent(entity, *(MusicPlayerWantsPlayingRepeatStatus*)data);
                    break;
                case CallbackIdentifier.HTTPRequestCompleted:
                    ecb.AddComponent(entity, *(HTTPRequestCompleted*)data);
                    break;
                case CallbackIdentifier.HTTPRequestHeadersReceived:
                    ecb.AddComponent(entity, *(HTTPRequestHeadersReceived*)data);
                    break;
                case CallbackIdentifier.HTTPRequestDataReceived:
                    ecb.AddComponent(entity, *(HTTPRequestDataReceived*)data);
                    break;
                case CallbackIdentifier.SteamInputDeviceConnected:
                    ecb.AddComponent(entity, *(SteamInputDeviceConnected*)data);
                    break;
                case CallbackIdentifier.SteamInputDeviceDisconnected:
                    ecb.AddComponent(entity, *(SteamInputDeviceDisconnected*)data);
                    break;
                case CallbackIdentifier.SteamInputConfigurationLoaded:
                    ecb.AddComponent(entity, *(SteamInputConfigurationLoaded*)data);
                    break;
                case CallbackIdentifier.SteamInputGamepadSlotChange:
                    ecb.AddComponent(entity, *(SteamInputGamepadSlotChange*)data);
                    break;
                case CallbackIdentifier.SteamUGCQueryCompleted:
                    ecb.AddComponent(entity, *(SteamUGCQueryCompleted*)data);
                    break;
                case CallbackIdentifier.SteamUGCRequestUGCDetailsResult:
                    ecb.AddComponent(entity, *(SteamUGCRequestUGCDetailsResult*)data);
                    break;
                case CallbackIdentifier.CreateItemResult:
                    ecb.AddComponent(entity, *(CreateItemResult*)data);
                    break;
                case CallbackIdentifier.SubmitItemUpdateResult:
                    ecb.AddComponent(entity, *(SubmitItemUpdateResult*)data);
                    break;
                case CallbackIdentifier.ItemInstalled:
                    ecb.AddComponent(entity, *(ItemInstalled*)data);
                    break;
                case CallbackIdentifier.DownloadItemResult:
                    ecb.AddComponent(entity, *(DownloadItemResult*)data);
                    break;
                case CallbackIdentifier.UserFavoriteItemsListChanged:
                    ecb.AddComponent(entity, *(UserFavoriteItemsListChanged*)data);
                    break;
                case CallbackIdentifier.SetUserItemVoteResult:
                    ecb.AddComponent(entity, *(SetUserItemVoteResult*)data);
                    break;
                case CallbackIdentifier.GetUserItemVoteResult:
                    ecb.AddComponent(entity, *(GetUserItemVoteResult*)data);
                    break;
                case CallbackIdentifier.StartPlaytimeTrackingResult:
                    ecb.AddComponent(entity, *(StartPlaytimeTrackingResult*)data);
                    break;
                case CallbackIdentifier.StopPlaytimeTrackingResult:
                    ecb.AddComponent(entity, *(StopPlaytimeTrackingResult*)data);
                    break;
                case CallbackIdentifier.AddUGCDependencyResult:
                    ecb.AddComponent(entity, *(AddUGCDependencyResult*)data);
                    break;
                case CallbackIdentifier.RemoveUGCDependencyResult:
                    ecb.AddComponent(entity, *(RemoveUGCDependencyResult*)data);
                    break;
                case CallbackIdentifier.AddAppDependencyResult:
                    ecb.AddComponent(entity, *(AddAppDependencyResult*)data);
                    break;
                case CallbackIdentifier.RemoveAppDependencyResult:
                    ecb.AddComponent(entity, *(RemoveAppDependencyResult*)data);
                    break;
                case CallbackIdentifier.GetAppDependenciesResult:
                    ecb.AddComponent(entity, *(GetAppDependenciesResult*)data);
                    break;
                case CallbackIdentifier.DeleteItemResult:
                    ecb.AddComponent(entity, *(DeleteItemResult*)data);
                    break;
                case CallbackIdentifier.UserSubscribedItemsListChanged:
                    ecb.AddComponent(entity, *(UserSubscribedItemsListChanged*)data);
                    break;
                case CallbackIdentifier.WorkshopEULAStatus:
                    ecb.AddComponent(entity, *(WorkshopEULAStatus*)data);
                    break;
                case CallbackIdentifier.HTML_BrowserReady:
                    ecb.AddComponent(entity, *(HTML_BrowserReady*)data);
                    break;
                case CallbackIdentifier.HTML_NeedsPaint:
                    ecb.AddComponent(entity, *(HTML_NeedsPaint*)data);
                    break;
                case CallbackIdentifier.HTML_StartRequest:
                    ecb.AddComponent(entity, *(HTML_StartRequest*)data);
                    break;
                case CallbackIdentifier.HTML_CloseBrowser:
                    ecb.AddComponent(entity, *(HTML_CloseBrowser*)data);
                    break;
                case CallbackIdentifier.HTML_URLChanged:
                    ecb.AddComponent(entity, *(HTML_URLChanged*)data);
                    break;
                case CallbackIdentifier.HTML_FinishedRequest:
                    ecb.AddComponent(entity, *(HTML_FinishedRequest*)data);
                    break;
                case CallbackIdentifier.HTML_OpenLinkInNewTab:
                    ecb.AddComponent(entity, *(HTML_OpenLinkInNewTab*)data);
                    break;
                case CallbackIdentifier.HTML_ChangedTitle:
                    ecb.AddComponent(entity, *(HTML_ChangedTitle*)data);
                    break;
                case CallbackIdentifier.HTML_SearchResults:
                    ecb.AddComponent(entity, *(HTML_SearchResults*)data);
                    break;
                case CallbackIdentifier.HTML_CanGoBackAndForward:
                    ecb.AddComponent(entity, *(HTML_CanGoBackAndForward*)data);
                    break;
                case CallbackIdentifier.HTML_HorizontalScroll:
                    ecb.AddComponent(entity, *(HTML_HorizontalScroll*)data);
                    break;
                case CallbackIdentifier.HTML_VerticalScroll:
                    ecb.AddComponent(entity, *(HTML_VerticalScroll*)data);
                    break;
                case CallbackIdentifier.HTML_LinkAtPosition:
                    ecb.AddComponent(entity, *(HTML_LinkAtPosition*)data);
                    break;
                case CallbackIdentifier.HTML_JSAlert:
                    ecb.AddComponent(entity, *(HTML_JSAlert*)data);
                    break;
                case CallbackIdentifier.HTML_JSConfirm:
                    ecb.AddComponent(entity, *(HTML_JSConfirm*)data);
                    break;
                case CallbackIdentifier.HTML_FileOpenDialog:
                    ecb.AddComponent(entity, *(HTML_FileOpenDialog*)data);
                    break;
                case CallbackIdentifier.HTML_NewWindow:
                    ecb.AddComponent(entity, *(HTML_NewWindow*)data);
                    break;
                case CallbackIdentifier.HTML_SetCursor:
                    ecb.AddComponent(entity, *(HTML_SetCursor*)data);
                    break;
                case CallbackIdentifier.HTML_StatusText:
                    ecb.AddComponent(entity, *(HTML_StatusText*)data);
                    break;
                case CallbackIdentifier.HTML_ShowToolTip:
                    ecb.AddComponent(entity, *(HTML_ShowToolTip*)data);
                    break;
                case CallbackIdentifier.HTML_UpdateToolTip:
                    ecb.AddComponent(entity, *(HTML_UpdateToolTip*)data);
                    break;
                case CallbackIdentifier.HTML_HideToolTip:
                    ecb.AddComponent(entity, *(HTML_HideToolTip*)data);
                    break;
                case CallbackIdentifier.HTML_BrowserRestarted:
                    ecb.AddComponent(entity, *(HTML_BrowserRestarted*)data);
                    break;
                case CallbackIdentifier.SteamInventoryResultReady:
                    ecb.AddComponent(entity, *(SteamInventoryResultReady*)data);
                    break;
                case CallbackIdentifier.SteamInventoryFullUpdate:
                    ecb.AddComponent(entity, *(SteamInventoryFullUpdate*)data);
                    break;
                case CallbackIdentifier.SteamInventoryDefinitionUpdate:
                    ecb.AddComponent(entity, *(SteamInventoryDefinitionUpdate*)data);
                    break;
                case CallbackIdentifier.SteamInventoryEligiblePromoItemDefIDs:
                    ecb.AddComponent(entity, *(SteamInventoryEligiblePromoItemDefIDs*)data);
                    break;
                case CallbackIdentifier.SteamInventoryStartPurchaseResult:
                    ecb.AddComponent(entity, *(SteamInventoryStartPurchaseResult*)data);
                    break;
                case CallbackIdentifier.SteamInventoryRequestPricesResult:
                    ecb.AddComponent(entity, *(SteamInventoryRequestPricesResult*)data);
                    break;
                case CallbackIdentifier.GetVideoURLResult:
                    ecb.AddComponent(entity, *(GetVideoURLResult*)data);
                    break;
                case CallbackIdentifier.GetOPFSettingsResult:
                    ecb.AddComponent(entity, *(GetOPFSettingsResult*)data);
                    break;
                case CallbackIdentifier.SteamParentalSettingsChanged:
                    ecb.AddComponent(entity, *(SteamParentalSettingsChanged*)data);
                    break;
                case CallbackIdentifier.SteamRemotePlaySessionConnected:
                    ecb.AddComponent(entity, *(SteamRemotePlaySessionConnected*)data);
                    break;
                case CallbackIdentifier.SteamRemotePlaySessionDisconnected:
                    ecb.AddComponent(entity, *(SteamRemotePlaySessionDisconnected*)data);
                    break;
                case CallbackIdentifier.SteamRemotePlayTogetherGuestInvite:
                    ecb.AddComponent(entity, *(SteamRemotePlayTogetherGuestInvite*)data);
                    break;
                case CallbackIdentifier.SteamNetworkingMessagesSessionRequest:
                    ecb.AddComponent(entity, *(SteamNetworkingMessagesSessionRequest*)data);
                    break;
                case CallbackIdentifier.SteamNetworkingMessagesSessionFailed:
                    ecb.AddComponent(entity, *(SteamNetworkingMessagesSessionFailed*)data);
                    break;
                case CallbackIdentifier.SteamNetConnectionStatusChangedCallback:
                    ecb.AddComponent(entity, *(SteamNetConnectionStatusChangedCallback*)data);
                    break;
                case CallbackIdentifier.SteamNetAuthenticationStatus:
                    ecb.AddComponent(entity, *(SteamNetAuthenticationStatus*)data);
                    break;
                case CallbackIdentifier.SteamRelayNetworkStatus:
                    ecb.AddComponent(entity, *(SteamRelayNetworkStatus*)data);
                    break;
                case CallbackIdentifier.GSClientApprove:
                    ecb.AddComponent(entity, *(GSClientApprove*)data);
                    break;
                case CallbackIdentifier.GSClientDeny:
                    ecb.AddComponent(entity, *(GSClientDeny*)data);
                    break;
                case CallbackIdentifier.GSClientKick:
                    ecb.AddComponent(entity, *(GSClientKick*)data);
                    break;
                case CallbackIdentifier.GSClientAchievementStatus:
                    ecb.AddComponent(entity, *(GSClientAchievementStatus*)data);
                    break;
                case CallbackIdentifier.GSPolicyResponse:
                    ecb.AddComponent(entity, *(GSPolicyResponse*)data);
                    break;
                case CallbackIdentifier.GSGameplayStats:
                    ecb.AddComponent(entity, *(GSGameplayStats*)data);
                    break;
                case CallbackIdentifier.GSClientGroupStatus:
                    ecb.AddComponent(entity, *(GSClientGroupStatus*)data);
                    break;
                case CallbackIdentifier.GSReputation:
                    ecb.AddComponent(entity, *(GSReputation*)data);
                    break;
                case CallbackIdentifier.AssociateWithClanResult:
                    ecb.AddComponent(entity, *(AssociateWithClanResult*)data);
                    break;
                case CallbackIdentifier.ComputeNewPlayerCompatibilityResult:
                    ecb.AddComponent(entity, *(ComputeNewPlayerCompatibilityResult*)data);
                    break;
                case CallbackIdentifier.GSStatsReceived:
                    ecb.AddComponent(entity, *(GSStatsReceived*)data);
                    break;
                case CallbackIdentifier.GSStatsStored:
                    ecb.AddComponent(entity, *(GSStatsStored*)data);
                    break;
                case CallbackIdentifier.SteamNetworkingFakeIPResult:
                    ecb.AddComponent(entity, *(SteamNetworkingFakeIPResult*)data);
                    break;
                default:
                    break;
            }
        }
    }
}