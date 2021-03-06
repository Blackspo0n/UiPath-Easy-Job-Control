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
    /// IEdmEntityContainerElement
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class IEdmEntityContainerElement :  IEquatable<IEdmEntityContainerElement>, IValidatableObject
    {
        /// <summary>
        /// Defines ContainerElementKind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContainerElementKindEnum
        {
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,
            
            /// <summary>
            /// Enum EntitySet for value: EntitySet
            /// </summary>
            [EnumMember(Value = "EntitySet")]
            EntitySet = 2,
            
            /// <summary>
            /// Enum ActionImport for value: ActionImport
            /// </summary>
            [EnumMember(Value = "ActionImport")]
            ActionImport = 3,
            
            /// <summary>
            /// Enum FunctionImport for value: FunctionImport
            /// </summary>
            [EnumMember(Value = "FunctionImport")]
            FunctionImport = 4,
            
            /// <summary>
            /// Enum Singleton for value: Singleton
            /// </summary>
            [EnumMember(Value = "Singleton")]
            Singleton = 5
        }

        /// <summary>
        /// Gets or Sets ContainerElementKind
        /// </summary>
        [DataMember(Name="ContainerElementKind", EmitDefaultValue=false)]
        public ContainerElementKindEnum? ContainerElementKind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IEdmEntityContainerElement" /> class.
        /// </summary>
        /// <param name="Container">Container.</param>
        public IEdmEntityContainerElement(IEdmEntityContainer Container = default(IEdmEntityContainer))
        {
            this.Container = Container;
        }
        

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [DataMember(Name="Container", EmitDefaultValue=false)]
        public IEdmEntityContainer Container { get; set; }

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
            sb.Append("class IEdmEntityContainerElement {\n");
            sb.Append("  ContainerElementKind: ").Append(ContainerElementKind).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
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
            return this.Equals(input as IEdmEntityContainerElement);
        }

        /// <summary>
        /// Returns true if IEdmEntityContainerElement instances are equal
        /// </summary>
        /// <param name="input">Instance of IEdmEntityContainerElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmEntityContainerElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerElementKind == input.ContainerElementKind ||
                    (this.ContainerElementKind != null &&
                    this.ContainerElementKind.Equals(input.ContainerElementKind))
                ) && 
                (
                    this.Container == input.Container ||
                    (this.Container != null &&
                    this.Container.Equals(input.Container))
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
                if (this.ContainerElementKind != null)
                    hashCode = hashCode * 59 + this.ContainerElementKind.GetHashCode();
                if (this.Container != null)
                    hashCode = hashCode * 59 + this.Container.GetHashCode();
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
