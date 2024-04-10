using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameSearch
    {
        public static ISteamGameSearch.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameSearch_v001", CallingConvention = Platform.CC)]
        private static extern ISteamGameSearch.Instance Accessor();
        /// missing documentation
        public static GameSearchErrorCode AddGameSearchParams(UTF8StringPtr pchKeyToFind, UTF8StringPtr pchValuesToFind) => Instance.AddGameSearchParams(pchKeyToFind, pchValuesToFind);
        /// missing documentation
        public static GameSearchErrorCode SearchForGameWithLobby(SteamId steamIDLobby, int nPlayerMin, int nPlayerMax) => Instance.SearchForGameWithLobby(steamIDLobby, nPlayerMin, nPlayerMax);
        /// missing documentation
        public static GameSearchErrorCode SearchForGameSolo(int nPlayerMin, int nPlayerMax) => Instance.SearchForGameSolo(nPlayerMin, nPlayerMax);
        /// missing documentation
        public static GameSearchErrorCode AcceptGame() => Instance.AcceptGame();
        /// missing documentation
        public static GameSearchErrorCode DeclineGame() => Instance.DeclineGame();
        /// missing documentation
        public static GameSearchErrorCode RetrieveConnectionDetails(SteamId steamIDHost, char* pchConnectionDetails, int cubConnectionDetails) => Instance.RetrieveConnectionDetails(steamIDHost, pchConnectionDetails, cubConnectionDetails);
        /// missing documentation
        public static GameSearchErrorCode EndGameSearch() => Instance.EndGameSearch();
        /// missing documentation
        public static GameSearchErrorCode SetGameHostParams(UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetGameHostParams(pchKey, pchValue);
        /// missing documentation
        public static GameSearchErrorCode SetConnectionDetails(UTF8StringPtr pchConnectionDetails, int cubConnectionDetails) => Instance.SetConnectionDetails(pchConnectionDetails, cubConnectionDetails);
        /// missing documentation
        public static GameSearchErrorCode RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) => Instance.RequestPlayersForGame(nPlayerMin, nPlayerMax, nMaxTeamSize);
        /// missing documentation
        public static GameSearchErrorCode HostConfirmGameStart(ulong ullUniqueGameID) => Instance.HostConfirmGameStart(ullUniqueGameID);
        /// missing documentation
        public static GameSearchErrorCode CancelRequestPlayersForGame() => Instance.CancelRequestPlayersForGame();
        /// missing documentation
        public static GameSearchErrorCode SubmitPlayerResult(ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult EPlayerResult) => Instance.SubmitPlayerResult(ullUniqueGameID, steamIDPlayer, EPlayerResult);
        /// missing documentation
        public static GameSearchErrorCode EndGame(ulong ullUniqueGameID) => Instance.EndGame(ullUniqueGameID);
    }
}