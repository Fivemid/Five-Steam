using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AppResumingFromSuspend_t</summary>
    public unsafe struct AppResumingFromSuspend : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AppResumingFromSuspend;
    }
}