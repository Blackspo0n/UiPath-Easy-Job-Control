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
    /// Stores data about a version of the various versions of the process associated with a certain release.  &lt;para /&gt;If a certain version is associated on and off with a release a new ReleaseVersion object is created for each association.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class ReleaseVersionDto :  IEquatable<ReleaseVersionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseVersionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReleaseVersionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseVersionDto" /> class.
        /// </summary>
        /// <param name="ReleaseId">The Id of the parent release. (required).</param>
        /// <param name="VersionNumber">The version of process associated with the release. (required).</param>
        /// <param name="CreationTime">The date and time when the version was associated with the release..</param>
        /// <param name="Id">Id.</param>
        public ReleaseVersionDto(long? ReleaseId = default(long?), string VersionNumber = default(string), DateTime? CreationTime = default(DateTime?), long? Id = default(long?))
        {
            // to ensure "ReleaseId" is required (not null)
            if (ReleaseId == null)
            {
                throw new InvalidDataException("ReleaseId is a required property for ReleaseVersionDto and cannot be null");
            }
            else
            {
                this.ReleaseId = ReleaseId;
            }
            // to ensure "VersionNumber" is required (not null)
            if (VersionNumber == null)
            {
                throw new InvalidDataException("VersionNumber is a required property for ReleaseVersionDto and cannot be null");
            }
            else
            {
                this.VersionNumber = VersionNumber;
            }
            this.CreationTime = CreationTime;
            this.Id = Id;
        }
        
        /// <summary>
        /// The Id of the parent release.
        /// </summary>
        /// <value>The Id of the parent release.</value>
        [DataMember(Name="ReleaseId", EmitDefaultValue=false)]
        public long? ReleaseId { get; set; }

        /// <summary>
        /// The version of process associated with the release.
        /// </summary>
        /// <value>The version of process associated with the release.</value>
        [DataMember(Name="VersionNumber", EmitDefaultValue=false)]
        public string VersionNumber { get; set; }

        /// <summary>
        /// The date and time when the version was associated with the release.
        /// </summary>
        /// <value>The date and time when the version was associated with the release.</value>
        [DataMember(Name="CreationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }

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
            sb.Append("class ReleaseVersionDto {\n");
            sb.Append("  ReleaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
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
            return this.Equals(input as ReleaseVersionDto);
        }

        /// <summary>
        /// Returns true if ReleaseVersionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseVersionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseVersionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReleaseId == input.ReleaseId ||
                    (this.ReleaseId != null &&
                    this.ReleaseId.Equals(input.ReleaseId))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
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
                if (this.ReleaseId != null)
                    hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.VersionNumber != null)
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
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
