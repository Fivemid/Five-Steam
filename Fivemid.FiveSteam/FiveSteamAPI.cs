using System;

namespace Fivemid.FiveSteam {
    public static partial class FiveSteamAPI {
        private static bool  initialized;
        private static AppId appId;
        
        public static unsafe void Init(AppId appId) {
            if (initialized)
                throw new Exception("FiveSteam is already initialized");
            
            
            FiveSteamAPI.appId = appId;
            
            Environment.SetEnvironmentVariable("SteamAppId",  appId.ToString());
            Environment.SetEnvironmentVariable("SteamGameId", appId.ToString());
            SteamErrMsg        error      = default;
            SteamAPIInitResult initResult = SteamAPI.Init(&error);
            if (initResult != SteamAPIInitResult.OK)
                throw new Exception($"SteamAPI init failed: {initResult} - {error.value}");
            initialized = true;
        }
        
        public static void Shutdown() {
            SteamAPI.Shutdown();
            initialized = false;
        }
    }
}