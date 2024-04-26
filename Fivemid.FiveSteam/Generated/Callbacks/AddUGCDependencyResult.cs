using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>The result of a call to <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddDependency" class="bb_apilink">ISteamUGC::AddDependency</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddDependency" class="bb_apilink">ISteamUGC::AddDependency</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct AddUGCDependencyResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AddUGCDependencyResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The parent workshop item that the dependency was added to.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The child workshop item which was added as a dependency to the parent item.</summary>
        public PublishedFileId nChildPublishedFileId;
    }
}