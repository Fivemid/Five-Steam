using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// </summary>
    public enum WorkshopVote : int
    {
        /// <summary>The user has not voted.</summary>
        Unvoted = 0,
        /// <summary>The user has voted this item up.</summary>
        For = 1,
        /// <summary>The user has voted this item down.</summary>
        Against = 2,
        /// <summary>The user has chosen to vote later.</summary>
        Later = 3
    }
}