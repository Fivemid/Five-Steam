using System;
using Unity.Burst;

namespace Fivemid.FiveSteam {
    public static partial class FiveSteamAPI {
        private static readonly SharedStatic<bool>  initialized = SharedStatic<bool>.GetOrCreate<InitializedContext>();
        private static readonly SharedStatic<AppId> appId       = SharedStatic<AppId>.GetOrCreate<AppIdContext>();
        
        public static ref bool  Initialized => ref initialized.Data;
        public static ref AppId AppId       => ref appId.Data;
        
        public static unsafe void Init(AppId appId) {
            if (Initialized)
                throw new Exception("FiveSteam is already initialized");
            
            AppId = appId;
            
            Environment.SetEnvironmentVariable("SteamAppId",  AppId.ToString());
            Environment.SetEnvironmentVariable("SteamGameId", AppId.ToString());
            SteamErrMsg        error      = default;
            SteamAPIInitResult initResult = SteamAPI.Init(&error);
            if (initResult != SteamAPIInitResult.OK)
                throw new Exception($"SteamAPI init failed: {initResult} - {error.value}");
            
            InitCallbacks();
            Initialized = true;
        }
        
        public static void Shutdown() {
            ShutdownCallbacks();
            SteamAPI.Shutdown();
            Initialized = false;
        }
        
        private struct InitializedContext { }
        
        private struct AppIdContext { }
    }
}