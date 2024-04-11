using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EncryptedAppTicketResponse_t</summary>
    public unsafe struct EncryptedAppTicketResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EncryptedAppTicketResponse;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}