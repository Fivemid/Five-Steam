using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />, where the scope arguments are supplied by the object being created.<a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#SetConfigValueStruct" class="bb_apilink">ISteamNetworkingUtils::SetConfigValueStruct</a>.  Basically when the object is created, we just iterate over the list of options and call <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#SetConfigValue" class="bb_apilink">ISteamNetworkingUtils::SetConfigValue</a>
    /// For the meaning of these fields, see <br />
    /// <br /> the listen socket or connection really starts doing anything.  Creating the object and then setting the options "immediately" after creation doesn't work completely, because network packets could be received between the time the object is created and when the options are applied.  To set options at creation time in a reliable way, they must be passed to the creation function.  This structure is used to pass those options.<i>before</i>
    /// In a few places we need to set configuration options on listen sockets and connections, and have them take effect <br /></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamNetworkingConfigValue
    {
        /// <summary>Which option is being set</summary>
        public SteamNetworkingConfigValueType eValue;
        /// <summary>Which field below did you fill in?</summary>
        public SteamNetworkingConfigDataType eDataType;
        /// <summary></summary>
        public long int64;
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetInt32", CallingConvention = Platform.CC)]
        internal static extern void SetInt32(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, int data);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetInt64", CallingConvention = Platform.CC)]
        internal static extern void SetInt64(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, long data);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetFloat", CallingConvention = Platform.CC)]
        internal static extern void SetFloat(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, float data);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetPtr", CallingConvention = Platform.CC)]
        internal static extern void SetPtr(SteamNetworkingConfigValue* self, SteamNetworkingConfigValueType eVal, void* data);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingConfigValue_t_SetString", CallingConvention = Platform.CC)]
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