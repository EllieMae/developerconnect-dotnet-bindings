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
 * Schema
 *
 * Represents schema operations on Loan.
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
using SwaggerDateConverter = Elli.Api.Schema.Client.SwaggerDateConverter;

namespace Elli.Api.Schema.Model
{
    /// <summary>
    /// LoanContractLoanProductDataHelocRepaymentDrawPeriods
    /// </summary>
    [DataContract]
    public partial class LoanContractLoanProductDataHelocRepaymentDrawPeriods :  IEquatable<LoanContractLoanProductDataHelocRepaymentDrawPeriods>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Apr
        /// </summary>
        [DataMember(Name="apr", EmitDefaultValue=false)]
        public double? Apr { get; set; }

        /// <summary>
        /// Gets or Sets DrawIndicator
        /// </summary>
        [DataMember(Name="drawIndicator", EmitDefaultValue=false)]
        public bool? DrawIndicator { get; set; }

        /// <summary>
        /// Gets or Sets IndexRatePercent
        /// </summary>
        [DataMember(Name="indexRatePercent", EmitDefaultValue=false)]
        public double? IndexRatePercent { get; set; }

        /// <summary>
        /// Gets or Sets MarginRatePercent
        /// </summary>
        [DataMember(Name="marginRatePercent", EmitDefaultValue=false)]
        public double? MarginRatePercent { get; set; }

        /// <summary>
        /// Gets or Sets MinimumMonthlyPaymentAmount
        /// </summary>
        [DataMember(Name="minimumMonthlyPaymentAmount", EmitDefaultValue=false)]
        public double? MinimumMonthlyPaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractLoanProductDataHelocRepaymentDrawPeriods {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Apr: ").Append(Apr).Append("\n");
            sb.Append("  DrawIndicator: ").Append(DrawIndicator).Append("\n");
            sb.Append("  IndexRatePercent: ").Append(IndexRatePercent).Append("\n");
            sb.Append("  MarginRatePercent: ").Append(MarginRatePercent).Append("\n");
            sb.Append("  MinimumMonthlyPaymentAmount: ").Append(MinimumMonthlyPaymentAmount).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as LoanContractLoanProductDataHelocRepaymentDrawPeriods);
        }

        /// <summary>
        /// Returns true if LoanContractLoanProductDataHelocRepaymentDrawPeriods instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractLoanProductDataHelocRepaymentDrawPeriods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractLoanProductDataHelocRepaymentDrawPeriods input)
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
                    this.Apr == input.Apr ||
                    (this.Apr != null &&
                    this.Apr.Equals(input.Apr))
                ) && 
                (
                    this.DrawIndicator == input.DrawIndicator ||
                    (this.DrawIndicator != null &&
                    this.DrawIndicator.Equals(input.DrawIndicator))
                ) && 
                (
                    this.IndexRatePercent == input.IndexRatePercent ||
                    (this.IndexRatePercent != null &&
                    this.IndexRatePercent.Equals(input.IndexRatePercent))
                ) && 
                (
                    this.MarginRatePercent == input.MarginRatePercent ||
                    (this.MarginRatePercent != null &&
                    this.MarginRatePercent.Equals(input.MarginRatePercent))
                ) && 
                (
                    this.MinimumMonthlyPaymentAmount == input.MinimumMonthlyPaymentAmount ||
                    (this.MinimumMonthlyPaymentAmount != null &&
                    this.MinimumMonthlyPaymentAmount.Equals(input.MinimumMonthlyPaymentAmount))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.Apr != null)
                    hashCode = hashCode * 59 + this.Apr.GetHashCode();
                if (this.DrawIndicator != null)
                    hashCode = hashCode * 59 + this.DrawIndicator.GetHashCode();
                if (this.IndexRatePercent != null)
                    hashCode = hashCode * 59 + this.IndexRatePercent.GetHashCode();
                if (this.MarginRatePercent != null)
                    hashCode = hashCode * 59 + this.MarginRatePercent.GetHashCode();
                if (this.MinimumMonthlyPaymentAmount != null)
                    hashCode = hashCode * 59 + this.MinimumMonthlyPaymentAmount.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
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
