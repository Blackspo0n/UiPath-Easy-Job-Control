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
    /// A release enables the assignment of a process to an environment.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class ReleaseDto :  IEquatable<ReleaseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReleaseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseDto" /> class.
        /// </summary>
        /// <param name="Key">A unique identifier associated to each release..</param>
        /// <param name="ProcessKey">The unique identifier of the process associated with the release. (required).</param>
        /// <param name="ProcessVersion">The version of the process associated with the release. (required).</param>
        /// <param name="IsLatestVersion">States whether the version of process associated with the release is latest or not..</param>
        /// <param name="IsProcessDeleted">States whether the process associated with the release is deleted or not..</param>
        /// <param name="Description">Used to add additional information about a release in order to better identify it..</param>
        /// <param name="Name">A custom name of the release. The default name format is ProcessName_EnvironmentName. (required).</param>
        /// <param name="EnvironmentId">The Id of the environment associated with the release. (required).</param>
        /// <param name="EnvironmentName">The name of the environment associated with the release..</param>
        /// <param name="Environment">The environment associated with the release..</param>
        /// <param name="InputArguments">Input parameters in JSON format to be passed as default values to job execution..</param>
        /// <param name="CurrentVersion">The release version associated with the current release..</param>
        /// <param name="ReleaseVersions">The collection of release versions that current release had over time..</param>
        /// <param name="Arguments">Input/Output arguments consumed/produced by the release.</param>
        /// <param name="ProcessSettings">ProcessSettings.</param>
        /// <param name="Id">Id.</param>
        public ReleaseDto(string Key = default(string), string ProcessKey = default(string), string ProcessVersion = default(string), bool? IsLatestVersion = default(bool?), bool? IsProcessDeleted = default(bool?), string Description = default(string), string Name = default(string), long? EnvironmentId = default(long?), string EnvironmentName = default(string), EnvironmentDto Environment = default(EnvironmentDto), string InputArguments = default(string), ReleaseVersionDto CurrentVersion = default(ReleaseVersionDto), List<ReleaseVersionDto> ReleaseVersions = default(List<ReleaseVersionDto>), ArgumentMetadata Arguments = default(ArgumentMetadata), ProcessSettingsDto ProcessSettings = default(ProcessSettingsDto), long? Id = default(long?))
        {
            // to ensure "ProcessKey" is required (not null)
            if (ProcessKey == null)
            {
                throw new InvalidDataException("ProcessKey is a required property for ReleaseDto and cannot be null");
            }
            else
            {
                this.ProcessKey = ProcessKey;
            }
            // to ensure "ProcessVersion" is required (not null)
            if (ProcessVersion == null)
            {
                throw new InvalidDataException("ProcessVersion is a required property for ReleaseDto and cannot be null");
            }
            else
            {
                this.ProcessVersion = ProcessVersion;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ReleaseDto and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "EnvironmentId" is required (not null)
            if (EnvironmentId == null)
            {
                throw new InvalidDataException("EnvironmentId is a required property for ReleaseDto and cannot be null");
            }
            else
            {
                this.EnvironmentId = EnvironmentId;
            }
            this.Key = Key;
            this.IsLatestVersion = IsLatestVersion;
            this.IsProcessDeleted = IsProcessDeleted;
            this.Description = Description;
            this.EnvironmentName = EnvironmentName;
            this.Environment = Environment;
            this.InputArguments = InputArguments;
            this.CurrentVersion = CurrentVersion;
            this.ReleaseVersions = ReleaseVersions;
            this.Arguments = Arguments;
            this.ProcessSettings = ProcessSettings;
            this.Id = Id;
        }
        
        /// <summary>
        /// A unique identifier associated to each release.
        /// </summary>
        /// <value>A unique identifier associated to each release.</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The unique identifier of the process associated with the release.
        /// </summary>
        /// <value>The unique identifier of the process associated with the release.</value>
        [DataMember(Name="ProcessKey", EmitDefaultValue=false)]
        public string ProcessKey { get; set; }

        /// <summary>
        /// The version of the process associated with the release.
        /// </summary>
        /// <value>The version of the process associated with the release.</value>
        [DataMember(Name="ProcessVersion", EmitDefaultValue=false)]
        public string ProcessVersion { get; set; }

        /// <summary>
        /// States whether the version of process associated with the release is latest or not.
        /// </summary>
        /// <value>States whether the version of process associated with the release is latest or not.</value>
        [DataMember(Name="IsLatestVersion", EmitDefaultValue=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// States whether the process associated with the release is deleted or not.
        /// </summary>
        /// <value>States whether the process associated with the release is deleted or not.</value>
        [DataMember(Name="IsProcessDeleted", EmitDefaultValue=false)]
        public bool? IsProcessDeleted { get; set; }

        /// <summary>
        /// Used to add additional information about a release in order to better identify it.
        /// </summary>
        /// <value>Used to add additional information about a release in order to better identify it.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A custom name of the release. The default name format is ProcessName_EnvironmentName.
        /// </summary>
        /// <value>A custom name of the release. The default name format is ProcessName_EnvironmentName.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Id of the environment associated with the release.
        /// </summary>
        /// <value>The Id of the environment associated with the release.</value>
        [DataMember(Name="EnvironmentId", EmitDefaultValue=false)]
        public long? EnvironmentId { get; set; }

        /// <summary>
        /// The name of the environment associated with the release.
        /// </summary>
        /// <value>The name of the environment associated with the release.</value>
        [DataMember(Name="EnvironmentName", EmitDefaultValue=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// The environment associated with the release.
        /// </summary>
        /// <value>The environment associated with the release.</value>
        [DataMember(Name="Environment", EmitDefaultValue=false)]
        public EnvironmentDto Environment { get; set; }

        /// <summary>
        /// Input parameters in JSON format to be passed as default values to job execution.
        /// </summary>
        /// <value>Input parameters in JSON format to be passed as default values to job execution.</value>
        [DataMember(Name="InputArguments", EmitDefaultValue=false)]
        public string InputArguments { get; set; }

        /// <summary>
        /// The release version associated with the current release.
        /// </summary>
        /// <value>The release version associated with the current release.</value>
        [DataMember(Name="CurrentVersion", EmitDefaultValue=false)]
        public ReleaseVersionDto CurrentVersion { get; set; }

        /// <summary>
        /// The collection of release versions that current release had over time.
        /// </summary>
        /// <value>The collection of release versions that current release had over time.</value>
        [DataMember(Name="ReleaseVersions", EmitDefaultValue=false)]
        public List<ReleaseVersionDto> ReleaseVersions { get; set; }

        /// <summary>
        /// Input/Output arguments consumed/produced by the release
        /// </summary>
        /// <value>Input/Output arguments consumed/produced by the release</value>
        [DataMember(Name="Arguments", EmitDefaultValue=false)]
        public ArgumentMetadata Arguments { get; set; }

        /// <summary>
        /// Gets or Sets ProcessSettings
        /// </summary>
        [DataMember(Name="ProcessSettings", EmitDefaultValue=false)]
        public ProcessSettingsDto ProcessSettings { get; set; }

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
            sb.Append("class ReleaseDto {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ProcessKey: ").Append(ProcessKey).Append("\n");
            sb.Append("  ProcessVersion: ").Append(ProcessVersion).Append("\n");
            sb.Append("  IsLatestVersion: ").Append(IsLatestVersion).Append("\n");
            sb.Append("  IsProcessDeleted: ").Append(IsProcessDeleted).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EnvironmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  EnvironmentName: ").Append(EnvironmentName).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  InputArguments: ").Append(InputArguments).Append("\n");
            sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  ReleaseVersions: ").Append(ReleaseVersions).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  ProcessSettings: ").Append(ProcessSettings).Append("\n");
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
            return this.Equals(input as ReleaseDto);
        }

        /// <summary>
        /// Returns true if ReleaseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ProcessKey == input.ProcessKey ||
                    (this.ProcessKey != null &&
                    this.ProcessKey.Equals(input.ProcessKey))
                ) && 
                (
                    this.ProcessVersion == input.ProcessVersion ||
                    (this.ProcessVersion != null &&
                    this.ProcessVersion.Equals(input.ProcessVersion))
                ) && 
                (
                    this.IsLatestVersion == input.IsLatestVersion ||
                    (this.IsLatestVersion != null &&
                    this.IsLatestVersion.Equals(input.IsLatestVersion))
                ) && 
                (
                    this.IsProcessDeleted == input.IsProcessDeleted ||
                    (this.IsProcessDeleted != null &&
                    this.IsProcessDeleted.Equals(input.IsProcessDeleted))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EnvironmentId == input.EnvironmentId ||
                    (this.EnvironmentId != null &&
                    this.EnvironmentId.Equals(input.EnvironmentId))
                ) && 
                (
                    this.EnvironmentName == input.EnvironmentName ||
                    (this.EnvironmentName != null &&
                    this.EnvironmentName.Equals(input.EnvironmentName))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.InputArguments == input.InputArguments ||
                    (this.InputArguments != null &&
                    this.InputArguments.Equals(input.InputArguments))
                ) && 
                (
                    this.CurrentVersion == input.CurrentVersion ||
                    (this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(input.CurrentVersion))
                ) && 
                (
                    this.ReleaseVersions == input.ReleaseVersions ||
                    this.ReleaseVersions != null &&
                    this.ReleaseVersions.SequenceEqual(input.ReleaseVersions)
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    (this.Arguments != null &&
                    this.Arguments.Equals(input.Arguments))
                ) && 
                (
                    this.ProcessSettings == input.ProcessSettings ||
                    (this.ProcessSettings != null &&
                    this.ProcessSettings.Equals(input.ProcessSettings))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ProcessKey != null)
                    hashCode = hashCode * 59 + this.ProcessKey.GetHashCode();
                if (this.ProcessVersion != null)
                    hashCode = hashCode * 59 + this.ProcessVersion.GetHashCode();
                if (this.IsLatestVersion != null)
                    hashCode = hashCode * 59 + this.IsLatestVersion.GetHashCode();
                if (this.IsProcessDeleted != null)
                    hashCode = hashCode * 59 + this.IsProcessDeleted.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnvironmentId != null)
                    hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.EnvironmentName != null)
                    hashCode = hashCode * 59 + this.EnvironmentName.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.InputArguments != null)
                    hashCode = hashCode * 59 + this.InputArguments.GetHashCode();
                if (this.CurrentVersion != null)
                    hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.ReleaseVersions != null)
                    hashCode = hashCode * 59 + this.ReleaseVersions.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.ProcessSettings != null)
                    hashCode = hashCode * 59 + this.ProcessSettings.GetHashCode();
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
