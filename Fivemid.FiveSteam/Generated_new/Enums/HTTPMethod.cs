using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EHTTPMethod</summary>
    public enum HTTPMethod : int
    {
        /// <summary>k_EHTTPMethodInvalid</summary>
        Invalid = 0,
        /// <summary>k_EHTTPMethodGET</summary>
        GET = 1,
        /// <summary>k_EHTTPMethodHEAD</summary>
        HEAD = 2,
        /// <summary>k_EHTTPMethodPOST</summary>
        POST = 3,
        /// <summary>k_EHTTPMethodPUT</summary>
        PUT = 4,
        /// <summary>k_EHTTPMethodDELETE</summary>
        DELETE = 5,
        /// <summary>k_EHTTPMethodOPTIONS</summary>
        OPTIONS = 6,
        /// <summary>k_EHTTPMethodPATCH</summary>
        PATCH = 7
    }
}