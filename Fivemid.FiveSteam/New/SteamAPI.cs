using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
	public static class SteamAPI
	{
		private static class Native
		{
			[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_Init",
			            CallingConvention = CallingConvention.Cdecl )]
			[return: MarshalAs( UnmanagedType.I1 )]
			public static extern bool SteamAPI_Init();

			[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_Shutdown",
			            CallingConvention = CallingConvention.Cdecl )]
			public static extern void SteamAPI_Shutdown();

			[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_GetHSteamPipe",
			            CallingConvention = CallingConvention.Cdecl )]
			public static extern HSteamPipe SteamAPI_GetHSteamPipe();

			[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_RestartAppIfNecessary",
			            CallingConvention = CallingConvention.Cdecl )]
			[return: MarshalAs( UnmanagedType.I1 )]
			public static extern bool SteamAPI_RestartAppIfNecessary( uint unOwnAppID );
		}

		public static bool Init()
		{
			return Native.SteamAPI_Init();
		}

		public static void Shutdown()
		{
			Native.SteamAPI_Shutdown();
		}

		public static HSteamPipe GetHSteamPipe()
		{
			return Native.SteamAPI_GetHSteamPipe();
		}

		public static bool RestartAppIfNecessary( uint unOwnAppID )
		{
			return Native.SteamAPI_RestartAppIfNecessary( unOwnAppID );
		}
	}
}
