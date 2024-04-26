using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Connection state to a specified user, returned by <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#GetP2PSessionState" class="bb_apilink">ISteamNetworking::GetP2PSessionState</a>. This is the under-the-hood info about what's going on with a previous call to <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SendP2PPacket" class="bb_apilink">ISteamNetworking::SendP2PPacket</a>. This typically shouldn't be needed except for debugging purposes.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct P2PSessionState
    {
        /// <summary>Do we have an active open connection with the user (<b>true</b>) or not (<b>false</b>)?</summary>
        public byte bConnectionActive;
        /// <summary>Are we currently trying to establish a connection with the user (<b>true</b>) or not (<b>false</b>)?</summary>
        public byte bConnecting;
        /// <summary>Last error recorded on the socket. This returns a <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#EP2PSessionError" class="bb_apilink">EP2PSessionError</a>.</summary>
        public byte eP2PSessionError;
        /// <summary>Is this connection going through a Steam relay server (<b>true</b>) or not (<b>false</b>)?</summary>
        public byte bUsingRelay;
        /// <summary>The number of bytes queued up to be sent to the user.</summary>
        public int nBytesQueuedForSend;
        /// <summary>The number of packets queued up to be sent to the user.</summary>
        public int nPacketsQueuedForSend;
        /// <summary>The IP of remote host if set. Could be a Steam relay server. This only exists for compatibility with older authentication api's.</summary>
        public uint nRemoteIP;
        /// <summary>The Port of remote host if set. Could be a Steam relay server. This only exists for compatibility with older authentication api's.</summary>
        public ushort nRemotePort;
    }
}