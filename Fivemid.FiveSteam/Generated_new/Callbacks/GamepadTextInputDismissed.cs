using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GamepadTextInputDismissed_t</summary>
    public unsafe struct GamepadTextInputDismissed
    {
        /// <summary>bool m_bSubmitted</summary>
        public bool bSubmitted;
        /// <summary>uint32 m_unSubmittedText</summary>
        public uint unSubmittedText;
        /// <summary>AppId_t m_unAppID</summary>
        public AppId unAppID;
    }
}