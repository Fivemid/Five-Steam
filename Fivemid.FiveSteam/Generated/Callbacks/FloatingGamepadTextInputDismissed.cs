using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when the floating keyboard invoked from
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#ShowFloatingGamepadTextInput" class="bb_apilink">ISteamUtils::ShowFloatingGamepadTextInput</a>
    /// has been closed.
    /// </summary>
    public unsafe struct FloatingGamepadTextInputDismissed : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FloatingGamepadTextInputDismissed;
    }
}