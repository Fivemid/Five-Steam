using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ChangeNumOpenSlotsCallback_t</summary>
    public unsafe struct ChangeNumOpenSlotsCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ChangeNumOpenSlotsCallback;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}