using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Reports the result of an attempt to change the current user's persona name.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SetPersonaName" class="bb_apilink">ISteamFriends::SetPersonaName</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SetPersonaNameResponse
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SetPersonaNameResponse;
        /// <summary><b>true</b> if name change completed successfully.</summary>
        public bool bSuccess;
        /// <summary><b>true</b> if name change was retained locally. We might not have been able to communicate with Steam.</summary>
        public bool bLocalSuccess;
        /// <summary>The result of the operation.</summary>
        public Result result;
    }
}