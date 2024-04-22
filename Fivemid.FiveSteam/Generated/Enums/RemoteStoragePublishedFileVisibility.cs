using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Possible visibility states that a Workshop item can be in.<br />
    /// <br />
    /// </summary>
    public enum RemoteStoragePublishedFileVisibility : int
    {
        /// <summary>Visible to everyone.</summary>
        Public = 0,
        /// <summary>Visible to friends only.</summary>
        FriendsOnly = 1,
        /// <summary>Only visible to the creator. Setting an item to private is the closest that you can get to deleting a workshop item from the API.</summary>
        Private = 2,
        /// <summary>Visible to everyone, but will not be returned in any global queries. <br />
        ///  Will also not be returned in any user lists unless the caller is the creator or a subscriber.</summary>
        Unlisted = 3
    }
}