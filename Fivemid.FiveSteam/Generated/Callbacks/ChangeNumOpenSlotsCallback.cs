using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Call result for <a href="https://partner.steamgames.com/doc/api/ISteamParties#ChangeNumOpenSlots" class="bb_apilink">ISteamParties::ChangeNumOpenSlots</a>. <br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct ChangeNumOpenSlotsCallback
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ChangeNumOpenSlotsCallback;
        /// <summary>The result of the attempt to change the number of open slots.</summary>
        public Result eResult;
    }
}