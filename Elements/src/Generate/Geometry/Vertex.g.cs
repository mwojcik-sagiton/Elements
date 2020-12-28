//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v11.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Geometry
{
    #pragma warning disable // Disable all warnings

    /// <summary>A mesh vertex.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Vertex 
    {
        [Newtonsoft.Json.JsonConstructor]
        public Vertex(Vector3 @position, Vector3 @normal, Color @color, int @index, UV @uV)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Vertex>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @position, @normal, @color, @index, @uV});
            }
        
            this.Position = @position;
            this.Normal = @normal;
            this.Color = @color;
            this.Index = @index;
            this.UV = @uV;
            
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The vertex's position.</summary>
        [Newtonsoft.Json.JsonProperty("Position", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Position { get; set; }
    
        /// <summary>The vertex's normal.</summary>
        [Newtonsoft.Json.JsonProperty("Normal", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Normal { get; set; }
    
        /// <summary>The vertex's color.</summary>
        [Newtonsoft.Json.JsonProperty("Color", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Color Color { get; set; } = new Color();
    
        /// <summary>The index of the vertex within a mesh.</summary>
        [Newtonsoft.Json.JsonProperty("Index", Required = Newtonsoft.Json.Required.Always)]
        public int Index { get; set; }
    
        /// <summary>The vertex's texture coordinate.</summary>
        [Newtonsoft.Json.JsonProperty("UV", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public UV UV { get; set; } = new UV();
    
    
    }
}