using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct MusicPlayerWantsVolume
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsVolume;
        /// <summary></summary>
        public float flNewVolume;
    }
}