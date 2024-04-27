using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A screenshot has been requested by the user from the Steam screenshot hotkey. This will only be called if <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#HookScreenshots" class="bb_apilink">ISteamScreenshots::HookScreenshots</a> has been enabled, in which case Steam will not take the screenshot itself.<br />
    /// <br />
    /// This callback has no fields.<br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#TriggerScreenshot" class="bb_apilink">ISteamScreenshots::TriggerScreenshot</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct ScreenshotRequested
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ScreenshotRequested;
    }
}