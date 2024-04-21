using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Broadcast upload result from
    /// <a href="https://partner.steamgames.com/doc/api/ISteamVideo#BroadcastUploadStop_t" class="bb_apilink">BroadcastUploadStop_t</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum BroadcastUploadResult : int
    {
        /// <summary>Broadcast state unknown.</summary>
        None = 0,
        /// <summary>Broadcast was good, no problems.</summary>
        OK = 1,
        /// <summary>Broadcast init failed.</summary>
        InitFailed = 2,
        /// <summary>Broadcast frame upload failed.</summary>
        FrameFailed = 3,
        /// <summary>Broadcast upload timed out.</summary>
        Timeout = 4,
        /// <summary>Broadcast send too much data.</summary>
        BandwidthExceeded = 5,
        /// <summary>Broadcast FPS is too low.</summary>
        LowFPS = 6,
        /// <summary>Broadcast sending not enough key frames.</summary>
        MissingKeyFrames = 7,
        /// <summary>Broadcast client failed to connect to relay.</summary>
        NoConnection = 8,
        /// <summary>Relay dropped the upload.</summary>
        RelayFailed = 9,
        /// <summary>The client changed broadcast settings.</summary>
        SettingsChanged = 10,
        /// <summary>Client failed to send audio data.</summary>
        MissingAudio = 11,
        /// <summary>Clients was too slow uploading.</summary>
        TooFarBehind = 12,
        /// <summary>Server failed to keep up with transcode.</summary>
        TranscodeBehind = 13,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultNotAllowedToPlay
        NotAllowedToPlay = 14,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultBusy
        Busy = 15,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultBanned
        Banned = 16,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultAlreadyActive
        AlreadyActive = 17,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultForcedOff
        ForcedOff = 18,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultAudioBehind
        AudioBehind = 19,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultShutdown
        Shutdown = 20,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultDisconnect
        Disconnect = 21,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultVideoInitFailed
        VideoInitFailed = 22,
        /// missing documentation for EBroadcastUploadResult.k_EBroadcastUploadResultAudioInitFailed
        AudioInitFailed = 23
    }
}