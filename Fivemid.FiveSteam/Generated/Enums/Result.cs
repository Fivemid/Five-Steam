using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EResult</summary>
    public enum Result : int
    {
        /// <summary>k_EResultNone</summary>
        None = 0,
        /// <summary>k_EResultOK</summary>
        OK = 1,
        /// <summary>k_EResultFail</summary>
        Fail = 2,
        /// <summary>k_EResultNoConnection</summary>
        NoConnection = 3,
        /// <summary>k_EResultInvalidPassword</summary>
        InvalidPassword = 5,
        /// <summary>k_EResultLoggedInElsewhere</summary>
        LoggedInElsewhere = 6,
        /// <summary>k_EResultInvalidProtocolVer</summary>
        InvalidProtocolVer = 7,
        /// <summary>k_EResultInvalidParam</summary>
        InvalidParam = 8,
        /// <summary>k_EResultFileNotFound</summary>
        FileNotFound = 9,
        /// <summary>k_EResultBusy</summary>
        Busy = 10,
        /// <summary>k_EResultInvalidState</summary>
        InvalidState = 11,
        /// <summary>k_EResultInvalidName</summary>
        InvalidName = 12,
        /// <summary>k_EResultInvalidEmail</summary>
        InvalidEmail = 13,
        /// <summary>k_EResultDuplicateName</summary>
        DuplicateName = 14,
        /// <summary>k_EResultAccessDenied</summary>
        AccessDenied = 15,
        /// <summary>k_EResultTimeout</summary>
        Timeout = 16,
        /// <summary>k_EResultBanned</summary>
        Banned = 17,
        /// <summary>k_EResultAccountNotFound</summary>
        AccountNotFound = 18,
        /// <summary>k_EResultInvalidSteamID</summary>
        InvalidSteamID = 19,
        /// <summary>k_EResultServiceUnavailable</summary>
        ServiceUnavailable = 20,
        /// <summary>k_EResultNotLoggedOn</summary>
        NotLoggedOn = 21,
        /// <summary>k_EResultPending</summary>
        Pending = 22,
        /// <summary>k_EResultEncryptionFailure</summary>
        EncryptionFailure = 23,
        /// <summary>k_EResultInsufficientPrivilege</summary>
        InsufficientPrivilege = 24,
        /// <summary>k_EResultLimitExceeded</summary>
        LimitExceeded = 25,
        /// <summary>k_EResultRevoked</summary>
        Revoked = 26,
        /// <summary>k_EResultExpired</summary>
        Expired = 27,
        /// <summary>k_EResultAlreadyRedeemed</summary>
        AlreadyRedeemed = 28,
        /// <summary>k_EResultDuplicateRequest</summary>
        DuplicateRequest = 29,
        /// <summary>k_EResultAlreadyOwned</summary>
        AlreadyOwned = 30,
        /// <summary>k_EResultIPNotFound</summary>
        IPNotFound = 31,
        /// <summary>k_EResultPersistFailed</summary>
        PersistFailed = 32,
        /// <summary>k_EResultLockingFailed</summary>
        LockingFailed = 33,
        /// <summary>k_EResultLogonSessionReplaced</summary>
        LogonSessionReplaced = 34,
        /// <summary>k_EResultConnectFailed</summary>
        ConnectFailed = 35,
        /// <summary>k_EResultHandshakeFailed</summary>
        HandshakeFailed = 36,
        /// <summary>k_EResultIOFailure</summary>
        IOFailure = 37,
        /// <summary>k_EResultRemoteDisconnect</summary>
        RemoteDisconnect = 38,
        /// <summary>k_EResultShoppingCartNotFound</summary>
        ShoppingCartNotFound = 39,
        /// <summary>k_EResultBlocked</summary>
        Blocked = 40,
        /// <summary>k_EResultIgnored</summary>
        Ignored = 41,
        /// <summary>k_EResultNoMatch</summary>
        NoMatch = 42,
        /// <summary>k_EResultAccountDisabled</summary>
        AccountDisabled = 43,
        /// <summary>k_EResultServiceReadOnly</summary>
        ServiceReadOnly = 44,
        /// <summary>k_EResultAccountNotFeatured</summary>
        AccountNotFeatured = 45,
        /// <summary>k_EResultAdministratorOK</summary>
        AdministratorOK = 46,
        /// <summary>k_EResultContentVersion</summary>
        ContentVersion = 47,
        /// <summary>k_EResultTryAnotherCM</summary>
        TryAnotherCM = 48,
        /// <summary>k_EResultPasswordRequiredToKickSession</summary>
        PasswordRequiredToKickSession = 49,
        /// <summary>k_EResultAlreadyLoggedInElsewhere</summary>
        AlreadyLoggedInElsewhere = 50,
        /// <summary>k_EResultSuspended</summary>
        Suspended = 51,
        /// <summary>k_EResultCancelled</summary>
        Cancelled = 52,
        /// <summary>k_EResultDataCorruption</summary>
        DataCorruption = 53,
        /// <summary>k_EResultDiskFull</summary>
        DiskFull = 54,
        /// <summary>k_EResultRemoteCallFailed</summary>
        RemoteCallFailed = 55,
        /// <summary>k_EResultPasswordUnset</summary>
        PasswordUnset = 56,
        /// <summary>k_EResultExternalAccountUnlinked</summary>
        ExternalAccountUnlinked = 57,
        /// <summary>k_EResultPSNTicketInvalid</summary>
        PSNTicketInvalid = 58,
        /// <summary>k_EResultExternalAccountAlreadyLinked</summary>
        ExternalAccountAlreadyLinked = 59,
        /// <summary>k_EResultRemoteFileConflict</summary>
        RemoteFileConflict = 60,
        /// <summary>k_EResultIllegalPassword</summary>
        IllegalPassword = 61,
        /// <summary>k_EResultSameAsPreviousValue</summary>
        SameAsPreviousValue = 62,
        /// <summary>k_EResultAccountLogonDenied</summary>
        AccountLogonDenied = 63,
        /// <summary>k_EResultCannotUseOldPassword</summary>
        CannotUseOldPassword = 64,
        /// <summary>k_EResultInvalidLoginAuthCode</summary>
        InvalidLoginAuthCode = 65,
        /// <summary>k_EResultAccountLogonDeniedNoMail</summary>
        AccountLogonDeniedNoMail = 66,
        /// <summary>k_EResultHardwareNotCapableOfIPT</summary>
        HardwareNotCapableOfIPT = 67,
        /// <summary>k_EResultIPTInitError</summary>
        IPTInitError = 68,
        /// <summary>k_EResultParentalControlRestricted</summary>
        ParentalControlRestricted = 69,
        /// <summary>k_EResultFacebookQueryError</summary>
        FacebookQueryError = 70,
        /// <summary>k_EResultExpiredLoginAuthCode</summary>
        ExpiredLoginAuthCode = 71,
        /// <summary>k_EResultIPLoginRestrictionFailed</summary>
        IPLoginRestrictionFailed = 72,
        /// <summary>k_EResultAccountLockedDown</summary>
        AccountLockedDown = 73,
        /// <summary>k_EResultAccountLogonDeniedVerifiedEmailRequired</summary>
        AccountLogonDeniedVerifiedEmailRequired = 74,
        /// <summary>k_EResultNoMatchingURL</summary>
        NoMatchingURL = 75,
        /// <summary>k_EResultBadResponse</summary>
        BadResponse = 76,
        /// <summary>k_EResultRequirePasswordReEntry</summary>
        RequirePasswordReEntry = 77,
        /// <summary>k_EResultValueOutOfRange</summary>
        ValueOutOfRange = 78,
        /// <summary>k_EResultUnexpectedError</summary>
        UnexpectedError = 79,
        /// <summary>k_EResultDisabled</summary>
        Disabled = 80,
        /// <summary>k_EResultInvalidCEGSubmission</summary>
        InvalidCEGSubmission = 81,
        /// <summary>k_EResultRestrictedDevice</summary>
        RestrictedDevice = 82,
        /// <summary>k_EResultRegionLocked</summary>
        RegionLocked = 83,
        /// <summary>k_EResultRateLimitExceeded</summary>
        RateLimitExceeded = 84,
        /// <summary>k_EResultAccountLoginDeniedNeedTwoFactor</summary>
        AccountLoginDeniedNeedTwoFactor = 85,
        /// <summary>k_EResultItemDeleted</summary>
        ItemDeleted = 86,
        /// <summary>k_EResultAccountLoginDeniedThrottle</summary>
        AccountLoginDeniedThrottle = 87,
        /// <summary>k_EResultTwoFactorCodeMismatch</summary>
        TwoFactorCodeMismatch = 88,
        /// <summary>k_EResultTwoFactorActivationCodeMismatch</summary>
        TwoFactorActivationCodeMismatch = 89,
        /// <summary>k_EResultAccountAssociatedToMultiplePartners</summary>
        AccountAssociatedToMultiplePartners = 90,
        /// <summary>k_EResultNotModified</summary>
        NotModified = 91,
        /// <summary>k_EResultNoMobileDevice</summary>
        NoMobileDevice = 92,
        /// <summary>k_EResultTimeNotSynced</summary>
        TimeNotSynced = 93,
        /// <summary>k_EResultSmsCodeFailed</summary>
        SmsCodeFailed = 94,
        /// <summary>k_EResultAccountLimitExceeded</summary>
        AccountLimitExceeded = 95,
        /// <summary>k_EResultAccountActivityLimitExceeded</summary>
        AccountActivityLimitExceeded = 96,
        /// <summary>k_EResultPhoneActivityLimitExceeded</summary>
        PhoneActivityLimitExceeded = 97,
        /// <summary>k_EResultRefundToWallet</summary>
        RefundToWallet = 98,
        /// <summary>k_EResultEmailSendFailure</summary>
        EmailSendFailure = 99,
        /// <summary>k_EResultNotSettled</summary>
        NotSettled = 100,
        /// <summary>k_EResultNeedCaptcha</summary>
        NeedCaptcha = 101,
        /// <summary>k_EResultGSLTDenied</summary>
        GSLTDenied = 102,
        /// <summary>k_EResultGSOwnerDenied</summary>
        GSOwnerDenied = 103,
        /// <summary>k_EResultInvalidItemType</summary>
        InvalidItemType = 104,
        /// <summary>k_EResultIPBanned</summary>
        IPBanned = 105,
        /// <summary>k_EResultGSLTExpired</summary>
        GSLTExpired = 106,
        /// <summary>k_EResultInsufficientFunds</summary>
        InsufficientFunds = 107,
        /// <summary>k_EResultTooManyPending</summary>
        TooManyPending = 108,
        /// <summary>k_EResultNoSiteLicensesFound</summary>
        NoSiteLicensesFound = 109,
        /// <summary>k_EResultWGNetworkSendExceeded</summary>
        WGNetworkSendExceeded = 110,
        /// <summary>k_EResultAccountNotFriends</summary>
        AccountNotFriends = 111,
        /// <summary>k_EResultLimitedUserAccount</summary>
        LimitedUserAccount = 112,
        /// <summary>k_EResultCantRemoveItem</summary>
        CantRemoveItem = 113,
        /// <summary>k_EResultAccountDeleted</summary>
        AccountDeleted = 114,
        /// <summary>k_EResultExistingUserCancelledLicense</summary>
        ExistingUserCancelledLicense = 115,
        /// <summary>k_EResultCommunityCooldown</summary>
        CommunityCooldown = 116,
        /// <summary>k_EResultNoLauncherSpecified</summary>
        NoLauncherSpecified = 117,
        /// <summary>k_EResultMustAgreeToSSA</summary>
        MustAgreeToSSA = 118,
        /// <summary>k_EResultLauncherMigrated</summary>
        LauncherMigrated = 119,
        /// <summary>k_EResultSteamRealmMismatch</summary>
        SteamRealmMismatch = 120,
        /// <summary>k_EResultInvalidSignature</summary>
        InvalidSignature = 121,
        /// <summary>k_EResultParseFailure</summary>
        ParseFailure = 122,
        /// <summary>k_EResultNoVerifiedPhone</summary>
        NoVerifiedPhone = 123,
        /// <summary>k_EResultInsufficientBattery</summary>
        InsufficientBattery = 124,
        /// <summary>k_EResultChargerRequired</summary>
        ChargerRequired = 125,
        /// <summary>k_EResultCachedCredentialInvalid</summary>
        CachedCredentialInvalid = 126,
        /// <summary>K_EResultPhoneNumberIsVOIP</summary>
        K_EResultPhoneNumberIsVOIP = 127,
        /// <summary>k_EResultNotSupported</summary>
        NotSupported = 128,
        /// <summary>k_EResultFamilySizeLimitExceeded</summary>
        FamilySizeLimitExceeded = 129
    }
}