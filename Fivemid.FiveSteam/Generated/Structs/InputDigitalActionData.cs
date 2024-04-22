using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Represents the current state of a digital action.<br />
    /// <br />
    /// </summary>
    public unsafe struct InputDigitalActionData
    {
        /// <summary>The current state of this action; <b>true</b> if the action is currently pressed, otherwise <b>false</b>.</summary>
        public bool bState;
        /// <summary>Whether or not this action is currently available to be bound in the active action set.</summary>
        public bool bActive;
    }
}