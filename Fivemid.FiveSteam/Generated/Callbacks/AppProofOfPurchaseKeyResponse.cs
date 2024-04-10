using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AppProofOfPurchaseKeyResponse_t</summary>
    public unsafe struct AppProofOfPurchaseKeyResponse
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint32 m_nAppID</summary>
        public uint nAppID;
        /// <summary>uint32 m_cchKeyLength</summary>
        public uint cchKeyLength;
        /// <summary>char [240] m_rgchKey</summary>
        public UTF8String240 rgchKey;
    }
}