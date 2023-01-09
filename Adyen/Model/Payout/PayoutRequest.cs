/*
* Adyen Payout API
*
*
* The version of the OpenAPI document: 68
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.Payout
{
    /// <summary>
    /// PayoutRequest
    /// </summary>
    [DataContract(Name = "PayoutRequest")]
    public partial class PayoutRequest : IEquatable<PayoutRequest>, IValidatableObject
    {
        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShopperInteractionEnum
        {
            /// <summary>
            /// Enum Ecommerce for value: Ecommerce
            /// </summary>
            [EnumMember(Value = "Ecommerce")]
            Ecommerce = 1,

            /// <summary>
            /// Enum ContAuth for value: ContAuth
            /// </summary>
            [EnumMember(Value = "ContAuth")]
            ContAuth = 2,

            /// <summary>
            /// Enum Moto for value: Moto
            /// </summary>
            [EnumMember(Value = "Moto")]
            Moto = 3,

            /// <summary>
            /// Enum POS for value: POS
            /// </summary>
            [EnumMember(Value = "POS")]
            POS = 4

        }


        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        public ShopperInteractionEnum? ShopperInteraction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="card">card.</param>
        /// <param name="fraudOffset">An integer value that is added to the normal fraud score. The value can be either positive or negative..</param>
        /// <param name="fundSource">fundSource.</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="reference">The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters. (required).</param>
        /// <param name="selectedRecurringDetailReference">The &#x60;recurringDetailReference&#x60; you want to use for this payment. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail..</param>
        /// <param name="shopperEmail">The shopper&#39;s email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperEmail&#x60; for all browser-based and mobile implementations..</param>
        /// <param name="shopperInteraction">Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal..</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="telephoneNumber">The shopper&#39;s telephone number..</param>
        public PayoutRequest(Amount amount = default(Amount), Address billingAddress = default(Address), Card card = default(Card), int fraudOffset = default(int), FundSource fundSource = default(FundSource), string merchantAccount = default(string), Recurring recurring = default(Recurring), string reference = default(string), string selectedRecurringDetailReference = default(string), string shopperEmail = default(string), ShopperInteractionEnum? shopperInteraction = default(ShopperInteractionEnum?), Name shopperName = default(Name), string shopperReference = default(string), string telephoneNumber = default(string))
        {
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.Reference = reference;
            this.BillingAddress = billingAddress;
            this.Card = card;
            this.FraudOffset = fraudOffset;
            this.FundSource = fundSource;
            this.Recurring = recurring;
            this.SelectedRecurringDetailReference = selectedRecurringDetailReference;
            this.ShopperEmail = shopperEmail;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.TelephoneNumber = telephoneNumber;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = true)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name = "card", EmitDefaultValue = false)]
        public Card Card { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        /// <value>An integer value that is added to the normal fraud score. The value can be either positive or negative.</value>
        [DataMember(Name = "fraudOffset", EmitDefaultValue = false)]
        public int FraudOffset { get; set; }

        /// <summary>
        /// Gets or Sets FundSource
        /// </summary>
        [DataMember(Name = "fundSource", EmitDefaultValue = false)]
        public FundSource FundSource { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = true)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets Recurring
        /// </summary>
        [DataMember(Name = "recurring", EmitDefaultValue = false)]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.
        /// </summary>
        /// <value>The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement. If you need to provide multiple references for a transaction, separate them with hyphens (\&quot;-\&quot;). Maximum length: 80 characters.</value>
        [DataMember(Name = "reference", IsRequired = false, EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// The &#x60;recurringDetailReference&#x60; you want to use for this payment. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail.
        /// </summary>
        /// <value>The &#x60;recurringDetailReference&#x60; you want to use for this payment. The value &#x60;LATEST&#x60; can be used to select the most recently stored recurring detail.</value>
        [DataMember(Name = "selectedRecurringDetailReference", EmitDefaultValue = false)]
        public string SelectedRecurringDetailReference { get; set; }

        /// <summary>
        /// The shopper&#39;s email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperEmail&#x60; for all browser-based and mobile implementations.
        /// </summary>
        /// <value>The shopper&#39;s email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperEmail&#x60; for all browser-based and mobile implementations.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets ShopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Required for recurring payments.  Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The shopper&#39;s telephone number.
        /// </summary>
        /// <value>The shopper&#39;s telephone number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayoutRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  FraudOffset: ").Append(FraudOffset).Append("\n");
            sb.Append("  FundSource: ").Append(FundSource).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SelectedRecurringDetailReference: ").Append(SelectedRecurringDetailReference).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayoutRequest);
        }

        /// <summary>
        /// Returns true if PayoutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.Card == input.Card ||
                    (this.Card != null &&
                    this.Card.Equals(input.Card))
                ) && 
                (
                    this.FraudOffset == input.FraudOffset ||
                    this.FraudOffset.Equals(input.FraudOffset)
                ) && 
                (
                    this.FundSource == input.FundSource ||
                    (this.FundSource != null &&
                    this.FundSource.Equals(input.FundSource))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SelectedRecurringDetailReference == input.SelectedRecurringDetailReference ||
                    (this.SelectedRecurringDetailReference != null &&
                    this.SelectedRecurringDetailReference.Equals(input.SelectedRecurringDetailReference))
                ) && 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    this.ShopperInteraction.Equals(input.ShopperInteraction)
                ) && 
                (
                    this.ShopperName == input.ShopperName ||
                    (this.ShopperName != null &&
                    this.ShopperName.Equals(input.ShopperName))
                ) && 
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                }
                if (this.Card != null)
                {
                    hashCode = (hashCode * 59) + this.Card.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FraudOffset.GetHashCode();
                if (this.FundSource != null)
                {
                    hashCode = (hashCode * 59) + this.FundSource.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.Recurring != null)
                {
                    hashCode = (hashCode * 59) + this.Recurring.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.SelectedRecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.SelectedRecurringDetailReference.GetHashCode();
                }
                if (this.ShopperEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperEmail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShopperInteraction.GetHashCode();
                if (this.ShopperName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperName.GetHashCode();
                }
                if (this.ShopperReference != null)
                {
                    hashCode = (hashCode * 59) + this.ShopperReference.GetHashCode();
                }
                if (this.TelephoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TelephoneNumber.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
