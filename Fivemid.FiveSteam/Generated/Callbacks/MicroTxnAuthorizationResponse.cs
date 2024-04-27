using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a user has responded to a microtransaction authorization request.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct MicroTxnAuthorizationResponse
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MicroTxnAuthorizationResponse;
        /// <summary>App ID for this microtransaction</summary>
        public uint unAppID;
        /// <summary>Order ID provided for the microtransaction.</summary>
        public ulong ulOrderID;
        /// <summary>Did the user authorize the transaction (<b>1</b>) or not (<b>0</b>)?</summary>
        public byte bAuthorized;
    }
}