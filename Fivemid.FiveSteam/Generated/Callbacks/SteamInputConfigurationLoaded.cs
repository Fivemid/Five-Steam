using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInputConfigurationLoaded_t</summary>
    public unsafe struct SteamInputConfigurationLoaded
    {
        /// <summary>AppId_t m_unAppID</summary>
        public AppId unAppID;
        /// <summary>InputHandle_t m_ulDeviceHandle</summary>
        public InputHandle ulDeviceHandle;
        /// <summary>CSteamID m_ulMappingCreator</summary>
        public SteamId ulMappingCreator;
        /// <summary>uint32 m_unMajorRevision</summary>
        public uint unMajorRevision;
        /// <summary>uint32 m_unMinorRevision</summary>
        public uint unMinorRevision;
        /// <summary>bool m_bUsesSteamInputAPI</summary>
        public bool bUsesSteamInputAPI;
        /// <summary>bool m_bUsesGamepadAPI</summary>
        public bool bUsesGamepadAPI;
    }
}