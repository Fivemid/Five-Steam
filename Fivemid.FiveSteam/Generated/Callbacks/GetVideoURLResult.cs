using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Provides the result of a call to
    /// <a href="https://partner.steamgames.com/doc/api/ISteamVideo#GetVideoURL" class="bb_apilink">ISteamVideo::GetVideoURL</a>.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamVideo#GetVideoURL" class="bb_apilink">ISteamVideo::GetVideoURL</a>
    /// </summary>
    public unsafe struct GetVideoURLResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetVideoURLResult;
        /// <summary>
        ///             The result of the operation.<br />
        ///             <ul class="bb_ul">
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///                     if the call is successful.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a>
        ///                     if the app ID provided is not a video app ID or if the user does not own a
        ///                     license for it.
        ///                 </li>
        ///             </ul>
        ///         </summary>
        public Result eResult;
        /// <summary>
        ///             The App ID provided in the original call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamVideo#GetVideoURL" class="bb_apilink">ISteamVideo::GetVideoURL</a>.
        ///         </summary>
        public AppId unVideoAppID;
        /// <summary>
        ///             If the call was successful this contains the URL to the
        ///             <a href="http://en.wikipedia.org/wiki/Dynamic_Adaptive_Streaming_over_HTTP" target="_blank" rel="noreferrer">MPEG-DASH Standard</a>
        ///             schema formatted xml document which can be used to stream the content.
        ///         </summary>
        public UTF8String256 rgchURL;
    }
}