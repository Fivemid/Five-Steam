using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when we have received the group status of a user.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#RequestUserGroupStatus" class="bb_apilink">ISteamGameServer::RequestUserGroupStatus</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSClientGroupStatus
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSClientGroupStatus;
        /// <summary>The user whose group status we queried.</summary>
        public SteamId SteamIDUser;
        /// <summary>The group that we queried.</summary>
        public SteamId SteamIDGroup;
        /// <summary>Is the user a member of the group (<b>true</b>) or not (<b>false</b>)?</summary>
        public bool bMember;
        /// <summary>Is the user an officer in the group (<b>true</b>) or not (<b>false</b>)? This will never be true if <code class="bb_code bb_code_inline nohighlight">m_bMember</code> is false.</summary>
        public bool bOfficer;
    }
}