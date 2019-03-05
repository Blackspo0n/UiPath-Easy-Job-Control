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
    /// SetReviewerBulkParameters
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class SetReviewerBulkParameters :  IEquatable<SetReviewerBulkParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetReviewerBulkParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetReviewerBulkParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetReviewerBulkParameters" /> class.
        /// </summary>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="QueueItems">QueueItems.</param>
        public SetReviewerBulkParameters(long? UserId = default(long?), List<LongVersionedEntity> QueueItems = default(List<LongVersionedEntity>))
        {
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for SetReviewerBulkParameters and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            this.QueueItems = QueueItems;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets QueueItems
        /// </summary>
        [DataMember(Name="queueItems", EmitDefaultValue=false)]
        public List<LongVersionedEntity> QueueItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetReviewerBulkParameters {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  QueueItems: ").Append(QueueItems).Append("\n");
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
            return this.Equals(input as SetReviewerBulkParameters);
        }

        /// <summary>
        /// Returns true if SetReviewerBulkParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SetReviewerBulkParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetReviewerBulkParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.QueueItems == input.QueueItems ||
                    this.QueueItems != null &&
                    this.QueueItems.SequenceEqual(input.QueueItems)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.QueueItems != null)
                    hashCode = hashCode * 59 + this.QueueItems.GetHashCode();
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