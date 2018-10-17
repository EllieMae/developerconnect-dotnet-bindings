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
    /// LoanContractCommitmentTerms
    /// </summary>
    [DataContract]
    public partial class LoanContractCommitmentTerms :  IEquatable<LoanContractCommitmentTerms>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ActionDate
        /// </summary>
        [DataMember(Name="actionDate", EmitDefaultValue=false)]
        public DateTime? ActionDate { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalConditions
        /// </summary>
        [DataMember(Name="additionalConditions", EmitDefaultValue=false)]
        public string AdditionalConditions { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalItems1
        /// </summary>
        [DataMember(Name="additionalItems1", EmitDefaultValue=false)]
        public string AdditionalItems1 { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalItems2
        /// </summary>
        [DataMember(Name="additionalItems2", EmitDefaultValue=false)]
        public string AdditionalItems2 { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalItems3
        /// </summary>
        [DataMember(Name="additionalItems3", EmitDefaultValue=false)]
        public string AdditionalItems3 { get; set; }

        /// <summary>
        /// Gets or Sets AppraisalDone
        /// </summary>
        [DataMember(Name="appraisalDone", EmitDefaultValue=false)]
        public bool? AppraisalDone { get; set; }

        /// <summary>
        /// Gets or Sets AssuranceOfCompletion
        /// </summary>
        [DataMember(Name="assuranceOfCompletion", EmitDefaultValue=false)]
        public double? AssuranceOfCompletion { get; set; }

        /// <summary>
        /// Gets or Sets CommitmentDate
        /// </summary>
        [DataMember(Name="commitmentDate", EmitDefaultValue=false)]
        public DateTime? CommitmentDate { get; set; }

        /// <summary>
        /// Gets or Sets CommitmentExpired
        /// </summary>
        [DataMember(Name="commitmentExpired", EmitDefaultValue=false)]
        public DateTime? CommitmentExpired { get; set; }

        /// <summary>
        /// Gets or Sets CommitmentIssued
        /// </summary>
        [DataMember(Name="commitmentIssued", EmitDefaultValue=false)]
        public DateTime? CommitmentIssued { get; set; }

        /// <summary>
        /// Gets or Sets ConditionalCommitmentUnderActg
        /// </summary>
        [DataMember(Name="conditionalCommitmentUnderActg", EmitDefaultValue=false)]
        public bool? ConditionalCommitmentUnderActg { get; set; }

        /// <summary>
        /// Gets or Sets EligibleForHighLtv
        /// </summary>
        [DataMember(Name="eligibleForHighLtv", EmitDefaultValue=false)]
        public bool? EligibleForHighLtv { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedRemainingYears
        /// </summary>
        [DataMember(Name="estimatedRemainingYears", EmitDefaultValue=false)]
        public int? EstimatedRemainingYears { get; set; }

        /// <summary>
        /// Gets or Sets ImprovedLivingAreas
        /// </summary>
        [DataMember(Name="improvedLivingAreas", EmitDefaultValue=false)]
        public string ImprovedLivingAreas { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturedHousing
        /// </summary>
        [DataMember(Name="manufacturedHousing", EmitDefaultValue=false)]
        public bool? ManufacturedHousing { get; set; }

        /// <summary>
        /// Gets or Sets MaxInsurableMortgage
        /// </summary>
        [DataMember(Name="maxInsurableMortgage", EmitDefaultValue=false)]
        public double? MaxInsurableMortgage { get; set; }

        /// <summary>
        /// Gets or Sets MortgageeAddress
        /// </summary>
        [DataMember(Name="mortgageeAddress", EmitDefaultValue=false)]
        public string MortgageeAddress { get; set; }

        /// <summary>
        /// Gets or Sets MortgageeCity
        /// </summary>
        [DataMember(Name="mortgageeCity", EmitDefaultValue=false)]
        public string MortgageeCity { get; set; }

        /// <summary>
        /// Gets or Sets MortgageeName
        /// </summary>
        [DataMember(Name="mortgageeName", EmitDefaultValue=false)]
        public string MortgageeName { get; set; }

        /// <summary>
        /// Gets or Sets MortgageePostalCode
        /// </summary>
        [DataMember(Name="mortgageePostalCode", EmitDefaultValue=false)]
        public string MortgageePostalCode { get; set; }

        /// <summary>
        /// Gets or Sets MortgageeState
        /// </summary>
        [DataMember(Name="mortgageeState", EmitDefaultValue=false)]
        public string MortgageeState { get; set; }

        /// <summary>
        /// Gets or Sets OtherMonthlyExpenseDescription
        /// </summary>
        [DataMember(Name="otherMonthlyExpenseDescription", EmitDefaultValue=false)]
        public string OtherMonthlyExpenseDescription { get; set; }

        /// <summary>
        /// Gets or Sets ReportDate
        /// </summary>
        [DataMember(Name="reportDate", EmitDefaultValue=false)]
        public DateTime? ReportDate { get; set; }

        /// <summary>
        /// Gets or Sets RequirementsNumber
        /// </summary>
        [DataMember(Name="requirementsNumber", EmitDefaultValue=false)]
        public string RequirementsNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubdivisionDescription
        /// </summary>
        [DataMember(Name="subdivisionDescription", EmitDefaultValue=false)]
        public string SubdivisionDescription { get; set; }

        /// <summary>
        /// Gets or Sets SubdivisionRequirements
        /// </summary>
        [DataMember(Name="subdivisionRequirements", EmitDefaultValue=false)]
        public string SubdivisionRequirements { get; set; }

        /// <summary>
        /// Gets or Sets TotalMonthlyExpense
        /// </summary>
        [DataMember(Name="totalMonthlyExpense", EmitDefaultValue=false)]
        public double? TotalMonthlyExpense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractCommitmentTerms {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActionDate: ").Append(ActionDate).Append("\n");
            sb.Append("  AdditionalConditions: ").Append(AdditionalConditions).Append("\n");
            sb.Append("  AdditionalItems1: ").Append(AdditionalItems1).Append("\n");
            sb.Append("  AdditionalItems2: ").Append(AdditionalItems2).Append("\n");
            sb.Append("  AdditionalItems3: ").Append(AdditionalItems3).Append("\n");
            sb.Append("  AppraisalDone: ").Append(AppraisalDone).Append("\n");
            sb.Append("  AssuranceOfCompletion: ").Append(AssuranceOfCompletion).Append("\n");
            sb.Append("  CommitmentDate: ").Append(CommitmentDate).Append("\n");
            sb.Append("  CommitmentExpired: ").Append(CommitmentExpired).Append("\n");
            sb.Append("  CommitmentIssued: ").Append(CommitmentIssued).Append("\n");
            sb.Append("  ConditionalCommitmentUnderActg: ").Append(ConditionalCommitmentUnderActg).Append("\n");
            sb.Append("  EligibleForHighLtv: ").Append(EligibleForHighLtv).Append("\n");
            sb.Append("  EstimatedRemainingYears: ").Append(EstimatedRemainingYears).Append("\n");
            sb.Append("  ImprovedLivingAreas: ").Append(ImprovedLivingAreas).Append("\n");
            sb.Append("  ManufacturedHousing: ").Append(ManufacturedHousing).Append("\n");
            sb.Append("  MaxInsurableMortgage: ").Append(MaxInsurableMortgage).Append("\n");
            sb.Append("  MortgageeAddress: ").Append(MortgageeAddress).Append("\n");
            sb.Append("  MortgageeCity: ").Append(MortgageeCity).Append("\n");
            sb.Append("  MortgageeName: ").Append(MortgageeName).Append("\n");
            sb.Append("  MortgageePostalCode: ").Append(MortgageePostalCode).Append("\n");
            sb.Append("  MortgageeState: ").Append(MortgageeState).Append("\n");
            sb.Append("  OtherMonthlyExpenseDescription: ").Append(OtherMonthlyExpenseDescription).Append("\n");
            sb.Append("  ReportDate: ").Append(ReportDate).Append("\n");
            sb.Append("  RequirementsNumber: ").Append(RequirementsNumber).Append("\n");
            sb.Append("  SubdivisionDescription: ").Append(SubdivisionDescription).Append("\n");
            sb.Append("  SubdivisionRequirements: ").Append(SubdivisionRequirements).Append("\n");
            sb.Append("  TotalMonthlyExpense: ").Append(TotalMonthlyExpense).Append("\n");
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
            return this.Equals(input as LoanContractCommitmentTerms);
        }

        /// <summary>
        /// Returns true if LoanContractCommitmentTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractCommitmentTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractCommitmentTerms input)
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
                    this.ActionDate == input.ActionDate ||
                    (this.ActionDate != null &&
                    this.ActionDate.Equals(input.ActionDate))
                ) && 
                (
                    this.AdditionalConditions == input.AdditionalConditions ||
                    (this.AdditionalConditions != null &&
                    this.AdditionalConditions.Equals(input.AdditionalConditions))
                ) && 
                (
                    this.AdditionalItems1 == input.AdditionalItems1 ||
                    (this.AdditionalItems1 != null &&
                    this.AdditionalItems1.Equals(input.AdditionalItems1))
                ) && 
                (
                    this.AdditionalItems2 == input.AdditionalItems2 ||
                    (this.AdditionalItems2 != null &&
                    this.AdditionalItems2.Equals(input.AdditionalItems2))
                ) && 
                (
                    this.AdditionalItems3 == input.AdditionalItems3 ||
                    (this.AdditionalItems3 != null &&
                    this.AdditionalItems3.Equals(input.AdditionalItems3))
                ) && 
                (
                    this.AppraisalDone == input.AppraisalDone ||
                    (this.AppraisalDone != null &&
                    this.AppraisalDone.Equals(input.AppraisalDone))
                ) && 
                (
                    this.AssuranceOfCompletion == input.AssuranceOfCompletion ||
                    (this.AssuranceOfCompletion != null &&
                    this.AssuranceOfCompletion.Equals(input.AssuranceOfCompletion))
                ) && 
                (
                    this.CommitmentDate == input.CommitmentDate ||
                    (this.CommitmentDate != null &&
                    this.CommitmentDate.Equals(input.CommitmentDate))
                ) && 
                (
                    this.CommitmentExpired == input.CommitmentExpired ||
                    (this.CommitmentExpired != null &&
                    this.CommitmentExpired.Equals(input.CommitmentExpired))
                ) && 
                (
                    this.CommitmentIssued == input.CommitmentIssued ||
                    (this.CommitmentIssued != null &&
                    this.CommitmentIssued.Equals(input.CommitmentIssued))
                ) && 
                (
                    this.ConditionalCommitmentUnderActg == input.ConditionalCommitmentUnderActg ||
                    (this.ConditionalCommitmentUnderActg != null &&
                    this.ConditionalCommitmentUnderActg.Equals(input.ConditionalCommitmentUnderActg))
                ) && 
                (
                    this.EligibleForHighLtv == input.EligibleForHighLtv ||
                    (this.EligibleForHighLtv != null &&
                    this.EligibleForHighLtv.Equals(input.EligibleForHighLtv))
                ) && 
                (
                    this.EstimatedRemainingYears == input.EstimatedRemainingYears ||
                    (this.EstimatedRemainingYears != null &&
                    this.EstimatedRemainingYears.Equals(input.EstimatedRemainingYears))
                ) && 
                (
                    this.ImprovedLivingAreas == input.ImprovedLivingAreas ||
                    (this.ImprovedLivingAreas != null &&
                    this.ImprovedLivingAreas.Equals(input.ImprovedLivingAreas))
                ) && 
                (
                    this.ManufacturedHousing == input.ManufacturedHousing ||
                    (this.ManufacturedHousing != null &&
                    this.ManufacturedHousing.Equals(input.ManufacturedHousing))
                ) && 
                (
                    this.MaxInsurableMortgage == input.MaxInsurableMortgage ||
                    (this.MaxInsurableMortgage != null &&
                    this.MaxInsurableMortgage.Equals(input.MaxInsurableMortgage))
                ) && 
                (
                    this.MortgageeAddress == input.MortgageeAddress ||
                    (this.MortgageeAddress != null &&
                    this.MortgageeAddress.Equals(input.MortgageeAddress))
                ) && 
                (
                    this.MortgageeCity == input.MortgageeCity ||
                    (this.MortgageeCity != null &&
                    this.MortgageeCity.Equals(input.MortgageeCity))
                ) && 
                (
                    this.MortgageeName == input.MortgageeName ||
                    (this.MortgageeName != null &&
                    this.MortgageeName.Equals(input.MortgageeName))
                ) && 
                (
                    this.MortgageePostalCode == input.MortgageePostalCode ||
                    (this.MortgageePostalCode != null &&
                    this.MortgageePostalCode.Equals(input.MortgageePostalCode))
                ) && 
                (
                    this.MortgageeState == input.MortgageeState ||
                    (this.MortgageeState != null &&
                    this.MortgageeState.Equals(input.MortgageeState))
                ) && 
                (
                    this.OtherMonthlyExpenseDescription == input.OtherMonthlyExpenseDescription ||
                    (this.OtherMonthlyExpenseDescription != null &&
                    this.OtherMonthlyExpenseDescription.Equals(input.OtherMonthlyExpenseDescription))
                ) && 
                (
                    this.ReportDate == input.ReportDate ||
                    (this.ReportDate != null &&
                    this.ReportDate.Equals(input.ReportDate))
                ) && 
                (
                    this.RequirementsNumber == input.RequirementsNumber ||
                    (this.RequirementsNumber != null &&
                    this.RequirementsNumber.Equals(input.RequirementsNumber))
                ) && 
                (
                    this.SubdivisionDescription == input.SubdivisionDescription ||
                    (this.SubdivisionDescription != null &&
                    this.SubdivisionDescription.Equals(input.SubdivisionDescription))
                ) && 
                (
                    this.SubdivisionRequirements == input.SubdivisionRequirements ||
                    (this.SubdivisionRequirements != null &&
                    this.SubdivisionRequirements.Equals(input.SubdivisionRequirements))
                ) && 
                (
                    this.TotalMonthlyExpense == input.TotalMonthlyExpense ||
                    (this.TotalMonthlyExpense != null &&
                    this.TotalMonthlyExpense.Equals(input.TotalMonthlyExpense))
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
                if (this.ActionDate != null)
                    hashCode = hashCode * 59 + this.ActionDate.GetHashCode();
                if (this.AdditionalConditions != null)
                    hashCode = hashCode * 59 + this.AdditionalConditions.GetHashCode();
                if (this.AdditionalItems1 != null)
                    hashCode = hashCode * 59 + this.AdditionalItems1.GetHashCode();
                if (this.AdditionalItems2 != null)
                    hashCode = hashCode * 59 + this.AdditionalItems2.GetHashCode();
                if (this.AdditionalItems3 != null)
                    hashCode = hashCode * 59 + this.AdditionalItems3.GetHashCode();
                if (this.AppraisalDone != null)
                    hashCode = hashCode * 59 + this.AppraisalDone.GetHashCode();
                if (this.AssuranceOfCompletion != null)
                    hashCode = hashCode * 59 + this.AssuranceOfCompletion.GetHashCode();
                if (this.CommitmentDate != null)
                    hashCode = hashCode * 59 + this.CommitmentDate.GetHashCode();
                if (this.CommitmentExpired != null)
                    hashCode = hashCode * 59 + this.CommitmentExpired.GetHashCode();
                if (this.CommitmentIssued != null)
                    hashCode = hashCode * 59 + this.CommitmentIssued.GetHashCode();
                if (this.ConditionalCommitmentUnderActg != null)
                    hashCode = hashCode * 59 + this.ConditionalCommitmentUnderActg.GetHashCode();
                if (this.EligibleForHighLtv != null)
                    hashCode = hashCode * 59 + this.EligibleForHighLtv.GetHashCode();
                if (this.EstimatedRemainingYears != null)
                    hashCode = hashCode * 59 + this.EstimatedRemainingYears.GetHashCode();
                if (this.ImprovedLivingAreas != null)
                    hashCode = hashCode * 59 + this.ImprovedLivingAreas.GetHashCode();
                if (this.ManufacturedHousing != null)
                    hashCode = hashCode * 59 + this.ManufacturedHousing.GetHashCode();
                if (this.MaxInsurableMortgage != null)
                    hashCode = hashCode * 59 + this.MaxInsurableMortgage.GetHashCode();
                if (this.MortgageeAddress != null)
                    hashCode = hashCode * 59 + this.MortgageeAddress.GetHashCode();
                if (this.MortgageeCity != null)
                    hashCode = hashCode * 59 + this.MortgageeCity.GetHashCode();
                if (this.MortgageeName != null)
                    hashCode = hashCode * 59 + this.MortgageeName.GetHashCode();
                if (this.MortgageePostalCode != null)
                    hashCode = hashCode * 59 + this.MortgageePostalCode.GetHashCode();
                if (this.MortgageeState != null)
                    hashCode = hashCode * 59 + this.MortgageeState.GetHashCode();
                if (this.OtherMonthlyExpenseDescription != null)
                    hashCode = hashCode * 59 + this.OtherMonthlyExpenseDescription.GetHashCode();
                if (this.ReportDate != null)
                    hashCode = hashCode * 59 + this.ReportDate.GetHashCode();
                if (this.RequirementsNumber != null)
                    hashCode = hashCode * 59 + this.RequirementsNumber.GetHashCode();
                if (this.SubdivisionDescription != null)
                    hashCode = hashCode * 59 + this.SubdivisionDescription.GetHashCode();
                if (this.SubdivisionRequirements != null)
                    hashCode = hashCode * 59 + this.SubdivisionRequirements.GetHashCode();
                if (this.TotalMonthlyExpense != null)
                    hashCode = hashCode * 59 + this.TotalMonthlyExpense.GetHashCode();
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
