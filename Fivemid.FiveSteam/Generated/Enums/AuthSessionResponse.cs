using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EAuthSessionResponse</summary>
    public enum AuthSessionResponse : int
    {
        /// <summary>k_EAuthSessionResponseOK</summary>
        OK = 0,
        /// <summary>k_EAuthSessionResponseUserNotConnectedToSteam</summary>
        UserNotConnectedToSteam = 1,
        /// <summary>k_EAuthSessionResponseNoLicenseOrExpired</summary>
        NoLicenseOrExpired = 2,
        /// <summary>k_EAuthSessionResponseVACBanned</summary>
        VACBanned = 3,
        /// <summary>k_EAuthSessionResponseLoggedInElseWhere</summary>
        LoggedInElseWhere = 4,
        /// <summary>k_EAuthSessionResponseVACCheckTimedOut</summary>
        VACCheckTimedOut = 5,
        /// <summary>k_EAuthSessionResponseAuthTicketCanceled</summary>
        AuthTicketCanceled = 6,
        /// <summary>k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed</summary>
        AuthTicketInvalidAlreadyUsed = 7,
        /// <summary>k_EAuthSessionResponseAuthTicketInvalid</summary>
        AuthTicketInvalid = 8,
        /// <summary>k_EAuthSessionResponsePublisherIssuedBan</summary>
        PublisherIssuedBan = 9,
        /// <summary>k_EAuthSessionResponseAuthTicketNetworkIdentityFailure</summary>
        AuthTicketNetworkIdentityFailure = 10
    }
}