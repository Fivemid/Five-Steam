using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when PS3 trophies are available.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct PS3TrophiesInstalled : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.PS3TrophiesInstalled;
        /// <summary>Game that these stats are for.</summary>
        public ulong nGameID;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>
        ///             If <code class="bb_code bb_code_inline nohighlight">m_eResult</code> is
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultDiskFull" class="bb_apilink">k_EResultDiskFull</a>, then this will contain the amount of space needed to install trophies.
        ///         </summary>
        public ulong ulRequiredDiskSpace;
    }
}