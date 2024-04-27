using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Notification that the list of available locations for posting a beacon has been updated. <br />
    /// <br />
    /// This callback has no members.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct AvailableBeaconLocationsUpdated
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AvailableBeaconLocationsUpdated;
    }
}