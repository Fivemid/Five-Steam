using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamItemDetails_t</summary>
    public unsafe struct SteamItemDetails
    {
        /// <summary>SteamItemInstanceID_t m_itemId</summary>
        public SteamItemInstanceID itemId;
        /// <summary>SteamItemDef_t m_iDefinition</summary>
        public SteamItemDef iDefinition;
        /// <summary>uint16 m_unQuantity</summary>
        public ushort unQuantity;
        /// <summary>uint16 m_unFlags</summary>
        public ushort unFlags;
    }
}