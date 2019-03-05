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
    /// The definition of a work queue. A work queue contains work items that are processed by robots.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class QueueDefinitionDto :  IEquatable<QueueDefinitionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueDefinitionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueueDefinitionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueDefinitionDto" /> class.
        /// </summary>
        /// <param name="Name">A custom name for the queue. (required).</param>
        /// <param name="Description">Used to add additional information about a queue in order to better identify it..</param>
        /// <param name="MaxNumberOfRetries">An integer value representing the number of times an item of this queue can be retried if its processing fails with application exception and auto retry is on..</param>
        /// <param name="AcceptAutomaticallyRetry">States whether a robot should retry to process an item if, after processing, it failed with application exception..</param>
        /// <param name="EnforceUniqueReference">States whether Item Reference field should be unique per Queue. Deleted and retried items are not checked against this rule..</param>
        /// <param name="CreationTime">The date and time when the queue was created..</param>
        /// <param name="Id">Id.</param>
        public QueueDefinitionDto(string Name = default(string), string Description = default(string), int? MaxNumberOfRetries = default(int?), bool? AcceptAutomaticallyRetry = default(bool?), bool? EnforceUniqueReference = default(bool?), DateTime? CreationTime = default(DateTime?), long? Id = default(long?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for QueueDefinitionDto and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Description = Description;
            this.MaxNumberOfRetries = MaxNumberOfRetries;
            this.AcceptAutomaticallyRetry = AcceptAutomaticallyRetry;
            this.EnforceUniqueReference = EnforceUniqueReference;
            this.CreationTime = CreationTime;
            this.Id = Id;
        }
        
        /// <summary>
        /// A custom name for the queue.
        /// </summary>
        /// <value>A custom name for the queue.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Used to add additional information about a queue in order to better identify it.
        /// </summary>
        /// <value>Used to add additional information about a queue in order to better identify it.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An integer value representing the number of times an item of this queue can be retried if its processing fails with application exception and auto retry is on.
        /// </summary>
        /// <value>An integer value representing the number of times an item of this queue can be retried if its processing fails with application exception and auto retry is on.</value>
        [DataMember(Name="MaxNumberOfRetries", EmitDefaultValue=false)]
        public int? MaxNumberOfRetries { get; set; }

        /// <summary>
        /// States whether a robot should retry to process an item if, after processing, it failed with application exception.
        /// </summary>
        /// <value>States whether a robot should retry to process an item if, after processing, it failed with application exception.</value>
        [DataMember(Name="AcceptAutomaticallyRetry", EmitDefaultValue=false)]
        public bool? AcceptAutomaticallyRetry { get; set; }

        /// <summary>
        /// States whether Item Reference field should be unique per Queue. Deleted and retried items are not checked against this rule.
        /// </summary>
        /// <value>States whether Item Reference field should be unique per Queue. Deleted and retried items are not checked against this rule.</value>
        [DataMember(Name="EnforceUniqueReference", EmitDefaultValue=false)]
        public bool? EnforceUniqueReference { get; set; }

        /// <summary>
        /// The date and time when the queue was created.
        /// </summary>
        /// <value>The date and time when the queue was created.</value>
        [DataMember(Name="CreationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }

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
            sb.Append("class QueueDefinitionDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MaxNumberOfRetries: ").Append(MaxNumberOfRetries).Append("\n");
            sb.Append("  AcceptAutomaticallyRetry: ").Append(AcceptAutomaticallyRetry).Append("\n");
            sb.Append("  EnforceUniqueReference: ").Append(EnforceUniqueReference).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
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
            return this.Equals(input as QueueDefinitionDto);
        }

        /// <summary>
        /// Returns true if QueueDefinitionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueDefinitionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueDefinitionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MaxNumberOfRetries == input.MaxNumberOfRetries ||
                    (this.MaxNumberOfRetries != null &&
                    this.MaxNumberOfRetries.Equals(input.MaxNumberOfRetries))
                ) && 
                (
                    this.AcceptAutomaticallyRetry == input.AcceptAutomaticallyRetry ||
                    (this.AcceptAutomaticallyRetry != null &&
                    this.AcceptAutomaticallyRetry.Equals(input.AcceptAutomaticallyRetry))
                ) && 
                (
                    this.EnforceUniqueReference == input.EnforceUniqueReference ||
                    (this.EnforceUniqueReference != null &&
                    this.EnforceUniqueReference.Equals(input.EnforceUniqueReference))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MaxNumberOfRetries != null)
                    hashCode = hashCode * 59 + this.MaxNumberOfRetries.GetHashCode();
                if (this.AcceptAutomaticallyRetry != null)
                    hashCode = hashCode * 59 + this.AcceptAutomaticallyRetry.GetHashCode();
                if (this.EnforceUniqueReference != null)
                    hashCode = hashCode * 59 + this.EnforceUniqueReference.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
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
