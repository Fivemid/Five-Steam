using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamParentalSettingsChanged_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct SteamParentalSettingsChanged
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamParentalSettingsChanged;
    }
}