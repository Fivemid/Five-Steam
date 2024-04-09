using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EServerMode</summary>
    public enum ServerMode : int
    {
        /// <summary>eServerModeInvalid</summary>
        eServerModeInvalid = 0,
        /// <summary>eServerModeNoAuthentication</summary>
        eServerModeNoAuthentication = 1,
        /// <summary>eServerModeAuthentication</summary>
        eServerModeAuthentication = 2,
        /// <summary>eServerModeAuthenticationAndSecure</summary>
        eServerModeAuthenticationAndSecure = 3
    }
}