using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// This callback has no fields.</summary>
    public unsafe struct PlaybackStatusHasChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.PlaybackStatusHasChanged;
    }
}