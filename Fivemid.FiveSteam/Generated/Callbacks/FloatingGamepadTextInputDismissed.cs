using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the floating keyboard invoked from <a href="https://partner.steamgames.com/doc/api/ISteamUtils#ShowFloatingGamepadTextInput" class="bb_apilink">ISteamUtils::ShowFloatingGamepadTextInput</a> has been closed.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct FloatingGamepadTextInputDismissed
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FloatingGamepadTextInputDismissed;
    }
}