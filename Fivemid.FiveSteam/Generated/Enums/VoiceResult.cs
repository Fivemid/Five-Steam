using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Results for use with the <a href="https://partner.steamgames.com/doc/features/voice" class="bb_doclink">Steam Voice</a> functions.<br />
    /// <br />
    /// </summary>
    public enum VoiceResult : int
    {
        /// <summary>The call has completed successfully.</summary>
        OK = 0,
        /// <summary>The Steam Voice interface has not been initialized.</summary>
        NotInitialized = 1,
        /// <summary>Steam Voice is not currently recording.</summary>
        NotRecording = 2,
        /// <summary>There is no voice data available.</summary>
        NoData = 3,
        /// <summary>The provided buffer is too small to receive the data.</summary>
        BufferTooSmall = 4,
        /// <summary>The voice data has been corrupted.</summary>
        DataCorrupted = 5,
        /// <summary>The user is chat restricted.</summary>
        Restricted = 6,
        /// <summary>Deprecated.</summary>
        UnsupportedCodec = 7,
        /// <summary>Deprecated.</summary>
        ReceiverOutOfDate = 8,
        /// <summary>Deprecated.</summary>
        ReceiverDidNotAnswer = 9
    }
}