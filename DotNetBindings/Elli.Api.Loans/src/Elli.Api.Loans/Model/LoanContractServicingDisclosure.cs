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
    /// LoanContractServicingDisclosure
    /// </summary>
    [DataContract]
    public partial class LoanContractServicingDisclosure :  IEquatable<LoanContractServicingDisclosure>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisclosurePercent1
        /// </summary>
        [DataMember(Name="disclosurePercent1", EmitDefaultValue=false)]
        public double? DisclosurePercent1 { get; set; }

        /// <summary>
        /// Gets or Sets DisclosurePercent2
        /// </summary>
        [DataMember(Name="disclosurePercent2", EmitDefaultValue=false)]
        public double? DisclosurePercent2 { get; set; }

        /// <summary>
        /// Gets or Sets DisclosurePercent3
        /// </summary>
        [DataMember(Name="disclosurePercent3", EmitDefaultValue=false)]
        public double? DisclosurePercent3 { get; set; }

        /// <summary>
        /// Gets or Sets DisclosureYear1
        /// </summary>
        [DataMember(Name="disclosureYear1", EmitDefaultValue=false)]
        public string DisclosureYear1 { get; set; }

        /// <summary>
        /// Gets or Sets DisclosureYear2
        /// </summary>
        [DataMember(Name="disclosureYear2", EmitDefaultValue=false)]
        public string DisclosureYear2 { get; set; }

        /// <summary>
        /// Gets or Sets DisclosureYear3
        /// </summary>
        [DataMember(Name="disclosureYear3", EmitDefaultValue=false)]
        public string DisclosureYear3 { get; set; }

        /// <summary>
        /// Gets or Sets FiftyOneTo75Indicator
        /// </summary>
        [DataMember(Name="fiftyOneTo75Indicator", EmitDefaultValue=false)]
        public bool? FiftyOneTo75Indicator { get; set; }

        /// <summary>
        /// Gets or Sets SeventySixTo100Indicator
        /// </summary>
        [DataMember(Name="seventySixTo100Indicator", EmitDefaultValue=false)]
        public bool? SeventySixTo100Indicator { get; set; }

        /// <summary>
        /// Gets or Sets ThisEstimateType
        /// </summary>
        [DataMember(Name="thisEstimateType", EmitDefaultValue=false)]
        public string ThisEstimateType { get; set; }

        /// <summary>
        /// Gets or Sets ThisInformationType
        /// </summary>
        [DataMember(Name="thisInformationType", EmitDefaultValue=false)]
        public string ThisInformationType { get; set; }

        /// <summary>
        /// Gets or Sets ThisIsOurRecordOfTransferingIndicator
        /// </summary>
        [DataMember(Name="thisIsOurRecordOfTransferingIndicator", EmitDefaultValue=false)]
        public bool? ThisIsOurRecordOfTransferingIndicator { get; set; }

        /// <summary>
        /// Gets or Sets TwentySixTo50Indicator
        /// </summary>
        [DataMember(Name="twentySixTo50Indicator", EmitDefaultValue=false)]
        public bool? TwentySixTo50Indicator { get; set; }

        /// <summary>
        /// Gets or Sets WeAreAbleType
        /// </summary>
        [DataMember(Name="weAreAbleType", EmitDefaultValue=false)]
        public string WeAreAbleType { get; set; }

        /// <summary>
        /// Gets or Sets WeDoNotSellMortgageLoansIndicator
        /// </summary>
        [DataMember(Name="weDoNotSellMortgageLoansIndicator", EmitDefaultValue=false)]
        public bool? WeDoNotSellMortgageLoansIndicator { get; set; }

        /// <summary>
        /// Gets or Sets WeDoNotServiceMortgageLoansIndicator
        /// </summary>
        [DataMember(Name="weDoNotServiceMortgageLoansIndicator", EmitDefaultValue=false)]
        public bool? WeDoNotServiceMortgageLoansIndicator { get; set; }

        /// <summary>
        /// Gets or Sets WeHaveNotServicedMortgLoansIn3YrsIndicator
        /// </summary>
        [DataMember(Name="weHaveNotServicedMortgLoansIn3YrsIndicator", EmitDefaultValue=false)]
        public bool? WeHaveNotServicedMortgLoansIn3YrsIndicator { get; set; }

        /// <summary>
        /// Gets or Sets WeHavePreviouslyAssignedIndicator
        /// </summary>
        [DataMember(Name="weHavePreviouslyAssignedIndicator", EmitDefaultValue=false)]
        public bool? WeHavePreviouslyAssignedIndicator { get; set; }

        /// <summary>
        /// Gets or Sets WeMayAssignIndicator
        /// </summary>
        [DataMember(Name="weMayAssignIndicator", EmitDefaultValue=false)]
        public bool? WeMayAssignIndicator { get; set; }

        /// <summary>
        /// Gets or Sets ZeroTo25Indicator
        /// </summary>
        [DataMember(Name="zeroTo25Indicator", EmitDefaultValue=false)]
        public bool? ZeroTo25Indicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractServicingDisclosure {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisclosurePercent1: ").Append(DisclosurePercent1).Append("\n");
            sb.Append("  DisclosurePercent2: ").Append(DisclosurePercent2).Append("\n");
            sb.Append("  DisclosurePercent3: ").Append(DisclosurePercent3).Append("\n");
            sb.Append("  DisclosureYear1: ").Append(DisclosureYear1).Append("\n");
            sb.Append("  DisclosureYear2: ").Append(DisclosureYear2).Append("\n");
            sb.Append("  DisclosureYear3: ").Append(DisclosureYear3).Append("\n");
            sb.Append("  FiftyOneTo75Indicator: ").Append(FiftyOneTo75Indicator).Append("\n");
            sb.Append("  SeventySixTo100Indicator: ").Append(SeventySixTo100Indicator).Append("\n");
            sb.Append("  ThisEstimateType: ").Append(ThisEstimateType).Append("\n");
            sb.Append("  ThisInformationType: ").Append(ThisInformationType).Append("\n");
            sb.Append("  ThisIsOurRecordOfTransferingIndicator: ").Append(ThisIsOurRecordOfTransferingIndicator).Append("\n");
            sb.Append("  TwentySixTo50Indicator: ").Append(TwentySixTo50Indicator).Append("\n");
            sb.Append("  WeAreAbleType: ").Append(WeAreAbleType).Append("\n");
            sb.Append("  WeDoNotSellMortgageLoansIndicator: ").Append(WeDoNotSellMortgageLoansIndicator).Append("\n");
            sb.Append("  WeDoNotServiceMortgageLoansIndicator: ").Append(WeDoNotServiceMortgageLoansIndicator).Append("\n");
            sb.Append("  WeHaveNotServicedMortgLoansIn3YrsIndicator: ").Append(WeHaveNotServicedMortgLoansIn3YrsIndicator).Append("\n");
            sb.Append("  WeHavePreviouslyAssignedIndicator: ").Append(WeHavePreviouslyAssignedIndicator).Append("\n");
            sb.Append("  WeMayAssignIndicator: ").Append(WeMayAssignIndicator).Append("\n");
            sb.Append("  ZeroTo25Indicator: ").Append(ZeroTo25Indicator).Append("\n");
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
            return this.Equals(input as LoanContractServicingDisclosure);
        }

        /// <summary>
        /// Returns true if LoanContractServicingDisclosure instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractServicingDisclosure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractServicingDisclosure input)
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
                    this.DisclosurePercent1 == input.DisclosurePercent1 ||
                    (this.DisclosurePercent1 != null &&
                    this.DisclosurePercent1.Equals(input.DisclosurePercent1))
                ) && 
                (
                    this.DisclosurePercent2 == input.DisclosurePercent2 ||
                    (this.DisclosurePercent2 != null &&
                    this.DisclosurePercent2.Equals(input.DisclosurePercent2))
                ) && 
                (
                    this.DisclosurePercent3 == input.DisclosurePercent3 ||
                    (this.DisclosurePercent3 != null &&
                    this.DisclosurePercent3.Equals(input.DisclosurePercent3))
                ) && 
                (
                    this.DisclosureYear1 == input.DisclosureYear1 ||
                    (this.DisclosureYear1 != null &&
                    this.DisclosureYear1.Equals(input.DisclosureYear1))
                ) && 
                (
                    this.DisclosureYear2 == input.DisclosureYear2 ||
                    (this.DisclosureYear2 != null &&
                    this.DisclosureYear2.Equals(input.DisclosureYear2))
                ) && 
                (
                    this.DisclosureYear3 == input.DisclosureYear3 ||
                    (this.DisclosureYear3 != null &&
                    this.DisclosureYear3.Equals(input.DisclosureYear3))
                ) && 
                (
                    this.FiftyOneTo75Indicator == input.FiftyOneTo75Indicator ||
                    (this.FiftyOneTo75Indicator != null &&
                    this.FiftyOneTo75Indicator.Equals(input.FiftyOneTo75Indicator))
                ) && 
                (
                    this.SeventySixTo100Indicator == input.SeventySixTo100Indicator ||
                    (this.SeventySixTo100Indicator != null &&
                    this.SeventySixTo100Indicator.Equals(input.SeventySixTo100Indicator))
                ) && 
                (
                    this.ThisEstimateType == input.ThisEstimateType ||
                    (this.ThisEstimateType != null &&
                    this.ThisEstimateType.Equals(input.ThisEstimateType))
                ) && 
                (
                    this.ThisInformationType == input.ThisInformationType ||
                    (this.ThisInformationType != null &&
                    this.ThisInformationType.Equals(input.ThisInformationType))
                ) && 
                (
                    this.ThisIsOurRecordOfTransferingIndicator == input.ThisIsOurRecordOfTransferingIndicator ||
                    (this.ThisIsOurRecordOfTransferingIndicator != null &&
                    this.ThisIsOurRecordOfTransferingIndicator.Equals(input.ThisIsOurRecordOfTransferingIndicator))
                ) && 
                (
                    this.TwentySixTo50Indicator == input.TwentySixTo50Indicator ||
                    (this.TwentySixTo50Indicator != null &&
                    this.TwentySixTo50Indicator.Equals(input.TwentySixTo50Indicator))
                ) && 
                (
                    this.WeAreAbleType == input.WeAreAbleType ||
                    (this.WeAreAbleType != null &&
                    this.WeAreAbleType.Equals(input.WeAreAbleType))
                ) && 
                (
                    this.WeDoNotSellMortgageLoansIndicator == input.WeDoNotSellMortgageLoansIndicator ||
                    (this.WeDoNotSellMortgageLoansIndicator != null &&
                    this.WeDoNotSellMortgageLoansIndicator.Equals(input.WeDoNotSellMortgageLoansIndicator))
                ) && 
                (
                    this.WeDoNotServiceMortgageLoansIndicator == input.WeDoNotServiceMortgageLoansIndicator ||
                    (this.WeDoNotServiceMortgageLoansIndicator != null &&
                    this.WeDoNotServiceMortgageLoansIndicator.Equals(input.WeDoNotServiceMortgageLoansIndicator))
                ) && 
                (
                    this.WeHaveNotServicedMortgLoansIn3YrsIndicator == input.WeHaveNotServicedMortgLoansIn3YrsIndicator ||
                    (this.WeHaveNotServicedMortgLoansIn3YrsIndicator != null &&
                    this.WeHaveNotServicedMortgLoansIn3YrsIndicator.Equals(input.WeHaveNotServicedMortgLoansIn3YrsIndicator))
                ) && 
                (
                    this.WeHavePreviouslyAssignedIndicator == input.WeHavePreviouslyAssignedIndicator ||
                    (this.WeHavePreviouslyAssignedIndicator != null &&
                    this.WeHavePreviouslyAssignedIndicator.Equals(input.WeHavePreviouslyAssignedIndicator))
                ) && 
                (
                    this.WeMayAssignIndicator == input.WeMayAssignIndicator ||
                    (this.WeMayAssignIndicator != null &&
                    this.WeMayAssignIndicator.Equals(input.WeMayAssignIndicator))
                ) && 
                (
                    this.ZeroTo25Indicator == input.ZeroTo25Indicator ||
                    (this.ZeroTo25Indicator != null &&
                    this.ZeroTo25Indicator.Equals(input.ZeroTo25Indicator))
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
                if (this.DisclosurePercent1 != null)
                    hashCode = hashCode * 59 + this.DisclosurePercent1.GetHashCode();
                if (this.DisclosurePercent2 != null)
                    hashCode = hashCode * 59 + this.DisclosurePercent2.GetHashCode();
                if (this.DisclosurePercent3 != null)
                    hashCode = hashCode * 59 + this.DisclosurePercent3.GetHashCode();
                if (this.DisclosureYear1 != null)
                    hashCode = hashCode * 59 + this.DisclosureYear1.GetHashCode();
                if (this.DisclosureYear2 != null)
                    hashCode = hashCode * 59 + this.DisclosureYear2.GetHashCode();
                if (this.DisclosureYear3 != null)
                    hashCode = hashCode * 59 + this.DisclosureYear3.GetHashCode();
                if (this.FiftyOneTo75Indicator != null)
                    hashCode = hashCode * 59 + this.FiftyOneTo75Indicator.GetHashCode();
                if (this.SeventySixTo100Indicator != null)
                    hashCode = hashCode * 59 + this.SeventySixTo100Indicator.GetHashCode();
                if (this.ThisEstimateType != null)
                    hashCode = hashCode * 59 + this.ThisEstimateType.GetHashCode();
                if (this.ThisInformationType != null)
                    hashCode = hashCode * 59 + this.ThisInformationType.GetHashCode();
                if (this.ThisIsOurRecordOfTransferingIndicator != null)
                    hashCode = hashCode * 59 + this.ThisIsOurRecordOfTransferingIndicator.GetHashCode();
                if (this.TwentySixTo50Indicator != null)
                    hashCode = hashCode * 59 + this.TwentySixTo50Indicator.GetHashCode();
                if (this.WeAreAbleType != null)
                    hashCode = hashCode * 59 + this.WeAreAbleType.GetHashCode();
                if (this.WeDoNotSellMortgageLoansIndicator != null)
                    hashCode = hashCode * 59 + this.WeDoNotSellMortgageLoansIndicator.GetHashCode();
                if (this.WeDoNotServiceMortgageLoansIndicator != null)
                    hashCode = hashCode * 59 + this.WeDoNotServiceMortgageLoansIndicator.GetHashCode();
                if (this.WeHaveNotServicedMortgLoansIn3YrsIndicator != null)
                    hashCode = hashCode * 59 + this.WeHaveNotServicedMortgLoansIn3YrsIndicator.GetHashCode();
                if (this.WeHavePreviouslyAssignedIndicator != null)
                    hashCode = hashCode * 59 + this.WeHavePreviouslyAssignedIndicator.GetHashCode();
                if (this.WeMayAssignIndicator != null)
                    hashCode = hashCode * 59 + this.WeMayAssignIndicator.GetHashCode();
                if (this.ZeroTo25Indicator != null)
                    hashCode = hashCode * 59 + this.ZeroTo25Indicator.GetHashCode();
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
