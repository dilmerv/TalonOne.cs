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
    /// LedgerInfo
    /// </summary>
    [DataContract]
    public partial class LedgerInfo :  IEquatable<LedgerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgerInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LedgerInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgerInfo" /> class.
        /// </summary>
        /// <param name="currentBalance">Sum of current active points amounts (required).</param>
        /// <param name="pendingBalance">Sum of pending points amounts (required).</param>
        /// <param name="expiredBalance">Sum of expired points amounts (required).</param>
        /// <param name="spentBalance">Sum of spent points amounts (required).</param>
        /// <param name="tentativeCurrentBalance">Sum of current active points amounts, including additions and deductions on open sessions (required).</param>
        /// <param name="currentTier">currentTier.</param>
        /// <param name="pointsToNextTier">Points required to move up a tier..</param>
        public LedgerInfo(decimal currentBalance = default(decimal), decimal pendingBalance = default(decimal), decimal expiredBalance = default(decimal), decimal spentBalance = default(decimal), decimal tentativeCurrentBalance = default(decimal), Tier currentTier = default(Tier), decimal pointsToNextTier = default(decimal))
        {
            this.CurrentBalance = currentBalance;
            this.PendingBalance = pendingBalance;
            this.ExpiredBalance = expiredBalance;
            this.SpentBalance = spentBalance;
            this.TentativeCurrentBalance = tentativeCurrentBalance;
            this.CurrentTier = currentTier;
            this.PointsToNextTier = pointsToNextTier;
        }
        
        /// <summary>
        /// Sum of current active points amounts
        /// </summary>
        /// <value>Sum of current active points amounts</value>
        [DataMember(Name="currentBalance", EmitDefaultValue=false)]
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// Sum of pending points amounts
        /// </summary>
        /// <value>Sum of pending points amounts</value>
        [DataMember(Name="pendingBalance", EmitDefaultValue=false)]
        public decimal PendingBalance { get; set; }

        /// <summary>
        /// Sum of expired points amounts
        /// </summary>
        /// <value>Sum of expired points amounts</value>
        [DataMember(Name="expiredBalance", EmitDefaultValue=false)]
        public decimal ExpiredBalance { get; set; }

        /// <summary>
        /// Sum of spent points amounts
        /// </summary>
        /// <value>Sum of spent points amounts</value>
        [DataMember(Name="spentBalance", EmitDefaultValue=false)]
        public decimal SpentBalance { get; set; }

        /// <summary>
        /// Sum of current active points amounts, including additions and deductions on open sessions
        /// </summary>
        /// <value>Sum of current active points amounts, including additions and deductions on open sessions</value>
        [DataMember(Name="tentativeCurrentBalance", EmitDefaultValue=false)]
        public decimal TentativeCurrentBalance { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTier
        /// </summary>
        [DataMember(Name="currentTier", EmitDefaultValue=false)]
        public Tier CurrentTier { get; set; }

        /// <summary>
        /// Points required to move up a tier.
        /// </summary>
        /// <value>Points required to move up a tier.</value>
        [DataMember(Name="pointsToNextTier", EmitDefaultValue=false)]
        public decimal PointsToNextTier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LedgerInfo {\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  PendingBalance: ").Append(PendingBalance).Append("\n");
            sb.Append("  ExpiredBalance: ").Append(ExpiredBalance).Append("\n");
            sb.Append("  SpentBalance: ").Append(SpentBalance).Append("\n");
            sb.Append("  TentativeCurrentBalance: ").Append(TentativeCurrentBalance).Append("\n");
            sb.Append("  CurrentTier: ").Append(CurrentTier).Append("\n");
            sb.Append("  PointsToNextTier: ").Append(PointsToNextTier).Append("\n");
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
            return this.Equals(input as LedgerInfo);
        }

        /// <summary>
        /// Returns true if LedgerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LedgerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LedgerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    this.CurrentBalance.Equals(input.CurrentBalance)
                ) && 
                (
                    this.PendingBalance == input.PendingBalance ||
                    this.PendingBalance.Equals(input.PendingBalance)
                ) && 
                (
                    this.ExpiredBalance == input.ExpiredBalance ||
                    this.ExpiredBalance.Equals(input.ExpiredBalance)
                ) && 
                (
                    this.SpentBalance == input.SpentBalance ||
                    this.SpentBalance.Equals(input.SpentBalance)
                ) && 
                (
                    this.TentativeCurrentBalance == input.TentativeCurrentBalance ||
                    this.TentativeCurrentBalance.Equals(input.TentativeCurrentBalance)
                ) && 
                (
                    this.CurrentTier == input.CurrentTier ||
                    (this.CurrentTier != null &&
                    this.CurrentTier.Equals(input.CurrentTier))
                ) && 
                (
                    this.PointsToNextTier == input.PointsToNextTier ||
                    this.PointsToNextTier.Equals(input.PointsToNextTier)
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
                hashCode = hashCode * 59 + this.CurrentBalance.GetHashCode();
                hashCode = hashCode * 59 + this.PendingBalance.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiredBalance.GetHashCode();
                hashCode = hashCode * 59 + this.SpentBalance.GetHashCode();
                hashCode = hashCode * 59 + this.TentativeCurrentBalance.GetHashCode();
                if (this.CurrentTier != null)
                    hashCode = hashCode * 59 + this.CurrentTier.GetHashCode();
                hashCode = hashCode * 59 + this.PointsToNextTier.GetHashCode();
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
