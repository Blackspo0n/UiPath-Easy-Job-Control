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
    /// ODataResponseListRobotDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class ODataResponseListRobotDto :  IEquatable<ODataResponseListRobotDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataResponseListRobotDto" /> class.
        /// </summary>
        /// <param name="OdataContext">OdataContext.</param>
        /// <param name="Value">Value.</param>
        public ODataResponseListRobotDto(string OdataContext = default(string), List<RobotDto> Value = default(List<RobotDto>))
        {
            this.OdataContext = OdataContext;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets OdataContext
        /// </summary>
        [DataMember(Name="@odata.context", EmitDefaultValue=false)]
        public string OdataContext { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<RobotDto> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ODataResponseListRobotDto {\n");
            sb.Append("  OdataContext: ").Append(OdataContext).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ODataResponseListRobotDto);
        }

        /// <summary>
        /// Returns true if ODataResponseListRobotDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ODataResponseListRobotDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ODataResponseListRobotDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OdataContext == input.OdataContext ||
                    (this.OdataContext != null &&
                    this.OdataContext.Equals(input.OdataContext))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.OdataContext != null)
                    hashCode = hashCode * 59 + this.OdataContext.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
