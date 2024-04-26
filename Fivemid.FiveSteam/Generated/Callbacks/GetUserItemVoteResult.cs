using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when getting the user's vote status on an item.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetUserItemVote" class="bb_apilink">ISteamUGC::GetUserItemVote</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GetUserItemVoteResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetUserItemVoteResult;
        /// <summary>The workshop item to get the vote status.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>Has the user voted the item up?</summary>
        public bool bVotedUp;
        /// <summary>Has the user voted the item down?</summary>
        public bool bVotedDown;
        /// <summary>Has the user skipped voting on this item?</summary>
        public bool bVoteSkipped;
    }
}