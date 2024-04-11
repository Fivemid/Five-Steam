using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>StoreAuthURLResponse_t</summary>
    public unsafe struct StoreAuthURLResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StoreAuthURLResponse;
        /// <summary>char [512] m_szURL</summary>
        public UTF8String512 szURL;
    }
}