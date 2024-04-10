using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EPersonaChange</summary>
    public enum PersonaChange : int
    {
        /// <summary>k_EPersonaChangeName</summary>
        Name = 1,
        /// <summary>k_EPersonaChangeStatus</summary>
        Status = 2,
        /// <summary>k_EPersonaChangeComeOnline</summary>
        ComeOnline = 4,
        /// <summary>k_EPersonaChangeGoneOffline</summary>
        GoneOffline = 8,
        /// <summary>k_EPersonaChangeGamePlayed</summary>
        GamePlayed = 16,
        /// <summary>k_EPersonaChangeGameServer</summary>
        GameServer = 32,
        /// <summary>k_EPersonaChangeAvatar</summary>
        Avatar = 64,
        /// <summary>k_EPersonaChangeJoinedSource</summary>
        JoinedSource = 128,
        /// <summary>k_EPersonaChangeLeftSource</summary>
        LeftSource = 256,
        /// <summary>k_EPersonaChangeRelationshipChanged</summary>
        RelationshipChanged = 512,
        /// <summary>k_EPersonaChangeNameFirstSet</summary>
        NameFirstSet = 1024,
        /// <summary>k_EPersonaChangeBroadcast</summary>
        Broadcast = 2048,
        /// <summary>k_EPersonaChangeNickname</summary>
        Nickname = 4096,
        /// <summary>k_EPersonaChangeSteamLevel</summary>
        SteamLevel = 8192,
        /// <summary>k_EPersonaChangeRichPresence</summary>
        RichPresence = 16384
    }
}