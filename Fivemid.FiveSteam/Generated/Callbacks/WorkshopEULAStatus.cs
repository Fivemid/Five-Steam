using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Callback returned
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetWorkshopEULAStatus" class="bb_apilink">ISteamUGC::GetWorkshopEULAStatus</a><br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetWorkshopEULAStatus" class="bb_apilink">ISteamUGC::GetWorkshopEULAStatus</a>
    /// </summary>
    public unsafe struct WorkshopEULAStatus : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.WorkshopEULAStatus;
        /// <summary>The result of the operation</summary>
        public Result eResult;
        /// <summary>The related appid.</summary>
        public AppId nAppID;
        /// <summary>The version of the signed EULA, if applicable</summary>
        public uint unVersion;
        /// <summary>Unix timestamp of when the user signed the EULA, if applicable.</summary>
        public RTime32 rtAction;
        /// <summary>
        ///             True if the user accepted the given version, false otherwise. Note that this can be true
        ///             if the user accepted an older version of the EULA.
        ///         </summary>
        public bool bAccepted;
        /// <summary>True if the user needs to accept the latest Workshop EULA, false otherwise.</summary>
        public bool bNeedsAction;
    }
}