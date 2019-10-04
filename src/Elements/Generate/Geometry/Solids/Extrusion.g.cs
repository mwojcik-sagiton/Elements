//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.24.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Elements.Geometry.Solids
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
    
    /// <summary>An extrusion of a profile profile, in a direction, to a depth.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Extrusion : Solid
    {
        /// <summary>The profile to extrude.</summary>
        [Newtonsoft.Json.JsonProperty("Profile", Required = Newtonsoft.Json.Required.AllowNull)]
        public  Profile Profile { get; internal set; }
    
        /// <summary>The depth of the extrusion.</summary>
        [Newtonsoft.Json.JsonProperty("Depth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public  double Depth { get; internal set; }
    
        /// <summary>The direction in which to extrude.</summary>
        [Newtonsoft.Json.JsonProperty("Direction", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public  Vector3 Direction { get; internal set; } = new Vector3();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new ModelConverter() });
        }
    
        public static Extrusion FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Extrusion>(data, new Newtonsoft.Json.JsonConverter[] { new ModelConverter() });
        }
    
    }
}