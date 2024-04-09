using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ELobbyDistanceFilter</summary>
    public enum LobbyDistanceFilter : int
    {
        /// <summary>k_ELobbyDistanceFilterClose</summary>
        Close = 0,
        /// <summary>k_ELobbyDistanceFilterDefault</summary>
        Default = 1,
        /// <summary>k_ELobbyDistanceFilterFar</summary>
        Far = 2,
        /// <summary>k_ELobbyDistanceFilterWorldwide</summary>
        Worldwide = 3
    }
}