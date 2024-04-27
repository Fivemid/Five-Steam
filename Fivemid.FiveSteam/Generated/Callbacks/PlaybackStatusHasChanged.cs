using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// This callback has no fields.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct PlaybackStatusHasChanged
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.PlaybackStatusHasChanged;
    }
}