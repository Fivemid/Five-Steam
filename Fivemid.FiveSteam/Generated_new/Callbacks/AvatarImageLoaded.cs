using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AvatarImageLoaded_t</summary>
    public unsafe struct AvatarImageLoaded
    {
        /// <summary>CSteamID m_steamID</summary>
        public SteamId steamID;
        /// <summary>int m_iImage</summary>
        public int iImage;
        /// <summary>int m_iWide</summary>
        public int iWide;
        /// <summary>int m_iTall</summary>
        public int iTall;
    }
}