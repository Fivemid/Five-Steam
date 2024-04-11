using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FilterTextDictionaryChanged_t</summary>
    public unsafe struct FilterTextDictionaryChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FilterTextDictionaryChanged;
        /// <summary>int m_eLanguage</summary>
        public int eLanguage;
    }
}