using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - PS3 only.<br />
    /// <br />
    /// </summary>
    public unsafe struct PSNGameBootInviteResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.PSNGameBootInviteResult;
        /// <summary></summary>
        public bool bGameBootInviteExists;
        /// <summary></summary>
        public SteamId steamIDLobby;
    }
}