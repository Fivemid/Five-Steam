using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam {
    public static unsafe class SteamAPI {
        private static class Native {
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            public static extern SteamAPIInitResult SteamAPI_InitFlat(SteamErrMsg* pOutErrMsg);
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            public static extern void SteamAPI_Shutdown();
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            public static extern HSteamPipe SteamAPI_GetHSteamPipe();
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool SteamAPI_RestartAppIfNecessary(uint unOwnAppID);
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            public static extern void SteamAPI_ManualDispatch_Init();
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe);
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool SteamAPI_ManualDispatch_GetNextCallback(
                HSteamPipe   hSteamPipe,
                CallbackMsg* pCallbackMsg);
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe);
            
            [DllImport(Platform.LIBRARY_NAME, CallingConvention = Platform.CC)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool SteamAPI_ManualDispatch_GetAPICallResult(
                HSteamPipe   hSteamPipe,
                SteamAPICall hSteamAPICall,
                void*        pCallback,
                int          cubCallback,
                int          iCallbackExpected,
                bool*        pbFailed
            );
        }
        
        public static SteamAPIInitResult Init(SteamErrMsg* pOutErrMsg) =>
            Native.SteamAPI_InitFlat(pOutErrMsg);
        
        /// <summary>
        /// SteamAPI_Shutdown should be called during process shutdown if possible.
        /// </summary>
        public static void Shutdown() =>
            Native.SteamAPI_Shutdown();
        
        public static HSteamPipe GetHSteamPipe() =>
            Native.SteamAPI_GetHSteamPipe();
        
        /// <summary>
        /// SteamAPI_RestartAppIfNecessary ensures that your executable was launched through Steam.
        ///
        /// Returns true if the current process should terminate. Steam is now re-launching your application.
        ///
        /// Returns false if no action needs to be taken. This means that your executable was started through
        /// the Steam client, or a steam_appid.txt file is present in your game's directory (for development).
        /// Your current process should continue if false is returned.
        ///
        /// NOTE: If you use the Steam DRM wrapper on your primary executable file, this check is unnecessary
        /// since the DRM wrapper will ensure that your application was launched properly through Steam.
        /// </summary>
        public static bool RestartAppIfNecessary(uint unOwnAppID) =>
            Native.SteamAPI_RestartAppIfNecessary(unOwnAppID);
        
        /// <summary>
        /// Inform the API that you wish to use manual event dispatch.  This must be called after SteamAPI_Init, but before
        /// you use any of the other manual dispatch functions below.
        /// </summary>
        public static void ManualDispatch_Init() =>
            Native.SteamAPI_ManualDispatch_Init();
        
        /// <summary>
        /// Perform certain periodic actions that need to be performed.
        /// </summary>
        public static void ManualDispatch_RunFrame(HSteamPipe hSteamPipe) =>
            Native.SteamAPI_ManualDispatch_RunFrame(hSteamPipe);
        
        /// <summary>
        /// Fetch the next pending callback on the given pipe, if any.  If a callback is available, true is returned
        /// and the structure is populated.  In this case, you MUST call SteamAPI_ManualDispatch_FreeLastCallback
        /// (after dispatching the callback) before calling SteamAPI_ManualDispatch_GetNextCallback again.
        /// </summary>
        public static bool ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, CallbackMsg* pCallbackMsg) =>
            Native.SteamAPI_ManualDispatch_GetNextCallback(hSteamPipe, pCallbackMsg);
        
        /// <summary>
        /// You must call this after dispatching the callback, if SteamAPI_ManualDispatch_GetNextCallback returns true.
        /// </summary>
        public static void ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe) =>
            Native.SteamAPI_ManualDispatch_FreeLastCallback(hSteamPipe);
        
        /// <summary>
        /// Return the call result for the specified call on the specified pipe.  You really should
        /// only call this in a handler for SteamAPICallCompleted_t callback.
        /// </summary>
        public static bool ManualDispatch_GetAPICallResult(
            HSteamPipe   hSteamPipe,
            SteamAPICall hSteamAPICall,
            void*        pCallback,
            int          cubCallback,
            int          iCallbackExpected,
            bool*        pbFailed
        ) =>
            Native.SteamAPI_ManualDispatch_GetAPICallResult(hSteamPipe, hSteamAPICall, pCallback, cubCallback,
                                                            iCallbackExpected, pbFailed);
    }
}