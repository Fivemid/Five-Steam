using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for EGameSearchErrorCode_t
    public enum GameSearchErrorCode : int
    {
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_OK
        OK = 1,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_Search_Already_In_Progress
        Failed_Search_Already_In_Progress = 2,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_No_Search_In_Progress
        Failed_No_Search_In_Progress = 3,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_Not_Lobby_Leader
        Failed_Not_Lobby_Leader = 4,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_No_Host_Available
        Failed_No_Host_Available = 5,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_Search_Params_Invalid
        Failed_Search_Params_Invalid = 6,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_Offline
        Failed_Offline = 7,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_NotAuthorized
        Failed_NotAuthorized = 8,
        /// missing documentation for EGameSearchErrorCode_t.k_EGameSearchErrorCode_Failed_Unknown_Error
        Failed_Unknown_Error = 9
    }
}