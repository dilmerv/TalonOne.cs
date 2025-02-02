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
    /// CartItem
    /// </summary>
    [DataContract]
    public partial class CartItem :  IEquatable<CartItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CartItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItem" /> class.
        /// </summary>
        /// <param name="name">Name of item (required).</param>
        /// <param name="sku">Stock keeping unit of item (required).</param>
        /// <param name="quantity">Quantity of item. **Important:** If you enabled [cart item flattening](https://help.talon.one/hc/en-us/articles/360016036899-Flattening-Cart-Items), the quantity is always one and the same cart item might receive multiple per-item discounts. Ensure you can process multiple discounts on one cart item correctly.  (required).</param>
        /// <param name="price">Price of item (required).</param>
        /// <param name="category">Type, group or model of the item.</param>
        /// <param name="weight">Weight of item in grams.</param>
        /// <param name="height">Height of item in mm.</param>
        /// <param name="width">Width of item in mm.</param>
        /// <param name="length">Length of item in mm.</param>
        /// <param name="position">Position of the Cart Item in the Cart (calculated internally).</param>
        /// <param name="attributes">Arbitrary properties associated with this item. You can use built-in attributes or create your own. See [Attributes](https://docs.talon.one/docs/dev/concepts/attributes). .</param>
        public CartItem(string name = default(string), string sku = default(string), int quantity = default(int), decimal price = default(decimal), string category = default(string), decimal weight = default(decimal), decimal height = default(decimal), decimal width = default(decimal), decimal length = default(decimal), decimal position = default(decimal), Object attributes = default(Object))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CartItem and cannot be null");
            // to ensure "sku" is required (not null)
            this.Sku = sku ?? throw new ArgumentNullException("sku is a required property for CartItem and cannot be null");
            this.Quantity = quantity;
            this.Price = price;
            this.Category = category;
            this.Weight = weight;
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Position = position;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// Name of item
        /// </summary>
        /// <value>Name of item</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Stock keeping unit of item
        /// </summary>
        /// <value>Stock keeping unit of item</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Quantity of item. **Important:** If you enabled [cart item flattening](https://help.talon.one/hc/en-us/articles/360016036899-Flattening-Cart-Items), the quantity is always one and the same cart item might receive multiple per-item discounts. Ensure you can process multiple discounts on one cart item correctly. 
        /// </summary>
        /// <value>Quantity of item. **Important:** If you enabled [cart item flattening](https://help.talon.one/hc/en-us/articles/360016036899-Flattening-Cart-Items), the quantity is always one and the same cart item might receive multiple per-item discounts. Ensure you can process multiple discounts on one cart item correctly. </value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Price of item
        /// </summary>
        /// <value>Price of item</value>
        [DataMember(Name="price", EmitDefaultValue=true)]
        public decimal Price { get; set; }

        /// <summary>
        /// Type, group or model of the item
        /// </summary>
        /// <value>Type, group or model of the item</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Weight of item in grams
        /// </summary>
        /// <value>Weight of item in grams</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Height of item in mm
        /// </summary>
        /// <value>Height of item in mm</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public decimal Height { get; set; }

        /// <summary>
        /// Width of item in mm
        /// </summary>
        /// <value>Width of item in mm</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public decimal Width { get; set; }

        /// <summary>
        /// Length of item in mm
        /// </summary>
        /// <value>Length of item in mm</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public decimal Length { get; set; }

        /// <summary>
        /// Position of the Cart Item in the Cart (calculated internally)
        /// </summary>
        /// <value>Position of the Cart Item in the Cart (calculated internally)</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public decimal Position { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this item. You can use built-in attributes or create your own. See [Attributes](https://docs.talon.one/docs/dev/concepts/attributes). 
        /// </summary>
        /// <value>Arbitrary properties associated with this item. You can use built-in attributes or create your own. See [Attributes](https://docs.talon.one/docs/dev/concepts/attributes). </value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as CartItem);
        }

        /// <summary>
        /// Returns true if CartItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CartItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartItem input)
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
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.Weight.GetHashCode();
                hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.Width.GetHashCode();
                hashCode = hashCode * 59 + this.Length.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
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
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Sku (string) minLength
            if(this.Sku != null && this.Sku.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sku, length must be greater than 1.", new [] { "Sku" });
            }

            // Quantity (int) minimum
            if(this.Quantity < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}
