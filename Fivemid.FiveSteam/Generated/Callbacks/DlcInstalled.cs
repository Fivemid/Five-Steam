using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>DlcInstalled_t</summary>
    public unsafe struct DlcInstalled : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DlcInstalled;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
    }
}