using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the big picture gamepad text input has been closed.<br />
    /// <br />
    /// </summary>
    public unsafe struct GamepadTextInputDismissed : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GamepadTextInputDismissed;
        /// <summary><b>true</b> if user entered &amp; accepted text (Call <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetEnteredGamepadTextInput" class="bb_apilink">ISteamUtils::GetEnteredGamepadTextInput</a> to receive the text), <b>false</b> if input was canceled.</summary>
        public bool bSubmitted;
        /// <summary>Contains the length in bytes if there was text submitted.</summary>
        public uint unSubmittedText;
        /// missing documentation for GamepadTextInputDismissed_t.m_unAppID
        public AppId unAppID;
    }
}