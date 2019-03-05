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
    /// WebhookProcessScheduleDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class WebhookProcessScheduleDto :  IEquatable<WebhookProcessScheduleDto>, IValidatableObject
    {
        /// <summary>
        /// States which robots from the environment are being run by the schedule.
        /// </summary>
        /// <value>States which robots from the environment are being run by the schedule.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StartStrategyEnum
        {
            
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 1,
            
            /// <summary>
            /// Enum Specific for value: Specific
            /// </summary>
            [EnumMember(Value = "Specific")]
            Specific = 2,
            
            /// <summary>
            /// Enum RobotCount for value: RobotCount
            /// </summary>
            [EnumMember(Value = "RobotCount")]
            RobotCount = 3,
            
            /// <summary>
            /// Enum JobsCount for value: JobsCount
            /// </summary>
            [EnumMember(Value = "JobsCount")]
            JobsCount = 4
        }

        /// <summary>
        /// States which robots from the environment are being run by the schedule.
        /// </summary>
        /// <value>States which robots from the environment are being run by the schedule.</value>
        [DataMember(Name="StartStrategy", EmitDefaultValue=false)]
        public StartStrategyEnum? StartStrategy { get; set; }
        /// <summary>
        /// The way a running process is stopped.
        /// </summary>
        /// <value>The way a running process is stopped.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StopStrategyEnum
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
        /// The way a running process is stopped.
        /// </summary>
        /// <value>The way a running process is stopped.</value>
        [DataMember(Name="StopStrategy", EmitDefaultValue=false)]
        public StopStrategyEnum? StopStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProcessScheduleDto" /> class.
        /// </summary>
        /// <param name="Release">Process details associated with the schedule.</param>
        /// <param name="ExecutorRobots">The collection of specific robots selected to be targeted by the current schedule. This collection must be empty if the start strategy is not 0 (specific robots)..</param>
        /// <param name="InputArguments">Input parameters that will be passed to each job created by this schedule..</param>
        public WebhookProcessScheduleDto(WebhookSimpleReleaseDto Release = default(WebhookSimpleReleaseDto), List<WebhookSimpleRobotDto> ExecutorRobots = default(List<WebhookSimpleRobotDto>), Object InputArguments = default(Object))
        {
            this.Release = Release;
            this.ExecutorRobots = ExecutorRobots;
            this.InputArguments = InputArguments;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The name of the schedule.
        /// </summary>
        /// <value>The name of the schedule.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Specifies if the schedule is active or not.
        /// </summary>
        /// <value>Specifies if the schedule is active or not.</value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; private set; }

        /// <summary>
        /// The Id of the environment associated with the schedule.
        /// </summary>
        /// <value>The Id of the environment associated with the schedule.</value>
        [DataMember(Name="EnvironmentId", EmitDefaultValue=false)]
        public string EnvironmentId { get; private set; }

        /// <summary>
        /// The name of the environment associated with the schedule.
        /// </summary>
        /// <value>The name of the environment associated with the schedule.</value>
        [DataMember(Name="EnvironmentName", EmitDefaultValue=false)]
        public string EnvironmentName { get; private set; }

        /// <summary>
        /// The start cron expression of the schedule.
        /// </summary>
        /// <value>The start cron expression of the schedule.</value>
        [DataMember(Name="StartProcessCron", EmitDefaultValue=false)]
        public string StartProcessCron { get; private set; }



        /// <summary>
        /// The unique identifier of the external job associated with the jobs generated by this schedule. A key is generated for each group of jobs triggered by this schedule.
        /// </summary>
        /// <value>The unique identifier of the external job associated with the jobs generated by this schedule. A key is generated for each group of jobs triggered by this schedule.</value>
        [DataMember(Name="ExternalJobKey", EmitDefaultValue=false)]
        public string ExternalJobKey { get; private set; }

        /// <summary>
        /// The timezone under which the schedule will run.
        /// </summary>
        /// <value>The timezone under which the schedule will run.</value>
        [DataMember(Name="TimeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; private set; }

        /// <summary>
        /// The timezone under which the schedule will run in Iana Standard.
        /// </summary>
        /// <value>The timezone under which the schedule will run in Iana Standard.</value>
        [DataMember(Name="TimeZoneIana", EmitDefaultValue=false)]
        public string TimeZoneIana { get; private set; }

        /// <summary>
        /// Specify whether the schedule uses the bank holiday calendar
        /// </summary>
        /// <value>Specify whether the schedule uses the bank holiday calendar</value>
        [DataMember(Name="UseCalendar", EmitDefaultValue=false)]
        public bool? UseCalendar { get; private set; }

        /// <summary>
        /// Process details associated with the schedule
        /// </summary>
        /// <value>Process details associated with the schedule</value>
        [DataMember(Name="Release", EmitDefaultValue=false)]
        public WebhookSimpleReleaseDto Release { get; set; }

        /// <summary>
        /// The collection of specific robots selected to be targeted by the current schedule. This collection must be empty if the start strategy is not 0 (specific robots).
        /// </summary>
        /// <value>The collection of specific robots selected to be targeted by the current schedule. This collection must be empty if the start strategy is not 0 (specific robots).</value>
        [DataMember(Name="ExecutorRobots", EmitDefaultValue=false)]
        public List<WebhookSimpleRobotDto> ExecutorRobots { get; set; }

        /// <summary>
        /// Input parameters that will be passed to each job created by this schedule.
        /// </summary>
        /// <value>Input parameters that will be passed to each job created by this schedule.</value>
        [DataMember(Name="InputArguments", EmitDefaultValue=false)]
        public Object InputArguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookProcessScheduleDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EnvironmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  EnvironmentName: ").Append(EnvironmentName).Append("\n");
            sb.Append("  StartProcessCron: ").Append(StartProcessCron).Append("\n");
            sb.Append("  StartStrategy: ").Append(StartStrategy).Append("\n");
            sb.Append("  StopStrategy: ").Append(StopStrategy).Append("\n");
            sb.Append("  ExternalJobKey: ").Append(ExternalJobKey).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  TimeZoneIana: ").Append(TimeZoneIana).Append("\n");
            sb.Append("  UseCalendar: ").Append(UseCalendar).Append("\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
            sb.Append("  ExecutorRobots: ").Append(ExecutorRobots).Append("\n");
            sb.Append("  InputArguments: ").Append(InputArguments).Append("\n");
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
            return this.Equals(input as WebhookProcessScheduleDto);
        }

        /// <summary>
        /// Returns true if WebhookProcessScheduleDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookProcessScheduleDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookProcessScheduleDto input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                    this.StartProcessCron == input.StartProcessCron ||
                    (this.StartProcessCron != null &&
                    this.StartProcessCron.Equals(input.StartProcessCron))
                ) && 
                (
                    this.StartStrategy == input.StartStrategy ||
                    (this.StartStrategy != null &&
                    this.StartStrategy.Equals(input.StartStrategy))
                ) && 
                (
                    this.StopStrategy == input.StopStrategy ||
                    (this.StopStrategy != null &&
                    this.StopStrategy.Equals(input.StopStrategy))
                ) && 
                (
                    this.ExternalJobKey == input.ExternalJobKey ||
                    (this.ExternalJobKey != null &&
                    this.ExternalJobKey.Equals(input.ExternalJobKey))
                ) && 
                (
                    this.TimeZoneId == input.TimeZoneId ||
                    (this.TimeZoneId != null &&
                    this.TimeZoneId.Equals(input.TimeZoneId))
                ) && 
                (
                    this.TimeZoneIana == input.TimeZoneIana ||
                    (this.TimeZoneIana != null &&
                    this.TimeZoneIana.Equals(input.TimeZoneIana))
                ) && 
                (
                    this.UseCalendar == input.UseCalendar ||
                    (this.UseCalendar != null &&
                    this.UseCalendar.Equals(input.UseCalendar))
                ) && 
                (
                    this.Release == input.Release ||
                    (this.Release != null &&
                    this.Release.Equals(input.Release))
                ) && 
                (
                    this.ExecutorRobots == input.ExecutorRobots ||
                    this.ExecutorRobots != null &&
                    this.ExecutorRobots.SequenceEqual(input.ExecutorRobots)
                ) && 
                (
                    this.InputArguments == input.InputArguments ||
                    (this.InputArguments != null &&
                    this.InputArguments.Equals(input.InputArguments))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.EnvironmentId != null)
                    hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.EnvironmentName != null)
                    hashCode = hashCode * 59 + this.EnvironmentName.GetHashCode();
                if (this.StartProcessCron != null)
                    hashCode = hashCode * 59 + this.StartProcessCron.GetHashCode();
                if (this.StartStrategy != null)
                    hashCode = hashCode * 59 + this.StartStrategy.GetHashCode();
                if (this.StopStrategy != null)
                    hashCode = hashCode * 59 + this.StopStrategy.GetHashCode();
                if (this.ExternalJobKey != null)
                    hashCode = hashCode * 59 + this.ExternalJobKey.GetHashCode();
                if (this.TimeZoneId != null)
                    hashCode = hashCode * 59 + this.TimeZoneId.GetHashCode();
                if (this.TimeZoneIana != null)
                    hashCode = hashCode * 59 + this.TimeZoneIana.GetHashCode();
                if (this.UseCalendar != null)
                    hashCode = hashCode * 59 + this.UseCalendar.GetHashCode();
                if (this.Release != null)
                    hashCode = hashCode * 59 + this.Release.GetHashCode();
                if (this.ExecutorRobots != null)
                    hashCode = hashCode * 59 + this.ExecutorRobots.GetHashCode();
                if (this.InputArguments != null)
                    hashCode = hashCode * 59 + this.InputArguments.GetHashCode();
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
