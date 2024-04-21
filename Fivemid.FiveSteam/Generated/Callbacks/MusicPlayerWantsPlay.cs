using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// <br />
    /// This callback has no fields.
    /// </summary>
    public unsafe struct MusicPlayerWantsPlay : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsPlay;
    }
}