using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for RequestPlayersForGameFinalResultCallback_t
    public unsafe struct RequestPlayersForGameFinalResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RequestPlayersForGameFinalResultCallback;
        /// missing documentation for RequestPlayersForGameFinalResultCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for RequestPlayersForGameFinalResultCallback_t.m_ullSearchID
        public ulong ullSearchID;
        /// missing documentation for RequestPlayersForGameFinalResultCallback_t.m_ullUniqueGameID
        public ulong ullUniqueGameID;
    }
}