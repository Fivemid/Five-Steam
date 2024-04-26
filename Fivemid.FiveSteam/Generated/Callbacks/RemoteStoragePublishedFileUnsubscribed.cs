using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStoragePublishedFileUnsubscribed : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStoragePublishedFileUnsubscribed;
        /// <summary>The published file id</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>ID of the app that will consume this file.</summary>
        public AppId nAppID;
    }
}