using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamInputLEDFlag</summary>
    public enum SteamInputLEDFlag : int
    {
        /// <summary>k_ESteamInputLEDFlag_SetColor</summary>
        SetColor = 0,
        /// <summary>k_ESteamInputLEDFlag_RestoreUserDefault</summary>
        RestoreUserDefault = 1
    }
}