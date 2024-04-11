using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ActiveBeaconsUpdated_t</summary>
    public unsafe struct ActiveBeaconsUpdated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ActiveBeaconsUpdated;
    }
}