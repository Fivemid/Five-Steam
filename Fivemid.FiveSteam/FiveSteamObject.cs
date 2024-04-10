using System;
using UnityEditor;
using UnityEngine;

namespace Fivemid.FiveSteam {
    public class FiveSteamObject : MonoBehaviour {
        [Header("References")]
        [SerializeField]
        private uint appId;
        [SerializeField]
        private bool restartIfNecessary;

        public uint AppId => appId;

        public static FiveSteamObject Instance { get; private set; }


        protected void Awake() {
            if (Instance != null) {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            try {
#if !UNITY_EDITOR
                if (restartIfNecessary && SteamAPI.RestartAppIfNecessary(AppId)) {
                    Application.Quit();
                    return;
                }
#endif
                FiveSteamAPI.Init(appId);
            } catch (Exception e) {
                Debug.LogError(e);
#if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
#else
                Application.Quit();
#endif
                return;
            }

            DontDestroyOnLoad(this);
        }

        protected void Update() {
            FiveSteamAPI.RunCallbacks();
        }

        protected void OnDestroy() {
            if (Instance != this) return;
            Instance = null;
            FiveSteamAPI.Shutdown();
        }
    }
}