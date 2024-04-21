using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamParentalSettingsChanged_t
    public unsafe struct SteamParentalSettingsChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamParentalSettingsChanged;
    }
}