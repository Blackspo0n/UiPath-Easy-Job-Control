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
    /// QueueItemParameters
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class QueueItemParameters :  IEquatable<QueueItemParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemParameters" /> class.
        /// </summary>
        /// <param name="ItemData">ItemData.</param>
        public QueueItemParameters(QueueItemDataDto ItemData = default(QueueItemDataDto))
        {
            this.ItemData = ItemData;
        }
        
        /// <summary>
        /// Gets or Sets ItemData
        /// </summary>
        [DataMember(Name="itemData", EmitDefaultValue=false)]
        public QueueItemDataDto ItemData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueItemParameters {\n");
            sb.Append("  ItemData: ").Append(ItemData).Append("\n");
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
            return this.Equals(input as QueueItemParameters);
        }

        /// <summary>
        /// Returns true if QueueItemParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueItemParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueItemParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemData == input.ItemData ||
                    (this.ItemData != null &&
                    this.ItemData.Equals(input.ItemData))
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
                if (this.ItemData != null)
                    hashCode = hashCode * 59 + this.ItemData.GetHashCode();
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
