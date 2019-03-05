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
    /// ODataQueryContext
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class ODataQueryContext :  IEquatable<ODataQueryContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataQueryContext" /> class.
        /// </summary>
        /// <param name="DefaultQuerySettings">DefaultQuerySettings.</param>
        /// <param name="Model">Model.</param>
        /// <param name="ElementType">ElementType.</param>
        /// <param name="NavigationSource">NavigationSource.</param>
        /// <param name="Path">Path.</param>
        /// <param name="RequestContainer">RequestContainer.</param>
        public ODataQueryContext(DefaultQuerySettings DefaultQuerySettings = default(DefaultQuerySettings), IEdmModel Model = default(IEdmModel), IEdmType ElementType = default(IEdmType), IEdmNavigationSource NavigationSource = default(IEdmNavigationSource), ODataPath Path = default(ODataPath), IServiceProvider RequestContainer = default(IServiceProvider))
        {
            this.DefaultQuerySettings = DefaultQuerySettings;
            this.Model = Model;
            this.ElementType = ElementType;
            this.NavigationSource = NavigationSource;
            this.Path = Path;
            this.RequestContainer = RequestContainer;
        }
        
        /// <summary>
        /// Gets or Sets DefaultQuerySettings
        /// </summary>
        [DataMember(Name="DefaultQuerySettings", EmitDefaultValue=false)]
        public DefaultQuerySettings DefaultQuerySettings { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="Model", EmitDefaultValue=false)]
        public IEdmModel Model { get; set; }

        /// <summary>
        /// Gets or Sets ElementType
        /// </summary>
        [DataMember(Name="ElementType", EmitDefaultValue=false)]
        public IEdmType ElementType { get; set; }

        /// <summary>
        /// Gets or Sets NavigationSource
        /// </summary>
        [DataMember(Name="NavigationSource", EmitDefaultValue=false)]
        public IEdmNavigationSource NavigationSource { get; set; }

        /// <summary>
        /// Gets or Sets ElementClrType
        /// </summary>
        [DataMember(Name="ElementClrType", EmitDefaultValue=false)]
        public string ElementClrType { get; private set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public ODataPath Path { get; set; }

        /// <summary>
        /// Gets or Sets RequestContainer
        /// </summary>
        [DataMember(Name="RequestContainer", EmitDefaultValue=false)]
        public IServiceProvider RequestContainer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ODataQueryContext {\n");
            sb.Append("  DefaultQuerySettings: ").Append(DefaultQuerySettings).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ElementType: ").Append(ElementType).Append("\n");
            sb.Append("  NavigationSource: ").Append(NavigationSource).Append("\n");
            sb.Append("  ElementClrType: ").Append(ElementClrType).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  RequestContainer: ").Append(RequestContainer).Append("\n");
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
            return this.Equals(input as ODataQueryContext);
        }

        /// <summary>
        /// Returns true if ODataQueryContext instances are equal
        /// </summary>
        /// <param name="input">Instance of ODataQueryContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ODataQueryContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultQuerySettings == input.DefaultQuerySettings ||
                    (this.DefaultQuerySettings != null &&
                    this.DefaultQuerySettings.Equals(input.DefaultQuerySettings))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.ElementType == input.ElementType ||
                    (this.ElementType != null &&
                    this.ElementType.Equals(input.ElementType))
                ) && 
                (
                    this.NavigationSource == input.NavigationSource ||
                    (this.NavigationSource != null &&
                    this.NavigationSource.Equals(input.NavigationSource))
                ) && 
                (
                    this.ElementClrType == input.ElementClrType ||
                    (this.ElementClrType != null &&
                    this.ElementClrType.Equals(input.ElementClrType))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.RequestContainer == input.RequestContainer ||
                    (this.RequestContainer != null &&
                    this.RequestContainer.Equals(input.RequestContainer))
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
                if (this.DefaultQuerySettings != null)
                    hashCode = hashCode * 59 + this.DefaultQuerySettings.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.ElementType != null)
                    hashCode = hashCode * 59 + this.ElementType.GetHashCode();
                if (this.NavigationSource != null)
                    hashCode = hashCode * 59 + this.NavigationSource.GetHashCode();
                if (this.ElementClrType != null)
                    hashCode = hashCode * 59 + this.ElementClrType.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.RequestContainer != null)
                    hashCode = hashCode * 59 + this.RequestContainer.GetHashCode();
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
