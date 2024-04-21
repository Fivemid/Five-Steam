using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Purpose: The result of a call to
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveDependency" class="bb_apilink">ISteamUGC::RemoveDependency</a>.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveDependency" class="bb_apilink">ISteamUGC::RemoveDependency</a>
    /// </summary>
    public unsafe struct RemoveUGCDependencyResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoveUGCDependencyResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The parent workshop item that the dependency was removed from.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The child workshop item which was removed as a dependency from the parent item.</summary>
        public PublishedFileId nChildPublishedFileId;
    }
}