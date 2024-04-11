using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SubmitPlayerResultResultCallback_t</summary>
    public unsafe struct SubmitPlayerResultResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SubmitPlayerResultResultCallback;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 ullUniqueGameID</summary>
        public ulong ullUniqueGameID;
        /// <summary>CSteamID steamIDPlayer</summary>
        public SteamId steamIDPlayer;
    }
}