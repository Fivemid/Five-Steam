using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GetOPFSettingsResult_t</summary>
    public unsafe struct GetOPFSettingsResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>AppId_t m_unVideoAppID</summary>
        public AppId unVideoAppID;
    }
}