using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Interface to access information about individual users and interact with the <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a>.</summary>
    public unsafe interface ISteamFriends
    {
        public UTF8StringPtr GetPersonaName();
        public SteamAPICall SetPersonaName(UTF8StringPtr pchPersonaName);
        public PersonaState GetPersonaState();
        public int GetFriendCount(int iFriendFlags);
        public SteamId GetFriendByIndex(int iFriend, int iFriendFlags);
        public FriendRelationship GetFriendRelationship(SteamId steamIDFriend);
        public PersonaState GetFriendPersonaState(SteamId steamIDFriend);
        public UTF8StringPtr GetFriendPersonaName(SteamId steamIDFriend);
        public bool GetFriendGamePlayed(SteamId steamIDFriend, FriendGameInfo* pFriendGameInfo);
        public UTF8StringPtr GetFriendPersonaNameHistory(SteamId steamIDFriend, int iPersonaName);
        public int GetFriendSteamLevel(SteamId steamIDFriend);
        public UTF8StringPtr GetPlayerNickname(SteamId steamIDPlayer);
        public int GetFriendsGroupCount();
        public FriendsGroupID GetFriendsGroupIDByIndex(int iFG);
        public UTF8StringPtr GetFriendsGroupName(FriendsGroupID friendsGroupID);
        public int GetFriendsGroupMembersCount(FriendsGroupID friendsGroupID);
        public void GetFriendsGroupMembersList(FriendsGroupID friendsGroupID, SteamId* pOutSteamIDMembers, int nMembersCount);
        public bool HasFriend(SteamId steamIDFriend, int iFriendFlags);
        public int GetClanCount();
        public SteamId GetClanByIndex(int iClan);
        public UTF8StringPtr GetClanName(SteamId steamIDClan);
        public UTF8StringPtr GetClanTag(SteamId steamIDClan);
        public bool GetClanActivityCounts(SteamId steamIDClan, int* pnOnline, int* pnInGame, int* pnChatting);
        public SteamAPICall DownloadClanActivityCounts(SteamId* psteamIDClans, int cClansToRequest);
        public int GetFriendCountFromSource(SteamId steamIDSource);
        public SteamId GetFriendFromSourceByIndex(SteamId steamIDSource, int iFriend);
        public bool IsUserInSource(SteamId steamIDUser, SteamId steamIDSource);
        public void SetInGameVoiceSpeaking(SteamId steamIDUser, bool bSpeaking);
        public void ActivateGameOverlay(UTF8StringPtr pchDialog);
        public void ActivateGameOverlayToUser(UTF8StringPtr pchDialog, SteamId steamID);
        public void ActivateGameOverlayToWebPage(UTF8StringPtr pchURL, ActivateGameOverlayToWebPageMode eMode);
        public void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag);
        public void SetPlayedWith(SteamId steamIDUserPlayedWith);
        public void ActivateGameOverlayInviteDialog(SteamId steamIDLobby);
        public int GetSmallFriendAvatar(SteamId steamIDFriend);
        public int GetMediumFriendAvatar(SteamId steamIDFriend);
        public int GetLargeFriendAvatar(SteamId steamIDFriend);
        public bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly);
        public SteamAPICall RequestClanOfficerList(SteamId steamIDClan);
        public SteamId GetClanOwner(SteamId steamIDClan);
        public int GetClanOfficerCount(SteamId steamIDClan);
        public SteamId GetClanOfficerByIndex(SteamId steamIDClan, int iOfficer);
        public uint GetUserRestrictions();
        public bool SetRichPresence(UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        public void ClearRichPresence();
        public UTF8StringPtr GetFriendRichPresence(SteamId steamIDFriend, UTF8StringPtr pchKey);
        public int GetFriendRichPresenceKeyCount(SteamId steamIDFriend);
        public UTF8StringPtr GetFriendRichPresenceKeyByIndex(SteamId steamIDFriend, int iKey);
        public void RequestFriendRichPresence(SteamId steamIDFriend);
        public bool InviteUserToGame(SteamId steamIDFriend, UTF8StringPtr pchConnectString);
        public int GetCoplayFriendCount();
        public SteamId GetCoplayFriend(int iCoplayFriend);
        public int GetFriendCoplayTime(SteamId steamIDFriend);
        public AppId GetFriendCoplayGame(SteamId steamIDFriend);
        public SteamAPICall JoinClanChatRoom(SteamId steamIDClan);
        public bool LeaveClanChatRoom(SteamId steamIDClan);
        public int GetClanChatMemberCount(SteamId steamIDClan);
        public SteamId GetChatMemberByIndex(SteamId steamIDClan, int iUser);
        public bool SendClanChatMessage(SteamId steamIDClanChat, UTF8StringPtr pchText);
        public int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, void* prgchText, int cchTextMax, ChatEntryType* peChatEntryType, SteamId* psteamidChatter);
        public bool IsClanChatAdmin(SteamId steamIDClanChat, SteamId steamIDUser);
        public bool IsClanChatWindowOpenInSteam(SteamId steamIDClanChat);
        public bool OpenClanChatWindowInSteam(SteamId steamIDClanChat);
        public bool CloseClanChatWindowInSteam(SteamId steamIDClanChat);
        public bool SetListenForFriendsMessages(bool bInterceptEnabled);
        public bool ReplyToFriendMessage(SteamId steamIDFriend, UTF8StringPtr pchMsgToSend);
        public int GetFriendMessage(SteamId steamIDFriend, int iMessageID, void* pvData, int cubData, ChatEntryType* peChatEntryType);
        public SteamAPICall GetFollowerCount(SteamId steamID);
        public SteamAPICall IsFollowing(SteamId steamID);
        public SteamAPICall EnumerateFollowingList(uint unStartIndex);
        public bool IsClanPublic(SteamId steamIDClan);
        public bool IsClanOfficialGameGroup(SteamId steamIDClan);
        public int GetNumChatsWithUnreadPriorityMessages();
        public void ActivateGameOverlayRemotePlayTogetherInviteDialog(SteamId steamIDLobby);
        public bool RegisterProtocolInOverlayBrowser(UTF8StringPtr pchProtocol);
        public void ActivateGameOverlayInviteDialogConnectString(UTF8StringPtr pchConnectString);
        public SteamAPICall RequestEquippedProfileItems(SteamId steamID);
        public bool BHasEquippedProfileItem(SteamId steamID, CommunityProfileItemType itemType);
        public UTF8StringPtr GetProfileItemPropertyString(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop);
        public uint GetProfileItemPropertyUint(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetPersonaName(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_SetPersonaName", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall SetPersonaName(void* self, UTF8StringPtr pchPersonaName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetPersonaState", CallingConvention = Platform.CC)]
        internal static extern PersonaState GetPersonaState(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCount", CallingConvention = Platform.CC)]
        internal static extern int GetFriendCount(void* self, int iFriendFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendByIndex", CallingConvention = Platform.CC)]
        internal static extern SteamId GetFriendByIndex(void* self, int iFriend, int iFriendFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRelationship", CallingConvention = Platform.CC)]
        internal static extern FriendRelationship GetFriendRelationship(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaState", CallingConvention = Platform.CC)]
        internal static extern PersonaState GetFriendPersonaState(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetFriendPersonaName(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendGamePlayed", CallingConvention = Platform.CC)]
        internal static extern bool GetFriendGamePlayed(void* self, SteamId steamIDFriend, FriendGameInfo* pFriendGameInfo);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendPersonaNameHistory", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetFriendPersonaNameHistory(void* self, SteamId steamIDFriend, int iPersonaName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendSteamLevel", CallingConvention = Platform.CC)]
        internal static extern int GetFriendSteamLevel(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetPlayerNickname", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetPlayerNickname(void* self, SteamId steamIDPlayer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupCount", CallingConvention = Platform.CC)]
        internal static extern int GetFriendsGroupCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupIDByIndex", CallingConvention = Platform.CC)]
        internal static extern FriendsGroupID GetFriendsGroupIDByIndex(void* self, int iFG);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetFriendsGroupName(void* self, FriendsGroupID friendsGroupID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersCount", CallingConvention = Platform.CC)]
        internal static extern int GetFriendsGroupMembersCount(void* self, FriendsGroupID friendsGroupID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendsGroupMembersList", CallingConvention = Platform.CC)]
        internal static extern void GetFriendsGroupMembersList(void* self, FriendsGroupID friendsGroupID, SteamId* pOutSteamIDMembers, int nMembersCount);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_HasFriend", CallingConvention = Platform.CC)]
        internal static extern bool HasFriend(void* self, SteamId steamIDFriend, int iFriendFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanCount", CallingConvention = Platform.CC)]
        internal static extern int GetClanCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanByIndex", CallingConvention = Platform.CC)]
        internal static extern SteamId GetClanByIndex(void* self, int iClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetClanName(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanTag", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetClanTag(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanActivityCounts", CallingConvention = Platform.CC)]
        internal static extern bool GetClanActivityCounts(void* self, SteamId steamIDClan, int* pnOnline, int* pnInGame, int* pnChatting);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_DownloadClanActivityCounts", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall DownloadClanActivityCounts(void* self, SteamId* psteamIDClans, int cClansToRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCountFromSource", CallingConvention = Platform.CC)]
        internal static extern int GetFriendCountFromSource(void* self, SteamId steamIDSource);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendFromSourceByIndex", CallingConvention = Platform.CC)]
        internal static extern SteamId GetFriendFromSourceByIndex(void* self, SteamId steamIDSource, int iFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_IsUserInSource", CallingConvention = Platform.CC)]
        internal static extern bool IsUserInSource(void* self, SteamId steamIDUser, SteamId steamIDSource);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_SetInGameVoiceSpeaking", CallingConvention = Platform.CC)]
        internal static extern void SetInGameVoiceSpeaking(void* self, SteamId steamIDUser, bool bSpeaking);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlay", CallingConvention = Platform.CC)]
        internal static extern void ActivateGameOverlay(void* self, UTF8StringPtr pchDialog);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToUser", CallingConvention = Platform.CC)]
        internal static extern void ActivateGameOverlayToUser(void* self, UTF8StringPtr pchDialog, SteamId steamID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToWebPage", CallingConvention = Platform.CC)]
        internal static extern void ActivateGameOverlayToWebPage(void* self, UTF8StringPtr pchURL, ActivateGameOverlayToWebPageMode eMode);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayToStore", CallingConvention = Platform.CC)]
        internal static extern void ActivateGameOverlayToStore(void* self, AppId nAppID, OverlayToStoreFlag eFlag);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_SetPlayedWith", CallingConvention = Platform.CC)]
        internal static extern void SetPlayedWith(void* self, SteamId steamIDUserPlayedWith);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialog", CallingConvention = Platform.CC)]
        internal static extern void ActivateGameOverlayInviteDialog(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetSmallFriendAvatar", CallingConvention = Platform.CC)]
        internal static extern int GetSmallFriendAvatar(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetMediumFriendAvatar", CallingConvention = Platform.CC)]
        internal static extern int GetMediumFriendAvatar(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetLargeFriendAvatar", CallingConvention = Platform.CC)]
        internal static extern int GetLargeFriendAvatar(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_RequestUserInformation", CallingConvention = Platform.CC)]
        internal static extern bool RequestUserInformation(void* self, SteamId steamIDUser, bool bRequireNameOnly);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_RequestClanOfficerList", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestClanOfficerList(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanOwner", CallingConvention = Platform.CC)]
        internal static extern SteamId GetClanOwner(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerCount", CallingConvention = Platform.CC)]
        internal static extern int GetClanOfficerCount(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanOfficerByIndex", CallingConvention = Platform.CC)]
        internal static extern SteamId GetClanOfficerByIndex(void* self, SteamId steamIDClan, int iOfficer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetUserRestrictions", CallingConvention = Platform.CC)]
        internal static extern uint GetUserRestrictions(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_SetRichPresence", CallingConvention = Platform.CC)]
        internal static extern bool SetRichPresence(void* self, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ClearRichPresence", CallingConvention = Platform.CC)]
        internal static extern void ClearRichPresence(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresence", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetFriendRichPresence(void* self, SteamId steamIDFriend, UTF8StringPtr pchKey);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyCount", CallingConvention = Platform.CC)]
        internal static extern int GetFriendRichPresenceKeyCount(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendRichPresenceKeyByIndex", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetFriendRichPresenceKeyByIndex(void* self, SteamId steamIDFriend, int iKey);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_RequestFriendRichPresence", CallingConvention = Platform.CC)]
        internal static extern void RequestFriendRichPresence(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_InviteUserToGame", CallingConvention = Platform.CC)]
        internal static extern bool InviteUserToGame(void* self, SteamId steamIDFriend, UTF8StringPtr pchConnectString);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriendCount", CallingConvention = Platform.CC)]
        internal static extern int GetCoplayFriendCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetCoplayFriend", CallingConvention = Platform.CC)]
        internal static extern SteamId GetCoplayFriend(void* self, int iCoplayFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayTime", CallingConvention = Platform.CC)]
        internal static extern int GetFriendCoplayTime(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendCoplayGame", CallingConvention = Platform.CC)]
        internal static extern AppId GetFriendCoplayGame(void* self, SteamId steamIDFriend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_JoinClanChatRoom", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall JoinClanChatRoom(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_LeaveClanChatRoom", CallingConvention = Platform.CC)]
        internal static extern bool LeaveClanChatRoom(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMemberCount", CallingConvention = Platform.CC)]
        internal static extern int GetClanChatMemberCount(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetChatMemberByIndex", CallingConvention = Platform.CC)]
        internal static extern SteamId GetChatMemberByIndex(void* self, SteamId steamIDClan, int iUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_SendClanChatMessage", CallingConvention = Platform.CC)]
        internal static extern bool SendClanChatMessage(void* self, SteamId steamIDClanChat, UTF8StringPtr pchText);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetClanChatMessage", CallingConvention = Platform.CC)]
        internal static extern int GetClanChatMessage(void* self, SteamId steamIDClanChat, int iMessage, void* prgchText, int cchTextMax, ChatEntryType* peChatEntryType, SteamId* psteamidChatter);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatAdmin", CallingConvention = Platform.CC)]
        internal static extern bool IsClanChatAdmin(void* self, SteamId steamIDClanChat, SteamId steamIDUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_IsClanChatWindowOpenInSteam", CallingConvention = Platform.CC)]
        internal static extern bool IsClanChatWindowOpenInSteam(void* self, SteamId steamIDClanChat);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_OpenClanChatWindowInSteam", CallingConvention = Platform.CC)]
        internal static extern bool OpenClanChatWindowInSteam(void* self, SteamId steamIDClanChat);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_CloseClanChatWindowInSteam", CallingConvention = Platform.CC)]
        internal static extern bool CloseClanChatWindowInSteam(void* self, SteamId steamIDClanChat);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_SetListenForFriendsMessages", CallingConvention = Platform.CC)]
        internal static extern bool SetListenForFriendsMessages(void* self, bool bInterceptEnabled);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ReplyToFriendMessage", CallingConvention = Platform.CC)]
        internal static extern bool ReplyToFriendMessage(void* self, SteamId steamIDFriend, UTF8StringPtr pchMsgToSend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFriendMessage", CallingConvention = Platform.CC)]
        internal static extern int GetFriendMessage(void* self, SteamId steamIDFriend, int iMessageID, void* pvData, int cubData, ChatEntryType* peChatEntryType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetFollowerCount", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetFollowerCount(void* self, SteamId steamID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_IsFollowing", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall IsFollowing(void* self, SteamId steamID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_EnumerateFollowingList", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall EnumerateFollowingList(void* self, uint unStartIndex);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_IsClanPublic", CallingConvention = Platform.CC)]
        internal static extern bool IsClanPublic(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_IsClanOfficialGameGroup", CallingConvention = Platform.CC)]
        internal static extern bool IsClanOfficialGameGroup(void* self, SteamId steamIDClan);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetNumChatsWithUnreadPriorityMessages", CallingConvention = Platform.CC)]
        internal static extern int GetNumChatsWithUnreadPriorityMessages(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog", CallingConvention = Platform.CC)]
        internal static extern void ActivateGameOverlayRemotePlayTogetherInviteDialog(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_RegisterProtocolInOverlayBrowser", CallingConvention = Platform.CC)]
        internal static extern bool RegisterProtocolInOverlayBrowser(void* self, UTF8StringPtr pchProtocol);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_ActivateGameOverlayInviteDialogConnectString", CallingConvention = Platform.CC)]
        internal static extern void ActivateGameOverlayInviteDialogConnectString(void* self, UTF8StringPtr pchConnectString);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_RequestEquippedProfileItems", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestEquippedProfileItems(void* self, SteamId steamID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_BHasEquippedProfileItem", CallingConvention = Platform.CC)]
        internal static extern bool BHasEquippedProfileItem(void* self, SteamId steamID, CommunityProfileItemType itemType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetProfileItemPropertyString", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetProfileItemPropertyString(void* self, SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamFriends_GetProfileItemPropertyUint", CallingConvention = Platform.CC)]
        internal static extern uint GetProfileItemPropertyUint(void* self, SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamFriends
        {
            public void* self;
            public UTF8StringPtr GetPersonaName() => ISteamFriends.GetPersonaName(self);
            public SteamAPICall SetPersonaName(UTF8StringPtr pchPersonaName) => ISteamFriends.SetPersonaName(self, pchPersonaName);
            public PersonaState GetPersonaState() => ISteamFriends.GetPersonaState(self);
            public int GetFriendCount(int iFriendFlags) => ISteamFriends.GetFriendCount(self, iFriendFlags);
            public SteamId GetFriendByIndex(int iFriend, int iFriendFlags) => ISteamFriends.GetFriendByIndex(self, iFriend, iFriendFlags);
            public FriendRelationship GetFriendRelationship(SteamId steamIDFriend) => ISteamFriends.GetFriendRelationship(self, steamIDFriend);
            public PersonaState GetFriendPersonaState(SteamId steamIDFriend) => ISteamFriends.GetFriendPersonaState(self, steamIDFriend);
            public UTF8StringPtr GetFriendPersonaName(SteamId steamIDFriend) => ISteamFriends.GetFriendPersonaName(self, steamIDFriend);
            public bool GetFriendGamePlayed(SteamId steamIDFriend, FriendGameInfo* pFriendGameInfo) => ISteamFriends.GetFriendGamePlayed(self, steamIDFriend, pFriendGameInfo);
            public UTF8StringPtr GetFriendPersonaNameHistory(SteamId steamIDFriend, int iPersonaName) => ISteamFriends.GetFriendPersonaNameHistory(self, steamIDFriend, iPersonaName);
            public int GetFriendSteamLevel(SteamId steamIDFriend) => ISteamFriends.GetFriendSteamLevel(self, steamIDFriend);
            public UTF8StringPtr GetPlayerNickname(SteamId steamIDPlayer) => ISteamFriends.GetPlayerNickname(self, steamIDPlayer);
            public int GetFriendsGroupCount() => ISteamFriends.GetFriendsGroupCount(self);
            public FriendsGroupID GetFriendsGroupIDByIndex(int iFG) => ISteamFriends.GetFriendsGroupIDByIndex(self, iFG);
            public UTF8StringPtr GetFriendsGroupName(FriendsGroupID friendsGroupID) => ISteamFriends.GetFriendsGroupName(self, friendsGroupID);
            public int GetFriendsGroupMembersCount(FriendsGroupID friendsGroupID) => ISteamFriends.GetFriendsGroupMembersCount(self, friendsGroupID);
            public void GetFriendsGroupMembersList(FriendsGroupID friendsGroupID, SteamId* pOutSteamIDMembers, int nMembersCount) => ISteamFriends.GetFriendsGroupMembersList(self, friendsGroupID, pOutSteamIDMembers, nMembersCount);
            public bool HasFriend(SteamId steamIDFriend, int iFriendFlags) => ISteamFriends.HasFriend(self, steamIDFriend, iFriendFlags);
            public int GetClanCount() => ISteamFriends.GetClanCount(self);
            public SteamId GetClanByIndex(int iClan) => ISteamFriends.GetClanByIndex(self, iClan);
            public UTF8StringPtr GetClanName(SteamId steamIDClan) => ISteamFriends.GetClanName(self, steamIDClan);
            public UTF8StringPtr GetClanTag(SteamId steamIDClan) => ISteamFriends.GetClanTag(self, steamIDClan);
            public bool GetClanActivityCounts(SteamId steamIDClan, int* pnOnline, int* pnInGame, int* pnChatting) => ISteamFriends.GetClanActivityCounts(self, steamIDClan, pnOnline, pnInGame, pnChatting);
            public SteamAPICall DownloadClanActivityCounts(SteamId* psteamIDClans, int cClansToRequest) => ISteamFriends.DownloadClanActivityCounts(self, psteamIDClans, cClansToRequest);
            public int GetFriendCountFromSource(SteamId steamIDSource) => ISteamFriends.GetFriendCountFromSource(self, steamIDSource);
            public SteamId GetFriendFromSourceByIndex(SteamId steamIDSource, int iFriend) => ISteamFriends.GetFriendFromSourceByIndex(self, steamIDSource, iFriend);
            public bool IsUserInSource(SteamId steamIDUser, SteamId steamIDSource) => ISteamFriends.IsUserInSource(self, steamIDUser, steamIDSource);
            public void SetInGameVoiceSpeaking(SteamId steamIDUser, bool bSpeaking) => ISteamFriends.SetInGameVoiceSpeaking(self, steamIDUser, bSpeaking);
            public void ActivateGameOverlay(UTF8StringPtr pchDialog) => ISteamFriends.ActivateGameOverlay(self, pchDialog);
            public void ActivateGameOverlayToUser(UTF8StringPtr pchDialog, SteamId steamID) => ISteamFriends.ActivateGameOverlayToUser(self, pchDialog, steamID);
            public void ActivateGameOverlayToWebPage(UTF8StringPtr pchURL, ActivateGameOverlayToWebPageMode eMode) => ISteamFriends.ActivateGameOverlayToWebPage(self, pchURL, eMode);
            public void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) => ISteamFriends.ActivateGameOverlayToStore(self, nAppID, eFlag);
            public void SetPlayedWith(SteamId steamIDUserPlayedWith) => ISteamFriends.SetPlayedWith(self, steamIDUserPlayedWith);
            public void ActivateGameOverlayInviteDialog(SteamId steamIDLobby) => ISteamFriends.ActivateGameOverlayInviteDialog(self, steamIDLobby);
            public int GetSmallFriendAvatar(SteamId steamIDFriend) => ISteamFriends.GetSmallFriendAvatar(self, steamIDFriend);
            public int GetMediumFriendAvatar(SteamId steamIDFriend) => ISteamFriends.GetMediumFriendAvatar(self, steamIDFriend);
            public int GetLargeFriendAvatar(SteamId steamIDFriend) => ISteamFriends.GetLargeFriendAvatar(self, steamIDFriend);
            public bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) => ISteamFriends.RequestUserInformation(self, steamIDUser, bRequireNameOnly);
            public SteamAPICall RequestClanOfficerList(SteamId steamIDClan) => ISteamFriends.RequestClanOfficerList(self, steamIDClan);
            public SteamId GetClanOwner(SteamId steamIDClan) => ISteamFriends.GetClanOwner(self, steamIDClan);
            public int GetClanOfficerCount(SteamId steamIDClan) => ISteamFriends.GetClanOfficerCount(self, steamIDClan);
            public SteamId GetClanOfficerByIndex(SteamId steamIDClan, int iOfficer) => ISteamFriends.GetClanOfficerByIndex(self, steamIDClan, iOfficer);
            public uint GetUserRestrictions() => ISteamFriends.GetUserRestrictions(self);
            public bool SetRichPresence(UTF8StringPtr pchKey, UTF8StringPtr pchValue) => ISteamFriends.SetRichPresence(self, pchKey, pchValue);
            public void ClearRichPresence() => ISteamFriends.ClearRichPresence(self);
            public UTF8StringPtr GetFriendRichPresence(SteamId steamIDFriend, UTF8StringPtr pchKey) => ISteamFriends.GetFriendRichPresence(self, steamIDFriend, pchKey);
            public int GetFriendRichPresenceKeyCount(SteamId steamIDFriend) => ISteamFriends.GetFriendRichPresenceKeyCount(self, steamIDFriend);
            public UTF8StringPtr GetFriendRichPresenceKeyByIndex(SteamId steamIDFriend, int iKey) => ISteamFriends.GetFriendRichPresenceKeyByIndex(self, steamIDFriend, iKey);
            public void RequestFriendRichPresence(SteamId steamIDFriend) => ISteamFriends.RequestFriendRichPresence(self, steamIDFriend);
            public bool InviteUserToGame(SteamId steamIDFriend, UTF8StringPtr pchConnectString) => ISteamFriends.InviteUserToGame(self, steamIDFriend, pchConnectString);
            public int GetCoplayFriendCount() => ISteamFriends.GetCoplayFriendCount(self);
            public SteamId GetCoplayFriend(int iCoplayFriend) => ISteamFriends.GetCoplayFriend(self, iCoplayFriend);
            public int GetFriendCoplayTime(SteamId steamIDFriend) => ISteamFriends.GetFriendCoplayTime(self, steamIDFriend);
            public AppId GetFriendCoplayGame(SteamId steamIDFriend) => ISteamFriends.GetFriendCoplayGame(self, steamIDFriend);
            public SteamAPICall JoinClanChatRoom(SteamId steamIDClan) => ISteamFriends.JoinClanChatRoom(self, steamIDClan);
            public bool LeaveClanChatRoom(SteamId steamIDClan) => ISteamFriends.LeaveClanChatRoom(self, steamIDClan);
            public int GetClanChatMemberCount(SteamId steamIDClan) => ISteamFriends.GetClanChatMemberCount(self, steamIDClan);
            public SteamId GetChatMemberByIndex(SteamId steamIDClan, int iUser) => ISteamFriends.GetChatMemberByIndex(self, steamIDClan, iUser);
            public bool SendClanChatMessage(SteamId steamIDClanChat, UTF8StringPtr pchText) => ISteamFriends.SendClanChatMessage(self, steamIDClanChat, pchText);
            public int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, void* prgchText, int cchTextMax, ChatEntryType* peChatEntryType, SteamId* psteamidChatter) => ISteamFriends.GetClanChatMessage(self, steamIDClanChat, iMessage, prgchText, cchTextMax, peChatEntryType, psteamidChatter);
            public bool IsClanChatAdmin(SteamId steamIDClanChat, SteamId steamIDUser) => ISteamFriends.IsClanChatAdmin(self, steamIDClanChat, steamIDUser);
            public bool IsClanChatWindowOpenInSteam(SteamId steamIDClanChat) => ISteamFriends.IsClanChatWindowOpenInSteam(self, steamIDClanChat);
            public bool OpenClanChatWindowInSteam(SteamId steamIDClanChat) => ISteamFriends.OpenClanChatWindowInSteam(self, steamIDClanChat);
            public bool CloseClanChatWindowInSteam(SteamId steamIDClanChat) => ISteamFriends.CloseClanChatWindowInSteam(self, steamIDClanChat);
            public bool SetListenForFriendsMessages(bool bInterceptEnabled) => ISteamFriends.SetListenForFriendsMessages(self, bInterceptEnabled);
            public bool ReplyToFriendMessage(SteamId steamIDFriend, UTF8StringPtr pchMsgToSend) => ISteamFriends.ReplyToFriendMessage(self, steamIDFriend, pchMsgToSend);
            public int GetFriendMessage(SteamId steamIDFriend, int iMessageID, void* pvData, int cubData, ChatEntryType* peChatEntryType) => ISteamFriends.GetFriendMessage(self, steamIDFriend, iMessageID, pvData, cubData, peChatEntryType);
            public SteamAPICall GetFollowerCount(SteamId steamID) => ISteamFriends.GetFollowerCount(self, steamID);
            public SteamAPICall IsFollowing(SteamId steamID) => ISteamFriends.IsFollowing(self, steamID);
            public SteamAPICall EnumerateFollowingList(uint unStartIndex) => ISteamFriends.EnumerateFollowingList(self, unStartIndex);
            public bool IsClanPublic(SteamId steamIDClan) => ISteamFriends.IsClanPublic(self, steamIDClan);
            public bool IsClanOfficialGameGroup(SteamId steamIDClan) => ISteamFriends.IsClanOfficialGameGroup(self, steamIDClan);
            public int GetNumChatsWithUnreadPriorityMessages() => ISteamFriends.GetNumChatsWithUnreadPriorityMessages(self);
            public void ActivateGameOverlayRemotePlayTogetherInviteDialog(SteamId steamIDLobby) => ISteamFriends.ActivateGameOverlayRemotePlayTogetherInviteDialog(self, steamIDLobby);
            public bool RegisterProtocolInOverlayBrowser(UTF8StringPtr pchProtocol) => ISteamFriends.RegisterProtocolInOverlayBrowser(self, pchProtocol);
            public void ActivateGameOverlayInviteDialogConnectString(UTF8StringPtr pchConnectString) => ISteamFriends.ActivateGameOverlayInviteDialogConnectString(self, pchConnectString);
            public SteamAPICall RequestEquippedProfileItems(SteamId steamID) => ISteamFriends.RequestEquippedProfileItems(self, steamID);
            public bool BHasEquippedProfileItem(SteamId steamID, CommunityProfileItemType itemType) => ISteamFriends.BHasEquippedProfileItem(self, steamID, itemType);
            public UTF8StringPtr GetProfileItemPropertyString(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop) => ISteamFriends.GetProfileItemPropertyString(self, steamID, itemType, prop);
            public uint GetProfileItemPropertyUint(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop) => ISteamFriends.GetProfileItemPropertyUint(self, steamID, itemType, prop);
        }
    }
}