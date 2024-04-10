using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUGCReadAction</summary>
    public enum UGCReadAction : int
    {
        /// <summary>k_EUGCRead_ContinueReadingUntilFinished</summary>
        UGCRead_ContinueReadingUntilFinished = 0,
        /// <summary>k_EUGCRead_ContinueReading</summary>
        UGCRead_ContinueReading = 1,
        /// <summary>k_EUGCRead_Close</summary>
        UGCRead_Close = 2
    }
}