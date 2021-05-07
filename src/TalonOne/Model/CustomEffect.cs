/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// CustomEffect
    /// </summary>
    [DataContract]
    public partial class CustomEffect :  IEquatable<CustomEffect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEffect" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEffect() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEffect" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="modified">The exact moment this entity was last modified. (required).</param>
        /// <param name="name">The name of this effect. (required).</param>
        /// <param name="title">The title of this effect. (required).</param>
        /// <param name="payload">The JSON payload of this effect. (required).</param>
        /// <param name="description">The description of this effect..</param>
        /// <param name="enabled">Determines if this effect is active. (required).</param>
        /// <param name="subscribedApplicationsIds">A list of the IDs of the applications that this effect is enabled for.</param>
        /// <param name="_params">Array of template argument definitions.</param>
        /// <param name="modifiedBy">ID of the user who last updated this effect if available..</param>
        /// <param name="createdBy">ID of the user who created this effect. (required).</param>
        public CustomEffect(int id = default(int), DateTime created = default(DateTime), int accountId = default(int), DateTime modified = default(DateTime), string name = default(string), string title = default(string), string payload = default(string), string description = default(string), bool enabled = default(bool), List<int> subscribedApplicationsIds = default(List<int>), List<TemplateArgDef> _params = default(List<TemplateArgDef>), int modifiedBy = default(int), int createdBy = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new InvalidDataException("payload is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.Payload = payload;
            }
            
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new InvalidDataException("createdBy is a required property for CustomEffect and cannot be null");
            }
            else
            {
                this.CreatedBy = createdBy;
            }
            
            this.Description = description;
            this.SubscribedApplicationsIds = subscribedApplicationsIds;
            this.Params = _params;
            this.ModifiedBy = modifiedBy;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=true)]
        public int AccountId { get; set; }

        /// <summary>
        /// The exact moment this entity was last modified.
        /// </summary>
        /// <value>The exact moment this entity was last modified.</value>
        [DataMember(Name="modified", EmitDefaultValue=true)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// The name of this effect.
        /// </summary>
        /// <value>The name of this effect.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The title of this effect.
        /// </summary>
        /// <value>The title of this effect.</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// The JSON payload of this effect.
        /// </summary>
        /// <value>The JSON payload of this effect.</value>
        [DataMember(Name="payload", EmitDefaultValue=true)]
        public string Payload { get; set; }

        /// <summary>
        /// The description of this effect.
        /// </summary>
        /// <value>The description of this effect.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Determines if this effect is active.
        /// </summary>
        /// <value>Determines if this effect is active.</value>
        [DataMember(Name="enabled", EmitDefaultValue=true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// A list of the IDs of the applications that this effect is enabled for
        /// </summary>
        /// <value>A list of the IDs of the applications that this effect is enabled for</value>
        [DataMember(Name="subscribedApplicationsIds", EmitDefaultValue=false)]
        public List<int> SubscribedApplicationsIds { get; set; }

        /// <summary>
        /// Array of template argument definitions
        /// </summary>
        /// <value>Array of template argument definitions</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public List<TemplateArgDef> Params { get; set; }

        /// <summary>
        /// ID of the user who last updated this effect if available.
        /// </summary>
        /// <value>ID of the user who last updated this effect if available.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public int ModifiedBy { get; set; }

        /// <summary>
        /// ID of the user who created this effect.
        /// </summary>
        /// <value>ID of the user who created this effect.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=true)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEffect {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SubscribedApplicationsIds: ").Append(SubscribedApplicationsIds).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as CustomEffect);
        }

        /// <summary>
        /// Returns true if CustomEffect instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEffect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEffect input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.SubscribedApplicationsIds == input.SubscribedApplicationsIds ||
                    this.SubscribedApplicationsIds != null &&
                    input.SubscribedApplicationsIds != null &&
                    this.SubscribedApplicationsIds.SequenceEqual(input.SubscribedApplicationsIds)
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.SubscribedApplicationsIds != null)
                    hashCode = hashCode * 59 + this.SubscribedApplicationsIds.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                return hashCode;
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
