using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// 
    /// </summary>
    public unsafe struct SteamParamStringArray
    {
        /// <summary>Array of strings.</summary>
        public UTF8StringPtr* ppStrings;
        /// <summary>The number of strings that are in [param]m_ppStrings[/param].</summary>
        public int nNumStrings;
    }
}