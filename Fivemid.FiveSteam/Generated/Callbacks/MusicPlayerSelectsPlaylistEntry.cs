using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// </summary>
    public unsafe struct MusicPlayerSelectsPlaylistEntry : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerSelectsPlaylistEntry;
        /// <summary></summary>
        public int nID;
    }
}