using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct MusicPlayerWantsLooped : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsLooped;
        /// <summary></summary>
        public bool bLooped;
    }
}