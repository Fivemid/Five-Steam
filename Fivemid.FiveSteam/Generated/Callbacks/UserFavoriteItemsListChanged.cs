using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UserFavoriteItemsListChanged_t</summary>
    public unsafe struct UserFavoriteItemsListChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserFavoriteItemsListChanged;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>bool m_bWasAddRequest</summary>
        public bool bWasAddRequest;
    }
}