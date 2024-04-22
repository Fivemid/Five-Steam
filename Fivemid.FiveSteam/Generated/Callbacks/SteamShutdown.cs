using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when Steam wants to shutdown.<br />
    /// <br />
    /// This callback has no fields.</summary>
    public unsafe struct SteamShutdown : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamShutdown;
    }
}