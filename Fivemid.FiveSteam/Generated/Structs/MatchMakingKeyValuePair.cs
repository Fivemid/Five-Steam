using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Store key/value pair used in matchmaking queries.<br />
    /// <br />
    /// Actually, the name Key/Value is a bit misleading. The "key" is better understood as "filter operation code" and the "value" is the operand to this filter operation. The meaning of the operand depends upon the filter.<br />
    /// <br />
    /// Supported filter operation codes:<br />
    /// <ul class="bb_ul ">    <li> "map"<br />
    ///         Server passes the filter if the server is playing the specified map.<br />
    ///     </li><li> "gamedataand"<br />
    ///         Server passes the filter if the server's game data (<a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameData" class="bb_apilink">ISteamGameServer::SetGameData</a>) contains all of the specified strings. The value field is a comma-delimited list of strings to match.<br />
    ///     </li><li> "gamedataor"<br />
    ///         Server passes the filter if the server's game data (<a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameData" class="bb_apilink">ISteamGameServer::SetGameData</a>) contains at least one of the specified strings. The value field is a comma-delimited list of strings to match.<br />
    ///     </li><li> "gamedatanor"<br />
    ///         Server passes the filter if the server's game data (<a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameData" class="bb_apilink">ISteamGameServer::SetGameData</a>) does not contain any of the specified strings. The value field is a comma-delimited list of strings to check.<br />
    ///     </li><li> "gametagsand"<br />
    ///         Server passes the filter if the server's game tags (<a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameTags" class="bb_apilink">ISteamGameServer::SetGameTags</a>) contains all of the specified strings. The value field is a comma-delimited list of strings to check.<br />
    ///     </li><li> "gametagsnor"<br />
    ///     Server passes the filter if the server's game tags (<a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetGameTags" class="bb_apilink">ISteamGameServer::SetGameTags</a>) does not contain any of the specified strings. The value field is a comma-delimited list of strings to check.<br />
    ///     </li><li> "and" (x1 &amp;&amp; x2 &amp;&amp; ... &amp;&amp; xn)<br />
    ///         "or" (x1 || x2 || ... || xn)<br />
    ///         "nand" !(x1 &amp;&amp; x2 &amp;&amp; ... &amp;&amp; xn)<br />
    ///         "nor" !(x1 || x2 || ... || xn)<br />
    ///         Performs Boolean operation on the following filters. The operand to this filter specifies the "size" of the Boolean inputs to the operation, in Key/value pairs. (The keyvalue pairs must immediately follow, i.e. this is a prefix logical operator notation.) In the simplest case where Boolean expressions are not nested, this is simply the number of operands.<br />
    ///         For example, to match servers on a particular map or with a particular tag, would would use these filters.<br />
    /// <code>( server.map == "cp_dustbowl" || server.gametags.contains("payload") )
    /// "or", "2"
    /// "map", "cp_dustbowl"
    /// "gametagsand", "payload"
    /// </code><br />
    ///     If logical inputs are nested, then the operand specifies the size of the entire "length" of its operands, not the number of immediate children like so.<br />
    /// <code>( server.map == "cp_dustbowl" || ( server.gametags.contains("payload") &amp;&amp; !server.gametags.contains("payloadrace") ) )
    /// "or", "4"
    /// "map", "cp_dustbowl"
    /// "and", "2"
    /// "gametagsand", "payload"
    /// "gametagsnor", "payloadrace"
    /// </code>    Unary NOT can be achieved using either "nand" or "nor" with a single operand.<br />
    /// <br />
    ///     </li><li> "addr"<br />
    ///         Server passes the filter if the server's query address matches the specified IP or IP:port.<br />
    ///     </li><li> "gameaddr"<br />
    ///         Server passes the filter if the server's game address matches the specified IP or IP:port.</li></ul><br />
    /// The following filter operations ignore the "value" part of MatchMakingKeyValuePair_t<br />
    /// <ul class="bb_ul ">    <li> "dedicated"<br />
    ///         Server passes the filter if it passed <b>true</b> to <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetDedicatedServer" class="bb_apilink">ISteamGameServer::SetDedicatedServer</a>.<br />
    ///     </li><li> "secure"<br />
    ///         Server passes the filter if the server is VAC-enabled.<br />
    ///     </li><li> "notfull"<br />
    ///         Server passes the filter if the player count is less than the reported max player count.<br />
    ///     </li><li> "hasplayers"<br />
    ///         Server passes the filter if the player count is greater than zero.<br />
    ///     </li><li> "noplayers"<br />
    ///         Server passes the filter if it doesn't have any players.<br />
    ///     </li><li> "linux"<br />
    ///         Server passes the filter if it's a linux server.</li></ul><br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct MatchMakingKeyValuePair
    {
        /// <summary>Filter operation code.</summary>
        public UTF8String256 szKey;
        /// <summary>Operation operand.</summary>
        public UTF8String256 szValue;
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_MatchMakingKeyValuePair_t_Construct", CallingConvention = Platform.CC)]
        internal static extern void Construct(MatchMakingKeyValuePair* self);
        public void Construct()
        {
            fixed (MatchMakingKeyValuePair* self = &this)
                Construct(self);
        }
    }
}