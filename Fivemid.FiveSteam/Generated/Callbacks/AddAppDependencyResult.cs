using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>The result of a call to <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddAppDependency" class="bb_apilink">ISteamUGC::AddAppDependency</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddAppDependency" class="bb_apilink">ISteamUGC::AddAppDependency</a></summary>
    public unsafe struct AddAppDependencyResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AddAppDependencyResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The parent workshop item that the dependency was added to.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The app/dlc.</summary>
        public AppId nAppID;
    }
}