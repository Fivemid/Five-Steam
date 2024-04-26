using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Received when the game server requests to be displayed as secure (VAC protected)<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSPolicyResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSPolicyResponse;
        /// <summary>Is the server now set to secure (<b>true</b>) or unsecure (<b>false</b>)?.</summary>
        public byte bSecure;
    }
}