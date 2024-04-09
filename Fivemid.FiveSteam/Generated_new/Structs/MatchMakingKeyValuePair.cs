using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MatchMakingKeyValuePair_t</summary>
    public unsafe struct MatchMakingKeyValuePair
    {
        /// <summary>char [256] m_szKey</summary>
        public UTF8String256 szKey;
        /// <summary>char [256] m_szValue</summary>
        public UTF8String256 szValue;
    }
}