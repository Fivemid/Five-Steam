using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fivemid.FiveSteam.Generator;

public class SteamApiDefinition {
    public static readonly SteamApiDefinition VALUE =
        JsonSerializer.Deserialize<SteamApiDefinition>(File.ReadAllText("Data/steam_api/steam_api.json"))!;
    
    public class Method {
        [JsonPropertyName("desc")]
        public string Description { get; set; }
        
        [JsonPropertyName("returntype")]
        public string ReturnType { get; set; }
        
        [JsonPropertyName("callresult")]
        public string CallResult { get; set; }
        
        public class Parameter {
            [JsonPropertyName("paramname")]
            public string Name { get; set; }
            
            [JsonPropertyName("paramtype")]
            public string Type { get; set; }
        }
        
        [JsonPropertyName("params")]
        public Parameter[] Parameters { get; set; }
        
        [JsonPropertyName("methodname")]
        public string Name { get; set; }
        
        [JsonPropertyName("methodname_flat")]
        public string FlatName { get; set; }
    }
    
    public class InterfaceDefinition {
        [JsonPropertyName("classname")]
        public string Name { get; set; }
        
        [JsonPropertyName("version_string")]
        public string VersionString { get; set; }
        
        [JsonPropertyName("methods")]
        public Method[] Methods { get; set; }
        
        public class Accessor {
            [JsonPropertyName("kind")]
            public string Kind { get; set; }
            
            [JsonPropertyName("name")]
            public string Name { get; set; }
            
            [JsonPropertyName("name_flat")]
            public string NameFlat { get; set; }
        }
        
        [JsonPropertyName("accessors")]
        public Accessor[]? Accessors { get; set; }
        
        [JsonPropertyName("enums")]
        public EnumDefinition[]? Enums { get; set; }
    }
    
    [JsonPropertyName("interfaces")]
    public InterfaceDefinition[] Interfaces { get; set; }
    
    
    public class EnumDefinition {
        public class EnumValue {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            
            [JsonPropertyName("value")]
            public string Value { get; set; }
        }
        
        [JsonPropertyName("enumname")]
        public string Name { get; set; }
        
        [JsonPropertyName("fqname")]
        public string QualifiedName { get; set; }
        
        [JsonPropertyName("values")]
        public EnumValue[] Values { get; set; }
    }
    
    [JsonPropertyName("enums")]
    public EnumDefinition[] Enums { get; set; }
    
    
    public class TypeDef {
        [JsonPropertyName("typedef")]
        public string Name { get; set; }
        
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
    
    [JsonPropertyName("typedefs")]
    public TypeDef[] TypeDefs { get; set; }
    
    public class StructDefinition {
        public class StructField {
            [JsonPropertyName("fieldname")]
            public string Name { get; set; }
            
            [JsonPropertyName("fieldtype")]
            public string Type { get; set; }
        }
        
        [JsonPropertyName("struct")]
        public string Name { get; set; }
        
        [JsonPropertyName("fields")]
        public StructField[] Fields { get; set; }
        
        [JsonPropertyName("methods")]
        public Method[]? Methods { get; set; }
        
        [JsonPropertyName("enums")]
        public EnumDefinition[]? Enums { get; set; }
        
        public bool IsPack4OnWindows {
            get {
                // 4/8 packing is irrevant to these classes
                if (Name.Contains("MatchMakingKeyValuePair_t")) return true;
                
                if (Fields.Skip(1).Any(x => x.Type.Contains("CSteamID")))
                    return true;
                
                if (Fields.Skip(1).Any(x => x.Type.Contains("CGameID")))
                    return true;
                
                return false;
            }
        }
    }
    
    [JsonPropertyName("structs")]
    public StructDefinition[] Structs { get; set; }
    
    public class CallbackStructDefinition : StructDefinition {
        [JsonPropertyName("callback_id")]
        public int CallbackId { get; set; }
    }
    
    [JsonPropertyName("callback_structs")]
    public CallbackStructDefinition[] CallbackStructs { get; set; }
    
    public class Const {
        [JsonPropertyName("consttype")]
        public string Type { get; set; }
        
        [JsonPropertyName("constname")]
        public string Name { get; set; }
        
        [JsonPropertyName("constval")]
        public string Value { get; set; }
    }
    
    [JsonPropertyName("consts")]
    public Const[] Constants { get; set; }
}