using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for RequestPlayersForGameProgressCallback_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RequestPlayersForGameProgressCallback
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RequestPlayersForGameProgressCallback;
        /// missing documentation for RequestPlayersForGameProgressCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for RequestPlayersForGameProgressCallback_t.m_ullSearchID
        public ulong ullSearchID;
    }
}