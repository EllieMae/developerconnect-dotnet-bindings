/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractFundingFees
    /// </summary>
    [DataContract]
    public partial class LoanContractFundingFees :  IEquatable<LoanContractFundingFees>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets CdLineId
        /// </summary>
        [DataMember(Name="cdLineId", EmitDefaultValue=false)]
        public string CdLineId { get; set; }

        /// <summary>
        /// Gets or Sets LineId
        /// </summary>
        [DataMember(Name="lineId", EmitDefaultValue=false)]
        public string LineId { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="lineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets BalanceChecked
        /// </summary>
        [DataMember(Name="balanceChecked", EmitDefaultValue=false)]
        public bool? BalanceChecked { get; set; }

        /// <summary>
        /// Gets or Sets FeeDescription
        /// </summary>
        [DataMember(Name="feeDescription", EmitDefaultValue=false)]
        public string FeeDescription { get; set; }

        /// <summary>
        /// Gets or Sets FeeDescription2015
        /// </summary>
        [DataMember(Name="feeDescription2015", EmitDefaultValue=false)]
        public string FeeDescription2015 { get; set; }

        /// <summary>
        /// Gets or Sets Payee
        /// </summary>
        [DataMember(Name="payee", EmitDefaultValue=false)]
        public string Payee { get; set; }

        /// <summary>
        /// Gets or Sets PaidBy
        /// </summary>
        [DataMember(Name="paidBy", EmitDefaultValue=false)]
        public string PaidBy { get; set; }

        /// <summary>
        /// Gets or Sets PaidTo
        /// </summary>
        [DataMember(Name="paidTo", EmitDefaultValue=false)]
        public string PaidTo { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets PocAmount
        /// </summary>
        [DataMember(Name="pocAmount", EmitDefaultValue=false)]
        public double? PocAmount { get; set; }

        /// <summary>
        /// Gets or Sets PocPaidBy
        /// </summary>
        [DataMember(Name="pocPaidBy", EmitDefaultValue=false)]
        public string PocPaidBy { get; set; }

        /// <summary>
        /// Gets or Sets PtcAmount
        /// </summary>
        [DataMember(Name="ptcAmount", EmitDefaultValue=false)]
        public double? PtcAmount { get; set; }

        /// <summary>
        /// Gets or Sets PtcPaidBy
        /// </summary>
        [DataMember(Name="ptcPaidBy", EmitDefaultValue=false)]
        public string PtcPaidBy { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public Object Tag { get; set; }

        /// <summary>
        /// Gets or Sets PocBorrower2015
        /// </summary>
        [DataMember(Name="pocBorrower2015", EmitDefaultValue=false)]
        public double? PocBorrower2015 { get; set; }

        /// <summary>
        /// Gets or Sets PocSeller2015
        /// </summary>
        [DataMember(Name="pocSeller2015", EmitDefaultValue=false)]
        public double? PocSeller2015 { get; set; }

        /// <summary>
        /// Gets or Sets PocBroker2015
        /// </summary>
        [DataMember(Name="pocBroker2015", EmitDefaultValue=false)]
        public double? PocBroker2015 { get; set; }

        /// <summary>
        /// Gets or Sets PocOther2015
        /// </summary>
        [DataMember(Name="pocOther2015", EmitDefaultValue=false)]
        public double? PocOther2015 { get; set; }

        /// <summary>
        /// Gets or Sets PacBroker2015
        /// </summary>
        [DataMember(Name="pacBroker2015", EmitDefaultValue=false)]
        public double? PacBroker2015 { get; set; }

        /// <summary>
        /// Gets or Sets PacLender2015
        /// </summary>
        [DataMember(Name="pacLender2015", EmitDefaultValue=false)]
        public double? PacLender2015 { get; set; }

        /// <summary>
        /// Gets or Sets PacOther2015
        /// </summary>
        [DataMember(Name="pacOther2015", EmitDefaultValue=false)]
        public double? PacOther2015 { get; set; }

        /// <summary>
        /// Gets or Sets PocLender2015
        /// </summary>
        [DataMember(Name="pocLender2015", EmitDefaultValue=false)]
        public double? PocLender2015 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractFundingFees {\n");
            sb.Append("  CdLineId: ").Append(CdLineId).Append("\n");
            sb.Append("  LineId: ").Append(LineId).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  BalanceChecked: ").Append(BalanceChecked).Append("\n");
            sb.Append("  FeeDescription: ").Append(FeeDescription).Append("\n");
            sb.Append("  FeeDescription2015: ").Append(FeeDescription2015).Append("\n");
            sb.Append("  Payee: ").Append(Payee).Append("\n");
            sb.Append("  PaidBy: ").Append(PaidBy).Append("\n");
            sb.Append("  PaidTo: ").Append(PaidTo).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PocAmount: ").Append(PocAmount).Append("\n");
            sb.Append("  PocPaidBy: ").Append(PocPaidBy).Append("\n");
            sb.Append("  PtcAmount: ").Append(PtcAmount).Append("\n");
            sb.Append("  PtcPaidBy: ").Append(PtcPaidBy).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  PocBorrower2015: ").Append(PocBorrower2015).Append("\n");
            sb.Append("  PocSeller2015: ").Append(PocSeller2015).Append("\n");
            sb.Append("  PocBroker2015: ").Append(PocBroker2015).Append("\n");
            sb.Append("  PocOther2015: ").Append(PocOther2015).Append("\n");
            sb.Append("  PacBroker2015: ").Append(PacBroker2015).Append("\n");
            sb.Append("  PacLender2015: ").Append(PacLender2015).Append("\n");
            sb.Append("  PacOther2015: ").Append(PacOther2015).Append("\n");
            sb.Append("  PocLender2015: ").Append(PocLender2015).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as LoanContractFundingFees);
        }

        /// <summary>
        /// Returns true if LoanContractFundingFees instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractFundingFees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractFundingFees input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CdLineId == input.CdLineId ||
                    (this.CdLineId != null &&
                    this.CdLineId.Equals(input.CdLineId))
                ) && 
                (
                    this.LineId == input.LineId ||
                    (this.LineId != null &&
                    this.LineId.Equals(input.LineId))
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.BalanceChecked == input.BalanceChecked ||
                    (this.BalanceChecked != null &&
                    this.BalanceChecked.Equals(input.BalanceChecked))
                ) && 
                (
                    this.FeeDescription == input.FeeDescription ||
                    (this.FeeDescription != null &&
                    this.FeeDescription.Equals(input.FeeDescription))
                ) && 
                (
                    this.FeeDescription2015 == input.FeeDescription2015 ||
                    (this.FeeDescription2015 != null &&
                    this.FeeDescription2015.Equals(input.FeeDescription2015))
                ) && 
                (
                    this.Payee == input.Payee ||
                    (this.Payee != null &&
                    this.Payee.Equals(input.Payee))
                ) && 
                (
                    this.PaidBy == input.PaidBy ||
                    (this.PaidBy != null &&
                    this.PaidBy.Equals(input.PaidBy))
                ) && 
                (
                    this.PaidTo == input.PaidTo ||
                    (this.PaidTo != null &&
                    this.PaidTo.Equals(input.PaidTo))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.PocAmount == input.PocAmount ||
                    (this.PocAmount != null &&
                    this.PocAmount.Equals(input.PocAmount))
                ) && 
                (
                    this.PocPaidBy == input.PocPaidBy ||
                    (this.PocPaidBy != null &&
                    this.PocPaidBy.Equals(input.PocPaidBy))
                ) && 
                (
                    this.PtcAmount == input.PtcAmount ||
                    (this.PtcAmount != null &&
                    this.PtcAmount.Equals(input.PtcAmount))
                ) && 
                (
                    this.PtcPaidBy == input.PtcPaidBy ||
                    (this.PtcPaidBy != null &&
                    this.PtcPaidBy.Equals(input.PtcPaidBy))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.PocBorrower2015 == input.PocBorrower2015 ||
                    (this.PocBorrower2015 != null &&
                    this.PocBorrower2015.Equals(input.PocBorrower2015))
                ) && 
                (
                    this.PocSeller2015 == input.PocSeller2015 ||
                    (this.PocSeller2015 != null &&
                    this.PocSeller2015.Equals(input.PocSeller2015))
                ) && 
                (
                    this.PocBroker2015 == input.PocBroker2015 ||
                    (this.PocBroker2015 != null &&
                    this.PocBroker2015.Equals(input.PocBroker2015))
                ) && 
                (
                    this.PocOther2015 == input.PocOther2015 ||
                    (this.PocOther2015 != null &&
                    this.PocOther2015.Equals(input.PocOther2015))
                ) && 
                (
                    this.PacBroker2015 == input.PacBroker2015 ||
                    (this.PacBroker2015 != null &&
                    this.PacBroker2015.Equals(input.PacBroker2015))
                ) && 
                (
                    this.PacLender2015 == input.PacLender2015 ||
                    (this.PacLender2015 != null &&
                    this.PacLender2015.Equals(input.PacLender2015))
                ) && 
                (
                    this.PacOther2015 == input.PacOther2015 ||
                    (this.PacOther2015 != null &&
                    this.PacOther2015.Equals(input.PacOther2015))
                ) && 
                (
                    this.PocLender2015 == input.PocLender2015 ||
                    (this.PocLender2015 != null &&
                    this.PocLender2015.Equals(input.PocLender2015))
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
                if (this.CdLineId != null)
                    hashCode = hashCode * 59 + this.CdLineId.GetHashCode();
                if (this.LineId != null)
                    hashCode = hashCode * 59 + this.LineId.GetHashCode();
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.BalanceChecked != null)
                    hashCode = hashCode * 59 + this.BalanceChecked.GetHashCode();
                if (this.FeeDescription != null)
                    hashCode = hashCode * 59 + this.FeeDescription.GetHashCode();
                if (this.FeeDescription2015 != null)
                    hashCode = hashCode * 59 + this.FeeDescription2015.GetHashCode();
                if (this.Payee != null)
                    hashCode = hashCode * 59 + this.Payee.GetHashCode();
                if (this.PaidBy != null)
                    hashCode = hashCode * 59 + this.PaidBy.GetHashCode();
                if (this.PaidTo != null)
                    hashCode = hashCode * 59 + this.PaidTo.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.PocAmount != null)
                    hashCode = hashCode * 59 + this.PocAmount.GetHashCode();
                if (this.PocPaidBy != null)
                    hashCode = hashCode * 59 + this.PocPaidBy.GetHashCode();
                if (this.PtcAmount != null)
                    hashCode = hashCode * 59 + this.PtcAmount.GetHashCode();
                if (this.PtcPaidBy != null)
                    hashCode = hashCode * 59 + this.PtcPaidBy.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.PocBorrower2015 != null)
                    hashCode = hashCode * 59 + this.PocBorrower2015.GetHashCode();
                if (this.PocSeller2015 != null)
                    hashCode = hashCode * 59 + this.PocSeller2015.GetHashCode();
                if (this.PocBroker2015 != null)
                    hashCode = hashCode * 59 + this.PocBroker2015.GetHashCode();
                if (this.PocOther2015 != null)
                    hashCode = hashCode * 59 + this.PocOther2015.GetHashCode();
                if (this.PacBroker2015 != null)
                    hashCode = hashCode * 59 + this.PacBroker2015.GetHashCode();
                if (this.PacLender2015 != null)
                    hashCode = hashCode * 59 + this.PacLender2015.GetHashCode();
                if (this.PacOther2015 != null)
                    hashCode = hashCode * 59 + this.PacOther2015.GetHashCode();
                if (this.PocLender2015 != null)
                    hashCode = hashCode * 59 + this.PocLender2015.GetHashCode();
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
