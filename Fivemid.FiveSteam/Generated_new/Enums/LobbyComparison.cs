using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ELobbyComparison</summary>
    public enum LobbyComparison : int
    {
        /// <summary>k_ELobbyComparisonEqualToOrLessThan</summary>
        EqualToOrLessThan = -2,
        /// <summary>k_ELobbyComparisonLessThan</summary>
        LessThan = -1,
        /// <summary>k_ELobbyComparisonEqual</summary>
        Equal = 0,
        /// <summary>k_ELobbyComparisonGreaterThan</summary>
        GreaterThan = 1,
        /// <summary>k_ELobbyComparisonEqualToOrGreaterThan</summary>
        EqualToOrGreaterThan = 2,
        /// <summary>k_ELobbyComparisonNotEqual</summary>
        NotEqual = 3
    }
}