using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Inputs the player binds to actions in the Steam Input Configurator. The chief purpose of these
    /// values is to direct which on-screen button glyphs should appear for a given action, such as "Press
    /// [A] to Jump".<br />
    /// <br />
    /// 
    /// </summary>
    public enum ControllerActionOrigin : int
    {
        /// <summary></summary>
        None = 0,
        /// <summary>(Valve Steam Controller) digital face button A</summary>
        A = 1,
        /// <summary>(Valve Steam Controller) digital face button B</summary>
        B = 2,
        /// <summary>(Valve Steam Controller) digital face button X</summary>
        X = 3,
        /// <summary>(Valve Steam Controller) digital face button Y</summary>
        Y = 4,
        /// <summary>(Valve Steam Controller) digital left shoulder button (aka "left bumper")</summary>
        LeftBumper = 5,
        /// <summary>(Valve Steam Controller) digital right shoulder button (aka "right bumper")</summary>
        RightBumper = 6,
        /// <summary>(Valve Steam Controller) digital left grip paddle</summary>
        LeftGrip = 7,
        /// <summary>(Valve Steam Controller) digital right grip paddle</summary>
        RightGrip = 8,
        /// <summary>(Valve Steam Controller) digital start button</summary>
        Start = 9,
        /// <summary>(Valve Steam Controller) digital back button</summary>
        Back = 10,
        /// <summary>(Valve Steam Controller) left haptic touchpad, in simple contact with a finger</summary>
        LeftPad_Touch = 11,
        /// <summary>(Valve Steam Controller) left haptic touchpad, touch input on any axis</summary>
        LeftPad_Swipe = 12,
        /// <summary>(Valve Steam Controller) left haptic touchpad, digital click (for the whole thing)</summary>
        LeftPad_Click = 13,
        /// <summary>(Valve Steam Controller) left haptic touchpad, digital click (upper quadrant)</summary>
        LeftPad_DPadNorth = 14,
        /// <summary>(Valve Steam Controller) left haptic touchpad, digital click (lower quadrant)</summary>
        LeftPad_DPadSouth = 15,
        /// <summary>(Valve Steam Controller) left haptic touchpad, digital click (left quadrant)</summary>
        LeftPad_DPadWest = 16,
        /// <summary>(Valve Steam Controller) left haptic touchpad, digital click (right quadrant)</summary>
        LeftPad_DPadEast = 17,
        /// <summary>(Valve Steam Controller) right haptic touchpad, in simple contact with a finger</summary>
        RightPad_Touch = 18,
        /// <summary>(Valve Steam Controller) right haptic touchpad, touch input on any axis</summary>
        RightPad_Swipe = 19,
        /// <summary>(Valve Steam Controller) right haptic touchpad, digital click (for the whole thing)</summary>
        RightPad_Click = 20,
        /// <summary>(Valve Steam Controller) right haptic touchpad, digital click (upper quadrant)</summary>
        RightPad_DPadNorth = 21,
        /// <summary>(Valve Steam Controller) right haptic touchpad, digital click (lower quadrant)</summary>
        RightPad_DPadSouth = 22,
        /// <summary>(Valve Steam Controller) right haptic touchpad, digital click (left quadrant)</summary>
        RightPad_DPadWest = 23,
        /// <summary>(Valve Steam Controller) right haptic touchpad, digital click (right quadrant)</summary>
        RightPad_DPadEast = 24,
        /// <summary>(Valve Steam Controller) left analog trigger, pulled by any amount (analog value)</summary>
        LeftTrigger_Pull = 25,
        /// <summary>(Valve Steam Controller) left analog trigger, pulled in all the way (digital value)</summary>
        LeftTrigger_Click = 26,
        /// <summary>(Valve Steam Controller) right analog trigger, pulled by any amount (analog value)</summary>
        RightTrigger_Pull = 27,
        /// <summary>
        ///             (Valve Steam Controller) right analog trigger, pulled in all the way (digital value)
        ///         </summary>
        RightTrigger_Click = 28,
        /// <summary>(Valve Steam Controller) left joystick, movement on any axis (analog value)</summary>
        LeftStick_Move = 29,
        /// <summary>(Valve Steam Controller) left joystick, clicked in (digital value)</summary>
        LeftStick_Click = 30,
        /// <summary>(Valve Steam Controller) left joystick, digital movement (upper quadrant)</summary>
        LeftStick_DPadNorth = 31,
        /// <summary>(Valve Steam Controller) left joystick, digital movement (lower quadrant)</summary>
        LeftStick_DPadSouth = 32,
        /// <summary>(Valve Steam Controller) left joystick, digital movement (left quadrant)</summary>
        LeftStick_DPadWest = 33,
        /// <summary>(Valve Steam Controller) left joystick, digital movement (right quadrant)</summary>
        LeftStick_DPadEast = 34,
        /// <summary>(Valve Steam Controller) gyroscope, analog movement in any axis</summary>
        Gyro_Move = 35,
        /// <summary>
        ///             (Valve Steam Controller) gyroscope, analog movement on the Pitch axis (point head up to
        ///             ceiling, point head down to floor)
        ///         </summary>
        Gyro_Pitch = 36,
        /// <summary>
        ///             (Valve Steam Controller) gyroscope, analog movement on the Yaw axis (turn head left to
        ///             face one wall, turn head right to face other)
        ///         </summary>
        Gyro_Yaw = 37,
        /// <summary>
        ///             (Valve Steam Controller) gyroscope, analog movement on the Roll axis (tilt head left
        ///             towards shoulder, tilt head right towards other)
        ///         </summary>
        Gyro_Roll = 38,
        /// <summary>(Sony Dualshock 4) digital face button X</summary>
        PS4_X = 39,
        /// <summary>(Sony Dualshock 4) digital face button Circle</summary>
        PS4_Circle = 40,
        /// <summary>(Sony Dualshock 4) digital face button Triangle</summary>
        PS4_Triangle = 41,
        /// <summary>(Sony Dualshock 4) digital face button Square</summary>
        PS4_Square = 42,
        /// <summary>(Sony Dualshock 4) digital left shoulder button (aka "left bumper")</summary>
        PS4_LeftBumper = 43,
        /// <summary>(Sony Dualshock 4) digital right shoulder button (aka "right bumper")</summary>
        PS4_RightBumper = 44,
        /// <summary>(Sony Dualshock 4) digital options button (aka "Start")</summary>
        PS4_Options = 45,
        /// <summary>(Sony Dualshock 4) digital share button (aka "Back")</summary>
        PS4_Share = 46,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, in simple contact with a finger</summary>
        PS4_LeftPad_Touch = 47,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, touch input on any axis</summary>
        PS4_LeftPad_Swipe = 48,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (for the whole thing)</summary>
        PS4_LeftPad_Click = 49,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (upper quadrant)</summary>
        PS4_LeftPad_DPadNorth = 50,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (lower quadrant)</summary>
        PS4_LeftPad_DPadSouth = 51,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (left quadrant)</summary>
        PS4_LeftPad_DPadWest = 52,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (right quadrant)</summary>
        PS4_LeftPad_DPadEast = 53,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, in simple contact with a finger</summary>
        PS4_RightPad_Touch = 54,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, touch input on any axis</summary>
        PS4_RightPad_Swipe = 55,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (for the whole thing)</summary>
        PS4_RightPad_Click = 56,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (upper quadrant)</summary>
        PS4_RightPad_DPadNorth = 57,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (lower quadrant)</summary>
        PS4_RightPad_DPadSouth = 58,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (left quadrant)</summary>
        PS4_RightPad_DPadWest = 59,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (right quadrant)</summary>
        PS4_RightPad_DPadEast = 60,
        /// <summary>(Sony Dualshock 4) unified touchpad, in simple contact with a finger</summary>
        PS4_CenterPad_Touch = 61,
        /// <summary>(Sony Dualshock 4) unified touchpad, touch input on any axis</summary>
        PS4_CenterPad_Swipe = 62,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (for the whole thing)</summary>
        PS4_CenterPad_Click = 63,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (upper quadrant)</summary>
        PS4_CenterPad_DPadNorth = 64,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (lower quadrant)</summary>
        PS4_CenterPad_DPadSouth = 65,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (left quadrant)</summary>
        PS4_CenterPad_DPadWest = 66,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (right quadrant)</summary>
        PS4_CenterPad_DPadEast = 67,
        /// <summary>(Sony Dualshock 4) left analog trigger, pulled by any amount (analog value)</summary>
        PS4_LeftTrigger_Pull = 68,
        /// <summary>(Sony Dualshock 4) left analog trigger, pulled in all the way (digital value)</summary>
        PS4_LeftTrigger_Click = 69,
        /// <summary>(Sony Dualshock 4) right analog trigger, pulled by any amount (analog value)</summary>
        PS4_RightTrigger_Pull = 70,
        /// <summary>(Sony Dualshock 4) right analog trigger, pulled in all the way (digital value)</summary>
        PS4_RightTrigger_Click = 71,
        /// <summary>(Sony Dualshock 4) left joystick, movement on any axis (analog value)</summary>
        PS4_LeftStick_Move = 72,
        /// <summary>(Sony Dualshock 4) left joystick, clicked in (digital value)</summary>
        PS4_LeftStick_Click = 73,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (upper quadrant)</summary>
        PS4_LeftStick_DPadNorth = 74,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (lower quadrant)</summary>
        PS4_LeftStick_DPadSouth = 75,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (left quadrant)</summary>
        PS4_LeftStick_DPadWest = 76,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (right quadrant)</summary>
        PS4_LeftStick_DPadEast = 77,
        /// <summary>(Sony Dualshock 4) right joystick, movement on any axis (analog value)</summary>
        PS4_RightStick_Move = 78,
        /// <summary>(Sony Dualshock 4) right joystick, clicked in (digital value)</summary>
        PS4_RightStick_Click = 79,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (upper quadrant)</summary>
        PS4_RightStick_DPadNorth = 80,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (lower quadrant)</summary>
        PS4_RightStick_DPadSouth = 81,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (left quadrant)</summary>
        PS4_RightStick_DPadWest = 82,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (right quadrant)</summary>
        PS4_RightStick_DPadEast = 83,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (upper quadrant)</summary>
        PS4_DPad_North = 84,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (lower quadrant)</summary>
        PS4_DPad_South = 85,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (left quadrant)</summary>
        PS4_DPad_West = 86,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (right quadrant)</summary>
        PS4_DPad_East = 87,
        /// <summary>(Sony Dualshock 4) gyroscope, analog movement in any axis</summary>
        PS4_Gyro_Move = 88,
        /// <summary>
        ///             (Sony Dualshock 4) gyroscope, analog movement on the Pitch axis (point head up to
        ///             ceiling, point head down to floor)
        ///         </summary>
        PS4_Gyro_Pitch = 89,
        /// <summary>
        ///             (Sony Dualshock 4) gyroscope, analog movement on the Yaw axis (turn head left to face
        ///             one wall, turn head right to face other)
        ///         </summary>
        PS4_Gyro_Yaw = 90,
        /// <summary>
        ///             (Sony Dualshock 4) gyroscope, analog movement on the Roll axis (tilt head left towards
        ///             shoulder, tilt head right towards other shoulder)
        ///         </summary>
        PS4_Gyro_Roll = 91,
        /// <summary>(XB1) digital face button A</summary>
        XBoxOne_A = 92,
        /// <summary>(XB1) digital face button B</summary>
        XBoxOne_B = 93,
        /// <summary>(XB1) digital face button X</summary>
        XBoxOne_X = 94,
        /// <summary>(XB1) digital face button Y</summary>
        XBoxOne_Y = 95,
        /// <summary>(XB1) digital left shoulder button (aka "left bumper")</summary>
        XBoxOne_LeftBumper = 96,
        /// <summary>(XB1) digital right shoulder button (aka "right bumper")</summary>
        XBoxOne_RightBumper = 97,
        /// <summary>(XB1) digital menu button (aka "start")</summary>
        XBoxOne_Menu = 98,
        /// <summary>(XB1) digital view button (aka "back")</summary>
        XBoxOne_View = 99,
        /// <summary>(XB1) left analog trigger, pulled by any amount (analog value)</summary>
        XBoxOne_LeftTrigger_Pull = 100,
        /// <summary>(XB1) left analog trigger, pulled in all the way (digital value)</summary>
        XBoxOne_LeftTrigger_Click = 101,
        /// <summary>(XB1) right analog trigger, pulled by any amount (analog value)</summary>
        XBoxOne_RightTrigger_Pull = 102,
        /// <summary>(XB1) right analog trigger, pulled in all the way (digital value)</summary>
        XBoxOne_RightTrigger_Click = 103,
        /// <summary>(XB1) left joystick, movement on any axis (analog value)</summary>
        XBoxOne_LeftStick_Move = 104,
        /// <summary>(XB1) left joystick, clicked in (digital value)</summary>
        XBoxOne_LeftStick_Click = 105,
        /// <summary>(XB1) left joystick, digital movement (upper quadrant)</summary>
        XBoxOne_LeftStick_DPadNorth = 106,
        /// <summary>(XB1) left joystick, digital movement (lower quadrant)</summary>
        XBoxOne_LeftStick_DPadSouth = 107,
        /// <summary>(XB1) left joystick, digital movement (left quadrant)</summary>
        XBoxOne_LeftStick_DPadWest = 108,
        /// <summary>(XB1) left joystick, digital movement (right quadrant)</summary>
        XBoxOne_LeftStick_DPadEast = 109,
        /// <summary>(XB1) right joystick, movement on any axis (analog value)</summary>
        XBoxOne_RightStick_Move = 110,
        /// <summary>(XB1) right joystick, clicked in (digital value)</summary>
        XBoxOne_RightStick_Click = 111,
        /// <summary>(XB1) right joystick, digital movement (upper quadrant)</summary>
        XBoxOne_RightStick_DPadNorth = 112,
        /// <summary>(XB1) right joystick, digital movement (lower quadrant)</summary>
        XBoxOne_RightStick_DPadSouth = 113,
        /// <summary>(XB1) right joystick, digital movement (left quadrant)</summary>
        XBoxOne_RightStick_DPadWest = 114,
        /// <summary>(XB1) right joystick, digital movement (right quadrant)</summary>
        XBoxOne_RightStick_DPadEast = 115,
        /// <summary>(XB1) digital pad, pressed (upper quadrant)</summary>
        XBoxOne_DPad_North = 116,
        /// <summary>(XB1) digital pad, pressed (lower quadrant)</summary>
        XBoxOne_DPad_South = 117,
        /// <summary>(XB1) digital pad, pressed (left quadrant)</summary>
        XBoxOne_DPad_West = 118,
        /// <summary>(XB1) digital pad, pressed (right quadrant)</summary>
        XBoxOne_DPad_East = 119,
        /// <summary>(X360) digital face button A</summary>
        XBox360_A = 120,
        /// <summary>(X360) digital face button B</summary>
        XBox360_B = 121,
        /// <summary>(X360) digital face button X</summary>
        XBox360_X = 122,
        /// <summary>(X360) digital face button Y</summary>
        XBox360_Y = 123,
        /// <summary>(X360) digital left shoulder button (aka "left bumper")</summary>
        XBox360_LeftBumper = 124,
        /// <summary>(X360) digital right shoulder button (aka "right bumper")</summary>
        XBox360_RightBumper = 125,
        /// <summary>(X360) digital start button</summary>
        XBox360_Start = 126,
        /// <summary>(X360) digital back button</summary>
        XBox360_Back = 127,
        /// <summary>(X360) left analog trigger, pulled by any amount (analog value)</summary>
        XBox360_LeftTrigger_Pull = 128,
        /// <summary>(X360) left analog trigger, pulled in all the way (digital value)</summary>
        XBox360_LeftTrigger_Click = 129,
        /// <summary>(X360) right analog trigger, pulled by any amount (analog value)</summary>
        XBox360_RightTrigger_Pull = 130,
        /// <summary>(X360) right analog trigger, pulled in all the way (digital value)</summary>
        XBox360_RightTrigger_Click = 131,
        /// <summary>(X360) left joystick, movement on any axis (analog value)</summary>
        XBox360_LeftStick_Move = 132,
        /// <summary>(X360) left joystick, clicked in (digital value)</summary>
        XBox360_LeftStick_Click = 133,
        /// <summary>(X360) left joystick, digital movement (upper quadrant)</summary>
        XBox360_LeftStick_DPadNorth = 134,
        /// <summary>(X360) left joystick, digital movement (lower quadrant)</summary>
        XBox360_LeftStick_DPadSouth = 135,
        /// <summary>(X360) left joystick, digital movement (left quadrant)</summary>
        XBox360_LeftStick_DPadWest = 136,
        /// <summary>(X360) left joystick, digital movement (right quadrant)</summary>
        XBox360_LeftStick_DPadEast = 137,
        /// <summary>(X360) right joystick, movement on any axis (analog value)</summary>
        XBox360_RightStick_Move = 138,
        /// <summary>(X360) right joystick, clicked in (digital value)</summary>
        XBox360_RightStick_Click = 139,
        /// <summary>(X360) right joystick, digital movement (upper quadrant)</summary>
        XBox360_RightStick_DPadNorth = 140,
        /// <summary>(X360) right joystick, digital movement (lower quadrant)</summary>
        XBox360_RightStick_DPadSouth = 141,
        /// <summary>(X360) right joystick, digital movement (left quadrant)</summary>
        XBox360_RightStick_DPadWest = 142,
        /// <summary>(X360) right joystick, digital movement (right quadrant)</summary>
        XBox360_RightStick_DPadEast = 143,
        /// <summary>(X360) digital pad, pressed (upper quadrant)</summary>
        XBox360_DPad_North = 144,
        /// <summary>(X360) digital pad, pressed (lower quadrant)</summary>
        XBox360_DPad_South = 145,
        /// <summary>(X360) digital pad, pressed (left quadrant)</summary>
        XBox360_DPad_West = 146,
        /// <summary>(X360) digital pad, pressed (right quadrant)</summary>
        XBox360_DPad_East = 147,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_A
        SteamV2_A = 148,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_B
        SteamV2_B = 149,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_X
        SteamV2_X = 150,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_Y
        SteamV2_Y = 151,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftBumper
        SteamV2_LeftBumper = 152,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightBumper
        SteamV2_RightBumper = 153,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftGrip_Lower
        SteamV2_LeftGrip_Lower = 154,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftGrip_Upper
        SteamV2_LeftGrip_Upper = 155,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightGrip_Lower
        SteamV2_RightGrip_Lower = 156,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightGrip_Upper
        SteamV2_RightGrip_Upper = 157,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftBumper_Pressure
        SteamV2_LeftBumper_Pressure = 158,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightBumper_Pressure
        SteamV2_RightBumper_Pressure = 159,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftGrip_Pressure
        SteamV2_LeftGrip_Pressure = 160,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightGrip_Pressure
        SteamV2_RightGrip_Pressure = 161,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftGrip_Upper_Pressure
        SteamV2_LeftGrip_Upper_Pressure = 162,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightGrip_Upper_Pressure
        SteamV2_RightGrip_Upper_Pressure = 163,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_Start
        SteamV2_Start = 164,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_Back
        SteamV2_Back = 165,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_Touch
        SteamV2_LeftPad_Touch = 166,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_Swipe
        SteamV2_LeftPad_Swipe = 167,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_Click
        SteamV2_LeftPad_Click = 168,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_Pressure
        SteamV2_LeftPad_Pressure = 169,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_DPadNorth
        SteamV2_LeftPad_DPadNorth = 170,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_DPadSouth
        SteamV2_LeftPad_DPadSouth = 171,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_DPadWest
        SteamV2_LeftPad_DPadWest = 172,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftPad_DPadEast
        SteamV2_LeftPad_DPadEast = 173,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_Touch
        SteamV2_RightPad_Touch = 174,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_Swipe
        SteamV2_RightPad_Swipe = 175,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_Click
        SteamV2_RightPad_Click = 176,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_Pressure
        SteamV2_RightPad_Pressure = 177,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_DPadNorth
        SteamV2_RightPad_DPadNorth = 178,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_DPadSouth
        SteamV2_RightPad_DPadSouth = 179,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_DPadWest
        SteamV2_RightPad_DPadWest = 180,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightPad_DPadEast
        SteamV2_RightPad_DPadEast = 181,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftTrigger_Pull
        SteamV2_LeftTrigger_Pull = 182,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftTrigger_Click
        SteamV2_LeftTrigger_Click = 183,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightTrigger_Pull
        SteamV2_RightTrigger_Pull = 184,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_RightTrigger_Click
        SteamV2_RightTrigger_Click = 185,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftStick_Move
        SteamV2_LeftStick_Move = 186,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftStick_Click
        SteamV2_LeftStick_Click = 187,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftStick_DPadNorth
        SteamV2_LeftStick_DPadNorth = 188,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftStick_DPadSouth
        SteamV2_LeftStick_DPadSouth = 189,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftStick_DPadWest
        SteamV2_LeftStick_DPadWest = 190,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_LeftStick_DPadEast
        SteamV2_LeftStick_DPadEast = 191,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_Gyro_Move
        SteamV2_Gyro_Move = 192,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_Gyro_Pitch
        SteamV2_Gyro_Pitch = 193,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_Gyro_Yaw
        SteamV2_Gyro_Yaw = 194,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamV2_Gyro_Roll
        SteamV2_Gyro_Roll = 195,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_A
        Switch_A = 196,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_B
        Switch_B = 197,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_X
        Switch_X = 198,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_Y
        Switch_Y = 199,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftBumper
        Switch_LeftBumper = 200,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightBumper
        Switch_RightBumper = 201,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_Plus
        Switch_Plus = 202,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_Minus
        Switch_Minus = 203,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_Capture
        Switch_Capture = 204,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftTrigger_Pull
        Switch_LeftTrigger_Pull = 205,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftTrigger_Click
        Switch_LeftTrigger_Click = 206,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightTrigger_Pull
        Switch_RightTrigger_Pull = 207,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightTrigger_Click
        Switch_RightTrigger_Click = 208,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftStick_Move
        Switch_LeftStick_Move = 209,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftStick_Click
        Switch_LeftStick_Click = 210,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftStick_DPadNorth
        Switch_LeftStick_DPadNorth = 211,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftStick_DPadSouth
        Switch_LeftStick_DPadSouth = 212,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftStick_DPadWest
        Switch_LeftStick_DPadWest = 213,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftStick_DPadEast
        Switch_LeftStick_DPadEast = 214,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightStick_Move
        Switch_RightStick_Move = 215,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightStick_Click
        Switch_RightStick_Click = 216,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightStick_DPadNorth
        Switch_RightStick_DPadNorth = 217,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightStick_DPadSouth
        Switch_RightStick_DPadSouth = 218,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightStick_DPadWest
        Switch_RightStick_DPadWest = 219,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightStick_DPadEast
        Switch_RightStick_DPadEast = 220,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_DPad_North
        Switch_DPad_North = 221,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_DPad_South
        Switch_DPad_South = 222,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_DPad_West
        Switch_DPad_West = 223,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_DPad_East
        Switch_DPad_East = 224,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_ProGyro_Move
        Switch_ProGyro_Move = 225,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_ProGyro_Pitch
        Switch_ProGyro_Pitch = 226,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_ProGyro_Yaw
        Switch_ProGyro_Yaw = 227,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_ProGyro_Roll
        Switch_ProGyro_Roll = 228,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightGyro_Move
        Switch_RightGyro_Move = 229,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightGyro_Pitch
        Switch_RightGyro_Pitch = 230,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightGyro_Yaw
        Switch_RightGyro_Yaw = 231,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightGyro_Roll
        Switch_RightGyro_Roll = 232,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftGyro_Move
        Switch_LeftGyro_Move = 233,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftGyro_Pitch
        Switch_LeftGyro_Pitch = 234,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftGyro_Yaw
        Switch_LeftGyro_Yaw = 235,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftGyro_Roll
        Switch_LeftGyro_Roll = 236,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftGrip_Lower
        Switch_LeftGrip_Lower = 237,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_LeftGrip_Upper
        Switch_LeftGrip_Upper = 238,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightGrip_Lower
        Switch_RightGrip_Lower = 239,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_RightGrip_Upper
        Switch_RightGrip_Upper = 240,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS4_DPad_Move
        PS4_DPad_Move = 241,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_XBoxOne_DPad_Move
        XBoxOne_DPad_Move = 242,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_XBox360_DPad_Move
        XBox360_DPad_Move = 243,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_DPad_Move
        Switch_DPad_Move = 244,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_X
        PS5_X = 245,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Circle
        PS5_Circle = 246,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Triangle
        PS5_Triangle = 247,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Square
        PS5_Square = 248,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftBumper
        PS5_LeftBumper = 249,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightBumper
        PS5_RightBumper = 250,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Option
        PS5_Option = 251,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Create
        PS5_Create = 252,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Mute
        PS5_Mute = 253,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftPad_Touch
        PS5_LeftPad_Touch = 254,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftPad_Swipe
        PS5_LeftPad_Swipe = 255,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftPad_Click
        PS5_LeftPad_Click = 256,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftPad_DPadNorth
        PS5_LeftPad_DPadNorth = 257,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftPad_DPadSouth
        PS5_LeftPad_DPadSouth = 258,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftPad_DPadWest
        PS5_LeftPad_DPadWest = 259,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftPad_DPadEast
        PS5_LeftPad_DPadEast = 260,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightPad_Touch
        PS5_RightPad_Touch = 261,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightPad_Swipe
        PS5_RightPad_Swipe = 262,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightPad_Click
        PS5_RightPad_Click = 263,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightPad_DPadNorth
        PS5_RightPad_DPadNorth = 264,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightPad_DPadSouth
        PS5_RightPad_DPadSouth = 265,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightPad_DPadWest
        PS5_RightPad_DPadWest = 266,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightPad_DPadEast
        PS5_RightPad_DPadEast = 267,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_CenterPad_Touch
        PS5_CenterPad_Touch = 268,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_CenterPad_Swipe
        PS5_CenterPad_Swipe = 269,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_CenterPad_Click
        PS5_CenterPad_Click = 270,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_CenterPad_DPadNorth
        PS5_CenterPad_DPadNorth = 271,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_CenterPad_DPadSouth
        PS5_CenterPad_DPadSouth = 272,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_CenterPad_DPadWest
        PS5_CenterPad_DPadWest = 273,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_CenterPad_DPadEast
        PS5_CenterPad_DPadEast = 274,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftTrigger_Pull
        PS5_LeftTrigger_Pull = 275,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftTrigger_Click
        PS5_LeftTrigger_Click = 276,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightTrigger_Pull
        PS5_RightTrigger_Pull = 277,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightTrigger_Click
        PS5_RightTrigger_Click = 278,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftStick_Move
        PS5_LeftStick_Move = 279,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftStick_Click
        PS5_LeftStick_Click = 280,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftStick_DPadNorth
        PS5_LeftStick_DPadNorth = 281,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftStick_DPadSouth
        PS5_LeftStick_DPadSouth = 282,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftStick_DPadWest
        PS5_LeftStick_DPadWest = 283,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftStick_DPadEast
        PS5_LeftStick_DPadEast = 284,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightStick_Move
        PS5_RightStick_Move = 285,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightStick_Click
        PS5_RightStick_Click = 286,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightStick_DPadNorth
        PS5_RightStick_DPadNorth = 287,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightStick_DPadSouth
        PS5_RightStick_DPadSouth = 288,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightStick_DPadWest
        PS5_RightStick_DPadWest = 289,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightStick_DPadEast
        PS5_RightStick_DPadEast = 290,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_DPad_Move
        PS5_DPad_Move = 291,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_DPad_North
        PS5_DPad_North = 292,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_DPad_South
        PS5_DPad_South = 293,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_DPad_West
        PS5_DPad_West = 294,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_DPad_East
        PS5_DPad_East = 295,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Gyro_Move
        PS5_Gyro_Move = 296,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Gyro_Pitch
        PS5_Gyro_Pitch = 297,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Gyro_Yaw
        PS5_Gyro_Yaw = 298,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_Gyro_Roll
        PS5_Gyro_Roll = 299,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_XBoxOne_LeftGrip_Lower
        XBoxOne_LeftGrip_Lower = 300,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_XBoxOne_LeftGrip_Upper
        XBoxOne_LeftGrip_Upper = 301,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_XBoxOne_RightGrip_Lower
        XBoxOne_RightGrip_Lower = 302,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_XBoxOne_RightGrip_Upper
        XBoxOne_RightGrip_Upper = 303,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_XBoxOne_Share
        XBoxOne_Share = 304,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_A
        SteamDeck_A = 305,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_B
        SteamDeck_B = 306,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_X
        SteamDeck_X = 307,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Y
        SteamDeck_Y = 308,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_L1
        SteamDeck_L1 = 309,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_R1
        SteamDeck_R1 = 310,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Menu
        SteamDeck_Menu = 311,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_View
        SteamDeck_View = 312,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftPad_Touch
        SteamDeck_LeftPad_Touch = 313,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftPad_Swipe
        SteamDeck_LeftPad_Swipe = 314,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftPad_Click
        SteamDeck_LeftPad_Click = 315,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftPad_DPadNorth
        SteamDeck_LeftPad_DPadNorth = 316,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftPad_DPadSouth
        SteamDeck_LeftPad_DPadSouth = 317,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftPad_DPadWest
        SteamDeck_LeftPad_DPadWest = 318,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftPad_DPadEast
        SteamDeck_LeftPad_DPadEast = 319,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightPad_Touch
        SteamDeck_RightPad_Touch = 320,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightPad_Swipe
        SteamDeck_RightPad_Swipe = 321,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightPad_Click
        SteamDeck_RightPad_Click = 322,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightPad_DPadNorth
        SteamDeck_RightPad_DPadNorth = 323,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightPad_DPadSouth
        SteamDeck_RightPad_DPadSouth = 324,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightPad_DPadWest
        SteamDeck_RightPad_DPadWest = 325,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightPad_DPadEast
        SteamDeck_RightPad_DPadEast = 326,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_L2_SoftPull
        SteamDeck_L2_SoftPull = 327,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_L2
        SteamDeck_L2 = 328,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_R2_SoftPull
        SteamDeck_R2_SoftPull = 329,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_R2
        SteamDeck_R2 = 330,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftStick_Move
        SteamDeck_LeftStick_Move = 331,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_L3
        SteamDeck_L3 = 332,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftStick_DPadNorth
        SteamDeck_LeftStick_DPadNorth = 333,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftStick_DPadSouth
        SteamDeck_LeftStick_DPadSouth = 334,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftStick_DPadWest
        SteamDeck_LeftStick_DPadWest = 335,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftStick_DPadEast
        SteamDeck_LeftStick_DPadEast = 336,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_LeftStick_Touch
        SteamDeck_LeftStick_Touch = 337,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightStick_Move
        SteamDeck_RightStick_Move = 338,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_R3
        SteamDeck_R3 = 339,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightStick_DPadNorth
        SteamDeck_RightStick_DPadNorth = 340,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightStick_DPadSouth
        SteamDeck_RightStick_DPadSouth = 341,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightStick_DPadWest
        SteamDeck_RightStick_DPadWest = 342,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightStick_DPadEast
        SteamDeck_RightStick_DPadEast = 343,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_RightStick_Touch
        SteamDeck_RightStick_Touch = 344,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_L4
        SteamDeck_L4 = 345,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_R4
        SteamDeck_R4 = 346,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_L5
        SteamDeck_L5 = 347,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_R5
        SteamDeck_R5 = 348,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_DPad_Move
        SteamDeck_DPad_Move = 349,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_DPad_North
        SteamDeck_DPad_North = 350,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_DPad_South
        SteamDeck_DPad_South = 351,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_DPad_West
        SteamDeck_DPad_West = 352,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_DPad_East
        SteamDeck_DPad_East = 353,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Gyro_Move
        SteamDeck_Gyro_Move = 354,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Gyro_Pitch
        SteamDeck_Gyro_Pitch = 355,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Gyro_Yaw
        SteamDeck_Gyro_Yaw = 356,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Gyro_Roll
        SteamDeck_Gyro_Roll = 357,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved1
        SteamDeck_Reserved1 = 358,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved2
        SteamDeck_Reserved2 = 359,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved3
        SteamDeck_Reserved3 = 360,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved4
        SteamDeck_Reserved4 = 361,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved5
        SteamDeck_Reserved5 = 362,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved6
        SteamDeck_Reserved6 = 363,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved7
        SteamDeck_Reserved7 = 364,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved8
        SteamDeck_Reserved8 = 365,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved9
        SteamDeck_Reserved9 = 366,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved10
        SteamDeck_Reserved10 = 367,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved11
        SteamDeck_Reserved11 = 368,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved12
        SteamDeck_Reserved12 = 369,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved13
        SteamDeck_Reserved13 = 370,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved14
        SteamDeck_Reserved14 = 371,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved15
        SteamDeck_Reserved15 = 372,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved16
        SteamDeck_Reserved16 = 373,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved17
        SteamDeck_Reserved17 = 374,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved18
        SteamDeck_Reserved18 = 375,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved19
        SteamDeck_Reserved19 = 376,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_SteamDeck_Reserved20
        SteamDeck_Reserved20 = 377,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_JoyConButton_N
        Switch_JoyConButton_N = 378,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_JoyConButton_E
        Switch_JoyConButton_E = 379,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_JoyConButton_S
        Switch_JoyConButton_S = 380,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_Switch_JoyConButton_W
        Switch_JoyConButton_W = 381,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftGrip
        PS5_LeftGrip = 382,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightGrip
        PS5_RightGrip = 383,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_LeftFn
        PS5_LeftFn = 384,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_PS5_RightFn
        PS5_RightFn = 385,
        /// <summary>The number of values in this enum, useful for iterating.</summary>
        Count = 386,
        /// missing documentation for EControllerActionOrigin.k_EControllerActionOrigin_MaximumPossibleValue
        MaximumPossibleValue = 32767
    }
}