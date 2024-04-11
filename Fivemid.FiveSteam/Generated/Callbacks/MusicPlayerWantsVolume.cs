using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerWantsVolume_t</summary>
    public unsafe struct MusicPlayerWantsVolume : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsVolume;
        /// <summary>float m_flNewVolume</summary>
        public float flNewVolume;
    }
}