using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyMatchList_t</summary>
    public unsafe struct LobbyMatchList : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyMatchList;
        /// <summary>uint32 m_nLobbiesMatching</summary>
        public uint nLobbiesMatching;
    }
}