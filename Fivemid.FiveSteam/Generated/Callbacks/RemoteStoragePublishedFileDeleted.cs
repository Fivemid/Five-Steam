using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStoragePublishedFileDeleted
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStoragePublishedFileDeleted;
        /// <summary>The published file id</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>ID of the app that will consume this file.</summary>
        public AppId nAppID;
    }
}