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
    /// LoanContractClosingCostClosingDisclosure3UCDDetails
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingCostClosingDisclosure3UCDDetails :  IEquatable<LoanContractClosingCostClosingDisclosure3UCDDetails>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FeeAccountType
        /// </summary>
        [DataMember(Name="feeAccountType", EmitDefaultValue=false)]
        public string FeeAccountType { get; set; }

        /// <summary>
        /// Gets or Sets FeeAmount
        /// </summary>
        [DataMember(Name="feeAmount", EmitDefaultValue=false)]
        public double? FeeAmount { get; set; }

        /// <summary>
        /// Gets or Sets FeeDateFrom
        /// </summary>
        [DataMember(Name="feeDateFrom", EmitDefaultValue=false)]
        public DateTime? FeeDateFrom { get; set; }

        /// <summary>
        /// Gets or Sets FeeDateTo
        /// </summary>
        [DataMember(Name="feeDateTo", EmitDefaultValue=false)]
        public DateTime? FeeDateTo { get; set; }

        /// <summary>
        /// Gets or Sets FeeDesc
        /// </summary>
        [DataMember(Name="feeDesc", EmitDefaultValue=false)]
        public string FeeDesc { get; set; }

        /// <summary>
        /// Gets or Sets FeePOC
        /// </summary>
        [DataMember(Name="feePOC", EmitDefaultValue=false)]
        public bool? FeePOC { get; set; }

        /// <summary>
        /// Gets or Sets FeePaidTo
        /// </summary>
        [DataMember(Name="feePaidTo", EmitDefaultValue=false)]
        public string FeePaidTo { get; set; }

        /// <summary>
        /// Gets or Sets FeePaidBy
        /// </summary>
        [DataMember(Name="feePaidBy", EmitDefaultValue=false)]
        public string FeePaidBy { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="lineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets Section
        /// </summary>
        [DataMember(Name="section", EmitDefaultValue=false)]
        public string Section { get; set; }

        /// <summary>
        /// Gets or Sets FeeIndex
        /// </summary>
        [DataMember(Name="feeIndex", EmitDefaultValue=false)]
        public int? FeeIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingCostClosingDisclosure3UCDDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FeeAccountType: ").Append(FeeAccountType).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  FeeDateFrom: ").Append(FeeDateFrom).Append("\n");
            sb.Append("  FeeDateTo: ").Append(FeeDateTo).Append("\n");
            sb.Append("  FeeDesc: ").Append(FeeDesc).Append("\n");
            sb.Append("  FeePOC: ").Append(FeePOC).Append("\n");
            sb.Append("  FeePaidTo: ").Append(FeePaidTo).Append("\n");
            sb.Append("  FeePaidBy: ").Append(FeePaidBy).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  FeeIndex: ").Append(FeeIndex).Append("\n");
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
            return this.Equals(input as LoanContractClosingCostClosingDisclosure3UCDDetails);
        }

        /// <summary>
        /// Returns true if LoanContractClosingCostClosingDisclosure3UCDDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingCostClosingDisclosure3UCDDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingCostClosingDisclosure3UCDDetails input)
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
                    this.FeeAccountType == input.FeeAccountType ||
                    (this.FeeAccountType != null &&
                    this.FeeAccountType.Equals(input.FeeAccountType))
                ) && 
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
                ) && 
                (
                    this.FeeDateFrom == input.FeeDateFrom ||
                    (this.FeeDateFrom != null &&
                    this.FeeDateFrom.Equals(input.FeeDateFrom))
                ) && 
                (
                    this.FeeDateTo == input.FeeDateTo ||
                    (this.FeeDateTo != null &&
                    this.FeeDateTo.Equals(input.FeeDateTo))
                ) && 
                (
                    this.FeeDesc == input.FeeDesc ||
                    (this.FeeDesc != null &&
                    this.FeeDesc.Equals(input.FeeDesc))
                ) && 
                (
                    this.FeePOC == input.FeePOC ||
                    (this.FeePOC != null &&
                    this.FeePOC.Equals(input.FeePOC))
                ) && 
                (
                    this.FeePaidTo == input.FeePaidTo ||
                    (this.FeePaidTo != null &&
                    this.FeePaidTo.Equals(input.FeePaidTo))
                ) && 
                (
                    this.FeePaidBy == input.FeePaidBy ||
                    (this.FeePaidBy != null &&
                    this.FeePaidBy.Equals(input.FeePaidBy))
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
                ) && 
                (
                    this.FeeIndex == input.FeeIndex ||
                    (this.FeeIndex != null &&
                    this.FeeIndex.Equals(input.FeeIndex))
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
                if (this.FeeAccountType != null)
                    hashCode = hashCode * 59 + this.FeeAccountType.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
                if (this.FeeDateFrom != null)
                    hashCode = hashCode * 59 + this.FeeDateFrom.GetHashCode();
                if (this.FeeDateTo != null)
                    hashCode = hashCode * 59 + this.FeeDateTo.GetHashCode();
                if (this.FeeDesc != null)
                    hashCode = hashCode * 59 + this.FeeDesc.GetHashCode();
                if (this.FeePOC != null)
                    hashCode = hashCode * 59 + this.FeePOC.GetHashCode();
                if (this.FeePaidTo != null)
                    hashCode = hashCode * 59 + this.FeePaidTo.GetHashCode();
                if (this.FeePaidBy != null)
                    hashCode = hashCode * 59 + this.FeePaidBy.GetHashCode();
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
                if (this.FeeIndex != null)
                    hashCode = hashCode * 59 + this.FeeIndex.GetHashCode();
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
