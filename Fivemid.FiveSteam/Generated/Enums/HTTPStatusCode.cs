using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EHTTPStatusCode</summary>
    public enum HTTPStatusCode : int
    {
        /// <summary>k_EHTTPStatusCodeInvalid</summary>
        Invalid = 0,
        /// <summary>k_EHTTPStatusCode100Continue</summary>
        _100Continue = 100,
        /// <summary>k_EHTTPStatusCode101SwitchingProtocols</summary>
        _101SwitchingProtocols = 101,
        /// <summary>k_EHTTPStatusCode200OK</summary>
        _200OK = 200,
        /// <summary>k_EHTTPStatusCode201Created</summary>
        _201Created = 201,
        /// <summary>k_EHTTPStatusCode202Accepted</summary>
        _202Accepted = 202,
        /// <summary>k_EHTTPStatusCode203NonAuthoritative</summary>
        _203NonAuthoritative = 203,
        /// <summary>k_EHTTPStatusCode204NoContent</summary>
        _204NoContent = 204,
        /// <summary>k_EHTTPStatusCode205ResetContent</summary>
        _205ResetContent = 205,
        /// <summary>k_EHTTPStatusCode206PartialContent</summary>
        _206PartialContent = 206,
        /// <summary>k_EHTTPStatusCode300MultipleChoices</summary>
        _300MultipleChoices = 300,
        /// <summary>k_EHTTPStatusCode301MovedPermanently</summary>
        _301MovedPermanently = 301,
        /// <summary>k_EHTTPStatusCode302Found</summary>
        _302Found = 302,
        /// <summary>k_EHTTPStatusCode303SeeOther</summary>
        _303SeeOther = 303,
        /// <summary>k_EHTTPStatusCode304NotModified</summary>
        _304NotModified = 304,
        /// <summary>k_EHTTPStatusCode305UseProxy</summary>
        _305UseProxy = 305,
        /// <summary>k_EHTTPStatusCode307TemporaryRedirect</summary>
        _307TemporaryRedirect = 307,
        /// <summary>k_EHTTPStatusCode308PermanentRedirect</summary>
        _308PermanentRedirect = 308,
        /// <summary>k_EHTTPStatusCode400BadRequest</summary>
        _400BadRequest = 400,
        /// <summary>k_EHTTPStatusCode401Unauthorized</summary>
        _401Unauthorized = 401,
        /// <summary>k_EHTTPStatusCode402PaymentRequired</summary>
        _402PaymentRequired = 402,
        /// <summary>k_EHTTPStatusCode403Forbidden</summary>
        _403Forbidden = 403,
        /// <summary>k_EHTTPStatusCode404NotFound</summary>
        _404NotFound = 404,
        /// <summary>k_EHTTPStatusCode405MethodNotAllowed</summary>
        _405MethodNotAllowed = 405,
        /// <summary>k_EHTTPStatusCode406NotAcceptable</summary>
        _406NotAcceptable = 406,
        /// <summary>k_EHTTPStatusCode407ProxyAuthRequired</summary>
        _407ProxyAuthRequired = 407,
        /// <summary>k_EHTTPStatusCode408RequestTimeout</summary>
        _408RequestTimeout = 408,
        /// <summary>k_EHTTPStatusCode409Conflict</summary>
        _409Conflict = 409,
        /// <summary>k_EHTTPStatusCode410Gone</summary>
        _410Gone = 410,
        /// <summary>k_EHTTPStatusCode411LengthRequired</summary>
        _411LengthRequired = 411,
        /// <summary>k_EHTTPStatusCode412PreconditionFailed</summary>
        _412PreconditionFailed = 412,
        /// <summary>k_EHTTPStatusCode413RequestEntityTooLarge</summary>
        _413RequestEntityTooLarge = 413,
        /// <summary>k_EHTTPStatusCode414RequestURITooLong</summary>
        _414RequestURITooLong = 414,
        /// <summary>k_EHTTPStatusCode415UnsupportedMediaType</summary>
        _415UnsupportedMediaType = 415,
        /// <summary>k_EHTTPStatusCode416RequestedRangeNotSatisfiable</summary>
        _416RequestedRangeNotSatisfiable = 416,
        /// <summary>k_EHTTPStatusCode417ExpectationFailed</summary>
        _417ExpectationFailed = 417,
        /// <summary>k_EHTTPStatusCode4xxUnknown</summary>
        _4xxUnknown = 418,
        /// <summary>k_EHTTPStatusCode429TooManyRequests</summary>
        _429TooManyRequests = 429,
        /// <summary>k_EHTTPStatusCode444ConnectionClosed</summary>
        _444ConnectionClosed = 444,
        /// <summary>k_EHTTPStatusCode500InternalServerError</summary>
        _500InternalServerError = 500,
        /// <summary>k_EHTTPStatusCode501NotImplemented</summary>
        _501NotImplemented = 501,
        /// <summary>k_EHTTPStatusCode502BadGateway</summary>
        _502BadGateway = 502,
        /// <summary>k_EHTTPStatusCode503ServiceUnavailable</summary>
        _503ServiceUnavailable = 503,
        /// <summary>k_EHTTPStatusCode504GatewayTimeout</summary>
        _504GatewayTimeout = 504,
        /// <summary>k_EHTTPStatusCode505HTTPVersionNotSupported</summary>
        _505HTTPVersionNotSupported = 505,
        /// <summary>k_EHTTPStatusCode5xxUnknown</summary>
        _5xxUnknown = 599
    }
}