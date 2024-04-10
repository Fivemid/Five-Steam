using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EControllerActionOrigin</summary>
    public enum ControllerActionOrigin : int
    {
        /// <summary>k_EControllerActionOrigin_None</summary>
        None = 0,
        /// <summary>k_EControllerActionOrigin_A</summary>
        A = 1,
        /// <summary>k_EControllerActionOrigin_B</summary>
        B = 2,
        /// <summary>k_EControllerActionOrigin_X</summary>
        X = 3,
        /// <summary>k_EControllerActionOrigin_Y</summary>
        Y = 4,
        /// <summary>k_EControllerActionOrigin_LeftBumper</summary>
        LeftBumper = 5,
        /// <summary>k_EControllerActionOrigin_RightBumper</summary>
        RightBumper = 6,
        /// <summary>k_EControllerActionOrigin_LeftGrip</summary>
        LeftGrip = 7,
        /// <summary>k_EControllerActionOrigin_RightGrip</summary>
        RightGrip = 8,
        /// <summary>k_EControllerActionOrigin_Start</summary>
        Start = 9,
        /// <summary>k_EControllerActionOrigin_Back</summary>
        Back = 10,
        /// <summary>k_EControllerActionOrigin_LeftPad_Touch</summary>
        LeftPad_Touch = 11,
        /// <summary>k_EControllerActionOrigin_LeftPad_Swipe</summary>
        LeftPad_Swipe = 12,
        /// <summary>k_EControllerActionOrigin_LeftPad_Click</summary>
        LeftPad_Click = 13,
        /// <summary>k_EControllerActionOrigin_LeftPad_DPadNorth</summary>
        LeftPad_DPadNorth = 14,
        /// <summary>k_EControllerActionOrigin_LeftPad_DPadSouth</summary>
        LeftPad_DPadSouth = 15,
        /// <summary>k_EControllerActionOrigin_LeftPad_DPadWest</summary>
        LeftPad_DPadWest = 16,
        /// <summary>k_EControllerActionOrigin_LeftPad_DPadEast</summary>
        LeftPad_DPadEast = 17,
        /// <summary>k_EControllerActionOrigin_RightPad_Touch</summary>
        RightPad_Touch = 18,
        /// <summary>k_EControllerActionOrigin_RightPad_Swipe</summary>
        RightPad_Swipe = 19,
        /// <summary>k_EControllerActionOrigin_RightPad_Click</summary>
        RightPad_Click = 20,
        /// <summary>k_EControllerActionOrigin_RightPad_DPadNorth</summary>
        RightPad_DPadNorth = 21,
        /// <summary>k_EControllerActionOrigin_RightPad_DPadSouth</summary>
        RightPad_DPadSouth = 22,
        /// <summary>k_EControllerActionOrigin_RightPad_DPadWest</summary>
        RightPad_DPadWest = 23,
        /// <summary>k_EControllerActionOrigin_RightPad_DPadEast</summary>
        RightPad_DPadEast = 24,
        /// <summary>k_EControllerActionOrigin_LeftTrigger_Pull</summary>
        LeftTrigger_Pull = 25,
        /// <summary>k_EControllerActionOrigin_LeftTrigger_Click</summary>
        LeftTrigger_Click = 26,
        /// <summary>k_EControllerActionOrigin_RightTrigger_Pull</summary>
        RightTrigger_Pull = 27,
        /// <summary>k_EControllerActionOrigin_RightTrigger_Click</summary>
        RightTrigger_Click = 28,
        /// <summary>k_EControllerActionOrigin_LeftStick_Move</summary>
        LeftStick_Move = 29,
        /// <summary>k_EControllerActionOrigin_LeftStick_Click</summary>
        LeftStick_Click = 30,
        /// <summary>k_EControllerActionOrigin_LeftStick_DPadNorth</summary>
        LeftStick_DPadNorth = 31,
        /// <summary>k_EControllerActionOrigin_LeftStick_DPadSouth</summary>
        LeftStick_DPadSouth = 32,
        /// <summary>k_EControllerActionOrigin_LeftStick_DPadWest</summary>
        LeftStick_DPadWest = 33,
        /// <summary>k_EControllerActionOrigin_LeftStick_DPadEast</summary>
        LeftStick_DPadEast = 34,
        /// <summary>k_EControllerActionOrigin_Gyro_Move</summary>
        Gyro_Move = 35,
        /// <summary>k_EControllerActionOrigin_Gyro_Pitch</summary>
        Gyro_Pitch = 36,
        /// <summary>k_EControllerActionOrigin_Gyro_Yaw</summary>
        Gyro_Yaw = 37,
        /// <summary>k_EControllerActionOrigin_Gyro_Roll</summary>
        Gyro_Roll = 38,
        /// <summary>k_EControllerActionOrigin_PS4_X</summary>
        PS4_X = 39,
        /// <summary>k_EControllerActionOrigin_PS4_Circle</summary>
        PS4_Circle = 40,
        /// <summary>k_EControllerActionOrigin_PS4_Triangle</summary>
        PS4_Triangle = 41,
        /// <summary>k_EControllerActionOrigin_PS4_Square</summary>
        PS4_Square = 42,
        /// <summary>k_EControllerActionOrigin_PS4_LeftBumper</summary>
        PS4_LeftBumper = 43,
        /// <summary>k_EControllerActionOrigin_PS4_RightBumper</summary>
        PS4_RightBumper = 44,
        /// <summary>k_EControllerActionOrigin_PS4_Options</summary>
        PS4_Options = 45,
        /// <summary>k_EControllerActionOrigin_PS4_Share</summary>
        PS4_Share = 46,
        /// <summary>k_EControllerActionOrigin_PS4_LeftPad_Touch</summary>
        PS4_LeftPad_Touch = 47,
        /// <summary>k_EControllerActionOrigin_PS4_LeftPad_Swipe</summary>
        PS4_LeftPad_Swipe = 48,
        /// <summary>k_EControllerActionOrigin_PS4_LeftPad_Click</summary>
        PS4_LeftPad_Click = 49,
        /// <summary>k_EControllerActionOrigin_PS4_LeftPad_DPadNorth</summary>
        PS4_LeftPad_DPadNorth = 50,
        /// <summary>k_EControllerActionOrigin_PS4_LeftPad_DPadSouth</summary>
        PS4_LeftPad_DPadSouth = 51,
        /// <summary>k_EControllerActionOrigin_PS4_LeftPad_DPadWest</summary>
        PS4_LeftPad_DPadWest = 52,
        /// <summary>k_EControllerActionOrigin_PS4_LeftPad_DPadEast</summary>
        PS4_LeftPad_DPadEast = 53,
        /// <summary>k_EControllerActionOrigin_PS4_RightPad_Touch</summary>
        PS4_RightPad_Touch = 54,
        /// <summary>k_EControllerActionOrigin_PS4_RightPad_Swipe</summary>
        PS4_RightPad_Swipe = 55,
        /// <summary>k_EControllerActionOrigin_PS4_RightPad_Click</summary>
        PS4_RightPad_Click = 56,
        /// <summary>k_EControllerActionOrigin_PS4_RightPad_DPadNorth</summary>
        PS4_RightPad_DPadNorth = 57,
        /// <summary>k_EControllerActionOrigin_PS4_RightPad_DPadSouth</summary>
        PS4_RightPad_DPadSouth = 58,
        /// <summary>k_EControllerActionOrigin_PS4_RightPad_DPadWest</summary>
        PS4_RightPad_DPadWest = 59,
        /// <summary>k_EControllerActionOrigin_PS4_RightPad_DPadEast</summary>
        PS4_RightPad_DPadEast = 60,
        /// <summary>k_EControllerActionOrigin_PS4_CenterPad_Touch</summary>
        PS4_CenterPad_Touch = 61,
        /// <summary>k_EControllerActionOrigin_PS4_CenterPad_Swipe</summary>
        PS4_CenterPad_Swipe = 62,
        /// <summary>k_EControllerActionOrigin_PS4_CenterPad_Click</summary>
        PS4_CenterPad_Click = 63,
        /// <summary>k_EControllerActionOrigin_PS4_CenterPad_DPadNorth</summary>
        PS4_CenterPad_DPadNorth = 64,
        /// <summary>k_EControllerActionOrigin_PS4_CenterPad_DPadSouth</summary>
        PS4_CenterPad_DPadSouth = 65,
        /// <summary>k_EControllerActionOrigin_PS4_CenterPad_DPadWest</summary>
        PS4_CenterPad_DPadWest = 66,
        /// <summary>k_EControllerActionOrigin_PS4_CenterPad_DPadEast</summary>
        PS4_CenterPad_DPadEast = 67,
        /// <summary>k_EControllerActionOrigin_PS4_LeftTrigger_Pull</summary>
        PS4_LeftTrigger_Pull = 68,
        /// <summary>k_EControllerActionOrigin_PS4_LeftTrigger_Click</summary>
        PS4_LeftTrigger_Click = 69,
        /// <summary>k_EControllerActionOrigin_PS4_RightTrigger_Pull</summary>
        PS4_RightTrigger_Pull = 70,
        /// <summary>k_EControllerActionOrigin_PS4_RightTrigger_Click</summary>
        PS4_RightTrigger_Click = 71,
        /// <summary>k_EControllerActionOrigin_PS4_LeftStick_Move</summary>
        PS4_LeftStick_Move = 72,
        /// <summary>k_EControllerActionOrigin_PS4_LeftStick_Click</summary>
        PS4_LeftStick_Click = 73,
        /// <summary>k_EControllerActionOrigin_PS4_LeftStick_DPadNorth</summary>
        PS4_LeftStick_DPadNorth = 74,
        /// <summary>k_EControllerActionOrigin_PS4_LeftStick_DPadSouth</summary>
        PS4_LeftStick_DPadSouth = 75,
        /// <summary>k_EControllerActionOrigin_PS4_LeftStick_DPadWest</summary>
        PS4_LeftStick_DPadWest = 76,
        /// <summary>k_EControllerActionOrigin_PS4_LeftStick_DPadEast</summary>
        PS4_LeftStick_DPadEast = 77,
        /// <summary>k_EControllerActionOrigin_PS4_RightStick_Move</summary>
        PS4_RightStick_Move = 78,
        /// <summary>k_EControllerActionOrigin_PS4_RightStick_Click</summary>
        PS4_RightStick_Click = 79,
        /// <summary>k_EControllerActionOrigin_PS4_RightStick_DPadNorth</summary>
        PS4_RightStick_DPadNorth = 80,
        /// <summary>k_EControllerActionOrigin_PS4_RightStick_DPadSouth</summary>
        PS4_RightStick_DPadSouth = 81,
        /// <summary>k_EControllerActionOrigin_PS4_RightStick_DPadWest</summary>
        PS4_RightStick_DPadWest = 82,
        /// <summary>k_EControllerActionOrigin_PS4_RightStick_DPadEast</summary>
        PS4_RightStick_DPadEast = 83,
        /// <summary>k_EControllerActionOrigin_PS4_DPad_North</summary>
        PS4_DPad_North = 84,
        /// <summary>k_EControllerActionOrigin_PS4_DPad_South</summary>
        PS4_DPad_South = 85,
        /// <summary>k_EControllerActionOrigin_PS4_DPad_West</summary>
        PS4_DPad_West = 86,
        /// <summary>k_EControllerActionOrigin_PS4_DPad_East</summary>
        PS4_DPad_East = 87,
        /// <summary>k_EControllerActionOrigin_PS4_Gyro_Move</summary>
        PS4_Gyro_Move = 88,
        /// <summary>k_EControllerActionOrigin_PS4_Gyro_Pitch</summary>
        PS4_Gyro_Pitch = 89,
        /// <summary>k_EControllerActionOrigin_PS4_Gyro_Yaw</summary>
        PS4_Gyro_Yaw = 90,
        /// <summary>k_EControllerActionOrigin_PS4_Gyro_Roll</summary>
        PS4_Gyro_Roll = 91,
        /// <summary>k_EControllerActionOrigin_XBoxOne_A</summary>
        XBoxOne_A = 92,
        /// <summary>k_EControllerActionOrigin_XBoxOne_B</summary>
        XBoxOne_B = 93,
        /// <summary>k_EControllerActionOrigin_XBoxOne_X</summary>
        XBoxOne_X = 94,
        /// <summary>k_EControllerActionOrigin_XBoxOne_Y</summary>
        XBoxOne_Y = 95,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftBumper</summary>
        XBoxOne_LeftBumper = 96,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightBumper</summary>
        XBoxOne_RightBumper = 97,
        /// <summary>k_EControllerActionOrigin_XBoxOne_Menu</summary>
        XBoxOne_Menu = 98,
        /// <summary>k_EControllerActionOrigin_XBoxOne_View</summary>
        XBoxOne_View = 99,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftTrigger_Pull</summary>
        XBoxOne_LeftTrigger_Pull = 100,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftTrigger_Click</summary>
        XBoxOne_LeftTrigger_Click = 101,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightTrigger_Pull</summary>
        XBoxOne_RightTrigger_Pull = 102,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightTrigger_Click</summary>
        XBoxOne_RightTrigger_Click = 103,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftStick_Move</summary>
        XBoxOne_LeftStick_Move = 104,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftStick_Click</summary>
        XBoxOne_LeftStick_Click = 105,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftStick_DPadNorth</summary>
        XBoxOne_LeftStick_DPadNorth = 106,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftStick_DPadSouth</summary>
        XBoxOne_LeftStick_DPadSouth = 107,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftStick_DPadWest</summary>
        XBoxOne_LeftStick_DPadWest = 108,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftStick_DPadEast</summary>
        XBoxOne_LeftStick_DPadEast = 109,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightStick_Move</summary>
        XBoxOne_RightStick_Move = 110,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightStick_Click</summary>
        XBoxOne_RightStick_Click = 111,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightStick_DPadNorth</summary>
        XBoxOne_RightStick_DPadNorth = 112,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightStick_DPadSouth</summary>
        XBoxOne_RightStick_DPadSouth = 113,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightStick_DPadWest</summary>
        XBoxOne_RightStick_DPadWest = 114,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightStick_DPadEast</summary>
        XBoxOne_RightStick_DPadEast = 115,
        /// <summary>k_EControllerActionOrigin_XBoxOne_DPad_North</summary>
        XBoxOne_DPad_North = 116,
        /// <summary>k_EControllerActionOrigin_XBoxOne_DPad_South</summary>
        XBoxOne_DPad_South = 117,
        /// <summary>k_EControllerActionOrigin_XBoxOne_DPad_West</summary>
        XBoxOne_DPad_West = 118,
        /// <summary>k_EControllerActionOrigin_XBoxOne_DPad_East</summary>
        XBoxOne_DPad_East = 119,
        /// <summary>k_EControllerActionOrigin_XBox360_A</summary>
        XBox360_A = 120,
        /// <summary>k_EControllerActionOrigin_XBox360_B</summary>
        XBox360_B = 121,
        /// <summary>k_EControllerActionOrigin_XBox360_X</summary>
        XBox360_X = 122,
        /// <summary>k_EControllerActionOrigin_XBox360_Y</summary>
        XBox360_Y = 123,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftBumper</summary>
        XBox360_LeftBumper = 124,
        /// <summary>k_EControllerActionOrigin_XBox360_RightBumper</summary>
        XBox360_RightBumper = 125,
        /// <summary>k_EControllerActionOrigin_XBox360_Start</summary>
        XBox360_Start = 126,
        /// <summary>k_EControllerActionOrigin_XBox360_Back</summary>
        XBox360_Back = 127,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftTrigger_Pull</summary>
        XBox360_LeftTrigger_Pull = 128,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftTrigger_Click</summary>
        XBox360_LeftTrigger_Click = 129,
        /// <summary>k_EControllerActionOrigin_XBox360_RightTrigger_Pull</summary>
        XBox360_RightTrigger_Pull = 130,
        /// <summary>k_EControllerActionOrigin_XBox360_RightTrigger_Click</summary>
        XBox360_RightTrigger_Click = 131,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftStick_Move</summary>
        XBox360_LeftStick_Move = 132,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftStick_Click</summary>
        XBox360_LeftStick_Click = 133,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftStick_DPadNorth</summary>
        XBox360_LeftStick_DPadNorth = 134,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftStick_DPadSouth</summary>
        XBox360_LeftStick_DPadSouth = 135,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftStick_DPadWest</summary>
        XBox360_LeftStick_DPadWest = 136,
        /// <summary>k_EControllerActionOrigin_XBox360_LeftStick_DPadEast</summary>
        XBox360_LeftStick_DPadEast = 137,
        /// <summary>k_EControllerActionOrigin_XBox360_RightStick_Move</summary>
        XBox360_RightStick_Move = 138,
        /// <summary>k_EControllerActionOrigin_XBox360_RightStick_Click</summary>
        XBox360_RightStick_Click = 139,
        /// <summary>k_EControllerActionOrigin_XBox360_RightStick_DPadNorth</summary>
        XBox360_RightStick_DPadNorth = 140,
        /// <summary>k_EControllerActionOrigin_XBox360_RightStick_DPadSouth</summary>
        XBox360_RightStick_DPadSouth = 141,
        /// <summary>k_EControllerActionOrigin_XBox360_RightStick_DPadWest</summary>
        XBox360_RightStick_DPadWest = 142,
        /// <summary>k_EControllerActionOrigin_XBox360_RightStick_DPadEast</summary>
        XBox360_RightStick_DPadEast = 143,
        /// <summary>k_EControllerActionOrigin_XBox360_DPad_North</summary>
        XBox360_DPad_North = 144,
        /// <summary>k_EControllerActionOrigin_XBox360_DPad_South</summary>
        XBox360_DPad_South = 145,
        /// <summary>k_EControllerActionOrigin_XBox360_DPad_West</summary>
        XBox360_DPad_West = 146,
        /// <summary>k_EControllerActionOrigin_XBox360_DPad_East</summary>
        XBox360_DPad_East = 147,
        /// <summary>k_EControllerActionOrigin_SteamV2_A</summary>
        SteamV2_A = 148,
        /// <summary>k_EControllerActionOrigin_SteamV2_B</summary>
        SteamV2_B = 149,
        /// <summary>k_EControllerActionOrigin_SteamV2_X</summary>
        SteamV2_X = 150,
        /// <summary>k_EControllerActionOrigin_SteamV2_Y</summary>
        SteamV2_Y = 151,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftBumper</summary>
        SteamV2_LeftBumper = 152,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightBumper</summary>
        SteamV2_RightBumper = 153,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftGrip_Lower</summary>
        SteamV2_LeftGrip_Lower = 154,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftGrip_Upper</summary>
        SteamV2_LeftGrip_Upper = 155,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightGrip_Lower</summary>
        SteamV2_RightGrip_Lower = 156,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightGrip_Upper</summary>
        SteamV2_RightGrip_Upper = 157,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftBumper_Pressure</summary>
        SteamV2_LeftBumper_Pressure = 158,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightBumper_Pressure</summary>
        SteamV2_RightBumper_Pressure = 159,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftGrip_Pressure</summary>
        SteamV2_LeftGrip_Pressure = 160,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightGrip_Pressure</summary>
        SteamV2_RightGrip_Pressure = 161,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftGrip_Upper_Pressure</summary>
        SteamV2_LeftGrip_Upper_Pressure = 162,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightGrip_Upper_Pressure</summary>
        SteamV2_RightGrip_Upper_Pressure = 163,
        /// <summary>k_EControllerActionOrigin_SteamV2_Start</summary>
        SteamV2_Start = 164,
        /// <summary>k_EControllerActionOrigin_SteamV2_Back</summary>
        SteamV2_Back = 165,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_Touch</summary>
        SteamV2_LeftPad_Touch = 166,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_Swipe</summary>
        SteamV2_LeftPad_Swipe = 167,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_Click</summary>
        SteamV2_LeftPad_Click = 168,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_Pressure</summary>
        SteamV2_LeftPad_Pressure = 169,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_DPadNorth</summary>
        SteamV2_LeftPad_DPadNorth = 170,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_DPadSouth</summary>
        SteamV2_LeftPad_DPadSouth = 171,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_DPadWest</summary>
        SteamV2_LeftPad_DPadWest = 172,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftPad_DPadEast</summary>
        SteamV2_LeftPad_DPadEast = 173,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_Touch</summary>
        SteamV2_RightPad_Touch = 174,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_Swipe</summary>
        SteamV2_RightPad_Swipe = 175,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_Click</summary>
        SteamV2_RightPad_Click = 176,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_Pressure</summary>
        SteamV2_RightPad_Pressure = 177,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_DPadNorth</summary>
        SteamV2_RightPad_DPadNorth = 178,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_DPadSouth</summary>
        SteamV2_RightPad_DPadSouth = 179,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_DPadWest</summary>
        SteamV2_RightPad_DPadWest = 180,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightPad_DPadEast</summary>
        SteamV2_RightPad_DPadEast = 181,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftTrigger_Pull</summary>
        SteamV2_LeftTrigger_Pull = 182,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftTrigger_Click</summary>
        SteamV2_LeftTrigger_Click = 183,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightTrigger_Pull</summary>
        SteamV2_RightTrigger_Pull = 184,
        /// <summary>k_EControllerActionOrigin_SteamV2_RightTrigger_Click</summary>
        SteamV2_RightTrigger_Click = 185,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftStick_Move</summary>
        SteamV2_LeftStick_Move = 186,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftStick_Click</summary>
        SteamV2_LeftStick_Click = 187,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftStick_DPadNorth</summary>
        SteamV2_LeftStick_DPadNorth = 188,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftStick_DPadSouth</summary>
        SteamV2_LeftStick_DPadSouth = 189,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftStick_DPadWest</summary>
        SteamV2_LeftStick_DPadWest = 190,
        /// <summary>k_EControllerActionOrigin_SteamV2_LeftStick_DPadEast</summary>
        SteamV2_LeftStick_DPadEast = 191,
        /// <summary>k_EControllerActionOrigin_SteamV2_Gyro_Move</summary>
        SteamV2_Gyro_Move = 192,
        /// <summary>k_EControllerActionOrigin_SteamV2_Gyro_Pitch</summary>
        SteamV2_Gyro_Pitch = 193,
        /// <summary>k_EControllerActionOrigin_SteamV2_Gyro_Yaw</summary>
        SteamV2_Gyro_Yaw = 194,
        /// <summary>k_EControllerActionOrigin_SteamV2_Gyro_Roll</summary>
        SteamV2_Gyro_Roll = 195,
        /// <summary>k_EControllerActionOrigin_Switch_A</summary>
        Switch_A = 196,
        /// <summary>k_EControllerActionOrigin_Switch_B</summary>
        Switch_B = 197,
        /// <summary>k_EControllerActionOrigin_Switch_X</summary>
        Switch_X = 198,
        /// <summary>k_EControllerActionOrigin_Switch_Y</summary>
        Switch_Y = 199,
        /// <summary>k_EControllerActionOrigin_Switch_LeftBumper</summary>
        Switch_LeftBumper = 200,
        /// <summary>k_EControllerActionOrigin_Switch_RightBumper</summary>
        Switch_RightBumper = 201,
        /// <summary>k_EControllerActionOrigin_Switch_Plus</summary>
        Switch_Plus = 202,
        /// <summary>k_EControllerActionOrigin_Switch_Minus</summary>
        Switch_Minus = 203,
        /// <summary>k_EControllerActionOrigin_Switch_Capture</summary>
        Switch_Capture = 204,
        /// <summary>k_EControllerActionOrigin_Switch_LeftTrigger_Pull</summary>
        Switch_LeftTrigger_Pull = 205,
        /// <summary>k_EControllerActionOrigin_Switch_LeftTrigger_Click</summary>
        Switch_LeftTrigger_Click = 206,
        /// <summary>k_EControllerActionOrigin_Switch_RightTrigger_Pull</summary>
        Switch_RightTrigger_Pull = 207,
        /// <summary>k_EControllerActionOrigin_Switch_RightTrigger_Click</summary>
        Switch_RightTrigger_Click = 208,
        /// <summary>k_EControllerActionOrigin_Switch_LeftStick_Move</summary>
        Switch_LeftStick_Move = 209,
        /// <summary>k_EControllerActionOrigin_Switch_LeftStick_Click</summary>
        Switch_LeftStick_Click = 210,
        /// <summary>k_EControllerActionOrigin_Switch_LeftStick_DPadNorth</summary>
        Switch_LeftStick_DPadNorth = 211,
        /// <summary>k_EControllerActionOrigin_Switch_LeftStick_DPadSouth</summary>
        Switch_LeftStick_DPadSouth = 212,
        /// <summary>k_EControllerActionOrigin_Switch_LeftStick_DPadWest</summary>
        Switch_LeftStick_DPadWest = 213,
        /// <summary>k_EControllerActionOrigin_Switch_LeftStick_DPadEast</summary>
        Switch_LeftStick_DPadEast = 214,
        /// <summary>k_EControllerActionOrigin_Switch_RightStick_Move</summary>
        Switch_RightStick_Move = 215,
        /// <summary>k_EControllerActionOrigin_Switch_RightStick_Click</summary>
        Switch_RightStick_Click = 216,
        /// <summary>k_EControllerActionOrigin_Switch_RightStick_DPadNorth</summary>
        Switch_RightStick_DPadNorth = 217,
        /// <summary>k_EControllerActionOrigin_Switch_RightStick_DPadSouth</summary>
        Switch_RightStick_DPadSouth = 218,
        /// <summary>k_EControllerActionOrigin_Switch_RightStick_DPadWest</summary>
        Switch_RightStick_DPadWest = 219,
        /// <summary>k_EControllerActionOrigin_Switch_RightStick_DPadEast</summary>
        Switch_RightStick_DPadEast = 220,
        /// <summary>k_EControllerActionOrigin_Switch_DPad_North</summary>
        Switch_DPad_North = 221,
        /// <summary>k_EControllerActionOrigin_Switch_DPad_South</summary>
        Switch_DPad_South = 222,
        /// <summary>k_EControllerActionOrigin_Switch_DPad_West</summary>
        Switch_DPad_West = 223,
        /// <summary>k_EControllerActionOrigin_Switch_DPad_East</summary>
        Switch_DPad_East = 224,
        /// <summary>k_EControllerActionOrigin_Switch_ProGyro_Move</summary>
        Switch_ProGyro_Move = 225,
        /// <summary>k_EControllerActionOrigin_Switch_ProGyro_Pitch</summary>
        Switch_ProGyro_Pitch = 226,
        /// <summary>k_EControllerActionOrigin_Switch_ProGyro_Yaw</summary>
        Switch_ProGyro_Yaw = 227,
        /// <summary>k_EControllerActionOrigin_Switch_ProGyro_Roll</summary>
        Switch_ProGyro_Roll = 228,
        /// <summary>k_EControllerActionOrigin_Switch_RightGyro_Move</summary>
        Switch_RightGyro_Move = 229,
        /// <summary>k_EControllerActionOrigin_Switch_RightGyro_Pitch</summary>
        Switch_RightGyro_Pitch = 230,
        /// <summary>k_EControllerActionOrigin_Switch_RightGyro_Yaw</summary>
        Switch_RightGyro_Yaw = 231,
        /// <summary>k_EControllerActionOrigin_Switch_RightGyro_Roll</summary>
        Switch_RightGyro_Roll = 232,
        /// <summary>k_EControllerActionOrigin_Switch_LeftGyro_Move</summary>
        Switch_LeftGyro_Move = 233,
        /// <summary>k_EControllerActionOrigin_Switch_LeftGyro_Pitch</summary>
        Switch_LeftGyro_Pitch = 234,
        /// <summary>k_EControllerActionOrigin_Switch_LeftGyro_Yaw</summary>
        Switch_LeftGyro_Yaw = 235,
        /// <summary>k_EControllerActionOrigin_Switch_LeftGyro_Roll</summary>
        Switch_LeftGyro_Roll = 236,
        /// <summary>k_EControllerActionOrigin_Switch_LeftGrip_Lower</summary>
        Switch_LeftGrip_Lower = 237,
        /// <summary>k_EControllerActionOrigin_Switch_LeftGrip_Upper</summary>
        Switch_LeftGrip_Upper = 238,
        /// <summary>k_EControllerActionOrigin_Switch_RightGrip_Lower</summary>
        Switch_RightGrip_Lower = 239,
        /// <summary>k_EControllerActionOrigin_Switch_RightGrip_Upper</summary>
        Switch_RightGrip_Upper = 240,
        /// <summary>k_EControllerActionOrigin_PS4_DPad_Move</summary>
        PS4_DPad_Move = 241,
        /// <summary>k_EControllerActionOrigin_XBoxOne_DPad_Move</summary>
        XBoxOne_DPad_Move = 242,
        /// <summary>k_EControllerActionOrigin_XBox360_DPad_Move</summary>
        XBox360_DPad_Move = 243,
        /// <summary>k_EControllerActionOrigin_Switch_DPad_Move</summary>
        Switch_DPad_Move = 244,
        /// <summary>k_EControllerActionOrigin_PS5_X</summary>
        PS5_X = 245,
        /// <summary>k_EControllerActionOrigin_PS5_Circle</summary>
        PS5_Circle = 246,
        /// <summary>k_EControllerActionOrigin_PS5_Triangle</summary>
        PS5_Triangle = 247,
        /// <summary>k_EControllerActionOrigin_PS5_Square</summary>
        PS5_Square = 248,
        /// <summary>k_EControllerActionOrigin_PS5_LeftBumper</summary>
        PS5_LeftBumper = 249,
        /// <summary>k_EControllerActionOrigin_PS5_RightBumper</summary>
        PS5_RightBumper = 250,
        /// <summary>k_EControllerActionOrigin_PS5_Option</summary>
        PS5_Option = 251,
        /// <summary>k_EControllerActionOrigin_PS5_Create</summary>
        PS5_Create = 252,
        /// <summary>k_EControllerActionOrigin_PS5_Mute</summary>
        PS5_Mute = 253,
        /// <summary>k_EControllerActionOrigin_PS5_LeftPad_Touch</summary>
        PS5_LeftPad_Touch = 254,
        /// <summary>k_EControllerActionOrigin_PS5_LeftPad_Swipe</summary>
        PS5_LeftPad_Swipe = 255,
        /// <summary>k_EControllerActionOrigin_PS5_LeftPad_Click</summary>
        PS5_LeftPad_Click = 256,
        /// <summary>k_EControllerActionOrigin_PS5_LeftPad_DPadNorth</summary>
        PS5_LeftPad_DPadNorth = 257,
        /// <summary>k_EControllerActionOrigin_PS5_LeftPad_DPadSouth</summary>
        PS5_LeftPad_DPadSouth = 258,
        /// <summary>k_EControllerActionOrigin_PS5_LeftPad_DPadWest</summary>
        PS5_LeftPad_DPadWest = 259,
        /// <summary>k_EControllerActionOrigin_PS5_LeftPad_DPadEast</summary>
        PS5_LeftPad_DPadEast = 260,
        /// <summary>k_EControllerActionOrigin_PS5_RightPad_Touch</summary>
        PS5_RightPad_Touch = 261,
        /// <summary>k_EControllerActionOrigin_PS5_RightPad_Swipe</summary>
        PS5_RightPad_Swipe = 262,
        /// <summary>k_EControllerActionOrigin_PS5_RightPad_Click</summary>
        PS5_RightPad_Click = 263,
        /// <summary>k_EControllerActionOrigin_PS5_RightPad_DPadNorth</summary>
        PS5_RightPad_DPadNorth = 264,
        /// <summary>k_EControllerActionOrigin_PS5_RightPad_DPadSouth</summary>
        PS5_RightPad_DPadSouth = 265,
        /// <summary>k_EControllerActionOrigin_PS5_RightPad_DPadWest</summary>
        PS5_RightPad_DPadWest = 266,
        /// <summary>k_EControllerActionOrigin_PS5_RightPad_DPadEast</summary>
        PS5_RightPad_DPadEast = 267,
        /// <summary>k_EControllerActionOrigin_PS5_CenterPad_Touch</summary>
        PS5_CenterPad_Touch = 268,
        /// <summary>k_EControllerActionOrigin_PS5_CenterPad_Swipe</summary>
        PS5_CenterPad_Swipe = 269,
        /// <summary>k_EControllerActionOrigin_PS5_CenterPad_Click</summary>
        PS5_CenterPad_Click = 270,
        /// <summary>k_EControllerActionOrigin_PS5_CenterPad_DPadNorth</summary>
        PS5_CenterPad_DPadNorth = 271,
        /// <summary>k_EControllerActionOrigin_PS5_CenterPad_DPadSouth</summary>
        PS5_CenterPad_DPadSouth = 272,
        /// <summary>k_EControllerActionOrigin_PS5_CenterPad_DPadWest</summary>
        PS5_CenterPad_DPadWest = 273,
        /// <summary>k_EControllerActionOrigin_PS5_CenterPad_DPadEast</summary>
        PS5_CenterPad_DPadEast = 274,
        /// <summary>k_EControllerActionOrigin_PS5_LeftTrigger_Pull</summary>
        PS5_LeftTrigger_Pull = 275,
        /// <summary>k_EControllerActionOrigin_PS5_LeftTrigger_Click</summary>
        PS5_LeftTrigger_Click = 276,
        /// <summary>k_EControllerActionOrigin_PS5_RightTrigger_Pull</summary>
        PS5_RightTrigger_Pull = 277,
        /// <summary>k_EControllerActionOrigin_PS5_RightTrigger_Click</summary>
        PS5_RightTrigger_Click = 278,
        /// <summary>k_EControllerActionOrigin_PS5_LeftStick_Move</summary>
        PS5_LeftStick_Move = 279,
        /// <summary>k_EControllerActionOrigin_PS5_LeftStick_Click</summary>
        PS5_LeftStick_Click = 280,
        /// <summary>k_EControllerActionOrigin_PS5_LeftStick_DPadNorth</summary>
        PS5_LeftStick_DPadNorth = 281,
        /// <summary>k_EControllerActionOrigin_PS5_LeftStick_DPadSouth</summary>
        PS5_LeftStick_DPadSouth = 282,
        /// <summary>k_EControllerActionOrigin_PS5_LeftStick_DPadWest</summary>
        PS5_LeftStick_DPadWest = 283,
        /// <summary>k_EControllerActionOrigin_PS5_LeftStick_DPadEast</summary>
        PS5_LeftStick_DPadEast = 284,
        /// <summary>k_EControllerActionOrigin_PS5_RightStick_Move</summary>
        PS5_RightStick_Move = 285,
        /// <summary>k_EControllerActionOrigin_PS5_RightStick_Click</summary>
        PS5_RightStick_Click = 286,
        /// <summary>k_EControllerActionOrigin_PS5_RightStick_DPadNorth</summary>
        PS5_RightStick_DPadNorth = 287,
        /// <summary>k_EControllerActionOrigin_PS5_RightStick_DPadSouth</summary>
        PS5_RightStick_DPadSouth = 288,
        /// <summary>k_EControllerActionOrigin_PS5_RightStick_DPadWest</summary>
        PS5_RightStick_DPadWest = 289,
        /// <summary>k_EControllerActionOrigin_PS5_RightStick_DPadEast</summary>
        PS5_RightStick_DPadEast = 290,
        /// <summary>k_EControllerActionOrigin_PS5_DPad_Move</summary>
        PS5_DPad_Move = 291,
        /// <summary>k_EControllerActionOrigin_PS5_DPad_North</summary>
        PS5_DPad_North = 292,
        /// <summary>k_EControllerActionOrigin_PS5_DPad_South</summary>
        PS5_DPad_South = 293,
        /// <summary>k_EControllerActionOrigin_PS5_DPad_West</summary>
        PS5_DPad_West = 294,
        /// <summary>k_EControllerActionOrigin_PS5_DPad_East</summary>
        PS5_DPad_East = 295,
        /// <summary>k_EControllerActionOrigin_PS5_Gyro_Move</summary>
        PS5_Gyro_Move = 296,
        /// <summary>k_EControllerActionOrigin_PS5_Gyro_Pitch</summary>
        PS5_Gyro_Pitch = 297,
        /// <summary>k_EControllerActionOrigin_PS5_Gyro_Yaw</summary>
        PS5_Gyro_Yaw = 298,
        /// <summary>k_EControllerActionOrigin_PS5_Gyro_Roll</summary>
        PS5_Gyro_Roll = 299,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftGrip_Lower</summary>
        XBoxOne_LeftGrip_Lower = 300,
        /// <summary>k_EControllerActionOrigin_XBoxOne_LeftGrip_Upper</summary>
        XBoxOne_LeftGrip_Upper = 301,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightGrip_Lower</summary>
        XBoxOne_RightGrip_Lower = 302,
        /// <summary>k_EControllerActionOrigin_XBoxOne_RightGrip_Upper</summary>
        XBoxOne_RightGrip_Upper = 303,
        /// <summary>k_EControllerActionOrigin_XBoxOne_Share</summary>
        XBoxOne_Share = 304,
        /// <summary>k_EControllerActionOrigin_SteamDeck_A</summary>
        SteamDeck_A = 305,
        /// <summary>k_EControllerActionOrigin_SteamDeck_B</summary>
        SteamDeck_B = 306,
        /// <summary>k_EControllerActionOrigin_SteamDeck_X</summary>
        SteamDeck_X = 307,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Y</summary>
        SteamDeck_Y = 308,
        /// <summary>k_EControllerActionOrigin_SteamDeck_L1</summary>
        SteamDeck_L1 = 309,
        /// <summary>k_EControllerActionOrigin_SteamDeck_R1</summary>
        SteamDeck_R1 = 310,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Menu</summary>
        SteamDeck_Menu = 311,
        /// <summary>k_EControllerActionOrigin_SteamDeck_View</summary>
        SteamDeck_View = 312,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftPad_Touch</summary>
        SteamDeck_LeftPad_Touch = 313,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftPad_Swipe</summary>
        SteamDeck_LeftPad_Swipe = 314,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftPad_Click</summary>
        SteamDeck_LeftPad_Click = 315,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftPad_DPadNorth</summary>
        SteamDeck_LeftPad_DPadNorth = 316,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftPad_DPadSouth</summary>
        SteamDeck_LeftPad_DPadSouth = 317,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftPad_DPadWest</summary>
        SteamDeck_LeftPad_DPadWest = 318,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftPad_DPadEast</summary>
        SteamDeck_LeftPad_DPadEast = 319,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightPad_Touch</summary>
        SteamDeck_RightPad_Touch = 320,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightPad_Swipe</summary>
        SteamDeck_RightPad_Swipe = 321,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightPad_Click</summary>
        SteamDeck_RightPad_Click = 322,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightPad_DPadNorth</summary>
        SteamDeck_RightPad_DPadNorth = 323,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightPad_DPadSouth</summary>
        SteamDeck_RightPad_DPadSouth = 324,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightPad_DPadWest</summary>
        SteamDeck_RightPad_DPadWest = 325,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightPad_DPadEast</summary>
        SteamDeck_RightPad_DPadEast = 326,
        /// <summary>k_EControllerActionOrigin_SteamDeck_L2_SoftPull</summary>
        SteamDeck_L2_SoftPull = 327,
        /// <summary>k_EControllerActionOrigin_SteamDeck_L2</summary>
        SteamDeck_L2 = 328,
        /// <summary>k_EControllerActionOrigin_SteamDeck_R2_SoftPull</summary>
        SteamDeck_R2_SoftPull = 329,
        /// <summary>k_EControllerActionOrigin_SteamDeck_R2</summary>
        SteamDeck_R2 = 330,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftStick_Move</summary>
        SteamDeck_LeftStick_Move = 331,
        /// <summary>k_EControllerActionOrigin_SteamDeck_L3</summary>
        SteamDeck_L3 = 332,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftStick_DPadNorth</summary>
        SteamDeck_LeftStick_DPadNorth = 333,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftStick_DPadSouth</summary>
        SteamDeck_LeftStick_DPadSouth = 334,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftStick_DPadWest</summary>
        SteamDeck_LeftStick_DPadWest = 335,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftStick_DPadEast</summary>
        SteamDeck_LeftStick_DPadEast = 336,
        /// <summary>k_EControllerActionOrigin_SteamDeck_LeftStick_Touch</summary>
        SteamDeck_LeftStick_Touch = 337,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightStick_Move</summary>
        SteamDeck_RightStick_Move = 338,
        /// <summary>k_EControllerActionOrigin_SteamDeck_R3</summary>
        SteamDeck_R3 = 339,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightStick_DPadNorth</summary>
        SteamDeck_RightStick_DPadNorth = 340,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightStick_DPadSouth</summary>
        SteamDeck_RightStick_DPadSouth = 341,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightStick_DPadWest</summary>
        SteamDeck_RightStick_DPadWest = 342,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightStick_DPadEast</summary>
        SteamDeck_RightStick_DPadEast = 343,
        /// <summary>k_EControllerActionOrigin_SteamDeck_RightStick_Touch</summary>
        SteamDeck_RightStick_Touch = 344,
        /// <summary>k_EControllerActionOrigin_SteamDeck_L4</summary>
        SteamDeck_L4 = 345,
        /// <summary>k_EControllerActionOrigin_SteamDeck_R4</summary>
        SteamDeck_R4 = 346,
        /// <summary>k_EControllerActionOrigin_SteamDeck_L5</summary>
        SteamDeck_L5 = 347,
        /// <summary>k_EControllerActionOrigin_SteamDeck_R5</summary>
        SteamDeck_R5 = 348,
        /// <summary>k_EControllerActionOrigin_SteamDeck_DPad_Move</summary>
        SteamDeck_DPad_Move = 349,
        /// <summary>k_EControllerActionOrigin_SteamDeck_DPad_North</summary>
        SteamDeck_DPad_North = 350,
        /// <summary>k_EControllerActionOrigin_SteamDeck_DPad_South</summary>
        SteamDeck_DPad_South = 351,
        /// <summary>k_EControllerActionOrigin_SteamDeck_DPad_West</summary>
        SteamDeck_DPad_West = 352,
        /// <summary>k_EControllerActionOrigin_SteamDeck_DPad_East</summary>
        SteamDeck_DPad_East = 353,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Gyro_Move</summary>
        SteamDeck_Gyro_Move = 354,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Gyro_Pitch</summary>
        SteamDeck_Gyro_Pitch = 355,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Gyro_Yaw</summary>
        SteamDeck_Gyro_Yaw = 356,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Gyro_Roll</summary>
        SteamDeck_Gyro_Roll = 357,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved1</summary>
        SteamDeck_Reserved1 = 358,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved2</summary>
        SteamDeck_Reserved2 = 359,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved3</summary>
        SteamDeck_Reserved3 = 360,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved4</summary>
        SteamDeck_Reserved4 = 361,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved5</summary>
        SteamDeck_Reserved5 = 362,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved6</summary>
        SteamDeck_Reserved6 = 363,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved7</summary>
        SteamDeck_Reserved7 = 364,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved8</summary>
        SteamDeck_Reserved8 = 365,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved9</summary>
        SteamDeck_Reserved9 = 366,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved10</summary>
        SteamDeck_Reserved10 = 367,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved11</summary>
        SteamDeck_Reserved11 = 368,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved12</summary>
        SteamDeck_Reserved12 = 369,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved13</summary>
        SteamDeck_Reserved13 = 370,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved14</summary>
        SteamDeck_Reserved14 = 371,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved15</summary>
        SteamDeck_Reserved15 = 372,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved16</summary>
        SteamDeck_Reserved16 = 373,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved17</summary>
        SteamDeck_Reserved17 = 374,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved18</summary>
        SteamDeck_Reserved18 = 375,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved19</summary>
        SteamDeck_Reserved19 = 376,
        /// <summary>k_EControllerActionOrigin_SteamDeck_Reserved20</summary>
        SteamDeck_Reserved20 = 377,
        /// <summary>k_EControllerActionOrigin_Switch_JoyConButton_N</summary>
        Switch_JoyConButton_N = 378,
        /// <summary>k_EControllerActionOrigin_Switch_JoyConButton_E</summary>
        Switch_JoyConButton_E = 379,
        /// <summary>k_EControllerActionOrigin_Switch_JoyConButton_S</summary>
        Switch_JoyConButton_S = 380,
        /// <summary>k_EControllerActionOrigin_Switch_JoyConButton_W</summary>
        Switch_JoyConButton_W = 381,
        /// <summary>k_EControllerActionOrigin_PS5_LeftGrip</summary>
        PS5_LeftGrip = 382,
        /// <summary>k_EControllerActionOrigin_PS5_RightGrip</summary>
        PS5_RightGrip = 383,
        /// <summary>k_EControllerActionOrigin_PS5_LeftFn</summary>
        PS5_LeftFn = 384,
        /// <summary>k_EControllerActionOrigin_PS5_RightFn</summary>
        PS5_RightFn = 385,
        /// <summary>k_EControllerActionOrigin_Count</summary>
        Count = 386,
        /// <summary>k_EControllerActionOrigin_MaximumPossibleValue</summary>
        MaximumPossibleValue = 32767
    }
}