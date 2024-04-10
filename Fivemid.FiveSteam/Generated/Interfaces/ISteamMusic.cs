using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamMusic</summary>
    public unsafe interface ISteamMusic
    {
        public bool BIsEnabled();
        public bool BIsPlaying();
        public AudioPlayback_Status GetPlaybackStatus();
        public void Play();
        public void Pause();
        public void PlayPrevious();
        public void PlayNext();
        public void SetVolume(float flVolume);
        public float GetVolume();
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_BIsEnabled", CallingConvention = Platform.CC)]
        internal static extern bool BIsEnabled(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_BIsPlaying", CallingConvention = Platform.CC)]
        internal static extern bool BIsPlaying(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_GetPlaybackStatus", CallingConvention = Platform.CC)]
        internal static extern AudioPlayback_Status GetPlaybackStatus(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_Play", CallingConvention = Platform.CC)]
        internal static extern void Play(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_Pause", CallingConvention = Platform.CC)]
        internal static extern void Pause(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_PlayPrevious", CallingConvention = Platform.CC)]
        internal static extern void PlayPrevious(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_PlayNext", CallingConvention = Platform.CC)]
        internal static extern void PlayNext(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_SetVolume", CallingConvention = Platform.CC)]
        internal static extern void SetVolume(void* self, float flVolume);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMusic_GetVolume", CallingConvention = Platform.CC)]
        internal static extern float GetVolume(void* self);
        public struct Instance : ISteamMusic
        {
            public void* self;
            public bool BIsEnabled() => ISteamMusic.BIsEnabled(self);
            public bool BIsPlaying() => ISteamMusic.BIsPlaying(self);
            public AudioPlayback_Status GetPlaybackStatus() => ISteamMusic.GetPlaybackStatus(self);
            public void Play() => ISteamMusic.Play(self);
            public void Pause() => ISteamMusic.Pause(self);
            public void PlayPrevious() => ISteamMusic.PlayPrevious(self);
            public void PlayNext() => ISteamMusic.PlayNext(self);
            public void SetVolume(float flVolume) => ISteamMusic.SetVolume(self, flVolume);
            public float GetVolume() => ISteamMusic.GetVolume(self);
        }
    }
}