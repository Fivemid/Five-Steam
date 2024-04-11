using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageFileWriteAsyncComplete_t</summary>
    public unsafe struct RemoteStorageFileWriteAsyncComplete : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageFileWriteAsyncComplete;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}