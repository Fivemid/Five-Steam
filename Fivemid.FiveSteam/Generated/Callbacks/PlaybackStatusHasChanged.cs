using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>PlaybackStatusHasChanged_t</summary>
    public unsafe struct PlaybackStatusHasChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.PlaybackStatusHasChanged;
    }
}