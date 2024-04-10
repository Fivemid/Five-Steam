using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMusic
    {
        public static ISteamMusic.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamMusic_v001", CallingConvention = Platform.CC)]
        private static extern ISteamMusic.Instance Accessor();
        /// <summary>
        /// <code>bool BIsEnabled();</code>
        /// Checks if Steam Music is enabled.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if it is enabled; otherwise <b>false</b>.
        /// </summary>
        /// 
        public static bool BIsEnabled() => Instance.BIsEnabled();
        /// <summary>
        /// <code>bool BIsPlaying();</code>
        /// Checks if Steam Music is active. This does not necessarily a song is currently playing, it may be
        /// paused.<br />
        /// <br />
        /// For finer grain control use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMusic#GetPlaybackStatus" class="bb_apilink">ISteamMusic::GetPlaybackStatus</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if a song is currently playing, paused, or queued up to play; otherwise
        /// <b>false</b>.
        /// </summary>
        /// 
        public static bool BIsPlaying() => Instance.BIsPlaying();
        /// <summary>
        /// <code>AudioPlayback_Status GetPlaybackStatus();</code>
        /// Gets the current status of the Steam Music player.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMusic#AudioPlayback_Status" class="bb_apilink">AudioPlayback_Status</a>
        /// </summary>
        /// 
        public static AudioPlayback_Status GetPlaybackStatus() => Instance.GetPlaybackStatus();
        /// <summary>
        /// <code>void Play();</code>
        /// Have the Steam Music player resume playing.
        /// </summary>
        /// 
        public static void Play() => Instance.Play();
        /// <summary>
        /// <code>void Pause();</code>
        /// Pause the Steam Music player.
        /// </summary>
        /// 
        public static void Pause() => Instance.Pause();
        /// <summary>
        /// <code>void PlayPrevious();</code>
        /// Have the Steam Music player play the previous song.
        /// </summary>
        /// 
        public static void PlayPrevious() => Instance.PlayPrevious();
        /// <summary>
        /// <code>void PlayNext();</code>
        /// Have the Steam Music player skip to the next song.
        /// </summary>
        /// 
        public static void PlayNext() => Instance.PlayNext();
        /// <summary>
        /// <code>void SetVolume( float flVolume );</code>
        /// 
        /// <br />
        /// Sets the volume of the Steam Music player.
        /// </summary>
        /// <param name="flVolume">float: The volume percentage to set from <b>0.0</b> to <b>1.0</b>.</param>
        public static void SetVolume(float flVolume) => Instance.SetVolume(flVolume);
        /// <summary>
        /// <code>float GetVolume();</code>
        /// Gets the current volume of the Steam Music player.<br />
        /// <br />
        /// <b>Returns:</b> float<br />
        /// The volume is returned as a percentage between <b>0.0</b> and <b>1.0</b>.
        /// </summary>
        /// 
        public static float GetVolume() => Instance.GetVolume();
    }
}