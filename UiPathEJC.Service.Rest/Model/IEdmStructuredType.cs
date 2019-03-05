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
    /// IEdmStructuredType
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class IEdmStructuredType :  IEquatable<IEdmStructuredType>, IValidatableObject
    {
        /// <summary>
        /// Defines TypeKind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeKindEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum Primitive for value: Primitive
            /// </summary>
            [EnumMember(Value = "Primitive")]
            Primitive = 2,
            
            /// <summary>
            /// Enum Entity for value: Entity
            /// </summary>
            [EnumMember(Value = "Entity")]
            Entity = 3,
            
            /// <summary>
            /// Enum Complex for value: Complex
            /// </summary>
            [EnumMember(Value = "Complex")]
            Complex = 4,
            
            /// <summary>
            /// Enum Collection for value: Collection
            /// </summary>
            [EnumMember(Value = "Collection")]
            Collection = 5,
            
            /// <summary>
            /// Enum EntityReference for value: EntityReference
            /// </summary>
            [EnumMember(Value = "EntityReference")]
            EntityReference = 6,
            
            /// <summary>
            /// Enum Enum for value: Enum
            /// </summary>
            [EnumMember(Value = "Enum")]
            Enum = 7,
            
            /// <summary>
            /// Enum TypeDefinition for value: TypeDefinition
            /// </summary>
            [EnumMember(Value = "TypeDefinition")]
            TypeDefinition = 8,
            
            /// <summary>
            /// Enum Untyped for value: Untyped
            /// </summary>
            [EnumMember(Value = "Untyped")]
            Untyped = 9,
            
            /// <summary>
            /// Enum Path for value: Path
            /// </summary>
            [EnumMember(Value = "Path")]
            Path = 10
        }

        /// <summary>
        /// Gets or Sets TypeKind
        /// </summary>
        [DataMember(Name="TypeKind", EmitDefaultValue=false)]
        public TypeKindEnum? TypeKind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IEdmStructuredType" /> class.
        /// </summary>
        /// <param name="BaseType">BaseType.</param>
        /// <param name="DeclaredProperties">DeclaredProperties.</param>
        public IEdmStructuredType(IEdmStructuredType BaseType = default(IEdmStructuredType), List<IEdmProperty> DeclaredProperties = default(List<IEdmProperty>))
        {
            this.BaseType = BaseType;
            this.DeclaredProperties = DeclaredProperties;
        }
        
        /// <summary>
        /// Gets or Sets IsAbstract
        /// </summary>
        [DataMember(Name="IsAbstract", EmitDefaultValue=false)]
        public bool? IsAbstract { get; private set; }

        /// <summary>
        /// Gets or Sets IsOpen
        /// </summary>
        [DataMember(Name="IsOpen", EmitDefaultValue=false)]
        public bool? IsOpen { get; private set; }

        /// <summary>
        /// Gets or Sets BaseType
        /// </summary>
        [DataMember(Name="BaseType", EmitDefaultValue=false)]
        public IEdmStructuredType BaseType { get; set; }

        /// <summary>
        /// Gets or Sets DeclaredProperties
        /// </summary>
        [DataMember(Name="DeclaredProperties", EmitDefaultValue=false)]
        public List<IEdmProperty> DeclaredProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IEdmStructuredType {\n");
            sb.Append("  IsAbstract: ").Append(IsAbstract).Append("\n");
            sb.Append("  IsOpen: ").Append(IsOpen).Append("\n");
            sb.Append("  BaseType: ").Append(BaseType).Append("\n");
            sb.Append("  DeclaredProperties: ").Append(DeclaredProperties).Append("\n");
            sb.Append("  TypeKind: ").Append(TypeKind).Append("\n");
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
            return this.Equals(input as IEdmStructuredType);
        }

        /// <summary>
        /// Returns true if IEdmStructuredType instances are equal
        /// </summary>
        /// <param name="input">Instance of IEdmStructuredType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmStructuredType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAbstract == input.IsAbstract ||
                    (this.IsAbstract != null &&
                    this.IsAbstract.Equals(input.IsAbstract))
                ) && 
                (
                    this.IsOpen == input.IsOpen ||
                    (this.IsOpen != null &&
                    this.IsOpen.Equals(input.IsOpen))
                ) && 
                (
                    this.BaseType == input.BaseType ||
                    (this.BaseType != null &&
                    this.BaseType.Equals(input.BaseType))
                ) && 
                (
                    this.DeclaredProperties == input.DeclaredProperties ||
                    this.DeclaredProperties != null &&
                    this.DeclaredProperties.SequenceEqual(input.DeclaredProperties)
                ) && 
                (
                    this.TypeKind == input.TypeKind ||
                    (this.TypeKind != null &&
                    this.TypeKind.Equals(input.TypeKind))
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
                if (this.IsAbstract != null)
                    hashCode = hashCode * 59 + this.IsAbstract.GetHashCode();
                if (this.IsOpen != null)
                    hashCode = hashCode * 59 + this.IsOpen.GetHashCode();
                if (this.BaseType != null)
                    hashCode = hashCode * 59 + this.BaseType.GetHashCode();
                if (this.DeclaredProperties != null)
                    hashCode = hashCode * 59 + this.DeclaredProperties.GetHashCode();
                if (this.TypeKind != null)
                    hashCode = hashCode * 59 + this.TypeKind.GetHashCode();
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
