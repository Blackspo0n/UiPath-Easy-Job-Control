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
    /// Stores information about all the permissions a user is associated with in Orchestrator.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class UserPermissionsCollection :  IEquatable<UserPermissionsCollection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPermissionsCollection" /> class.
        /// </summary>
        /// <param name="UserId">The Id of the user associated with the permissions..</param>
        /// <param name="Permissions">The collection of names of the permissions the user is associated with..</param>
        public UserPermissionsCollection(long? UserId = default(long?), List<string> Permissions = default(List<string>))
        {
            this.UserId = UserId;
            this.Permissions = Permissions;
        }
        
        /// <summary>
        /// The Id of the user associated with the permissions.
        /// </summary>
        /// <value>The Id of the user associated with the permissions.</value>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// The collection of names of the permissions the user is associated with.
        /// </summary>
        /// <value>The collection of names of the permissions the user is associated with.</value>
        [DataMember(Name="Permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPermissionsCollection {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as UserPermissionsCollection);
        }

        /// <summary>
        /// Returns true if UserPermissionsCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPermissionsCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPermissionsCollection input)
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
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
