using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamHTMLSurface
    {
        public static ISteamHTMLSurface.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamHTMLSurface_v005", CallingConvention = Platform.CC)]
        private static extern ISteamHTMLSurface.Instance Accessor();
        /// <summary>
        /// <code>bool Init();</code>
        /// Initializes the HTML Surface API.<br />
        /// <br />
        /// This must be called prior to using any other functions in this interface.<br />
        /// <br />
        /// You MUST call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#Shutdown" class="bb_apilink">ISteamHTMLSurface::Shutdown</a>
        /// when you are done using the interface to free up the resources associated with it. Failing to do so
        /// will result in a memory leak!<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the API was successfully initialized; otherwise, <b>false</b>.
        /// </summary>
        /// 
        public static bool Init() => Instance.Init();
        /// <summary>
        /// <code>bool Shutdown();</code>
        /// Shutdown the ISteamHTMLSurface interface, releasing the memory and handles.<br />
        /// <br />
        /// You MUST call this when you are done using this interface to prevent memory and handle leaks. After
        /// calling this then all of the functions provided in this interface will fail until you call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#Init" class="bb_apilink">ISteamHTMLSurface::Init</a>
        /// to reinitialize again.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function currently always returns <b>true</b>.
        /// </summary>
        /// 
        public static bool Shutdown() => Instance.Shutdown();
        /// <summary>
        /// <code>
        ///     SteamAPICall_t CreateBrowser( const char *pchUserAgent, const char *pchUserCSS );
        /// </code>
        /// 
        /// <br />
        /// Create a browser object for displaying of an HTML page.
        /// <div class="bb_callout bb_red bb_fixed">
        ///     <div>
        ///         <strong>NOTE:</strong> You must have implemented callback handlers for
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_BrowserReady_t" class="bb_apilink">HTML_BrowserReady_t</a>,
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_StartRequest_t" class="bb_apilink">HTML_StartRequest_t</a>,
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_JSAlert_t" class="bb_apilink">HTML_JSAlert_t</a>,
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_JSConfirm_t" class="bb_apilink">HTML_JSConfirm_t</a>, and
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_FileOpenDialog_t" class="bb_apilink">HTML_FileOpenDialog_t</a>!<br />
        ///         If you do not implement these callback handlers, the browser may appear to hang instead of
        ///         navigating to new pages or triggering javascript popups!<br />
        ///         <br />
        ///         <strong>NOTE:</strong> You MUST call
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#RemoveBrowser" class="bb_apilink">ISteamHTMLSurface::RemoveBrowser</a>
        ///         when you are done using this browser to free up the resources associated with it. Failing to
        ///         do so will result in a memory leak.
        ///     </div>
        /// </div>
        /// <br />
        /// You will want to call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#SetSize" class="bb_apilink">ISteamHTMLSurface::SetSize</a>
        /// and
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#LoadURL" class="bb_apilink">ISteamHTMLSurface::LoadURL</a>
        /// to start using your display surface.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_BrowserReady_t" class="bb_apilink">HTML_BrowserReady_t</a>
        /// call result.
        /// </summary>
        /// <param name="pchUserAgent">const char *: 
        ///             Appends the string to the general user agent string of the browser, allowing you to
        ///             detect your client on webservers. Use <b>NULL</b> if you do not require this
        ///             functionality.
        ///         </param>
        /// <param name="pchUserCSS">const char *: 
        ///             This allows you to set a CSS style to every page displayed by this browser. Use
        ///             <b>NULL</b> if you do not require this functionality.
        ///         </param>
        public static SteamAPICall CreateBrowser(UTF8StringPtr pchUserAgent, UTF8StringPtr pchUserCSS) => Instance.CreateBrowser(pchUserAgent, pchUserCSS);
        /// <summary>
        /// <code>void RemoveBrowser( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// You MUST call this when you are done with an HTML surface, freeing the resources associated with
        /// it.<br />
        /// <br />
        /// Failing to call this will result in a memory leak!
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The browser handle to release.</param>
        public static void RemoveBrowser(HHTMLBrowser unBrowserHandle) => Instance.RemoveBrowser(unBrowserHandle);
        /// <summary>
        /// <code>
        ///     void LoadURL( HHTMLBrowser unBrowserHandle, const char *pchURL, const char *pchPostData );
        /// </code>
        /// 
        /// <br />
        /// Navigate to a specified URL.<br />
        /// <br />
        /// If you send POST data with <code class="bb_code bb_code_inline nohighlight">pchPostData</code> then
        /// the data should be formatted as:
        /// <code class="bb_code bb_code_inline nohighlight">name1=value1&amp;name2=value2</code>.<br />
        /// <br />
        /// You can load any URI scheme supported by Chromium Embedded Framework including but not limited to:
        /// <code class="bb_code bb_code_inline nohighlight">http://</code>,
        /// <code class="bb_code bb_code_inline nohighlight">https://</code>,
        /// <code class="bb_code bb_code_inline nohighlight">ftp://</code>, and
        /// <code class="bb_code bb_code_inline nohighlight">file:///</code>. If no scheme is specified then
        /// <code class="bb_code bb_code_inline nohighlight">http://</code> is used.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_StartRequest_t" class="bb_apilink">HTML_StartRequest_t</a>
        /// callback.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to load this URL in.</param>
        /// <param name="pchURL">const char *: The URL to load.</param>
        /// <param name="pchPostData">const char *: 
        ///             Optionally send a POST request with this data, set this to NULL to not send any data.
        ///         </param>
        public static void LoadURL(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchURL, UTF8StringPtr pchPostData) => Instance.LoadURL(unBrowserHandle, pchURL, pchPostData);
        /// <summary>
        /// <code>
        ///     void SetSize( HHTMLBrowser unBrowserHandle, uint32 unWidth, uint32 unHeight );
        /// </code>
        /// 
        /// <br />
        /// Sets the display size of a surface in pixels.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to set the size of.</param>
        /// <param name="unWidth">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : The width of the surface in pixels.</param>
        /// <param name="unHeight">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : The height of the surface in pixels.</param>
        public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) => Instance.SetSize(unBrowserHandle, unWidth, unHeight);
        /// <summary>
        /// <code>void StopLoad( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Stop the load of the current HTML page.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to stop loading.</param>
        public static void StopLoad(HHTMLBrowser unBrowserHandle) => Instance.StopLoad(unBrowserHandle);
        /// <summary>
        /// <code>void Reload( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Refreshes the current page.<br />
        /// <br />
        /// The reload will most likely hit the local cache instead of going over the network. This is
        /// equivalent to F5 or Ctrl+R in your browser of choice.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to reload.</param>
        public static void Reload(HHTMLBrowser unBrowserHandle) => Instance.Reload(unBrowserHandle);
        /// <summary>
        /// <code>void GoBack( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Navigate back in the page history.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to navigate back on.</param>
        public static void GoBack(HHTMLBrowser unBrowserHandle) => Instance.GoBack(unBrowserHandle);
        /// <summary>
        /// <code>void GoForward( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Navigate forward in the page history
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to navigate forward on.</param>
        public static void GoForward(HHTMLBrowser unBrowserHandle) => Instance.GoForward(unBrowserHandle);
        /// <summary>
        /// <code>
        ///     void AddHeader( HHTMLBrowser unBrowserHandle, const char *pchKey, const char *pchValue );
        /// </code>
        /// 
        /// <br />
        /// Add a header to any HTTP requests from this browser.<br />
        /// <br />
        /// A full list of standard request fields are available here on
        /// <a href="https://en.wikipedia.org/wiki/List_of_HTTP_header_fields" target="_blank" rel="noreferrer">wikipedia</a>.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to add the header to.</param>
        /// <param name="pchKey">const char *: The header name to add.</param>
        /// <param name="pchValue">const char *: The header value to associate with the key.</param>
        public static void AddHeader(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.AddHeader(unBrowserHandle, pchKey, pchValue);
        /// <summary>
        /// <code>
        ///     void ExecuteJavascript( HHTMLBrowser unBrowserHandle, const char *pchScript );
        /// </code>
        /// 
        /// <br />
        /// Run a javascript script in the currently loaded page.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface that is navigating.</param>
        /// <param name="pchScript">const char *: The javascript script to run.</param>
        public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchScript) => Instance.ExecuteJavascript(unBrowserHandle, pchScript);
        /// <summary>
        /// <code>
        ///     void MouseUp( HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton );
        /// </code>
        /// 
        /// <br />
        /// Tells an HTML surface that a mouse button has been released.<br />
        /// <br />
        /// The click will occur where the surface thinks the mouse is based on the last call to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#MouseMove" class="bb_apilink">ISteamHTMLSurface::MouseMove</a>.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="eMouseButton">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#EHTMLMouseButton" class="bb_apilink">EHTMLMouseButton</a>
        ///         : The mouse button which was released.</param>
        public static void MouseUp(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => Instance.MouseUp(unBrowserHandle, eMouseButton);
        /// <summary>
        /// <code>
        ///     void MouseDown( HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton );
        /// </code>
        /// 
        /// <br />
        /// Tells an HTML surface that a mouse button has been pressed.<br />
        /// <br />
        /// The click will occur where the surface thinks the mouse is based on the last call to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#MouseMove" class="bb_apilink">ISteamHTMLSurface::MouseMove</a>.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="eMouseButton">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#EHTMLMouseButton" class="bb_apilink">EHTMLMouseButton</a>
        ///         : The mouse button which was pressed.</param>
        public static void MouseDown(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => Instance.MouseDown(unBrowserHandle, eMouseButton);
        /// <summary>
        /// <code>
        ///     void MouseDoubleClick( HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton );
        /// </code>
        /// 
        /// <br />
        /// Tells an HTML surface that a mouse button has been double clicked.<br />
        /// <br />
        /// The click will occur where the surface thinks the mouse is based on the last call to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#MouseMove" class="bb_apilink">ISteamHTMLSurface::MouseMove</a>.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="eMouseButton">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#EHTMLMouseButton" class="bb_apilink">EHTMLMouseButton</a>
        ///         : The mouse button which was double clicked.</param>
        public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => Instance.MouseDoubleClick(unBrowserHandle, eMouseButton);
        /// <summary>
        /// <code>void MouseMove( HHTMLBrowser unBrowserHandle, int x, int y );</code>
        /// 
        /// <br />
        /// Tells an HTML surface where the mouse is.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="x">int: 
        ///             X (width) coordinate in pixels relative to the position of the HTML surface. (0, 0) is
        ///             the top left.
        ///         </param>
        /// <param name="y">int: 
        ///             Y (height) coordinate in pixels relative to the position of the HTML surface. (0, 0) is
        ///             the top left.
        ///         </param>
        public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) => Instance.MouseMove(unBrowserHandle, x, y);
        /// <summary>
        /// <code>void MouseWheel( HHTMLBrowser unBrowserHandle, int32 nDelta );</code>
        /// 
        /// <br />
        /// Tells an HTML surface that the mouse wheel has moved.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="nDelta">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#int32" class="bb_apilink">int32</a>
        ///         : The number of pixels to scroll.</param>
        public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) => Instance.MouseWheel(unBrowserHandle, nDelta);
        /// <summary>
        /// <code>
        ///     void KeyDown( HHTMLBrowser unBrowserHandle, uint32 nNativeKeyCode, EHTMLKeyModifiers
        ///     eHTMLKeyModifiers );
        /// </code>
        /// 
        /// <br />
        /// keyboard interactions, native keycode is the virtual key code value from your OS
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="nNativeKeyCode">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : This is the virtual keycode value from the OS.</param>
        /// <param name="eHTMLKeyModifiers">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#EHTMLKeyModifiers" class="bb_apilink">EHTMLKeyModifiers</a>
        ///         : 
        ///             This should be set to a bitmask of the modifier keys that the user is currently
        ///             pressing.
        ///         </param>
        public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey) => Instance.KeyDown(unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers, bIsSystemKey);
        /// <summary>
        /// <code>
        ///     void KeyUp( HHTMLBrowser unBrowserHandle, uint32 nNativeKeyCode, EHTMLKeyModifiers
        ///     eHTMLKeyModifiers );
        /// </code>
        /// 
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="nNativeKeyCode">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : This is the virtual keycode value from the OS.</param>
        /// <param name="eHTMLKeyModifiers">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#EHTMLKeyModifiers" class="bb_apilink">EHTMLKeyModifiers</a>
        ///         : 
        ///             This should be set to a bitmask of the modifier keys that the user is currently
        ///             pressing.
        ///         </param>
        public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers) => Instance.KeyUp(unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers);
        /// <summary>
        /// <code>
        ///     void KeyChar( HHTMLBrowser unBrowserHandle, uint32 cUnicodeChar, EHTMLKeyModifiers
        ///     eHTMLKeyModifiers );
        /// </code>
        /// 
        /// <br />
        /// cUnicodeChar is the unicode character point for this keypress (and potentially multiple chars per
        /// press)
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to send the interaction to.</param>
        /// <param name="cUnicodeChar">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : 
        ///             The unicode character point for this keypress; and potentially multiple characters per
        ///             press.
        ///         </param>
        /// <param name="eHTMLKeyModifiers">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#EHTMLKeyModifiers" class="bb_apilink">EHTMLKeyModifiers</a>
        ///         : 
        ///             This should be set to a bitmask of the modifier keys that the user is currently
        ///             pressing.
        ///         </param>
        public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers) => Instance.KeyChar(unBrowserHandle, cUnicodeChar, eHTMLKeyModifiers);
        /// <summary>
        /// <code>
        ///     void SetHorizontalScroll( HHTMLBrowser unBrowserHandle, uint32 nAbsolutePixelScroll );
        /// </code>
        /// 
        /// <br />
        /// Scroll the current page horizontally.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_HorizontalScroll_t" class="bb_apilink">HTML_HorizontalScroll_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_HorizontalScroll_t" class="bb_apilink">HTML_HorizontalScroll_t</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#SetVerticalScroll" class="bb_apilink">ISteamHTMLSurface::SetVerticalScroll</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_VerticalScroll_t" class="bb_apilink">HTML_VerticalScroll_t</a>
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to set the horizontal scroll position.</param>
        /// <param name="nAbsolutePixelScroll">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : 
        ///             The absolute pixel position to scroll to. 0 is the left and
        ///             <code class="bb_code bb_code_inline nohighlight">HTML_HorizontalScroll_t.unScrollMax</code>
        ///             is the right side.
        ///         </param>
        public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) => Instance.SetHorizontalScroll(unBrowserHandle, nAbsolutePixelScroll);
        /// <summary>
        /// <code>
        ///     void SetVerticalScroll( HHTMLBrowser unBrowserHandle, uint32 nAbsolutePixelScroll );
        /// </code>
        /// 
        /// <br />
        /// Scroll the current page vertically.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_VerticalScroll_t" class="bb_apilink">HTML_VerticalScroll_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_VerticalScroll_t" class="bb_apilink">HTML_VerticalScroll_t</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#SetHorizontalScroll" class="bb_apilink">ISteamHTMLSurface::SetHorizontalScroll</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_HorizontalScroll_t" class="bb_apilink">HTML_HorizontalScroll_t</a>
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to set the vertical scroll position.</param>
        /// <param name="nAbsolutePixelScroll">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : 
        ///             The absolute pixel position to scroll to. 0 is the top and
        ///             <code class="bb_code bb_code_inline nohighlight">HTML_VerticalScroll_t.unScrollMax</code>
        ///             is the bottom.
        ///         </param>
        public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) => Instance.SetVerticalScroll(unBrowserHandle, nAbsolutePixelScroll);
        /// <summary>
        /// <code>void SetKeyFocus( HHTMLBrowser unBrowserHandle, bool bHasKeyFocus );</code>
        /// 
        /// <br />
        /// Tell a HTML surface if it has key focus currently, controls showing the I-beam cursor in text
        /// controls amongst other things.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to set key focus on.</param>
        /// <param name="bHasKeyFocus">bool: Turn key focus on or off?</param>
        public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) => Instance.SetKeyFocus(unBrowserHandle, bHasKeyFocus);
        /// <summary>
        /// <code>void ViewSource( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Open the current pages HTML source code in default local text editor, used for debugging.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to view its current pages source.</param>
        public static void ViewSource(HHTMLBrowser unBrowserHandle) => Instance.ViewSource(unBrowserHandle);
        /// <summary>
        /// <code>void CopyToClipboard( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Copy the currently selected text from the current page in an HTML surface into the local clipboard.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to copy the text from.</param>
        public static void CopyToClipboard(HHTMLBrowser unBrowserHandle) => Instance.CopyToClipboard(unBrowserHandle);
        /// <summary>
        /// <code>void PasteFromClipboard( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Paste from the local clipboard to the current page in an HTML surface.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to paste into.</param>
        public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle) => Instance.PasteFromClipboard(unBrowserHandle);
        /// <summary>
        /// <code>
        ///     void Find( HHTMLBrowser unBrowserHandle, const char *pchSearchStr, bool bCurrentlyInFind, bool
        ///     bReverse );
        /// </code>
        /// 
        /// <br />
        /// Find a string in the current page of an HTML surface.<br />
        /// <br />
        /// This is the equivalent of "ctrl+f" in your browser of choice. It will highlight all of the matching
        /// strings.<br />
        /// <br />
        /// You should call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#StopFind" class="bb_apilink">ISteamHTMLSurface::StopFind</a>
        /// when the input string has changed or you want to stop searching.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_SearchResults_t" class="bb_apilink">HTML_SearchResults_t</a>
        /// callback.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to find the string in.</param>
        /// <param name="pchSearchStr">const char *: The string to search for.</param>
        /// <param name="bCurrentlyInFind">bool: 
        ///             Set this to <b>true</b> on subsequent calls to cycle through to the next
        ///             matching string.
        ///         </param>
        /// <param name="bReverse">bool: Search from the bottom up?</param>
        public static void Find(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchSearchStr, bool bCurrentlyInFind, bool bReverse) => Instance.Find(unBrowserHandle, pchSearchStr, bCurrentlyInFind, bReverse);
        /// <summary>
        /// <code>void StopFind( HHTMLBrowser unBrowserHandle );</code>
        /// 
        /// <br />
        /// Cancel a currently running find.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#Find" class="bb_apilink">ISteamHTMLSurface::Find</a>
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to stop the find results.</param>
        public static void StopFind(HHTMLBrowser unBrowserHandle) => Instance.StopFind(unBrowserHandle);
        /// <summary>
        /// <code>void GetLinkAtPosition( HHTMLBrowser unBrowserHandle, int x, int y );</code>
        /// 
        /// <br />
        /// Retrieves details about a link at a specific position on the current page in an HTML surface.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_LinkAtPosition_t" class="bb_apilink">HTML_LinkAtPosition_t</a>
        /// callback.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to get a link from.</param>
        /// <param name="x">int: The X (width) position in pixels within the surface. (0, 0) is the top left corner.</param>
        /// <param name="y">int: 
        ///             The Y (height) position in pixels within the surface. (0, 0) is the top left corner.
        ///         </param>
        public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) => Instance.GetLinkAtPosition(unBrowserHandle, x, y);
        /// <summary>
        /// <code>
        ///     void SetCookie( const char *pchHostname, const char *pchKey, const char *pchValue, const char
        ///     *pchPath = "/", RTime32 nExpires = 0, bool bSecure = false, bool bHTTPOnly = false );
        /// </code>
        /// 
        /// <br />
        /// Set a webcookie for a specific hostname.<br />
        /// <br />
        /// You can read more about the specifics of setting cookies here on
        /// <a href="https://en.wikipedia.org/wiki/HTTP_cookie#Implementation" target="_blank" rel="noreferrer">wikipedia</a>.
        /// </summary>
        /// <param name="pchHostname">const char *: The hostname of the server to set the cookie for. ('Host' attribute)</param>
        /// <param name="pchKey">const char *: The cookie name to set.</param>
        /// <param name="pchValue">const char *: The cookie value to set.</param>
        /// <param name="pchPath">const char *: 
        ///             Sets the 'Path' attribute on the cookie. You can use this to restrict the cookie to a
        ///             specific path on the domain. e.g. "/accounts"
        ///         </param>
        /// <param name="nExpires">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#RTime32" class="bb_apilink">RTime32</a>
        ///         : 
        ///             Sets the 'Expires' attribute on the cookie to the specified timestamp in Unix epoch
        ///             format (seconds since Jan 1st 1970).
        ///         </param>
        /// <param name="bSecure">bool: Sets the 'Secure' attribute.</param>
        /// <param name="bHTTPOnly">bool: Sets the 'HttpOnly' attribute.</param>
        public static void SetCookie(UTF8StringPtr pchHostname, UTF8StringPtr pchKey, UTF8StringPtr pchValue, UTF8StringPtr pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly) => Instance.SetCookie(pchHostname, pchKey, pchValue, pchPath, nExpires, bSecure, bHTTPOnly);
        /// <summary>
        /// <code>
        ///     void SetPageScaleFactor( HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY );
        /// </code>
        /// 
        /// <br />
        /// Zoom the current page in an HTML surface.<br />
        /// <br />
        /// The current scale factor is available from
        /// <code class="bb_code bb_code_inline nohighlight">HTML_NeedsPaint_t.flPageScale</code>,
        /// <code class="bb_code bb_code_inline nohighlight">HTML_HorizontalScroll_t.flPageScale</code>, and
        /// <code class="bb_code bb_code_inline nohighlight">HTML_VerticalScroll_t.flPageScale</code>.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface to scale.</param>
        /// <param name="flZoom">float: 
        ///             The amount to zoom, this can range from <b>1</b> (100% and the default) to
        ///             <b>2</b> (200%).
        ///         </param>
        /// <param name="nPointX">int: The X point in pixels to zoom around. Use 0 if you don't care.</param>
        /// <param name="nPointY">int: The Y point in pixels to zoom around. Use 0 if you don't care.</param>
        public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) => Instance.SetPageScaleFactor(unBrowserHandle, flZoom, nPointX, nPointY);
        /// <summary>
        /// <code>
        ///     void SetBackgroundMode( HHTMLBrowser unBrowserHandle, bool bBackgroundMode );
        /// </code>
        /// 
        /// <br />
        /// Enable/disable low-resource background mode, where javascript and repaint timers are throttled,
        /// resources are more aggressively purged from memory, and audio/video elements are paused.<br />
        /// <br />
        /// When background mode is enabled, all HTML5 video and audio objects will execute ".pause()" and gain
        /// the property "._steam_background_paused = 1".<br />
        /// When background mode is disabled, any video or audio objects with that property will resume with
        /// ".play()".
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface set background mode on.</param>
        /// <param name="bBackgroundMode">bool: Toggle background mode on or off.</param>
        public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) => Instance.SetBackgroundMode(unBrowserHandle, bBackgroundMode);
        /// missing documentation
        public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) => Instance.SetDPIScalingFactor(unBrowserHandle, flDPIScaling);
        /// missing documentation
        public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle) => Instance.OpenDeveloperTools(unBrowserHandle);
        /// <summary>
        /// <code>
        ///     void AllowStartRequest( HHTMLBrowser unBrowserHandle, bool bAllowed );
        /// </code>
        /// 
        /// <br />
        /// Sets whether a pending load is allowed or if it should be canceled.
        /// <div class="bb_callout bb_red bb_fixed">
        ///     <div>
        ///         <strong>NOTE:</strong>You MUST call this in response to a
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_StartRequest_t" class="bb_apilink">HTML_StartRequest_t</a>
        ///         callback.
        ///     </div>
        /// </div>
        /// <br />
        /// You can use this feature to limit the valid pages allowed in your HTML surface.
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface that is navigating.</param>
        /// <param name="bAllowed">bool: Allow or deny the navigation to the current start request.</param>
        public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) => Instance.AllowStartRequest(unBrowserHandle, bAllowed);
        /// <summary>
        /// <code>void JSDialogResponse( HHTMLBrowser unBrowserHandle, bool bResult );</code>
        /// 
        /// <br />
        /// Allows you to react to a page wanting to open a javascript modal dialog notification.
        /// <div class="bb_callout bb_red bb_fixed">
        ///     <div>
        ///         <strong>NOTE:</strong>You MUST call this in response to
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_JSAlert_t" class="bb_apilink">HTML_JSAlert_t</a>
        ///         and
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_JSConfirm_t" class="bb_apilink">HTML_JSConfirm_t</a>
        ///         callbacks.
        ///     </div>
        /// </div>
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface that is spawning a dialog.</param>
        /// <param name="bResult">bool: 
        ///             Set this to <b>true</b> to simulate pressing the "OK" button, otherwise
        ///             <b>false</b> for "Cancel".
        ///         </param>
        public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) => Instance.JSDialogResponse(unBrowserHandle, bResult);
        /// <summary>
        /// <code>
        ///     void FileLoadDialogResponse( HHTMLBrowser unBrowserHandle, const char **pchSelectedFiles );
        /// </code>
        /// 
        /// <br />
        /// Allows you to react to a page wanting to open a file load dialog.
        /// <div class="bb_callout bb_red bb_fixed">
        ///     <div>
        ///         <strong>NOTE:</strong>You MUST call this in response to a
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HTML_FileOpenDialog_t" class="bb_apilink">HTML_FileOpenDialog_t</a>
        ///         callback.
        ///     </div>
        /// </div>
        /// </summary>
        /// <param name="unBrowserHandle">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#HHTMLBrowser" class="bb_apilink">HHTMLBrowser</a>
        ///         : The handle of the surface that wants to spawn a file open dialog.</param>
        /// <param name="pchSelectedFiles">const char **: 
        ///             This should be an array of absolute file paths to the files that the user has selected.
        ///             <b>NULL</b> if the user did not select any files.
        ///         </param>
        public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, UTF8StringPtr* pchSelectedFiles) => Instance.FileLoadDialogResponse(unBrowserHandle, pchSelectedFiles);
    }
}