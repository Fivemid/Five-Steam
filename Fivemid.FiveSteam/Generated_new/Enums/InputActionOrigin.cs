using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EInputActionOrigin</summary>
    public enum InputActionOrigin : int
    {
        /// <summary>k_EInputActionOrigin_None</summary>
        None = 0,
        /// <summary>k_EInputActionOrigin_SteamController_A</summary>
        SteamController_A = 1,
        /// <summary>k_EInputActionOrigin_SteamController_B</summary>
        SteamController_B = 2,
        /// <summary>k_EInputActionOrigin_SteamController_X</summary>
        SteamController_X = 3,
        /// <summary>k_EInputActionOrigin_SteamController_Y</summary>
        SteamController_Y = 4,
        /// <summary>k_EInputActionOrigin_SteamController_LeftBumper</summary>
        SteamController_LeftBumper = 5,
        /// <summary>k_EInputActionOrigin_SteamController_RightBumper</summary>
        SteamController_RightBumper = 6,
        /// <summary>k_EInputActionOrigin_SteamController_LeftGrip</summary>
        SteamController_LeftGrip = 7,
        /// <summary>k_EInputActionOrigin_SteamController_RightGrip</summary>
        SteamController_RightGrip = 8,
        /// <summary>k_EInputActionOrigin_SteamController_Start</summary>
        SteamController_Start = 9,
        /// <summary>k_EInputActionOrigin_SteamController_Back</summary>
        SteamController_Back = 10,
        /// <summary>k_EInputActionOrigin_SteamController_LeftPad_Touch</summary>
        SteamController_LeftPad_Touch = 11,
        /// <summary>k_EInputActionOrigin_SteamController_LeftPad_Swipe</summary>
        SteamController_LeftPad_Swipe = 12,
        /// <summary>k_EInputActionOrigin_SteamController_LeftPad_Click</summary>
        SteamController_LeftPad_Click = 13,
        /// <summary>k_EInputActionOrigin_SteamController_LeftPad_DPadNorth</summary>
        SteamController_LeftPad_DPadNorth = 14,
        /// <summary>k_EInputActionOrigin_SteamController_LeftPad_DPadSouth</summary>
        SteamController_LeftPad_DPadSouth = 15,
        /// <summary>k_EInputActionOrigin_SteamController_LeftPad_DPadWest</summary>
        SteamController_LeftPad_DPadWest = 16,
        /// <summary>k_EInputActionOrigin_SteamController_LeftPad_DPadEast</summary>
        SteamController_LeftPad_DPadEast = 17,
        /// <summary>k_EInputActionOrigin_SteamController_RightPad_Touch</summary>
        SteamController_RightPad_Touch = 18,
        /// <summary>k_EInputActionOrigin_SteamController_RightPad_Swipe</summary>
        SteamController_RightPad_Swipe = 19,
        /// <summary>k_EInputActionOrigin_SteamController_RightPad_Click</summary>
        SteamController_RightPad_Click = 20,
        /// <summary>k_EInputActionOrigin_SteamController_RightPad_DPadNorth</summary>
        SteamController_RightPad_DPadNorth = 21,
        /// <summary>k_EInputActionOrigin_SteamController_RightPad_DPadSouth</summary>
        SteamController_RightPad_DPadSouth = 22,
        /// <summary>k_EInputActionOrigin_SteamController_RightPad_DPadWest</summary>
        SteamController_RightPad_DPadWest = 23,
        /// <summary>k_EInputActionOrigin_SteamController_RightPad_DPadEast</summary>
        SteamController_RightPad_DPadEast = 24,
        /// <summary>k_EInputActionOrigin_SteamController_LeftTrigger_Pull</summary>
        SteamController_LeftTrigger_Pull = 25,
        /// <summary>k_EInputActionOrigin_SteamController_LeftTrigger_Click</summary>
        SteamController_LeftTrigger_Click = 26,
        /// <summary>k_EInputActionOrigin_SteamController_RightTrigger_Pull</summary>
        SteamController_RightTrigger_Pull = 27,
        /// <summary>k_EInputActionOrigin_SteamController_RightTrigger_Click</summary>
        SteamController_RightTrigger_Click = 28,
        /// <summary>k_EInputActionOrigin_SteamController_LeftStick_Move</summary>
        SteamController_LeftStick_Move = 29,
        /// <summary>k_EInputActionOrigin_SteamController_LeftStick_Click</summary>
        SteamController_LeftStick_Click = 30,
        /// <summary>k_EInputActionOrigin_SteamController_LeftStick_DPadNorth</summary>
        SteamController_LeftStick_DPadNorth = 31,
        /// <summary>k_EInputActionOrigin_SteamController_LeftStick_DPadSouth</summary>
        SteamController_LeftStick_DPadSouth = 32,
        /// <summary>k_EInputActionOrigin_SteamController_LeftStick_DPadWest</summary>
        SteamController_LeftStick_DPadWest = 33,
        /// <summary>k_EInputActionOrigin_SteamController_LeftStick_DPadEast</summary>
        SteamController_LeftStick_DPadEast = 34,
        /// <summary>k_EInputActionOrigin_SteamController_Gyro_Move</summary>
        SteamController_Gyro_Move = 35,
        /// <summary>k_EInputActionOrigin_SteamController_Gyro_Pitch</summary>
        SteamController_Gyro_Pitch = 36,
        /// <summary>k_EInputActionOrigin_SteamController_Gyro_Yaw</summary>
        SteamController_Gyro_Yaw = 37,
        /// <summary>k_EInputActionOrigin_SteamController_Gyro_Roll</summary>
        SteamController_Gyro_Roll = 38,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved0</summary>
        SteamController_Reserved0 = 39,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved1</summary>
        SteamController_Reserved1 = 40,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved2</summary>
        SteamController_Reserved2 = 41,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved3</summary>
        SteamController_Reserved3 = 42,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved4</summary>
        SteamController_Reserved4 = 43,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved5</summary>
        SteamController_Reserved5 = 44,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved6</summary>
        SteamController_Reserved6 = 45,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved7</summary>
        SteamController_Reserved7 = 46,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved8</summary>
        SteamController_Reserved8 = 47,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved9</summary>
        SteamController_Reserved9 = 48,
        /// <summary>k_EInputActionOrigin_SteamController_Reserved10</summary>
        SteamController_Reserved10 = 49,
        /// <summary>k_EInputActionOrigin_PS4_X</summary>
        PS4_X = 50,
        /// <summary>k_EInputActionOrigin_PS4_Circle</summary>
        PS4_Circle = 51,
        /// <summary>k_EInputActionOrigin_PS4_Triangle</summary>
        PS4_Triangle = 52,
        /// <summary>k_EInputActionOrigin_PS4_Square</summary>
        PS4_Square = 53,
        /// <summary>k_EInputActionOrigin_PS4_LeftBumper</summary>
        PS4_LeftBumper = 54,
        /// <summary>k_EInputActionOrigin_PS4_RightBumper</summary>
        PS4_RightBumper = 55,
        /// <summary>k_EInputActionOrigin_PS4_Options</summary>
        PS4_Options = 56,
        /// <summary>k_EInputActionOrigin_PS4_Share</summary>
        PS4_Share = 57,
        /// <summary>k_EInputActionOrigin_PS4_LeftPad_Touch</summary>
        PS4_LeftPad_Touch = 58,
        /// <summary>k_EInputActionOrigin_PS4_LeftPad_Swipe</summary>
        PS4_LeftPad_Swipe = 59,
        /// <summary>k_EInputActionOrigin_PS4_LeftPad_Click</summary>
        PS4_LeftPad_Click = 60,
        /// <summary>k_EInputActionOrigin_PS4_LeftPad_DPadNorth</summary>
        PS4_LeftPad_DPadNorth = 61,
        /// <summary>k_EInputActionOrigin_PS4_LeftPad_DPadSouth</summary>
        PS4_LeftPad_DPadSouth = 62,
        /// <summary>k_EInputActionOrigin_PS4_LeftPad_DPadWest</summary>
        PS4_LeftPad_DPadWest = 63,
        /// <summary>k_EInputActionOrigin_PS4_LeftPad_DPadEast</summary>
        PS4_LeftPad_DPadEast = 64,
        /// <summary>k_EInputActionOrigin_PS4_RightPad_Touch</summary>
        PS4_RightPad_Touch = 65,
        /// <summary>k_EInputActionOrigin_PS4_RightPad_Swipe</summary>
        PS4_RightPad_Swipe = 66,
        /// <summary>k_EInputActionOrigin_PS4_RightPad_Click</summary>
        PS4_RightPad_Click = 67,
        /// <summary>k_EInputActionOrigin_PS4_RightPad_DPadNorth</summary>
        PS4_RightPad_DPadNorth = 68,
        /// <summary>k_EInputActionOrigin_PS4_RightPad_DPadSouth</summary>
        PS4_RightPad_DPadSouth = 69,
        /// <summary>k_EInputActionOrigin_PS4_RightPad_DPadWest</summary>
        PS4_RightPad_DPadWest = 70,
        /// <summary>k_EInputActionOrigin_PS4_RightPad_DPadEast</summary>
        PS4_RightPad_DPadEast = 71,
        /// <summary>k_EInputActionOrigin_PS4_CenterPad_Touch</summary>
        PS4_CenterPad_Touch = 72,
        /// <summary>k_EInputActionOrigin_PS4_CenterPad_Swipe</summary>
        PS4_CenterPad_Swipe = 73,
        /// <summary>k_EInputActionOrigin_PS4_CenterPad_Click</summary>
        PS4_CenterPad_Click = 74,
        /// <summary>k_EInputActionOrigin_PS4_CenterPad_DPadNorth</summary>
        PS4_CenterPad_DPadNorth = 75,
        /// <summary>k_EInputActionOrigin_PS4_CenterPad_DPadSouth</summary>
        PS4_CenterPad_DPadSouth = 76,
        /// <summary>k_EInputActionOrigin_PS4_CenterPad_DPadWest</summary>
        PS4_CenterPad_DPadWest = 77,
        /// <summary>k_EInputActionOrigin_PS4_CenterPad_DPadEast</summary>
        PS4_CenterPad_DPadEast = 78,
        /// <summary>k_EInputActionOrigin_PS4_LeftTrigger_Pull</summary>
        PS4_LeftTrigger_Pull = 79,
        /// <summary>k_EInputActionOrigin_PS4_LeftTrigger_Click</summary>
        PS4_LeftTrigger_Click = 80,
        /// <summary>k_EInputActionOrigin_PS4_RightTrigger_Pull</summary>
        PS4_RightTrigger_Pull = 81,
        /// <summary>k_EInputActionOrigin_PS4_RightTrigger_Click</summary>
        PS4_RightTrigger_Click = 82,
        /// <summary>k_EInputActionOrigin_PS4_LeftStick_Move</summary>
        PS4_LeftStick_Move = 83,
        /// <summary>k_EInputActionOrigin_PS4_LeftStick_Click</summary>
        PS4_LeftStick_Click = 84,
        /// <summary>k_EInputActionOrigin_PS4_LeftStick_DPadNorth</summary>
        PS4_LeftStick_DPadNorth = 85,
        /// <summary>k_EInputActionOrigin_PS4_LeftStick_DPadSouth</summary>
        PS4_LeftStick_DPadSouth = 86,
        /// <summary>k_EInputActionOrigin_PS4_LeftStick_DPadWest</summary>
        PS4_LeftStick_DPadWest = 87,
        /// <summary>k_EInputActionOrigin_PS4_LeftStick_DPadEast</summary>
        PS4_LeftStick_DPadEast = 88,
        /// <summary>k_EInputActionOrigin_PS4_RightStick_Move</summary>
        PS4_RightStick_Move = 89,
        /// <summary>k_EInputActionOrigin_PS4_RightStick_Click</summary>
        PS4_RightStick_Click = 90,
        /// <summary>k_EInputActionOrigin_PS4_RightStick_DPadNorth</summary>
        PS4_RightStick_DPadNorth = 91,
        /// <summary>k_EInputActionOrigin_PS4_RightStick_DPadSouth</summary>
        PS4_RightStick_DPadSouth = 92,
        /// <summary>k_EInputActionOrigin_PS4_RightStick_DPadWest</summary>
        PS4_RightStick_DPadWest = 93,
        /// <summary>k_EInputActionOrigin_PS4_RightStick_DPadEast</summary>
        PS4_RightStick_DPadEast = 94,
        /// <summary>k_EInputActionOrigin_PS4_DPad_North</summary>
        PS4_DPad_North = 95,
        /// <summary>k_EInputActionOrigin_PS4_DPad_South</summary>
        PS4_DPad_South = 96,
        /// <summary>k_EInputActionOrigin_PS4_DPad_West</summary>
        PS4_DPad_West = 97,
        /// <summary>k_EInputActionOrigin_PS4_DPad_East</summary>
        PS4_DPad_East = 98,
        /// <summary>k_EInputActionOrigin_PS4_Gyro_Move</summary>
        PS4_Gyro_Move = 99,
        /// <summary>k_EInputActionOrigin_PS4_Gyro_Pitch</summary>
        PS4_Gyro_Pitch = 100,
        /// <summary>k_EInputActionOrigin_PS4_Gyro_Yaw</summary>
        PS4_Gyro_Yaw = 101,
        /// <summary>k_EInputActionOrigin_PS4_Gyro_Roll</summary>
        PS4_Gyro_Roll = 102,
        /// <summary>k_EInputActionOrigin_PS4_DPad_Move</summary>
        PS4_DPad_Move = 103,
        /// <summary>k_EInputActionOrigin_PS4_Reserved1</summary>
        PS4_Reserved1 = 104,
        /// <summary>k_EInputActionOrigin_PS4_Reserved2</summary>
        PS4_Reserved2 = 105,
        /// <summary>k_EInputActionOrigin_PS4_Reserved3</summary>
        PS4_Reserved3 = 106,
        /// <summary>k_EInputActionOrigin_PS4_Reserved4</summary>
        PS4_Reserved4 = 107,
        /// <summary>k_EInputActionOrigin_PS4_Reserved5</summary>
        PS4_Reserved5 = 108,
        /// <summary>k_EInputActionOrigin_PS4_Reserved6</summary>
        PS4_Reserved6 = 109,
        /// <summary>k_EInputActionOrigin_PS4_Reserved7</summary>
        PS4_Reserved7 = 110,
        /// <summary>k_EInputActionOrigin_PS4_Reserved8</summary>
        PS4_Reserved8 = 111,
        /// <summary>k_EInputActionOrigin_PS4_Reserved9</summary>
        PS4_Reserved9 = 112,
        /// <summary>k_EInputActionOrigin_PS4_Reserved10</summary>
        PS4_Reserved10 = 113,
        /// <summary>k_EInputActionOrigin_XBoxOne_A</summary>
        XBoxOne_A = 114,
        /// <summary>k_EInputActionOrigin_XBoxOne_B</summary>
        XBoxOne_B = 115,
        /// <summary>k_EInputActionOrigin_XBoxOne_X</summary>
        XBoxOne_X = 116,
        /// <summary>k_EInputActionOrigin_XBoxOne_Y</summary>
        XBoxOne_Y = 117,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftBumper</summary>
        XBoxOne_LeftBumper = 118,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightBumper</summary>
        XBoxOne_RightBumper = 119,
        /// <summary>k_EInputActionOrigin_XBoxOne_Menu</summary>
        XBoxOne_Menu = 120,
        /// <summary>k_EInputActionOrigin_XBoxOne_View</summary>
        XBoxOne_View = 121,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftTrigger_Pull</summary>
        XBoxOne_LeftTrigger_Pull = 122,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftTrigger_Click</summary>
        XBoxOne_LeftTrigger_Click = 123,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightTrigger_Pull</summary>
        XBoxOne_RightTrigger_Pull = 124,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightTrigger_Click</summary>
        XBoxOne_RightTrigger_Click = 125,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftStick_Move</summary>
        XBoxOne_LeftStick_Move = 126,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftStick_Click</summary>
        XBoxOne_LeftStick_Click = 127,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftStick_DPadNorth</summary>
        XBoxOne_LeftStick_DPadNorth = 128,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftStick_DPadSouth</summary>
        XBoxOne_LeftStick_DPadSouth = 129,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftStick_DPadWest</summary>
        XBoxOne_LeftStick_DPadWest = 130,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftStick_DPadEast</summary>
        XBoxOne_LeftStick_DPadEast = 131,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightStick_Move</summary>
        XBoxOne_RightStick_Move = 132,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightStick_Click</summary>
        XBoxOne_RightStick_Click = 133,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightStick_DPadNorth</summary>
        XBoxOne_RightStick_DPadNorth = 134,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightStick_DPadSouth</summary>
        XBoxOne_RightStick_DPadSouth = 135,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightStick_DPadWest</summary>
        XBoxOne_RightStick_DPadWest = 136,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightStick_DPadEast</summary>
        XBoxOne_RightStick_DPadEast = 137,
        /// <summary>k_EInputActionOrigin_XBoxOne_DPad_North</summary>
        XBoxOne_DPad_North = 138,
        /// <summary>k_EInputActionOrigin_XBoxOne_DPad_South</summary>
        XBoxOne_DPad_South = 139,
        /// <summary>k_EInputActionOrigin_XBoxOne_DPad_West</summary>
        XBoxOne_DPad_West = 140,
        /// <summary>k_EInputActionOrigin_XBoxOne_DPad_East</summary>
        XBoxOne_DPad_East = 141,
        /// <summary>k_EInputActionOrigin_XBoxOne_DPad_Move</summary>
        XBoxOne_DPad_Move = 142,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftGrip_Lower</summary>
        XBoxOne_LeftGrip_Lower = 143,
        /// <summary>k_EInputActionOrigin_XBoxOne_LeftGrip_Upper</summary>
        XBoxOne_LeftGrip_Upper = 144,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightGrip_Lower</summary>
        XBoxOne_RightGrip_Lower = 145,
        /// <summary>k_EInputActionOrigin_XBoxOne_RightGrip_Upper</summary>
        XBoxOne_RightGrip_Upper = 146,
        /// <summary>k_EInputActionOrigin_XBoxOne_Share</summary>
        XBoxOne_Share = 147,
        /// <summary>k_EInputActionOrigin_XBoxOne_Reserved6</summary>
        XBoxOne_Reserved6 = 148,
        /// <summary>k_EInputActionOrigin_XBoxOne_Reserved7</summary>
        XBoxOne_Reserved7 = 149,
        /// <summary>k_EInputActionOrigin_XBoxOne_Reserved8</summary>
        XBoxOne_Reserved8 = 150,
        /// <summary>k_EInputActionOrigin_XBoxOne_Reserved9</summary>
        XBoxOne_Reserved9 = 151,
        /// <summary>k_EInputActionOrigin_XBoxOne_Reserved10</summary>
        XBoxOne_Reserved10 = 152,
        /// <summary>k_EInputActionOrigin_XBox360_A</summary>
        XBox360_A = 153,
        /// <summary>k_EInputActionOrigin_XBox360_B</summary>
        XBox360_B = 154,
        /// <summary>k_EInputActionOrigin_XBox360_X</summary>
        XBox360_X = 155,
        /// <summary>k_EInputActionOrigin_XBox360_Y</summary>
        XBox360_Y = 156,
        /// <summary>k_EInputActionOrigin_XBox360_LeftBumper</summary>
        XBox360_LeftBumper = 157,
        /// <summary>k_EInputActionOrigin_XBox360_RightBumper</summary>
        XBox360_RightBumper = 158,
        /// <summary>k_EInputActionOrigin_XBox360_Start</summary>
        XBox360_Start = 159,
        /// <summary>k_EInputActionOrigin_XBox360_Back</summary>
        XBox360_Back = 160,
        /// <summary>k_EInputActionOrigin_XBox360_LeftTrigger_Pull</summary>
        XBox360_LeftTrigger_Pull = 161,
        /// <summary>k_EInputActionOrigin_XBox360_LeftTrigger_Click</summary>
        XBox360_LeftTrigger_Click = 162,
        /// <summary>k_EInputActionOrigin_XBox360_RightTrigger_Pull</summary>
        XBox360_RightTrigger_Pull = 163,
        /// <summary>k_EInputActionOrigin_XBox360_RightTrigger_Click</summary>
        XBox360_RightTrigger_Click = 164,
        /// <summary>k_EInputActionOrigin_XBox360_LeftStick_Move</summary>
        XBox360_LeftStick_Move = 165,
        /// <summary>k_EInputActionOrigin_XBox360_LeftStick_Click</summary>
        XBox360_LeftStick_Click = 166,
        /// <summary>k_EInputActionOrigin_XBox360_LeftStick_DPadNorth</summary>
        XBox360_LeftStick_DPadNorth = 167,
        /// <summary>k_EInputActionOrigin_XBox360_LeftStick_DPadSouth</summary>
        XBox360_LeftStick_DPadSouth = 168,
        /// <summary>k_EInputActionOrigin_XBox360_LeftStick_DPadWest</summary>
        XBox360_LeftStick_DPadWest = 169,
        /// <summary>k_EInputActionOrigin_XBox360_LeftStick_DPadEast</summary>
        XBox360_LeftStick_DPadEast = 170,
        /// <summary>k_EInputActionOrigin_XBox360_RightStick_Move</summary>
        XBox360_RightStick_Move = 171,
        /// <summary>k_EInputActionOrigin_XBox360_RightStick_Click</summary>
        XBox360_RightStick_Click = 172,
        /// <summary>k_EInputActionOrigin_XBox360_RightStick_DPadNorth</summary>
        XBox360_RightStick_DPadNorth = 173,
        /// <summary>k_EInputActionOrigin_XBox360_RightStick_DPadSouth</summary>
        XBox360_RightStick_DPadSouth = 174,
        /// <summary>k_EInputActionOrigin_XBox360_RightStick_DPadWest</summary>
        XBox360_RightStick_DPadWest = 175,
        /// <summary>k_EInputActionOrigin_XBox360_RightStick_DPadEast</summary>
        XBox360_RightStick_DPadEast = 176,
        /// <summary>k_EInputActionOrigin_XBox360_DPad_North</summary>
        XBox360_DPad_North = 177,
        /// <summary>k_EInputActionOrigin_XBox360_DPad_South</summary>
        XBox360_DPad_South = 178,
        /// <summary>k_EInputActionOrigin_XBox360_DPad_West</summary>
        XBox360_DPad_West = 179,
        /// <summary>k_EInputActionOrigin_XBox360_DPad_East</summary>
        XBox360_DPad_East = 180,
        /// <summary>k_EInputActionOrigin_XBox360_DPad_Move</summary>
        XBox360_DPad_Move = 181,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved1</summary>
        XBox360_Reserved1 = 182,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved2</summary>
        XBox360_Reserved2 = 183,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved3</summary>
        XBox360_Reserved3 = 184,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved4</summary>
        XBox360_Reserved4 = 185,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved5</summary>
        XBox360_Reserved5 = 186,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved6</summary>
        XBox360_Reserved6 = 187,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved7</summary>
        XBox360_Reserved7 = 188,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved8</summary>
        XBox360_Reserved8 = 189,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved9</summary>
        XBox360_Reserved9 = 190,
        /// <summary>k_EInputActionOrigin_XBox360_Reserved10</summary>
        XBox360_Reserved10 = 191,
        /// <summary>k_EInputActionOrigin_Switch_A</summary>
        Switch_A = 192,
        /// <summary>k_EInputActionOrigin_Switch_B</summary>
        Switch_B = 193,
        /// <summary>k_EInputActionOrigin_Switch_X</summary>
        Switch_X = 194,
        /// <summary>k_EInputActionOrigin_Switch_Y</summary>
        Switch_Y = 195,
        /// <summary>k_EInputActionOrigin_Switch_LeftBumper</summary>
        Switch_LeftBumper = 196,
        /// <summary>k_EInputActionOrigin_Switch_RightBumper</summary>
        Switch_RightBumper = 197,
        /// <summary>k_EInputActionOrigin_Switch_Plus</summary>
        Switch_Plus = 198,
        /// <summary>k_EInputActionOrigin_Switch_Minus</summary>
        Switch_Minus = 199,
        /// <summary>k_EInputActionOrigin_Switch_Capture</summary>
        Switch_Capture = 200,
        /// <summary>k_EInputActionOrigin_Switch_LeftTrigger_Pull</summary>
        Switch_LeftTrigger_Pull = 201,
        /// <summary>k_EInputActionOrigin_Switch_LeftTrigger_Click</summary>
        Switch_LeftTrigger_Click = 202,
        /// <summary>k_EInputActionOrigin_Switch_RightTrigger_Pull</summary>
        Switch_RightTrigger_Pull = 203,
        /// <summary>k_EInputActionOrigin_Switch_RightTrigger_Click</summary>
        Switch_RightTrigger_Click = 204,
        /// <summary>k_EInputActionOrigin_Switch_LeftStick_Move</summary>
        Switch_LeftStick_Move = 205,
        /// <summary>k_EInputActionOrigin_Switch_LeftStick_Click</summary>
        Switch_LeftStick_Click = 206,
        /// <summary>k_EInputActionOrigin_Switch_LeftStick_DPadNorth</summary>
        Switch_LeftStick_DPadNorth = 207,
        /// <summary>k_EInputActionOrigin_Switch_LeftStick_DPadSouth</summary>
        Switch_LeftStick_DPadSouth = 208,
        /// <summary>k_EInputActionOrigin_Switch_LeftStick_DPadWest</summary>
        Switch_LeftStick_DPadWest = 209,
        /// <summary>k_EInputActionOrigin_Switch_LeftStick_DPadEast</summary>
        Switch_LeftStick_DPadEast = 210,
        /// <summary>k_EInputActionOrigin_Switch_RightStick_Move</summary>
        Switch_RightStick_Move = 211,
        /// <summary>k_EInputActionOrigin_Switch_RightStick_Click</summary>
        Switch_RightStick_Click = 212,
        /// <summary>k_EInputActionOrigin_Switch_RightStick_DPadNorth</summary>
        Switch_RightStick_DPadNorth = 213,
        /// <summary>k_EInputActionOrigin_Switch_RightStick_DPadSouth</summary>
        Switch_RightStick_DPadSouth = 214,
        /// <summary>k_EInputActionOrigin_Switch_RightStick_DPadWest</summary>
        Switch_RightStick_DPadWest = 215,
        /// <summary>k_EInputActionOrigin_Switch_RightStick_DPadEast</summary>
        Switch_RightStick_DPadEast = 216,
        /// <summary>k_EInputActionOrigin_Switch_DPad_North</summary>
        Switch_DPad_North = 217,
        /// <summary>k_EInputActionOrigin_Switch_DPad_South</summary>
        Switch_DPad_South = 218,
        /// <summary>k_EInputActionOrigin_Switch_DPad_West</summary>
        Switch_DPad_West = 219,
        /// <summary>k_EInputActionOrigin_Switch_DPad_East</summary>
        Switch_DPad_East = 220,
        /// <summary>k_EInputActionOrigin_Switch_ProGyro_Move</summary>
        Switch_ProGyro_Move = 221,
        /// <summary>k_EInputActionOrigin_Switch_ProGyro_Pitch</summary>
        Switch_ProGyro_Pitch = 222,
        /// <summary>k_EInputActionOrigin_Switch_ProGyro_Yaw</summary>
        Switch_ProGyro_Yaw = 223,
        /// <summary>k_EInputActionOrigin_Switch_ProGyro_Roll</summary>
        Switch_ProGyro_Roll = 224,
        /// <summary>k_EInputActionOrigin_Switch_DPad_Move</summary>
        Switch_DPad_Move = 225,
        /// <summary>k_EInputActionOrigin_Switch_Reserved1</summary>
        Switch_Reserved1 = 226,
        /// <summary>k_EInputActionOrigin_Switch_Reserved2</summary>
        Switch_Reserved2 = 227,
        /// <summary>k_EInputActionOrigin_Switch_Reserved3</summary>
        Switch_Reserved3 = 228,
        /// <summary>k_EInputActionOrigin_Switch_Reserved4</summary>
        Switch_Reserved4 = 229,
        /// <summary>k_EInputActionOrigin_Switch_Reserved5</summary>
        Switch_Reserved5 = 230,
        /// <summary>k_EInputActionOrigin_Switch_Reserved6</summary>
        Switch_Reserved6 = 231,
        /// <summary>k_EInputActionOrigin_Switch_Reserved7</summary>
        Switch_Reserved7 = 232,
        /// <summary>k_EInputActionOrigin_Switch_Reserved8</summary>
        Switch_Reserved8 = 233,
        /// <summary>k_EInputActionOrigin_Switch_Reserved9</summary>
        Switch_Reserved9 = 234,
        /// <summary>k_EInputActionOrigin_Switch_Reserved10</summary>
        Switch_Reserved10 = 235,
        /// <summary>k_EInputActionOrigin_Switch_RightGyro_Move</summary>
        Switch_RightGyro_Move = 236,
        /// <summary>k_EInputActionOrigin_Switch_RightGyro_Pitch</summary>
        Switch_RightGyro_Pitch = 237,
        /// <summary>k_EInputActionOrigin_Switch_RightGyro_Yaw</summary>
        Switch_RightGyro_Yaw = 238,
        /// <summary>k_EInputActionOrigin_Switch_RightGyro_Roll</summary>
        Switch_RightGyro_Roll = 239,
        /// <summary>k_EInputActionOrigin_Switch_LeftGyro_Move</summary>
        Switch_LeftGyro_Move = 240,
        /// <summary>k_EInputActionOrigin_Switch_LeftGyro_Pitch</summary>
        Switch_LeftGyro_Pitch = 241,
        /// <summary>k_EInputActionOrigin_Switch_LeftGyro_Yaw</summary>
        Switch_LeftGyro_Yaw = 242,
        /// <summary>k_EInputActionOrigin_Switch_LeftGyro_Roll</summary>
        Switch_LeftGyro_Roll = 243,
        /// <summary>k_EInputActionOrigin_Switch_LeftGrip_Lower</summary>
        Switch_LeftGrip_Lower = 244,
        /// <summary>k_EInputActionOrigin_Switch_LeftGrip_Upper</summary>
        Switch_LeftGrip_Upper = 245,
        /// <summary>k_EInputActionOrigin_Switch_RightGrip_Lower</summary>
        Switch_RightGrip_Lower = 246,
        /// <summary>k_EInputActionOrigin_Switch_RightGrip_Upper</summary>
        Switch_RightGrip_Upper = 247,
        /// <summary>k_EInputActionOrigin_Switch_JoyConButton_N</summary>
        Switch_JoyConButton_N = 248,
        /// <summary>k_EInputActionOrigin_Switch_JoyConButton_E</summary>
        Switch_JoyConButton_E = 249,
        /// <summary>k_EInputActionOrigin_Switch_JoyConButton_S</summary>
        Switch_JoyConButton_S = 250,
        /// <summary>k_EInputActionOrigin_Switch_JoyConButton_W</summary>
        Switch_JoyConButton_W = 251,
        /// <summary>k_EInputActionOrigin_Switch_Reserved15</summary>
        Switch_Reserved15 = 252,
        /// <summary>k_EInputActionOrigin_Switch_Reserved16</summary>
        Switch_Reserved16 = 253,
        /// <summary>k_EInputActionOrigin_Switch_Reserved17</summary>
        Switch_Reserved17 = 254,
        /// <summary>k_EInputActionOrigin_Switch_Reserved18</summary>
        Switch_Reserved18 = 255,
        /// <summary>k_EInputActionOrigin_Switch_Reserved19</summary>
        Switch_Reserved19 = 256,
        /// <summary>k_EInputActionOrigin_Switch_Reserved20</summary>
        Switch_Reserved20 = 257,
        /// <summary>k_EInputActionOrigin_PS5_X</summary>
        PS5_X = 258,
        /// <summary>k_EInputActionOrigin_PS5_Circle</summary>
        PS5_Circle = 259,
        /// <summary>k_EInputActionOrigin_PS5_Triangle</summary>
        PS5_Triangle = 260,
        /// <summary>k_EInputActionOrigin_PS5_Square</summary>
        PS5_Square = 261,
        /// <summary>k_EInputActionOrigin_PS5_LeftBumper</summary>
        PS5_LeftBumper = 262,
        /// <summary>k_EInputActionOrigin_PS5_RightBumper</summary>
        PS5_RightBumper = 263,
        /// <summary>k_EInputActionOrigin_PS5_Option</summary>
        PS5_Option = 264,
        /// <summary>k_EInputActionOrigin_PS5_Create</summary>
        PS5_Create = 265,
        /// <summary>k_EInputActionOrigin_PS5_Mute</summary>
        PS5_Mute = 266,
        /// <summary>k_EInputActionOrigin_PS5_LeftPad_Touch</summary>
        PS5_LeftPad_Touch = 267,
        /// <summary>k_EInputActionOrigin_PS5_LeftPad_Swipe</summary>
        PS5_LeftPad_Swipe = 268,
        /// <summary>k_EInputActionOrigin_PS5_LeftPad_Click</summary>
        PS5_LeftPad_Click = 269,
        /// <summary>k_EInputActionOrigin_PS5_LeftPad_DPadNorth</summary>
        PS5_LeftPad_DPadNorth = 270,
        /// <summary>k_EInputActionOrigin_PS5_LeftPad_DPadSouth</summary>
        PS5_LeftPad_DPadSouth = 271,
        /// <summary>k_EInputActionOrigin_PS5_LeftPad_DPadWest</summary>
        PS5_LeftPad_DPadWest = 272,
        /// <summary>k_EInputActionOrigin_PS5_LeftPad_DPadEast</summary>
        PS5_LeftPad_DPadEast = 273,
        /// <summary>k_EInputActionOrigin_PS5_RightPad_Touch</summary>
        PS5_RightPad_Touch = 274,
        /// <summary>k_EInputActionOrigin_PS5_RightPad_Swipe</summary>
        PS5_RightPad_Swipe = 275,
        /// <summary>k_EInputActionOrigin_PS5_RightPad_Click</summary>
        PS5_RightPad_Click = 276,
        /// <summary>k_EInputActionOrigin_PS5_RightPad_DPadNorth</summary>
        PS5_RightPad_DPadNorth = 277,
        /// <summary>k_EInputActionOrigin_PS5_RightPad_DPadSouth</summary>
        PS5_RightPad_DPadSouth = 278,
        /// <summary>k_EInputActionOrigin_PS5_RightPad_DPadWest</summary>
        PS5_RightPad_DPadWest = 279,
        /// <summary>k_EInputActionOrigin_PS5_RightPad_DPadEast</summary>
        PS5_RightPad_DPadEast = 280,
        /// <summary>k_EInputActionOrigin_PS5_CenterPad_Touch</summary>
        PS5_CenterPad_Touch = 281,
        /// <summary>k_EInputActionOrigin_PS5_CenterPad_Swipe</summary>
        PS5_CenterPad_Swipe = 282,
        /// <summary>k_EInputActionOrigin_PS5_CenterPad_Click</summary>
        PS5_CenterPad_Click = 283,
        /// <summary>k_EInputActionOrigin_PS5_CenterPad_DPadNorth</summary>
        PS5_CenterPad_DPadNorth = 284,
        /// <summary>k_EInputActionOrigin_PS5_CenterPad_DPadSouth</summary>
        PS5_CenterPad_DPadSouth = 285,
        /// <summary>k_EInputActionOrigin_PS5_CenterPad_DPadWest</summary>
        PS5_CenterPad_DPadWest = 286,
        /// <summary>k_EInputActionOrigin_PS5_CenterPad_DPadEast</summary>
        PS5_CenterPad_DPadEast = 287,
        /// <summary>k_EInputActionOrigin_PS5_LeftTrigger_Pull</summary>
        PS5_LeftTrigger_Pull = 288,
        /// <summary>k_EInputActionOrigin_PS5_LeftTrigger_Click</summary>
        PS5_LeftTrigger_Click = 289,
        /// <summary>k_EInputActionOrigin_PS5_RightTrigger_Pull</summary>
        PS5_RightTrigger_Pull = 290,
        /// <summary>k_EInputActionOrigin_PS5_RightTrigger_Click</summary>
        PS5_RightTrigger_Click = 291,
        /// <summary>k_EInputActionOrigin_PS5_LeftStick_Move</summary>
        PS5_LeftStick_Move = 292,
        /// <summary>k_EInputActionOrigin_PS5_LeftStick_Click</summary>
        PS5_LeftStick_Click = 293,
        /// <summary>k_EInputActionOrigin_PS5_LeftStick_DPadNorth</summary>
        PS5_LeftStick_DPadNorth = 294,
        /// <summary>k_EInputActionOrigin_PS5_LeftStick_DPadSouth</summary>
        PS5_LeftStick_DPadSouth = 295,
        /// <summary>k_EInputActionOrigin_PS5_LeftStick_DPadWest</summary>
        PS5_LeftStick_DPadWest = 296,
        /// <summary>k_EInputActionOrigin_PS5_LeftStick_DPadEast</summary>
        PS5_LeftStick_DPadEast = 297,
        /// <summary>k_EInputActionOrigin_PS5_RightStick_Move</summary>
        PS5_RightStick_Move = 298,
        /// <summary>k_EInputActionOrigin_PS5_RightStick_Click</summary>
        PS5_RightStick_Click = 299,
        /// <summary>k_EInputActionOrigin_PS5_RightStick_DPadNorth</summary>
        PS5_RightStick_DPadNorth = 300,
        /// <summary>k_EInputActionOrigin_PS5_RightStick_DPadSouth</summary>
        PS5_RightStick_DPadSouth = 301,
        /// <summary>k_EInputActionOrigin_PS5_RightStick_DPadWest</summary>
        PS5_RightStick_DPadWest = 302,
        /// <summary>k_EInputActionOrigin_PS5_RightStick_DPadEast</summary>
        PS5_RightStick_DPadEast = 303,
        /// <summary>k_EInputActionOrigin_PS5_DPad_North</summary>
        PS5_DPad_North = 304,
        /// <summary>k_EInputActionOrigin_PS5_DPad_South</summary>
        PS5_DPad_South = 305,
        /// <summary>k_EInputActionOrigin_PS5_DPad_West</summary>
        PS5_DPad_West = 306,
        /// <summary>k_EInputActionOrigin_PS5_DPad_East</summary>
        PS5_DPad_East = 307,
        /// <summary>k_EInputActionOrigin_PS5_Gyro_Move</summary>
        PS5_Gyro_Move = 308,
        /// <summary>k_EInputActionOrigin_PS5_Gyro_Pitch</summary>
        PS5_Gyro_Pitch = 309,
        /// <summary>k_EInputActionOrigin_PS5_Gyro_Yaw</summary>
        PS5_Gyro_Yaw = 310,
        /// <summary>k_EInputActionOrigin_PS5_Gyro_Roll</summary>
        PS5_Gyro_Roll = 311,
        /// <summary>k_EInputActionOrigin_PS5_DPad_Move</summary>
        PS5_DPad_Move = 312,
        /// <summary>k_EInputActionOrigin_PS5_LeftGrip</summary>
        PS5_LeftGrip = 313,
        /// <summary>k_EInputActionOrigin_PS5_RightGrip</summary>
        PS5_RightGrip = 314,
        /// <summary>k_EInputActionOrigin_PS5_LeftFn</summary>
        PS5_LeftFn = 315,
        /// <summary>k_EInputActionOrigin_PS5_RightFn</summary>
        PS5_RightFn = 316,
        /// <summary>k_EInputActionOrigin_PS5_Reserved5</summary>
        PS5_Reserved5 = 317,
        /// <summary>k_EInputActionOrigin_PS5_Reserved6</summary>
        PS5_Reserved6 = 318,
        /// <summary>k_EInputActionOrigin_PS5_Reserved7</summary>
        PS5_Reserved7 = 319,
        /// <summary>k_EInputActionOrigin_PS5_Reserved8</summary>
        PS5_Reserved8 = 320,
        /// <summary>k_EInputActionOrigin_PS5_Reserved9</summary>
        PS5_Reserved9 = 321,
        /// <summary>k_EInputActionOrigin_PS5_Reserved10</summary>
        PS5_Reserved10 = 322,
        /// <summary>k_EInputActionOrigin_PS5_Reserved11</summary>
        PS5_Reserved11 = 323,
        /// <summary>k_EInputActionOrigin_PS5_Reserved12</summary>
        PS5_Reserved12 = 324,
        /// <summary>k_EInputActionOrigin_PS5_Reserved13</summary>
        PS5_Reserved13 = 325,
        /// <summary>k_EInputActionOrigin_PS5_Reserved14</summary>
        PS5_Reserved14 = 326,
        /// <summary>k_EInputActionOrigin_PS5_Reserved15</summary>
        PS5_Reserved15 = 327,
        /// <summary>k_EInputActionOrigin_PS5_Reserved16</summary>
        PS5_Reserved16 = 328,
        /// <summary>k_EInputActionOrigin_PS5_Reserved17</summary>
        PS5_Reserved17 = 329,
        /// <summary>k_EInputActionOrigin_PS5_Reserved18</summary>
        PS5_Reserved18 = 330,
        /// <summary>k_EInputActionOrigin_PS5_Reserved19</summary>
        PS5_Reserved19 = 331,
        /// <summary>k_EInputActionOrigin_PS5_Reserved20</summary>
        PS5_Reserved20 = 332,
        /// <summary>k_EInputActionOrigin_SteamDeck_A</summary>
        SteamDeck_A = 333,
        /// <summary>k_EInputActionOrigin_SteamDeck_B</summary>
        SteamDeck_B = 334,
        /// <summary>k_EInputActionOrigin_SteamDeck_X</summary>
        SteamDeck_X = 335,
        /// <summary>k_EInputActionOrigin_SteamDeck_Y</summary>
        SteamDeck_Y = 336,
        /// <summary>k_EInputActionOrigin_SteamDeck_L1</summary>
        SteamDeck_L1 = 337,
        /// <summary>k_EInputActionOrigin_SteamDeck_R1</summary>
        SteamDeck_R1 = 338,
        /// <summary>k_EInputActionOrigin_SteamDeck_Menu</summary>
        SteamDeck_Menu = 339,
        /// <summary>k_EInputActionOrigin_SteamDeck_View</summary>
        SteamDeck_View = 340,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftPad_Touch</summary>
        SteamDeck_LeftPad_Touch = 341,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftPad_Swipe</summary>
        SteamDeck_LeftPad_Swipe = 342,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftPad_Click</summary>
        SteamDeck_LeftPad_Click = 343,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftPad_DPadNorth</summary>
        SteamDeck_LeftPad_DPadNorth = 344,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftPad_DPadSouth</summary>
        SteamDeck_LeftPad_DPadSouth = 345,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftPad_DPadWest</summary>
        SteamDeck_LeftPad_DPadWest = 346,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftPad_DPadEast</summary>
        SteamDeck_LeftPad_DPadEast = 347,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightPad_Touch</summary>
        SteamDeck_RightPad_Touch = 348,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightPad_Swipe</summary>
        SteamDeck_RightPad_Swipe = 349,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightPad_Click</summary>
        SteamDeck_RightPad_Click = 350,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightPad_DPadNorth</summary>
        SteamDeck_RightPad_DPadNorth = 351,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightPad_DPadSouth</summary>
        SteamDeck_RightPad_DPadSouth = 352,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightPad_DPadWest</summary>
        SteamDeck_RightPad_DPadWest = 353,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightPad_DPadEast</summary>
        SteamDeck_RightPad_DPadEast = 354,
        /// <summary>k_EInputActionOrigin_SteamDeck_L2_SoftPull</summary>
        SteamDeck_L2_SoftPull = 355,
        /// <summary>k_EInputActionOrigin_SteamDeck_L2</summary>
        SteamDeck_L2 = 356,
        /// <summary>k_EInputActionOrigin_SteamDeck_R2_SoftPull</summary>
        SteamDeck_R2_SoftPull = 357,
        /// <summary>k_EInputActionOrigin_SteamDeck_R2</summary>
        SteamDeck_R2 = 358,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftStick_Move</summary>
        SteamDeck_LeftStick_Move = 359,
        /// <summary>k_EInputActionOrigin_SteamDeck_L3</summary>
        SteamDeck_L3 = 360,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftStick_DPadNorth</summary>
        SteamDeck_LeftStick_DPadNorth = 361,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftStick_DPadSouth</summary>
        SteamDeck_LeftStick_DPadSouth = 362,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftStick_DPadWest</summary>
        SteamDeck_LeftStick_DPadWest = 363,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftStick_DPadEast</summary>
        SteamDeck_LeftStick_DPadEast = 364,
        /// <summary>k_EInputActionOrigin_SteamDeck_LeftStick_Touch</summary>
        SteamDeck_LeftStick_Touch = 365,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightStick_Move</summary>
        SteamDeck_RightStick_Move = 366,
        /// <summary>k_EInputActionOrigin_SteamDeck_R3</summary>
        SteamDeck_R3 = 367,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightStick_DPadNorth</summary>
        SteamDeck_RightStick_DPadNorth = 368,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightStick_DPadSouth</summary>
        SteamDeck_RightStick_DPadSouth = 369,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightStick_DPadWest</summary>
        SteamDeck_RightStick_DPadWest = 370,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightStick_DPadEast</summary>
        SteamDeck_RightStick_DPadEast = 371,
        /// <summary>k_EInputActionOrigin_SteamDeck_RightStick_Touch</summary>
        SteamDeck_RightStick_Touch = 372,
        /// <summary>k_EInputActionOrigin_SteamDeck_L4</summary>
        SteamDeck_L4 = 373,
        /// <summary>k_EInputActionOrigin_SteamDeck_R4</summary>
        SteamDeck_R4 = 374,
        /// <summary>k_EInputActionOrigin_SteamDeck_L5</summary>
        SteamDeck_L5 = 375,
        /// <summary>k_EInputActionOrigin_SteamDeck_R5</summary>
        SteamDeck_R5 = 376,
        /// <summary>k_EInputActionOrigin_SteamDeck_DPad_Move</summary>
        SteamDeck_DPad_Move = 377,
        /// <summary>k_EInputActionOrigin_SteamDeck_DPad_North</summary>
        SteamDeck_DPad_North = 378,
        /// <summary>k_EInputActionOrigin_SteamDeck_DPad_South</summary>
        SteamDeck_DPad_South = 379,
        /// <summary>k_EInputActionOrigin_SteamDeck_DPad_West</summary>
        SteamDeck_DPad_West = 380,
        /// <summary>k_EInputActionOrigin_SteamDeck_DPad_East</summary>
        SteamDeck_DPad_East = 381,
        /// <summary>k_EInputActionOrigin_SteamDeck_Gyro_Move</summary>
        SteamDeck_Gyro_Move = 382,
        /// <summary>k_EInputActionOrigin_SteamDeck_Gyro_Pitch</summary>
        SteamDeck_Gyro_Pitch = 383,
        /// <summary>k_EInputActionOrigin_SteamDeck_Gyro_Yaw</summary>
        SteamDeck_Gyro_Yaw = 384,
        /// <summary>k_EInputActionOrigin_SteamDeck_Gyro_Roll</summary>
        SteamDeck_Gyro_Roll = 385,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved1</summary>
        SteamDeck_Reserved1 = 386,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved2</summary>
        SteamDeck_Reserved2 = 387,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved3</summary>
        SteamDeck_Reserved3 = 388,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved4</summary>
        SteamDeck_Reserved4 = 389,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved5</summary>
        SteamDeck_Reserved5 = 390,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved6</summary>
        SteamDeck_Reserved6 = 391,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved7</summary>
        SteamDeck_Reserved7 = 392,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved8</summary>
        SteamDeck_Reserved8 = 393,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved9</summary>
        SteamDeck_Reserved9 = 394,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved10</summary>
        SteamDeck_Reserved10 = 395,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved11</summary>
        SteamDeck_Reserved11 = 396,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved12</summary>
        SteamDeck_Reserved12 = 397,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved13</summary>
        SteamDeck_Reserved13 = 398,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved14</summary>
        SteamDeck_Reserved14 = 399,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved15</summary>
        SteamDeck_Reserved15 = 400,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved16</summary>
        SteamDeck_Reserved16 = 401,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved17</summary>
        SteamDeck_Reserved17 = 402,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved18</summary>
        SteamDeck_Reserved18 = 403,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved19</summary>
        SteamDeck_Reserved19 = 404,
        /// <summary>k_EInputActionOrigin_SteamDeck_Reserved20</summary>
        SteamDeck_Reserved20 = 405,
        /// <summary>k_EInputActionOrigin_Count</summary>
        Count = 406,
        /// <summary>k_EInputActionOrigin_MaximumPossibleValue</summary>
        MaximumPossibleValue = 32767
    }
}