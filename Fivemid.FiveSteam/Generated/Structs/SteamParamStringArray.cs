using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamParamStringArray_t</summary>
    public unsafe struct SteamParamStringArray
    {
        /// <summary>const char ** m_ppStrings</summary>
        public UTF8StringPtr* ppStrings;
        /// <summary>int32 m_nNumStrings</summary>
        public int nNumStrings;
    }
}