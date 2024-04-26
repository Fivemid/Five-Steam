using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamInputConfigurationLoaded_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInputConfigurationLoaded : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInputConfigurationLoaded;
        /// missing documentation for SteamInputConfigurationLoaded_t.m_unAppID
        public AppId unAppID;
        /// missing documentation for SteamInputConfigurationLoaded_t.m_ulDeviceHandle
        public InputHandle ulDeviceHandle;
        /// missing documentation for SteamInputConfigurationLoaded_t.m_ulMappingCreator
        public SteamId ulMappingCreator;
        /// missing documentation for SteamInputConfigurationLoaded_t.m_unMajorRevision
        public uint unMajorRevision;
        /// missing documentation for SteamInputConfigurationLoaded_t.m_unMinorRevision
        public uint unMinorRevision;
        /// missing documentation for SteamInputConfigurationLoaded_t.m_bUsesSteamInputAPI
        public bool bUsesSteamInputAPI;
        /// missing documentation for SteamInputConfigurationLoaded_t.m_bUsesGamepadAPI
        public bool bUsesGamepadAPI;
    }
}