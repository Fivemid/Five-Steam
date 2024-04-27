using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Purpose: The result of a call to <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveAppDependency" class="bb_apilink">ISteamUGC::RemoveAppDependency</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveAppDependency" class="bb_apilink">ISteamUGC::RemoveAppDependency</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoveAppDependencyResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoveAppDependencyResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The parent workshop item that the dependency was removed from.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The app/dlc.</summary>
        public AppId nAppID;
    }
}