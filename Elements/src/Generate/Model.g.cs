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

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A container of elements.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Model : System.ComponentModel.INotifyPropertyChanged
    {
        private Position _origin;
        private Transform _transform;
        private System.Collections.Generic.IDictionary<Guid, Element> _elements = new System.Collections.Generic.Dictionary<Guid, Element>();
    
        [Newtonsoft.Json.JsonConstructor]
        public Model(Position @origin, Transform @transform, System.Collections.Generic.IDictionary<Guid, Element> @elements)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Model>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @origin, @transform, @elements});
            }
        
            this.Origin = @origin;
            this.Transform = @transform;
            this.Elements = @elements;
            
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The origin of the model.</summary>
        [Newtonsoft.Json.JsonProperty("Origin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Position Origin
        {
            get { return _origin; }
            set 
            {
                if (_origin != value)
                {
                    _origin = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>The transform of the model.</summary>
        [Newtonsoft.Json.JsonProperty("Transform", Required = Newtonsoft.Json.Required.AllowNull)]
        public Transform Transform
        {
            get { return _transform; }
            set 
            {
                if (_transform != value)
                {
                    _transform = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>A collection of Elements keyed by their identifiers.</summary>
        [Newtonsoft.Json.JsonProperty("Elements", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.IDictionary<Guid, Element> Elements
        {
            get { return _elements; }
            set 
            {
                if (_elements != value)
                {
                    _elements = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
    
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    
    }
}