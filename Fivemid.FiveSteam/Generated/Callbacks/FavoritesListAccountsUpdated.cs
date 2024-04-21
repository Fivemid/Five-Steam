using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct FavoritesListAccountsUpdated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FavoritesListAccountsUpdated;
        /// <summary></summary>
        public Result eResult;
    }
}