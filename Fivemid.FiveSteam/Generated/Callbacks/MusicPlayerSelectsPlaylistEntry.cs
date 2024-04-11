using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerSelectsPlaylistEntry_t</summary>
    public unsafe struct MusicPlayerSelectsPlaylistEntry : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerSelectsPlaylistEntry;
        /// <summary>int nID</summary>
        public int nID;
    }
}