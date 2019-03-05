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
    /// Used to store various predefined application configurations like time zone or account e-mail information.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class SettingsDto :  IEquatable<SettingsDto>, IValidatableObject
    {
        /// <summary>
        /// The scope of a specific setting.
        /// </summary>
        /// <value>The scope of a specific setting.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            
            /// <summary>
            /// Enum Application for value: Application
            /// </summary>
            [EnumMember(Value = "Application")]
            Application = 1,
            
            /// <summary>
            /// Enum Tenant for value: Tenant
            /// </summary>
            [EnumMember(Value = "Tenant")]
            Tenant = 2,
            
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 3,
            
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 4
        }

        /// <summary>
        /// The scope of a specific setting.
        /// </summary>
        /// <value>The scope of a specific setting.</value>
        [DataMember(Name="Scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsDto" /> class.
        /// </summary>
        /// <param name="Name">The name of a specific setting (e.g. Abp.Net.Mail.DefaultFromAddress). (required).</param>
        /// <param name="Value">The value assigned to a specific setting (e.g. admin@mydomain.com)..</param>
        /// <param name="Scope">The scope of a specific setting..</param>
        /// <param name="Id">Id.</param>
        public SettingsDto(string Name = default(string), string Value = default(string), ScopeEnum? Scope = default(ScopeEnum?), string Id = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for SettingsDto and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Value = Value;
            this.Scope = Scope;
            this.Id = Id;
        }
        
        /// <summary>
        /// The name of a specific setting (e.g. Abp.Net.Mail.DefaultFromAddress).
        /// </summary>
        /// <value>The name of a specific setting (e.g. Abp.Net.Mail.DefaultFromAddress).</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The value assigned to a specific setting (e.g. admin@mydomain.com).
        /// </summary>
        /// <value>The value assigned to a specific setting (e.g. admin@mydomain.com).</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as SettingsDto);
        }

        /// <summary>
        /// Returns true if SettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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