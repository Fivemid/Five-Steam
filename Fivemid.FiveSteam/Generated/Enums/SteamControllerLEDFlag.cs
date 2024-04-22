using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Controls the color of a Steam Controller Device's LED (if the device indeed has one).<br />
    /// <br />
    /// <b>Notes:</b><br />
    /// The VSC has an LED, but only its brightness will be affected (the color is always white).<br />
    /// The DS4's LED is the lightbar, whose color and brightness can both be configured.<br />
    /// <br />
    /// </summary>
    public enum SteamControllerLEDFlag : int
    {
        /// <summary>Set the color to the specified values</summary>
        SetColor = 0,
        /// <summary>Restore the color to default (out-of-game) settings</summary>
        RestoreUserDefault = 1
    }
}