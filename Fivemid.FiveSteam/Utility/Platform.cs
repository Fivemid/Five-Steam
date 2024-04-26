using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam {
    internal static class Platform {
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
        public const int    PACK_SIZE = 8;
        public const string LIBRARY_NAME     = "steam_api64";
#elif UNITY_STANDALONE_LINUX || UNITY_EDITOR_LINUX
		public const int    PACK_SIZE = 4;
		public const string LIBRARY_NAME = "libsteam_api";
#endif
        
        public const CallingConvention CC = CallingConvention.Cdecl;
    }
}