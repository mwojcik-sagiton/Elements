//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.24.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Elements
{
    #pragma warning disable // Disable all warnings

    using Elements.ElementTypes;
    using Elements.GeoJSON;
    using Elements.Geometry;
    using Elements.Geometry.Solids;
    using Elements.Properties;
    using Elements.Serialization.JSON;
    using System;
    using System.Collections.Generic;
    
    /// <summary>A material.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Material 
    {
        /// <summary>The name of the material.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  string Name { get; internal set; }
    
        /// <summary>The material's color.</summary>
        [Newtonsoft.Json.JsonProperty("Color", Required = Newtonsoft.Json.Required.AllowNull)]
        public  Color Color { get; internal set; }
    
        /// <summary>The material's specular factor.</summary>
        [Newtonsoft.Json.JsonProperty("SpecularFactor", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, 1)]
        public  double SpecularFactor { get; internal set; }
    
        /// <summary>The material's glossiness factor.</summary>
        [Newtonsoft.Json.JsonProperty("GlossinessFactor", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, 1)]
        public  double GlossinessFactor { get; internal set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new ModelConverter() });
        }
    
        public static Material FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Material>(data, new Newtonsoft.Json.JsonConverter[] { new ModelConverter() });
        }
    
    }
}