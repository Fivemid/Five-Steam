using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for EndGameResultCallback_t
    public unsafe struct EndGameResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EndGameResultCallback;
        /// missing documentation for EndGameResultCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for EndGameResultCallback_t.ullUniqueGameID
        public ulong ullUniqueGameID;
    }
}