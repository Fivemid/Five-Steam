using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamParentalSettingsChanged_t</summary>
    public unsafe struct SteamParentalSettingsChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamParentalSettingsChanged;
    }
}