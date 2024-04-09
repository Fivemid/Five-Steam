using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUniverse</summary>
    public enum Universe : int
    {
        /// <summary>k_EUniverseInvalid</summary>
        Invalid = 0,
        /// <summary>k_EUniversePublic</summary>
        Public = 1,
        /// <summary>k_EUniverseBeta</summary>
        Beta = 2,
        /// <summary>k_EUniverseInternal</summary>
        Internal = 3,
        /// <summary>k_EUniverseDev</summary>
        Dev = 4,
        /// <summary>k_EUniverseMax</summary>
        Max = 5
    }
}