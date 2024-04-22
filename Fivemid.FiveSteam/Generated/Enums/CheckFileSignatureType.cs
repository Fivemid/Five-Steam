using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>The result of a call to <a href="https://partner.steamgames.com/doc/api/ISteamUtils#CheckFileSignature" class="bb_apilink">ISteamUtils::CheckFileSignature</a><br />
    /// <br />
    /// </summary>
    public enum CheckFileSignatureType : int
    {
        /// <summary></summary>
        CheckFileSignatureInvalidSignature = 0,
        /// <summary></summary>
        CheckFileSignatureValidSignature = 1,
        /// <summary></summary>
        CheckFileSignatureFileNotFound = 2,
        /// <summary></summary>
        CheckFileSignatureNoSignaturesFoundForThisApp = 3,
        /// <summary></summary>
        CheckFileSignatureNoSignaturesFoundForThisFile = 4
    }
}