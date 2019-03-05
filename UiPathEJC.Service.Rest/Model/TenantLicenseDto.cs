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
    /// TenantLicenseDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class TenantLicenseDto :  IEquatable<TenantLicenseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantLicenseDto" /> class.
        /// </summary>
        /// <param name="HostLicenseId">The host license Id..</param>
        /// <param name="CreationTime">The date it was uploaded..</param>
        /// <param name="Code">The license code..</param>
        /// <param name="Allowed">Contains the number of allowed licenses for each type.</param>
        /// <param name="Id">Id.</param>
        public TenantLicenseDto(long? HostLicenseId = default(long?), DateTime? CreationTime = default(DateTime?), string Code = default(string), LicenseFields Allowed = default(LicenseFields), long? Id = default(long?))
        {
            this.HostLicenseId = HostLicenseId;
            this.CreationTime = CreationTime;
            this.Code = Code;
            this.Allowed = Allowed;
            this.Id = Id;
        }
        
        /// <summary>
        /// The host license Id.
        /// </summary>
        /// <value>The host license Id.</value>
        [DataMember(Name="HostLicenseId", EmitDefaultValue=false)]
        public long? HostLicenseId { get; set; }

        /// <summary>
        /// The date it was uploaded.
        /// </summary>
        /// <value>The date it was uploaded.</value>
        [DataMember(Name="CreationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// The license code.
        /// </summary>
        /// <value>The license code.</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Contains the number of allowed licenses for each type
        /// </summary>
        /// <value>Contains the number of allowed licenses for each type</value>
        [DataMember(Name="Allowed", EmitDefaultValue=false)]
        public LicenseFields Allowed { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantLicenseDto {\n");
            sb.Append("  HostLicenseId: ").Append(HostLicenseId).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
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
            return this.Equals(input as TenantLicenseDto);
        }

        /// <summary>
        /// Returns true if TenantLicenseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantLicenseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantLicenseDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostLicenseId == input.HostLicenseId ||
                    (this.HostLicenseId != null &&
                    this.HostLicenseId.Equals(input.HostLicenseId))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Allowed == input.Allowed ||
                    (this.Allowed != null &&
                    this.Allowed.Equals(input.Allowed))
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
                if (this.HostLicenseId != null)
                    hashCode = hashCode * 59 + this.HostLicenseId.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Allowed != null)
                    hashCode = hashCode * 59 + this.Allowed.GetHashCode();
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
