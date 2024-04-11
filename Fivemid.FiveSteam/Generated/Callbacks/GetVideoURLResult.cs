using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GetVideoURLResult_t</summary>
    public unsafe struct GetVideoURLResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetVideoURLResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>AppId_t m_unVideoAppID</summary>
        public AppId unVideoAppID;
        /// <summary>char [256] m_rgchURL</summary>
        public UTF8String256 rgchURL;
    }
}