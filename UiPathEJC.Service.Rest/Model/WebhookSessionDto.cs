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
    /// WebhookSessionDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class WebhookSessionDto :  IEquatable<WebhookSessionDto>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Available for value: Available
            /// </summary>
            [EnumMember(Value = "Available")]
            Available = 1,
            
            /// <summary>
            /// Enum Busy for value: Busy
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy = 2,
            
            /// <summary>
            /// Enum Disconnected for value: Disconnected
            /// </summary>
            [EnumMember(Value = "Disconnected")]
            Disconnected = 3,
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 4
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Defines LicenseErrorCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LicenseErrorCodeEnum
        {
            
            /// <summary>
            /// Enum NoLicense for value: NoLicense
            /// </summary>
            [EnumMember(Value = "NoLicense")]
            NoLicense = 1,
            
            /// <summary>
            /// Enum LicenseExpired for value: LicenseExpired
            /// </summary>
            [EnumMember(Value = "LicenseExpired")]
            LicenseExpired = 2,
            
            /// <summary>
            /// Enum LicenseUnregistered for value: LicenseUnregistered
            /// </summary>
            [EnumMember(Value = "LicenseUnregistered")]
            LicenseUnregistered = 3,
            
            /// <summary>
            /// Enum NoAvailableLicenses for value: NoAvailableLicenses
            /// </summary>
            [EnumMember(Value = "NoAvailableLicenses")]
            NoAvailableLicenses = 4,
            
            /// <summary>
            /// Enum NotEnoughAvailableSlots for value: NotEnoughAvailableSlots
            /// </summary>
            [EnumMember(Value = "NotEnoughAvailableSlots")]
            NotEnoughAvailableSlots = 5,
            
            /// <summary>
            /// Enum NotEnoughRuntimeLicenses for value: NotEnoughRuntimeLicenses
            /// </summary>
            [EnumMember(Value = "NotEnoughRuntimeLicenses")]
            NotEnoughRuntimeLicenses = 6,
            
            /// <summary>
            /// Enum LicenseIsAlreadyInUse for value: LicenseIsAlreadyInUse
            /// </summary>
            [EnumMember(Value = "LicenseIsAlreadyInUse")]
            LicenseIsAlreadyInUse = 7,
            
            /// <summary>
            /// Enum InvalidRequest for value: InvalidRequest
            /// </summary>
            [EnumMember(Value = "InvalidRequest")]
            InvalidRequest = 8,
            
            /// <summary>
            /// Enum SlotsExceedLicenseLimit for value: SlotsExceedLicenseLimit
            /// </summary>
            [EnumMember(Value = "SlotsExceedLicenseLimit")]
            SlotsExceedLicenseLimit = 9,
            
            /// <summary>
            /// Enum RuntimeDisabled for value: RuntimeDisabled
            /// </summary>
            [EnumMember(Value = "RuntimeDisabled")]
            RuntimeDisabled = 10
        }

        /// <summary>
        /// Gets or Sets LicenseErrorCode
        /// </summary>
        [DataMember(Name="LicenseErrorCode", EmitDefaultValue=false)]
        public LicenseErrorCodeEnum? LicenseErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSessionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public WebhookSessionDto()
        {
        }
        
        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="SessionId", EmitDefaultValue=false)]
        public long? SessionId { get; private set; }

        /// <summary>
        /// Gets or Sets RobotId
        /// </summary>
        [DataMember(Name="RobotId", EmitDefaultValue=false)]
        public long? RobotId { get; private set; }

        /// <summary>
        /// Gets or Sets HostMachineName
        /// </summary>
        [DataMember(Name="HostMachineName", EmitDefaultValue=false)]
        public string HostMachineName { get; private set; }


        /// <summary>
        /// Gets or Sets ReportingTime
        /// </summary>
        [DataMember(Name="ReportingTime", EmitDefaultValue=false)]
        public DateTime? ReportingTime { get; private set; }

        /// <summary>
        /// Gets or Sets IsUnresponsive
        /// </summary>
        [DataMember(Name="IsUnresponsive", EmitDefaultValue=false)]
        public bool? IsUnresponsive { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSessionDto {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  RobotId: ").Append(RobotId).Append("\n");
            sb.Append("  HostMachineName: ").Append(HostMachineName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ReportingTime: ").Append(ReportingTime).Append("\n");
            sb.Append("  IsUnresponsive: ").Append(IsUnresponsive).Append("\n");
            sb.Append("  LicenseErrorCode: ").Append(LicenseErrorCode).Append("\n");
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
            return this.Equals(input as WebhookSessionDto);
        }

        /// <summary>
        /// Returns true if WebhookSessionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSessionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSessionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.RobotId == input.RobotId ||
                    (this.RobotId != null &&
                    this.RobotId.Equals(input.RobotId))
                ) && 
                (
                    this.HostMachineName == input.HostMachineName ||
                    (this.HostMachineName != null &&
                    this.HostMachineName.Equals(input.HostMachineName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ReportingTime == input.ReportingTime ||
                    (this.ReportingTime != null &&
                    this.ReportingTime.Equals(input.ReportingTime))
                ) && 
                (
                    this.IsUnresponsive == input.IsUnresponsive ||
                    (this.IsUnresponsive != null &&
                    this.IsUnresponsive.Equals(input.IsUnresponsive))
                ) && 
                (
                    this.LicenseErrorCode == input.LicenseErrorCode ||
                    (this.LicenseErrorCode != null &&
                    this.LicenseErrorCode.Equals(input.LicenseErrorCode))
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
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.RobotId != null)
                    hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.HostMachineName != null)
                    hashCode = hashCode * 59 + this.HostMachineName.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ReportingTime != null)
                    hashCode = hashCode * 59 + this.ReportingTime.GetHashCode();
                if (this.IsUnresponsive != null)
                    hashCode = hashCode * 59 + this.IsUnresponsive.GetHashCode();
                if (this.LicenseErrorCode != null)
                    hashCode = hashCode * 59 + this.LicenseErrorCode.GetHashCode();
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
