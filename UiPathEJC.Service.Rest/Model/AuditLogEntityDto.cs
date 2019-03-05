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
    /// Stores audit information about any action performed in Orchestrator.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class AuditLogEntityDto :  IEquatable<AuditLogEntityDto>, IValidatableObject
    {
        /// <summary>
        /// The action (created, updated, deleted etc)
        /// </summary>
        /// <value>The action (created, updated, deleted etc)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Create for value: Create
            /// </summary>
            [EnumMember(Value = "Create")]
            Create = 2,
            
            /// <summary>
            /// Enum Update for value: Update
            /// </summary>
            [EnumMember(Value = "Update")]
            Update = 3,
            
            /// <summary>
            /// Enum Delete for value: Delete
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete = 4,
            
            /// <summary>
            /// Enum StartJob for value: StartJob
            /// </summary>
            [EnumMember(Value = "StartJob")]
            StartJob = 5,
            
            /// <summary>
            /// Enum StopJob for value: StopJob
            /// </summary>
            [EnumMember(Value = "StopJob")]
            StopJob = 6,
            
            /// <summary>
            /// Enum Associate for value: Associate
            /// </summary>
            [EnumMember(Value = "Associate")]
            Associate = 7,
            
            /// <summary>
            /// Enum Upload for value: Upload
            /// </summary>
            [EnumMember(Value = "Upload")]
            Upload = 8,
            
            /// <summary>
            /// Enum ChangeStatus for value: ChangeStatus
            /// </summary>
            [EnumMember(Value = "ChangeStatus")]
            ChangeStatus = 9,
            
            /// <summary>
            /// Enum Import for value: Import
            /// </summary>
            [EnumMember(Value = "Import")]
            Import = 10,
            
            /// <summary>
            /// Enum ChangePassword for value: ChangePassword
            /// </summary>
            [EnumMember(Value = "ChangePassword")]
            ChangePassword = 11,
            
            /// <summary>
            /// Enum Register for value: Register
            /// </summary>
            [EnumMember(Value = "Register")]
            Register = 12,
            
            /// <summary>
            /// Enum Toggle for value: Toggle
            /// </summary>
            [EnumMember(Value = "Toggle")]
            Toggle = 13,
            
            /// <summary>
            /// Enum ResetPassword for value: ResetPassword
            /// </summary>
            [EnumMember(Value = "ResetPassword")]
            ResetPassword = 14,
            
            /// <summary>
            /// Enum PasswordResetAttempt for value: PasswordResetAttempt
            /// </summary>
            [EnumMember(Value = "PasswordResetAttempt")]
            PasswordResetAttempt = 15,
            
            /// <summary>
            /// Enum Download for value: Download
            /// </summary>
            [EnumMember(Value = "Download")]
            Download = 16
        }

        /// <summary>
        /// The action (created, updated, deleted etc)
        /// </summary>
        /// <value>The action (created, updated, deleted etc)</value>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEntityDto" /> class.
        /// </summary>
        /// <param name="AuditLogId">Business audit entry that triggered the changes.</param>
        /// <param name="CustomData">Data about the old/new/included values.</param>
        /// <param name="EntityId">The Id of the referred entity.</param>
        /// <param name="EntityName">The name of the entity the auditLog refers to.</param>
        /// <param name="Action">The action (created, updated, deleted etc).</param>
        /// <param name="Id">Id.</param>
        public AuditLogEntityDto(long? AuditLogId = default(long?), string CustomData = default(string), long? EntityId = default(long?), string EntityName = default(string), ActionEnum? Action = default(ActionEnum?), long? Id = default(long?))
        {
            this.AuditLogId = AuditLogId;
            this.CustomData = CustomData;
            this.EntityId = EntityId;
            this.EntityName = EntityName;
            this.Action = Action;
            this.Id = Id;
        }
        
        /// <summary>
        /// Business audit entry that triggered the changes
        /// </summary>
        /// <value>Business audit entry that triggered the changes</value>
        [DataMember(Name="AuditLogId", EmitDefaultValue=false)]
        public long? AuditLogId { get; set; }

        /// <summary>
        /// Data about the old/new/included values
        /// </summary>
        /// <value>Data about the old/new/included values</value>
        [DataMember(Name="CustomData", EmitDefaultValue=false)]
        public string CustomData { get; set; }

        /// <summary>
        /// The Id of the referred entity
        /// </summary>
        /// <value>The Id of the referred entity</value>
        [DataMember(Name="EntityId", EmitDefaultValue=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// The name of the entity the auditLog refers to
        /// </summary>
        /// <value>The name of the entity the auditLog refers to</value>
        [DataMember(Name="EntityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }


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
            sb.Append("class AuditLogEntityDto {\n");
            sb.Append("  AuditLogId: ").Append(AuditLogId).Append("\n");
            sb.Append("  CustomData: ").Append(CustomData).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as AuditLogEntityDto);
        }

        /// <summary>
        /// Returns true if AuditLogEntityDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditLogEntityDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogEntityDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuditLogId == input.AuditLogId ||
                    (this.AuditLogId != null &&
                    this.AuditLogId.Equals(input.AuditLogId))
                ) && 
                (
                    this.CustomData == input.CustomData ||
                    (this.CustomData != null &&
                    this.CustomData.Equals(input.CustomData))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.AuditLogId != null)
                    hashCode = hashCode * 59 + this.AuditLogId.GetHashCode();
                if (this.CustomData != null)
                    hashCode = hashCode * 59 + this.CustomData.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
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