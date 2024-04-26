using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when getting the app dependencies for an item.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetAppDependencies" class="bb_apilink">ISteamUGC::GetAppDependencies</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GetAppDependenciesResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetAppDependenciesResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The workshop item to get app dependencies for.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>Array of app dependencies</summary>
        public FixedArray_uint32 rgAppIDs;
        /// <summary>Number of returned app dependencies in m_rgAppIDs</summary>
        public uint nNumAppDependencies;
        /// <summary>Total app dependencies found.</summary>
        public uint nTotalNumAppDependencies;
    }
}