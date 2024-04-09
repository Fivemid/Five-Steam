using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamInputConfigurationEnableType</summary>
    public enum SteamInputConfigurationEnableType : int
    {
        /// <summary>k_ESteamInputConfigurationEnableType_None</summary>
        None = 0,
        /// <summary>k_ESteamInputConfigurationEnableType_Playstation</summary>
        Playstation = 1,
        /// <summary>k_ESteamInputConfigurationEnableType_Xbox</summary>
        Xbox = 2,
        /// <summary>k_ESteamInputConfigurationEnableType_Generic</summary>
        Generic = 4,
        /// <summary>k_ESteamInputConfigurationEnableType_Switch</summary>
        Switch = 8
    }
}