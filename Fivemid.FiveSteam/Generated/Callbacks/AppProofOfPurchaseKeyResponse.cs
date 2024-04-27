using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Only used internally in Steam.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct AppProofOfPurchaseKeyResponse
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AppProofOfPurchaseKeyResponse;
        /// <summary></summary>
        public Result eResult;
        /// <summary></summary>
        public uint nAppID;
        /// <summary></summary>
        public uint cchKeyLength;
        /// <summary></summary>
        public UTF8String240 rgchKey;
    }
}