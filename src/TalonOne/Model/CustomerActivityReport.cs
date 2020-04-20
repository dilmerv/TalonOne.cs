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
    /// CustomerActivityReport
    /// </summary>
    [DataContract]
    public partial class CustomerActivityReport :  IEquatable<CustomerActivityReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerActivityReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerActivityReport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerActivityReport" /> class.
        /// </summary>
        /// <param name="integrationId">The ID used for this entity in the application system. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="name">The name for this customer profile. (required).</param>
        /// <param name="customerId">The internal Talon.One ID of the customer. (required).</param>
        /// <param name="lastActivity">The last activity of the customer..</param>
        /// <param name="couponRedemptions">Number of coupon redemptions in all customer campaigns. (required).</param>
        /// <param name="couponUseAttempts">Number of coupon use attempts in all customer campaigns. (required).</param>
        /// <param name="couponFailedAttempts">Number of failed coupon use attempts in all customer campaigns. (required).</param>
        /// <param name="accruedDiscounts">Number of accrued discounts in all customer campaigns. (required).</param>
        /// <param name="accruedRevenue">Amount of accrued revenue in all customer campaigns. (required).</param>
        /// <param name="totalOrders">Number of orders in all customer campaigns. (required).</param>
        /// <param name="totalOrdersNoCoupon">Number of orders without coupon used in all customer campaigns. (required).</param>
        /// <param name="campaignName">The name of the campaign this customer belongs to. (required).</param>
        public CustomerActivityReport(string integrationId = default(string), DateTime created = default(DateTime), string name = default(string), int customerId = default(int), DateTime lastActivity = default(DateTime), int couponRedemptions = default(int), int couponUseAttempts = default(int), int couponFailedAttempts = default(int), decimal accruedDiscounts = default(decimal), decimal accruedRevenue = default(decimal), int totalOrders = default(int), int totalOrdersNoCoupon = default(int), string campaignName = default(string))
        {
            // to ensure "integrationId" is required (not null)
            if (integrationId == null)
            {
                throw new InvalidDataException("integrationId is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.IntegrationId = integrationId;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "customerId" is required (not null)
            if (customerId == null)
            {
                throw new InvalidDataException("customerId is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.CustomerId = customerId;
            }
            
            // to ensure "couponRedemptions" is required (not null)
            if (couponRedemptions == null)
            {
                throw new InvalidDataException("couponRedemptions is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.CouponRedemptions = couponRedemptions;
            }
            
            // to ensure "couponUseAttempts" is required (not null)
            if (couponUseAttempts == null)
            {
                throw new InvalidDataException("couponUseAttempts is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.CouponUseAttempts = couponUseAttempts;
            }
            
            // to ensure "couponFailedAttempts" is required (not null)
            if (couponFailedAttempts == null)
            {
                throw new InvalidDataException("couponFailedAttempts is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.CouponFailedAttempts = couponFailedAttempts;
            }
            
            // to ensure "accruedDiscounts" is required (not null)
            if (accruedDiscounts == null)
            {
                throw new InvalidDataException("accruedDiscounts is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.AccruedDiscounts = accruedDiscounts;
            }
            
            // to ensure "accruedRevenue" is required (not null)
            if (accruedRevenue == null)
            {
                throw new InvalidDataException("accruedRevenue is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.AccruedRevenue = accruedRevenue;
            }
            
            // to ensure "totalOrders" is required (not null)
            if (totalOrders == null)
            {
                throw new InvalidDataException("totalOrders is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.TotalOrders = totalOrders;
            }
            
            // to ensure "totalOrdersNoCoupon" is required (not null)
            if (totalOrdersNoCoupon == null)
            {
                throw new InvalidDataException("totalOrdersNoCoupon is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.TotalOrdersNoCoupon = totalOrdersNoCoupon;
            }
            
            // to ensure "campaignName" is required (not null)
            if (campaignName == null)
            {
                throw new InvalidDataException("campaignName is a required property for CustomerActivityReport and cannot be null");
            }
            else
            {
                this.CampaignName = campaignName;
            }
            
            this.LastActivity = lastActivity;
        }
        
        /// <summary>
        /// The ID used for this entity in the application system.
        /// </summary>
        /// <value>The ID used for this entity in the application system.</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The name for this customer profile.
        /// </summary>
        /// <value>The name for this customer profile.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The internal Talon.One ID of the customer.
        /// </summary>
        /// <value>The internal Talon.One ID of the customer.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public int CustomerId { get; set; }

        /// <summary>
        /// The last activity of the customer.
        /// </summary>
        /// <value>The last activity of the customer.</value>
        [DataMember(Name="lastActivity", EmitDefaultValue=false)]
        public DateTime LastActivity { get; set; }

        /// <summary>
        /// Number of coupon redemptions in all customer campaigns.
        /// </summary>
        /// <value>Number of coupon redemptions in all customer campaigns.</value>
        [DataMember(Name="couponRedemptions", EmitDefaultValue=false)]
        public int CouponRedemptions { get; set; }

        /// <summary>
        /// Number of coupon use attempts in all customer campaigns.
        /// </summary>
        /// <value>Number of coupon use attempts in all customer campaigns.</value>
        [DataMember(Name="couponUseAttempts", EmitDefaultValue=false)]
        public int CouponUseAttempts { get; set; }

        /// <summary>
        /// Number of failed coupon use attempts in all customer campaigns.
        /// </summary>
        /// <value>Number of failed coupon use attempts in all customer campaigns.</value>
        [DataMember(Name="couponFailedAttempts", EmitDefaultValue=false)]
        public int CouponFailedAttempts { get; set; }

        /// <summary>
        /// Number of accrued discounts in all customer campaigns.
        /// </summary>
        /// <value>Number of accrued discounts in all customer campaigns.</value>
        [DataMember(Name="accruedDiscounts", EmitDefaultValue=false)]
        public decimal AccruedDiscounts { get; set; }

        /// <summary>
        /// Amount of accrued revenue in all customer campaigns.
        /// </summary>
        /// <value>Amount of accrued revenue in all customer campaigns.</value>
        [DataMember(Name="accruedRevenue", EmitDefaultValue=false)]
        public decimal AccruedRevenue { get; set; }

        /// <summary>
        /// Number of orders in all customer campaigns.
        /// </summary>
        /// <value>Number of orders in all customer campaigns.</value>
        [DataMember(Name="totalOrders", EmitDefaultValue=false)]
        public int TotalOrders { get; set; }

        /// <summary>
        /// Number of orders without coupon used in all customer campaigns.
        /// </summary>
        /// <value>Number of orders without coupon used in all customer campaigns.</value>
        [DataMember(Name="totalOrdersNoCoupon", EmitDefaultValue=false)]
        public int TotalOrdersNoCoupon { get; set; }

        /// <summary>
        /// The name of the campaign this customer belongs to.
        /// </summary>
        /// <value>The name of the campaign this customer belongs to.</value>
        [DataMember(Name="campaignName", EmitDefaultValue=false)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerActivityReport {\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
            sb.Append("  CouponRedemptions: ").Append(CouponRedemptions).Append("\n");
            sb.Append("  CouponUseAttempts: ").Append(CouponUseAttempts).Append("\n");
            sb.Append("  CouponFailedAttempts: ").Append(CouponFailedAttempts).Append("\n");
            sb.Append("  AccruedDiscounts: ").Append(AccruedDiscounts).Append("\n");
            sb.Append("  AccruedRevenue: ").Append(AccruedRevenue).Append("\n");
            sb.Append("  TotalOrders: ").Append(TotalOrders).Append("\n");
            sb.Append("  TotalOrdersNoCoupon: ").Append(TotalOrdersNoCoupon).Append("\n");
            sb.Append("  CampaignName: ").Append(CampaignName).Append("\n");
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
            return this.Equals(input as CustomerActivityReport);
        }

        /// <summary>
        /// Returns true if CustomerActivityReport instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerActivityReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerActivityReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.LastActivity == input.LastActivity ||
                    (this.LastActivity != null &&
                    this.LastActivity.Equals(input.LastActivity))
                ) && 
                (
                    this.CouponRedemptions == input.CouponRedemptions ||
                    (this.CouponRedemptions != null &&
                    this.CouponRedemptions.Equals(input.CouponRedemptions))
                ) && 
                (
                    this.CouponUseAttempts == input.CouponUseAttempts ||
                    (this.CouponUseAttempts != null &&
                    this.CouponUseAttempts.Equals(input.CouponUseAttempts))
                ) && 
                (
                    this.CouponFailedAttempts == input.CouponFailedAttempts ||
                    (this.CouponFailedAttempts != null &&
                    this.CouponFailedAttempts.Equals(input.CouponFailedAttempts))
                ) && 
                (
                    this.AccruedDiscounts == input.AccruedDiscounts ||
                    (this.AccruedDiscounts != null &&
                    this.AccruedDiscounts.Equals(input.AccruedDiscounts))
                ) && 
                (
                    this.AccruedRevenue == input.AccruedRevenue ||
                    (this.AccruedRevenue != null &&
                    this.AccruedRevenue.Equals(input.AccruedRevenue))
                ) && 
                (
                    this.TotalOrders == input.TotalOrders ||
                    (this.TotalOrders != null &&
                    this.TotalOrders.Equals(input.TotalOrders))
                ) && 
                (
                    this.TotalOrdersNoCoupon == input.TotalOrdersNoCoupon ||
                    (this.TotalOrdersNoCoupon != null &&
                    this.TotalOrdersNoCoupon.Equals(input.TotalOrdersNoCoupon))
                ) && 
                (
                    this.CampaignName == input.CampaignName ||
                    (this.CampaignName != null &&
                    this.CampaignName.Equals(input.CampaignName))
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
                if (this.IntegrationId != null)
                    hashCode = hashCode * 59 + this.IntegrationId.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.LastActivity != null)
                    hashCode = hashCode * 59 + this.LastActivity.GetHashCode();
                if (this.CouponRedemptions != null)
                    hashCode = hashCode * 59 + this.CouponRedemptions.GetHashCode();
                if (this.CouponUseAttempts != null)
                    hashCode = hashCode * 59 + this.CouponUseAttempts.GetHashCode();
                if (this.CouponFailedAttempts != null)
                    hashCode = hashCode * 59 + this.CouponFailedAttempts.GetHashCode();
                if (this.AccruedDiscounts != null)
                    hashCode = hashCode * 59 + this.AccruedDiscounts.GetHashCode();
                if (this.AccruedRevenue != null)
                    hashCode = hashCode * 59 + this.AccruedRevenue.GetHashCode();
                if (this.TotalOrders != null)
                    hashCode = hashCode * 59 + this.TotalOrders.GetHashCode();
                if (this.TotalOrdersNoCoupon != null)
                    hashCode = hashCode * 59 + this.TotalOrdersNoCoupon.GetHashCode();
                if (this.CampaignName != null)
                    hashCode = hashCode * 59 + this.CampaignName.GetHashCode();
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
