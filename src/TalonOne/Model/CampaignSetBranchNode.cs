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
    /// CampaignSetBranchNode
    /// </summary>
    [DataContract]
    public partial class CampaignSetBranchNode :  IEquatable<CampaignSetBranchNode>, IValidatableObject
    {
        /// <summary>
        /// Indicates the node type
        /// </summary>
        /// <value>Indicates the node type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SET for value: SET
            /// </summary>
            [EnumMember(Value = "SET")]
            SET = 1

        }

        /// <summary>
        /// Indicates the node type
        /// </summary>
        /// <value>Indicates the node type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// How does the set operates on its elements
        /// </summary>
        /// <value>How does the set operates on its elements</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 1,

            /// <summary>
            /// Enum FIRST for value: FIRST
            /// </summary>
            [EnumMember(Value = "FIRST")]
            FIRST = 2

        }

        /// <summary>
        /// How does the set operates on its elements
        /// </summary>
        /// <value>How does the set operates on its elements</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSetBranchNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignSetBranchNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSetBranchNode" /> class.
        /// </summary>
        /// <param name="type">Indicates the node type (required).</param>
        /// <param name="name">Name of the set (required).</param>
        /// <param name="_operator">How does the set operates on its elements (required).</param>
        /// <param name="elements">Child elements of this set (required).</param>
        public CampaignSetBranchNode(TypeEnum type = default(TypeEnum), string name = default(string), OperatorEnum _operator = default(OperatorEnum), List<CampaignSetNode> elements = default(List<CampaignSetNode>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CampaignSetBranchNode and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CampaignSetBranchNode and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "_operator" is required (not null)
            if (_operator == null)
            {
                throw new InvalidDataException("_operator is a required property for CampaignSetBranchNode and cannot be null");
            }
            else
            {
                this.Operator = _operator;
            }
            
            // to ensure "elements" is required (not null)
            if (elements == null)
            {
                throw new InvalidDataException("elements is a required property for CampaignSetBranchNode and cannot be null");
            }
            else
            {
                this.Elements = elements;
            }
            
        }
        

        /// <summary>
        /// Name of the set
        /// </summary>
        /// <value>Name of the set</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Child elements of this set
        /// </summary>
        /// <value>Child elements of this set</value>
        [DataMember(Name="elements", EmitDefaultValue=false)]
        public List<CampaignSetNode> Elements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignSetBranchNode {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
            return this.Equals(input as CampaignSetBranchNode);
        }

        /// <summary>
        /// Returns true if CampaignSetBranchNode instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignSetBranchNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignSetBranchNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    input.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Elements != null)
                    hashCode = hashCode * 59 + this.Elements.GetHashCode();
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
