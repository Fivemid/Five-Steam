using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Sent after the device returns from sleep/suspend mode.<br />
    /// <br />
    /// This callback has no fields.</summary>
    public unsafe struct AppResumingFromSuspend : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AppResumingFromSuspend;
    }
}