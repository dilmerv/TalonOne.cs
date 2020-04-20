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
    /// ApplicationSession
    /// </summary>
    [DataContract]
    public partial class ApplicationSession :  IEquatable<ApplicationSession>, IValidatableObject
    {
        /// <summary>
        /// Indicating if the customer session is in progress (\&quot;open\&quot;), \&quot;closed\&quot;, or \&quot;cancelled\&quot;.
        /// </summary>
        /// <value>Indicating if the customer session is in progress (\&quot;open\&quot;), \&quot;closed\&quot;, or \&quot;cancelled\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 3

        }

        /// <summary>
        /// Indicating if the customer session is in progress (\&quot;open\&quot;), \&quot;closed\&quot;, or \&quot;cancelled\&quot;.
        /// </summary>
        /// <value>Indicating if the customer session is in progress (\&quot;open\&quot;), \&quot;closed\&quot;, or \&quot;cancelled\&quot;.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSession" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. The exact moment this entity was created. (required).</param>
        /// <param name="applicationId">The ID of the application that owns this entity. (required).</param>
        /// <param name="profileId">The globally unique Talon.One ID of the customer that created this entity..</param>
        /// <param name="integrationId">The ID used for this entity in the application system. (required).</param>
        /// <param name="profileintegrationid">Integration ID of the customer for the session..</param>
        /// <param name="coupon">Any coupon code entered. (required).</param>
        /// <param name="referral">Any referral code entered. (required).</param>
        /// <param name="state">Indicating if the customer session is in progress (\&quot;open\&quot;), \&quot;closed\&quot;, or \&quot;cancelled\&quot;. (required).</param>
        /// <param name="cartItems">Serialized JSON representation. (required).</param>
        /// <param name="discounts">A map of labelled discount values, in the same currency as the session. (required).</param>
        /// <param name="total">The total sum of the session before any discounts applied..</param>
        /// <param name="attributes">Arbitrary properties associated with this item.</param>
        public ApplicationSession(int id = default(int), DateTime created = default(DateTime), int applicationId = default(int), int profileId = default(int), string integrationId = default(string), string profileintegrationid = default(string), string coupon = default(string), string referral = default(string), StateEnum state = default(StateEnum), List<CartItem> cartItems = default(List<CartItem>), Dictionary<string, decimal> discounts = default(Dictionary<string, decimal>), decimal total = default(decimal), Object attributes = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            
            // to ensure "integrationId" is required (not null)
            if (integrationId == null)
            {
                throw new InvalidDataException("integrationId is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.IntegrationId = integrationId;
            }
            
            // to ensure "coupon" is required (not null)
            if (coupon == null)
            {
                throw new InvalidDataException("coupon is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.Coupon = coupon;
            }
            
            // to ensure "referral" is required (not null)
            if (referral == null)
            {
                throw new InvalidDataException("referral is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.Referral = referral;
            }
            
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.State = state;
            }
            
            // to ensure "cartItems" is required (not null)
            if (cartItems == null)
            {
                throw new InvalidDataException("cartItems is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.CartItems = cartItems;
            }
            
            // to ensure "discounts" is required (not null)
            if (discounts == null)
            {
                throw new InvalidDataException("discounts is a required property for ApplicationSession and cannot be null");
            }
            else
            {
                this.Discounts = discounts;
            }
            
            this.ProfileId = profileId;
            this.Profileintegrationid = profileintegrationid;
            this.Total = total;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created. The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created. The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the application that owns this entity.
        /// </summary>
        /// <value>The ID of the application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The globally unique Talon.One ID of the customer that created this entity.
        /// </summary>
        /// <value>The globally unique Talon.One ID of the customer that created this entity.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public int ProfileId { get; set; }

        /// <summary>
        /// The ID used for this entity in the application system.
        /// </summary>
        /// <value>The ID used for this entity in the application system.</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Integration ID of the customer for the session.
        /// </summary>
        /// <value>Integration ID of the customer for the session.</value>
        [DataMember(Name="profileintegrationid", EmitDefaultValue=false)]
        public string Profileintegrationid { get; set; }

        /// <summary>
        /// Any coupon code entered.
        /// </summary>
        /// <value>Any coupon code entered.</value>
        [DataMember(Name="coupon", EmitDefaultValue=false)]
        public string Coupon { get; set; }

        /// <summary>
        /// Any referral code entered.
        /// </summary>
        /// <value>Any referral code entered.</value>
        [DataMember(Name="referral", EmitDefaultValue=false)]
        public string Referral { get; set; }


        /// <summary>
        /// Serialized JSON representation.
        /// </summary>
        /// <value>Serialized JSON representation.</value>
        [DataMember(Name="cartItems", EmitDefaultValue=false)]
        public List<CartItem> CartItems { get; set; }

        /// <summary>
        /// A map of labelled discount values, in the same currency as the session.
        /// </summary>
        /// <value>A map of labelled discount values, in the same currency as the session.</value>
        [DataMember(Name="discounts", EmitDefaultValue=false)]
        public Dictionary<string, decimal> Discounts { get; set; }

        /// <summary>
        /// The total sum of the session before any discounts applied.
        /// </summary>
        /// <value>The total sum of the session before any discounts applied.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal Total { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this item
        /// </summary>
        /// <value>Arbitrary properties associated with this item</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Profileintegrationid: ").Append(Profileintegrationid).Append("\n");
            sb.Append("  Coupon: ").Append(Coupon).Append("\n");
            sb.Append("  Referral: ").Append(Referral).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CartItems: ").Append(CartItems).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as ApplicationSession);
        }

        /// <summary>
        /// Returns true if ApplicationSession instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationSession input)
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
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
                ) && 
                (
                    this.Profileintegrationid == input.Profileintegrationid ||
                    (this.Profileintegrationid != null &&
                    this.Profileintegrationid.Equals(input.Profileintegrationid))
                ) && 
                (
                    this.Coupon == input.Coupon ||
                    (this.Coupon != null &&
                    this.Coupon.Equals(input.Coupon))
                ) && 
                (
                    this.Referral == input.Referral ||
                    (this.Referral != null &&
                    this.Referral.Equals(input.Referral))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CartItems == input.CartItems ||
                    this.CartItems != null &&
                    input.CartItems != null &&
                    this.CartItems.SequenceEqual(input.CartItems)
                ) && 
                (
                    this.Discounts == input.Discounts ||
                    this.Discounts != null &&
                    input.Discounts != null &&
                    this.Discounts.SequenceEqual(input.Discounts)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.IntegrationId != null)
                    hashCode = hashCode * 59 + this.IntegrationId.GetHashCode();
                if (this.Profileintegrationid != null)
                    hashCode = hashCode * 59 + this.Profileintegrationid.GetHashCode();
                if (this.Coupon != null)
                    hashCode = hashCode * 59 + this.Coupon.GetHashCode();
                if (this.Referral != null)
                    hashCode = hashCode * 59 + this.Referral.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CartItems != null)
                    hashCode = hashCode * 59 + this.CartItems.GetHashCode();
                if (this.Discounts != null)
                    hashCode = hashCode * 59 + this.Discounts.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
