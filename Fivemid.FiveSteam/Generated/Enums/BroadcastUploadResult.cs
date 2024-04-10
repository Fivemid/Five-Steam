using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EBroadcastUploadResult</summary>
    public enum BroadcastUploadResult : int
    {
        /// <summary>k_EBroadcastUploadResultNone</summary>
        None = 0,
        /// <summary>k_EBroadcastUploadResultOK</summary>
        OK = 1,
        /// <summary>k_EBroadcastUploadResultInitFailed</summary>
        InitFailed = 2,
        /// <summary>k_EBroadcastUploadResultFrameFailed</summary>
        FrameFailed = 3,
        /// <summary>k_EBroadcastUploadResultTimeout</summary>
        Timeout = 4,
        /// <summary>k_EBroadcastUploadResultBandwidthExceeded</summary>
        BandwidthExceeded = 5,
        /// <summary>k_EBroadcastUploadResultLowFPS</summary>
        LowFPS = 6,
        /// <summary>k_EBroadcastUploadResultMissingKeyFrames</summary>
        MissingKeyFrames = 7,
        /// <summary>k_EBroadcastUploadResultNoConnection</summary>
        NoConnection = 8,
        /// <summary>k_EBroadcastUploadResultRelayFailed</summary>
        RelayFailed = 9,
        /// <summary>k_EBroadcastUploadResultSettingsChanged</summary>
        SettingsChanged = 10,
        /// <summary>k_EBroadcastUploadResultMissingAudio</summary>
        MissingAudio = 11,
        /// <summary>k_EBroadcastUploadResultTooFarBehind</summary>
        TooFarBehind = 12,
        /// <summary>k_EBroadcastUploadResultTranscodeBehind</summary>
        TranscodeBehind = 13,
        /// <summary>k_EBroadcastUploadResultNotAllowedToPlay</summary>
        NotAllowedToPlay = 14,
        /// <summary>k_EBroadcastUploadResultBusy</summary>
        Busy = 15,
        /// <summary>k_EBroadcastUploadResultBanned</summary>
        Banned = 16,
        /// <summary>k_EBroadcastUploadResultAlreadyActive</summary>
        AlreadyActive = 17,
        /// <summary>k_EBroadcastUploadResultForcedOff</summary>
        ForcedOff = 18,
        /// <summary>k_EBroadcastUploadResultAudioBehind</summary>
        AudioBehind = 19,
        /// <summary>k_EBroadcastUploadResultShutdown</summary>
        Shutdown = 20,
        /// <summary>k_EBroadcastUploadResultDisconnect</summary>
        Disconnect = 21,
        /// <summary>k_EBroadcastUploadResultVideoInitFailed</summary>
        VideoInitFailed = 22,
        /// <summary>k_EBroadcastUploadResultAudioInitFailed</summary>
        AudioInitFailed = 23
    }
}