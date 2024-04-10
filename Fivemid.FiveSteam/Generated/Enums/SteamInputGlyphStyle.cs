using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamInputGlyphStyle</summary>
    public enum SteamInputGlyphStyle : int
    {
        /// <summary>ESteamInputGlyphStyle_Knockout</summary>
        Knockout = 0,
        /// <summary>ESteamInputGlyphStyle_Light</summary>
        Light = 1,
        /// <summary>ESteamInputGlyphStyle_Dark</summary>
        Dark = 2,
        /// <summary>ESteamInputGlyphStyle_NeutralColorABXY</summary>
        NeutralColorABXY = 16,
        /// <summary>ESteamInputGlyphStyle_SolidABXY</summary>
        SolidABXY = 32
    }
}