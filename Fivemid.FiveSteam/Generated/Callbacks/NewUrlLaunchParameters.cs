using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Posted after the user executes a steam url with command line or query parameters such as <code class="bb_code bb_code_inline nohighlight">steam://run/&lt;appid&gt;//?param1=value1;param2=value2;param3=value3;</code> while the game is already running. The new params can be queried with <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetLaunchCommandLine" class="bb_apilink">ISteamApps::GetLaunchCommandLine</a> and <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetLaunchQueryParam" class="bb_apilink">ISteamApps::GetLaunchQueryParam</a>.<br />
    /// <br />
    /// This callback has no fields.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct NewUrlLaunchParameters
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.NewUrlLaunchParameters;
    }
}