using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - PS3 only.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct PSNGameBootInviteResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.PSNGameBootInviteResult;
        /// <summary></summary>
        public bool bGameBootInviteExists;
        /// <summary></summary>
        public SteamId steamIDLobby;
    }
}