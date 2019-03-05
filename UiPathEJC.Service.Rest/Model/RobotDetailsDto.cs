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
    /// RobotDetailsDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class RobotDetailsDto :  IEquatable<RobotDetailsDto>, IValidatableObject
    {
        /// <summary>
        /// The Robot type.
        /// </summary>
        /// <value>The Robot type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RobotTypeEnum
        {
            
            /// <summary>
            /// Enum NonProduction for value: NonProduction
            /// </summary>
            [EnumMember(Value = "NonProduction")]
            NonProduction = 1,
            
            /// <summary>
            /// Enum Attended for value: Attended
            /// </summary>
            [EnumMember(Value = "Attended")]
            Attended = 2,
            
            /// <summary>
            /// Enum Unattended for value: Unattended
            /// </summary>
            [EnumMember(Value = "Unattended")]
            Unattended = 3,
            
            /// <summary>
            /// Enum Development for value: Development
            /// </summary>
            [EnumMember(Value = "Development")]
            Development = 4
        }

        /// <summary>
        /// The Robot type.
        /// </summary>
        /// <value>The Robot type.</value>
        [DataMember(Name="robotType", EmitDefaultValue=false)]
        public RobotTypeEnum? RobotType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotDetailsDto" /> class.
        /// </summary>
        /// <param name="RobotKey">The Robot key..</param>
        /// <param name="User">The Robot username..</param>
        /// <param name="MachineName">The name of the machine a Robot is hosted on..</param>
        /// <param name="MachineId">The Machine Id..</param>
        /// <param name="RobotName">The Robot name..</param>
        /// <param name="RobotType">The Robot type..</param>
        /// <param name="HasLicense">Whether the Robot is licensed or not.</param>
        /// <param name="TenantId">The Tenant&#39;s Id..</param>
        /// <param name="OrganizationUnitId">The OrganizationUnit&#39;s Id..</param>
        /// <param name="ExecutionSettings">A collection of key value pairs containing execution settings for this robot..</param>
        /// <param name="Id">Id.</param>
        public RobotDetailsDto(string RobotKey = default(string), string User = default(string), string MachineName = default(string), long? MachineId = default(long?), string RobotName = default(string), RobotTypeEnum? RobotType = default(RobotTypeEnum?), bool? HasLicense = default(bool?), int? TenantId = default(int?), long? OrganizationUnitId = default(long?), Dictionary<string, Object> ExecutionSettings = default(Dictionary<string, Object>), long? Id = default(long?))
        {
            this.RobotKey = RobotKey;
            this.User = User;
            this.MachineName = MachineName;
            this.MachineId = MachineId;
            this.RobotName = RobotName;
            this.RobotType = RobotType;
            this.HasLicense = HasLicense;
            this.TenantId = TenantId;
            this.OrganizationUnitId = OrganizationUnitId;
            this.ExecutionSettings = ExecutionSettings;
            this.Id = Id;
        }
        
        /// <summary>
        /// The Robot key.
        /// </summary>
        /// <value>The Robot key.</value>
        [DataMember(Name="robotKey", EmitDefaultValue=false)]
        public string RobotKey { get; set; }

        /// <summary>
        /// The Robot username.
        /// </summary>
        /// <value>The Robot username.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// The name of the machine a Robot is hosted on.
        /// </summary>
        /// <value>The name of the machine a Robot is hosted on.</value>
        [DataMember(Name="machineName", EmitDefaultValue=false)]
        public string MachineName { get; set; }

        /// <summary>
        /// The Machine Id.
        /// </summary>
        /// <value>The Machine Id.</value>
        [DataMember(Name="machineId", EmitDefaultValue=false)]
        public long? MachineId { get; set; }

        /// <summary>
        /// The Robot name.
        /// </summary>
        /// <value>The Robot name.</value>
        [DataMember(Name="robotName", EmitDefaultValue=false)]
        public string RobotName { get; set; }


        /// <summary>
        /// Whether the Robot is licensed or not
        /// </summary>
        /// <value>Whether the Robot is licensed or not</value>
        [DataMember(Name="hasLicense", EmitDefaultValue=false)]
        public bool? HasLicense { get; set; }

        /// <summary>
        /// The Tenant&#39;s Id.
        /// </summary>
        /// <value>The Tenant&#39;s Id.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public int? TenantId { get; set; }

        /// <summary>
        /// The OrganizationUnit&#39;s Id.
        /// </summary>
        /// <value>The OrganizationUnit&#39;s Id.</value>
        [DataMember(Name="organizationUnitId", EmitDefaultValue=false)]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// A collection of key value pairs containing execution settings for this robot.
        /// </summary>
        /// <value>A collection of key value pairs containing execution settings for this robot.</value>
        [DataMember(Name="executionSettings", EmitDefaultValue=false)]
        public Dictionary<string, Object> ExecutionSettings { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RobotDetailsDto {\n");
            sb.Append("  RobotKey: ").Append(RobotKey).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  MachineName: ").Append(MachineName).Append("\n");
            sb.Append("  MachineId: ").Append(MachineId).Append("\n");
            sb.Append("  RobotName: ").Append(RobotName).Append("\n");
            sb.Append("  RobotType: ").Append(RobotType).Append("\n");
            sb.Append("  HasLicense: ").Append(HasLicense).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  OrganizationUnitId: ").Append(OrganizationUnitId).Append("\n");
            sb.Append("  ExecutionSettings: ").Append(ExecutionSettings).Append("\n");
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
            return this.Equals(input as RobotDetailsDto);
        }

        /// <summary>
        /// Returns true if RobotDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RobotDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RobotDetailsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RobotKey == input.RobotKey ||
                    (this.RobotKey != null &&
                    this.RobotKey.Equals(input.RobotKey))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.MachineName == input.MachineName ||
                    (this.MachineName != null &&
                    this.MachineName.Equals(input.MachineName))
                ) && 
                (
                    this.MachineId == input.MachineId ||
                    (this.MachineId != null &&
                    this.MachineId.Equals(input.MachineId))
                ) && 
                (
                    this.RobotName == input.RobotName ||
                    (this.RobotName != null &&
                    this.RobotName.Equals(input.RobotName))
                ) && 
                (
                    this.RobotType == input.RobotType ||
                    (this.RobotType != null &&
                    this.RobotType.Equals(input.RobotType))
                ) && 
                (
                    this.HasLicense == input.HasLicense ||
                    (this.HasLicense != null &&
                    this.HasLicense.Equals(input.HasLicense))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.OrganizationUnitId == input.OrganizationUnitId ||
                    (this.OrganizationUnitId != null &&
                    this.OrganizationUnitId.Equals(input.OrganizationUnitId))
                ) && 
                (
                    this.ExecutionSettings == input.ExecutionSettings ||
                    this.ExecutionSettings != null &&
                    this.ExecutionSettings.SequenceEqual(input.ExecutionSettings)
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
                if (this.RobotKey != null)
                    hashCode = hashCode * 59 + this.RobotKey.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.MachineName != null)
                    hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.MachineId != null)
                    hashCode = hashCode * 59 + this.MachineId.GetHashCode();
                if (this.RobotName != null)
                    hashCode = hashCode * 59 + this.RobotName.GetHashCode();
                if (this.RobotType != null)
                    hashCode = hashCode * 59 + this.RobotType.GetHashCode();
                if (this.HasLicense != null)
                    hashCode = hashCode * 59 + this.HasLicense.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.OrganizationUnitId != null)
                    hashCode = hashCode * 59 + this.OrganizationUnitId.GetHashCode();
                if (this.ExecutionSettings != null)
                    hashCode = hashCode * 59 + this.ExecutionSettings.GetHashCode();
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
