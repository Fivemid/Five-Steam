using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a user has responded to a microtransaction authorization request.<br />
    /// <br />
    /// </summary>
    public unsafe struct MicroTxnAuthorizationResponse : global::Unity.Entities.IComponentData
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