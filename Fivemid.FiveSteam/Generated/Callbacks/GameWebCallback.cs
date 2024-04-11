using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameWebCallback_t</summary>
    public unsafe struct GameWebCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameWebCallback;
        /// <summary>char [256] m_szURL</summary>
        public UTF8String256 szURL;
    }
}