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
    /// WebhookEventDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class WebhookEventDto :  IEquatable<WebhookEventDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookEventDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventDto" /> class.
        /// </summary>
        /// <param name="EventType">EventType (required).</param>
        public WebhookEventDto(string EventType = default(string))
        {
            // to ensure "EventType" is required (not null)
            if (EventType == null)
            {
                throw new InvalidDataException("EventType is a required property for WebhookEventDto and cannot be null");
            }
            else
            {
                this.EventType = EventType;
            }
        }
        
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="EventType", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEventDto {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(input as WebhookEventDto);
        }

        /// <summary>
        /// Returns true if WebhookEventDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEventDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
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
            // EventType (string) maxLength
            if(this.EventType != null && this.EventType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be less than 50.", new [] { "EventType" });
            }

            // EventType (string) minLength
            if(this.EventType != null && this.EventType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be greater than 0.", new [] { "EventType" });
            }

            yield break;
        }
    }

}
