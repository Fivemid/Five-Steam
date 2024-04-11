using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSPolicyResponse_t</summary>
    public unsafe struct GSPolicyResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSPolicyResponse;
        /// <summary>uint8 m_bSecure</summary>
        public byte bSecure;
    }
}