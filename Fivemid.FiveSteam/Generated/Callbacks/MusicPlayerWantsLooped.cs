using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerWantsLooped_t</summary>
    public unsafe struct MusicPlayerWantsLooped : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsLooped;
        /// <summary>bool m_bLooped</summary>
        public bool bLooped;
    }
}