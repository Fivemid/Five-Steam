using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ECheckFileSignature</summary>
    public enum CheckFileSignatureType : int
    {
        /// <summary>k_ECheckFileSignatureInvalidSignature</summary>
        CheckFileSignatureInvalidSignature = 0,
        /// <summary>k_ECheckFileSignatureValidSignature</summary>
        CheckFileSignatureValidSignature = 1,
        /// <summary>k_ECheckFileSignatureFileNotFound</summary>
        CheckFileSignatureFileNotFound = 2,
        /// <summary>k_ECheckFileSignatureNoSignaturesFoundForThisApp</summary>
        CheckFileSignatureNoSignaturesFoundForThisApp = 3,
        /// <summary>k_ECheckFileSignatureNoSignaturesFoundForThisFile</summary>
        CheckFileSignatureNoSignaturesFoundForThisFile = 4
    }
}