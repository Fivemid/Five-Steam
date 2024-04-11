using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>IPCFailure_t</summary>
    public unsafe struct IPCFailure : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.IPCFailure;
        /// <summary>uint8 m_eFailureType</summary>
        public byte eFailureType;
        /// <summary>EFailureType</summary>
        public enum FailureType : int
        {
            /// <summary>k_EFailureFlushedCallbackQueue</summary>
            FailureFlushedCallbackQueue = 0,
            /// <summary>k_EFailurePipeFail</summary>
            FailurePipeFail = 1
        }
    }
}