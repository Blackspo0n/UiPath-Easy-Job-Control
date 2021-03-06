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
    /// This event is raised whenever a new queue item transaction is started
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class QueueItemStartedEventDto :  IEquatable<QueueItemStartedEventDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemStartedEventDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueueItemStartedEventDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemStartedEventDto" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="EventId">EventId (required).</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="QueueItem">QueueItem.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="TenantId">TenantId.</param>
        /// <param name="OrganizationUnitId">OrganizationUnitId.</param>
        /// <param name="UserId">UserId.</param>
        public QueueItemStartedEventDto(string Type = default(string), string EventId = default(string), DateTime? Timestamp = default(DateTime?), WebhookQueueItemDto QueueItem = default(WebhookQueueItemDto), WebhookQueueDefinitionDto Queue = default(WebhookQueueDefinitionDto), int? TenantId = default(int?), long? OrganizationUnitId = default(long?), long? UserId = default(long?))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for QueueItemStartedEventDto and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "EventId" is required (not null)
            if (EventId == null)
            {
                throw new InvalidDataException("EventId is a required property for QueueItemStartedEventDto and cannot be null");
            }
            else
            {
                this.EventId = EventId;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for QueueItemStartedEventDto and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            this.QueueItem = QueueItem;
            this.Queue = Queue;
            this.TenantId = TenantId;
            this.OrganizationUnitId = OrganizationUnitId;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="EventId", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets QueueItem
        /// </summary>
        [DataMember(Name="QueueItem", EmitDefaultValue=false)]
        public WebhookQueueItemDto QueueItem { get; set; }

        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="Queue", EmitDefaultValue=false)]
        public WebhookQueueDefinitionDto Queue { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="TenantId", EmitDefaultValue=false)]
        public int? TenantId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationUnitId
        /// </summary>
        [DataMember(Name="OrganizationUnitId", EmitDefaultValue=false)]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueItemStartedEventDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  QueueItem: ").Append(QueueItem).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  OrganizationUnitId: ").Append(OrganizationUnitId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as QueueItemStartedEventDto);
        }

        /// <summary>
        /// Returns true if QueueItemStartedEventDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueItemStartedEventDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueItemStartedEventDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.QueueItem == input.QueueItem ||
                    (this.QueueItem != null &&
                    this.QueueItem.Equals(input.QueueItem))
                ) && 
                (
                    this.Queue == input.Queue ||
                    (this.Queue != null &&
                    this.Queue.Equals(input.Queue))
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.QueueItem != null)
                    hashCode = hashCode * 59 + this.QueueItem.GetHashCode();
                if (this.Queue != null)
                    hashCode = hashCode * 59 + this.Queue.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.OrganizationUnitId != null)
                    hashCode = hashCode * 59 + this.OrganizationUnitId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
            // EventId (string) maxLength
            if(this.EventId != null && this.EventId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventId, length must be less than 50.", new [] { "EventId" });
            }

            // EventId (string) minLength
            if(this.EventId != null && this.EventId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventId, length must be greater than 0.", new [] { "EventId" });
            }

            yield break;
        }
    }

}
