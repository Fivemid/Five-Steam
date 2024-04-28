using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ISteamGameSearch
    public unsafe interface ISteamGameSearch
    {
        public GameSearchErrorCode AddGameSearchParams(UTF8StringPtr pchKeyToFind, UTF8StringPtr pchValuesToFind);
        public GameSearchErrorCode SearchForGameWithLobby(SteamId steamIDLobby, int nPlayerMin, int nPlayerMax);
        public GameSearchErrorCode SearchForGameSolo(int nPlayerMin, int nPlayerMax);
        public GameSearchErrorCode AcceptGame();
        public GameSearchErrorCode DeclineGame();
        public GameSearchErrorCode RetrieveConnectionDetails(SteamId steamIDHost, byte* pchConnectionDetails, int cubConnectionDetails);
        public GameSearchErrorCode EndGameSearch();
        public GameSearchErrorCode SetGameHostParams(UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        public GameSearchErrorCode SetConnectionDetails(UTF8StringPtr pchConnectionDetails, int cubConnectionDetails);
        public GameSearchErrorCode RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize);
        public GameSearchErrorCode HostConfirmGameStart(ulong ullUniqueGameID);
        public GameSearchErrorCode CancelRequestPlayersForGame();
        public GameSearchErrorCode SubmitPlayerResult(ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult EPlayerResult);
        public GameSearchErrorCode EndGame(ulong ullUniqueGameID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_AddGameSearchParams", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode AddGameSearchParams(void* self, UTF8StringPtr pchKeyToFind, UTF8StringPtr pchValuesToFind);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_SearchForGameWithLobby", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode SearchForGameWithLobby(void* self, SteamId steamIDLobby, int nPlayerMin, int nPlayerMax);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_SearchForGameSolo", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode SearchForGameSolo(void* self, int nPlayerMin, int nPlayerMax);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_AcceptGame", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode AcceptGame(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_DeclineGame", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode DeclineGame(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_RetrieveConnectionDetails", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode RetrieveConnectionDetails(void* self, SteamId steamIDHost, byte* pchConnectionDetails, int cubConnectionDetails);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_EndGameSearch", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode EndGameSearch(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_SetGameHostParams", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode SetGameHostParams(void* self, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_SetConnectionDetails", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode SetConnectionDetails(void* self, UTF8StringPtr pchConnectionDetails, int cubConnectionDetails);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_RequestPlayersForGame", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode RequestPlayersForGame(void* self, int nPlayerMin, int nPlayerMax, int nMaxTeamSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_HostConfirmGameStart", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode HostConfirmGameStart(void* self, ulong ullUniqueGameID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_CancelRequestPlayersForGame", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode CancelRequestPlayersForGame(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_SubmitPlayerResult", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode SubmitPlayerResult(void* self, ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult EPlayerResult);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameSearch_EndGame", CallingConvention = Platform.CC)]
        internal static extern GameSearchErrorCode EndGame(void* self, ulong ullUniqueGameID);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamGameSearch
        {
            public void* self;
            public GameSearchErrorCode AddGameSearchParams(UTF8StringPtr pchKeyToFind, UTF8StringPtr pchValuesToFind) => ISteamGameSearch.AddGameSearchParams(self, pchKeyToFind, pchValuesToFind);
            public GameSearchErrorCode SearchForGameWithLobby(SteamId steamIDLobby, int nPlayerMin, int nPlayerMax) => ISteamGameSearch.SearchForGameWithLobby(self, steamIDLobby, nPlayerMin, nPlayerMax);
            public GameSearchErrorCode SearchForGameSolo(int nPlayerMin, int nPlayerMax) => ISteamGameSearch.SearchForGameSolo(self, nPlayerMin, nPlayerMax);
            public GameSearchErrorCode AcceptGame() => ISteamGameSearch.AcceptGame(self);
            public GameSearchErrorCode DeclineGame() => ISteamGameSearch.DeclineGame(self);
            public GameSearchErrorCode RetrieveConnectionDetails(SteamId steamIDHost, byte* pchConnectionDetails, int cubConnectionDetails) => ISteamGameSearch.RetrieveConnectionDetails(self, steamIDHost, pchConnectionDetails, cubConnectionDetails);
            public GameSearchErrorCode EndGameSearch() => ISteamGameSearch.EndGameSearch(self);
            public GameSearchErrorCode SetGameHostParams(UTF8StringPtr pchKey, UTF8StringPtr pchValue) => ISteamGameSearch.SetGameHostParams(self, pchKey, pchValue);
            public GameSearchErrorCode SetConnectionDetails(UTF8StringPtr pchConnectionDetails, int cubConnectionDetails) => ISteamGameSearch.SetConnectionDetails(self, pchConnectionDetails, cubConnectionDetails);
            public GameSearchErrorCode RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) => ISteamGameSearch.RequestPlayersForGame(self, nPlayerMin, nPlayerMax, nMaxTeamSize);
            public GameSearchErrorCode HostConfirmGameStart(ulong ullUniqueGameID) => ISteamGameSearch.HostConfirmGameStart(self, ullUniqueGameID);
            public GameSearchErrorCode CancelRequestPlayersForGame() => ISteamGameSearch.CancelRequestPlayersForGame(self);
            public GameSearchErrorCode SubmitPlayerResult(ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult EPlayerResult) => ISteamGameSearch.SubmitPlayerResult(self, ullUniqueGameID, steamIDPlayer, EPlayerResult);
            public GameSearchErrorCode EndGame(ulong ullUniqueGameID) => ISteamGameSearch.EndGame(self, ullUniqueGameID);
        }
    }
}