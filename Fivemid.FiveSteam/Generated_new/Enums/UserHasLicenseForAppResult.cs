using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUserHasLicenseForAppResult</summary>
    public enum UserHasLicenseForAppResult : int
    {
        /// <summary>k_EUserHasLicenseResultHasLicense</summary>
        UserHasLicenseResultHasLicense = 0,
        /// <summary>k_EUserHasLicenseResultDoesNotHaveLicense</summary>
        UserHasLicenseResultDoesNotHaveLicense = 1,
        /// <summary>k_EUserHasLicenseResultNoAuth</summary>
        UserHasLicenseResultNoAuth = 2
    }
}