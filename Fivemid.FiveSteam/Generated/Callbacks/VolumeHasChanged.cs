using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>VolumeHasChanged_t</summary>
    public unsafe struct VolumeHasChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.VolumeHasChanged;
        /// <summary>float m_flNewVolume</summary>
        public float flNewVolume;
    }
}