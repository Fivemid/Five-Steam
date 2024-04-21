using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when the user has voted on an item.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetUserItemVote" class="bb_apilink">ISteamUGC::SetUserItemVote</a>
    /// </summary>
    public unsafe struct SetUserItemVoteResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SetUserItemVoteResult;
        /// <summary>The workshop item that the user voted on.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>Was the vote up (<b>true</b>) or down (<b>false</b>)?</summary>
        public bool bVoteUp;
    }
}