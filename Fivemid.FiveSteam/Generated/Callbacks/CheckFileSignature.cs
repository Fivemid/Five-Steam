using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>CheckFileSignature_t</summary>
    public unsafe struct CheckFileSignature : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.CheckFileSignature;
        /// <summary>ECheckFileSignature m_eCheckFileSignature</summary>
        public CheckFileSignatureType eCheckFileSignature;
    }
}