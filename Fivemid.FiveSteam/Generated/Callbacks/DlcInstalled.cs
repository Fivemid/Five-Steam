using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Triggered after the current user gains ownership of DLC and that DLC is installed.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#InstallDLC" class="bb_apilink">ISteamApps::InstallDLC</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct DlcInstalled
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DlcInstalled;
        /// <summary>App ID of the DLC that was installed.</summary>
        public AppId nAppID;
    }
}