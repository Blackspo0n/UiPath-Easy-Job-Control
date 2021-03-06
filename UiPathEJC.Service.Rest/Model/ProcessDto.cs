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
    /// A process is a project defined in UiPath Studio and published in Orchestrator from UiPath Studio or manually.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class ProcessDto :  IEquatable<ProcessDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDto" /> class.
        /// </summary>
        /// <param name="IsActive">Specifies if the process is still active..</param>
        /// <param name="Arguments">Input/Output arguments supported by the process.</param>
        /// <param name="Title">The custom name of the package..</param>
        /// <param name="Version">The current version of the given package..</param>
        /// <param name="Key">The unique identifier for the package..</param>
        /// <param name="Description">Used to add additional information about a package in order to better identify it..</param>
        /// <param name="Published">The date and time when the package was published or uploaded..</param>
        /// <param name="IsLatestVersion">Specifies whether the current version is the latest of the given package..</param>
        /// <param name="OldVersion">Specifies the last version before the current one..</param>
        /// <param name="ReleaseNotes">Package release notes..</param>
        /// <param name="Authors">Package authors..</param>
        /// <param name="Id">Id.</param>
        public ProcessDto(bool? IsActive = default(bool?), ArgumentMetadata Arguments = default(ArgumentMetadata), string Title = default(string), string Version = default(string), string Key = default(string), string Description = default(string), DateTime? Published = default(DateTime?), bool? IsLatestVersion = default(bool?), string OldVersion = default(string), string ReleaseNotes = default(string), string Authors = default(string), string Id = default(string))
        {
            this.IsActive = IsActive;
            this.Arguments = Arguments;
            this.Title = Title;
            this.Version = Version;
            this.Key = Key;
            this.Description = Description;
            this.Published = Published;
            this.IsLatestVersion = IsLatestVersion;
            this.OldVersion = OldVersion;
            this.ReleaseNotes = ReleaseNotes;
            this.Authors = Authors;
            this.Id = Id;
        }
        
        /// <summary>
        /// Specifies if the process is still active.
        /// </summary>
        /// <value>Specifies if the process is still active.</value>
        [DataMember(Name="IsActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Input/Output arguments supported by the process
        /// </summary>
        /// <value>Input/Output arguments supported by the process</value>
        [DataMember(Name="Arguments", EmitDefaultValue=false)]
        public ArgumentMetadata Arguments { get; set; }

        /// <summary>
        /// The custom name of the package.
        /// </summary>
        /// <value>The custom name of the package.</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The current version of the given package.
        /// </summary>
        /// <value>The current version of the given package.</value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The unique identifier for the package.
        /// </summary>
        /// <value>The unique identifier for the package.</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Used to add additional information about a package in order to better identify it.
        /// </summary>
        /// <value>Used to add additional information about a package in order to better identify it.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the package was published or uploaded.
        /// </summary>
        /// <value>The date and time when the package was published or uploaded.</value>
        [DataMember(Name="Published", EmitDefaultValue=false)]
        public DateTime? Published { get; set; }

        /// <summary>
        /// Specifies whether the current version is the latest of the given package.
        /// </summary>
        /// <value>Specifies whether the current version is the latest of the given package.</value>
        [DataMember(Name="IsLatestVersion", EmitDefaultValue=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// Specifies the last version before the current one.
        /// </summary>
        /// <value>Specifies the last version before the current one.</value>
        [DataMember(Name="OldVersion", EmitDefaultValue=false)]
        public string OldVersion { get; set; }

        /// <summary>
        /// Package release notes.
        /// </summary>
        /// <value>Package release notes.</value>
        [DataMember(Name="ReleaseNotes", EmitDefaultValue=false)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Package authors.
        /// </summary>
        /// <value>Package authors.</value>
        [DataMember(Name="Authors", EmitDefaultValue=false)]
        public string Authors { get; set; }

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
            sb.Append("class ProcessDto {\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  IsLatestVersion: ").Append(IsLatestVersion).Append("\n");
            sb.Append("  OldVersion: ").Append(OldVersion).Append("\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
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
            return this.Equals(input as ProcessDto);
        }

        /// <summary>
        /// Returns true if ProcessDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    (this.Arguments != null &&
                    this.Arguments.Equals(input.Arguments))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.IsLatestVersion == input.IsLatestVersion ||
                    (this.IsLatestVersion != null &&
                    this.IsLatestVersion.Equals(input.IsLatestVersion))
                ) && 
                (
                    this.OldVersion == input.OldVersion ||
                    (this.OldVersion != null &&
                    this.OldVersion.Equals(input.OldVersion))
                ) && 
                (
                    this.ReleaseNotes == input.ReleaseNotes ||
                    (this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(input.ReleaseNotes))
                ) && 
                (
                    this.Authors == input.Authors ||
                    (this.Authors != null &&
                    this.Authors.Equals(input.Authors))
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
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.IsLatestVersion != null)
                    hashCode = hashCode * 59 + this.IsLatestVersion.GetHashCode();
                if (this.OldVersion != null)
                    hashCode = hashCode * 59 + this.OldVersion.GetHashCode();
                if (this.ReleaseNotes != null)
                    hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
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
