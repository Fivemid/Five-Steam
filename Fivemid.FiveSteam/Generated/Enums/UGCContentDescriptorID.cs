using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUGCContentDescriptorID</summary>
    public enum UGCContentDescriptorID : int
    {
        /// <summary>k_EUGCContentDescriptor_NudityOrSexualContent</summary>
        UGCContentDescriptor_NudityOrSexualContent = 1,
        /// <summary>k_EUGCContentDescriptor_FrequentViolenceOrGore</summary>
        UGCContentDescriptor_FrequentViolenceOrGore = 2,
        /// <summary>k_EUGCContentDescriptor_AdultOnlySexualContent</summary>
        UGCContentDescriptor_AdultOnlySexualContent = 3,
        /// <summary>k_EUGCContentDescriptor_GratuitousSexualContent</summary>
        UGCContentDescriptor_GratuitousSexualContent = 4,
        /// <summary>k_EUGCContentDescriptor_AnyMatureContent</summary>
        UGCContentDescriptor_AnyMatureContent = 5
    }
}