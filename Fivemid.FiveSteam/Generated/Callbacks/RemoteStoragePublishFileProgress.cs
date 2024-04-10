using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStoragePublishFileProgress_t</summary>
    public unsafe struct RemoteStoragePublishFileProgress
    {
        /// <summary>double m_dPercentFile</summary>
        public double dPercentFile;
        /// <summary>bool m_bPreview</summary>
        public bool bPreview;
    }
}