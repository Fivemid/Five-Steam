using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTTP response status codes that the server can send in response to a request.<br />
    /// <br />
    /// See the <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Status" target="_blank" rel="noreferrer">Mozilla Developer Network</a> or RFC2616 section 10.3 for detailed descriptions for each of these.<br />
    /// <br />
    /// </summary>
    public enum HTTPStatusCode : int
    {
        /// <summary>Invalid status code. This isn't defined in HTTP, used to indicate unset in our code.</summary>
        Invalid = 0,
        /// <summary></summary>
        _100Continue = 100,
        /// <summary></summary>
        _101SwitchingProtocols = 101,
        /// <summary></summary>
        _200OK = 200,
        /// <summary></summary>
        _201Created = 201,
        /// <summary></summary>
        _202Accepted = 202,
        /// <summary></summary>
        _203NonAuthoritative = 203,
        /// <summary></summary>
        _204NoContent = 204,
        /// <summary></summary>
        _205ResetContent = 205,
        /// <summary></summary>
        _206PartialContent = 206,
        /// <summary></summary>
        _300MultipleChoices = 300,
        /// <summary></summary>
        _301MovedPermanently = 301,
        /// <summary></summary>
        _302Found = 302,
        /// <summary></summary>
        _303SeeOther = 303,
        /// <summary></summary>
        _304NotModified = 304,
        /// <summary></summary>
        _305UseProxy = 305,
        /// <summary></summary>
        _307TemporaryRedirect = 307,
        /// missing documentation for EHTTPStatusCode.k_EHTTPStatusCode308PermanentRedirect
        _308PermanentRedirect = 308,
        /// <summary></summary>
        _400BadRequest = 400,
        /// <summary>You probably want 403 or something else. 401 implies you're sending a WWW-Authenticate header and the client can sent an Authorization header in response.</summary>
        _401Unauthorized = 401,
        /// <summary>This is reserved for future HTTP specs, not really supported by clients.</summary>
        _402PaymentRequired = 402,
        /// <summary></summary>
        _403Forbidden = 403,
        /// <summary></summary>
        _404NotFound = 404,
        /// <summary></summary>
        _405MethodNotAllowed = 405,
        /// <summary></summary>
        _406NotAcceptable = 406,
        /// <summary></summary>
        _407ProxyAuthRequired = 407,
        /// <summary></summary>
        _408RequestTimeout = 408,
        /// <summary></summary>
        _409Conflict = 409,
        /// <summary></summary>
        _410Gone = 410,
        /// <summary></summary>
        _411LengthRequired = 411,
        /// <summary></summary>
        _412PreconditionFailed = 412,
        /// <summary></summary>
        _413RequestEntityTooLarge = 413,
        /// <summary></summary>
        _414RequestURITooLong = 414,
        /// <summary></summary>
        _415UnsupportedMediaType = 415,
        /// <summary></summary>
        _416RequestedRangeNotSatisfiable = 416,
        /// <summary></summary>
        _417ExpectationFailed = 417,
        /// <summary>418 is reserved, so we use it to mean unknown.</summary>
        _4xxUnknown = 418,
        /// <summary></summary>
        _429TooManyRequests = 429,
        /// missing documentation for EHTTPStatusCode.k_EHTTPStatusCode444ConnectionClosed
        _444ConnectionClosed = 444,
        /// <summary></summary>
        _500InternalServerError = 500,
        /// <summary></summary>
        _501NotImplemented = 501,
        /// <summary></summary>
        _502BadGateway = 502,
        /// <summary></summary>
        _503ServiceUnavailable = 503,
        /// <summary></summary>
        _504GatewayTimeout = 504,
        /// <summary></summary>
        _505HTTPVersionNotSupported = 505,
        /// <summary></summary>
        _5xxUnknown = 599
    }
}