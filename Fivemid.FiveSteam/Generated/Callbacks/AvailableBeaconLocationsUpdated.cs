using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Notification that the list of available locations for posting a beacon has been updated. <br />
    /// <br />
    /// This callback has no members.
    /// </summary>
    public unsafe struct AvailableBeaconLocationsUpdated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AvailableBeaconLocationsUpdated;
    }
}