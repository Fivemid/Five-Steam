using System;
using Unity.Burst;

namespace Fivemid.FiveSteam {
    public static partial class FiveSteamAPI {
        private static bool initialized;
        
        private static readonly SharedStatic<AppId> appIdData = SharedStatic<AppId>.GetOrCreate<AppIdContext>();
        
        public static AppId AppId {
            get => appIdData.Data;
            private set => appIdData.Data = value;
        }
        
        public static unsafe void Init(AppId appId) {
            if (initialized)
                throw new Exception("FiveSteam is already initialized");
            
            AppId = appId;
            
            Environment.SetEnvironmentVariable("SteamAppId",  AppId.ToString());
            Environment.SetEnvironmentVariable("SteamGameId", AppId.ToString());
            SteamErrMsg        error      = default;
            SteamAPIInitResult initResult = SteamAPI.Init(&error);
            if (initResult != SteamAPIInitResult.OK)
                throw new Exception($"SteamAPI init failed: {initResult} - {error.value}");
            
            InitCallbacks();
            initialized = true;
        }
        
        public static void Shutdown() {
            ShutdownCallbacks();
            SteamAPI.Shutdown();
            initialized = false;
        }
        
        private struct AppIdContext { }
    }
}