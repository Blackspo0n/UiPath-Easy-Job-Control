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
    /// MachinesRobotVersionDto
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class MachinesRobotVersionDto :  IEquatable<MachinesRobotVersionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MachinesRobotVersionDto" /> class.
        /// </summary>
        /// <param name="Count">The number of Robots on the Machine with the specified version..</param>
        /// <param name="Version">The Version of the Robot hosted on the Machine..</param>
        /// <param name="MachineId">The Id of the Machine..</param>
        public MachinesRobotVersionDto(long? Count = default(long?), string Version = default(string), long? MachineId = default(long?))
        {
            this.Count = Count;
            this.Version = Version;
            this.MachineId = MachineId;
        }
        
        /// <summary>
        /// The number of Robots on the Machine with the specified version.
        /// </summary>
        /// <value>The number of Robots on the Machine with the specified version.</value>
        [DataMember(Name="Count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The Version of the Robot hosted on the Machine.
        /// </summary>
        /// <value>The Version of the Robot hosted on the Machine.</value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The Id of the Machine.
        /// </summary>
        /// <value>The Id of the Machine.</value>
        [DataMember(Name="MachineId", EmitDefaultValue=false)]
        public long? MachineId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MachinesRobotVersionDto {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  MachineId: ").Append(MachineId).Append("\n");
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
            return this.Equals(input as MachinesRobotVersionDto);
        }

        /// <summary>
        /// Returns true if MachinesRobotVersionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MachinesRobotVersionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MachinesRobotVersionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.MachineId == input.MachineId ||
                    (this.MachineId != null &&
                    this.MachineId.Equals(input.MachineId))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.MachineId != null)
                    hashCode = hashCode * 59 + this.MachineId.GetHashCode();
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