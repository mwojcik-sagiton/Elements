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

namespace Elements.Properties
{
    #pragma warning disable // Disable all warnings

    /// <summary>A property with a numeric value.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NumericProperty : System.ComponentModel.INotifyPropertyChanged
    {
        private double _value;
        private NumericPropertyUnitType _unitType;
    
        [Newtonsoft.Json.JsonConstructor]
        public NumericProperty(double @value, NumericPropertyUnitType @unitType)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<NumericProperty>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @value, @unitType});
            }
        
            this.Value = @value;
            this.UnitType = @unitType;
            
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The property's value</summary>
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.Always)]
        public double Value
        {
            get { return _value; }
            set 
            {
                if (_value != value)
                {
                    _value = value; 
                    RaisePropertyChanged();
                }
            }
        }
    
        /// <summary>The property's unit type.</summary>
        [Newtonsoft.Json.JsonProperty("UnitType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public NumericPropertyUnitType UnitType
        {
            get { return _unitType; }
            set 
            {
                if (_unitType != value)
                {
                    _unitType = value; 
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