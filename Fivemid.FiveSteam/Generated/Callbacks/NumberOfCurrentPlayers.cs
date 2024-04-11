using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>NumberOfCurrentPlayers_t</summary>
    public unsafe struct NumberOfCurrentPlayers : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.NumberOfCurrentPlayers;
        /// <summary>uint8 m_bSuccess</summary>
        public byte bSuccess;
        /// <summary>int32 m_cPlayers</summary>
        public int cPlayers;
    }
}