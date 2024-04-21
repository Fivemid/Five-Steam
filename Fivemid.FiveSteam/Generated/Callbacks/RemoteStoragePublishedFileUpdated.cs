using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct RemoteStoragePublishedFileUpdated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStoragePublishedFileUpdated;
        /// <summary>The published file id</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>ID of the app that will consume this file.</summary>
        public AppId nAppID;
        /// <summary>not used anymore</summary>
        public ulong ulUnused;
    }
}