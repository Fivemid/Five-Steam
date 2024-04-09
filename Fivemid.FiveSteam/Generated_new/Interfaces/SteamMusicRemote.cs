using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMusicRemote
    {
        public static ISteamMusicRemote.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamMusicRemote_v001", CallingConvention = Platform.CC)]
        private static extern ISteamMusicRemote.Instance Accessor();
        /// <summary></summary>
        public static bool RegisterSteamMusicRemote(UTF8StringPtr pchName) => Instance.RegisterSteamMusicRemote(pchName);
        /// <summary></summary>
        public static bool DeregisterSteamMusicRemote() => Instance.DeregisterSteamMusicRemote();
        /// <summary></summary>
        public static bool BIsCurrentMusicRemote() => Instance.BIsCurrentMusicRemote();
        /// <summary></summary>
        public static bool BActivationSuccess(bool bValue) => Instance.BActivationSuccess(bValue);
        /// <summary></summary>
        public static bool SetDisplayName(UTF8StringPtr pchDisplayName) => Instance.SetDisplayName(pchDisplayName);
        /// <summary></summary>
        public static bool SetPNGIcon_64x64(void* pvBuffer, uint cbBufferLength) => Instance.SetPNGIcon_64x64(pvBuffer, cbBufferLength);
        /// <summary></summary>
        public static bool EnablePlayPrevious(bool bValue) => Instance.EnablePlayPrevious(bValue);
        /// <summary></summary>
        public static bool EnablePlayNext(bool bValue) => Instance.EnablePlayNext(bValue);
        /// <summary></summary>
        public static bool EnableShuffled(bool bValue) => Instance.EnableShuffled(bValue);
        /// <summary></summary>
        public static bool EnableLooped(bool bValue) => Instance.EnableLooped(bValue);
        /// <summary></summary>
        public static bool EnableQueue(bool bValue) => Instance.EnableQueue(bValue);
        /// <summary></summary>
        public static bool EnablePlaylists(bool bValue) => Instance.EnablePlaylists(bValue);
        /// <summary></summary>
        public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) => Instance.UpdatePlaybackStatus(nStatus);
        /// <summary></summary>
        public static bool UpdateShuffled(bool bValue) => Instance.UpdateShuffled(bValue);
        /// <summary></summary>
        public static bool UpdateLooped(bool bValue) => Instance.UpdateLooped(bValue);
        /// <summary></summary>
        public static bool UpdateVolume(float flValue) => Instance.UpdateVolume(flValue);
        /// <summary></summary>
        public static bool CurrentEntryWillChange() => Instance.CurrentEntryWillChange();
        /// <summary></summary>
        public static bool CurrentEntryIsAvailable(bool bAvailable) => Instance.CurrentEntryIsAvailable(bAvailable);
        /// <summary></summary>
        public static bool UpdateCurrentEntryText(UTF8StringPtr pchText) => Instance.UpdateCurrentEntryText(pchText);
        /// <summary></summary>
        public static bool UpdateCurrentEntryElapsedSeconds(int nValue) => Instance.UpdateCurrentEntryElapsedSeconds(nValue);
        /// <summary></summary>
        public static bool UpdateCurrentEntryCoverArt(void* pvBuffer, uint cbBufferLength) => Instance.UpdateCurrentEntryCoverArt(pvBuffer, cbBufferLength);
        /// <summary></summary>
        public static bool CurrentEntryDidChange() => Instance.CurrentEntryDidChange();
        /// <summary></summary>
        public static bool QueueWillChange() => Instance.QueueWillChange();
        /// <summary></summary>
        public static bool ResetQueueEntries() => Instance.ResetQueueEntries();
        /// <summary></summary>
        public static bool SetQueueEntry(int nID, int nPosition, UTF8StringPtr pchEntryText) => Instance.SetQueueEntry(nID, nPosition, pchEntryText);
        /// <summary></summary>
        public static bool SetCurrentQueueEntry(int nID) => Instance.SetCurrentQueueEntry(nID);
        /// <summary></summary>
        public static bool QueueDidChange() => Instance.QueueDidChange();
        /// <summary></summary>
        public static bool PlaylistWillChange() => Instance.PlaylistWillChange();
        /// <summary></summary>
        public static bool ResetPlaylistEntries() => Instance.ResetPlaylistEntries();
        /// <summary></summary>
        public static bool SetPlaylistEntry(int nID, int nPosition, UTF8StringPtr pchEntryText) => Instance.SetPlaylistEntry(nID, nPosition, pchEntryText);
        /// <summary></summary>
        public static bool SetCurrentPlaylistEntry(int nID) => Instance.SetCurrentPlaylistEntry(nID);
        /// <summary></summary>
        public static bool PlaylistDidChange() => Instance.PlaylistDidChange();
    }
}