using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ERemoteStoragePublishedFileVisibility</summary>
    public enum RemoteStoragePublishedFileVisibility : int
    {
        /// <summary>k_ERemoteStoragePublishedFileVisibilityPublic</summary>
        Public = 0,
        /// <summary>k_ERemoteStoragePublishedFileVisibilityFriendsOnly</summary>
        FriendsOnly = 1,
        /// <summary>k_ERemoteStoragePublishedFileVisibilityPrivate</summary>
        Private = 2,
        /// <summary>k_ERemoteStoragePublishedFileVisibilityUnlisted</summary>
        Unlisted = 3
    }
}