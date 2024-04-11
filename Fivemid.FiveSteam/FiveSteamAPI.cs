using System;

namespace Fivemid.FiveSteam {
    public static partial class FiveSteamAPI {
        private static bool initialized;
        
        public static AppId AppId { get; private set; }
        
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
            
            SteamMatchmaking.CreateLobby(LobbyType.Public, 8);
        }
        
        public static void Shutdown() {
            ShutdownCallbacks();
            SteamAPI.Shutdown();
            initialized = false;
        }
    }
}