using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EVoiceResult</summary>
    public enum VoiceResult : int
    {
        /// <summary>k_EVoiceResultOK</summary>
        OK = 0,
        /// <summary>k_EVoiceResultNotInitialized</summary>
        NotInitialized = 1,
        /// <summary>k_EVoiceResultNotRecording</summary>
        NotRecording = 2,
        /// <summary>k_EVoiceResultNoData</summary>
        NoData = 3,
        /// <summary>k_EVoiceResultBufferTooSmall</summary>
        BufferTooSmall = 4,
        /// <summary>k_EVoiceResultDataCorrupted</summary>
        DataCorrupted = 5,
        /// <summary>k_EVoiceResultRestricted</summary>
        Restricted = 6,
        /// <summary>k_EVoiceResultUnsupportedCodec</summary>
        UnsupportedCodec = 7,
        /// <summary>k_EVoiceResultReceiverOutOfDate</summary>
        ReceiverOutOfDate = 8,
        /// <summary>k_EVoiceResultReceiverDidNotAnswer</summary>
        ReceiverDidNotAnswer = 9
    }
}