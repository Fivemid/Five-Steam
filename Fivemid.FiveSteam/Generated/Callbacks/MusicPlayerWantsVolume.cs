using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct MusicPlayerWantsVolume : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsVolume;
        /// <summary></summary>
        public float flNewVolume;
    }
}