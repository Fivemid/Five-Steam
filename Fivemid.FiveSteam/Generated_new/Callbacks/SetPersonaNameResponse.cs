using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SetPersonaNameResponse_t</summary>
    public unsafe struct SetPersonaNameResponse
    {
        /// <summary>bool m_bSuccess</summary>
        public bool bSuccess;
        /// <summary>bool m_bLocalSuccess</summary>
        public bool bLocalSuccess;
        /// <summary>EResult m_result</summary>
        public Result result;
    }
}