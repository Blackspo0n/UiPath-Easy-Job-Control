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
    /// SetActiveParameters
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class SetActiveParameters :  IEquatable<SetActiveParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetActiveParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetActiveParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetActiveParameters" /> class.
        /// </summary>
        /// <param name="TenantIds">TenantIds (required).</param>
        /// <param name="Active">Active (required).</param>
        public SetActiveParameters(List<int?> TenantIds = default(List<int?>), bool? Active = default(bool?))
        {
            // to ensure "TenantIds" is required (not null)
            if (TenantIds == null)
            {
                throw new InvalidDataException("TenantIds is a required property for SetActiveParameters and cannot be null");
            }
            else
            {
                this.TenantIds = TenantIds;
            }
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for SetActiveParameters and cannot be null");
            }
            else
            {
                this.Active = Active;
            }
        }
        
        /// <summary>
        /// Gets or Sets TenantIds
        /// </summary>
        [DataMember(Name="tenantIds", EmitDefaultValue=false)]
        public List<int?> TenantIds { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetActiveParameters {\n");
            sb.Append("  TenantIds: ").Append(TenantIds).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as SetActiveParameters);
        }

        /// <summary>
        /// Returns true if SetActiveParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SetActiveParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetActiveParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantIds == input.TenantIds ||
                    this.TenantIds != null &&
                    this.TenantIds.SequenceEqual(input.TenantIds)
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
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
                if (this.TenantIds != null)
                    hashCode = hashCode * 59 + this.TenantIds.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
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