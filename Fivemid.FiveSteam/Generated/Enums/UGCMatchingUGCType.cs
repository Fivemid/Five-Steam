using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Specifies the types of UGC to obtain from a call to
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a>
    /// or
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum UGCMatchingUGCType : int
    {
        /// <summary>Both Microtransaction items and Ready-to-use items.</summary>
        Items = 0,
        /// <summary>
        ///             Microtransaction items. (See:
        ///             <a href="https://partner.steamgames.com/doc/features/workshop#curated_workshop" class="bb_doclink">Curated Workshop</a>)
        ///         </summary>
        Items_Mtx = 1,
        /// <summary>
        ///             Regular in game items that players have uploaded. (See:
        ///             <a href="https://partner.steamgames.com/doc/features/workshop#ready-to-use_workshop" class="bb_doclink">Ready-To-Use Workshop</a>)
        ///         </summary>
        Items_ReadyToUse = 2,
        /// <summary>Shared collections of UGC.</summary>
        Collections = 3,
        /// <summary>Artwork which has been shared.</summary>
        Artwork = 4,
        /// <summary>Videos which have been shared.</summary>
        Videos = 5,
        /// <summary>Screenshots which have been shared.</summary>
        Screenshots = 6,
        /// <summary>Both web guides and integrated guides.</summary>
        AllGuides = 7,
        /// <summary>Guides that are only available on the Steam Community.</summary>
        WebGuides = 8,
        /// <summary>Guides that you can use within your game. (Like Dota 2's in game character guides.)</summary>
        IntegratedGuides = 9,
        /// <summary>Ready-to-use items and integrated guides.</summary>
        UsableInGame = 10,
        /// <summary>Controller Bindings which have been shared.</summary>
        ControllerBindings = 11,
        /// <summary>Game managed items (Not managed by users.)</summary>
        GameManagedItems = 12,
        /// <summary>Return everything.</summary>
        All = -1
    }
}