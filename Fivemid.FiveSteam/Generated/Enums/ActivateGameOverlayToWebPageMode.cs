using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Game Overlay web page modes<br />
    /// <br />
    /// 
    /// </summary>
    public enum ActivateGameOverlayToWebPageMode : int
    {
        /// <summary>
        ///             Browser will open next to all other windows that the user has open in the overlay. The
        ///             window will remain open, even if the user closes then re-opens the overlay.
        ///         </summary>
        Default = 0,
        /// <summary>
        ///             Browser will be opened in a special overlay configuration which hides all other windows
        ///             that the user has open in the overlay. When the user closes the overlay, the browser
        ///             window will also close. When the user closes the browser window, the overlay will
        ///             automatically close.
        ///         </summary>
        Modal = 1
    }
}