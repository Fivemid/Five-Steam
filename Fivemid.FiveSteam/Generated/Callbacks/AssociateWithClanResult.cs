using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AssociateWithClanResult_t</summary>
    public unsafe struct AssociateWithClanResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AssociateWithClanResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}