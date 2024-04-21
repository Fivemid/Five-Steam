using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SubmitPlayerResultResultCallback_t
    public unsafe struct SubmitPlayerResultResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SubmitPlayerResultResultCallback;
        /// missing documentation for SubmitPlayerResultResultCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for SubmitPlayerResultResultCallback_t.ullUniqueGameID
        public ulong ullUniqueGameID;
        /// missing documentation for SubmitPlayerResultResultCallback_t.steamIDPlayer
        public SteamId steamIDPlayer;
    }
}