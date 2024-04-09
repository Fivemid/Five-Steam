using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EFloatingGamepadTextInputMode</summary>
    public enum FloatingGamepadTextInputMode : int
    {
        /// <summary>k_EFloatingGamepadTextInputModeModeSingleLine</summary>
        ModeSingleLine = 0,
        /// <summary>k_EFloatingGamepadTextInputModeModeMultipleLines</summary>
        ModeMultipleLines = 1,
        /// <summary>k_EFloatingGamepadTextInputModeModeEmail</summary>
        ModeEmail = 2,
        /// <summary>k_EFloatingGamepadTextInputModeModeNumeric</summary>
        ModeNumeric = 3
    }
}