using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMusicRemote
    {
        public static ISteamMusicRemote.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamMusicRemote_v001", CallingConvention = Platform.CC)]
        private static extern ISteamMusicRemote.Instance Accessor();
        /// <summary>
        /// <code>bool RegisterSteamMusicRemote( const char *pchName );</code>
        /// 
        /// <br />
        /// Service Definition<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="pchName">const char *: </param>
        public static bool RegisterSteamMusicRemote(UTF8StringPtr pchName) => Instance.RegisterSteamMusicRemote(pchName);
        /// <summary>
        /// <code>bool DeregisterSteamMusicRemote();</code>
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool DeregisterSteamMusicRemote() => Instance.DeregisterSteamMusicRemote();
        /// <summary>
        /// <code>bool BIsCurrentMusicRemote();</code>
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool BIsCurrentMusicRemote() => Instance.BIsCurrentMusicRemote();
        /// <summary>
        /// <code>bool BActivationSuccess( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool BActivationSuccess(bool bValue) => Instance.BActivationSuccess(bValue);
        /// <summary>
        /// <code>bool SetDisplayName( const char *pchDisplayName );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="pchDisplayName">const char *: </param>
        public static bool SetDisplayName(UTF8StringPtr pchDisplayName) => Instance.SetDisplayName(pchDisplayName);
        /// <summary>
        /// <code>bool SetPNGIcon_64x64( void *pvBuffer, uint32 cbBufferLength );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="pvBuffer">void *: </param>
        /// <param name="cbBufferLength">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : </param>
        public static bool SetPNGIcon_64x64(void* pvBuffer, uint cbBufferLength) => Instance.SetPNGIcon_64x64(pvBuffer, cbBufferLength);
        /// <summary>
        /// <code>bool EnablePlayPrevious( bool bValue );</code>
        /// 
        /// <br />
        /// Abilities for the user interface<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool EnablePlayPrevious(bool bValue) => Instance.EnablePlayPrevious(bValue);
        /// <summary>
        /// <code>bool EnablePlayNext( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool EnablePlayNext(bool bValue) => Instance.EnablePlayNext(bValue);
        /// <summary>
        /// <code>bool EnableShuffled( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool EnableShuffled(bool bValue) => Instance.EnableShuffled(bValue);
        /// <summary>
        /// <code>bool EnableLooped( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool EnableLooped(bool bValue) => Instance.EnableLooped(bValue);
        /// <summary>
        /// <code>bool EnableQueue( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool EnableQueue(bool bValue) => Instance.EnableQueue(bValue);
        /// <summary>
        /// <code>bool EnablePlaylists( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool EnablePlaylists(bool bValue) => Instance.EnablePlaylists(bValue);
        /// <summary>
        /// <code>bool UpdatePlaybackStatus( AudioPlayback_Status nStatus );</code>
        /// 
        /// <br />
        /// Status<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="nStatus">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMusic#AudioPlayback_Status" class="bb_apilink">AudioPlayback_Status</a>
        ///         : </param>
        public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) => Instance.UpdatePlaybackStatus(nStatus);
        /// <summary>
        /// <code>bool UpdateShuffled( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool UpdateShuffled(bool bValue) => Instance.UpdateShuffled(bValue);
        /// <summary>
        /// <code>bool UpdateLooped( bool bValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bValue">bool: </param>
        public static bool UpdateLooped(bool bValue) => Instance.UpdateLooped(bValue);
        /// <summary>
        /// <code>bool UpdateVolume( float flValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="flValue">float: </param>
        public static bool UpdateVolume(float flValue) => Instance.UpdateVolume(flValue);
        /// <summary>
        /// <code>bool CurrentEntryWillChange();</code>
        /// Current Entry<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool CurrentEntryWillChange() => Instance.CurrentEntryWillChange();
        /// <summary>
        /// <code>bool CurrentEntryIsAvailable( bool bAvailable );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="bAvailable">bool: </param>
        public static bool CurrentEntryIsAvailable(bool bAvailable) => Instance.CurrentEntryIsAvailable(bAvailable);
        /// <summary>
        /// <code>bool UpdateCurrentEntryText( const char *pchText );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="pchText">const char *: </param>
        public static bool UpdateCurrentEntryText(UTF8StringPtr pchText) => Instance.UpdateCurrentEntryText(pchText);
        /// <summary>
        /// <code>bool UpdateCurrentEntryElapsedSeconds( int nValue );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="nValue">int: </param>
        public static bool UpdateCurrentEntryElapsedSeconds(int nValue) => Instance.UpdateCurrentEntryElapsedSeconds(nValue);
        /// <summary>
        /// <code>
        ///     bool UpdateCurrentEntryCoverArt( void *pvBuffer, uint32 cbBufferLength );
        /// </code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="pvBuffer">void *: </param>
        /// <param name="cbBufferLength">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : </param>
        public static bool UpdateCurrentEntryCoverArt(void* pvBuffer, uint cbBufferLength) => Instance.UpdateCurrentEntryCoverArt(pvBuffer, cbBufferLength);
        /// <summary>
        /// <code>bool CurrentEntryDidChange();</code>
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool CurrentEntryDidChange() => Instance.CurrentEntryDidChange();
        /// <summary>
        /// <code>bool QueueWillChange();</code>
        /// Queue<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool QueueWillChange() => Instance.QueueWillChange();
        /// <summary>
        /// <code>bool ResetQueueEntries();</code>
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool ResetQueueEntries() => Instance.ResetQueueEntries();
        /// <summary>
        /// <code>
        ///     bool SetQueueEntry( int nID, int nPosition, const char *pchEntryText );
        /// </code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="nID">int: </param>
        /// <param name="nPosition">int: </param>
        /// <param name="pchEntryText">const char *: </param>
        public static bool SetQueueEntry(int nID, int nPosition, UTF8StringPtr pchEntryText) => Instance.SetQueueEntry(nID, nPosition, pchEntryText);
        /// <summary>
        /// <code>bool SetCurrentQueueEntry( int nID );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="nID">int: </param>
        public static bool SetCurrentQueueEntry(int nID) => Instance.SetCurrentQueueEntry(nID);
        /// <summary>
        /// <code>bool QueueDidChange();</code>
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool QueueDidChange() => Instance.QueueDidChange();
        /// <summary>
        /// <code>bool PlaylistWillChange();</code>
        /// Playlist<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool PlaylistWillChange() => Instance.PlaylistWillChange();
        /// <summary>
        /// <code>bool ResetPlaylistEntries();</code>
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool ResetPlaylistEntries() => Instance.ResetPlaylistEntries();
        /// <summary>
        /// <code>
        ///     bool SetPlaylistEntry( int nID, int nPosition, const char *pchEntryText );
        /// </code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="nID">int: </param>
        /// <param name="nPosition">int: </param>
        /// <param name="pchEntryText">const char *: </param>
        public static bool SetPlaylistEntry(int nID, int nPosition, UTF8StringPtr pchEntryText) => Instance.SetPlaylistEntry(nID, nPosition, pchEntryText);
        /// <summary>
        /// <code>bool SetCurrentPlaylistEntry( int nID );</code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="nID">int: </param>
        public static bool SetCurrentPlaylistEntry(int nID) => Instance.SetCurrentPlaylistEntry(nID);
        /// <summary>
        /// <code>bool PlaylistDidChange();</code>
        /// <br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// 
        public static bool PlaylistDidChange() => Instance.PlaylistDidChange();
    }
}