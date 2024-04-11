using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UserSubscribedItemsListChanged_t</summary>
    public unsafe struct UserSubscribedItemsListChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserSubscribedItemsListChanged;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
    }
}