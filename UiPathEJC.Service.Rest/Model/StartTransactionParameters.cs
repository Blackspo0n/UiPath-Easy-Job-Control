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
    /// StartTransactionParameters
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class StartTransactionParameters :  IEquatable<StartTransactionParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartTransactionParameters" /> class.
        /// </summary>
        /// <param name="TransactionData">TransactionData.</param>
        public StartTransactionParameters(TransactionDataDto TransactionData = default(TransactionDataDto))
        {
            this.TransactionData = TransactionData;
        }
        
        /// <summary>
        /// Gets or Sets TransactionData
        /// </summary>
        [DataMember(Name="transactionData", EmitDefaultValue=false)]
        public TransactionDataDto TransactionData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartTransactionParameters {\n");
            sb.Append("  TransactionData: ").Append(TransactionData).Append("\n");
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
            return this.Equals(input as StartTransactionParameters);
        }

        /// <summary>
        /// Returns true if StartTransactionParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of StartTransactionParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartTransactionParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionData == input.TransactionData ||
                    (this.TransactionData != null &&
                    this.TransactionData.Equals(input.TransactionData))
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
                if (this.TransactionData != null)
                    hashCode = hashCode * 59 + this.TransactionData.GetHashCode();
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
