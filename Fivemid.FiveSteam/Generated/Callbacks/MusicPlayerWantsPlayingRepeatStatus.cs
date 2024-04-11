using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MusicPlayerWantsPlayingRepeatStatus_t</summary>
    public unsafe struct MusicPlayerWantsPlayingRepeatStatus : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MusicPlayerWantsPlayingRepeatStatus;
        /// <summary>int m_nPlayingRepeatStatus</summary>
        public int nPlayingRepeatStatus;
    }
}