using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public static partial class Convert {
    private static readonly Dictionary<string, TypeSyntax> primitiveTypeMapping = new List<(string key, string value)> {
        ("int8", "sbyte"),
        ("uint8", "byte"),
        ("int16", "short"),
        ("uint16", "ushort"),
        ("int32", "int"),
        ("int32_t", "int"),
        ("uint32", "uint"),
        ("int64", "long"),
        ("int64_t", "long"),
        ("uint64", "ulong"),
        ("intp", "long"),
        ("uintp", "ulong"),
        ("intptr_t", "IntPtr"),
        ("size_t", "int"),

        ("signed char", "sbyte"),
        ("unsigned char", "byte"),
        ("short", "short"),
        ("unsigned short", "ushort"),
        ("int", "int"),
        ("unsigned int", "uint"),
        ("long long", "long"),
        ("unsigned long long", "ulong")
    }.ToDictionary(x => x.key, x => ParseTypeName(x.value));

    private static readonly Dictionary<string, TypeSyntax> customTypeMapping = new List<(string key, string value)> {
        ("CSteamID", "SteamId"),
        ("CGameID", "GameId"),
        ("const char *", "UTF8StringPtr"),
        ("ScePadTriggerEffectParam", "Unknown"),
        ("SteamDatagramRelayAuthTicket", "Unknown"),
        ("ISteamNetworkingConnectionSignaling", "Unknown"),
        ("ISteamNetworkingSignalingRecvContext", "Unknown"),
        ("SteamAPIWarningMessageHook_t", "Unknown"),
    }.ToDictionary(x => x.key, x => ParseTypeName(x.value));

    private static readonly Dictionary<string, TypeSyntax> typeDefs = new List<(string key, string value)> {
        ("SteamId", "ulong")
    }.ToDictionary(x => x.key, x => ParseTypeName(x.value));

    private static readonly Dictionary<string, TypeSyntax> createdTypes = new();

    public static readonly HashSet<UTF8StringType>      seenUTF8StringTypes      = [];
    public static readonly HashSet<FunctionPointerType> seenFunctionPointerTypes = [];
    public static readonly HashSet<FixedArrayType>      seenFixedArrayTypes      = [];

    public static void RegisterType(string nativeName, TypeSyntax type) {
        createdTypes.Add(nativeName, type);
    }

    public static void RegisterTypeDef(TypeSyntax wrapper, TypeSyntax inner) {
        typeDefs.Add(wrapper.ToString(), inner);
    }

    public static bool IsPrimitive(this string type) => primitiveTypeMapping.ContainsKey(type);

    public static TypeSyntax ToPrimitive(this TypeSyntax type) =>
        typeDefs.GetValueOrDefault(type.ToString(), type);

    public static TypeSyntax ToType(this string type) {
        if (primitiveTypeMapping.TryGetValue(type.Trim(), out TypeSyntax? typeResult))
            return typeResult;
        if (customTypeMapping.TryGetValue(type.Trim(), out typeResult))
            return typeResult;
        if (createdTypes.TryGetValue(type.Trim(), out typeResult))
            return typeResult;

        { // UTF8String
            Match match = CharArrayRegex().Match(type);
            if (match.Success) {
                UTF8StringType utf8StringType = new(int.Parse(match.Groups[1].Value),
                                                    type);
                seenUTF8StringTypes.Add(utf8StringType);
                return utf8StringType.ToType();
            }
        }

        { // FunctionPointer
            Match match = FunctionPointerRegex().Match(type);
            if (match.Success) {
                FunctionPointerType functionPointerType =
                    new(match.Groups[1].Value.Split(", ").Select(ToType).ToArray(),
                        type);
                seenFunctionPointerTypes.Add(functionPointerType);
                return functionPointerType.ToType();
            }
        }

        { // Pointer
            Match match = PointerRegex().Match(type);
            if (match.Success) {
                return PointerType(match.Groups[1].Value.ToType());
            }
        }

        { // FixedArray
            Match match = FixedArrayRegex().Match(type);
            if (match.Success) {
                FixedArrayType fixedArrayType = new(match.Groups[1].Value.ToType().ToPrimitive(),
                                                    int.Parse(match.Groups[2].Value),
                                                    type);
                seenFixedArrayTypes.Add(fixedArrayType);
                return fixedArrayType.ToType();
            }
        }

        {
            if (type.Contains("const ")) {
                return type.Replace("const ", "").ToType();
            }
        }

        {
            if (type.EndsWith("&")) {
                return type.StripSuffix("&").ToType();
            }
        }

        return ParseTypeName(type);
    }

    public static ExpressionSyntax ToInitializerValue(this string value) =>
        ParseExpression(value.Replace("ull", "ul"));

    public static string StripPrefix(this string value, string prefix) {
        if (value.StartsWith(prefix))
            return value[prefix.Length..];

        return value;
    }

    public static string StripSuffix(this string value, string suffix) {
        if (value.EndsWith(suffix))
            return value[..^suffix.Length];

        return value;
    }

    public static string PreventStartByDigit(this string value, string prefix = "_") {
        if (StartByDigitRegex().IsMatch(value))
            return $"{prefix}{value}";

        return value;
    }

    [GeneratedRegex(@"^\d")]
    private static partial Regex StartByDigitRegex();

    [GeneratedRegex(@"^char \[(\d+)\]$")]
    private static partial Regex CharArrayRegex();

    [GeneratedRegex(@"^void \(\*\)\((.+)\)$")]
    private static partial Regex FunctionPointerRegex();

    [GeneratedRegex(@"^(.+)\*$")]
    private static partial Regex PointerRegex();

    [GeneratedRegex(@"^(.+)\[(\d+)\]$")]
    private static partial Regex FixedArrayRegex();
}