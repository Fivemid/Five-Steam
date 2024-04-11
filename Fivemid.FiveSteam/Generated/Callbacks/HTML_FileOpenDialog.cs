using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_FileOpenDialog_t</summary>
    public unsafe struct HTML_FileOpenDialog : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_FileOpenDialog;
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchTitle</summary>
        public UTF8StringPtr pchTitle;
        /// <summary>const char * pchInitialFile</summary>
        public UTF8StringPtr pchInitialFile;
    }
}