using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for EndGameResultCallback_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct EndGameResultCallback
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EndGameResultCallback;
        /// missing documentation for EndGameResultCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for EndGameResultCallback_t.ullUniqueGameID
        public ulong ullUniqueGameID;
    }
}