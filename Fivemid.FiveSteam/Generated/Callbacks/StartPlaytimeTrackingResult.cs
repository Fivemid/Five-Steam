using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>StartPlaytimeTrackingResult_t</summary>
    public unsafe struct StartPlaytimeTrackingResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StartPlaytimeTrackingResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}