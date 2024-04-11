using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTTPRequestDataReceived_t</summary>
    public unsafe struct HTTPRequestDataReceived : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTTPRequestDataReceived;
        /// <summary>HTTPRequestHandle m_hRequest</summary>
        public HTTPRequestHandle hRequest;
        /// <summary>uint64 m_ulContextValue</summary>
        public ulong ulContextValue;
        /// <summary>uint32 m_cOffset</summary>
        public uint cOffset;
        /// <summary>uint32 m_cBytesReceived</summary>
        public uint cBytesReceived;
    }
}