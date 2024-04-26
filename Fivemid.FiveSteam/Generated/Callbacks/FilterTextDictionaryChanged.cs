using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for FilterTextDictionaryChanged_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct FilterTextDictionaryChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FilterTextDictionaryChanged;
        /// missing documentation for FilterTextDictionaryChanged_t.m_eLanguage
        public int eLanguage;
    }
}