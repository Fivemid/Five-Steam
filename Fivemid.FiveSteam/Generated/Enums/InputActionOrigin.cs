using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Inputs the player binds to actions in the Steam Input Configurator. The chief purpose of these values is to direct which on-screen button glyphs should appear for a given action, such as "Press [A] to Jump".<br />
    /// <br />
    /// </summary>
    public enum InputActionOrigin : int
    {
        /// <summary></summary>
        None = 0,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_A
        SteamController_A = 1,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_B
        SteamController_B = 2,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_X
        SteamController_X = 3,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_Y
        SteamController_Y = 4,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftBumper
        SteamController_LeftBumper = 5,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightBumper
        SteamController_RightBumper = 6,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftGrip
        SteamController_LeftGrip = 7,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightGrip
        SteamController_RightGrip = 8,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_Start
        SteamController_Start = 9,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_Back
        SteamController_Back = 10,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftPad_Touch
        SteamController_LeftPad_Touch = 11,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftPad_Swipe
        SteamController_LeftPad_Swipe = 12,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftPad_Click
        SteamController_LeftPad_Click = 13,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftPad_DPadNorth
        SteamController_LeftPad_DPadNorth = 14,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftPad_DPadSouth
        SteamController_LeftPad_DPadSouth = 15,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftPad_DPadWest
        SteamController_LeftPad_DPadWest = 16,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftPad_DPadEast
        SteamController_LeftPad_DPadEast = 17,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightPad_Touch
        SteamController_RightPad_Touch = 18,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightPad_Swipe
        SteamController_RightPad_Swipe = 19,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightPad_Click
        SteamController_RightPad_Click = 20,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightPad_DPadNorth
        SteamController_RightPad_DPadNorth = 21,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightPad_DPadSouth
        SteamController_RightPad_DPadSouth = 22,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightPad_DPadWest
        SteamController_RightPad_DPadWest = 23,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightPad_DPadEast
        SteamController_RightPad_DPadEast = 24,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftTrigger_Pull
        SteamController_LeftTrigger_Pull = 25,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftTrigger_Click
        SteamController_LeftTrigger_Click = 26,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightTrigger_Pull
        SteamController_RightTrigger_Pull = 27,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_RightTrigger_Click
        SteamController_RightTrigger_Click = 28,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftStick_Move
        SteamController_LeftStick_Move = 29,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftStick_Click
        SteamController_LeftStick_Click = 30,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftStick_DPadNorth
        SteamController_LeftStick_DPadNorth = 31,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftStick_DPadSouth
        SteamController_LeftStick_DPadSouth = 32,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftStick_DPadWest
        SteamController_LeftStick_DPadWest = 33,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_LeftStick_DPadEast
        SteamController_LeftStick_DPadEast = 34,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_Gyro_Move
        SteamController_Gyro_Move = 35,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_Gyro_Pitch
        SteamController_Gyro_Pitch = 36,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_Gyro_Yaw
        SteamController_Gyro_Yaw = 37,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamController_Gyro_Roll
        SteamController_Gyro_Roll = 38,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved0 = 39,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved1 = 40,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved2 = 41,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved3 = 42,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved4 = 43,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved5 = 44,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved6 = 45,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved7 = 46,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved8 = 47,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved9 = 48,
        /// <summary>Reserved for future use</summary>
        SteamController_Reserved10 = 49,
        /// <summary>(Sony Dualshock 4) digital face button X</summary>
        PS4_X = 50,
        /// <summary>(Sony Dualshock 4) digital face button Circle</summary>
        PS4_Circle = 51,
        /// <summary>(Sony Dualshock 4) digital face button Triangle</summary>
        PS4_Triangle = 52,
        /// <summary>(Sony Dualshock 4) digital face button Square</summary>
        PS4_Square = 53,
        /// <summary>(Sony Dualshock 4) digital left shoulder button (aka left bumper)</summary>
        PS4_LeftBumper = 54,
        /// <summary>(Sony Dualshock 4) digital right shoulder button (aka right bumper)</summary>
        PS4_RightBumper = 55,
        /// <summary>(Sony Dualshock 4) digital options button (aka Start)</summary>
        PS4_Options = 56,
        /// <summary>(Sony Dualshock 4) digital share button (aka Back)</summary>
        PS4_Share = 57,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, in simple contact with a finger</summary>
        PS4_LeftPad_Touch = 58,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, touch input on any axis</summary>
        PS4_LeftPad_Swipe = 59,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (for the whole thing)</summary>
        PS4_LeftPad_Click = 60,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (upper quadrant)</summary>
        PS4_LeftPad_DPadNorth = 61,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (lower quadrant)</summary>
        PS4_LeftPad_DPadSouth = 62,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (left quadrant)</summary>
        PS4_LeftPad_DPadWest = 63,
        /// <summary>(Sony Dualshock 4) left half of the touchpad, digital click (right quadrant)</summary>
        PS4_LeftPad_DPadEast = 64,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, in simple contact with a finger</summary>
        PS4_RightPad_Touch = 65,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, touch input on any axis</summary>
        PS4_RightPad_Swipe = 66,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (for the whole thing)</summary>
        PS4_RightPad_Click = 67,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (upper quadrant)</summary>
        PS4_RightPad_DPadNorth = 68,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (lower quadrant)</summary>
        PS4_RightPad_DPadSouth = 69,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (left quadrant)</summary>
        PS4_RightPad_DPadWest = 70,
        /// <summary>(Sony Dualshock 4) right half of the touchpad, digital click (right quadrant)</summary>
        PS4_RightPad_DPadEast = 71,
        /// <summary>(Sony Dualshock 4) unified touchpad, in simple contact with a finger</summary>
        PS4_CenterPad_Touch = 72,
        /// <summary>(Sony Dualshock 4) unified touchpad, touch input on any axis</summary>
        PS4_CenterPad_Swipe = 73,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (for the whole thing)</summary>
        PS4_CenterPad_Click = 74,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (upper quadrant)</summary>
        PS4_CenterPad_DPadNorth = 75,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (lower quadrant)</summary>
        PS4_CenterPad_DPadSouth = 76,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (left quadrant)</summary>
        PS4_CenterPad_DPadWest = 77,
        /// <summary>(Sony Dualshock 4) unified touchpad, digital click (right quadrant)</summary>
        PS4_CenterPad_DPadEast = 78,
        /// <summary>(Sony Dualshock 4) left analog trigger, pulled by any amount (analog value)</summary>
        PS4_LeftTrigger_Pull = 79,
        /// <summary>(Sony Dualshock 4) left analog trigger, pulled in all the way (digital value)</summary>
        PS4_LeftTrigger_Click = 80,
        /// <summary>(Sony Dualshock 4) right analog trigger, pulled by any amount (analog value)</summary>
        PS4_RightTrigger_Pull = 81,
        /// <summary>(Sony Dualshock 4) right analog trigger, pulled in all the way (digital value)</summary>
        PS4_RightTrigger_Click = 82,
        /// <summary>(Sony Dualshock 4) left joystick, movement on any axis (analog value)</summary>
        PS4_LeftStick_Move = 83,
        /// <summary>(Sony Dualshock 4) left joystick, clicked in (digital value)</summary>
        PS4_LeftStick_Click = 84,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (upper quadrant)</summary>
        PS4_LeftStick_DPadNorth = 85,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (lower quadrant)</summary>
        PS4_LeftStick_DPadSouth = 86,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (left quadrant)</summary>
        PS4_LeftStick_DPadWest = 87,
        /// <summary>(Sony Dualshock 4) left joystick, digital movement (right quadrant)</summary>
        PS4_LeftStick_DPadEast = 88,
        /// <summary>(Sony Dualshock 4) right joystick, movement on any axis (analog value)</summary>
        PS4_RightStick_Move = 89,
        /// <summary>(Sony Dualshock 4) right joystick, clicked in (digital value)</summary>
        PS4_RightStick_Click = 90,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (upper quadrant)</summary>
        PS4_RightStick_DPadNorth = 91,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (lower quadrant)</summary>
        PS4_RightStick_DPadSouth = 92,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (left quadrant)</summary>
        PS4_RightStick_DPadWest = 93,
        /// <summary>(Sony Dualshock 4) right joystick, digital movement (right quadrant)</summary>
        PS4_RightStick_DPadEast = 94,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (upper quadrant)</summary>
        PS4_DPad_North = 95,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (lower quadrant)</summary>
        PS4_DPad_South = 96,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (left quadrant)</summary>
        PS4_DPad_West = 97,
        /// <summary>(Sony Dualshock 4) digital pad, pressed (right quadrant)</summary>
        PS4_DPad_East = 98,
        /// <summary>(Sony Dualshock 4) gyroscope, analog movement in any axis</summary>
        PS4_Gyro_Move = 99,
        /// <summary>(Sony Dualshock 4) gyroscope, analog movement on the Pitch axis (point head up to ceiling, point head down to floor)</summary>
        PS4_Gyro_Pitch = 100,
        /// <summary>(Sony Dualshock 4) gyroscope, analog movement on the Yaw axis (turn head left to face one wall, turn head right to face other)</summary>
        PS4_Gyro_Yaw = 101,
        /// <summary>(Sony Dualshock 4) gyroscope, analog movement on the Roll axis (tilt head left towards shoulder, tilt head right towards other shoulder)</summary>
        PS4_Gyro_Roll = 102,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS4_DPad_Move
        PS4_DPad_Move = 103,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved1 = 104,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved2 = 105,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved3 = 106,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved4 = 107,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved5 = 108,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved6 = 109,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved7 = 110,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved8 = 111,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved9 = 112,
        /// <summary>Reserved for future use</summary>
        PS4_Reserved10 = 113,
        /// <summary>(XB1) digital face button A</summary>
        XBoxOne_A = 114,
        /// <summary>(XB1) digital face button B</summary>
        XBoxOne_B = 115,
        /// <summary>(XB1) digital face button Cross</summary>
        XBoxOne_X = 116,
        /// <summary>(XB1) digital face button Y</summary>
        XBoxOne_Y = 117,
        /// <summary>(XB1) digital left shoulder button (aka left bumper)</summary>
        XBoxOne_LeftBumper = 118,
        /// <summary>(XB1) digital right shoulder button (aka right bumper)</summary>
        XBoxOne_RightBumper = 119,
        /// <summary>(XB1) digital menu button (aka start)</summary>
        XBoxOne_Menu = 120,
        /// <summary>(XB1) digital view button (aka back)</summary>
        XBoxOne_View = 121,
        /// <summary>(XB1) left analog trigger, pulled by any amount (analog value)</summary>
        XBoxOne_LeftTrigger_Pull = 122,
        /// <summary>(XB1) left analog trigger, pulled in all the way (digital value)</summary>
        XBoxOne_LeftTrigger_Click = 123,
        /// <summary>(XB1) right analog trigger, pulled by any amount (analog value)</summary>
        XBoxOne_RightTrigger_Pull = 124,
        /// <summary>(XB1) right analog trigger, pulled in all the way (digital value)</summary>
        XBoxOne_RightTrigger_Click = 125,
        /// <summary>(XB1) left joystick, movement on any axis (analog value)</summary>
        XBoxOne_LeftStick_Move = 126,
        /// <summary>(XB1) left joystick, clicked in (digital value)</summary>
        XBoxOne_LeftStick_Click = 127,
        /// <summary>(XB1) left joystick, digital movement (upper quadrant)</summary>
        XBoxOne_LeftStick_DPadNorth = 128,
        /// <summary>(XB1) left joystick, digital movement (lower quadrant)</summary>
        XBoxOne_LeftStick_DPadSouth = 129,
        /// <summary>(XB1) left joystick, digital movement (left quadrant)</summary>
        XBoxOne_LeftStick_DPadWest = 130,
        /// <summary>(XB1) left joystick, digital movement (right quadrant)</summary>
        XBoxOne_LeftStick_DPadEast = 131,
        /// <summary>(XB1) right joystick, movement on any axis (analog value)</summary>
        XBoxOne_RightStick_Move = 132,
        /// <summary>(XB1) right joystick, clicked in (digital value)</summary>
        XBoxOne_RightStick_Click = 133,
        /// <summary>(XB1) right joystick, digital movement (upper quadrant)</summary>
        XBoxOne_RightStick_DPadNorth = 134,
        /// <summary>(XB1) right joystick, digital movement (lower quadrant)</summary>
        XBoxOne_RightStick_DPadSouth = 135,
        /// <summary>(XB1) right joystick, digital movement (left quadrant)</summary>
        XBoxOne_RightStick_DPadWest = 136,
        /// <summary>(XB1) right joystick, digital movement (right quadrant)</summary>
        XBoxOne_RightStick_DPadEast = 137,
        /// <summary>(XB1) digital pad, pressed (upper quadrant)</summary>
        XBoxOne_DPad_North = 138,
        /// <summary>(XB1) digital pad, pressed (lower quadrant)</summary>
        XBoxOne_DPad_South = 139,
        /// <summary>(XB1) digital pad, pressed (left quadrant)</summary>
        XBoxOne_DPad_West = 140,
        /// <summary>(XB1) digital pad, pressed (right quadrant)</summary>
        XBoxOne_DPad_East = 141,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_XBoxOne_DPad_Move
        XBoxOne_DPad_Move = 142,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_XBoxOne_LeftGrip_Lower
        XBoxOne_LeftGrip_Lower = 143,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_XBoxOne_LeftGrip_Upper
        XBoxOne_LeftGrip_Upper = 144,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_XBoxOne_RightGrip_Lower
        XBoxOne_RightGrip_Lower = 145,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_XBoxOne_RightGrip_Upper
        XBoxOne_RightGrip_Upper = 146,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_XBoxOne_Share
        XBoxOne_Share = 147,
        /// <summary>Reserved for future use</summary>
        XBoxOne_Reserved6 = 148,
        /// <summary>Reserved for future use</summary>
        XBoxOne_Reserved7 = 149,
        /// <summary>Reserved for future use</summary>
        XBoxOne_Reserved8 = 150,
        /// <summary>Reserved for future use</summary>
        XBoxOne_Reserved9 = 151,
        /// <summary>Reserved for future use</summary>
        XBoxOne_Reserved10 = 152,
        /// <summary>(X360) digital face button A</summary>
        XBox360_A = 153,
        /// <summary>(X360) digital face button B</summary>
        XBox360_B = 154,
        /// <summary>(X360) digital face button X</summary>
        XBox360_X = 155,
        /// <summary>(X360) digital face button Y</summary>
        XBox360_Y = 156,
        /// <summary>(X360) digital left shoulder button (aka left bumper)</summary>
        XBox360_LeftBumper = 157,
        /// <summary>(X360) digital right shoulder button (aka right bumper)</summary>
        XBox360_RightBumper = 158,
        /// <summary>(X360) digital start button</summary>
        XBox360_Start = 159,
        /// <summary>(X360) digital back button</summary>
        XBox360_Back = 160,
        /// <summary>(X360) left analog trigger, pulled by any amount (analog value)</summary>
        XBox360_LeftTrigger_Pull = 161,
        /// <summary>(X360) left analog trigger, pulled in all the way (digital value)</summary>
        XBox360_LeftTrigger_Click = 162,
        /// <summary>(X360) right analog trigger, pulled by any amount (analog value)</summary>
        XBox360_RightTrigger_Pull = 163,
        /// <summary>(X360) right analog trigger, pulled in all the way (digital value)</summary>
        XBox360_RightTrigger_Click = 164,
        /// <summary>(X360) left joystick, movement on any axis (analog value)</summary>
        XBox360_LeftStick_Move = 165,
        /// <summary>(X360) left joystick, clicked in (digital value)</summary>
        XBox360_LeftStick_Click = 166,
        /// <summary>(X360) left joystick, digital movement (upper quadrant)</summary>
        XBox360_LeftStick_DPadNorth = 167,
        /// <summary>(X360) left joystick, digital movement (lower quadrant)</summary>
        XBox360_LeftStick_DPadSouth = 168,
        /// <summary>(X360) left joystick, digital movement (left quadrant)</summary>
        XBox360_LeftStick_DPadWest = 169,
        /// <summary>(X360) left joystick, digital movement (right quadrant)</summary>
        XBox360_LeftStick_DPadEast = 170,
        /// <summary>(X360) right joystick, movement on any axis (analog value)</summary>
        XBox360_RightStick_Move = 171,
        /// <summary>(X360) right joystick, clicked in (digital value)</summary>
        XBox360_RightStick_Click = 172,
        /// <summary>(X360) right joystick, digital movement (upper quadrant)</summary>
        XBox360_RightStick_DPadNorth = 173,
        /// <summary>(X360) right joystick, digital movement (lower quadrant)</summary>
        XBox360_RightStick_DPadSouth = 174,
        /// <summary>(X360) right joystick, digital movement (left quadrant)</summary>
        XBox360_RightStick_DPadWest = 175,
        /// <summary>(X360) right joystick, digital movement (right quadrant)</summary>
        XBox360_RightStick_DPadEast = 176,
        /// <summary>(X360) digital pad, pressed (upper quadrant)</summary>
        XBox360_DPad_North = 177,
        /// <summary>(X360) digital pad, pressed (lower quadrant)</summary>
        XBox360_DPad_South = 178,
        /// <summary>(X360) digital pad, pressed (left quadrant)</summary>
        XBox360_DPad_West = 179,
        /// <summary>(X360) digital pad, pressed (right quadrant)</summary>
        XBox360_DPad_East = 180,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_XBox360_DPad_Move
        XBox360_DPad_Move = 181,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved1 = 182,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved2 = 183,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved3 = 184,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved4 = 185,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved5 = 186,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved6 = 187,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved7 = 188,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved8 = 189,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved9 = 190,
        /// <summary>Reserved for future use</summary>
        XBox360_Reserved10 = 191,
        /// <summary>(Nintendo Switch Pro) digital face button A</summary>
        Switch_A = 192,
        /// <summary>(Nintendo Switch Pro) digital face button B</summary>
        Switch_B = 193,
        /// <summary>(Nintendo Switch Pro) digital face button X</summary>
        Switch_X = 194,
        /// <summary>(Nintendo Switch Pro) digital face button Y</summary>
        Switch_Y = 195,
        /// <summary>(Nintendo Switch Pro) digital left shoulder button (aka left bumper)</summary>
        Switch_LeftBumper = 196,
        /// <summary>(Nintendo Switch Pro) digital right shoulder button (aka right bumper)</summary>
        Switch_RightBumper = 197,
        /// <summary>(Nintendo Switch Pro) plus button</summary>
        Switch_Plus = 198,
        /// <summary>(Nintendo Switch Pro) minus button</summary>
        Switch_Minus = 199,
        /// <summary>(Nintendo Switch Pro) digital capture button</summary>
        Switch_Capture = 200,
        /// <summary>(Nintendo Switch Pro) left trigger, clicked</summary>
        Switch_LeftTrigger_Pull = 201,
        /// <summary>(Nintendo Switch Pro) left trigger, clicked (same as previous value)</summary>
        Switch_LeftTrigger_Click = 202,
        /// <summary>(Nintendo Switch Pro) right trigger, clicked</summary>
        Switch_RightTrigger_Pull = 203,
        /// <summary>(Nintendo Switch Pro) right trigger, clicked (same as previous value)</summary>
        Switch_RightTrigger_Click = 204,
        /// <summary>(Nintendo Switch Pro) left joystick, movement on any axis (analog value)</summary>
        Switch_LeftStick_Move = 205,
        /// <summary>(Nintendo Switch Pro) left joystick, clicked in (digital value)</summary>
        Switch_LeftStick_Click = 206,
        /// <summary>(Nintendo Switch Pro) left joystick, digital movement (upper quadrant)</summary>
        Switch_LeftStick_DPadNorth = 207,
        /// <summary>(Nintendo Switch Pro) left joystick, digital movement (lower quadrant)</summary>
        Switch_LeftStick_DPadSouth = 208,
        /// <summary>(Nintendo Switch Pro) left joystick, digital movement (left quadrant)</summary>
        Switch_LeftStick_DPadWest = 209,
        /// <summary>(Nintendo Switch Pro) left joystick, digital movement (right quadrant)</summary>
        Switch_LeftStick_DPadEast = 210,
        /// <summary>(Nintendo Switch Pro) right joystick, movement on any axis (analog value)</summary>
        Switch_RightStick_Move = 211,
        /// <summary>(Nintendo Switch Pro) right joystick, clicked in (digital value)</summary>
        Switch_RightStick_Click = 212,
        /// <summary>(Nintendo Switch Pro) right joystick, digital movement (upper quadrant)</summary>
        Switch_RightStick_DPadNorth = 213,
        /// <summary>(Nintendo Switch Pro) right joystick, digital movement (lower quadrant)</summary>
        Switch_RightStick_DPadSouth = 214,
        /// <summary>(Nintendo Switch Pro) right joystick, digital movement (left quadrant)</summary>
        Switch_RightStick_DPadWest = 215,
        /// <summary>(Nintendo Switch Pro) right joystick, digital movement (right quadrant)</summary>
        Switch_RightStick_DPadEast = 216,
        /// <summary>(Nintendo Switch Pro) digital pad, pressed (upper quadrant)</summary>
        Switch_DPad_North = 217,
        /// <summary>(Nintendo Switch Pro) digital pad, pressed (lower quadrant)</summary>
        Switch_DPad_South = 218,
        /// <summary>(Nintendo Switch Pro) digital pad, pressed (left quadrant)</summary>
        Switch_DPad_West = 219,
        /// <summary>(Nintendo Switch Pro) digital pad, pressed (right quadrant)</summary>
        Switch_DPad_East = 220,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_ProGyro_Move
        Switch_ProGyro_Move = 221,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_ProGyro_Pitch
        Switch_ProGyro_Pitch = 222,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_ProGyro_Yaw
        Switch_ProGyro_Yaw = 223,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_ProGyro_Roll
        Switch_ProGyro_Roll = 224,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_DPad_Move
        Switch_DPad_Move = 225,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved1 = 226,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved2 = 227,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved3 = 228,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved4 = 229,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved5 = 230,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved6 = 231,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved7 = 232,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved8 = 233,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved9 = 234,
        /// <summary>Reserved for future use</summary>
        Switch_Reserved10 = 235,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_RightGyro_Move
        Switch_RightGyro_Move = 236,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_RightGyro_Pitch
        Switch_RightGyro_Pitch = 237,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_RightGyro_Yaw
        Switch_RightGyro_Yaw = 238,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_RightGyro_Roll
        Switch_RightGyro_Roll = 239,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_LeftGyro_Move
        Switch_LeftGyro_Move = 240,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_LeftGyro_Pitch
        Switch_LeftGyro_Pitch = 241,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_LeftGyro_Yaw
        Switch_LeftGyro_Yaw = 242,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_LeftGyro_Roll
        Switch_LeftGyro_Roll = 243,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_LeftGrip_Lower
        Switch_LeftGrip_Lower = 244,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_LeftGrip_Upper
        Switch_LeftGrip_Upper = 245,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_RightGrip_Lower
        Switch_RightGrip_Lower = 246,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_RightGrip_Upper
        Switch_RightGrip_Upper = 247,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_JoyConButton_N
        Switch_JoyConButton_N = 248,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_JoyConButton_E
        Switch_JoyConButton_E = 249,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_JoyConButton_S
        Switch_JoyConButton_S = 250,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_JoyConButton_W
        Switch_JoyConButton_W = 251,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_Reserved15
        Switch_Reserved15 = 252,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_Reserved16
        Switch_Reserved16 = 253,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_Reserved17
        Switch_Reserved17 = 254,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_Reserved18
        Switch_Reserved18 = 255,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_Reserved19
        Switch_Reserved19 = 256,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_Switch_Reserved20
        Switch_Reserved20 = 257,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_X
        PS5_X = 258,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Circle
        PS5_Circle = 259,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Triangle
        PS5_Triangle = 260,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Square
        PS5_Square = 261,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftBumper
        PS5_LeftBumper = 262,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightBumper
        PS5_RightBumper = 263,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Option
        PS5_Option = 264,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Create
        PS5_Create = 265,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Mute
        PS5_Mute = 266,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftPad_Touch
        PS5_LeftPad_Touch = 267,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftPad_Swipe
        PS5_LeftPad_Swipe = 268,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftPad_Click
        PS5_LeftPad_Click = 269,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftPad_DPadNorth
        PS5_LeftPad_DPadNorth = 270,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftPad_DPadSouth
        PS5_LeftPad_DPadSouth = 271,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftPad_DPadWest
        PS5_LeftPad_DPadWest = 272,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftPad_DPadEast
        PS5_LeftPad_DPadEast = 273,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightPad_Touch
        PS5_RightPad_Touch = 274,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightPad_Swipe
        PS5_RightPad_Swipe = 275,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightPad_Click
        PS5_RightPad_Click = 276,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightPad_DPadNorth
        PS5_RightPad_DPadNorth = 277,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightPad_DPadSouth
        PS5_RightPad_DPadSouth = 278,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightPad_DPadWest
        PS5_RightPad_DPadWest = 279,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightPad_DPadEast
        PS5_RightPad_DPadEast = 280,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_CenterPad_Touch
        PS5_CenterPad_Touch = 281,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_CenterPad_Swipe
        PS5_CenterPad_Swipe = 282,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_CenterPad_Click
        PS5_CenterPad_Click = 283,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_CenterPad_DPadNorth
        PS5_CenterPad_DPadNorth = 284,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_CenterPad_DPadSouth
        PS5_CenterPad_DPadSouth = 285,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_CenterPad_DPadWest
        PS5_CenterPad_DPadWest = 286,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_CenterPad_DPadEast
        PS5_CenterPad_DPadEast = 287,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftTrigger_Pull
        PS5_LeftTrigger_Pull = 288,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftTrigger_Click
        PS5_LeftTrigger_Click = 289,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightTrigger_Pull
        PS5_RightTrigger_Pull = 290,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightTrigger_Click
        PS5_RightTrigger_Click = 291,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftStick_Move
        PS5_LeftStick_Move = 292,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftStick_Click
        PS5_LeftStick_Click = 293,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftStick_DPadNorth
        PS5_LeftStick_DPadNorth = 294,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftStick_DPadSouth
        PS5_LeftStick_DPadSouth = 295,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftStick_DPadWest
        PS5_LeftStick_DPadWest = 296,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftStick_DPadEast
        PS5_LeftStick_DPadEast = 297,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightStick_Move
        PS5_RightStick_Move = 298,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightStick_Click
        PS5_RightStick_Click = 299,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightStick_DPadNorth
        PS5_RightStick_DPadNorth = 300,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightStick_DPadSouth
        PS5_RightStick_DPadSouth = 301,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightStick_DPadWest
        PS5_RightStick_DPadWest = 302,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightStick_DPadEast
        PS5_RightStick_DPadEast = 303,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_DPad_North
        PS5_DPad_North = 304,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_DPad_South
        PS5_DPad_South = 305,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_DPad_West
        PS5_DPad_West = 306,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_DPad_East
        PS5_DPad_East = 307,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Gyro_Move
        PS5_Gyro_Move = 308,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Gyro_Pitch
        PS5_Gyro_Pitch = 309,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Gyro_Yaw
        PS5_Gyro_Yaw = 310,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Gyro_Roll
        PS5_Gyro_Roll = 311,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_DPad_Move
        PS5_DPad_Move = 312,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftGrip
        PS5_LeftGrip = 313,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightGrip
        PS5_RightGrip = 314,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_LeftFn
        PS5_LeftFn = 315,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_RightFn
        PS5_RightFn = 316,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved5
        PS5_Reserved5 = 317,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved6
        PS5_Reserved6 = 318,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved7
        PS5_Reserved7 = 319,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved8
        PS5_Reserved8 = 320,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved9
        PS5_Reserved9 = 321,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved10
        PS5_Reserved10 = 322,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved11
        PS5_Reserved11 = 323,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved12
        PS5_Reserved12 = 324,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved13
        PS5_Reserved13 = 325,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved14
        PS5_Reserved14 = 326,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved15
        PS5_Reserved15 = 327,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved16
        PS5_Reserved16 = 328,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved17
        PS5_Reserved17 = 329,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved18
        PS5_Reserved18 = 330,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved19
        PS5_Reserved19 = 331,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_PS5_Reserved20
        PS5_Reserved20 = 332,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_A
        SteamDeck_A = 333,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_B
        SteamDeck_B = 334,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_X
        SteamDeck_X = 335,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Y
        SteamDeck_Y = 336,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_L1
        SteamDeck_L1 = 337,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_R1
        SteamDeck_R1 = 338,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Menu
        SteamDeck_Menu = 339,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_View
        SteamDeck_View = 340,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftPad_Touch
        SteamDeck_LeftPad_Touch = 341,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftPad_Swipe
        SteamDeck_LeftPad_Swipe = 342,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftPad_Click
        SteamDeck_LeftPad_Click = 343,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftPad_DPadNorth
        SteamDeck_LeftPad_DPadNorth = 344,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftPad_DPadSouth
        SteamDeck_LeftPad_DPadSouth = 345,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftPad_DPadWest
        SteamDeck_LeftPad_DPadWest = 346,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftPad_DPadEast
        SteamDeck_LeftPad_DPadEast = 347,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightPad_Touch
        SteamDeck_RightPad_Touch = 348,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightPad_Swipe
        SteamDeck_RightPad_Swipe = 349,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightPad_Click
        SteamDeck_RightPad_Click = 350,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightPad_DPadNorth
        SteamDeck_RightPad_DPadNorth = 351,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightPad_DPadSouth
        SteamDeck_RightPad_DPadSouth = 352,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightPad_DPadWest
        SteamDeck_RightPad_DPadWest = 353,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightPad_DPadEast
        SteamDeck_RightPad_DPadEast = 354,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_L2_SoftPull
        SteamDeck_L2_SoftPull = 355,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_L2
        SteamDeck_L2 = 356,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_R2_SoftPull
        SteamDeck_R2_SoftPull = 357,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_R2
        SteamDeck_R2 = 358,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftStick_Move
        SteamDeck_LeftStick_Move = 359,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_L3
        SteamDeck_L3 = 360,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftStick_DPadNorth
        SteamDeck_LeftStick_DPadNorth = 361,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftStick_DPadSouth
        SteamDeck_LeftStick_DPadSouth = 362,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftStick_DPadWest
        SteamDeck_LeftStick_DPadWest = 363,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftStick_DPadEast
        SteamDeck_LeftStick_DPadEast = 364,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_LeftStick_Touch
        SteamDeck_LeftStick_Touch = 365,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightStick_Move
        SteamDeck_RightStick_Move = 366,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_R3
        SteamDeck_R3 = 367,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightStick_DPadNorth
        SteamDeck_RightStick_DPadNorth = 368,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightStick_DPadSouth
        SteamDeck_RightStick_DPadSouth = 369,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightStick_DPadWest
        SteamDeck_RightStick_DPadWest = 370,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightStick_DPadEast
        SteamDeck_RightStick_DPadEast = 371,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_RightStick_Touch
        SteamDeck_RightStick_Touch = 372,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_L4
        SteamDeck_L4 = 373,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_R4
        SteamDeck_R4 = 374,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_L5
        SteamDeck_L5 = 375,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_R5
        SteamDeck_R5 = 376,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_DPad_Move
        SteamDeck_DPad_Move = 377,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_DPad_North
        SteamDeck_DPad_North = 378,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_DPad_South
        SteamDeck_DPad_South = 379,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_DPad_West
        SteamDeck_DPad_West = 380,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_DPad_East
        SteamDeck_DPad_East = 381,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Gyro_Move
        SteamDeck_Gyro_Move = 382,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Gyro_Pitch
        SteamDeck_Gyro_Pitch = 383,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Gyro_Yaw
        SteamDeck_Gyro_Yaw = 384,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Gyro_Roll
        SteamDeck_Gyro_Roll = 385,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved1
        SteamDeck_Reserved1 = 386,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved2
        SteamDeck_Reserved2 = 387,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved3
        SteamDeck_Reserved3 = 388,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved4
        SteamDeck_Reserved4 = 389,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved5
        SteamDeck_Reserved5 = 390,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved6
        SteamDeck_Reserved6 = 391,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved7
        SteamDeck_Reserved7 = 392,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved8
        SteamDeck_Reserved8 = 393,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved9
        SteamDeck_Reserved9 = 394,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved10
        SteamDeck_Reserved10 = 395,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved11
        SteamDeck_Reserved11 = 396,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved12
        SteamDeck_Reserved12 = 397,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved13
        SteamDeck_Reserved13 = 398,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved14
        SteamDeck_Reserved14 = 399,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved15
        SteamDeck_Reserved15 = 400,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved16
        SteamDeck_Reserved16 = 401,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved17
        SteamDeck_Reserved17 = 402,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved18
        SteamDeck_Reserved18 = 403,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved19
        SteamDeck_Reserved19 = 404,
        /// missing documentation for EInputActionOrigin.k_EInputActionOrigin_SteamDeck_Reserved20
        SteamDeck_Reserved20 = 405,
        /// <summary>The number of values in this enum, useful for iterating.</summary>
        Count = 406,
        /// <summary>The number of values in this enum, useful for iterating.</summary>
        MaximumPossibleValue = 32767
    }
}