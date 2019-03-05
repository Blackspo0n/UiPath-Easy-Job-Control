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
    /// WebhookSimpleJobDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class WebhookSimpleJobDto :  IEquatable<WebhookSimpleJobDto>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 2,
            
            /// <summary>
            /// Enum Stopping for value: Stopping
            /// </summary>
            [EnumMember(Value = "Stopping")]
            Stopping = 3,
            
            /// <summary>
            /// Enum Terminating for value: Terminating
            /// </summary>
            [EnumMember(Value = "Terminating")]
            Terminating = 4,
            
            /// <summary>
            /// Enum Faulted for value: Faulted
            /// </summary>
            [EnumMember(Value = "Faulted")]
            Faulted = 5,
            
            /// <summary>
            /// Enum Successful for value: Successful
            /// </summary>
            [EnumMember(Value = "Successful")]
            Successful = 6,
            
            /// <summary>
            /// Enum Stopped for value: Stopped
            /// </summary>
            [EnumMember(Value = "Stopped")]
            Stopped = 7
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSimpleJobDto" /> class.
        /// </summary>
        /// <param name="OutputArguments">OutputArguments.</param>
        /// <param name="Robot">Robot.</param>
        /// <param name="Release">Release.</param>
        public WebhookSimpleJobDto(Object OutputArguments = default(Object), WebhookSimpleRobotDto Robot = default(WebhookSimpleRobotDto), WebhookSimpleReleaseDto Release = default(WebhookSimpleReleaseDto))
        {
            this.OutputArguments = OutputArguments;
            this.Robot = Robot;
            this.Release = Release;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public Guid? Key { get; private set; }


        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="Info", EmitDefaultValue=false)]
        public string Info { get; private set; }

        /// <summary>
        /// Gets or Sets OutputArguments
        /// </summary>
        [DataMember(Name="OutputArguments", EmitDefaultValue=false)]
        public Object OutputArguments { get; set; }

        /// <summary>
        /// Gets or Sets Robot
        /// </summary>
        [DataMember(Name="Robot", EmitDefaultValue=false)]
        public WebhookSimpleRobotDto Robot { get; set; }

        /// <summary>
        /// Gets or Sets Release
        /// </summary>
        [DataMember(Name="Release", EmitDefaultValue=false)]
        public WebhookSimpleReleaseDto Release { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSimpleJobDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  OutputArguments: ").Append(OutputArguments).Append("\n");
            sb.Append("  Robot: ").Append(Robot).Append("\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
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
            return this.Equals(input as WebhookSimpleJobDto);
        }

        /// <summary>
        /// Returns true if WebhookSimpleJobDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSimpleJobDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSimpleJobDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.OutputArguments == input.OutputArguments ||
                    (this.OutputArguments != null &&
                    this.OutputArguments.Equals(input.OutputArguments))
                ) && 
                (
                    this.Robot == input.Robot ||
                    (this.Robot != null &&
                    this.Robot.Equals(input.Robot))
                ) && 
                (
                    this.Release == input.Release ||
                    (this.Release != null &&
                    this.Release.Equals(input.Release))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.OutputArguments != null)
                    hashCode = hashCode * 59 + this.OutputArguments.GetHashCode();
                if (this.Robot != null)
                    hashCode = hashCode * 59 + this.Robot.GetHashCode();
                if (this.Release != null)
                    hashCode = hashCode * 59 + this.Release.GetHashCode();
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
