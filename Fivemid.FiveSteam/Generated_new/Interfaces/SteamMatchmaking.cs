using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMatchmaking
    {
        public static ISteamMatchmaking.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamMatchmaking_v009", CallingConvention = Platform.CC)]
        private static extern ISteamMatchmaking.Instance Accessor();
        /// <summary></summary>
        public static int GetFavoriteGameCount() => Instance.GetFavoriteGameCount();
        /// <summary></summary>
        public static bool GetFavoriteGame(int iGame, AppId* pnAppID, uint* pnIP, ushort* pnConnPort, ushort* pnQueryPort, uint* punFlags, uint* pRTime32LastPlayedOnServer) => Instance.GetFavoriteGame(iGame, pnAppID, pnIP, pnConnPort, pnQueryPort, punFlags, pRTime32LastPlayedOnServer);
        /// <summary></summary>
        public static int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) => Instance.AddFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer);
        /// <summary></summary>
        public static bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) => Instance.RemoveFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags);
        /// <summary></summary>
        public static SteamAPICall RequestLobbyList() => Instance.RequestLobbyList();
        /// <summary></summary>
        public static void AddRequestLobbyListStringFilter(UTF8StringPtr pchKeyToMatch, UTF8StringPtr pchValueToMatch, LobbyComparison eComparisonType) => Instance.AddRequestLobbyListStringFilter(pchKeyToMatch, pchValueToMatch, eComparisonType);
        /// <summary></summary>
        public static void AddRequestLobbyListNumericalFilter(UTF8StringPtr pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType) => Instance.AddRequestLobbyListNumericalFilter(pchKeyToMatch, nValueToMatch, eComparisonType);
        /// <summary></summary>
        public static void AddRequestLobbyListNearValueFilter(UTF8StringPtr pchKeyToMatch, int nValueToBeCloseTo) => Instance.AddRequestLobbyListNearValueFilter(pchKeyToMatch, nValueToBeCloseTo);
        /// <summary></summary>
        public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) => Instance.AddRequestLobbyListFilterSlotsAvailable(nSlotsAvailable);
        /// <summary></summary>
        public static void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter eLobbyDistanceFilter) => Instance.AddRequestLobbyListDistanceFilter(eLobbyDistanceFilter);
        /// <summary></summary>
        public static void AddRequestLobbyListResultCountFilter(int cMaxResults) => Instance.AddRequestLobbyListResultCountFilter(cMaxResults);
        /// <summary></summary>
        public static void AddRequestLobbyListCompatibleMembersFilter(SteamId steamIDLobby) => Instance.AddRequestLobbyListCompatibleMembersFilter(steamIDLobby);
        /// <summary></summary>
        public static SteamId GetLobbyByIndex(int iLobby) => Instance.GetLobbyByIndex(iLobby);
        /// <summary></summary>
        public static SteamAPICall CreateLobby(LobbyType eLobbyType, int cMaxMembers) => Instance.CreateLobby(eLobbyType, cMaxMembers);
        /// <summary></summary>
        public static SteamAPICall JoinLobby(SteamId steamIDLobby) => Instance.JoinLobby(steamIDLobby);
        /// <summary></summary>
        public static void LeaveLobby(SteamId steamIDLobby) => Instance.LeaveLobby(steamIDLobby);
        /// <summary></summary>
        public static bool InviteUserToLobby(SteamId steamIDLobby, SteamId steamIDInvitee) => Instance.InviteUserToLobby(steamIDLobby, steamIDInvitee);
        /// <summary></summary>
        public static int GetNumLobbyMembers(SteamId steamIDLobby) => Instance.GetNumLobbyMembers(steamIDLobby);
        /// <summary></summary>
        public static SteamId GetLobbyMemberByIndex(SteamId steamIDLobby, int iMember) => Instance.GetLobbyMemberByIndex(steamIDLobby, iMember);
        /// <summary></summary>
        public static UTF8StringPtr GetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey) => Instance.GetLobbyData(steamIDLobby, pchKey);
        /// <summary></summary>
        public static bool SetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetLobbyData(steamIDLobby, pchKey, pchValue);
        /// <summary></summary>
        public static int GetLobbyDataCount(SteamId steamIDLobby) => Instance.GetLobbyDataCount(steamIDLobby);
        /// <summary></summary>
        public static bool GetLobbyDataByIndex(SteamId steamIDLobby, int iLobbyData, char* pchKey, int cchKeyBufferSize, char* pchValue, int cchValueBufferSize) => Instance.GetLobbyDataByIndex(steamIDLobby, iLobbyData, pchKey, cchKeyBufferSize, pchValue, cchValueBufferSize);
        /// <summary></summary>
        public static bool DeleteLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey) => Instance.DeleteLobbyData(steamIDLobby, pchKey);
        /// <summary></summary>
        public static UTF8StringPtr GetLobbyMemberData(SteamId steamIDLobby, SteamId steamIDUser, UTF8StringPtr pchKey) => Instance.GetLobbyMemberData(steamIDLobby, steamIDUser, pchKey);
        /// <summary></summary>
        public static void SetLobbyMemberData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetLobbyMemberData(steamIDLobby, pchKey, pchValue);
        /// <summary></summary>
        public static bool SendLobbyChatMsg(SteamId steamIDLobby, void* pvMsgBody, int cubMsgBody) => Instance.SendLobbyChatMsg(steamIDLobby, pvMsgBody, cubMsgBody);
        /// <summary></summary>
        public static int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, SteamId* pSteamIDUser, void* pvData, int cubData, ChatEntryType* peChatEntryType) => Instance.GetLobbyChatEntry(steamIDLobby, iChatID, pSteamIDUser, pvData, cubData, peChatEntryType);
        /// <summary></summary>
        public static bool RequestLobbyData(SteamId steamIDLobby) => Instance.RequestLobbyData(steamIDLobby);
        /// <summary></summary>
        public static void SetLobbyGameServer(SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer) => Instance.SetLobbyGameServer(steamIDLobby, unGameServerIP, unGameServerPort, steamIDGameServer);
        /// <summary></summary>
        public static bool GetLobbyGameServer(SteamId steamIDLobby, uint* punGameServerIP, ushort* punGameServerPort, SteamId* psteamIDGameServer) => Instance.GetLobbyGameServer(steamIDLobby, punGameServerIP, punGameServerPort, psteamIDGameServer);
        /// <summary></summary>
        public static bool SetLobbyMemberLimit(SteamId steamIDLobby, int cMaxMembers) => Instance.SetLobbyMemberLimit(steamIDLobby, cMaxMembers);
        /// <summary></summary>
        public static int GetLobbyMemberLimit(SteamId steamIDLobby) => Instance.GetLobbyMemberLimit(steamIDLobby);
        /// <summary></summary>
        public static bool SetLobbyType(SteamId steamIDLobby, LobbyType eLobbyType) => Instance.SetLobbyType(steamIDLobby, eLobbyType);
        /// <summary></summary>
        public static bool SetLobbyJoinable(SteamId steamIDLobby, bool bLobbyJoinable) => Instance.SetLobbyJoinable(steamIDLobby, bLobbyJoinable);
        /// <summary></summary>
        public static SteamId GetLobbyOwner(SteamId steamIDLobby) => Instance.GetLobbyOwner(steamIDLobby);
        /// <summary></summary>
        public static bool SetLobbyOwner(SteamId steamIDLobby, SteamId steamIDNewOwner) => Instance.SetLobbyOwner(steamIDLobby, steamIDNewOwner);
        /// <summary></summary>
        public static bool SetLinkedLobby(SteamId steamIDLobby, SteamId steamIDLobbyDependent) => Instance.SetLinkedLobby(steamIDLobby, steamIDLobbyDependent);
    }
}