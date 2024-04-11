using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerSelectsQueueEntry_t</summary>
    public unsafe struct MusicPlayerSelectsQueueEntry : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerSelectsQueueEntry;
        /// <summary>int nID</summary>
        public int nID;
    }
}