using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a browser surface has received a file open dialog from a <code class="bb_code bb_code_inline nohighlight">&lt;input type="file"&gt;</code> click or similar, you must call <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#FileLoadDialogResponse" class="bb_apilink">ISteamHTMLSurface::FileLoadDialogResponse</a> with the file(s) the user selected.<br />
    /// <br />
    /// </summary>
    public unsafe struct HTML_FileOpenDialog : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_FileOpenDialog;
        /// <summary>The handle of the surface that is navigating.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The name of the dialog. (eg. "Upload Images")</summary>
        public UTF8StringPtr pchTitle;
        /// <summary>The filename that the page wants you to set by default. It may be expecting a file with that name or that was the file the user previously uploaded.</summary>
        public UTF8StringPtr pchInitialFile;
    }
}