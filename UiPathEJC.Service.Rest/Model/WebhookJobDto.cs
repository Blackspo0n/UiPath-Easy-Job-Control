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
    /// WebhookJobDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class WebhookJobDto :  IEquatable<WebhookJobDto>, IValidatableObject
    {
        /// <summary>
        /// The state in which the job is.
        /// </summary>
        /// <value>The state in which the job is.</value>
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
        /// The state in which the job is.
        /// </summary>
        /// <value>The state in which the job is.</value>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The Source type of the job.
        /// </summary>
        /// <value>The Source type of the job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceTypeEnum
        {
            
            /// <summary>
            /// Enum Manual for value: Manual
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual = 1,
            
            /// <summary>
            /// Enum Schedule for value: Schedule
            /// </summary>
            [EnumMember(Value = "Schedule")]
            Schedule = 2,
            
            /// <summary>
            /// Enum Agent for value: Agent
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent = 3
        }

        /// <summary>
        /// The Source type of the job.
        /// </summary>
        /// <value>The Source type of the job.</value>
        [DataMember(Name="SourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// The type of the job, Attended if started via the robot, Unattended otherwise
        /// </summary>
        /// <value>The type of the job, Attended if started via the robot, Unattended otherwise</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Unattended for value: Unattended
            /// </summary>
            [EnumMember(Value = "Unattended")]
            Unattended = 1,
            
            /// <summary>
            /// Enum Attended for value: Attended
            /// </summary>
            [EnumMember(Value = "Attended")]
            Attended = 2
        }

        /// <summary>
        /// The type of the job, Attended if started via the robot, Unattended otherwise
        /// </summary>
        /// <value>The type of the job, Attended if started via the robot, Unattended otherwise</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookJobDto" /> class.
        /// </summary>
        /// <param name="Robot">The robot associated with the current job..</param>
        /// <param name="Release">The release associated with the current job..</param>
        /// <param name="InputArguments">Input parameters in JSON format to be passed to job execution.</param>
        /// <param name="OutputArguments">Output parameters in JSON format resulted from job execution.</param>
        public WebhookJobDto(WebhookRobotDto Robot = default(WebhookRobotDto), WebhookReleaseDto Release = default(WebhookReleaseDto), Object InputArguments = default(Object), Object OutputArguments = default(Object))
        {
            this.Robot = Robot;
            this.Release = Release;
            this.InputArguments = InputArguments;
            this.OutputArguments = OutputArguments;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The unique job identifier.
        /// </summary>
        /// <value>The unique job identifier.</value>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public Guid? Key { get; private set; }

        /// <summary>
        /// The date and time when the job execution started or null if the job hasn&#39;t started yet.
        /// </summary>
        /// <value>The date and time when the job execution started or null if the job hasn&#39;t started yet.</value>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// The date and time when the job execution ended or null if the job hasn&#39;t ended yet.
        /// </summary>
        /// <value>The date and time when the job execution ended or null if the job hasn&#39;t ended yet.</value>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; private set; }


        /// <summary>
        /// The Source name of the job.
        /// </summary>
        /// <value>The Source name of the job.</value>
        [DataMember(Name="Source", EmitDefaultValue=false)]
        public string Source { get; private set; }


        /// <summary>
        /// The unique identifier grouping multiple jobs. It is usually generated when the job is created by a schedule.
        /// </summary>
        /// <value>The unique identifier grouping multiple jobs. It is usually generated when the job is created by a schedule.</value>
        [DataMember(Name="BatchExecutionKey", EmitDefaultValue=false)]
        public Guid? BatchExecutionKey { get; private set; }

        /// <summary>
        /// Additional information about the current job.
        /// </summary>
        /// <value>Additional information about the current job.</value>
        [DataMember(Name="Info", EmitDefaultValue=false)]
        public string Info { get; private set; }

        /// <summary>
        /// The Id of the schedule that started the job, or null if the job was started by the user.
        /// </summary>
        /// <value>The Id of the schedule that started the job, or null if the job was started by the user.</value>
        [DataMember(Name="StartingScheduleId", EmitDefaultValue=false)]
        public long? StartingScheduleId { get; private set; }

        /// <summary>
        /// The name of the release associated with the current name.
        /// </summary>
        /// <value>The name of the release associated with the current name.</value>
        [DataMember(Name="ReleaseName", EmitDefaultValue=false)]
        public string ReleaseName { get; private set; }


        /// <summary>
        /// The name of the machine where the Robot run the job.
        /// </summary>
        /// <value>The name of the machine where the Robot run the job.</value>
        [DataMember(Name="HostMachineName", EmitDefaultValue=false)]
        public string HostMachineName { get; private set; }

        /// <summary>
        /// The robot associated with the current job.
        /// </summary>
        /// <value>The robot associated with the current job.</value>
        [DataMember(Name="Robot", EmitDefaultValue=false)]
        public WebhookRobotDto Robot { get; set; }

        /// <summary>
        /// The release associated with the current job.
        /// </summary>
        /// <value>The release associated with the current job.</value>
        [DataMember(Name="Release", EmitDefaultValue=false)]
        public WebhookReleaseDto Release { get; set; }

        /// <summary>
        /// Input parameters in JSON format to be passed to job execution
        /// </summary>
        /// <value>Input parameters in JSON format to be passed to job execution</value>
        [DataMember(Name="InputArguments", EmitDefaultValue=false)]
        public Object InputArguments { get; set; }

        /// <summary>
        /// Output parameters in JSON format resulted from job execution
        /// </summary>
        /// <value>Output parameters in JSON format resulted from job execution</value>
        [DataMember(Name="OutputArguments", EmitDefaultValue=false)]
        public Object OutputArguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookJobDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  BatchExecutionKey: ").Append(BatchExecutionKey).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  StartingScheduleId: ").Append(StartingScheduleId).Append("\n");
            sb.Append("  ReleaseName: ").Append(ReleaseName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HostMachineName: ").Append(HostMachineName).Append("\n");
            sb.Append("  Robot: ").Append(Robot).Append("\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
            sb.Append("  InputArguments: ").Append(InputArguments).Append("\n");
            sb.Append("  OutputArguments: ").Append(OutputArguments).Append("\n");
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
            return this.Equals(input as WebhookJobDto);
        }

        /// <summary>
        /// Returns true if WebhookJobDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookJobDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookJobDto input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.BatchExecutionKey == input.BatchExecutionKey ||
                    (this.BatchExecutionKey != null &&
                    this.BatchExecutionKey.Equals(input.BatchExecutionKey))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.StartingScheduleId == input.StartingScheduleId ||
                    (this.StartingScheduleId != null &&
                    this.StartingScheduleId.Equals(input.StartingScheduleId))
                ) && 
                (
                    this.ReleaseName == input.ReleaseName ||
                    (this.ReleaseName != null &&
                    this.ReleaseName.Equals(input.ReleaseName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.HostMachineName == input.HostMachineName ||
                    (this.HostMachineName != null &&
                    this.HostMachineName.Equals(input.HostMachineName))
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
                ) && 
                (
                    this.InputArguments == input.InputArguments ||
                    (this.InputArguments != null &&
                    this.InputArguments.Equals(input.InputArguments))
                ) && 
                (
                    this.OutputArguments == input.OutputArguments ||
                    (this.OutputArguments != null &&
                    this.OutputArguments.Equals(input.OutputArguments))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.BatchExecutionKey != null)
                    hashCode = hashCode * 59 + this.BatchExecutionKey.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.StartingScheduleId != null)
                    hashCode = hashCode * 59 + this.StartingScheduleId.GetHashCode();
                if (this.ReleaseName != null)
                    hashCode = hashCode * 59 + this.ReleaseName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HostMachineName != null)
                    hashCode = hashCode * 59 + this.HostMachineName.GetHashCode();
                if (this.Robot != null)
                    hashCode = hashCode * 59 + this.Robot.GetHashCode();
                if (this.Release != null)
                    hashCode = hashCode * 59 + this.Release.GetHashCode();
                if (this.InputArguments != null)
                    hashCode = hashCode * 59 + this.InputArguments.GetHashCode();
                if (this.OutputArguments != null)
                    hashCode = hashCode * 59 + this.OutputArguments.GetHashCode();
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
