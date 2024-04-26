using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Allows direct interaction with the Steam Music player.<br />
    /// <br />
    /// See <a href="https://partner.steamgames.com/doc/features/music_player" class="bb_doclink">features/music_player</a> for more information.</summary>
    public unsafe interface ISteamMusicRemote
    {
        public bool RegisterSteamMusicRemote(UTF8StringPtr pchName);
        public bool DeregisterSteamMusicRemote();
        public bool BIsCurrentMusicRemote();
        public bool BActivationSuccess(bool bValue);
        public bool SetDisplayName(UTF8StringPtr pchDisplayName);
        public bool SetPNGIcon_64x64(void* pvBuffer, uint cbBufferLength);
        public bool EnablePlayPrevious(bool bValue);
        public bool EnablePlayNext(bool bValue);
        public bool EnableShuffled(bool bValue);
        public bool EnableLooped(bool bValue);
        public bool EnableQueue(bool bValue);
        public bool EnablePlaylists(bool bValue);
        public bool UpdatePlaybackStatus(AudioPlayback_Status nStatus);
        public bool UpdateShuffled(bool bValue);
        public bool UpdateLooped(bool bValue);
        public bool UpdateVolume(float flValue);
        public bool CurrentEntryWillChange();
        public bool CurrentEntryIsAvailable(bool bAvailable);
        public bool UpdateCurrentEntryText(UTF8StringPtr pchText);
        public bool UpdateCurrentEntryElapsedSeconds(int nValue);
        public bool UpdateCurrentEntryCoverArt(void* pvBuffer, uint cbBufferLength);
        public bool CurrentEntryDidChange();
        public bool QueueWillChange();
        public bool ResetQueueEntries();
        public bool SetQueueEntry(int nID, int nPosition, UTF8StringPtr pchEntryText);
        public bool SetCurrentQueueEntry(int nID);
        public bool QueueDidChange();
        public bool PlaylistWillChange();
        public bool ResetPlaylistEntries();
        public bool SetPlaylistEntry(int nID, int nPosition, UTF8StringPtr pchEntryText);
        public bool SetCurrentPlaylistEntry(int nID);
        public bool PlaylistDidChange();
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_RegisterSteamMusicRemote", CallingConvention = Platform.CC)]
        internal static extern bool RegisterSteamMusicRemote(void* self, UTF8StringPtr pchName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_DeregisterSteamMusicRemote", CallingConvention = Platform.CC)]
        internal static extern bool DeregisterSteamMusicRemote(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_BIsCurrentMusicRemote", CallingConvention = Platform.CC)]
        internal static extern bool BIsCurrentMusicRemote(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_BActivationSuccess", CallingConvention = Platform.CC)]
        internal static extern bool BActivationSuccess(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_SetDisplayName", CallingConvention = Platform.CC)]
        internal static extern bool SetDisplayName(void* self, UTF8StringPtr pchDisplayName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPNGIcon_64x64", CallingConvention = Platform.CC)]
        internal static extern bool SetPNGIcon_64x64(void* self, void* pvBuffer, uint cbBufferLength);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayPrevious", CallingConvention = Platform.CC)]
        internal static extern bool EnablePlayPrevious(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlayNext", CallingConvention = Platform.CC)]
        internal static extern bool EnablePlayNext(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableShuffled", CallingConvention = Platform.CC)]
        internal static extern bool EnableShuffled(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableLooped", CallingConvention = Platform.CC)]
        internal static extern bool EnableLooped(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_EnableQueue", CallingConvention = Platform.CC)]
        internal static extern bool EnableQueue(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_EnablePlaylists", CallingConvention = Platform.CC)]
        internal static extern bool EnablePlaylists(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdatePlaybackStatus", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePlaybackStatus(void* self, AudioPlayback_Status nStatus);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateShuffled", CallingConvention = Platform.CC)]
        internal static extern bool UpdateShuffled(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateLooped", CallingConvention = Platform.CC)]
        internal static extern bool UpdateLooped(void* self, bool bValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateVolume", CallingConvention = Platform.CC)]
        internal static extern bool UpdateVolume(void* self, float flValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryWillChange", CallingConvention = Platform.CC)]
        internal static extern bool CurrentEntryWillChange(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryIsAvailable", CallingConvention = Platform.CC)]
        internal static extern bool CurrentEntryIsAvailable(void* self, bool bAvailable);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryText", CallingConvention = Platform.CC)]
        internal static extern bool UpdateCurrentEntryText(void* self, UTF8StringPtr pchText);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds", CallingConvention = Platform.CC)]
        internal static extern bool UpdateCurrentEntryElapsedSeconds(void* self, int nValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_UpdateCurrentEntryCoverArt", CallingConvention = Platform.CC)]
        internal static extern bool UpdateCurrentEntryCoverArt(void* self, void* pvBuffer, uint cbBufferLength);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_CurrentEntryDidChange", CallingConvention = Platform.CC)]
        internal static extern bool CurrentEntryDidChange(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueWillChange", CallingConvention = Platform.CC)]
        internal static extern bool QueueWillChange(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetQueueEntries", CallingConvention = Platform.CC)]
        internal static extern bool ResetQueueEntries(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_SetQueueEntry", CallingConvention = Platform.CC)]
        internal static extern bool SetQueueEntry(void* self, int nID, int nPosition, UTF8StringPtr pchEntryText);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentQueueEntry", CallingConvention = Platform.CC)]
        internal static extern bool SetCurrentQueueEntry(void* self, int nID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_QueueDidChange", CallingConvention = Platform.CC)]
        internal static extern bool QueueDidChange(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistWillChange", CallingConvention = Platform.CC)]
        internal static extern bool PlaylistWillChange(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_ResetPlaylistEntries", CallingConvention = Platform.CC)]
        internal static extern bool ResetPlaylistEntries(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_SetPlaylistEntry", CallingConvention = Platform.CC)]
        internal static extern bool SetPlaylistEntry(void* self, int nID, int nPosition, UTF8StringPtr pchEntryText);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_SetCurrentPlaylistEntry", CallingConvention = Platform.CC)]
        internal static extern bool SetCurrentPlaylistEntry(void* self, int nID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMusicRemote_PlaylistDidChange", CallingConvention = Platform.CC)]
        internal static extern bool PlaylistDidChange(void* self);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamMusicRemote
        {
            public void* self;
            public bool RegisterSteamMusicRemote(UTF8StringPtr pchName) => ISteamMusicRemote.RegisterSteamMusicRemote(self, pchName);
            public bool DeregisterSteamMusicRemote() => ISteamMusicRemote.DeregisterSteamMusicRemote(self);
            public bool BIsCurrentMusicRemote() => ISteamMusicRemote.BIsCurrentMusicRemote(self);
            public bool BActivationSuccess(bool bValue) => ISteamMusicRemote.BActivationSuccess(self, bValue);
            public bool SetDisplayName(UTF8StringPtr pchDisplayName) => ISteamMusicRemote.SetDisplayName(self, pchDisplayName);
            public bool SetPNGIcon_64x64(void* pvBuffer, uint cbBufferLength) => ISteamMusicRemote.SetPNGIcon_64x64(self, pvBuffer, cbBufferLength);
            public bool EnablePlayPrevious(bool bValue) => ISteamMusicRemote.EnablePlayPrevious(self, bValue);
            public bool EnablePlayNext(bool bValue) => ISteamMusicRemote.EnablePlayNext(self, bValue);
            public bool EnableShuffled(bool bValue) => ISteamMusicRemote.EnableShuffled(self, bValue);
            public bool EnableLooped(bool bValue) => ISteamMusicRemote.EnableLooped(self, bValue);
            public bool EnableQueue(bool bValue) => ISteamMusicRemote.EnableQueue(self, bValue);
            public bool EnablePlaylists(bool bValue) => ISteamMusicRemote.EnablePlaylists(self, bValue);
            public bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) => ISteamMusicRemote.UpdatePlaybackStatus(self, nStatus);
            public bool UpdateShuffled(bool bValue) => ISteamMusicRemote.UpdateShuffled(self, bValue);
            public bool UpdateLooped(bool bValue) => ISteamMusicRemote.UpdateLooped(self, bValue);
            public bool UpdateVolume(float flValue) => ISteamMusicRemote.UpdateVolume(self, flValue);
            public bool CurrentEntryWillChange() => ISteamMusicRemote.CurrentEntryWillChange(self);
            public bool CurrentEntryIsAvailable(bool bAvailable) => ISteamMusicRemote.CurrentEntryIsAvailable(self, bAvailable);
            public bool UpdateCurrentEntryText(UTF8StringPtr pchText) => ISteamMusicRemote.UpdateCurrentEntryText(self, pchText);
            public bool UpdateCurrentEntryElapsedSeconds(int nValue) => ISteamMusicRemote.UpdateCurrentEntryElapsedSeconds(self, nValue);
            public bool UpdateCurrentEntryCoverArt(void* pvBuffer, uint cbBufferLength) => ISteamMusicRemote.UpdateCurrentEntryCoverArt(self, pvBuffer, cbBufferLength);
            public bool CurrentEntryDidChange() => ISteamMusicRemote.CurrentEntryDidChange(self);
            public bool QueueWillChange() => ISteamMusicRemote.QueueWillChange(self);
            public bool ResetQueueEntries() => ISteamMusicRemote.ResetQueueEntries(self);
            public bool SetQueueEntry(int nID, int nPosition, UTF8StringPtr pchEntryText) => ISteamMusicRemote.SetQueueEntry(self, nID, nPosition, pchEntryText);
            public bool SetCurrentQueueEntry(int nID) => ISteamMusicRemote.SetCurrentQueueEntry(self, nID);
            public bool QueueDidChange() => ISteamMusicRemote.QueueDidChange(self);
            public bool PlaylistWillChange() => ISteamMusicRemote.PlaylistWillChange(self);
            public bool ResetPlaylistEntries() => ISteamMusicRemote.ResetPlaylistEntries(self);
            public bool SetPlaylistEntry(int nID, int nPosition, UTF8StringPtr pchEntryText) => ISteamMusicRemote.SetPlaylistEntry(self, nID, nPosition, pchEntryText);
            public bool SetCurrentPlaylistEntry(int nID) => ISteamMusicRemote.SetCurrentPlaylistEntry(self, nID);
            public bool PlaylistDidChange() => ISteamMusicRemote.PlaylistDidChange(self);
        }
    }
}