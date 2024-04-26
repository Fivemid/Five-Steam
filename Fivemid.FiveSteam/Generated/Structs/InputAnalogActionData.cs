using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Represents the current state of an analog action.<br />
    /// <br />
    /// <b>Notes:</b><br />
    /// <ul class="bb_ul ">	<li> The exact values, range, etc, depend on the configuration, but (broadly speaking) traditional analog actions will provide normalized float values in the ballpark of -1.0 to 1.0, whereas mouse-like actions will provide delta updates which indicate the number of "pixels" moved since the last frame. The upshot of this is that mouse-like actions will provide much larger absolute x and y values, and are relative to the last recorded input position, whereas traditional analog actions are smaller and relative to a central physical anchor point.<br />
    /// 	</li><li> While the delta provided by mouse-like actions is very similar to pixel deltas as provided by an OS, the SC deltas are floats, not ints. This means less potential quantization and loss of precision when mapping this data to a camera rotation.<br />
    /// 	</li><li> In the case of single-axis analog inputs (such as analog triggers), only the x axis will contain data; the y axis will always be zero.</li></ul><br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct InputAnalogActionData
    {
        /// <summary>The type of data coming from this action, this will match what was specified in the action set's VDF definition.</summary>
        public InputSourceMode eMode;
        /// <summary>The current state of this action on the horizontal axis.</summary>
        public float x;
        /// <summary>The current state of this action vertical axis.</summary>
        public float y;
        /// <summary>Whether or not this action is currently available to be bound in the active action set. If it is not available, OR does not belong to the active action set, this will be false.</summary>
        public bool bActive;
    }
}