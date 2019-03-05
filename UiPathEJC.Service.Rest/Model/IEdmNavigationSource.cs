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
    /// IEdmNavigationSource
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class IEdmNavigationSource :  IEquatable<IEdmNavigationSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IEdmNavigationSource" /> class.
        /// </summary>
        /// <param name="NavigationPropertyBindings">NavigationPropertyBindings.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Type">Type.</param>
        public IEdmNavigationSource(List<IEdmNavigationPropertyBinding> NavigationPropertyBindings = default(List<IEdmNavigationPropertyBinding>), IEdmPathExpression Path = default(IEdmPathExpression), IEdmType Type = default(IEdmType))
        {
            this.NavigationPropertyBindings = NavigationPropertyBindings;
            this.Path = Path;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets NavigationPropertyBindings
        /// </summary>
        [DataMember(Name="NavigationPropertyBindings", EmitDefaultValue=false)]
        public List<IEdmNavigationPropertyBinding> NavigationPropertyBindings { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public IEdmPathExpression Path { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public IEdmType Type { get; set; }

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
            sb.Append("class IEdmNavigationSource {\n");
            sb.Append("  NavigationPropertyBindings: ").Append(NavigationPropertyBindings).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as IEdmNavigationSource);
        }

        /// <summary>
        /// Returns true if IEdmNavigationSource instances are equal
        /// </summary>
        /// <param name="input">Instance of IEdmNavigationSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IEdmNavigationSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NavigationPropertyBindings == input.NavigationPropertyBindings ||
                    this.NavigationPropertyBindings != null &&
                    this.NavigationPropertyBindings.SequenceEqual(input.NavigationPropertyBindings)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.NavigationPropertyBindings != null)
                    hashCode = hashCode * 59 + this.NavigationPropertyBindings.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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