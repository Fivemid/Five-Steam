using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamRemotePlay
    {
        public static ISteamRemotePlay.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamRemotePlay_v002", CallingConvention = Platform.CC)]
        private static extern ISteamRemotePlay.Instance Accessor();
        /// <summary>
        /// <code>uint32 GetSessionCount();</code>
        /// Get the number of currently connected Steam Remote Play sessions<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The number of currently connected Steam Remote Play sessions<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     bool BSteamRemotePlayActive() { uint32 unSessionCount = SteamRemotePlay()-&gt;GetSessionCount();
        ///     for ( uint32 iIndex = 0; iIndex &lt; unSessionCount; iIndex++ ) { RemotePlaySessionID_t
        ///     unSessionID = SteamRemotePlay()-&gt;GetSessionID( iIndex ); if ( !unSessionID ) { continue; }
        ///     return true; } return false; }
        /// </code>
        /// </summary>
        /// 
        public static uint GetSessionCount() => Instance.GetSessionCount();
        /// <summary>
        /// <code>uint32 GetSessionID( int iSessionIndex );</code>
        /// 
        /// <br />
        /// Get the currently connected Steam Remote Play session ID at the specified index<br />
        /// <br />
        /// <b>Returns:</b> uint32<br />
        /// The session ID of the session at the specified index, or 0 if the index is less than 0 or greater
        /// than or equal to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamRemotePlay#GetSessionCount" class="bb_apilink">ISteamRemotePlay::GetSessionCount</a>()
        /// </summary>
        /// <param name="iSessionIndex">int: The index of the specified session</param>
        public static RemotePlaySessionID GetSessionID(int iSessionIndex) => Instance.GetSessionID(iSessionIndex);
        /// <summary>
        /// <code>CSteamID GetSessionSteamID( uint32 unSessionID );</code>
        /// 
        /// <br />
        /// Get the SteamID of the connected user<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// The Steam ID of the user associated with the Remote Play session. This would normally be the logged
        /// in user, or a friend in the case of Remote Play Together.
        /// </summary>
        /// <param name="unSessionID">uint32: The session ID to get information about</param>
        public static SteamId GetSessionSteamID(RemotePlaySessionID unSessionID) => Instance.GetSessionSteamID(unSessionID);
        /// <summary>
        /// <code>const char *GetSessionClientName( uint32 unSessionID );</code>
        /// 
        /// <br />
        /// Get the name of the session client device<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The name of the device associated with the Remote Play session, or NULL if the session ID is not
        /// valid.
        /// </summary>
        /// <param name="unSessionID">uint32: The session ID to get information about</param>
        public static UTF8StringPtr GetSessionClientName(RemotePlaySessionID unSessionID) => Instance.GetSessionClientName(unSessionID);
        /// <summary>
        /// <code>
        ///     ESteamDeviceFormFactor GetSessionClientFormFactor( uint32 unSessionID );
        /// </code>
        /// 
        /// <br />
        /// Get the form factor of the session client device<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamRemotePlay#ESteamDeviceFormFactor" class="bb_apilink">ESteamDeviceFormFactor</a><br />
        /// The form factor of the device associated with the Remote Play session, or
        /// <code class="bb_code bb_code_inline nohighlight">k_ESteamDeviceFormFactorUnknown</code> if the
        /// session ID is not valid.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     bool BSteamRemotePlayToPhone() { uint32 unSessionCount =
        ///     SteamRemotePlay()-&gt;GetSessionCount(); for ( uint32 iIndex = 0; iIndex &lt; unSessionCount;
        ///     iIndex++ ) { RemotePlaySessionID_t unSessionID = SteamRemotePlay()-&gt;GetSessionID( iIndex );
        ///     if ( !unSessionID ) { continue; } ESteamDeviceFormFactor eFormFactor =
        ///     SteamRemotePlay()-&gt;GetSessionClientFormFactor( unSessionID ); if ( eFormFactor ==
        ///     k_ESteamDeviceFormFactorPhone ) { return true; } } return false; }
        /// </code>
        /// </summary>
        /// <param name="unSessionID">uint32: The session ID to get information about</param>
        public static SteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID unSessionID) => Instance.GetSessionClientFormFactor(unSessionID);
        /// <summary>
        /// <code>
        ///     bool BGetSessionClientResolution( uint32 unSessionID, int *pnResolutionX, int *pnResolutionY );
        /// </code>
        /// 
        /// <br />
        /// Get the resolution, in pixels, of the session client device. This is set to 0x0 if the resolution is
        /// not available.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the session ID is valid; otherwise, <b>false</b>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     // This can return false if the remote device doesn't provide device resolution information bool
        ///     BGetSteamRemotePlayResolution( int *pnX, int *pnY ) { int nMaxResolutionX = 0, nMaxResolutionY =
        ///     0; uint32 unSessionCount = SteamRemotePlay()-&gt;GetSessionCount(); for ( uint32 iIndex = 0;
        ///     iIndex &lt; unSessionCount; iIndex++ ) { RemotePlaySessionID_t unSessionID =
        ///     SteamRemotePlay()-&gt;GetSessionID( iIndex ); if ( !unSessionID ) { continue; } int nResolutionX
        ///     = 0, nResolutionY = 0; SteamRemotePlay()-&gt;BGetSessionClientResolution( unSessionID,
        ///     &amp;nResolutionX, &amp;nResolutionY ); if ( nResolutionX &gt; nMaxResolutionX ) {
        ///     nMaxResolutionX = nResolutionX; nMaxResolutionY = nResolutionY; } } if ( pnX ) { *pnX =
        ///     nMaxResolutionX; } if ( pnY ) { *pnY = nMaxResolutionY; } return ( nMaxResolutionX &gt; 0
        ///     &amp;&amp; nMaxResolutionY &gt; 0 ); }
        /// </code>
        /// </summary>
        /// <param name="unSessionID">uint32: The session ID to get information about</param>
        /// <param name="pnResolutionX">int: A pointer to a variable to fill with the device resolution width</param>
        /// <param name="pnResolutionY">int: A pointer to a variable to fill with the device resolution height</param>
        public static bool BGetSessionClientResolution(RemotePlaySessionID unSessionID, int* pnResolutionX, int* pnResolutionY) => Instance.BGetSessionClientResolution(unSessionID, pnResolutionX, pnResolutionY);
        /// missing documentation
        public static bool BStartRemotePlayTogether(bool bShowOverlay) => Instance.BStartRemotePlayTogether(bShowOverlay);
        /// <summary>
        /// <code>bool BSendRemotePlayTogetherInvite( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Invite a friend to join the game using Remote Play Together<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the invite was successfully sent; otherwise, <b>false</b>.
        /// </summary>
        /// <param name="steamIDFriend">CSteamID: The Steam ID of the friend you'd like to invite</param>
        public static bool BSendRemotePlayTogetherInvite(SteamId steamIDFriend) => Instance.BSendRemotePlayTogetherInvite(steamIDFriend);
    }
}