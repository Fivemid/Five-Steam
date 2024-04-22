using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Used with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a> to obtain different lists of published UGC for a user.<br />
    /// <br />
    /// </summary>
    public enum UserUGCList : int
    {
        /// <summary>List of files the user has published. (equivalent to <a href="http://steamcommunity.com/my/myworkshopfiles/?browsesort=myfiles" target="_blank" rel="noreferrer">http://steamcommunity.com/my/myworkshopfiles/?browsesort=myfiles</a>)</summary>
        Published = 0,
        /// <summary>List of files the user has voted on. Includes both VotedUp and VotedDown.</summary>
        VotedOn = 1,
        /// <summary>List of files the user has voted up. (Restricted to the current user only).</summary>
        VotedUp = 2,
        /// <summary>List of files the user has voted down. (Restricted to the current user only).</summary>
        VotedDown = 3,
        /// <summary>Deprecated. Do not use! (Restricted to the current user only).</summary>
        WillVoteLater = 4,
        /// <summary>List of files the user has favorited. (equivalent to <a href="http://steamcommunity.com/my/myworkshopfiles/?browsesort=myfavorites" target="_blank" rel="noreferrer">http://steamcommunity.com/my/myworkshopfiles/?browsesort=myfavorites</a>)</summary>
        Favorited = 5,
        /// <summary>List of files the user has subscribed to. (Restricted to the current user only). (equivalent to <a href="http://steamcommunity.com/my/myworkshopfiles/?browsesort=mysubscriptions" target="_blank" rel="noreferrer">http://steamcommunity.com/my/myworkshopfiles/?browsesort=mysubscriptions</a>)</summary>
        Subscribed = 6,
        /// <summary>List of files the user has spent time in game with. (equivalent to <a href="http://steamcommunity.com/my/myworkshopfiles/?browsesort=myplayedfiles" target="_blank" rel="noreferrer">http://steamcommunity.com/my/myworkshopfiles/?browsesort=myplayedfiles</a>)</summary>
        UsedOrPlayed = 7,
        /// <summary>List of files the user is following updates for.</summary>
        Followed = 8
    }
}