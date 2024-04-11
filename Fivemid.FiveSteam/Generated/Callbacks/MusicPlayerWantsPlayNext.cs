using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerWantsPlayNext_t</summary>
    public unsafe struct MusicPlayerWantsPlayNext : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsPlayNext;
    }
}