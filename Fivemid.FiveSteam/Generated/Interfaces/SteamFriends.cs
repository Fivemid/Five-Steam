using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamFriends
    {
        public static ISteamFriends.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamFriends_v017", CallingConvention = Platform.CC)]
        private static extern ISteamFriends.Instance Accessor();
        /// <summary>
        /// <code>const char * GetPersonaName();</code>
        /// Gets the current user's persona (display) name.<br />
        /// <br />
        /// This is the same name that is displayed the user's community profile page.<br />
        /// <br />
        /// To get the persona name of other users use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendPersonaName" class="bb_apilink">ISteamFriends::GetFriendPersonaName</a>.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The current user's persona name in UTF-8 format. Guaranteed to not be <b>NULL</b>.
        /// </summary>
        /// 
        public static UTF8StringPtr GetPersonaName() => Instance.GetPersonaName();
        /// <summary>
        /// <code>SteamAPICall_t SetPersonaName( const char *pchPersonaName );</code>
        /// 
        /// <br />
        /// Sets the current user's persona name, stores it on the server and publishes the changes to all
        /// friends who are online.<br />
        /// <br />
        /// Changes take place locally immediately, and a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#PersonaStateChange_t" class="bb_apilink">PersonaStateChange_t</a>
        /// callback is posted, presuming success.<br />
        /// <br />
        /// If the name change fails to happen on the server, then an additional
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#PersonaStateChange_t" class="bb_apilink">PersonaStateChange_t</a>
        /// callback will be posted to change the name back, in addition to the final result available in the
        /// call result.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SetPersonaNameResponse_t" class="bb_apilink">SetPersonaNameResponse_t</a>
        /// call result.
        /// </summary>
        /// <param name="pchPersonaName">const char *: 
        ///             The users new persona name. Can not be longer than
        ///             <code class="bb_code bb_code_inline nohighlight">k_cchPersonaNameMax</code> bytes.
        ///         </param>
        public static SteamAPICall SetPersonaName(UTF8StringPtr pchPersonaName) => Instance.SetPersonaName(pchPersonaName);
        /// <summary>
        /// <code>EPersonaState GetPersonaState();</code>
        /// Gets the friend status of the current user.<br />
        /// <br />
        /// To get the state of other users use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendPersonaState" class="bb_apilink">ISteamFriends::GetFriendPersonaState</a>.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EPersonaState" class="bb_apilink">EPersonaState</a><br />
        /// The friend state of the current user. (Online, Offline, In-Game, etc)
        /// </summary>
        /// 
        public static PersonaState GetPersonaState() => Instance.GetPersonaState();
        /// <summary>
        /// <code>int GetFriendCount( int iFriendFlags );</code>
        /// 
        /// <br />
        /// Gets the number of users the client knows about who meet a specified criteria. (Friends, blocked,
        /// users on the same server, etc)<br />
        /// <br />
        /// This can be used to iterate over all of the users by calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendByIndex" class="bb_apilink">ISteamFriends::GetFriendByIndex</a>
        /// to get the Steam IDs of each user.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of users that meet the specified criteria.<br />
        /// <br />
        /// <b>NOTE:</b> Returns <b>-1</b> if the current user is not logged on.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     int nFriends = SteamFriends()-&gt;GetFriendCount( k_EFriendFlagImmediate ); if ( nFriends == -1)
        ///     { printf( "GetFriendCount returned -1, the current user is not logged in.\n" ); // We always
        ///     recommend resetting to 0 just in case you were to do something like allocate // an array with
        ///     this value, or loop over it in a way that doesn't take into the -1 into account. nFriends = 0; }
        ///     for ( int i = 0; i &lt; nFriends; ++i ) { CSteamID friendSteamID =
        ///     SteamFriends()-&gt;GetFriendByIndex( i, k_EFriendFlagImmediate ); const char *friendName =
        ///     SteamFriends()-&gt;GetFriendPersonaName( friendSteamID ); printf( "Friend %d: %lld - %s\n", i,
        ///     friendSteamID.ConvertToUint64(), friendName ); }
        /// </code>
        /// </summary>
        /// <param name="iFriendFlags">int: 
        ///             A combined union (binary "or") of one or more
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EFriendFlags" class="bb_apilink">EFriendFlags</a>.
        ///         </param>
        public static int GetFriendCount(int iFriendFlags) => Instance.GetFriendCount(iFriendFlags);
        /// <summary>
        /// <code>CSteamID GetFriendByIndex( int iFriend, int iFriendFlags );</code>
        /// 
        /// <br />
        /// Gets the Steam ID of the user at the given index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendCount" class="bb_apilink">ISteamFriends::GetFriendCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Invalid indices return
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>.
        /// </summary>
        /// <param name="iFriend">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendCount" class="bb_apilink">ISteamFriends::GetFriendCount</a>.
        ///         </param>
        /// <param name="iFriendFlags">int: 
        ///             A combined union (binary "or") of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EFriendFlags" class="bb_apilink">EFriendFlags</a>. This must be the same value as used in the previous call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendCount" class="bb_apilink">ISteamFriends::GetFriendCount</a>.
        ///         </param>
        public static SteamId GetFriendByIndex(int iFriend, int iFriendFlags) => Instance.GetFriendByIndex(iFriend, iFriendFlags);
        /// <summary>
        /// <code>EFriendRelationship GetFriendRelationship( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets a relationship to a specified user.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EFriendRelationship" class="bb_apilink">EFriendRelationship</a><br />
        /// How the users know each other.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the other user.</param>
        public static FriendRelationship GetFriendRelationship(SteamId steamIDFriend) => Instance.GetFriendRelationship(steamIDFriend);
        /// <summary>
        /// <code>EPersonaState GetFriendPersonaState( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets the current status of the specified user.<br />
        /// <br />
        /// This will only be known to the current user if the other user is in their friends list, on the same
        /// game server, in a chat room or lobby, or in a small Steam group with the local user.<br />
        /// <br />
        /// To get the state of the current user use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetPersonaState" class="bb_apilink">ISteamFriends::GetPersonaState</a>.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EPersonaState" class="bb_apilink">EPersonaState</a><br />
        /// The friend state of the specified user. (Online, Offline, In-Game, etc)
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the other user.</param>
        public static PersonaState GetFriendPersonaState(SteamId steamIDFriend) => Instance.GetFriendPersonaState(steamIDFriend);
        /// <summary>
        /// <code>const char * GetFriendPersonaName( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets the specified user's persona (display) name.<br />
        /// <br />
        /// This will only be known to the current user if the other user is in their friends list, on the same
        /// game server, in a chat room or lobby, or in a small Steam group with the local user.<br />
        /// <br />
        /// <b>NOTE:</b> Upon on first joining a lobby, chat room, or game server the current user
        /// will not known the name of the other users automatically; that information will arrive
        /// asynchronously via
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#PersonaStateChange_t" class="bb_apilink">PersonaStateChange_t</a>
        /// callbacks.<br />
        /// <br />
        /// To get the persona name of the current user use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetPersonaName" class="bb_apilink">ISteamFriends::GetPersonaName</a>.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The current user's persona name in UTF-8 format. Guaranteed to not be <b>NULL</b>.<br />
        /// <br />
        /// Returns an empty string (""), or "[unknown]" if the Steam ID is invalid or not known to the caller.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the other user.</param>
        public static UTF8StringPtr GetFriendPersonaName(SteamId steamIDFriend) => Instance.GetFriendPersonaName(steamIDFriend);
        /// <summary>
        /// <code>
        ///     bool GetFriendGamePlayed( CSteamID steamIDFriend, FriendGameInfo_t *pFriendGameInfo );
        /// </code>
        /// 
        /// <br />
        /// Checks if the specified friend is in a game, and gets info about the game if they are.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the user is a friend and is in a game; otherwise, <b>false</b>.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the other user.</param>
        /// <param name="pFriendGameInfo">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendGameInfo_t" class="bb_apilink">FriendGameInfo_t</a>
        ///             *
        ///         : Fills in the details if the user is in a game.</param>
        public static bool GetFriendGamePlayed(SteamId steamIDFriend, FriendGameInfo* pFriendGameInfo) => Instance.GetFriendGamePlayed(steamIDFriend, pFriendGameInfo);
        /// <summary>
        /// <code>
        ///     const char * GetFriendPersonaNameHistory( CSteamID steamIDFriend, int iPersonaName );
        /// </code>
        /// 
        /// <br />
        /// Gets one of the previous display names for the specified user.<br />
        /// <br />
        /// This only works for display names that the current user has seen on the local computer.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The players old persona name at the given index. Returns an empty string when there are no further
        /// items in the history.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the other user.</param>
        /// <param name="iPersonaName">int: 
        ///             The index of the history to receive. <b>0</b> is their current persona name,
        ///             <b>1</b> is their most recent before they changed it, etc.
        ///         </param>
        public static UTF8StringPtr GetFriendPersonaNameHistory(SteamId steamIDFriend, int iPersonaName) => Instance.GetFriendPersonaNameHistory(steamIDFriend, iPersonaName);
        /// <summary>
        /// <code>int GetFriendSteamLevel( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets the Steam level of the specified user.<br />
        /// <br />
        /// You can use the local users Steam ID (<a href="https://partner.steamgames.com/doc/api/ISteamUser#GetSteamID" class="bb_apilink">ISteamUser::GetSteamID</a>) to get their level.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The Steam level if it's available.<br />
        /// <br />
        /// If the Steam level is not immediately available for the specified user then this returns
        /// <b>0</b> and queues it to be downloaded from the Steam servers. When it gets downloaded a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#PersonaStateChange_t" class="bb_apilink">PersonaStateChange_t</a>
        /// callback will be posted with
        /// <code class="bb_code bb_code_inline nohighlight">m_nChangeFlags</code> including
        /// <code class="bb_code bb_code_inline nohighlight">k_EPersonaChangeSteamLevel</code>.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user.</param>
        public static int GetFriendSteamLevel(SteamId steamIDFriend) => Instance.GetFriendSteamLevel(steamIDFriend);
        /// <summary>
        /// <code>const char * GetPlayerNickname( CSteamID steamIDPlayer );</code>
        /// 
        /// <br />
        /// Gets the nickname that the current user has set for the specified user.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// <b>NULL</b> if the no nickname has been set for that user.
        /// </summary>
        /// <param name="steamIDPlayer">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user.</param>
        public static UTF8StringPtr GetPlayerNickname(SteamId steamIDPlayer) => Instance.GetPlayerNickname(steamIDPlayer);
        /// <summary>
        /// <code>int GetFriendsGroupCount();</code>
        /// Gets the number of friends groups (tags) the user has created.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupIDByIndex" class="bb_apilink">ISteamFriends::GetFriendsGroupIDByIndex</a>
        /// can be used to get the ID of each friend group.<br />
        /// <br />
        /// This is not to be confused with Steam groups. Those can be obtained with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanCount" class="bb_apilink">ISteamFriends::GetClanCount</a>.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of friends groups the current user has.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void ListFriendsGroups() { int nGroups = SteamFriends()-&gt;GetFriendsGroupCount(); for ( int i
        ///     = 0; i &lt; nGroups; ++i ) { FriendsGroupID_t friendsGroupID =
        ///     SteamFriends()-&gt;GetFriendsGroupIDByIndex( i ); const char *szFriendsGroupName =
        ///     SteamFriends()-&gt;GetFriendsGroupName( friendsGroupID ); int nFriendsGroupMembers =
        ///     SteamFriends()-&gt;GetFriendsGroupMembersCount( friendsGroupID ); printf( "Group %d - ID: %d -
        ///     Name: '%s' - Members: %d\n", i, friendsGroupID, szFriendsGroupName, nFriendsGroupMembers );
        ///     std::vector&lt;CSteamID&gt; friends( nFriendsGroupMembers );
        ///     SteamFriends()-&gt;GetFriendsGroupMembersList( friendsGroupID, friends.data(),
        ///     nFriendsGroupMembers ); for ( int j = 0; j &lt; nFriendsGroupMembers; ++j ) { printf( " - Member
        ///     %d - ID: %lld\n", j, friends[j].ConvertToUint64() ); } } }
        /// </code>
        /// </summary>
        /// 
        public static int GetFriendsGroupCount() => Instance.GetFriendsGroupCount();
        /// <summary>
        /// <code>FriendsGroupID_t GetFriendsGroupIDByIndex( int iFG );</code>
        /// 
        /// <br />
        /// Gets the friends group ID for the given index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupCount" class="bb_apilink">ISteamFriends::GetFriendsGroupCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsGroupID_t" class="bb_apilink">FriendsGroupID_t</a><br />
        /// Invalid indices return
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_FriendsGroupID_Invalid" class="bb_apilink">ISteamFriends::k_FriendsGroupID_Invalid</a>.
        /// </summary>
        /// <param name="iFG">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupCount" class="bb_apilink">ISteamFriends::GetFriendsGroupCount</a>.
        ///         </param>
        public static FriendsGroupID GetFriendsGroupIDByIndex(int iFG) => Instance.GetFriendsGroupIDByIndex(iFG);
        /// <summary>
        /// <code>const char * GetFriendsGroupName( FriendsGroupID_t friendsGroupID );</code>
        /// 
        /// <br />
        /// Gets the name for the given friends group.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The friend groups name in UTF-8 format. Returns <b>NULL</b> if the group ID is invalid.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupCount" class="bb_apilink">ISteamFriends::GetFriendsGroupCount</a>
        /// </summary>
        /// <param name="friendsGroupID">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsGroupID_t" class="bb_apilink">FriendsGroupID_t</a>
        ///         : The friends group ID to get the name of.</param>
        public static UTF8StringPtr GetFriendsGroupName(FriendsGroupID friendsGroupID) => Instance.GetFriendsGroupName(friendsGroupID);
        /// <summary>
        /// <code>int GetFriendsGroupMembersCount( FriendsGroupID_t friendsGroupID );</code>
        /// 
        /// <br />
        /// Gets the number of friends in a given friends group.<br />
        /// <br />
        /// This should be called before getting the list of friends with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupMembersList" class="bb_apilink">ISteamFriends::GetFriendsGroupMembersList</a>.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of friends in the specified friends group.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupCount" class="bb_apilink">ISteamFriends::GetFriendsGroupCount</a>
        /// </summary>
        /// <param name="friendsGroupID">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsGroupID_t" class="bb_apilink">FriendsGroupID_t</a>
        ///         : The friends group ID to get the number of friends in.</param>
        public static int GetFriendsGroupMembersCount(FriendsGroupID friendsGroupID) => Instance.GetFriendsGroupMembersCount(friendsGroupID);
        /// <summary>
        /// <code>
        ///     void GetFriendsGroupMembersList( FriendsGroupID_t friendsGroupID, CSteamID *pOutSteamIDMembers,
        ///     int nMembersCount );
        /// </code>
        /// 
        /// <br />
        /// Gets the number of friends in the given friends group.<br />
        /// <br />
        /// If fewer friends exist than requested those positions' Steam IDs will be invalid.<br />
        /// <br />
        /// You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupMembersCount" class="bb_apilink">ISteamFriends::GetFriendsGroupMembersCount</a>
        /// before calling this to set up the
        /// <code class="bb_code bb_code_inline nohighlight">pOutSteamIDMembers</code> array with an appropriate
        /// size!<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupCount" class="bb_apilink">ISteamFriends::GetFriendsGroupCount</a>
        /// </summary>
        /// <param name="friendsGroupID">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsGroupID_t" class="bb_apilink">FriendsGroupID_t</a>
        ///         : The friends group ID to get the members list of.</param>
        /// <param name="pOutSteamIDMembers">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///             *
        ///         : Returns the Steam IDs of the friends by setting them in this array.</param>
        /// <param name="nMembersCount">int: 
        ///             This should match the number of elements allocated
        ///             <code class="bb_code bb_code_inline nohighlight">pOutSteamIDMembers</code> and the value
        ///             returned by
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendsGroupMembersCount" class="bb_apilink">ISteamFriends::GetFriendsGroupMembersCount</a>.
        ///         </param>
        public static void GetFriendsGroupMembersList(FriendsGroupID friendsGroupID, SteamId* pOutSteamIDMembers, int nMembersCount) => Instance.GetFriendsGroupMembersList(friendsGroupID, pOutSteamIDMembers, nMembersCount);
        /// <summary>
        /// <code>bool HasFriend( CSteamID steamIDFriend, int iFriendFlags );</code>
        /// 
        /// <br />
        /// Checks if the user meets the specified criteria. (Friends, blocked, users on the same server,
        /// etc)<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the specified user meets any of the criteria specified in
        /// <code class="bb_code bb_code_inline nohighlight">iFriendFlags</code>; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam user to check the friend status of.</param>
        /// <param name="iFriendFlags">int: 
        ///             A combined union (binary "or") of one or more
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EFriendFlags" class="bb_apilink">EFriendFlags</a>.
        ///         </param>
        public static bool HasFriend(SteamId steamIDFriend, int iFriendFlags) => Instance.HasFriend(steamIDFriend, iFriendFlags);
        /// <summary>
        /// <code>int GetClanCount();</code>
        /// Gets the number of Steam groups that the current user is a member of.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanByIndex" class="bb_apilink">ISteamFriends::GetClanByIndex</a>
        /// can be used to get the Steam ID of each Steam group.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of Steam groups that the user is a member of.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void ListSteamGroups() { int nGroups = SteamFriends()-&gt;GetClanCount(); printf( "Listing %d
        ///     Steam Groups\n", nGroups ); for ( int i = 0; i &lt; nGroups; ++i ) { CSteamID groupSteamID =
        ///     SteamFriends()-&gt;GetClanByIndex( i ); const char *szGroupName =
        ///     SteamFriends()-&gt;GetClanName( groupSteamID ); const char *szGroupTag =
        ///     SteamFriends()-&gt;GetClanTag( groupSteamID ); int nOnline, nInGame, nChatting; bool success =
        ///     SteamFriends()-&gt;GetClanActivityCounts( groupSteamID, &amp;nOnline, &amp;nInGame,
        ///     &amp;nChatting ); printf( "Group %d - ID: %lld - Name: '%s' - Tag: '%s'\n", i,
        ///     groupSteamID.ConvertToUint64(), szGroupName, szGroupTag ); printf( " - Online: %d, In Game: %d,
        ///     Chatting: %d\n", nOnline, nInGame, nChatting ); } }
        /// </code>
        /// </summary>
        /// 
        public static int GetClanCount() => Instance.GetClanCount();
        /// <summary>
        /// <code>CSteamID GetClanByIndex( int iClan );</code>
        /// 
        /// <br />
        /// Gets the Steam group's Steam ID at the given index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanCount" class="bb_apilink">ISteamFriends::GetClanCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Invalid indices return
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>.
        /// </summary>
        /// <param name="iClan">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanCount" class="bb_apilink">ISteamFriends::GetClanCount</a>.
        ///         </param>
        public static SteamId GetClanByIndex(int iClan) => Instance.GetClanByIndex(iClan);
        /// <summary>
        /// <code>const char * GetClanName( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Gets the display name for the specified Steam group; if the local client knows about it.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The Steam group's name in UTF-8 format. Returns an empty string ("") if the provided Steam ID is
        /// invalid or the user does not know about the group.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#DownloadClanActivityCounts" class="bb_apilink">ISteamFriends::DownloadClanActivityCounts</a>
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam group to get the name of.</param>
        public static UTF8StringPtr GetClanName(SteamId steamIDClan) => Instance.GetClanName(steamIDClan);
        /// <summary>
        /// <code>const char * GetClanTag( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Gets the unique tag (abbreviation) for the specified Steam group; If the local client knows about
        /// it.<br />
        /// <br />
        /// The Steam group abbreviation is a unique way for people to identify the group and is limited to 12
        /// characters. In some games this will appear next to the name of group members.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The Steam groups tag in UTF-8 format. Returns an empty string ("") if the provided Steam ID is
        /// invalid or the user does not know about the group.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#DownloadClanActivityCounts" class="bb_apilink">ISteamFriends::DownloadClanActivityCounts</a>
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam group to get the tag of.</param>
        public static UTF8StringPtr GetClanTag(SteamId steamIDClan) => Instance.GetClanTag(steamIDClan);
        /// <summary>
        /// <code>
        ///     bool GetClanActivityCounts( CSteamID steamIDClan, int *pnOnline, int *pnInGame, int *pnChatting
        ///     );
        /// </code>
        /// 
        /// <br />
        /// Gets the most recent information we have about what the users in a Steam Group are doing.<br />
        /// <br />
        /// This can only retrieve data that the local client knows about. To refresh the data or get data from
        /// a group other than one that the current user is a member of you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#DownloadClanActivityCounts" class="bb_apilink">ISteamFriends::DownloadClanActivityCounts</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the data was successfully returned.<br />
        /// <b>false</b> if the provided Steam ID is invalid or the local client does not have info
        /// about the Steam group and sets all the other parameters to <b>0</b>.
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam group to get the activity of.</param>
        /// <param name="pnOnline">int *: Returns the number of members that are online.</param>
        /// <param name="pnInGame">int *: 
        ///             Returns the number members that are in game (excluding those with their status set to
        ///             offline).
        ///         </param>
        /// <param name="pnChatting">int *: Returns the number of members in the group chat room.</param>
        public static bool GetClanActivityCounts(SteamId steamIDClan, int* pnOnline, int* pnInGame, int* pnChatting) => Instance.GetClanActivityCounts(steamIDClan, pnOnline, pnInGame, pnChatting);
        /// <summary>
        /// <code>
        ///     SteamAPICall_t DownloadClanActivityCounts( CSteamID *psteamIDClans, int cClansToRequest );
        /// </code>
        /// 
        /// <br />
        /// Refresh the Steam Group activity data or get the data from groups other than one that the current
        /// user is a member.<br />
        /// <br />
        /// After receiving the callback you can then use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanActivityCounts" class="bb_apilink">ISteamFriends::GetClanActivityCounts</a>
        /// to get the up to date user counts.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#DownloadClanActivityCountsResult_t" class="bb_apilink">DownloadClanActivityCountsResult_t</a>
        /// call result.
        /// </summary>
        /// <param name="psteamIDClans">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///             *
        ///         : A list of steam groups to get the updated data for.</param>
        /// <param name="cClansToRequest">int: 
        ///             This MUST be the number of groups in
        ///             <code class="bb_code bb_code_inline nohighlight">psteamIDClans</code>.
        ///         </param>
        public static SteamAPICall DownloadClanActivityCounts(SteamId* psteamIDClans, int cClansToRequest) => Instance.DownloadClanActivityCounts(psteamIDClans, cClansToRequest);
        /// <summary>
        /// <code>int GetFriendCountFromSource( CSteamID steamIDSource );</code>
        /// 
        /// <br />
        /// Get the number of users in a source (Steam group, chat room, lobby, or game server).<br />
        /// <br />
        /// <b>NOTE:</b> Large Steam groups cannot be iterated by the local user.<br />
        /// <br />
        /// <b>NOTE:</b> If you're getting the number of lobby members then you should use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetNumLobbyMembers" class="bb_apilink">ISteamMatchmaking::GetNumLobbyMembers</a>
        /// instead.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendFromSourceByIndex" class="bb_apilink">ISteamFriends::GetFriendFromSourceByIndex</a>
        /// can be used to get the Steam ID of each person in the source.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// <b>0</b> if the Steam ID provided is invalid or if the local user doesn't have the data
        /// available.
        /// </summary>
        /// <param name="steamIDSource">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam group, chat room, lobby or game server to get the user count of.</param>
        public static int GetFriendCountFromSource(SteamId steamIDSource) => Instance.GetFriendCountFromSource(steamIDSource);
        /// <summary>
        /// <code>
        ///     CSteamID GetFriendFromSourceByIndex( CSteamID steamIDSource, int iFriend );
        /// </code>
        /// 
        /// <br />
        /// Gets the Steam ID at the given index from a source (Steam group, chat room, lobby, or game
        /// server).<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendCountFromSource" class="bb_apilink">ISteamFriends::GetFriendCountFromSource</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Invalid indices return
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>.
        /// </summary>
        /// <param name="steamIDSource">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : 
        ///             This MUST be the same source used in the previous call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendCountFromSource" class="bb_apilink">ISteamFriends::GetFriendCountFromSource</a>!
        ///         </param>
        /// <param name="iFriend">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendCountFromSource" class="bb_apilink">ISteamFriends::GetFriendCountFromSource</a>.
        ///         </param>
        public static SteamId GetFriendFromSourceByIndex(SteamId steamIDSource, int iFriend) => Instance.GetFriendFromSourceByIndex(steamIDSource, iFriend);
        /// <summary>
        /// <code>bool IsUserInSource( CSteamID steamIDUser, CSteamID steamIDSource );</code>
        /// 
        /// <br />
        /// Checks if a specified user is in a source (Steam group, chat room, lobby, or game server).<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the local user can see that
        /// <code class="bb_code bb_code_inline nohighlight">steamIDUser</code> is a member or in
        /// <code class="bb_code bb_code_inline nohighlight">steamIDSource</code>; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// <param name="steamIDUser">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The user to check if they are in the source.</param>
        /// <param name="steamIDSource">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The source to check for the user.</param>
        public static bool IsUserInSource(SteamId steamIDUser, SteamId steamIDSource) => Instance.IsUserInSource(steamIDUser, steamIDSource);
        /// <summary>
        /// <code>void SetInGameVoiceSpeaking( CSteamID steamIDUser, bool bSpeaking );</code>
        /// 
        /// <br />
        /// Let Steam know that the user is currently using voice chat in game.<br />
        /// <br />
        /// This will suppress the microphone for all voice communication in the Steam UI.
        /// </summary>
        /// <param name="steamIDUser">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : Unused.</param>
        /// <param name="bSpeaking">bool: 
        ///             Did the user start speaking in game (<b>true</b>) or stopped speaking in game
        ///             (<b>false</b>)?
        ///         </param>
        public static void SetInGameVoiceSpeaking(SteamId steamIDUser, bool bSpeaking) => Instance.SetInGameVoiceSpeaking(steamIDUser, bSpeaking);
        /// <summary>
        /// <code>void ActivateGameOverlay( const char *pchDialog );</code>
        /// 
        /// <br />
        /// Activates the
        /// <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a>
        /// to a specific dialog.<br />
        /// <br />
        /// This is equivalent to calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ActivateGameOverlayToUser" class="bb_apilink">ISteamFriends::ActivateGameOverlayToUser</a>
        /// with <code class="bb_code bb_code_inline nohighlight">steamID</code> set to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetSteamID" class="bb_apilink">ISteamUser::GetSteamID</a>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>SteamFriends()-&gt;ActivateGameOverlay( "friends" );</code>
        /// </summary>
        /// <param name="pchDialog">const char *: 
        ///             The dialog to open. Valid options are: "friends", "community", "players", "settings",
        ///             "officialgamegroup", "stats", "achievements".
        ///         </param>
        public static void ActivateGameOverlay(UTF8StringPtr pchDialog) => Instance.ActivateGameOverlay(pchDialog);
        /// <summary>
        /// <code>
        ///     void ActivateGameOverlayToUser( const char *pchDialog, CSteamID steamID );
        /// </code>
        /// 
        /// <br />
        /// Activates
        /// <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a>
        /// to a specific dialog.<br />
        /// <br />
        /// Valid <code class="bb_code bb_code_inline nohighlight">pchDialog</code> options are:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         "steamid" - Opens the overlay web browser to the specified user or groups profile.<br />
        ///     </li>
        ///     <li>"chat" - Opens a chat window to the specified user, or joins the group chat.<br /></li>
        ///     <li>
        ///         "jointrade" - Opens a window to a Steam Trading session that was started with the
        ///         <a href="https://partner.steamgames.com/doc/webapi/ISteamEconomy#StartTrade" class="bb_apilink">ISteamEconomy/StartTrade</a>
        ///         Web API.<br />
        ///     </li>
        ///     <li>"stats" - Opens the overlay web browser to the specified user's stats.<br /></li>
        ///     <li>
        ///         "achievements" - Opens the overlay web browser to the specified user's achievements.<br />
        ///     </li>
        ///     <li>
        ///         "friendadd" - Opens the overlay in minimal mode prompting the user to add the target user as
        ///         a friend.<br />
        ///     </li>
        ///     <li>
        ///         "friendremove" - Opens the overlay in minimal mode prompting the user to remove the target
        ///         friend.<br />
        ///     </li>
        ///     <li>
        ///         "friendrequestaccept" - Opens the overlay in minimal mode prompting the user to accept an
        ///         incoming friend invite.<br />
        ///     </li>
        ///     <li>
        ///         "friendrequestignore" - Opens the overlay in minimal mode prompting the user to ignore an
        ///         incoming friend invite.
        ///     </li>
        /// </ul>
        /// </summary>
        /// <param name="pchDialog">const char *: The dialog to open.</param>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the context to open this dialog to.</param>
        public static void ActivateGameOverlayToUser(UTF8StringPtr pchDialog, SteamId steamID) => Instance.ActivateGameOverlayToUser(pchDialog, steamID);
        /// <summary>
        /// <code>void ActivateGameOverlayToWebPage( const char *pchURL );</code>
        /// 
        /// <br />
        /// Activates
        /// <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a>
        /// web browser directly to the specified URL.
        /// </summary>
        /// <param name="pchURL">const char *: 
        ///             The webpage to open. (A fully qualified address with the protocol is required, e.g.
        ///             <a href="http://%22http://www.steampowered.com%22)" target="_blank" rel="noreferrer">"http://www.steampowered.com")</a>
        ///         </param>
        /// <param name="eMode">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EActivateGameOverlayToWebPageMode" class="bb_apilink">EActivateGameOverlayToWebPageMode</a>
        ///         : 
        ///             Mode for the web page. Defaults to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_EActivateGameOverlayToWebPageMode_Default" class="bb_apilink">k_EActivateGameOverlayToWebPageMode_Default</a>
        ///         </param>
        public static void ActivateGameOverlayToWebPage(UTF8StringPtr pchURL, ActivateGameOverlayToWebPageMode eMode) => Instance.ActivateGameOverlayToWebPage(pchURL, eMode);
        /// <summary>
        /// <code>
        ///     void ActivateGameOverlayToStore( AppId_t nAppID, EOverlayToStoreFlag eFlag );
        /// </code>
        /// 
        /// <br />
        /// Activates the
        /// <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a>
        /// to the Steam store page for the provided app.<br />
        /// <br />
        /// Using
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAppIdInvalid" class="bb_apilink">k_uAppIdInvalid</a>
        /// brings the user to the front page of the Steam store.
        /// </summary>
        /// <param name="nAppID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>
        ///         : The app ID to show the store page of.</param>
        /// <param name="eFlag">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EOverlayToStoreFlag" class="bb_apilink">EOverlayToStoreFlag</a>
        ///         : Flags to modify the behavior when the page opens.</param>
        public static void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) => Instance.ActivateGameOverlayToStore(nAppID, eFlag);
        /// <summary>
        /// <code>void SetPlayedWith( CSteamID steamIDUserPlayedWith );</code>
        /// 
        /// <br />
        /// Mark a target user as 'played with'.<br />
        /// <br />
        /// <b>NOTE:</b> The current user must be in game with the other player for the association to
        /// work.<br />
        /// <br />
        /// You can view the players you have recently played with
        /// <a href="http://steamcommunity.com/my/friends/coplay/" target="_blank" rel="noreferrer">here</a> on
        /// the Steam community and in the
        /// <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a>.
        /// </summary>
        /// <param name="steamIDUserPlayedWith">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The other user that we have played with.</param>
        public static void SetPlayedWith(SteamId steamIDUserPlayedWith) => Instance.SetPlayedWith(steamIDUserPlayedWith);
        /// <summary>
        /// <code>void ActivateGameOverlayInviteDialog( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// Activates the
        /// <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a>
        /// to open the invite dialog. Invitations sent from this dialog will be for the provided lobby.
        /// </summary>
        /// <param name="steamIDLobby">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the lobby that selected users will be invited to.</param>
        public static void ActivateGameOverlayInviteDialog(SteamId steamIDLobby) => Instance.ActivateGameOverlayInviteDialog(steamIDLobby);
        /// <summary>
        /// <code>int GetSmallFriendAvatar( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets a handle to the small (32*32px) avatar for the specified user.<br />
        /// <br />
        /// You can pass in
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetSteamID" class="bb_apilink">ISteamUser::GetSteamID</a>
        /// to get the current user's avatar.<br />
        /// <br />
        /// <b>NOTE:</b> This only works for users that the local user knows about. They will
        /// automatically know about their friends, people on leaderboards they've requested, or people in the
        /// same source as them (Steam group, chat room, lobby, or game server). If they don't know about them
        /// then you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestUserInformation" class="bb_apilink">ISteamFriends::RequestUserInformation</a>
        /// to cache the avatar locally.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// A Steam image handle which is used with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageSize" class="bb_apilink">ISteamUtils::GetImageSize</a>
        /// and
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageRGBA" class="bb_apilink">ISteamUtils::GetImageRGBA</a>.<br />
        /// Returns <b>0</b> if no avatar is set for the user.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetLargeFriendAvatar" class="bb_apilink">ISteamFriends::GetLargeFriendAvatar</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetMediumFriendAvatar" class="bb_apilink">ISteamFriends::GetMediumFriendAvatar</a>
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : </param>
        public static int GetSmallFriendAvatar(SteamId steamIDFriend) => Instance.GetSmallFriendAvatar(steamIDFriend);
        /// <summary>
        /// <code>int GetMediumFriendAvatar( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets a handle to the medium (64*64px) avatar for the specified user.<br />
        /// <br />
        /// You can pass in
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetSteamID" class="bb_apilink">ISteamUser::GetSteamID</a>
        /// to get the current user's avatar.<br />
        /// <br />
        /// <b>NOTE:</b> This only works for users that the local user knows about. They will
        /// automatically know about their friends, people on leaderboards they've requested, or people in the
        /// same source as them (Steam group, chat room, lobby, or game server). If they don't know about them
        /// then you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestUserInformation" class="bb_apilink">ISteamFriends::RequestUserInformation</a>
        /// to cache the avatar locally.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// A Steam image handle which is used with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageSize" class="bb_apilink">ISteamUtils::GetImageSize</a>
        /// and
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageRGBA" class="bb_apilink">ISteamUtils::GetImageRGBA</a>.<br />
        /// Returns <b>0</b> if no avatar is set for the user.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetLargeFriendAvatar" class="bb_apilink">ISteamFriends::GetLargeFriendAvatar</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetSmallFriendAvatar" class="bb_apilink">ISteamFriends::GetSmallFriendAvatar</a>
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : </param>
        public static int GetMediumFriendAvatar(SteamId steamIDFriend) => Instance.GetMediumFriendAvatar(steamIDFriend);
        /// <summary>
        /// <code>int GetLargeFriendAvatar( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets a handle to the large (128*128px) avatar for the specified user.<br />
        /// <br />
        /// You can pass in
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetSteamID" class="bb_apilink">ISteamUser::GetSteamID</a>
        /// to get the current user's avatar.<br />
        /// <br />
        /// <b>NOTE:</b> This only works for users that the local user knows about. They will
        /// automatically know about their friends, people on leaderboards they've requested, or people in the
        /// same source as them (Steam group, chat room, lobby, or game server). If they don't know about them
        /// then you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestUserInformation" class="bb_apilink">ISteamFriends::RequestUserInformation</a>
        /// to cache the avatar locally.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#AvatarImageLoaded_t" class="bb_apilink">AvatarImageLoaded_t</a>
        /// callback.<br />
        /// A Steam image handle which is used with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageSize" class="bb_apilink">ISteamUtils::GetImageSize</a>
        /// and
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageRGBA" class="bb_apilink">ISteamUtils::GetImageRGBA</a>.<br />
        /// Returns <b>0</b> if no avatar is set for the user.<br />
        /// Returns <b>-1</b> if the avatar image data has not been loaded yet and requests that it
        /// gets download. In this case wait for a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#AvatarImageLoaded_t" class="bb_apilink">AvatarImageLoaded_t</a>
        /// callback and then call this again.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetMediumFriendAvatar" class="bb_apilink">ISteamFriends::GetMediumFriendAvatar</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetSmallFriendAvatar" class="bb_apilink">ISteamFriends::GetSmallFriendAvatar</a>
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : </param>
        public static int GetLargeFriendAvatar(SteamId steamIDFriend) => Instance.GetLargeFriendAvatar(steamIDFriend);
        /// <summary>
        /// <code>
        ///     bool RequestUserInformation( CSteamID steamIDUser, bool bRequireNameOnly );
        /// </code>
        /// 
        /// <br />
        /// Requests the persona name and optionally the avatar of a specified user.<br />
        /// <br />
        /// <b>NOTE:</b> It's a lot slower to download avatars and churns the local cache, so if you
        /// don't need avatars, don't request them.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#PersonaStateChange_t" class="bb_apilink">PersonaStateChange_t</a>
        /// callback.<br />
        /// <b>true</b> means that the data has being requested, and a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#PersonaStateChange_t" class="bb_apilink">PersonaStateChange_t</a>
        /// callback will be posted when it's retrieved.<br />
        /// <b>false</b> means that we already have all the details about that user, and functions
        /// that require this information can be used immediately.
        /// </summary>
        /// <param name="steamIDUser">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The user to request the information of.</param>
        /// <param name="bRequireNameOnly">bool: 
        ///             Retrieve the Persona name only (<b>true</b>)? Or both the name and the avatar
        ///             (<b>false</b>)?
        ///         </param>
        public static bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) => Instance.RequestUserInformation(steamIDUser, bRequireNameOnly);
        /// <summary>
        /// <code>SteamAPICall_t RequestClanOfficerList( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Requests information about a Steam group officers (administrators and moderators).<br />
        /// <br />
        /// <b>NOTE:</b> You can only ask about Steam groups that a user is a member of.<br />
        /// <b>NOTE:</b> This won't download avatars for the officers automatically. If no avatar
        /// image is available for an officer, then call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestUserInformation" class="bb_apilink">ISteamFriends::RequestUserInformation</a>
        /// to download the avatar.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ClanOfficerListResponse_t" class="bb_apilink">ClanOfficerListResponse_t</a>
        /// call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOwner" class="bb_apilink">ISteamFriends::GetClanOwner</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOfficerCount" class="bb_apilink">ISteamFriends::GetClanOfficerCount</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOfficerByIndex" class="bb_apilink">ISteamFriends::GetClanOfficerByIndex</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     class CClanOfficerListExample { public: void RequestOfficerList(); private: void
        ///     OnClanOfficerListResponse( ClanOfficerListResponse_t *pCallback, bool bIOFailure );
        ///     CCallResult&lt; CClanOfficerListExample, ClanOfficerListResponse_t &gt;
        ///     m_SteamCallResultClanOfficerListResponse; }; void CClanOfficerListExample::RequestOfficerList()
        ///     { printf( "Requesting the Clan Officer List\n" ); const CSteamID SteamworksDevGroup =
        ///     103582791433474333ull; SteamAPICall_t handle = SteamFriends()-&gt;RequestClanOfficerList(
        ///     SteamworksDevGroup ); m_SteamCallResultClanOfficerListResponse.Set( handle, this,
        ///     &amp;CClanOfficerListExample::OnClanOfficerListResponse ); } void
        ///     CClanOfficerListExample::OnClanOfficerListResponse( ClanOfficerListResponse_t *pCallback, bool
        ///     bIOFailure ) { if ( !pCallback-&gt;m_bSuccess || bIOFailure ) { printf( "ClanOfficerListResponse
        ///     failed for %lld!", pCallback-&gt;m_steamIDClan.ConvertToUint64() ); return; } printf( "Got a
        ///     ClanOfficerListResponse for: %s (%lld)\n", SteamFriends()-&gt;GetClanName(
        ///     pCallback-&gt;m_steamIDClan ), pCallback-&gt;m_steamIDClan.ConvertToUint64() ); CSteamID
        ///     ownerSteamID = SteamFriends()-&gt;GetClanOwner(pCallback-&gt;m_steamIDClan); printf( " The owner
        ///     of the clan is: %s (%lld) and there are %d officers.\n",
        ///     SteamFriends()-&gt;GetFriendPersonaName( ownerSteamID ), ownerSteamID.ConvertToUint64(),
        ///     pCallback-&gt;m_cOfficers ); int nOfficers = SteamFriends()-&gt;GetClanOfficerCount(
        ///     pCallback-&gt;m_steamIDClan ); printf( " GetClanOfficerCount reports: %d", nOfficers ); for (
        ///     int i = 0; i &lt; nOfficers; ++i ) { CSteamID officerSteamID =
        ///     SteamFriends()-&gt;GetClanOfficerByIndex( pCallback-&gt;m_steamIDClan, i ); printf( " Officer
        ///     %d: %s (%lld)\n", i, SteamFriends()-&gt;GetFriendPersonaName(officerSteamID),
        ///     officerSteamID.ConvertToUint64() ); } }
        /// </code>
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam group to get the officers list for.</param>
        public static SteamAPICall RequestClanOfficerList(SteamId steamIDClan) => Instance.RequestClanOfficerList(steamIDClan);
        /// <summary>
        /// <code>CSteamID GetClanOwner( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Gets the owner of a Steam Group.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestClanOfficerList" class="bb_apilink">ISteamFriends::RequestClanOfficerList</a>
        /// before this to get the required data!<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>
        /// if <code class="bb_code bb_code_inline nohighlight">steamIDClan</code> is invalid or if
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestClanOfficerList" class="bb_apilink">ISteamFriends::RequestClanOfficerList</a>
        /// has not been called for it.
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group to get the owner for.</param>
        public static SteamId GetClanOwner(SteamId steamIDClan) => Instance.GetClanOwner(steamIDClan);
        /// <summary>
        /// <code>int GetClanOfficerCount( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Gets the number of officers (administrators and moderators) in a specified Steam group.<br />
        /// <br />
        /// This also includes the owner of the Steam group.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOfficerByIndex" class="bb_apilink">ISteamFriends::GetClanOfficerByIndex</a>
        /// can be used to get the Steam ID of each officer.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestClanOfficerList" class="bb_apilink">ISteamFriends::RequestClanOfficerList</a>
        /// before this to get the required data!<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of officers in the Steam group. Returns <b>0</b> if
        /// <code class="bb_code bb_code_inline nohighlight">steamIDClan</code> is invalid or if
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestClanOfficerList" class="bb_apilink">ISteamFriends::RequestClanOfficerList</a>
        /// has not been called for it.
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam group to get the officer count of.</param>
        public static int GetClanOfficerCount(SteamId steamIDClan) => Instance.GetClanOfficerCount(steamIDClan);
        /// <summary>
        /// <code>CSteamID GetClanOfficerByIndex( CSteamID steamIDClan, int iOfficer );</code>
        /// 
        /// <br />
        /// Gets the Steam ID of the officer at the given index in a Steam group.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOfficerCount" class="bb_apilink">ISteamFriends::GetClanOfficerCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>
        /// if <code class="bb_code bb_code_inline nohighlight">steamIDClan</code> or
        /// <code class="bb_code bb_code_inline nohighlight">iOfficer</code> are invalid.
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : 
        ///             This must be the same steam group used in the previous call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOfficerCount" class="bb_apilink">ISteamFriends::GetClanOfficerCount</a>!
        ///         </param>
        /// <param name="iOfficer">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanOfficerCount" class="bb_apilink">ISteamFriends::GetClanOfficerCount</a>.
        ///         </param>
        public static SteamId GetClanOfficerByIndex(SteamId steamIDClan, int iOfficer) => Instance.GetClanOfficerByIndex(steamIDClan, iOfficer);
        /// <summary>
        /// <code>uint32 GetUserRestrictions();</code>
        /// Checks if current user is chat restricted.<br />
        /// <br />
        /// If they are restricted, then they can't send or receive any text/voice chat messages, can't see
        /// custom avatars.<br />
        /// A chat restricted user can't add friends or join any groups.<br />
        /// Restricted users can still be online and send/receive game invites.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// See:
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EUserRestriction" class="bb_apilink">EUserRestriction</a>
        /// </summary>
        /// 
        public static uint GetUserRestrictions() => Instance.GetUserRestrictions();
        /// <summary>
        /// <code>bool SetRichPresence( const char *pchKey, const char *pchValue );</code>
        /// 
        /// <br />
        /// Sets a Rich Presence key/value for the current user that is automatically shared to all friends
        /// playing the same game.<br />
        /// <br />
        /// Each user can have up to 20 keys set as defined by
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cchMaxRichPresenceKeys" class="bb_apilink">k_cchMaxRichPresenceKeys</a>.<br />
        /// <br />
        /// There are two special keys used for viewing/joining games:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         "status" - A UTF-8 string that will show up in the 'view game info' dialog in the Steam
        ///         friends list.<br />
        ///     </li>
        ///     <li>
        ///         "connect" - A UTF-8 string that contains the command-line for how a friend can connect to a
        ///         game. This enables the 'join game' button in the 'view game info' dialog, in the steam
        ///         friends list right click menu, and on the players Steam community profile. Be sure your app
        ///         implements
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetLaunchCommandLine" class="bb_apilink">ISteamApps::GetLaunchCommandLine</a>
        ///         so you can disable the popup warning when launched via a command line.
        ///     </li>
        /// </ul>
        /// <br />
        /// There are three additional special keys used by the
        /// <a href="https://steamcommunity.com/updates/chatupdate" target="_blank" rel="noreferrer">new Steam Chat</a>:<br />
        /// <ul class="bb_ul %1$s">
        ///     <li>
        ///         "steam_display" - Names a rich presence localization token that will be displayed in the
        ///         viewing user's selected language in the Steam client UI. See
        ///         <a href="#richpresencelocalization" class="bb_doclink">Rich Presence Localization</a> for
        ///         more info, including a link to a page for testing this rich presence data. If steam_display
        ///         is not set to a valid localization tag, then rich presence will not be displayed in the
        ///         Steam client.<br />
        ///     </li>
        ///     <li>
        ///         "steam_player_group" - When set, indicates to the Steam client that the player is a member
        ///         of a particular group. Players in the same group may be organized together in various places
        ///         in the Steam UI. This string could identify a party, a server, or whatever grouping is
        ///         relevant for your game. The string itself is not displayed to users.<br />
        ///     </li>
        ///     <li>
        ///         "steam_player_group_size" - When set, indicates the total number of players in the
        ///         steam_player_group. The Steam client may use this number to display additional information
        ///         about a group when all of the members are not part of a user's friends list. (For example,
        ///         "Bob, Pete, and 4 more".)
        ///     </li>
        /// </ul>
        /// <br />
        /// You can clear all of the keys for the current user with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ClearRichPresence" class="bb_apilink">ISteamFriends::ClearRichPresence</a>.<br />
        /// <br />
        /// To get rich presence keys for friends see:
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendRichPresence" class="bb_apilink">ISteamFriends::GetFriendRichPresence</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the rich presence was set successfully.<br />
        /// <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">pchKey</code> was longer than
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cchMaxRichPresenceKeyLength" class="bb_apilink">k_cchMaxRichPresenceKeyLength</a>
        ///         or had a length of <strong>0</strong>.<br />
        ///     </li>
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">pchValue</code> was longer than
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cchMaxRichPresenceValueLength" class="bb_apilink">k_cchMaxRichPresenceValueLength</a>.<br />
        ///     </li>
        ///     <li>
        ///         The user has reached the maximum amount of rich presence keys as defined by
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cchMaxRichPresenceKeys" class="bb_apilink">k_cchMaxRichPresenceKeys</a>.
        ///     </li>
        /// </ul>
        /// </summary>
        /// <param name="pchKey">const char *: 
        ///             The rich presence 'key' to set. This can not be longer than specified in
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cchMaxRichPresenceKeyLength" class="bb_apilink">k_cchMaxRichPresenceKeyLength</a>.
        ///         </param>
        /// <param name="pchValue">const char *: 
        ///             The rich presence 'value' to associate with
        ///             <code class="bb_code bb_code_inline nohighlight">pchKey</code>. This can not be longer
        ///             than specified in
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cchMaxRichPresenceValueLength" class="bb_apilink">k_cchMaxRichPresenceValueLength</a>.<br />
        ///             If this is set to an empty string ("") or <b>NULL</b> then the key is removed
        ///             if it's set.
        ///         </param>
        public static bool SetRichPresence(UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetRichPresence(pchKey, pchValue);
        /// <summary>
        /// <code>void ClearRichPresence();</code>
        /// Clears all of the current user's Rich Presence key/values.
        /// </summary>
        /// 
        public static void ClearRichPresence() => Instance.ClearRichPresence();
        /// <summary>
        /// <code>
        ///     const char * GetFriendRichPresence( CSteamID steamIDFriend, const char *pchKey );
        /// </code>
        /// 
        /// <br />
        /// Get a Rich Presence value from a specified friend.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// Returns an empty string ("") if the specified key is not set.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestFriendRichPresence" class="bb_apilink">ISteamFriends::RequestFriendRichPresence</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SetRichPresence" class="bb_apilink">ISteamFriends::SetRichPresence</a>
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The friend to get the Rich Presence value for.</param>
        /// <param name="pchKey">const char *: The Rich Presence key to request.</param>
        public static UTF8StringPtr GetFriendRichPresence(SteamId steamIDFriend, UTF8StringPtr pchKey) => Instance.GetFriendRichPresence(steamIDFriend, pchKey);
        /// <summary>
        /// <code>int GetFriendRichPresenceKeyCount( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets the number of Rich Presence keys that are set on the specified user.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendRichPresenceKeyByIndex" class="bb_apilink">ISteamFriends::GetFriendRichPresenceKeyByIndex</a>
        /// to get the rich presence keys.<br />
        /// <br />
        /// This is typically only ever used for debugging purposes.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Returns <b>0</b> if there is no Rich Presence information for the specified user.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user to get the Rich Presence Key Count of.</param>
        public static int GetFriendRichPresenceKeyCount(SteamId steamIDFriend) => Instance.GetFriendRichPresenceKeyCount(steamIDFriend);
        /// <summary>
        /// <code>
        ///     const char * GetFriendRichPresenceKeyByIndex( CSteamID steamIDFriend, int iKey );
        /// </code>
        /// 
        /// <br />
        /// <br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// Returns an empty string ("") if the index is invalid or the specified user has no Rich Presence data
        /// available.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : 
        ///             This should be the same user provided to the previous call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendRichPresenceKeyCount" class="bb_apilink">ISteamFriends::GetFriendRichPresenceKeyCount</a>!
        ///         </param>
        /// <param name="iKey">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendRichPresenceKeyCount" class="bb_apilink">ISteamFriends::GetFriendRichPresenceKeyCount</a>.
        ///         </param>
        public static UTF8StringPtr GetFriendRichPresenceKeyByIndex(SteamId steamIDFriend, int iKey) => Instance.GetFriendRichPresenceKeyByIndex(steamIDFriend, iKey);
        /// <summary>
        /// <code>void RequestFriendRichPresence( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Requests Rich Presence data from a specific user.<br />
        /// <br />
        /// This is used to get the Rich Presence information from a user that is not a friend of the current
        /// user, like someone in the same lobby or game server.<br />
        /// <br />
        /// This function is rate limited, if you call this too frequently for a particular user then it will
        /// just immediately post a callback without requesting new data from the server.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendRichPresenceUpdate_t" class="bb_apilink">FriendRichPresenceUpdate_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendRichPresence" class="bb_apilink">ISteamFriends::GetFriendRichPresence</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SetRichPresence" class="bb_apilink">ISteamFriends::SetRichPresence</a>
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user to request the rich presence of.</param>
        public static void RequestFriendRichPresence(SteamId steamIDFriend) => Instance.RequestFriendRichPresence(steamIDFriend);
        /// <summary>
        /// <code>
        ///     bool InviteUserToGame( CSteamID steamIDFriend, const char *pchConnectString );
        /// </code>
        /// 
        /// <br />
        /// Invites a friend or clan member to the current game using a special invite string.<br />
        /// <br />
        /// If the target user accepts the invite then the pchConnectString gets added to the command-line when
        /// launching the game.<br />
        /// If the game is already running for that user, then they will receive a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameRichPresenceJoinRequested_t" class="bb_apilink">GameRichPresenceJoinRequested_t</a>
        /// callback with the connect string.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameRichPresenceJoinRequested_t" class="bb_apilink">GameRichPresenceJoinRequested_t</a>
        /// callback.<br />
        /// <b>true</b> if the invite was successfully sent.<br />
        /// <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         The Steam ID provided to
        ///         <code class="bb_code bb_code_inline nohighlight">steamIDFriend</code> was invalid.<br />
        ///     </li>
        ///     <li>
        ///         The Steam ID provided to
        ///         <code class="bb_code bb_code_inline nohighlight">steamIDFriend</code> is not a friend or
        ///         does not share the same Steam Group as the current user.<br />
        ///     </li>
        ///     <li>
        ///         The value provided to
        ///         <code class="bb_code bb_code_inline nohighlight">pchConnectString</code> was too long.
        ///     </li>
        /// </ul>
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#InviteUserToLobby" class="bb_apilink">ISteamMatchmaking::InviteUserToLobby</a>
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the friend to invite.</param>
        /// <param name="pchConnectString">const char *: 
        ///             A string that lets the friend know how to join the game (I.E. the game server IP). This
        ///             can not be longer than specified in
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cchMaxRichPresenceValueLength" class="bb_apilink">k_cchMaxRichPresenceValueLength</a>.
        ///         </param>
        public static bool InviteUserToGame(SteamId steamIDFriend, UTF8StringPtr pchConnectString) => Instance.InviteUserToGame(steamIDFriend, pchConnectString);
        /// <summary>
        /// <code>int GetCoplayFriendCount();</code>
        /// Gets the number of players that the current user has recently played with, across all games.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetCoplayFriend" class="bb_apilink">ISteamFriends::GetCoplayFriend</a>
        /// can be used to get the Steam ID of each player.<br />
        /// <br />
        /// These players are have been set with previous calls to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SetPlayedWith" class="bb_apilink">ISteamFriends::SetPlayedWith</a>.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of users that the current user has recently played with.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void ListRecentlyPlayedWithList() { int nPlayers = SteamFriends()-&gt;GetCoplayFriendCount();
        ///     printf( "Listing %d Recently Played with Players\n", nPlayers ); for ( int i = 0; i &lt;
        ///     nPlayers; ++i ) { CSteamID playerSteamID = SteamFriends()-&gt;GetCoplayFriend( i ); int
        ///     iTimeStamp = SteamFriends()-&gt;GetFriendCoplayTime( playerSteamID ); AppId_t app =
        ///     SteamFriends()-&gt;GetFriendCoplayGame( playerSteamID ); printf( "Player %d - ID: %lld - Time:
        ///     %d - App: %d\n", i, playerSteamID.ConvertToUint64(), iTimeStamp, app ); } }
        /// </code>
        /// </summary>
        /// 
        public static int GetCoplayFriendCount() => Instance.GetCoplayFriendCount();
        /// <summary>
        /// <code>CSteamID GetCoplayFriend( int iCoplayFriend );</code>
        /// 
        /// <br />
        /// Gets the Steam ID of the recently played with user at the given index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetCoplayFriendCount" class="bb_apilink">ISteamFriends::GetCoplayFriendCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Invalid indices return
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>.
        /// </summary>
        /// <param name="iCoplayFriend">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetCoplayFriendCount" class="bb_apilink">ISteamFriends::GetCoplayFriendCount</a>.
        ///         </param>
        public static SteamId GetCoplayFriend(int iCoplayFriend) => Instance.GetCoplayFriend(iCoplayFriend);
        /// <summary>
        /// <code>int GetFriendCoplayTime( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets the timestamp of when the user played with someone on their recently-played-with list.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The time is provided in Unix epoch format (seconds since Jan 1st 1970).<br />
        /// Steam IDs not in the recently-played-with list return <b>0</b>.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user on the recently-played-with list to get the timestamp for.</param>
        public static int GetFriendCoplayTime(SteamId steamIDFriend) => Instance.GetFriendCoplayTime(steamIDFriend);
        /// <summary>
        /// <code>AppId_t GetFriendCoplayGame( CSteamID steamIDFriend );</code>
        /// 
        /// <br />
        /// Gets the app ID of the game that user played with someone on their recently-played-with list.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a><br />
        /// Steam IDs not in the recently-played-with list return
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAppIdInvalid" class="bb_apilink">k_uAppIdInvalid</a>.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user on the recently-played-with list to get the game played.</param>
        public static AppId GetFriendCoplayGame(SteamId steamIDFriend) => Instance.GetFriendCoplayGame(steamIDFriend);
        /// <summary>
        /// <code>SteamAPICall_t JoinClanChatRoom( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Allows the user to join Steam group (clan) chats right within the game.<br />
        /// <br />
        /// The behavior is somewhat complicated, because the user may or may not be already in the group chat
        /// from outside the game or in the overlay.<br />
        /// <br />
        /// You can use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ActivateGameOverlayToUser" class="bb_apilink">ISteamFriends::ActivateGameOverlayToUser</a>
        /// to open the in-game overlay version of the chat.<br />
        /// <br />
        /// If you have joined a Steam group chat then you should be watching for the following callbacks:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedClanChatMsg_t" class="bb_apilink">GameConnectedClanChatMsg_t</a><br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedChatJoin_t" class="bb_apilink">GameConnectedChatJoin_t</a><br />
        ///     </li>
        ///     <li>
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedChatLeave_t" class="bb_apilink">GameConnectedChatLeave_t</a>
        ///     </li>
        /// </ul>
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#JoinClanChatRoomCompletionResult_t" class="bb_apilink">JoinClanChatRoomCompletionResult_t</a>
        /// call result.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedChatJoin_t" class="bb_apilink">GameConnectedChatJoin_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedClanChatMsg_t" class="bb_apilink">GameConnectedClanChatMsg_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#LeaveClanChatRoom" class="bb_apilink">ISteamFriends::LeaveClanChatRoom</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanChatMemberCount" class="bb_apilink">ISteamFriends::GetClanChatMemberCount</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetChatMemberByIndex" class="bb_apilink">ISteamFriends::GetChatMemberByIndex</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SendClanChatMessage" class="bb_apilink">ISteamFriends::SendClanChatMessage</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanChatMessage" class="bb_apilink">ISteamFriends::GetClanChatMessage</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#IsClanChatAdmin" class="bb_apilink">ISteamFriends::IsClanChatAdmin</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#IsClanChatWindowOpenInSteam" class="bb_apilink">ISteamFriends::IsClanChatWindowOpenInSteam</a>
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group to join.</param>
        public static SteamAPICall JoinClanChatRoom(SteamId steamIDClan) => Instance.JoinClanChatRoom(steamIDClan);
        /// <summary>
        /// <code>bool LeaveClanChatRoom( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Leaves a Steam group chat that the user has previously entered with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#JoinClanChatRoom" class="bb_apilink">ISteamFriends::JoinClanChatRoom</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedChatLeave_t" class="bb_apilink">GameConnectedChatLeave_t</a>
        /// callback.<br />
        /// <b>true</b> if user is in the specified chat room, otherwise <b>false</b>.
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group chat to leave.</param>
        public static bool LeaveClanChatRoom(SteamId steamIDClan) => Instance.LeaveClanChatRoom(steamIDClan);
        /// <summary>
        /// <code>int GetClanChatMemberCount( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Get the number of users in a Steam group chat.<br />
        /// <br />
        /// <b>NOTE:</b> Large steam groups cannot be iterated by the local user.<br />
        /// <br />
        /// <b>NOTE:</b> The current user must be in a lobby to retrieve the Steam IDs of other users
        /// in that lobby.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetChatMemberByIndex" class="bb_apilink">ISteamFriends::GetChatMemberByIndex</a>
        /// can be used to get the Steam ID of each person in the chat.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// <b>0</b> if the Steam ID provided is invalid or if the local user doesn't have the data
        /// available.
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam group to get the chat count of.</param>
        public static int GetClanChatMemberCount(SteamId steamIDClan) => Instance.GetClanChatMemberCount(steamIDClan);
        /// <summary>
        /// <code>CSteamID GetChatMemberByIndex( CSteamID steamIDClan, int iUser );</code>
        /// 
        /// <br />
        /// Gets the Steam ID at the given index in a Steam group chat.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanChatMemberCount" class="bb_apilink">ISteamFriends::GetClanChatMemberCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Invalid indices return
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>.
        /// </summary>
        /// <param name="steamIDClan">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : 
        ///             This MUST be the same source used in the previous call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanChatMemberCount" class="bb_apilink">ISteamFriends::GetClanChatMemberCount</a>!
        ///         </param>
        /// <param name="iUser">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanChatMemberCount" class="bb_apilink">ISteamFriends::GetClanChatMemberCount</a>.
        ///         </param>
        public static SteamId GetChatMemberByIndex(SteamId steamIDClan, int iUser) => Instance.GetChatMemberByIndex(steamIDClan, iUser);
        /// <summary>
        /// <code>
        ///     bool SendClanChatMessage( CSteamID steamIDClanChat, const char *pchText );
        /// </code>
        /// 
        /// <br />
        /// Sends a message to a Steam group chat room.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the message was successfully sent.<br />
        /// <b>false</b> under one of the following circumstances:<br />
        /// <ul class="bb_ul">
        ///     <li>The current user is not in the specified group chat.<br /></li>
        ///     <li>The current user is not connected to Steam.<br /></li>
        ///     <li>The current user is rate limited.<br /></li>
        ///     <li>The current user is chat restricted.<br /></li>
        ///     <li>
        ///         The message in <code class="bb_code bb_code_inline nohighlight">pchText</code> exceeds 2048
        ///         characters.
        ///     </li>
        /// </ul>
        /// </summary>
        /// <param name="steamIDClanChat">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the group chat to send the message to.</param>
        /// <param name="pchText">const char *: The UTF-8 formatted message to send. This can be up to 2048 characters long.</param>
        public static bool SendClanChatMessage(SteamId steamIDClanChat, UTF8StringPtr pchText) => Instance.SendClanChatMessage(steamIDClanChat, pchText);
        /// <summary>
        /// <code>
        ///     int GetClanChatMessage( CSteamID steamIDClanChat, int iMessage, void *prgchText, int cchTextMax,
        ///     EChatEntryType *peChatEntryType, CSteamID *psteamidChatter );
        /// </code>
        /// 
        /// <br />
        /// Gets the data from a Steam group chat room message.<br />
        /// <br />
        /// This should only ever be called in response to a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedClanChatMsg_t" class="bb_apilink">GameConnectedClanChatMsg_t</a>
        /// callback.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of bytes copied into
        /// <code class="bb_code bb_code_inline nohighlight">prgchText</code>.<br />
        /// Returns <b>0</b> and sets
        /// <code class="bb_code bb_code_inline nohighlight">peChatEntryType</code> to
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_EChatEntryTypeInvalid" class="bb_apilink">k_EChatEntryTypeInvalid</a>
        /// if the current user is not in the specified Steam group chat room or if the index provided in
        /// <code class="bb_code bb_code_inline nohighlight">iMessage</code> is invalid.
        /// </summary>
        /// <param name="steamIDClanChat">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group chat room.</param>
        /// <param name="iMessage">int: 
        ///             The index of the message. This should be the
        ///             <code class="bb_code bb_code_inline nohighlight">m_iMessageID</code> field of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedClanChatMsg_t" class="bb_apilink">GameConnectedClanChatMsg_t</a>.
        ///         </param>
        /// <param name="prgchText">void *: 
        ///             The buffer where the chat message will be copied into. (Should be big enough to hold
        ///             2048 UTF-8 characters. So 8192 bytes + 1 for '\0')
        ///         </param>
        /// <param name="cchTextMax">int: The size of <code class="bb_code bb_code_inline nohighlight">prgchText</code>.</param>
        /// <param name="peChatEntryType">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#EChatEntryType" class="bb_apilink">EChatEntryType</a>
        ///             *
        ///         : Returns the type of chat entry that was received.</param>
        /// <param name="psteamidChatter">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///             *
        ///         : Returns the Steam ID of the user that sent the message.</param>
        public static int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, void* prgchText, int cchTextMax, ChatEntryType* peChatEntryType, SteamId* psteamidChatter) => Instance.GetClanChatMessage(steamIDClanChat, iMessage, prgchText, cchTextMax, peChatEntryType, psteamidChatter);
        /// <summary>
        /// <code>
        ///     bool IsClanChatAdmin( CSteamID steamIDClanChat, CSteamID steamIDUser );
        /// </code>
        /// 
        /// <br />
        /// Checks if a user in the Steam group chat room is an admin.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the specified user is an admin.<br />
        /// <b>false</b> if the user is not an admin, if the current user is not in the chat room
        /// specified, or the specified user is not in the chat room.
        /// </summary>
        /// <param name="steamIDClanChat">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group chat room.</param>
        /// <param name="steamIDUser">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user to check the admin status of.</param>
        public static bool IsClanChatAdmin(SteamId steamIDClanChat, SteamId steamIDUser) => Instance.IsClanChatAdmin(steamIDClanChat, steamIDUser);
        /// <summary>
        /// <code>bool IsClanChatWindowOpenInSteam( CSteamID steamIDClanChat );</code>
        /// 
        /// <br />
        /// Checks if the Steam Group chat room is open in the Steam UI.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the specified Steam group chat room is opened; otherwise,
        /// <b>false</b>.<br />
        /// This also returns <b>false</b> if the specified Steam group chat room is unknown.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#OpenClanChatWindowInSteam" class="bb_apilink">ISteamFriends::OpenClanChatWindowInSteam</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#CloseClanChatWindowInSteam" class="bb_apilink">ISteamFriends::CloseClanChatWindowInSteam</a>
        /// </summary>
        /// <param name="steamIDClanChat">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group chat room to check.</param>
        public static bool IsClanChatWindowOpenInSteam(SteamId steamIDClanChat) => Instance.IsClanChatWindowOpenInSteam(steamIDClanChat);
        /// <summary>
        /// <code>bool OpenClanChatWindowInSteam( CSteamID steamIDClanChat );</code>
        /// 
        /// <br />
        /// Opens the specified Steam group chat room in the Steam UI.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the user successfully entered the Steam group chat room.<br />
        /// <b>false</b> in one of the following situations:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         The provided Steam group chat room does not exist or the user does not have access to join
        ///         it.<br />
        ///     </li>
        ///     <li>The current user is currently rate limited.<br /></li>
        ///     <li>The current user is chat restricted.</li>
        /// </ul>
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#IsClanChatWindowOpenInSteam" class="bb_apilink">ISteamFriends::IsClanChatWindowOpenInSteam</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#CloseClanChatWindowInSteam" class="bb_apilink">ISteamFriends::CloseClanChatWindowInSteam</a>
        /// </summary>
        /// <param name="steamIDClanChat">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group chat room to open.</param>
        public static bool OpenClanChatWindowInSteam(SteamId steamIDClanChat) => Instance.OpenClanChatWindowInSteam(steamIDClanChat);
        /// <summary>
        /// <code>bool CloseClanChatWindowInSteam( CSteamID steamIDClanChat );</code>
        /// 
        /// <br />
        /// Closes the specified Steam group chat room in the Steam UI.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the user successfully left the Steam group chat room.<br />
        /// <b>false</b> if the user is not in the provided Steam group chat room.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#IsClanChatWindowOpenInSteam" class="bb_apilink">ISteamFriends::IsClanChatWindowOpenInSteam</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#OpenClanChatWindowInSteam" class="bb_apilink">ISteamFriends::OpenClanChatWindowInSteam</a>
        /// </summary>
        /// <param name="steamIDClanChat">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group chat room to close.</param>
        public static bool CloseClanChatWindowInSteam(SteamId steamIDClanChat) => Instance.CloseClanChatWindowInSteam(steamIDClanChat);
        /// <summary>
        /// <code>bool SetListenForFriendsMessages( bool bInterceptEnabled );</code>
        /// 
        /// <br />
        /// Listens for Steam friends chat messages.<br />
        /// <br />
        /// You can then show these chats inline in the game. For example, the chat system in Dota 2.<br />
        /// <br />
        /// After enabling this you will receive
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedFriendChatMsg_t" class="bb_apilink">GameConnectedFriendChatMsg_t</a>
        /// callbacks whenever the user receives a chat message. You can get the actual message data from this
        /// callback with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendMessage" class="bb_apilink">ISteamFriends::GetFriendMessage</a>. You can send messages with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ReplyToFriendMessage" class="bb_apilink">ISteamFriends::ReplyToFriendMessage</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedFriendChatMsg_t" class="bb_apilink">GameConnectedFriendChatMsg_t</a>
        /// callback.<br />
        /// Always returns <b>true</b>.
        /// </summary>
        /// <param name="bInterceptEnabled">bool: 
        ///             Turn friends message interception on (<b>true</b>) or off
        ///             (<b>false</b>)?
        ///         </param>
        public static bool SetListenForFriendsMessages(bool bInterceptEnabled) => Instance.SetListenForFriendsMessages(bInterceptEnabled);
        /// <summary>
        /// <code>
        ///     bool ReplyToFriendMessage( CSteamID steamIDFriend, const char *pchMsgToSend );
        /// </code>
        /// 
        /// <br />
        /// Sends a message to a Steam friend.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the message was successfully sent.<br />
        /// <b>false</b> if the current user is rate limited or chat restricted.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the friend to send the message to.</param>
        /// <param name="pchMsgToSend">const char *: The UTF-8 formatted message to send.</param>
        public static bool ReplyToFriendMessage(SteamId steamIDFriend, UTF8StringPtr pchMsgToSend) => Instance.ReplyToFriendMessage(steamIDFriend, pchMsgToSend);
        /// <summary>
        /// <code>
        ///     int GetFriendMessage( CSteamID steamIDFriend, int iMessageID, void *pvData, int cubData,
        ///     EChatEntryType *peChatEntryType );
        /// </code>
        /// 
        /// <br />
        /// Gets the data from a Steam friends message.<br />
        /// <br />
        /// This should only ever be called in response to a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedFriendChatMsg_t" class="bb_apilink">GameConnectedFriendChatMsg_t</a>
        /// callback.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of bytes copied into
        /// <code class="bb_code bb_code_inline nohighlight">pvData</code>.<br />
        /// Returns <b>0</b> and sets
        /// <code class="bb_code bb_code_inline nohighlight">peChatEntryType</code> to
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_EChatEntryTypeInvalid" class="bb_apilink">k_EChatEntryTypeInvalid</a>
        /// if the current user is chat restricted, if the provided Steam ID is not a friend, or if the index
        /// provided in <code class="bb_code bb_code_inline nohighlight">iMessageID</code> is invalid.
        /// </summary>
        /// <param name="steamIDFriend">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the friend that sent this message.</param>
        /// <param name="iMessageID">int: 
        ///             The index of the message. This should be the
        ///             <code class="bb_code bb_code_inline nohighlight">m_iMessageID</code> field of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameConnectedFriendChatMsg_t" class="bb_apilink">GameConnectedFriendChatMsg_t</a>.
        ///         </param>
        /// <param name="pvData">void *: The buffer where the chat message will be copied into.</param>
        /// <param name="cubData">int: The size of <code class="bb_code bb_code_inline nohighlight">pvData</code>.</param>
        /// <param name="peChatEntryType">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#EChatEntryType" class="bb_apilink">EChatEntryType</a>
        ///             *
        ///         : Returns the type of chat entry that was received.</param>
        public static int GetFriendMessage(SteamId steamIDFriend, int iMessageID, void* pvData, int cubData, ChatEntryType* peChatEntryType) => Instance.GetFriendMessage(steamIDFriend, iMessageID, pvData, cubData, peChatEntryType);
        /// <summary>
        /// <code>SteamAPICall_t GetFollowerCount( CSteamID steamID );</code>
        /// 
        /// <br />
        /// Gets the number of users following the specified user.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsGetFollowerCount_t" class="bb_apilink">FriendsGetFollowerCount_t</a>
        /// call result.<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     class GetFollowerCountExample { public: void GetFollowerCount(); private: void
        ///     OnFriendsGetFollowerCount( FriendsGetFollowerCount_t *pCallback, bool bIOFailure );
        ///     CCallResult&lt; GetFollowerCountExample, FriendsGetFollowerCount_t &gt;
        ///     m_SteamCallResultFriendsGetFollowerCount; }; void GetFollowerCountExample::GetFollowerCount() {
        ///     printf( "Getting the number of users who follow us.\n" ); SteamAPICall_t handle =
        ///     SteamFriends()-&gt;GetFollowerCount( SteamUser()-&gt;GetSteamID() );
        ///     m_SteamCallResultFriendsGetFollowerCount.Set( handle, this,
        ///     &amp;GetFollowerCountExample::OnFriendsGetFollowerCount ); } void
        ///     GetFollowerCountExample::OnFriendsGetFollowerCount( FriendsGetFollowerCount_t *pCallback, bool
        ///     bIOFailure ) { if ( pCallback-&gt;m_eResult != k_EResultOK || bIOFailure ) { printf(
        ///     "OnFriendsGetFollowerCount failed for %lld with m_eResult: %d and bIOFailure: %d!",
        ///     pCallback-&gt;m_steamID.ConvertToUint64(), pCallback-&gt;m_eResult, bIOFailure ); return; }
        ///     printf( "Got a FriendsGetFollowerCount_t, we have %d followers.\n", pCallback-&gt;m_nCount ); }
        /// </code>
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The user to get the follower count for.</param>
        public static SteamAPICall GetFollowerCount(SteamId steamID) => Instance.GetFollowerCount(steamID);
        /// <summary>
        /// <code>SteamAPICall_t IsFollowing( CSteamID steamID );</code>
        /// 
        /// <br />
        /// Checks if the current user is following the specified user.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsIsFollowing_t" class="bb_apilink">FriendsIsFollowing_t</a>
        /// call result.<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     class CIsFollowingExample { public: CIsFollowingExample(); void
        ///     CheckWhichFriendsWeAreFollowing(); private: void OnFriendsIsFollowing( FriendsIsFollowing_t
        ///     *pCallback, bool bIOFailure ); CCallResult&lt; CIsFollowingExample, FriendsIsFollowing_t &gt;
        ///     m_SteamCallResultFriendsIsFollowing; int m_nFriends; int m_iFriendIndex; };
        ///     CIsFollowingExample::CIsFollowingExample() { m_nFriends = SteamFriends()-&gt;GetFriendCount(
        ///     k_EFriendFlagImmediate ); if ( m_nFriends == -1 ) { printf( "GetFriendCount returned -1, the
        ///     current user is not logged in.\n" ); m_nFriends = 0; } m_iFriendIndex = 0; } void
        ///     CIsFollowingExample::CheckWhichFriendsWeAreFollowing() { if ( m_iFriendIndex &lt; m_nFriends ) {
        ///     CSteamID steamID = SteamFriends()-&gt;GetFriendByIndex( m_iFriendIndex, k_EFriendFlagImmediate
        ///     ); printf( "Checking if we follow %lld (%d of %d).\n", steamID.ConvertToUint64(),
        ///     m_iFriendIndex, m_nFriends ); SteamAPICall_t handle = SteamFriends()-&gt;IsFollowing( steamID );
        ///     m_SteamCallResultFriendsIsFollowing.Set( handle, this,
        ///     &amp;CIsFollowingExample::OnFriendsIsFollowing ); } } void
        ///     CIsFollowingExample::OnFriendsIsFollowing( FriendsIsFollowing_t *pCallback, bool bIOFailure ) {
        ///     if ( pCallback-&gt;m_eResult != k_EResultOK || bIOFailure ) { printf( "OnFriendsIsFollowing
        ///     failed for %lld with m_eResult: %d and bIOFailure: %d!\n",
        ///     pCallback-&gt;m_steamID.ConvertToUint64(), pCallback-&gt;m_eResult, bIOFailure ); return; } if (
        ///     pCallback-&gt;m_bIsFollowing ) printf( "We are following %lld\n",
        ///     pCallback-&gt;m_steamID.ConvertToUint64() ); // Recursively check our whole friends list.
        ///     m_iFriendIndex++; CheckWhichFriendsWeAreFollowing(); }
        /// </code>
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the check if we are following.</param>
        public static SteamAPICall IsFollowing(SteamId steamID) => Instance.IsFollowing(steamID);
        /// <summary>
        /// <code>SteamAPICall_t EnumerateFollowingList( uint32 unStartIndex );</code>
        /// 
        /// <br />
        /// Gets the list of users that the current user is following.<br />
        /// <br />
        /// You can be following people that are not your friends. Following allows you to receive updates when
        /// the person does things like post a new piece of content to the Steam Workshop.<br />
        /// <br />
        /// <b>NOTE:</b> This returns up to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cEnumerateFollowersMax" class="bb_apilink">k_cEnumerateFollowersMax</a>
        /// users at once. If the current user is following more than that, you will need to call this
        /// repeatedly, with <code class="bb_code bb_code_inline nohighlight">unStartIndex</code> set to the
        /// total number of followers that you have received so far.<br />
        /// I.E. If you have received 50 followers, and the user is following 105, you will need to call this
        /// again with <code class="bb_code bb_code_inline nohighlight">unStartIndex</code> = 50 to get the next
        /// 50, and then again with <code class="bb_code bb_code_inline nohighlight">unStartIndex</code> = 100
        /// to get the remaining 5 users.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#FriendsEnumerateFollowingList_t" class="bb_apilink">FriendsEnumerateFollowingList_t</a>
        /// call result.<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     class CEnumerateFollowingListExample { public: void GetWhoWeFollow(); private: void
        ///     OnFriendsEnumerateFollowingList( FriendsEnumerateFollowingList_t *pCallback, bool bIOFailure );
        ///     CCallResult&lt; CEnumerateFollowingListExample, FriendsEnumerateFollowingList_t &gt;
        ///     m_SteamCallResultFriendsEnumerateFollowingList; int m_nFollowersParsed; }; void
        ///     CEnumerateFollowingListExample::GetWhoWeFollow() { m_nFollowersParsed = 0; printf( "Getting the
        ///     list of users that we follow.\n" ); SteamAPICall_t handle =
        ///     SteamFriends()-&gt;EnumerateFollowingList( 0 );
        ///     m_SteamCallResultFriendsEnumerateFollowingList.Set( handle, this,
        ///     &amp;CEnumerateFollowingListExample::OnFriendsEnumerateFollowingList ); } void
        ///     CEnumerateFollowingListExample::OnFriendsEnumerateFollowingList( FriendsEnumerateFollowingList_t
        ///     *pCallback, bool bIOFailure ) { if ( pCallback-&gt;m_eResult != k_EResultOK || bIOFailure ) {
        ///     printf( "OnFriendsEnumerateFollowingList failed with m_eResult: %d and bIOFailure: %d!",
        ///     pCallback-&gt;m_eResult, bIOFailure ); return; } printf( "FriendsEnumerateFollowingList
        ///     retrieved %d of %d people that we follow.\n", pCallback-&gt;m_nResultsReturned,
        ///     pCallback-&gt;m_nTotalResultCount ); for ( int i = 0; i &lt; pCallback-&gt;m_nResultsReturned;
        ///     ++i ) { printf( " %d: %lld\n", i, pCallback-&gt;m_rgSteamID[i].ConvertToUint64() ); }
        ///     m_nFollowersParsed += pCallback-&gt;m_nResultsReturned; // There are more followers! Gets the
        ///     next set of them! if ( m_nFollowersParsed &lt; pCallback-&gt;m_nTotalResultCount ) {
        ///     SteamAPICall_t handle = SteamFriends()-&gt;EnumerateFollowingList(
        ///     pCallback-&gt;m_nResultsReturned ); m_SteamCallResultFriendsEnumerateFollowingList.Set( handle,
        ///     this, &amp;CEnumerateFollowingListExample::OnFriendsEnumerateFollowingList ); } }
        /// </code>
        /// </summary>
        /// <param name="unStartIndex">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : The index to start receiving followers from. This should be 0 on the initial call.</param>
        public static SteamAPICall EnumerateFollowingList(uint unStartIndex) => Instance.EnumerateFollowingList(unStartIndex);
        /// <summary>
        /// <code>bool IsClanPublic( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Checks if the Steam group is public.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the specified group is public<br />
        /// <b>false</b> if the specified group is not public
        /// </summary>
        /// <param name="steamIDClan ">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group.</param>
        public static bool IsClanPublic(SteamId steamIDClan) => Instance.IsClanPublic(steamIDClan);
        /// <summary>
        /// <code>bool IsClanOfficialGameGroup( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// Checks if the Steam group is an official game group/community hub.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the specified group is an official game group/community hub<br />
        /// <b>false</b> if the specified group is not an official game group/community hub
        /// </summary>
        /// <param name="steamIDClan ">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the Steam group.</param>
        public static bool IsClanOfficialGameGroup(SteamId steamIDClan) => Instance.IsClanOfficialGameGroup(steamIDClan);
        /// missing documentation
        public static int GetNumChatsWithUnreadPriorityMessages() => Instance.GetNumChatsWithUnreadPriorityMessages();
        /// missing documentation
        public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(SteamId steamIDLobby) => Instance.ActivateGameOverlayRemotePlayTogetherInviteDialog(steamIDLobby);
        /// missing documentation
        public static bool RegisterProtocolInOverlayBrowser(UTF8StringPtr pchProtocol) => Instance.RegisterProtocolInOverlayBrowser(pchProtocol);
        /// missing documentation
        public static void ActivateGameOverlayInviteDialogConnectString(UTF8StringPtr pchConnectString) => Instance.ActivateGameOverlayInviteDialogConnectString(pchConnectString);
        /// <summary>
        /// <code>SteamAPICall_t RequestEquippedProfileItems( CSteamID steamID);</code>
        /// 
        /// <br />
        /// Requests the list of equipped Steam Community profile items for the given user from Steam.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EquippedProfileItems_t" class="bb_apilink">EquippedProfileItems_t</a>
        /// call result.
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The user that you want to retrieve equipped items for.</param>
        public static SteamAPICall RequestEquippedProfileItems(SteamId steamID) => Instance.RequestEquippedProfileItems(steamID);
        /// <summary>
        /// <code>
        ///     bool BHasEquippedProfileItem( CSteamID steamID, ECommunityProfileItemType itemType);
        /// </code>
        /// 
        /// <br />
        /// After calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestEquippedProfileItems" class="bb_apilink">ISteamFriends::RequestEquippedProfileItems</a>, you can use this function to check if the user has a type of profile item equipped or not.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the itemType is equipped for the user<br />
        /// <b>false</b> if the itemType is not equipped for the user<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestEquippedProfileItems" class="bb_apilink">ISteamFriends::RequestEquippedProfileItems</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetProfileItemPropertyString" class="bb_apilink">ISteamFriends::GetProfileItemPropertyString</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetProfileItemPropertyUint" class="bb_apilink">ISteamFriends::GetProfileItemPropertyUint</a>
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The user that you had already retrieved equipped items for</param>
        /// <param name="itemType">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ECommunityProfileItemType" class="bb_apilink">ECommunityProfileItemType</a>
        ///         : Type of item you want to see is equipped or not</param>
        public static bool BHasEquippedProfileItem(SteamId steamID, CommunityProfileItemType itemType) => Instance.BHasEquippedProfileItem(steamID, itemType);
        /// <summary>
        /// <code>
        ///     bool GetProfileItemPropertyString( CSteamID steamID, ECommunityProfileItemType itemType,
        ///     ECommunityProfileItemProperty prop);
        /// </code>
        /// 
        /// <br />
        /// Returns a string property for a user's equipped profile item.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestEquippedProfileItems" class="bb_apilink">ISteamFriends::RequestEquippedProfileItems</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetProfileItemPropertyUint" class="bb_apilink">ISteamFriends::GetProfileItemPropertyUint</a>
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The user that you had already retrieved equipped items for</param>
        /// <param name="itemType">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ECommunityProfileItemType" class="bb_apilink">ECommunityProfileItemType</a>
        ///         : Type of item you are retrieving the property for</param>
        /// <param name="prop">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ECommunityProfileItemProperty" class="bb_apilink">ECommunityProfileItemProperty</a>
        ///         : The string property you want to retrieve</param>
        public static UTF8StringPtr GetProfileItemPropertyString(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop) => Instance.GetProfileItemPropertyString(steamID, itemType, prop);
        /// <summary>
        /// <code>
        ///     bool GetProfileItemPropertyUint( CSteamID steamID, ECommunityProfileItemType itemType,
        ///     ECommunityProfileItemProperty prop);
        /// </code>
        /// 
        /// <br />
        /// Returns an unsigned integer property for a user's equipped profile item.<br />
        /// <br />
        /// <b>Returns:</b> uint32<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestEquippedProfileItems" class="bb_apilink">ISteamFriends::RequestEquippedProfileItems</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetProfileItemPropertyString" class="bb_apilink">ISteamFriends::GetProfileItemPropertyString</a>
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The user that you had already retrieved equipped items for</param>
        /// <param name="itemType">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ECommunityProfileItemType" class="bb_apilink">ECommunityProfileItemType</a>
        ///         : Type of item you are retrieving the property for</param>
        /// <param name="prop">
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#ECommunityProfileItemProperty" class="bb_apilink">ECommunityProfileItemProperty</a>
        ///         : The unsigned integer property you want to retrieve</param>
        public static uint GetProfileItemPropertyUint(SteamId steamID, CommunityProfileItemType itemType, CommunityProfileItemProperty prop) => Instance.GetProfileItemPropertyUint(steamID, itemType, prop);
    }
}