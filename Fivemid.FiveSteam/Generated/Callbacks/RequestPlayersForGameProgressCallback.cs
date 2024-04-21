using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for RequestPlayersForGameProgressCallback_t
    public unsafe struct RequestPlayersForGameProgressCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RequestPlayersForGameProgressCallback;
        /// missing documentation for RequestPlayersForGameProgressCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for RequestPlayersForGameProgressCallback_t.m_ullSearchID
        public ulong ullSearchID;
    }
}