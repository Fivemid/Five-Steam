using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Triggered when the OPF Details for 360 video playback are retrieved.<br />
    /// After receiving this you can use <a href="https://partner.steamgames.com/doc/api/ISteamVideo#GetOPFStringForApp" class="bb_apilink">ISteamVideo::GetOPFStringForApp</a> to access the OPF details.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamVideo#GetOPFSettings" class="bb_apilink">ISteamVideo::GetOPFSettings</a></summary>
    public unsafe struct GetOPFSettingsResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetOPFSettingsResult;
        /// <summary>The result of the operation.<br />
        /// Possible values:<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> - Success<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a> - This application is not a video and cannot be streamed.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFileNotFound" class="bb_apilink">k_EResultFileNotFound</a> - This video has not been processed for streaming.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultAccessDenied" class="bb_apilink">k_EResultAccessDenied</a> - The video could not be accessed. Please ensure the account you are logged in with owns this video.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultNoConnection" class="bb_apilink">k_EResultNoConnection</a> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultServiceUnavailable" class="bb_apilink">k_EResultServiceUnavailable</a> - The video service is not available.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultTimeout" class="bb_apilink">k_EResultTimeout</a> - This video is not currently available to stream.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultBlocked" class="bb_apilink">k_EResultBlocked</a> - Sorry, this video is not yet available to watch.</li></ul></summary>
        public Result eResult;
        /// <summary>The app ID of the video that we got the details of.</summary>
        public AppId unVideoAppID;
    }
}