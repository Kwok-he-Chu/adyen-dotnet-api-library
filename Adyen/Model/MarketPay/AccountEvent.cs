using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// AccountEvent
    /// </summary>
    [DataContract]
        public class AccountEvent :  IEquatable<AccountEvent>, IValidatableObject
    {
        /// <summary>
        /// The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).
        /// </summary>
        /// <value>The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum EventEnum
        {
            /// <summary>
            /// Enum InactivateAccount for value: InactivateAccount
            /// </summary>
            [EnumMember(Value = "InactivateAccount")]
            InactivateAccount = 1,
            /// <summary>
            /// Enum RefundNotPaidOutTransfers for value: RefundNotPaidOutTransfers
            /// </summary>
            [EnumMember(Value = "RefundNotPaidOutTransfers")]
            RefundNotPaidOutTransfers = 2        }
        /// <summary>
        /// The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).
        /// </summary>
        /// <value>The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public EventEnum Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEvent" /> class.
        /// </summary>
        /// <param name="_event">The event. &gt;Permitted values: &#x60;InactivateAccount&#x60;, &#x60;RefundNotPaidOutTransfers&#x60;. For more information, refer to [Verification checks](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks). (required).</param>
        /// <param name="executionDate">The date on which the event will take place. (required).</param>
        /// <param name="reason">The reason why this event has been created. (required).</param>
        public AccountEvent(EventEnum _event = default(EventEnum), DateTime? executionDate = default(DateTime?), string reason = default(string))
        {
            // to ensure "executionDate" is required (not null)
            if (executionDate == null)
            {
                throw new InvalidDataException("executionDate is a required property for AccountEvent and cannot be null");
            }

            ExecutionDate = executionDate;
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for AccountEvent and cannot be null");
            }

            Reason = reason;
            Event = _event;
        }
        

        /// <summary>
        /// The date on which the event will take place.
        /// </summary>
        /// <value>The date on which the event will take place.</value>
        [DataMember(Name="executionDate", EmitDefaultValue=false)]
        public DateTime? ExecutionDate { get; set; }

        /// <summary>
        /// The reason why this event has been created.
        /// </summary>
        /// <value>The reason why this event has been created.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountEvent {\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return Equals(input as AccountEvent);
        }

        /// <summary>
        /// Returns true if AccountEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    Event == input.Event ||
                    Event.Equals(input.Event)
                ) && 
                (
                    ExecutionDate == input.ExecutionDate ||
                    (ExecutionDate != null &&
                    ExecutionDate.Equals(input.ExecutionDate))
                ) && 
                (
                    Reason == input.Reason ||
                    (Reason != null &&
                    Reason.Equals(input.Reason))
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
                hashCode = hashCode * 59 + Event.GetHashCode();
                if (ExecutionDate != null)
                    hashCode = hashCode * 59 + ExecutionDate.GetHashCode();
                if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
