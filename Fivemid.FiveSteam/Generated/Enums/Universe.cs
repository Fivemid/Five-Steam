using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Steam universes. Each universe is a self-contained Steam instance.<br />
    /// <br />
    /// </summary>
    public enum Universe : int
    {
        /// <summary>Invalid.</summary>
        Invalid = 0,
        /// <summary>The standard public universe.</summary>
        Public = 1,
        /// <summary>Beta universe used inside Valve.</summary>
        Beta = 2,
        /// <summary>Internal universe used inside Valve.</summary>
        Internal = 3,
        /// <summary>Dev universe used inside Valve.</summary>
        Dev = 4,
        /// <summary>Total number of universes, used for sanity checks.</summary>
        Max = 5
    }
}