using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerWantsShuffled_t</summary>
    public unsafe struct MusicPlayerWantsShuffled : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsShuffled;
        /// <summary>bool m_bShuffled</summary>
        public bool bShuffled;
    }
}