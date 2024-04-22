using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Represents the device model for a given piece of hardware.<br />
    /// <br />
    /// </summary>
    public enum SteamInputType : int
    {
        /// <summary>Catch-all for unrecognized devices</summary>
        Unknown = 0,
        /// <summary>Valve's Steam Controller</summary>
        SteamController = 1,
        /// <summary>Microsoft's XBox 360 Controller</summary>
        XBox360Controller = 2,
        /// <summary>Microsoft's XBox One Controller</summary>
        XBoxOneController = 3,
        /// missing documentation for ESteamInputType.k_ESteamInputType_GenericGamepad
        GenericGamepad = 4,
        /// <summary>Sony's PlayStation 4 Controller</summary>
        PS4Controller = 5,
        /// <summary>Unused</summary>
        AppleMFiController = 6,
        /// <summary>Unused</summary>
        AndroidController = 7,
        /// <summary>Unused</summary>
        SwitchJoyConPair = 8,
        /// <summary>Unused</summary>
        SwitchJoyConSingle = 9,
        /// <summary>Nintendo's Switch Pro Controller</summary>
        SwitchProController = 10,
        /// <summary>Steam Link App's Mobile Touch Controller</summary>
        MobileTouch = 11,
        /// <summary>Sony's PlayStation 3 Controller or PS3/PS4 compatible fight stick</summary>
        PS3Controller = 12,
        /// missing documentation for ESteamInputType.k_ESteamInputType_PS5Controller
        PS5Controller = 13,
        /// missing documentation for ESteamInputType.k_ESteamInputType_SteamDeckController
        SteamDeckController = 14,
        /// <summary>Current number of values returned</summary>
        Count = 15,
        /// <summary>Maximum possible value returned</summary>
        MaximumPossibleValue = 255
    }
}