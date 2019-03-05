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
    /// ProcessSettingsDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class ProcessSettingsDto :  IEquatable<ProcessSettingsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessSettingsDto" /> class.
        /// </summary>
        /// <param name="ErrorRecordingEnabled">ErrorRecordingEnabled.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="Frequency">Frequency.</param>
        /// <param name="Quality">Quality.</param>
        public ProcessSettingsDto(bool? ErrorRecordingEnabled = default(bool?), int? Duration = default(int?), int? Frequency = default(int?), int? Quality = default(int?))
        {
            this.ErrorRecordingEnabled = ErrorRecordingEnabled;
            this.Duration = Duration;
            this.Frequency = Frequency;
            this.Quality = Quality;
        }
        
        /// <summary>
        /// Gets or Sets ErrorRecordingEnabled
        /// </summary>
        [DataMember(Name="ErrorRecordingEnabled", EmitDefaultValue=false)]
        public bool? ErrorRecordingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="Duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="Frequency", EmitDefaultValue=false)]
        public int? Frequency { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name="Quality", EmitDefaultValue=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessSettingsDto {\n");
            sb.Append("  ErrorRecordingEnabled: ").Append(ErrorRecordingEnabled).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
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
            return this.Equals(input as ProcessSettingsDto);
        }

        /// <summary>
        /// Returns true if ProcessSettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessSettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessSettingsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorRecordingEnabled == input.ErrorRecordingEnabled ||
                    (this.ErrorRecordingEnabled != null &&
                    this.ErrorRecordingEnabled.Equals(input.ErrorRecordingEnabled))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
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
                if (this.ErrorRecordingEnabled != null)
                    hashCode = hashCode * 59 + this.ErrorRecordingEnabled.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
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
