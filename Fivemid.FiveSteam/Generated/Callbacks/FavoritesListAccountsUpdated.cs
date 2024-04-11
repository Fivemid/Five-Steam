using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FavoritesListAccountsUpdated_t</summary>
    public unsafe struct FavoritesListAccountsUpdated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FavoritesListAccountsUpdated;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}