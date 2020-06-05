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
    /// The properties specific to the \&quot;showNotification\&quot; effect. This gets triggered whenever a validated rule contained a \&quot;show notification\&quot; effect.
    /// </summary>
    [DataContract]
    public partial class ShowNotificationEffectProps :  IEquatable<ShowNotificationEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowNotificationEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShowNotificationEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowNotificationEffectProps" /> class.
        /// </summary>
        /// <param name="notificationType">The type of notification that should be shown (e.g. error/warning/info) (required).</param>
        /// <param name="title">Title of the notification (required).</param>
        /// <param name="body">Body of the notification (required).</param>
        public ShowNotificationEffectProps(string notificationType = default(string), string title = default(string), string body = default(string))
        {
            // to ensure "notificationType" is required (not null)
            if (notificationType == null)
            {
                throw new InvalidDataException("notificationType is a required property for ShowNotificationEffectProps and cannot be null");
            }
            else
            {
                this.NotificationType = notificationType;
            }
            
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ShowNotificationEffectProps and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for ShowNotificationEffectProps and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            
        }
        
        /// <summary>
        /// The type of notification that should be shown (e.g. error/warning/info)
        /// </summary>
        /// <value>The type of notification that should be shown (e.g. error/warning/info)</value>
        [DataMember(Name="notificationType", EmitDefaultValue=false)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Title of the notification
        /// </summary>
        /// <value>Title of the notification</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Body of the notification
        /// </summary>
        /// <value>Body of the notification</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNotificationEffectProps {\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as ShowNotificationEffectProps);
        }

        /// <summary>
        /// Returns true if ShowNotificationEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowNotificationEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowNotificationEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotificationType == input.NotificationType ||
                    (this.NotificationType != null &&
                    this.NotificationType.Equals(input.NotificationType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.NotificationType != null)
                    hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
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