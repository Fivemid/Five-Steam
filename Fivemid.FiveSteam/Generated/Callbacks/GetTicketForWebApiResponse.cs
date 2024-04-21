using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Result when creating an webapi ticket from GetAuthTicketForWebApi.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthTicketForWebApi" class="bb_apilink">ISteamUser::GetAuthTicketForWebApi</a>
    /// </summary>
    public unsafe struct GetTicketForWebApiResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetTicketForWebApiResponse;
        /// <summary>The handle to the ticket that was created.</summary>
        public HAuthTicket hAuthTicket;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The length of the ticket that was created.</summary>
        public int cubTicket;
        /// <summary>The ticket that was created.</summary>
        public FixedArray_byte2560 rgubTicket;
    }
}