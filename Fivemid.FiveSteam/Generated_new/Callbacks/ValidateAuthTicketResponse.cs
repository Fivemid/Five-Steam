using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ValidateAuthTicketResponse_t</summary>
    public unsafe struct ValidateAuthTicketResponse
    {
        /// <summary>CSteamID m_SteamID</summary>
        public SteamId SteamID;
        /// <summary>EAuthSessionResponse m_eAuthSessionResponse</summary>
        public AuthSessionResponse eAuthSessionResponse;
        /// <summary>CSteamID m_OwnerSteamID</summary>
        public SteamId OwnerSteamID;
    }
}