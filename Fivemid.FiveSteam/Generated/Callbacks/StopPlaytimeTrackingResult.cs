using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>StopPlaytimeTrackingResult_t</summary>
    public unsafe struct StopPlaytimeTrackingResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StopPlaytimeTrackingResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}