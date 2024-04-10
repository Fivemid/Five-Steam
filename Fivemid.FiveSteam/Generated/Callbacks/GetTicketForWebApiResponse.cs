using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GetTicketForWebApiResponse_t</summary>
    public unsafe struct GetTicketForWebApiResponse
    {
        /// <summary>HAuthTicket m_hAuthTicket</summary>
        public HAuthTicket hAuthTicket;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>int m_cubTicket</summary>
        public int cubTicket;
        /// <summary>uint8 [2560] m_rgubTicket</summary>
        public FixedArray_byte2560 rgubTicket;
    }
}