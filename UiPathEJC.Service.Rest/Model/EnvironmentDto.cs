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
    /// A grouping of Robots.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class EnvironmentDto :  IEquatable<EnvironmentDto>, IValidatableObject
    {
        /// <summary>
        /// DEPRECATED. The environment type specifies how it should be used.  This property is deprecated and should no longer be used.
        /// </summary>
        /// <value>DEPRECATED. The environment type specifies how it should be used.  This property is deprecated and should no longer be used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Dev for value: Dev
            /// </summary>
            [EnumMember(Value = "Dev")]
            Dev = 1,
            
            /// <summary>
            /// Enum Test for value: Test
            /// </summary>
            [EnumMember(Value = "Test")]
            Test = 2,
            
            /// <summary>
            /// Enum Prod for value: Prod
            /// </summary>
            [EnumMember(Value = "Prod")]
            Prod = 3
        }

        /// <summary>
        /// DEPRECATED. The environment type specifies how it should be used.  This property is deprecated and should no longer be used.
        /// </summary>
        /// <value>DEPRECATED. The environment type specifies how it should be used.  This property is deprecated and should no longer be used.</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnvironmentDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentDto" /> class.
        /// </summary>
        /// <param name="Name">A custom name for the environment. (required).</param>
        /// <param name="Description">Used to add additional information about an environment in order to better identify it..</param>
        /// <param name="Robots">The collection of robots associated with the current environment..</param>
        /// <param name="Type">DEPRECATED. The environment type specifies how it should be used.  This property is deprecated and should no longer be used..</param>
        /// <param name="Id">Id.</param>
        public EnvironmentDto(string Name = default(string), string Description = default(string), List<SimpleRobotDto> Robots = default(List<SimpleRobotDto>), TypeEnum? Type = default(TypeEnum?), long? Id = default(long?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for EnvironmentDto and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Description = Description;
            this.Robots = Robots;
            this.Type = Type;
            this.Id = Id;
        }
        
        /// <summary>
        /// A custom name for the environment.
        /// </summary>
        /// <value>A custom name for the environment.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Used to add additional information about an environment in order to better identify it.
        /// </summary>
        /// <value>Used to add additional information about an environment in order to better identify it.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The collection of robots associated with the current environment.
        /// </summary>
        /// <value>The collection of robots associated with the current environment.</value>
        [DataMember(Name="Robots", EmitDefaultValue=false)]
        public List<SimpleRobotDto> Robots { get; set; }


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
            sb.Append("class EnvironmentDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Robots: ").Append(Robots).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as EnvironmentDto);
        }

        /// <summary>
        /// Returns true if EnvironmentDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvironmentDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentDto input)
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
                    this.Robots == input.Robots ||
                    this.Robots != null &&
                    this.Robots.SequenceEqual(input.Robots)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Robots != null)
                    hashCode = hashCode * 59 + this.Robots.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 500.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            yield break;
        }
    }

}
