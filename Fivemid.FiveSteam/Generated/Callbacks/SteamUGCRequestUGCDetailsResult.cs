using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamUGCRequestUGCDetailsResult_t</summary>
    public unsafe struct SteamUGCRequestUGCDetailsResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamUGCRequestUGCDetailsResult;
        /// <summary>SteamUGCDetails_t m_details</summary>
        public SteamUGCDetails details;
        /// <summary>bool m_bCachedData</summary>
        public bool bCachedData;
    }
}