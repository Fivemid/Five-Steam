using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EWorkshopFileType</summary>
    public enum WorkshopFileType : int
    {
        /// <summary>k_EWorkshopFileTypeFirst</summary>
        First = 0,
        /// <summary>k_EWorkshopFileTypeCommunity</summary>
        Community = 0,
        /// <summary>k_EWorkshopFileTypeMicrotransaction</summary>
        Microtransaction = 1,
        /// <summary>k_EWorkshopFileTypeCollection</summary>
        Collection = 2,
        /// <summary>k_EWorkshopFileTypeArt</summary>
        Art = 3,
        /// <summary>k_EWorkshopFileTypeVideo</summary>
        Video = 4,
        /// <summary>k_EWorkshopFileTypeScreenshot</summary>
        Screenshot = 5,
        /// <summary>k_EWorkshopFileTypeGame</summary>
        Game = 6,
        /// <summary>k_EWorkshopFileTypeSoftware</summary>
        Software = 7,
        /// <summary>k_EWorkshopFileTypeConcept</summary>
        Concept = 8,
        /// <summary>k_EWorkshopFileTypeWebGuide</summary>
        WebGuide = 9,
        /// <summary>k_EWorkshopFileTypeIntegratedGuide</summary>
        IntegratedGuide = 10,
        /// <summary>k_EWorkshopFileTypeMerch</summary>
        Merch = 11,
        /// <summary>k_EWorkshopFileTypeControllerBinding</summary>
        ControllerBinding = 12,
        /// <summary>k_EWorkshopFileTypeSteamworksAccessInvite</summary>
        SteamworksAccessInvite = 13,
        /// <summary>k_EWorkshopFileTypeSteamVideo</summary>
        SteamVideo = 14,
        /// <summary>k_EWorkshopFileTypeGameManagedItem</summary>
        GameManagedItem = 15,
        /// <summary>k_EWorkshopFileTypeClip</summary>
        Clip = 16,
        /// <summary>k_EWorkshopFileTypeMax</summary>
        Max = 17
    }
}