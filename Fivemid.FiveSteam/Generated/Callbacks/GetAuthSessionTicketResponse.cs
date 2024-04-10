using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GetAuthSessionTicketResponse_t</summary>
    public unsafe struct GetAuthSessionTicketResponse
    {
        /// <summary>HAuthTicket m_hAuthTicket</summary>
        public HAuthTicket hAuthTicket;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}