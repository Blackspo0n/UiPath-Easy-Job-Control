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
    /// StopJobsParameters
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class StopJobsParameters :  IEquatable<StopJobsParameters>, IValidatableObject
    {
        /// <summary>
        /// Defines Strategy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrategyEnum
        {
            
            /// <summary>
            /// Enum SoftStop for value: SoftStop
            /// </summary>
            [EnumMember(Value = "SoftStop")]
            SoftStop = 1,
            
            /// <summary>
            /// Enum Kill for value: Kill
            /// </summary>
            [EnumMember(Value = "Kill")]
            Kill = 2
        }

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name="strategy", EmitDefaultValue=false)]
        public StrategyEnum Strategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StopJobsParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StopJobsParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StopJobsParameters" /> class.
        /// </summary>
        /// <param name="JobIds">JobIds (required).</param>
        /// <param name="Strategy">Strategy (required).</param>
        public StopJobsParameters(List<long?> JobIds = default(List<long?>), StrategyEnum Strategy = default(StrategyEnum))
        {
            // to ensure "JobIds" is required (not null)
            if (JobIds == null)
            {
                throw new InvalidDataException("JobIds is a required property for StopJobsParameters and cannot be null");
            }
            else
            {
                this.JobIds = JobIds;
            }
            // to ensure "Strategy" is required (not null)
            if (Strategy == null)
            {
                throw new InvalidDataException("Strategy is a required property for StopJobsParameters and cannot be null");
            }
            else
            {
                this.Strategy = Strategy;
            }
        }
        
        /// <summary>
        /// Gets or Sets JobIds
        /// </summary>
        [DataMember(Name="jobIds", EmitDefaultValue=false)]
        public List<long?> JobIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopJobsParameters {\n");
            sb.Append("  JobIds: ").Append(JobIds).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
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
            return this.Equals(input as StopJobsParameters);
        }

        /// <summary>
        /// Returns true if StopJobsParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of StopJobsParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopJobsParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    this.JobIds.SequenceEqual(input.JobIds)
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
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
                if (this.JobIds != null)
                    hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                if (this.Strategy != null)
                    hashCode = hashCode * 59 + this.Strategy.GetHashCode();
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