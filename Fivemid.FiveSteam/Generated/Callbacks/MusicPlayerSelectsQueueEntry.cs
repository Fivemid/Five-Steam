using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// </summary>
    public unsafe struct MusicPlayerSelectsQueueEntry : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerSelectsQueueEntry;
        /// <summary></summary>
        public int nID;
    }
}