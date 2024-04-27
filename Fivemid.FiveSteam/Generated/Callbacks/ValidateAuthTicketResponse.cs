using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when an auth ticket has been validated.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUser#BeginAuthSession" class="bb_apilink">ISteamUser::BeginAuthSession</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct ValidateAuthTicketResponse
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ValidateAuthTicketResponse;
        /// <summary>The Steam ID of the entity that provided the auth ticket.</summary>
        public SteamId SteamID;
        /// <summary>The result of the validation.</summary>
        public AuthSessionResponse eAuthSessionResponse;
        /// <summary>The Steam ID that owns the game, this will be different from <code class="bb_code bb_code_inline nohighlight">m_SteamID</code> if the game is being accessed via Steam Family Sharing. </summary>
        public SteamId OwnerSteamID;
    }
}