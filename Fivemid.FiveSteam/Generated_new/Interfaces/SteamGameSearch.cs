using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameSearch
    {
        public static ISteamGameSearch.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameSearch_v001", CallingConvention = Platform.CC)]
        private static extern ISteamGameSearch.Instance Accessor();
        /// <summary></summary>
        public static GameSearchErrorCode AddGameSearchParams(UTF8StringPtr pchKeyToFind, UTF8StringPtr pchValuesToFind) => Instance.AddGameSearchParams(pchKeyToFind, pchValuesToFind);
        /// <summary></summary>
        public static GameSearchErrorCode SearchForGameWithLobby(SteamId steamIDLobby, int nPlayerMin, int nPlayerMax) => Instance.SearchForGameWithLobby(steamIDLobby, nPlayerMin, nPlayerMax);
        /// <summary></summary>
        public static GameSearchErrorCode SearchForGameSolo(int nPlayerMin, int nPlayerMax) => Instance.SearchForGameSolo(nPlayerMin, nPlayerMax);
        /// <summary></summary>
        public static GameSearchErrorCode AcceptGame() => Instance.AcceptGame();
        /// <summary></summary>
        public static GameSearchErrorCode DeclineGame() => Instance.DeclineGame();
        /// <summary></summary>
        public static GameSearchErrorCode RetrieveConnectionDetails(SteamId steamIDHost, char* pchConnectionDetails, int cubConnectionDetails) => Instance.RetrieveConnectionDetails(steamIDHost, pchConnectionDetails, cubConnectionDetails);
        /// <summary></summary>
        public static GameSearchErrorCode EndGameSearch() => Instance.EndGameSearch();
        /// <summary></summary>
        public static GameSearchErrorCode SetGameHostParams(UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetGameHostParams(pchKey, pchValue);
        /// <summary></summary>
        public static GameSearchErrorCode SetConnectionDetails(UTF8StringPtr pchConnectionDetails, int cubConnectionDetails) => Instance.SetConnectionDetails(pchConnectionDetails, cubConnectionDetails);
        /// <summary></summary>
        public static GameSearchErrorCode RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) => Instance.RequestPlayersForGame(nPlayerMin, nPlayerMax, nMaxTeamSize);
        /// <summary></summary>
        public static GameSearchErrorCode HostConfirmGameStart(ulong ullUniqueGameID) => Instance.HostConfirmGameStart(ullUniqueGameID);
        /// <summary></summary>
        public static GameSearchErrorCode CancelRequestPlayersForGame() => Instance.CancelRequestPlayersForGame();
        /// <summary></summary>
        public static GameSearchErrorCode SubmitPlayerResult(ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult EPlayerResult) => Instance.SubmitPlayerResult(ullUniqueGameID, steamIDPlayer, EPlayerResult);
        /// <summary></summary>
        public static GameSearchErrorCode EndGame(ulong ullUniqueGameID) => Instance.EndGame(ullUniqueGameID);
    }
}