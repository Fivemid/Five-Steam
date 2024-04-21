using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Controls the mode for the floating keyboard<br />
    /// <br />
    /// 
    /// </summary>
    public enum FloatingGamepadTextInputMode : int
    {
        /// <summary>Enter dismisses the keyboard</summary>
        ModeSingleLine = 0,
        /// <summary>User needs to explicitly dismiss the keyboard</summary>
        ModeMultipleLines = 1,
        /// <summary>Keyboard is displayed in a special mode that makes it easier to enter emails</summary>
        ModeEmail = 2,
        /// <summary>Numeric keypad is shown</summary>
        ModeNumeric = 3
    }
}