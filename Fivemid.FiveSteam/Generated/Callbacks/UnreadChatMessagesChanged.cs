using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UnreadChatMessagesChanged_t</summary>
    public unsafe struct UnreadChatMessagesChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UnreadChatMessagesChanged;
    }
}