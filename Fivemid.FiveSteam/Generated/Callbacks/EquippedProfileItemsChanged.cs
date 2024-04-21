using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Callback for when a user's equipped Steam Community profile items have changed. This can be for the
    /// current user or their friends.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct EquippedProfileItemsChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EquippedProfileItemsChanged;
        /// <summary></summary>
        public SteamId steamID;
    }
}