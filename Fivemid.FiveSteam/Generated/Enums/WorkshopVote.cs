using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EWorkshopVote</summary>
    public enum WorkshopVote : int
    {
        /// <summary>k_EWorkshopVoteUnvoted</summary>
        Unvoted = 0,
        /// <summary>k_EWorkshopVoteFor</summary>
        For = 1,
        /// <summary>k_EWorkshopVoteAgainst</summary>
        Against = 2,
        /// <summary>k_EWorkshopVoteLater</summary>
        Later = 3
    }
}