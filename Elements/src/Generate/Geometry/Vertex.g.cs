//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Geometry.Solids
{
#pragma warning disable // Disable all warnings

    /// <summary>A mesh vertex.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    [UserElement]
    public partial class Vertex
    {
        [Newtonsoft.Json.JsonConstructor]
        public Vertex(Vector3 @position, Vector3 @normal, Color @color, int @index, UV @uV)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Vertex>
            ();
            if (validator != null)
            {
                validator.PreConstruct(new object[] { @position, @normal, @color, @index, @uV });
            }

            this.Position = @position;
            this.Normal = @normal;
            this.Color = @color;
            this.Index = @index;
            this.UV = @uV;

            if (validator != null)
            {
                validator.PostConstruct(this);
            }
        }

        /// <summary>The position of the vertex.</summary>
        [Newtonsoft.Json.JsonProperty("Position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 Position { get; set; }

        /// <summary>The vertex's normal.</summary>
        [Newtonsoft.Json.JsonProperty("Normal", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 Normal { get; set; }

        /// <summary>The vertex's color.</summary>
        [Newtonsoft.Json.JsonProperty("Color", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color Color { get; set; }

        /// <summary>The index of the vertex within a mesh.</summary>
        [Newtonsoft.Json.JsonProperty("Index", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Index { get; set; }

        /// <summary>The texture coordinate of the vertex</summary>
        [Newtonsoft.Json.JsonProperty("UV", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UV UV { get; set; }


    }
}