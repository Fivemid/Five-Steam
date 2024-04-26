using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Sent to your game in response to a steam://gamewebcallback/ command from a user clicking a link in the Steam overlay browser.<br />
    /// You can use this to add support for external site signups where you want to pop back into the browser after some web page signup sequence, and optionally get back some detail about that.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GameWebCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameWebCallback;
        /// <summary>The complete url that the user clicked on.</summary>
        public UTF8String256 szURL;
    }
}