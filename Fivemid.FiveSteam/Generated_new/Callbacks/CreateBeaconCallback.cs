using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>CreateBeaconCallback_t</summary>
    public unsafe struct CreateBeaconCallback
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PartyBeaconID_t m_ulBeaconID</summary>
        public PartyBeaconID ulBeaconID;
    }
}