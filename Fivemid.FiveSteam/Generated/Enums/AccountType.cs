using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EAccountType</summary>
    public enum AccountType : int
    {
        /// <summary>k_EAccountTypeInvalid</summary>
        Invalid = 0,
        /// <summary>k_EAccountTypeIndividual</summary>
        Individual = 1,
        /// <summary>k_EAccountTypeMultiseat</summary>
        Multiseat = 2,
        /// <summary>k_EAccountTypeGameServer</summary>
        GameServer = 3,
        /// <summary>k_EAccountTypeAnonGameServer</summary>
        AnonGameServer = 4,
        /// <summary>k_EAccountTypePending</summary>
        Pending = 5,
        /// <summary>k_EAccountTypeContentServer</summary>
        ContentServer = 6,
        /// <summary>k_EAccountTypeClan</summary>
        Clan = 7,
        /// <summary>k_EAccountTypeChat</summary>
        Chat = 8,
        /// <summary>k_EAccountTypeConsoleUser</summary>
        ConsoleUser = 9,
        /// <summary>k_EAccountTypeAnonUser</summary>
        AnonUser = 10,
        /// <summary>k_EAccountTypeMax</summary>
        Max = 11
    }
}