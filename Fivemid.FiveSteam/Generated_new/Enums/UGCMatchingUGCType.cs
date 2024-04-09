using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUGCMatchingUGCType</summary>
    public enum UGCMatchingUGCType : int
    {
        /// <summary>k_EUGCMatchingUGCType_Items</summary>
        Items = 0,
        /// <summary>k_EUGCMatchingUGCType_Items_Mtx</summary>
        Items_Mtx = 1,
        /// <summary>k_EUGCMatchingUGCType_Items_ReadyToUse</summary>
        Items_ReadyToUse = 2,
        /// <summary>k_EUGCMatchingUGCType_Collections</summary>
        Collections = 3,
        /// <summary>k_EUGCMatchingUGCType_Artwork</summary>
        Artwork = 4,
        /// <summary>k_EUGCMatchingUGCType_Videos</summary>
        Videos = 5,
        /// <summary>k_EUGCMatchingUGCType_Screenshots</summary>
        Screenshots = 6,
        /// <summary>k_EUGCMatchingUGCType_AllGuides</summary>
        AllGuides = 7,
        /// <summary>k_EUGCMatchingUGCType_WebGuides</summary>
        WebGuides = 8,
        /// <summary>k_EUGCMatchingUGCType_IntegratedGuides</summary>
        IntegratedGuides = 9,
        /// <summary>k_EUGCMatchingUGCType_UsableInGame</summary>
        UsableInGame = 10,
        /// <summary>k_EUGCMatchingUGCType_ControllerBindings</summary>
        ControllerBindings = 11,
        /// <summary>k_EUGCMatchingUGCType_GameManagedItems</summary>
        GameManagedItems = 12,
        /// <summary>k_EUGCMatchingUGCType_All</summary>
        All = -1
    }
}