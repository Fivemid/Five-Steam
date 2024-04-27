using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>CallResult for <a href="https://partner.steamgames.com/doc/api/ISteamUtils#CheckFileSignature" class="bb_apilink">ISteamUtils::CheckFileSignature</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#CheckFileSignature" class="bb_apilink">ISteamUtils::CheckFileSignature</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct CheckFileSignature
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.CheckFileSignature;
        /// <summary>Contains the result of the file signature check.<br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#k_ECheckFileSignatureNoSignaturesFoundForThisApp" class="bb_apilink">k_ECheckFileSignatureNoSignaturesFoundForThisApp</a> - This app has not been configured on the signing tab of the partner site to enable this function.<br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#k_ECheckFileSignatureNoSignaturesFoundForThisFile" class="bb_apilink">k_ECheckFileSignatureNoSignaturesFoundForThisFile</a> - This file is not listed on the signing tab for the partner site.<br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#k_ECheckFileSignatureFileNotFound" class="bb_apilink">k_ECheckFileSignatureFileNotFound</a> - The file does not exist on disk.<br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#k_ECheckFileSignatureInvalidSignature" class="bb_apilink">k_ECheckFileSignatureInvalidSignature</a> - The file exists, and the signing tab has been set for this file, but the file is either not signed or the signature does not match.<br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#k_ECheckFileSignatureValidSignature" class="bb_apilink">k_ECheckFileSignatureValidSignature</a> - The file is signed and the signature is valid.</summary>
        public CheckFileSignatureType eCheckFileSignature;
    }
}