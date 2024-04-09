using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EParentalFeature</summary>
    public enum ParentalFeature : int
    {
        /// <summary>k_EFeatureInvalid</summary>
        FeatureInvalid = 0,
        /// <summary>k_EFeatureStore</summary>
        FeatureStore = 1,
        /// <summary>k_EFeatureCommunity</summary>
        FeatureCommunity = 2,
        /// <summary>k_EFeatureProfile</summary>
        FeatureProfile = 3,
        /// <summary>k_EFeatureFriends</summary>
        FeatureFriends = 4,
        /// <summary>k_EFeatureNews</summary>
        FeatureNews = 5,
        /// <summary>k_EFeatureTrading</summary>
        FeatureTrading = 6,
        /// <summary>k_EFeatureSettings</summary>
        FeatureSettings = 7,
        /// <summary>k_EFeatureConsole</summary>
        FeatureConsole = 8,
        /// <summary>k_EFeatureBrowser</summary>
        FeatureBrowser = 9,
        /// <summary>k_EFeatureParentalSetup</summary>
        FeatureParentalSetup = 10,
        /// <summary>k_EFeatureLibrary</summary>
        FeatureLibrary = 11,
        /// <summary>k_EFeatureTest</summary>
        FeatureTest = 12,
        /// <summary>k_EFeatureSiteLicense</summary>
        FeatureSiteLicense = 13,
        /// <summary>k_EFeatureKioskMode_Deprecated</summary>
        FeatureKioskMode_Deprecated = 14,
        /// <summary>k_EFeatureMax</summary>
        FeatureMax = 15
    }
}