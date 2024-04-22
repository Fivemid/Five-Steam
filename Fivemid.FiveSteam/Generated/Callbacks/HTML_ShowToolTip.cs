using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a browser wants to display a tooltip.<br />
    /// <br />
    /// </summary>
    public unsafe struct HTML_ShowToolTip : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_ShowToolTip;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The text of the tooltip that wants to be displayed.</summary>
        public UTF8StringPtr pchMsg;
    }
}