using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>DownloadClanActivityCountsResult_t</summary>
    public unsafe struct DownloadClanActivityCountsResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DownloadClanActivityCountsResult;
        /// <summary>bool m_bSuccess</summary>
        public bool bSuccess;
    }
}