using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMusic
    {
        public static ISteamMusic.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamMusic_v001", CallingConvention = Platform.CC)]
        private static extern ISteamMusic.Instance Accessor();
        /// <summary></summary>
        public static bool BIsEnabled() => Instance.BIsEnabled();
        /// <summary></summary>
        public static bool BIsPlaying() => Instance.BIsPlaying();
        /// <summary></summary>
        public static AudioPlayback_Status GetPlaybackStatus() => Instance.GetPlaybackStatus();
        /// <summary></summary>
        public static void Play() => Instance.Play();
        /// <summary></summary>
        public static void Pause() => Instance.Pause();
        /// <summary></summary>
        public static void PlayPrevious() => Instance.PlayPrevious();
        /// <summary></summary>
        public static void PlayNext() => Instance.PlayNext();
        /// <summary></summary>
        public static void SetVolume(float flVolume) => Instance.SetVolume(flVolume);
        /// <summary></summary>
        public static float GetVolume() => Instance.GetVolume();
    }
}