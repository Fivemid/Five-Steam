using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// 
    /// </summary>
    public unsafe struct RemoteStoragePublishedFileSubscribed : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStoragePublishedFileSubscribed;
        /// <summary>The published file id</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>ID of the app that will consume this file.</summary>
        public AppId nAppID;
    }
}