using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// These values are passed as parameters to the store with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ActivateGameOverlayToStore" class="bb_apilink">ISteamFriends::ActivateGameOverlayToStore</a>
    /// and modify the behavior when the page opens.<br />
    /// <br />
    /// 
    /// </summary>
    public enum OverlayToStoreFlag : int
    {
        /// <summary>No</summary>
        None = 0,
        /// <summary>Deprecated, now works the same as k_EOverlayToStoreFlag_AddToCartAndShow.</summary>
        AddToCart = 1,
        /// <summary>Add the specified app ID to the users cart and show the store page.</summary>
        AddToCartAndShow = 2
    }
}