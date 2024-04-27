using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct FavoritesListAccountsUpdated
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FavoritesListAccountsUpdated;
        /// <summary></summary>
        public Result eResult;
    }
}