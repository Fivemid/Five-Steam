using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A screenshot successfully written or otherwise added to the library and can now be tagged.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#WriteScreenshot" class="bb_apilink">ISteamScreenshots::WriteScreenshot</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddScreenshotToLibrary</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#TriggerScreenshot" class="bb_apilink">ISteamScreenshots::TriggerScreenshot</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddVRScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddVRScreenshotToLibrary</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct ScreenshotReady : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ScreenshotReady;
        /// <summary>The screenshot handle that has been written.</summary>
        public ScreenshotHandle hLocal;
        /// <summary>The result of the operation. Possible values:<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> - The screenshot was successfully added to the users library.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a> - The screenshot could not be loaded or parsed.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultIOFailure" class="bb_apilink">k_EResultIOFailure</a> - The screenshot could not be saved to the disk.</li></ul></summary>
        public Result eResult;
    }
}