using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerRemoteToFront_t</summary>
    public unsafe struct MusicPlayerRemoteToFront : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerRemoteToFront;
    }
}