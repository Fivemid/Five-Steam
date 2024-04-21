using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Call result for
    /// <a href="https://partner.steamgames.com/doc/api/ISteamParties#ChangeNumOpenSlots" class="bb_apilink">ISteamParties::ChangeNumOpenSlots</a>. <br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct ChangeNumOpenSlotsCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ChangeNumOpenSlotsCallback;
        /// <summary>The result of the attempt to change the number of open slots.</summary>
        public Result eResult;
    }
}