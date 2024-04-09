using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamControllerLEDFlag</summary>
    public enum SteamControllerLEDFlag : int
    {
        /// <summary>k_ESteamControllerLEDFlag_SetColor</summary>
        SetColor = 0,
        /// <summary>k_ESteamControllerLEDFlag_RestoreUserDefault</summary>
        RestoreUserDefault = 1
    }
}