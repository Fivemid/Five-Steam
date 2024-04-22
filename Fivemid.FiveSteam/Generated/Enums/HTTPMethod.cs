using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Used to set the HTTP request method in <a href="https://partner.steamgames.com/doc/api/ISteamHTTP#CreateHTTPRequest" class="bb_apilink">ISteam</a><a href="HTTP::CreateHTTPRequest" target="_blank" rel="noreferrer">HTTP::CreateHTTPRequest</a>. For the most part you should only ever need GET or POST.<br />
    /// <br />
    /// You can read more about HTTP request methods on the <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods" target="_blank" rel="noreferrer">Mozilla Developer Network</a>.<br />
    /// <br />
    /// </summary>
    public enum HTTPMethod : int
    {
        /// <summary>Invalid.</summary>
        Invalid = 0,
        /// <summary>The HTTP Method is set to GET.</summary>
        GET = 1,
        /// <summary>The HTTP Method is set to HEAD.</summary>
        HEAD = 2,
        /// <summary>The HTTP Method is set to POST.</summary>
        POST = 3,
        /// <summary>The HTTP Method is set to PUT.</summary>
        PUT = 4,
        /// <summary>The HTTP Method is set to DELETE.</summary>
        DELETE = 5,
        /// <summary>The HTTP Method is set to OPTIONS.</summary>
        OPTIONS = 6,
        /// <summary>The HTTP Method is set to PATCH.</summary>
        PATCH = 7
    }
}