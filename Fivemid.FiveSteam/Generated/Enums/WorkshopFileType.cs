using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>The way that a shared file will be shared with the community.<br />
    /// <br />
    /// </summary>
    public enum WorkshopFileType : int
    {
        /// <summary>Only used for enumerating.</summary>
        First = 0,
        /// <summary>Normal Workshop item that can be subscribed to.</summary>
        Community = 0,
        /// <summary>Workshop item that is meant to be voted on for the purpose of selling in-game. (See: <a href="https://partner.steamgames.com/doc/features/workshop#curated_workshop" class="bb_doclink">Curated Workshop</a>)</summary>
        Microtransaction = 1,
        /// <summary>A collection of Workshop items.</summary>
        Collection = 2,
        /// <summary>Artwork.</summary>
        Art = 3,
        /// <summary>External video.</summary>
        Video = 4,
        /// <summary>Screenshot.</summary>
        Screenshot = 5,
        /// <summary>Unused, used to be for Greenlight game entries</summary>
        Game = 6,
        /// <summary>Unused, used to be for Greenlight software entries.</summary>
        Software = 7,
        /// <summary>Unused, used to be for Greenlight concepts.</summary>
        Concept = 8,
        /// <summary>Steam web guide.</summary>
        WebGuide = 9,
        /// <summary>Application integrated guide.</summary>
        IntegratedGuide = 10,
        /// <summary>Workshop merchandise meant to be voted on for the purpose of being sold.</summary>
        Merch = 11,
        /// <summary>Steam Controller bindings.</summary>
        ControllerBinding = 12,
        /// <summary>Only used internally in Steam.</summary>
        SteamworksAccessInvite = 13,
        /// <summary>Steam video.</summary>
        SteamVideo = 14,
        /// <summary>Managed completely by the game, not the user, and not shown on the web.</summary>
        GameManagedItem = 15,
        /// missing documentation for EWorkshopFileType.k_EWorkshopFileTypeClip
        Clip = 16,
        /// <summary>Only used for enumerating.</summary>
        Max = 17
    }
}