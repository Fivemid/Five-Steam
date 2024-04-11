using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EndGameResultCallback_t</summary>
    public unsafe struct EndGameResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EndGameResultCallback;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 ullUniqueGameID</summary>
        public ulong ullUniqueGameID;
    }
}