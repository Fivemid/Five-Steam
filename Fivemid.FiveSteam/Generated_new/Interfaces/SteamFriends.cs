using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamFriends
    {
        public static ISteamFriends.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamFriends_v017", CallingConvention = Platform.CC)]
        private static extern ISteamFriends.Instance Accessor();
        /// <summary></summary>
        public static UTF8StringPtr GetPersonaName() => Instance.GetPersonaName();
        /// <summary></summary>
        public static SteamAPICall SetPersonaName(UTF8StringPtr pchPersonaName) => Instance.SetPersonaName(pchPersonaName);
        /// <summary></summary>
        public static PersonaState GetPersonaState() => Instance.GetPersonaState();
        /// <summary></summary>
        public static int GetFriendCount(int iFriendFlags) => Instance.GetFriendCount(iFriendFlags);
        /// <summary></summary>
        public static SteamId GetFriendByIndex(int iFriend, int iFriendFlags) => Instance.GetFriendByIndex(iFriend, iFriendFlags);
        /// <summary></summary>
        public static FriendRelationship GetFriendRelationship(SteamId steamIDFriend) => Instance.GetFriendRelationship(steamIDFriend);
        /// <summary></summary>
        public static PersonaState GetFriendPersonaState(SteamId steamIDFriend) => Instance.GetFriendPersonaState(steamIDFriend);
        /// <summary></summary>
        public static UTF8StringPtr GetFriendPersonaName(SteamId steamIDFriend) => Instance.GetFriendPersonaName(steamIDFriend);
        /// <summary></summary>
        public static bool GetFriendGamePlayed(SteamId steamIDFriend, FriendGameInfo* pFriendGameInfo) => Instance.GetFriendGamePlayed(steamIDFriend, pFriendGameInfo);
        /// <summary></summary>
        public static UTF8StringPtr GetFriendPersonaNameHistory(SteamId steamIDFriend, int iPersonaName) => Instance.GetFriendPersonaNameHistory(steamIDFriend, iPersonaName);
        /// <summary></summary>
        public static int GetFriendSteamLevel(SteamId steamIDFriend) => Instance.GetFriendSteamLevel(steamIDFriend);
        /// <summary></summary>
        public static UTF8StringPtr GetPlayerNickname(SteamId steamIDPlayer) => Instance.GetPlayerNickname(steamIDPlayer);
        /// <summary></summary>
        public static int GetFriendsGroupCount() => Instance.GetFriendsGroupCount();
        /// <summary></summary>
        public static FriendsGroupID GetFriendsGroupIDByIndex(int iFG) => Instance.GetFriendsGroupIDByIndex(iFG);
        /// <summary></summary>
        public static UTF8StringPtr GetFriendsGroupName(FriendsGroupID friendsGroupID) => Instance.GetFriendsGroupName(friendsGroupID);
        /// <summary></summary>
        public static int GetFriendsGroupMembersCount(FriendsGroupID friendsGroupID) => Instance.GetFriendsGroupMembersCount(friendsGroupID);
        /// <summary></summary>
        public static void GetFriendsGroupMembersList(FriendsGroupID friendsGroupID, SteamId* pOutSteamIDMembers, int nMembersCount) => Instance.GetFriendsGroupMembersList(friendsGroupID, pOutSteamIDMembers, nMembersCount);
        /// <summary></summary>
        public static bool HasFriend(SteamId steamIDFriend, int iFriendFlags) => Instance.HasFriend(steamIDFriend, iFriendFlags);
        /// <summary></summary>
        public static int GetClanCount() => Instance.GetClanCount();
        /// <summary></summary>
        public static SteamId GetClanByIndex(int iClan) => Instance.GetClanByIndex(iClan);
        /// <summary></summary>
        public static UTF8StringPtr GetClanName(SteamId steamIDClan) => Instance.GetClanName(steamIDClan);
        /// <summary></summary>
        public static UTF8StringPtr GetClanTag(SteamId steamIDClan) => Instance.GetClanTag(steamIDClan);
        /// <summary></summary>
        public static bool GetClanActivityCounts(SteamId steamIDClan, int* pnOnline, int* pnInGame, int* pnChatting) => Instance.GetClanActivityCounts(steamIDClan, pnOnline, pnInGame, pnChatting);
        /// <summary></summary>
        public static SteamAPICall DownloadClanActivityCounts(SteamId* psteamIDClans, int cClansToRequest) => Instance.DownloadClanActivityCounts(psteamIDClans, cClansToRequest);
        /// <summary></summary>
        public static int GetFriendCountFromSource(SteamId steamIDSource) => Instance.GetFriendCountFromSource(steamIDSource);
        /// <summary></summary>
        public static SteamId GetFriendFromSourceByIndex(SteamId steamIDSource, int iFriend) => Instance.GetFriendFromSourceByIndex(steamIDSource, iFriend);
        /// <summary></summary>
        public static bool IsUserInSource(SteamId steamIDUser, SteamId steamIDSource) => Instance.IsUserInSource(steamIDUser, steamIDSource);
        /// <summary></summary>
        public static void SetInGameVoiceSpeaking(SteamId steamIDUser, bool bSpeaking) => Instance.SetInGameVoiceSpeaking(steamIDUser, bSpeaking);
        /// <summary></summary>
        public static void ActivateGameOverlay(UTF8StringPtr pchDialog) => Instance.ActivateGameOverlay(pchDialog);
        /// <summary></summary>
        public static void ActivateGameOverlayToUser(UTF8StringPtr pchDialog, SteamId steamID) => Instance.ActivateGameOverlayToUser(pchDialog, steamID);
        /// <summary></summary>
        public static void ActivateGameOverlayToWebPage(UTF8StringPtr pchURL, ActivateGameOverlayToWebPageMode eMode) => Instance.ActivateGameOverlayToWebPage(pchURL, eMode);
        /// <summary></summary>
        public static void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) => Instance.ActivateGameOverlayToStore(nAppID, eFlag);
        /// <summary></summary>
        public static void SetPlayedWith(SteamId steamIDUserPlayedWith) => Instance.SetPlayedWith(steamIDUserPlayedWith);
        /// <summary></summary>
        public static void ActivateGameOverlayInviteDialog(SteamId steamIDLobby) => Instance.ActivateGameOverlayInviteDialog(steamIDLobby);
        /// <summary></summary>
        public static int GetSmallFriendAvatar(SteamId steamIDFriend) => Instance.GetSmallFriendAvatar(steamIDFriend);
        /// <summary></summary>
        public static int GetMediumFriendAvatar(SteamId steamIDFriend) => Instance.GetMediumFriendAvatar(steamIDFriend);
        /// <summary></summary>
        public static int GetLargeFriendAvatar(SteamId steamIDFriend) => Instance.GetLargeFriendAvatar(steamIDFriend);
        /// <summary></summary>
        public static bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) => Instance.RequestUserInformation(steamIDUser, bRequireNameOnly);
        /// <summary></summary>
        public static SteamAPICall RequestClanOfficerList(SteamId steamIDClan) => Instance.RequestClanOfficerList(steamIDClan);
        /// <summary></summary>
        public static SteamId GetClanOwner(SteamId steamIDClan) => Instance.GetClanOwner(steamIDClan);
        /// <summary></summary>
        public static int GetClanOfficerCount(SteamId steamIDClan) => Instance.GetClanOfficerCount(steamIDClan);
        /// <summary></summary>
        public static SteamId GetClanOfficerByIndex(SteamId steamIDClan, int iOfficer) => Instance.GetClanOfficerByIndex(steamIDClan, iOfficer);
        /// <summary></summary>
        public static uint GetUserRestrictions() => Instance.GetUserRestrictions();
        /// <summary></summary>
        public static bool SetRichPresence(UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetRichPresence(pchKey, pchValue);
        /// <summary></summary>
        public static void ClearRichPresence() => Instance.ClearRichPresence();
        /// <summary></summary>
        public static UTF8StringPtr GetFriendRichPresence(SteamId steamIDFriend, UTF8StringPtr pchKey) => Instance.GetFriendRichPresence(steamIDFriend, pchKey);
        /// <summary></summary>
        public static int GetFriendRichPresenceKeyCount(SteamId steamIDFriend) => Instance.GetFriendRichPresenceKeyCount(steamIDFriend);
        /// <summary></summary>
        public static UTF8StringPtr GetFriendRichPresenceKeyByIndex(SteamId steamIDFriend, int iKey) => Instance.GetFriendRichPresenceKeyByIndex(steamIDFriend, iKey);
        /// <summary></summary>
        public static void RequestFriendRichPresence(SteamId steamIDFriend) => Instance.RequestFriendRichPresence(steamIDFriend);
        /// <summary></summary>
        public static bool InviteUserToGame(SteamId steamIDFriend, UTF8StringPtr pchConnectString) => Instance.InviteUserToGame(steamIDFriend, pchConnectString);
        /// <summary></summary>
        public static int GetCoplayFriendCount() => Instance.GetCoplayFriendCount();
        /// <summary></summary>
        public static SteamId GetCoplayFriend(int iCoplayFriend) => Instance.GetCoplayFriend(iCoplayFriend);
        /// <summary></summary>
        public static int GetFriendCoplayTime(SteamId steamIDFriend) => Instance.GetFriendCoplayTime(steamIDFriend);
        /// <summary></summary>
        public static AppId GetFriendCoplayGame(SteamId steamIDFriend) => Instance.GetFriendCoplayGame(steamIDFriend);
        /// <summary></summary>
        public static SteamAPICall JoinClanChatRoom(SteamId steamIDClan) => Instance.JoinClanChatRoom(steamIDClan);
        /// <summary></summary>
        public static bool LeaveClanChatRoom(SteamId steamIDClan) => Instance.LeaveClanChatRoom(steamIDClan);
        /// <summary></summary>
        public static int GetClanChatMemberCount(SteamId steamIDClan) => Instance.GetClanChatMemberCount(steamIDClan);
        /// <summary></summary>
        public static SteamId GetChatMemberByIndex(SteamId steamIDClan, int iUser) => Instance.GetChatMemberByIndex(steamIDClan, iUser);
        /// <summary></summary>
        public static bool SendClanChatMessage(SteamId steamIDClanChat, UTF8StringPtr pchText) => Instance.SendClanChatMessage(steamIDClanChat, pchText);
        /// <summary></summary>
        public static int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, void* prgchText, int cchTextMax, ChatEntryType* peChatEntryType, SteamId* psteamidChatter) => Instance.GetClanChatMessage(steamIDClanChat, iMessage, prgchText, cchTextMax, peChatEntryType, psteamidChatter);
        /// <summary></summary>
        public static bool IsClanChatAdmin(SteamId steamIDClanChat, SteamId steamIDUser) => Instance.IsClanChatAdmin(steamIDClanChat, steamIDUser);
        /// <summary></summary>
        public static bool IsClanChatWindowOpenInSteam(SteamId steamIDClanChat) => Instance.IsClanChatWindowOpenInSteam(steamIDClanChat);
        /// <summary></summary>
        public static bool OpenClanChatWindowInSteam(SteamId steamIDClanChat) => Instance.OpenClanChatWindowInSteam(steamIDClanChat);
        /// <summary></summary>
        public static bool CloseClanChatWindowInSteam(SteamId steamIDClanChat) => Instance.CloseClanChatWindowInSteam(steamIDClanChat);
        /// <summary></summary>
        public static bool SetListenForFriendsMessages(bool bInterceptEnabled) => Instance.SetListenForFriendsMessages(bInterceptEnabled);
        /// <summary></summary>
        public static bool ReplyToFriendMessage(SteamId steamIDFriend, UTF8StringPtr pchMsgToSend) => Instance.ReplyToFriendMessage(steamIDFriend, pchMsgToSend);
        /// <summary></summary>
        public static int GetFriendMessage(SteamId steamIDFriend, int iMessageID, void* pvData, int cubData, ChatEntryType* peChatEntryType) => Instance.GetFriendMessage(steamIDFriend, iMessageID, pvData, cubData, peChatEntryType);
        /// <summary></summary>
        public static SteamAPICall GetFollowerCount(SteamId steamID) => Instance.GetFollowerCount(steamID);
        /// <summary></summary>
        public static SteamAPICall IsFollowing(SteamId steamID) => Instance.IsFollowing(steamID);
        /// <summary></summary>
        public static SteamAPICall EnumerateFollowingList(uint unStartIndex) => Instance.EnumerateFollowingList(unStartIndex);
        /// <summary></summary>
        public static bool IsClanPublic(SteamId steamIDClan) => Instance.IsClanPublic(steamIDClan);
        /// <summary></summary>
        public static bool IsClanOfficialGameGroup(SteamId steamIDClan) => Instance.IsClanOfficialGameGroup(steamIDClan);
        /// <summary></summary>
        public static int GetNumChatsWithUnreadPriorityMessages() => Instance.GetNumChatsWithUnreadPriorityMessages();
        /// <summary></summary>
        public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(SteamId steamIDLobby) => Instance.ActivateGameOverlayRemotePlayTogetherInviteDialog(steamIDLobby);
        /// <summary></summary>
        public static bool RegisterProtocolInOverlayBrowser(UTF8StringPtr pchProtocol) => Instance.RegisterProtocolInOverlayBrowser(pchProtocol);
        /// <summary></summary>
        public static void ActivateGameOverlayInviteDialogConnectString(UTF8StringPtr pchConnectString) => Instance.ActivateGameOverlayInviteDialogConnectString(pchConnectString);
        /// <summary></summary>
        public static SteamAPICall RequestEquippedProfileItems(SteamId steamID) => Instance.RequestEquippedProfileItems(steamID);
        /// <summary></summary>
        public static bool BHasEquippedProfileItem(SteamId steamID, CommunityProfileItemType itemType) => Instance.BHasEquippedProfileItem(steamID, itemType);
        /// <summary></summary>
        public static UTF8StringPtr GetProfileItemPropertyString(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop) => Instance.GetProfileItemPropertyString(steamID, itemType, prop);
        /// <summary></summary>
        public static uint GetProfileItemPropertyUint(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop) => Instance.GetProfileItemPropertyUint(steamID, itemType, prop);
    }
}