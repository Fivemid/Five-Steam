using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called whenever the users licenses (owned packages) changes.<br />
    /// <br />
    /// This callback has no fields.
    /// </summary>
    public unsafe struct LicensesUpdated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LicensesUpdated;
    }
}