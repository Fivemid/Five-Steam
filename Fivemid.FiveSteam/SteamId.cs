﻿using System;
using Unity.Collections;

namespace Fivemid.FiveSteam {
    public struct SteamId : IEquatable<SteamId>, IComparable<SteamId> {
        public ulong value;
        
        public AccountID AccountId =>
            (uint)new BitField64(value).GetBits(0, 32);
        
        public uint AccountInstance =>
            (uint)new BitField64(value).GetBits(32, 20);
        
        public AccountType AccountType =>
            (AccountType)new BitField64(value).GetBits(52, 4);
        
        public Universe Universe =>
            (Universe)new BitField64(value).GetBits(56, 8);
        
        public bool IsValid {
            get {
                if (AccountType is <= AccountType.Invalid or >= AccountType.Max)
                    return false;
                if (Universe is <= Universe.Invalid or >= Universe.Max)
                    return false;
                switch (AccountType) {
                    case AccountType.Individual:
                        if (AccountId       == FiveSteamConstants.k_uAccountIdInvalid
                         || AccountInstance != FiveSteamConstants.k_unSteamUserDefaultInstance)
                            return false;
                        break;
                    
                    case AccountType.Clan:
                        if (AccountId       == FiveSteamConstants.k_uAccountIdInvalid
                         || AccountInstance != 0)
                            return false;
                        break;
                    
                    case AccountType.GameServer:
                        if (AccountId == FiveSteamConstants.k_uAccountIdInvalid)
                            return false;
                        break;
                }
                
                return true;
            }
        }
        
        public          bool Equals(SteamId other)                    => value == other.value;
        public override int  GetHashCode()                            => value.GetHashCode();
        public override bool Equals(object       obj)                 => obj is SteamId other && Equals(other);
        public static   bool operator ==(SteamId left, SteamId right) => left.Equals(right);
        public static   bool operator !=(SteamId left, SteamId right) => !left.Equals(right);
        public          int CompareTo(SteamId    other) => value.CompareTo(other.value);
    }
}