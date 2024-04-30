using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Functions for clients to access matchmaking services, favorites, and to operate on game lobbies.<br />
    /// <br />
    /// See <a href="https://partner.steamgames.com/doc/features/multiplayer/matchmaking" class="bb_doclink">Steam Matchmaking &amp; Lobbies</a> for more information.</summary>
    public unsafe interface ISteamMatchmaking
    {
        public int GetFavoriteGameCount();
        public bool GetFavoriteGame(int iGame, AppId* pnAppID, uint* pnIP, ushort* pnConnPort, ushort* pnQueryPort, uint* punFlags, uint* pRTime32LastPlayedOnServer);
        public int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);
        public bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);
        public SteamAPICall RequestLobbyList();
        public void AddRequestLobbyListStringFilter(UTF8StringPtr pchKeyToMatch, UTF8StringPtr pchValueToMatch, LobbyComparison eComparisonType);
        public void AddRequestLobbyListNumericalFilter(UTF8StringPtr pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType);
        public void AddRequestLobbyListNearValueFilter(UTF8StringPtr pchKeyToMatch, int nValueToBeCloseTo);
        public void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable);
        public void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter eLobbyDistanceFilter);
        public void AddRequestLobbyListResultCountFilter(int cMaxResults);
        public void AddRequestLobbyListCompatibleMembersFilter(SteamId steamIDLobby);
        public SteamId GetLobbyByIndex(int iLobby);
        public SteamAPICall CreateLobby(LobbyType eLobbyType, int cMaxMembers);
        public SteamAPICall JoinLobby(SteamId steamIDLobby);
        public void LeaveLobby(SteamId steamIDLobby);
        public bool InviteUserToLobby(SteamId steamIDLobby, SteamId steamIDInvitee);
        public int GetNumLobbyMembers(SteamId steamIDLobby);
        public SteamId GetLobbyMemberByIndex(SteamId steamIDLobby, int iMember);
        public UTF8StringPtr GetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey);
        public bool SetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        public int GetLobbyDataCount(SteamId steamIDLobby);
        public bool GetLobbyDataByIndex(SteamId steamIDLobby, int iLobbyData, byte* pchKey, int cchKeyBufferSize, byte* pchValue, int cchValueBufferSize);
        public bool DeleteLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey);
        public UTF8StringPtr GetLobbyMemberData(SteamId steamIDLobby, SteamId steamIDUser, UTF8StringPtr pchKey);
        public void SetLobbyMemberData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        public bool SendLobbyChatMsg(SteamId steamIDLobby, void* pvMsgBody, int cubMsgBody);
        public int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, SteamId* pSteamIDUser, void* pvData, int cubData, ChatEntryType* peChatEntryType);
        public bool RequestLobbyData(SteamId steamIDLobby);
        public void SetLobbyGameServer(SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer);
        public bool GetLobbyGameServer(SteamId steamIDLobby, uint* punGameServerIP, ushort* punGameServerPort, SteamId* psteamIDGameServer);
        public bool SetLobbyMemberLimit(SteamId steamIDLobby, int cMaxMembers);
        public int GetLobbyMemberLimit(SteamId steamIDLobby);
        public bool SetLobbyType(SteamId steamIDLobby, LobbyType eLobbyType);
        public bool SetLobbyJoinable(SteamId steamIDLobby, bool bLobbyJoinable);
        public SteamId GetLobbyOwner(SteamId steamIDLobby);
        public bool SetLobbyOwner(SteamId steamIDLobby, SteamId steamIDNewOwner);
        public bool SetLinkedLobby(SteamId steamIDLobby, SteamId steamIDLobbyDependent);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGameCount", CallingConvention = Platform.CC)]
        internal static extern int GetFavoriteGameCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetFavoriteGame", CallingConvention = Platform.CC)]
        internal static extern bool GetFavoriteGame(void* self, int iGame, AppId* pnAppID, uint* pnIP, ushort* pnConnPort, ushort* pnQueryPort, uint* punFlags, uint* pRTime32LastPlayedOnServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddFavoriteGame", CallingConvention = Platform.CC)]
        internal static extern int AddFavoriteGame(void* self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_RemoveFavoriteGame", CallingConvention = Platform.CC)]
        internal static extern bool RemoveFavoriteGame(void* self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyList", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestLobbyList(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListStringFilter", CallingConvention = Platform.CC)]
        internal static extern void AddRequestLobbyListStringFilter(void* self, UTF8StringPtr pchKeyToMatch, UTF8StringPtr pchValueToMatch, LobbyComparison eComparisonType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNumericalFilter", CallingConvention = Platform.CC)]
        internal static extern void AddRequestLobbyListNumericalFilter(void* self, UTF8StringPtr pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListNearValueFilter", CallingConvention = Platform.CC)]
        internal static extern void AddRequestLobbyListNearValueFilter(void* self, UTF8StringPtr pchKeyToMatch, int nValueToBeCloseTo);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable", CallingConvention = Platform.CC)]
        internal static extern void AddRequestLobbyListFilterSlotsAvailable(void* self, int nSlotsAvailable);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListDistanceFilter", CallingConvention = Platform.CC)]
        internal static extern void AddRequestLobbyListDistanceFilter(void* self, LobbyDistanceFilter eLobbyDistanceFilter);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListResultCountFilter", CallingConvention = Platform.CC)]
        internal static extern void AddRequestLobbyListResultCountFilter(void* self, int cMaxResults);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter", CallingConvention = Platform.CC)]
        internal static extern void AddRequestLobbyListCompatibleMembersFilter(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyByIndex", CallingConvention = Platform.CC)]
        internal static extern SteamId GetLobbyByIndex(void* self, int iLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_CreateLobby", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall CreateLobby(void* self, LobbyType eLobbyType, int cMaxMembers);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_JoinLobby", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall JoinLobby(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_LeaveLobby", CallingConvention = Platform.CC)]
        internal static extern void LeaveLobby(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_InviteUserToLobby", CallingConvention = Platform.CC)]
        internal static extern bool InviteUserToLobby(void* self, SteamId steamIDLobby, SteamId steamIDInvitee);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetNumLobbyMembers", CallingConvention = Platform.CC)]
        internal static extern int GetNumLobbyMembers(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberByIndex", CallingConvention = Platform.CC)]
        internal static extern SteamId GetLobbyMemberByIndex(void* self, SteamId steamIDLobby, int iMember);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyData", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetLobbyData(void* self, SteamId steamIDLobby, UTF8StringPtr pchKey);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyData", CallingConvention = Platform.CC)]
        internal static extern bool SetLobbyData(void* self, SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataCount", CallingConvention = Platform.CC)]
        internal static extern int GetLobbyDataCount(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyDataByIndex", CallingConvention = Platform.CC)]
        internal static extern bool GetLobbyDataByIndex(void* self, SteamId steamIDLobby, int iLobbyData, byte* pchKey, int cchKeyBufferSize, byte* pchValue, int cchValueBufferSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_DeleteLobbyData", CallingConvention = Platform.CC)]
        internal static extern bool DeleteLobbyData(void* self, SteamId steamIDLobby, UTF8StringPtr pchKey);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberData", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetLobbyMemberData(void* self, SteamId steamIDLobby, SteamId steamIDUser, UTF8StringPtr pchKey);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberData", CallingConvention = Platform.CC)]
        internal static extern void SetLobbyMemberData(void* self, SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SendLobbyChatMsg", CallingConvention = Platform.CC)]
        internal static extern bool SendLobbyChatMsg(void* self, SteamId steamIDLobby, void* pvMsgBody, int cubMsgBody);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyChatEntry", CallingConvention = Platform.CC)]
        internal static extern int GetLobbyChatEntry(void* self, SteamId steamIDLobby, int iChatID, SteamId* pSteamIDUser, void* pvData, int cubData, ChatEntryType* peChatEntryType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_RequestLobbyData", CallingConvention = Platform.CC)]
        internal static extern bool RequestLobbyData(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyGameServer", CallingConvention = Platform.CC)]
        internal static extern void SetLobbyGameServer(void* self, SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyGameServer", CallingConvention = Platform.CC)]
        internal static extern bool GetLobbyGameServer(void* self, SteamId steamIDLobby, uint* punGameServerIP, ushort* punGameServerPort, SteamId* psteamIDGameServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyMemberLimit", CallingConvention = Platform.CC)]
        internal static extern bool SetLobbyMemberLimit(void* self, SteamId steamIDLobby, int cMaxMembers);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyMemberLimit", CallingConvention = Platform.CC)]
        internal static extern int GetLobbyMemberLimit(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyType", CallingConvention = Platform.CC)]
        internal static extern bool SetLobbyType(void* self, SteamId steamIDLobby, LobbyType eLobbyType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyJoinable", CallingConvention = Platform.CC)]
        internal static extern bool SetLobbyJoinable(void* self, SteamId steamIDLobby, bool bLobbyJoinable);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_GetLobbyOwner", CallingConvention = Platform.CC)]
        internal static extern SteamId GetLobbyOwner(void* self, SteamId steamIDLobby);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLobbyOwner", CallingConvention = Platform.CC)]
        internal static extern bool SetLobbyOwner(void* self, SteamId steamIDLobby, SteamId steamIDNewOwner);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmaking_SetLinkedLobby", CallingConvention = Platform.CC)]
        internal static extern bool SetLinkedLobby(void* self, SteamId steamIDLobby, SteamId steamIDLobbyDependent);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamMatchmaking
        {
            public void* self;
            public int GetFavoriteGameCount() => ISteamMatchmaking.GetFavoriteGameCount(self);
            public bool GetFavoriteGame(int iGame, AppId* pnAppID, uint* pnIP, ushort* pnConnPort, ushort* pnQueryPort, uint* punFlags, uint* pRTime32LastPlayedOnServer) => ISteamMatchmaking.GetFavoriteGame(self, iGame, pnAppID, pnIP, pnConnPort, pnQueryPort, punFlags, pRTime32LastPlayedOnServer);
            public int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) => ISteamMatchmaking.AddFavoriteGame(self, nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer);
            public bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) => ISteamMatchmaking.RemoveFavoriteGame(self, nAppID, nIP, nConnPort, nQueryPort, unFlags);
            public SteamAPICall RequestLobbyList() => ISteamMatchmaking.RequestLobbyList(self);
            public void AddRequestLobbyListStringFilter(UTF8StringPtr pchKeyToMatch, UTF8StringPtr pchValueToMatch, LobbyComparison eComparisonType) => ISteamMatchmaking.AddRequestLobbyListStringFilter(self, pchKeyToMatch, pchValueToMatch, eComparisonType);
            public void AddRequestLobbyListNumericalFilter(UTF8StringPtr pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType) => ISteamMatchmaking.AddRequestLobbyListNumericalFilter(self, pchKeyToMatch, nValueToMatch, eComparisonType);
            public void AddRequestLobbyListNearValueFilter(UTF8StringPtr pchKeyToMatch, int nValueToBeCloseTo) => ISteamMatchmaking.AddRequestLobbyListNearValueFilter(self, pchKeyToMatch, nValueToBeCloseTo);
            public void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) => ISteamMatchmaking.AddRequestLobbyListFilterSlotsAvailable(self, nSlotsAvailable);
            public void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter eLobbyDistanceFilter) => ISteamMatchmaking.AddRequestLobbyListDistanceFilter(self, eLobbyDistanceFilter);
            public void AddRequestLobbyListResultCountFilter(int cMaxResults) => ISteamMatchmaking.AddRequestLobbyListResultCountFilter(self, cMaxResults);
            public void AddRequestLobbyListCompatibleMembersFilter(SteamId steamIDLobby) => ISteamMatchmaking.AddRequestLobbyListCompatibleMembersFilter(self, steamIDLobby);
            public SteamId GetLobbyByIndex(int iLobby) => ISteamMatchmaking.GetLobbyByIndex(self, iLobby);
            public SteamAPICall CreateLobby(LobbyType eLobbyType, int cMaxMembers) => ISteamMatchmaking.CreateLobby(self, eLobbyType, cMaxMembers);
            public SteamAPICall JoinLobby(SteamId steamIDLobby) => ISteamMatchmaking.JoinLobby(self, steamIDLobby);
            public void LeaveLobby(SteamId steamIDLobby) => ISteamMatchmaking.LeaveLobby(self, steamIDLobby);
            public bool InviteUserToLobby(SteamId steamIDLobby, SteamId steamIDInvitee) => ISteamMatchmaking.InviteUserToLobby(self, steamIDLobby, steamIDInvitee);
            public int GetNumLobbyMembers(SteamId steamIDLobby) => ISteamMatchmaking.GetNumLobbyMembers(self, steamIDLobby);
            public SteamId GetLobbyMemberByIndex(SteamId steamIDLobby, int iMember) => ISteamMatchmaking.GetLobbyMemberByIndex(self, steamIDLobby, iMember);
            public UTF8StringPtr GetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey) => ISteamMatchmaking.GetLobbyData(self, steamIDLobby, pchKey);
            public bool SetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => ISteamMatchmaking.SetLobbyData(self, steamIDLobby, pchKey, pchValue);
            public int GetLobbyDataCount(SteamId steamIDLobby) => ISteamMatchmaking.GetLobbyDataCount(self, steamIDLobby);
            public bool GetLobbyDataByIndex(SteamId steamIDLobby, int iLobbyData, byte* pchKey, int cchKeyBufferSize, byte* pchValue, int cchValueBufferSize) => ISteamMatchmaking.GetLobbyDataByIndex(self, steamIDLobby, iLobbyData, pchKey, cchKeyBufferSize, pchValue, cchValueBufferSize);
            public bool DeleteLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey) => ISteamMatchmaking.DeleteLobbyData(self, steamIDLobby, pchKey);
            public UTF8StringPtr GetLobbyMemberData(SteamId steamIDLobby, SteamId steamIDUser, UTF8StringPtr pchKey) => ISteamMatchmaking.GetLobbyMemberData(self, steamIDLobby, steamIDUser, pchKey);
            public void SetLobbyMemberData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => ISteamMatchmaking.SetLobbyMemberData(self, steamIDLobby, pchKey, pchValue);
            public bool SendLobbyChatMsg(SteamId steamIDLobby, void* pvMsgBody, int cubMsgBody) => ISteamMatchmaking.SendLobbyChatMsg(self, steamIDLobby, pvMsgBody, cubMsgBody);
            public int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, SteamId* pSteamIDUser, void* pvData, int cubData, ChatEntryType* peChatEntryType) => ISteamMatchmaking.GetLobbyChatEntry(self, steamIDLobby, iChatID, pSteamIDUser, pvData, cubData, peChatEntryType);
            public bool RequestLobbyData(SteamId steamIDLobby) => ISteamMatchmaking.RequestLobbyData(self, steamIDLobby);
            public void SetLobbyGameServer(SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer) => ISteamMatchmaking.SetLobbyGameServer(self, steamIDLobby, unGameServerIP, unGameServerPort, steamIDGameServer);
            public bool GetLobbyGameServer(SteamId steamIDLobby, uint* punGameServerIP, ushort* punGameServerPort, SteamId* psteamIDGameServer) => ISteamMatchmaking.GetLobbyGameServer(self, steamIDLobby, punGameServerIP, punGameServerPort, psteamIDGameServer);
            public bool SetLobbyMemberLimit(SteamId steamIDLobby, int cMaxMembers) => ISteamMatchmaking.SetLobbyMemberLimit(self, steamIDLobby, cMaxMembers);
            public int GetLobbyMemberLimit(SteamId steamIDLobby) => ISteamMatchmaking.GetLobbyMemberLimit(self, steamIDLobby);
            public bool SetLobbyType(SteamId steamIDLobby, LobbyType eLobbyType) => ISteamMatchmaking.SetLobbyType(self, steamIDLobby, eLobbyType);
            public bool SetLobbyJoinable(SteamId steamIDLobby, bool bLobbyJoinable) => ISteamMatchmaking.SetLobbyJoinable(self, steamIDLobby, bLobbyJoinable);
            public SteamId GetLobbyOwner(SteamId steamIDLobby) => ISteamMatchmaking.GetLobbyOwner(self, steamIDLobby);
            public bool SetLobbyOwner(SteamId steamIDLobby, SteamId steamIDNewOwner) => ISteamMatchmaking.SetLobbyOwner(self, steamIDLobby, steamIDNewOwner);
            public bool SetLinkedLobby(SteamId steamIDLobby, SteamId steamIDLobbyDependent) => ISteamMatchmaking.SetLinkedLobby(self, steamIDLobby, steamIDLobbyDependent);
        }
    }
}