using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Sent when the game server attempted to be associated with a Steam Group.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#AssociateWithClan" class="bb_apilink">ISteamGameServer::AssociateWithClan</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct AssociateWithClanResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AssociateWithClanResult;
        /// <summary>The result of the operation. Possible values:<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> - Success<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a> - The server could not be associated with the specified group.</li></ul></summary>
        public Result eResult;
    }
}