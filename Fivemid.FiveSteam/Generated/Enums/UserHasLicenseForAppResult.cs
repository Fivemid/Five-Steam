using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Result of
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#UserHasLicenseForApp" class="bb_apilink">ISteamUser::UserHasLicenseForApp</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum UserHasLicenseForAppResult : int
    {
        /// <summary>The user has a license for specified app.</summary>
        UserHasLicenseResultHasLicense = 0,
        /// <summary>The user does not have a license for the specified app.</summary>
        UserHasLicenseResultDoesNotHaveLicense = 1,
        /// <summary>The user has not been authenticated.</summary>
        UserHasLicenseResultNoAuth = 2
    }
}