using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EOverlayToStoreFlag</summary>
    public enum OverlayToStoreFlag : int
    {
        /// <summary>k_EOverlayToStoreFlag_None</summary>
        None = 0,
        /// <summary>k_EOverlayToStoreFlag_AddToCart</summary>
        AddToCart = 1,
        /// <summary>k_EOverlayToStoreFlag_AddToCartAndShow</summary>
        AddToCartAndShow = 2
    }
}