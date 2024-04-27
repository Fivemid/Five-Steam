using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Notification that the list of active beacons visible to the current user has changed. <br />
    /// <br />
    /// This callback has no members.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct ActiveBeaconsUpdated
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ActiveBeaconsUpdated;
    }
}