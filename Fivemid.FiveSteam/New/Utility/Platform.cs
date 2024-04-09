using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
	internal static class Platform
	{
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
		public const int    StructPlatformPackSize = 8;
		public const string LibraryName            = "steam_api64";
#elif UNITY_STANDALONE_LINUX || UNITY_EDITOR_LINUX
		public const int    StructPlatformPackSize = 4;
		public const string LibraryName = "libsteam_api";
#endif

		public const CallingConvention CC             = CallingConvention.Cdecl;
		public const int               StructPackSize = 4;
	}
}
