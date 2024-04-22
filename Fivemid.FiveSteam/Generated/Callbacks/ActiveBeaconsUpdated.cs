using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Notification that the list of active beacons visible to the current user has changed. <br />
    /// <br />
    /// This callback has no members.</summary>
    public unsafe struct ActiveBeaconsUpdated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ActiveBeaconsUpdated;
    }
}