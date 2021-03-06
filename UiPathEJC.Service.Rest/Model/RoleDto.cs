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
    /// A role acts as a grouping of permissions. Roles are associated with users to provide application authorization.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class RoleDto :  IEquatable<RoleDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleDto" /> class.
        /// </summary>
        /// <param name="Name">A custom name for the role..</param>
        /// <param name="DisplayName">An alternative name used for UI display..</param>
        /// <param name="Groups">Allows grouping multiple roles together..</param>
        /// <param name="IsStatic">States whether this role is defined by the application and cannot be deleted or it is user defined and can be deleted..</param>
        /// <param name="IsEditable">States whether the permissions for this role can be modified or not..</param>
        /// <param name="Permissions">The collection of application permissions associated with the role..</param>
        /// <param name="Id">Id.</param>
        public RoleDto(string Name = default(string), string DisplayName = default(string), string Groups = default(string), bool? IsStatic = default(bool?), bool? IsEditable = default(bool?), List<PermissionDto> Permissions = default(List<PermissionDto>), int? Id = default(int?))
        {
            this.Name = Name;
            this.DisplayName = DisplayName;
            this.Groups = Groups;
            this.IsStatic = IsStatic;
            this.IsEditable = IsEditable;
            this.Permissions = Permissions;
            this.Id = Id;
        }
        
        /// <summary>
        /// A custom name for the role.
        /// </summary>
        /// <value>A custom name for the role.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// An alternative name used for UI display.
        /// </summary>
        /// <value>An alternative name used for UI display.</value>
        [DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Allows grouping multiple roles together.
        /// </summary>
        /// <value>Allows grouping multiple roles together.</value>
        [DataMember(Name="Groups", EmitDefaultValue=false)]
        public string Groups { get; set; }

        /// <summary>
        /// States whether this role is defined by the application and cannot be deleted or it is user defined and can be deleted.
        /// </summary>
        /// <value>States whether this role is defined by the application and cannot be deleted or it is user defined and can be deleted.</value>
        [DataMember(Name="IsStatic", EmitDefaultValue=false)]
        public bool? IsStatic { get; set; }

        /// <summary>
        /// States whether the permissions for this role can be modified or not.
        /// </summary>
        /// <value>States whether the permissions for this role can be modified or not.</value>
        [DataMember(Name="IsEditable", EmitDefaultValue=false)]
        public bool? IsEditable { get; set; }

        /// <summary>
        /// The collection of application permissions associated with the role.
        /// </summary>
        /// <value>The collection of application permissions associated with the role.</value>
        [DataMember(Name="Permissions", EmitDefaultValue=false)]
        public List<PermissionDto> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  IsStatic: ").Append(IsStatic).Append("\n");
            sb.Append("  IsEditable: ").Append(IsEditable).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as RoleDto);
        }

        /// <summary>
        /// Returns true if RoleDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleDto input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
                ) && 
                (
                    this.IsStatic == input.IsStatic ||
                    (this.IsStatic != null &&
                    this.IsStatic.Equals(input.IsStatic))
                ) && 
                (
                    this.IsEditable == input.IsEditable ||
                    (this.IsEditable != null &&
                    this.IsEditable.Equals(input.IsEditable))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.IsStatic != null)
                    hashCode = hashCode * 59 + this.IsStatic.GetHashCode();
                if (this.IsEditable != null)
                    hashCode = hashCode * 59 + this.IsEditable.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
