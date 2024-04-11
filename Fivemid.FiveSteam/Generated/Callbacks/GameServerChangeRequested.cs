using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameServerChangeRequested_t</summary>
    public unsafe struct GameServerChangeRequested : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameServerChangeRequested;
        /// <summary>char [64] m_rgchServer</summary>
        public UTF8String64 rgchServer;
        /// <summary>char [64] m_rgchPassword</summary>
        public UTF8String64 rgchPassword;
    }
}