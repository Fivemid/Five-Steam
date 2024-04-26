using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result when creating an auth session ticket.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthSessionTicket" class="bb_apilink">ISteamUser::GetAuthSessionTicket</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GetAuthSessionTicketResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetAuthSessionTicketResponse;
        /// <summary>The handle to the ticket that was created.</summary>
        public HAuthTicket hAuthTicket;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
    }
}