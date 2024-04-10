using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamInputType</summary>
    public enum SteamInputType : int
    {
        /// <summary>k_ESteamInputType_Unknown</summary>
        Unknown = 0,
        /// <summary>k_ESteamInputType_SteamController</summary>
        SteamController = 1,
        /// <summary>k_ESteamInputType_XBox360Controller</summary>
        XBox360Controller = 2,
        /// <summary>k_ESteamInputType_XBoxOneController</summary>
        XBoxOneController = 3,
        /// <summary>k_ESteamInputType_GenericGamepad</summary>
        GenericGamepad = 4,
        /// <summary>k_ESteamInputType_PS4Controller</summary>
        PS4Controller = 5,
        /// <summary>k_ESteamInputType_AppleMFiController</summary>
        AppleMFiController = 6,
        /// <summary>k_ESteamInputType_AndroidController</summary>
        AndroidController = 7,
        /// <summary>k_ESteamInputType_SwitchJoyConPair</summary>
        SwitchJoyConPair = 8,
        /// <summary>k_ESteamInputType_SwitchJoyConSingle</summary>
        SwitchJoyConSingle = 9,
        /// <summary>k_ESteamInputType_SwitchProController</summary>
        SwitchProController = 10,
        /// <summary>k_ESteamInputType_MobileTouch</summary>
        MobileTouch = 11,
        /// <summary>k_ESteamInputType_PS3Controller</summary>
        PS3Controller = 12,
        /// <summary>k_ESteamInputType_PS5Controller</summary>
        PS5Controller = 13,
        /// <summary>k_ESteamInputType_SteamDeckController</summary>
        SteamDeckController = 14,
        /// <summary>k_ESteamInputType_Count</summary>
        Count = 15,
        /// <summary>k_ESteamInputType_MaximumPossibleValue</summary>
        MaximumPossibleValue = 255
    }
}