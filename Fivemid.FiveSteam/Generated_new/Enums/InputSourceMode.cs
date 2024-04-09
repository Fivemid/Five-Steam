using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EInputSourceMode</summary>
    public enum InputSourceMode : int
    {
        /// <summary>k_EInputSourceMode_None</summary>
        None = 0,
        /// <summary>k_EInputSourceMode_Dpad</summary>
        Dpad = 1,
        /// <summary>k_EInputSourceMode_Buttons</summary>
        Buttons = 2,
        /// <summary>k_EInputSourceMode_FourButtons</summary>
        FourButtons = 3,
        /// <summary>k_EInputSourceMode_AbsoluteMouse</summary>
        AbsoluteMouse = 4,
        /// <summary>k_EInputSourceMode_RelativeMouse</summary>
        RelativeMouse = 5,
        /// <summary>k_EInputSourceMode_JoystickMove</summary>
        JoystickMove = 6,
        /// <summary>k_EInputSourceMode_JoystickMouse</summary>
        JoystickMouse = 7,
        /// <summary>k_EInputSourceMode_JoystickCamera</summary>
        JoystickCamera = 8,
        /// <summary>k_EInputSourceMode_ScrollWheel</summary>
        ScrollWheel = 9,
        /// <summary>k_EInputSourceMode_Trigger</summary>
        Trigger = 10,
        /// <summary>k_EInputSourceMode_TouchMenu</summary>
        TouchMenu = 11,
        /// <summary>k_EInputSourceMode_MouseJoystick</summary>
        MouseJoystick = 12,
        /// <summary>k_EInputSourceMode_MouseRegion</summary>
        MouseRegion = 13,
        /// <summary>k_EInputSourceMode_RadialMenu</summary>
        RadialMenu = 14,
        /// <summary>k_EInputSourceMode_SingleButton</summary>
        SingleButton = 15,
        /// <summary>k_EInputSourceMode_Switches</summary>
        Switches = 16
    }
}