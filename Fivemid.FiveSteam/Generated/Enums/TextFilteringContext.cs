using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ETextFilteringContext</summary>
    public enum TextFilteringContext : int
    {
        /// <summary>k_ETextFilteringContextUnknown</summary>
        Unknown = 0,
        /// <summary>k_ETextFilteringContextGameContent</summary>
        GameContent = 1,
        /// <summary>k_ETextFilteringContextChat</summary>
        Chat = 2,
        /// <summary>k_ETextFilteringContextName</summary>
        Name = 3
    }
}