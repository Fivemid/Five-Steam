using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the country of the user changed. The country should be updated with <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetIPCountry" class="bb_apilink">ISteamUtils::GetIPCountry</a>.<br />
    /// <br />
    /// This callback has no fields.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct IPCountry : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.IPCountry;
    }
}