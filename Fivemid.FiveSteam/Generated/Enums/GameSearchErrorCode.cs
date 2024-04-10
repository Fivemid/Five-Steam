using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EGameSearchErrorCode_t</summary>
    public enum GameSearchErrorCode : int
    {
        /// <summary>k_EGameSearchErrorCode_OK</summary>
        OK = 1,
        /// <summary>k_EGameSearchErrorCode_Failed_Search_Already_In_Progress</summary>
        Failed_Search_Already_In_Progress = 2,
        /// <summary>k_EGameSearchErrorCode_Failed_No_Search_In_Progress</summary>
        Failed_No_Search_In_Progress = 3,
        /// <summary>k_EGameSearchErrorCode_Failed_Not_Lobby_Leader</summary>
        Failed_Not_Lobby_Leader = 4,
        /// <summary>k_EGameSearchErrorCode_Failed_No_Host_Available</summary>
        Failed_No_Host_Available = 5,
        /// <summary>k_EGameSearchErrorCode_Failed_Search_Params_Invalid</summary>
        Failed_Search_Params_Invalid = 6,
        /// <summary>k_EGameSearchErrorCode_Failed_Offline</summary>
        Failed_Offline = 7,
        /// <summary>k_EGameSearchErrorCode_Failed_NotAuthorized</summary>
        Failed_NotAuthorized = 8,
        /// <summary>k_EGameSearchErrorCode_Failed_Unknown_Error</summary>
        Failed_Unknown_Error = 9
    }
}