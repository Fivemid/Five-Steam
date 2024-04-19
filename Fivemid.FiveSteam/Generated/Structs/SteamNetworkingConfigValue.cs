using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingConfigValue_t</summary>
    public unsafe struct SteamNetworkingConfigValue
    {
        /// <summary>ESteamNetworkingConfigValue m_eValue</summary>
        public SteamNetworkingConfigValueType eValue;
        /// <summary>ESteamNetworkingConfigDataType m_eDataType</summary>
        public SteamNetworkingConfigDataType eDataType;
        /// <summary>int64_t m_int64</summary>
        public long int64;
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetInt32", CallingConvention = Platform.CC)]
        internal static extern void SetInt32(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, int data);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetInt64", CallingConvention = Platform.CC)]
        internal static extern void SetInt64(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, long data);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetFloat", CallingConvention = Platform.CC)]
        internal static extern void SetFloat(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, float data);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetPtr", CallingConvention = Platform.CC)]
        internal static extern void SetPtr(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, void* data);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetString", CallingConvention = Platform.CC)]
        internal static extern void SetString(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, UTF8StringPtr data);
        public void SetInt32(SteamNetworkingConfigValueType eVal, int data)
        {
            fixed (SteamNetworkingConfigValue* self = &this)
                SetInt32(self, eVal, data);
        }

        public void SetInt64(SteamNetworkingConfigValueType eVal, long data)
        {
            fixed (SteamNetworkingConfigValue* self = &this)
                SetInt64(self, eVal, data);
        }

        public void SetFloat(SteamNetworkingConfigValueType eVal, float data)
        {
            fixed (SteamNetworkingConfigValue* self = &this)
                SetFloat(self, eVal, data);
        }

        public void SetPtr(SteamNetworkingConfigValueType eVal, void* data)
        {
            fixed (SteamNetworkingConfigValue* self = &this)
                SetPtr(self, eVal, data);
        }

        public void SetString(SteamNetworkingConfigValueType eVal, UTF8StringPtr data)
        {
            fixed (SteamNetworkingConfigValue* self = &this)
                SetString(self, eVal, data);
        }
    }
}