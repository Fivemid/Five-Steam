using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>InputAnalogActionData_t</summary>
    public unsafe struct InputAnalogActionData
    {
        /// <summary>EInputSourceMode eMode</summary>
        public InputSourceMode eMode;
        /// <summary>float x</summary>
        public float x;
        /// <summary>float y</summary>
        public float y;
        /// <summary>bool bActive</summary>
        public bool bActive;
    }
}