using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// KYCShareholderCheckResult
    /// </summary>
    [DataContract]
        public class KYCShareholderCheckResult :  IEquatable<KYCShareholderCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KYCShareholderCheckResult" /> class.
        /// </summary>
        /// <param name="checks">A list of the checks and their statuses. (required).</param>
        /// <param name="shareholderCode">The code of the shareholder to which the check applies. (required).</param>
        public KYCShareholderCheckResult(List<KYCCheckStatusData> checks = default(List<KYCCheckStatusData>), string shareholderCode = default(string))
        {
            // to ensure "checks" is required (not null)
            if (checks == null)
            {
                throw new InvalidDataException("checks is a required property for KYCShareholderCheckResult and cannot be null");
            }

            Checks = checks;
            // to ensure "shareholderCode" is required (not null)
            if (shareholderCode == null)
            {
                throw new InvalidDataException("shareholderCode is a required property for KYCShareholderCheckResult and cannot be null");
            }

            ShareholderCode = shareholderCode;
        }
        
        /// <summary>
        /// A list of the checks and their statuses.
        /// </summary>
        /// <value>A list of the checks and their statuses.</value>
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public List<KYCCheckStatusData> Checks { get; set; }

        /// <summary>
        /// The code of the shareholder to which the check applies.
        /// </summary>
        /// <value>The code of the shareholder to which the check applies.</value>
        [DataMember(Name="shareholderCode", EmitDefaultValue=false)]
        public string ShareholderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KYCShareholderCheckResult {\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  ShareholderCode: ").Append(ShareholderCode).Append("\n");
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
            return Equals(input as KYCShareholderCheckResult);
        }

        /// <summary>
        /// Returns true if KYCShareholderCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of KYCShareholderCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KYCShareholderCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    Checks == input.Checks ||
                    Checks != null &&
                    input.Checks != null &&
                    Checks.SequenceEqual(input.Checks)
                ) && 
                (
                    ShareholderCode == input.ShareholderCode ||
                    (ShareholderCode != null &&
                    ShareholderCode.Equals(input.ShareholderCode))
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
                if (Checks != null)
                    hashCode = hashCode * 59 + Checks.GetHashCode();
                if (ShareholderCode != null)
                    hashCode = hashCode * 59 + ShareholderCode.GetHashCode();
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
