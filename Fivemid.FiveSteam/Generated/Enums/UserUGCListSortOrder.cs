using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Used with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a>
    /// to specify the sort order for user published UGC lists. Defaults to creation order descending.<br />
    /// <br />
    /// 
    /// </summary>
    public enum UserUGCListSortOrder : int
    {
        /// <summary>
        ///             Returns items by creation date. Descending - the newest items are first. (Corresponds to
        ///             "sortmethod=newestfirst" on the workshop page)
        ///         </summary>
        CreationOrderDesc = 0,
        /// <summary>
        ///             Returns items by creation date. Ascending - the oldest items are first. (Corresponds to
        ///             "sortmethod=oldestfirst" on the workshop page)
        ///         </summary>
        CreationOrderAsc = 1,
        /// <summary>Returns items by name. (Corresponds to "sortmethod=alpha" on the workshop page)</summary>
        TitleAsc = 2,
        /// <summary>
        ///             Returns the most recently updated items first. (Corresponds to "sortmethod=lastupdated"
        ///             on the workshop page)
        ///         </summary>
        LastUpdatedDesc = 3,
        /// <summary>
        ///             Returns the most recently subscribed items first. (Corresponds to
        ///             "sortmethod=subscriptiondate" on the workshop page)
        ///         </summary>
        SubscriptionDateDesc = 4,
        /// <summary>
        ///             Returns the items with the more recent score updates first. (Corresponds to
        ///             "sortmethod=score" on the workshop page)
        ///         </summary>
        VoteScoreDesc = 5,
        /// <summary>
        ///             Returns the items that have been reported for moderation. (Corresponds to
        ///             "sortmethod=formoderation" on the workshop page)
        ///         </summary>
        ForModeration = 6
    }
}