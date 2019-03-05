/* 
 * UiPath.WebApi
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: V2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = UiPathEJC.Service.Rest.Client.SwaggerDateConverter;

namespace UiPathEJC.Service.Rest.Model
{
    /// <summary>
    /// IEdmProperty
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class IEdmProperty :  IEquatable<IEdmProperty>, IValidatableObject
    {
        /// <summary>
        /// Defines PropertyKind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PropertyKindEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Structural for value: Structural
            /// </summary>
            [EnumMember(Value = "Structural")]
            Structural = 2,
            
            /// <summary>
            /// Enum Navigation for value: Navigation
            /// </summary>
            [EnumMember(Value = "Navigation")]
            Navigation = 3
        }

        /// <summary>
        /// Gets or Sets PropertyKind
        /// </summary>
        [DataMember(Name="PropertyKind", EmitDefaultValue=false)]
        public PropertyKindEnum? PropertyKind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IEdmProperty" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="DeclaringType">DeclaringType.</param>
        public IEdmProperty(IEdmTypeReference Type = default(IEdmTypeReference), IEdmStructuredType DeclaringType = default(IEdmStructuredType))
        {
            this.Type = Type;
            this.DeclaringType = DeclaringType;
        }
        

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public IEdmTypeReference Type { get; set; }

        /// <summary>
        /// Gets or Sets DeclaringType
        /// </summary>
        [DataMember(Name="DeclaringType", EmitDefaultValue=false)]
        public IEdmStructuredType DeclaringType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmProperty {\n");
            sb.Append("  PropertyKind: ").Append(PropertyKind).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DeclaringType: ").Append(DeclaringType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IEdmProperty);
        }

        /// <summary>
        /// Returns true if IEdmProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of IEdmProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyKind == input.PropertyKind ||
                    (this.PropertyKind != null &&
                    this.PropertyKind.Equals(input.PropertyKind))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DeclaringType == input.DeclaringType ||
                    (this.DeclaringType != null &&
                    this.DeclaringType.Equals(input.DeclaringType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PropertyKind != null)
                    hashCode = hashCode * 59 + this.PropertyKind.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeclaringType != null)
                    hashCode = hashCode * 59 + this.DeclaringType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
