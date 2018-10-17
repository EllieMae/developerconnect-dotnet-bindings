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
    /// LoanContractLOCompensation
    /// </summary>
    [DataContract]
    public partial class LoanContractLOCompensation :  IEquatable<LoanContractLOCompensation>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPlanAdditonalAmountForBroker
        /// </summary>
        [DataMember(Name="adjustedPlanAdditonalAmountForBroker", EmitDefaultValue=false)]
        public double? AdjustedPlanAdditonalAmountForBroker { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPlanAdditonalAmountForOfficer
        /// </summary>
        [DataMember(Name="adjustedPlanAdditonalAmountForOfficer", EmitDefaultValue=false)]
        public double? AdjustedPlanAdditonalAmountForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPlanAmountForBroker
        /// </summary>
        [DataMember(Name="adjustedPlanAmountForBroker", EmitDefaultValue=false)]
        public double? AdjustedPlanAmountForBroker { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPlanAmountForOfficer
        /// </summary>
        [DataMember(Name="adjustedPlanAmountForOfficer", EmitDefaultValue=false)]
        public double? AdjustedPlanAmountForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPlanRateForBroker
        /// </summary>
        [DataMember(Name="adjustedPlanRateForBroker", EmitDefaultValue=false)]
        public double? AdjustedPlanRateForBroker { get; set; }

        /// <summary>
        /// Gets or Sets AdjustedPlanRateForOfficer
        /// </summary>
        [DataMember(Name="adjustedPlanRateForOfficer", EmitDefaultValue=false)]
        public double? AdjustedPlanRateForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentDescription
        /// </summary>
        [DataMember(Name="adjustmentDescription", EmitDefaultValue=false)]
        public string AdjustmentDescription { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentDescriptionForOfficer
        /// </summary>
        [DataMember(Name="adjustmentDescriptionForOfficer", EmitDefaultValue=false)]
        public string AdjustmentDescriptionForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanAdditonalAmountForBroker
        /// </summary>
        [DataMember(Name="basePlanAdditonalAmountForBroker", EmitDefaultValue=false)]
        public double? BasePlanAdditonalAmountForBroker { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanAdditonalAmountForOfficer
        /// </summary>
        [DataMember(Name="basePlanAdditonalAmountForOfficer", EmitDefaultValue=false)]
        public double? BasePlanAdditonalAmountForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanAmountForBroker
        /// </summary>
        [DataMember(Name="basePlanAmountForBroker", EmitDefaultValue=false)]
        public double? BasePlanAmountForBroker { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanAmountForOfficer
        /// </summary>
        [DataMember(Name="basePlanAmountForOfficer", EmitDefaultValue=false)]
        public double? BasePlanAmountForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanMaximumAmountForBroker
        /// </summary>
        [DataMember(Name="basePlanMaximumAmountForBroker", EmitDefaultValue=false)]
        public double? BasePlanMaximumAmountForBroker { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanMaximumAmountForOfficer
        /// </summary>
        [DataMember(Name="basePlanMaximumAmountForOfficer", EmitDefaultValue=false)]
        public double? BasePlanMaximumAmountForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanMinimumAmountForBroker
        /// </summary>
        [DataMember(Name="basePlanMinimumAmountForBroker", EmitDefaultValue=false)]
        public double? BasePlanMinimumAmountForBroker { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanMinimumAmountForOfficer
        /// </summary>
        [DataMember(Name="basePlanMinimumAmountForOfficer", EmitDefaultValue=false)]
        public double? BasePlanMinimumAmountForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanRateForBroker
        /// </summary>
        [DataMember(Name="basePlanRateForBroker", EmitDefaultValue=false)]
        public double? BasePlanRateForBroker { get; set; }

        /// <summary>
        /// Gets or Sets BasePlanRateForOfficer
        /// </summary>
        [DataMember(Name="basePlanRateForOfficer", EmitDefaultValue=false)]
        public double? BasePlanRateForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets BonusCompAdditonalAmount
        /// </summary>
        [DataMember(Name="bonusCompAdditonalAmount", EmitDefaultValue=false)]
        public double? BonusCompAdditonalAmount { get; set; }

        /// <summary>
        /// Gets or Sets BonusCompAmount
        /// </summary>
        [DataMember(Name="bonusCompAmount", EmitDefaultValue=false)]
        public double? BonusCompAmount { get; set; }

        /// <summary>
        /// Gets or Sets BonusCompRate
        /// </summary>
        [DataMember(Name="bonusCompRate", EmitDefaultValue=false)]
        public double? BonusCompRate { get; set; }

        /// <summary>
        /// Gets or Sets LastAppliedDate
        /// </summary>
        [DataMember(Name="lastAppliedDate", EmitDefaultValue=false)]
        public DateTime? LastAppliedDate { get; set; }

        /// <summary>
        /// Gets or Sets LastAppliedDateTime
        /// </summary>
        [DataMember(Name="lastAppliedDateTime", EmitDefaultValue=false)]
        public string LastAppliedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LoanAmountType
        /// </summary>
        [DataMember(Name="loanAmountType", EmitDefaultValue=false)]
        public string LoanAmountType { get; set; }

        /// <summary>
        /// Gets or Sets LoanAmountTypeForOfficer
        /// </summary>
        [DataMember(Name="loanAmountTypeForOfficer", EmitDefaultValue=false)]
        public string LoanAmountTypeForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets LoanOriginatorID
        /// </summary>
        [DataMember(Name="loanOriginatorID", EmitDefaultValue=false)]
        public string LoanOriginatorID { get; set; }

        /// <summary>
        /// Gets or Sets LoanOriginatorIDForOfficer
        /// </summary>
        [DataMember(Name="loanOriginatorIDForOfficer", EmitDefaultValue=false)]
        public string LoanOriginatorIDForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets LoanOriginatorName
        /// </summary>
        [DataMember(Name="loanOriginatorName", EmitDefaultValue=false)]
        public string LoanOriginatorName { get; set; }

        /// <summary>
        /// Gets or Sets LoanOriginatorNameForOfficer
        /// </summary>
        [DataMember(Name="loanOriginatorNameForOfficer", EmitDefaultValue=false)]
        public string LoanOriginatorNameForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets NetAdjustedAmountForBroker
        /// </summary>
        [DataMember(Name="netAdjustedAmountForBroker", EmitDefaultValue=false)]
        public double? NetAdjustedAmountForBroker { get; set; }

        /// <summary>
        /// Gets or Sets NetAdjustedAmountForOfficer
        /// </summary>
        [DataMember(Name="netAdjustedAmountForOfficer", EmitDefaultValue=false)]
        public double? NetAdjustedAmountForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets PlanDate
        /// </summary>
        [DataMember(Name="planDate", EmitDefaultValue=false)]
        public DateTime? PlanDate { get; set; }

        /// <summary>
        /// Gets or Sets PlanName
        /// </summary>
        [DataMember(Name="planName", EmitDefaultValue=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// Gets or Sets PlanNameForOfficer
        /// </summary>
        [DataMember(Name="planNameForOfficer", EmitDefaultValue=false)]
        public string PlanNameForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets RoundingMethod
        /// </summary>
        [DataMember(Name="roundingMethod", EmitDefaultValue=false)]
        public string RoundingMethod { get; set; }

        /// <summary>
        /// Gets or Sets RoundingMethodForOfficer
        /// </summary>
        [DataMember(Name="roundingMethodForOfficer", EmitDefaultValue=false)]
        public string RoundingMethodForOfficer { get; set; }

        /// <summary>
        /// Gets or Sets TriggerField
        /// </summary>
        [DataMember(Name="triggerField", EmitDefaultValue=false)]
        public string TriggerField { get; set; }

        /// <summary>
        /// Gets or Sets WhoPaidCompensation
        /// </summary>
        [DataMember(Name="whoPaidCompensation", EmitDefaultValue=false)]
        public string WhoPaidCompensation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractLOCompensation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AdjustedPlanAdditonalAmountForBroker: ").Append(AdjustedPlanAdditonalAmountForBroker).Append("\n");
            sb.Append("  AdjustedPlanAdditonalAmountForOfficer: ").Append(AdjustedPlanAdditonalAmountForOfficer).Append("\n");
            sb.Append("  AdjustedPlanAmountForBroker: ").Append(AdjustedPlanAmountForBroker).Append("\n");
            sb.Append("  AdjustedPlanAmountForOfficer: ").Append(AdjustedPlanAmountForOfficer).Append("\n");
            sb.Append("  AdjustedPlanRateForBroker: ").Append(AdjustedPlanRateForBroker).Append("\n");
            sb.Append("  AdjustedPlanRateForOfficer: ").Append(AdjustedPlanRateForOfficer).Append("\n");
            sb.Append("  AdjustmentDescription: ").Append(AdjustmentDescription).Append("\n");
            sb.Append("  AdjustmentDescriptionForOfficer: ").Append(AdjustmentDescriptionForOfficer).Append("\n");
            sb.Append("  BasePlanAdditonalAmountForBroker: ").Append(BasePlanAdditonalAmountForBroker).Append("\n");
            sb.Append("  BasePlanAdditonalAmountForOfficer: ").Append(BasePlanAdditonalAmountForOfficer).Append("\n");
            sb.Append("  BasePlanAmountForBroker: ").Append(BasePlanAmountForBroker).Append("\n");
            sb.Append("  BasePlanAmountForOfficer: ").Append(BasePlanAmountForOfficer).Append("\n");
            sb.Append("  BasePlanMaximumAmountForBroker: ").Append(BasePlanMaximumAmountForBroker).Append("\n");
            sb.Append("  BasePlanMaximumAmountForOfficer: ").Append(BasePlanMaximumAmountForOfficer).Append("\n");
            sb.Append("  BasePlanMinimumAmountForBroker: ").Append(BasePlanMinimumAmountForBroker).Append("\n");
            sb.Append("  BasePlanMinimumAmountForOfficer: ").Append(BasePlanMinimumAmountForOfficer).Append("\n");
            sb.Append("  BasePlanRateForBroker: ").Append(BasePlanRateForBroker).Append("\n");
            sb.Append("  BasePlanRateForOfficer: ").Append(BasePlanRateForOfficer).Append("\n");
            sb.Append("  BonusCompAdditonalAmount: ").Append(BonusCompAdditonalAmount).Append("\n");
            sb.Append("  BonusCompAmount: ").Append(BonusCompAmount).Append("\n");
            sb.Append("  BonusCompRate: ").Append(BonusCompRate).Append("\n");
            sb.Append("  LastAppliedDate: ").Append(LastAppliedDate).Append("\n");
            sb.Append("  LastAppliedDateTime: ").Append(LastAppliedDateTime).Append("\n");
            sb.Append("  LoanAmountType: ").Append(LoanAmountType).Append("\n");
            sb.Append("  LoanAmountTypeForOfficer: ").Append(LoanAmountTypeForOfficer).Append("\n");
            sb.Append("  LoanOriginatorID: ").Append(LoanOriginatorID).Append("\n");
            sb.Append("  LoanOriginatorIDForOfficer: ").Append(LoanOriginatorIDForOfficer).Append("\n");
            sb.Append("  LoanOriginatorName: ").Append(LoanOriginatorName).Append("\n");
            sb.Append("  LoanOriginatorNameForOfficer: ").Append(LoanOriginatorNameForOfficer).Append("\n");
            sb.Append("  NetAdjustedAmountForBroker: ").Append(NetAdjustedAmountForBroker).Append("\n");
            sb.Append("  NetAdjustedAmountForOfficer: ").Append(NetAdjustedAmountForOfficer).Append("\n");
            sb.Append("  PlanDate: ").Append(PlanDate).Append("\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("  PlanNameForOfficer: ").Append(PlanNameForOfficer).Append("\n");
            sb.Append("  RoundingMethod: ").Append(RoundingMethod).Append("\n");
            sb.Append("  RoundingMethodForOfficer: ").Append(RoundingMethodForOfficer).Append("\n");
            sb.Append("  TriggerField: ").Append(TriggerField).Append("\n");
            sb.Append("  WhoPaidCompensation: ").Append(WhoPaidCompensation).Append("\n");
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
            return this.Equals(input as LoanContractLOCompensation);
        }

        /// <summary>
        /// Returns true if LoanContractLOCompensation instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractLOCompensation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractLOCompensation input)
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
                    this.AdjustedPlanAdditonalAmountForBroker == input.AdjustedPlanAdditonalAmountForBroker ||
                    (this.AdjustedPlanAdditonalAmountForBroker != null &&
                    this.AdjustedPlanAdditonalAmountForBroker.Equals(input.AdjustedPlanAdditonalAmountForBroker))
                ) && 
                (
                    this.AdjustedPlanAdditonalAmountForOfficer == input.AdjustedPlanAdditonalAmountForOfficer ||
                    (this.AdjustedPlanAdditonalAmountForOfficer != null &&
                    this.AdjustedPlanAdditonalAmountForOfficer.Equals(input.AdjustedPlanAdditonalAmountForOfficer))
                ) && 
                (
                    this.AdjustedPlanAmountForBroker == input.AdjustedPlanAmountForBroker ||
                    (this.AdjustedPlanAmountForBroker != null &&
                    this.AdjustedPlanAmountForBroker.Equals(input.AdjustedPlanAmountForBroker))
                ) && 
                (
                    this.AdjustedPlanAmountForOfficer == input.AdjustedPlanAmountForOfficer ||
                    (this.AdjustedPlanAmountForOfficer != null &&
                    this.AdjustedPlanAmountForOfficer.Equals(input.AdjustedPlanAmountForOfficer))
                ) && 
                (
                    this.AdjustedPlanRateForBroker == input.AdjustedPlanRateForBroker ||
                    (this.AdjustedPlanRateForBroker != null &&
                    this.AdjustedPlanRateForBroker.Equals(input.AdjustedPlanRateForBroker))
                ) && 
                (
                    this.AdjustedPlanRateForOfficer == input.AdjustedPlanRateForOfficer ||
                    (this.AdjustedPlanRateForOfficer != null &&
                    this.AdjustedPlanRateForOfficer.Equals(input.AdjustedPlanRateForOfficer))
                ) && 
                (
                    this.AdjustmentDescription == input.AdjustmentDescription ||
                    (this.AdjustmentDescription != null &&
                    this.AdjustmentDescription.Equals(input.AdjustmentDescription))
                ) && 
                (
                    this.AdjustmentDescriptionForOfficer == input.AdjustmentDescriptionForOfficer ||
                    (this.AdjustmentDescriptionForOfficer != null &&
                    this.AdjustmentDescriptionForOfficer.Equals(input.AdjustmentDescriptionForOfficer))
                ) && 
                (
                    this.BasePlanAdditonalAmountForBroker == input.BasePlanAdditonalAmountForBroker ||
                    (this.BasePlanAdditonalAmountForBroker != null &&
                    this.BasePlanAdditonalAmountForBroker.Equals(input.BasePlanAdditonalAmountForBroker))
                ) && 
                (
                    this.BasePlanAdditonalAmountForOfficer == input.BasePlanAdditonalAmountForOfficer ||
                    (this.BasePlanAdditonalAmountForOfficer != null &&
                    this.BasePlanAdditonalAmountForOfficer.Equals(input.BasePlanAdditonalAmountForOfficer))
                ) && 
                (
                    this.BasePlanAmountForBroker == input.BasePlanAmountForBroker ||
                    (this.BasePlanAmountForBroker != null &&
                    this.BasePlanAmountForBroker.Equals(input.BasePlanAmountForBroker))
                ) && 
                (
                    this.BasePlanAmountForOfficer == input.BasePlanAmountForOfficer ||
                    (this.BasePlanAmountForOfficer != null &&
                    this.BasePlanAmountForOfficer.Equals(input.BasePlanAmountForOfficer))
                ) && 
                (
                    this.BasePlanMaximumAmountForBroker == input.BasePlanMaximumAmountForBroker ||
                    (this.BasePlanMaximumAmountForBroker != null &&
                    this.BasePlanMaximumAmountForBroker.Equals(input.BasePlanMaximumAmountForBroker))
                ) && 
                (
                    this.BasePlanMaximumAmountForOfficer == input.BasePlanMaximumAmountForOfficer ||
                    (this.BasePlanMaximumAmountForOfficer != null &&
                    this.BasePlanMaximumAmountForOfficer.Equals(input.BasePlanMaximumAmountForOfficer))
                ) && 
                (
                    this.BasePlanMinimumAmountForBroker == input.BasePlanMinimumAmountForBroker ||
                    (this.BasePlanMinimumAmountForBroker != null &&
                    this.BasePlanMinimumAmountForBroker.Equals(input.BasePlanMinimumAmountForBroker))
                ) && 
                (
                    this.BasePlanMinimumAmountForOfficer == input.BasePlanMinimumAmountForOfficer ||
                    (this.BasePlanMinimumAmountForOfficer != null &&
                    this.BasePlanMinimumAmountForOfficer.Equals(input.BasePlanMinimumAmountForOfficer))
                ) && 
                (
                    this.BasePlanRateForBroker == input.BasePlanRateForBroker ||
                    (this.BasePlanRateForBroker != null &&
                    this.BasePlanRateForBroker.Equals(input.BasePlanRateForBroker))
                ) && 
                (
                    this.BasePlanRateForOfficer == input.BasePlanRateForOfficer ||
                    (this.BasePlanRateForOfficer != null &&
                    this.BasePlanRateForOfficer.Equals(input.BasePlanRateForOfficer))
                ) && 
                (
                    this.BonusCompAdditonalAmount == input.BonusCompAdditonalAmount ||
                    (this.BonusCompAdditonalAmount != null &&
                    this.BonusCompAdditonalAmount.Equals(input.BonusCompAdditonalAmount))
                ) && 
                (
                    this.BonusCompAmount == input.BonusCompAmount ||
                    (this.BonusCompAmount != null &&
                    this.BonusCompAmount.Equals(input.BonusCompAmount))
                ) && 
                (
                    this.BonusCompRate == input.BonusCompRate ||
                    (this.BonusCompRate != null &&
                    this.BonusCompRate.Equals(input.BonusCompRate))
                ) && 
                (
                    this.LastAppliedDate == input.LastAppliedDate ||
                    (this.LastAppliedDate != null &&
                    this.LastAppliedDate.Equals(input.LastAppliedDate))
                ) && 
                (
                    this.LastAppliedDateTime == input.LastAppliedDateTime ||
                    (this.LastAppliedDateTime != null &&
                    this.LastAppliedDateTime.Equals(input.LastAppliedDateTime))
                ) && 
                (
                    this.LoanAmountType == input.LoanAmountType ||
                    (this.LoanAmountType != null &&
                    this.LoanAmountType.Equals(input.LoanAmountType))
                ) && 
                (
                    this.LoanAmountTypeForOfficer == input.LoanAmountTypeForOfficer ||
                    (this.LoanAmountTypeForOfficer != null &&
                    this.LoanAmountTypeForOfficer.Equals(input.LoanAmountTypeForOfficer))
                ) && 
                (
                    this.LoanOriginatorID == input.LoanOriginatorID ||
                    (this.LoanOriginatorID != null &&
                    this.LoanOriginatorID.Equals(input.LoanOriginatorID))
                ) && 
                (
                    this.LoanOriginatorIDForOfficer == input.LoanOriginatorIDForOfficer ||
                    (this.LoanOriginatorIDForOfficer != null &&
                    this.LoanOriginatorIDForOfficer.Equals(input.LoanOriginatorIDForOfficer))
                ) && 
                (
                    this.LoanOriginatorName == input.LoanOriginatorName ||
                    (this.LoanOriginatorName != null &&
                    this.LoanOriginatorName.Equals(input.LoanOriginatorName))
                ) && 
                (
                    this.LoanOriginatorNameForOfficer == input.LoanOriginatorNameForOfficer ||
                    (this.LoanOriginatorNameForOfficer != null &&
                    this.LoanOriginatorNameForOfficer.Equals(input.LoanOriginatorNameForOfficer))
                ) && 
                (
                    this.NetAdjustedAmountForBroker == input.NetAdjustedAmountForBroker ||
                    (this.NetAdjustedAmountForBroker != null &&
                    this.NetAdjustedAmountForBroker.Equals(input.NetAdjustedAmountForBroker))
                ) && 
                (
                    this.NetAdjustedAmountForOfficer == input.NetAdjustedAmountForOfficer ||
                    (this.NetAdjustedAmountForOfficer != null &&
                    this.NetAdjustedAmountForOfficer.Equals(input.NetAdjustedAmountForOfficer))
                ) && 
                (
                    this.PlanDate == input.PlanDate ||
                    (this.PlanDate != null &&
                    this.PlanDate.Equals(input.PlanDate))
                ) && 
                (
                    this.PlanName == input.PlanName ||
                    (this.PlanName != null &&
                    this.PlanName.Equals(input.PlanName))
                ) && 
                (
                    this.PlanNameForOfficer == input.PlanNameForOfficer ||
                    (this.PlanNameForOfficer != null &&
                    this.PlanNameForOfficer.Equals(input.PlanNameForOfficer))
                ) && 
                (
                    this.RoundingMethod == input.RoundingMethod ||
                    (this.RoundingMethod != null &&
                    this.RoundingMethod.Equals(input.RoundingMethod))
                ) && 
                (
                    this.RoundingMethodForOfficer == input.RoundingMethodForOfficer ||
                    (this.RoundingMethodForOfficer != null &&
                    this.RoundingMethodForOfficer.Equals(input.RoundingMethodForOfficer))
                ) && 
                (
                    this.TriggerField == input.TriggerField ||
                    (this.TriggerField != null &&
                    this.TriggerField.Equals(input.TriggerField))
                ) && 
                (
                    this.WhoPaidCompensation == input.WhoPaidCompensation ||
                    (this.WhoPaidCompensation != null &&
                    this.WhoPaidCompensation.Equals(input.WhoPaidCompensation))
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
                if (this.AdjustedPlanAdditonalAmountForBroker != null)
                    hashCode = hashCode * 59 + this.AdjustedPlanAdditonalAmountForBroker.GetHashCode();
                if (this.AdjustedPlanAdditonalAmountForOfficer != null)
                    hashCode = hashCode * 59 + this.AdjustedPlanAdditonalAmountForOfficer.GetHashCode();
                if (this.AdjustedPlanAmountForBroker != null)
                    hashCode = hashCode * 59 + this.AdjustedPlanAmountForBroker.GetHashCode();
                if (this.AdjustedPlanAmountForOfficer != null)
                    hashCode = hashCode * 59 + this.AdjustedPlanAmountForOfficer.GetHashCode();
                if (this.AdjustedPlanRateForBroker != null)
                    hashCode = hashCode * 59 + this.AdjustedPlanRateForBroker.GetHashCode();
                if (this.AdjustedPlanRateForOfficer != null)
                    hashCode = hashCode * 59 + this.AdjustedPlanRateForOfficer.GetHashCode();
                if (this.AdjustmentDescription != null)
                    hashCode = hashCode * 59 + this.AdjustmentDescription.GetHashCode();
                if (this.AdjustmentDescriptionForOfficer != null)
                    hashCode = hashCode * 59 + this.AdjustmentDescriptionForOfficer.GetHashCode();
                if (this.BasePlanAdditonalAmountForBroker != null)
                    hashCode = hashCode * 59 + this.BasePlanAdditonalAmountForBroker.GetHashCode();
                if (this.BasePlanAdditonalAmountForOfficer != null)
                    hashCode = hashCode * 59 + this.BasePlanAdditonalAmountForOfficer.GetHashCode();
                if (this.BasePlanAmountForBroker != null)
                    hashCode = hashCode * 59 + this.BasePlanAmountForBroker.GetHashCode();
                if (this.BasePlanAmountForOfficer != null)
                    hashCode = hashCode * 59 + this.BasePlanAmountForOfficer.GetHashCode();
                if (this.BasePlanMaximumAmountForBroker != null)
                    hashCode = hashCode * 59 + this.BasePlanMaximumAmountForBroker.GetHashCode();
                if (this.BasePlanMaximumAmountForOfficer != null)
                    hashCode = hashCode * 59 + this.BasePlanMaximumAmountForOfficer.GetHashCode();
                if (this.BasePlanMinimumAmountForBroker != null)
                    hashCode = hashCode * 59 + this.BasePlanMinimumAmountForBroker.GetHashCode();
                if (this.BasePlanMinimumAmountForOfficer != null)
                    hashCode = hashCode * 59 + this.BasePlanMinimumAmountForOfficer.GetHashCode();
                if (this.BasePlanRateForBroker != null)
                    hashCode = hashCode * 59 + this.BasePlanRateForBroker.GetHashCode();
                if (this.BasePlanRateForOfficer != null)
                    hashCode = hashCode * 59 + this.BasePlanRateForOfficer.GetHashCode();
                if (this.BonusCompAdditonalAmount != null)
                    hashCode = hashCode * 59 + this.BonusCompAdditonalAmount.GetHashCode();
                if (this.BonusCompAmount != null)
                    hashCode = hashCode * 59 + this.BonusCompAmount.GetHashCode();
                if (this.BonusCompRate != null)
                    hashCode = hashCode * 59 + this.BonusCompRate.GetHashCode();
                if (this.LastAppliedDate != null)
                    hashCode = hashCode * 59 + this.LastAppliedDate.GetHashCode();
                if (this.LastAppliedDateTime != null)
                    hashCode = hashCode * 59 + this.LastAppliedDateTime.GetHashCode();
                if (this.LoanAmountType != null)
                    hashCode = hashCode * 59 + this.LoanAmountType.GetHashCode();
                if (this.LoanAmountTypeForOfficer != null)
                    hashCode = hashCode * 59 + this.LoanAmountTypeForOfficer.GetHashCode();
                if (this.LoanOriginatorID != null)
                    hashCode = hashCode * 59 + this.LoanOriginatorID.GetHashCode();
                if (this.LoanOriginatorIDForOfficer != null)
                    hashCode = hashCode * 59 + this.LoanOriginatorIDForOfficer.GetHashCode();
                if (this.LoanOriginatorName != null)
                    hashCode = hashCode * 59 + this.LoanOriginatorName.GetHashCode();
                if (this.LoanOriginatorNameForOfficer != null)
                    hashCode = hashCode * 59 + this.LoanOriginatorNameForOfficer.GetHashCode();
                if (this.NetAdjustedAmountForBroker != null)
                    hashCode = hashCode * 59 + this.NetAdjustedAmountForBroker.GetHashCode();
                if (this.NetAdjustedAmountForOfficer != null)
                    hashCode = hashCode * 59 + this.NetAdjustedAmountForOfficer.GetHashCode();
                if (this.PlanDate != null)
                    hashCode = hashCode * 59 + this.PlanDate.GetHashCode();
                if (this.PlanName != null)
                    hashCode = hashCode * 59 + this.PlanName.GetHashCode();
                if (this.PlanNameForOfficer != null)
                    hashCode = hashCode * 59 + this.PlanNameForOfficer.GetHashCode();
                if (this.RoundingMethod != null)
                    hashCode = hashCode * 59 + this.RoundingMethod.GetHashCode();
                if (this.RoundingMethodForOfficer != null)
                    hashCode = hashCode * 59 + this.RoundingMethodForOfficer.GetHashCode();
                if (this.TriggerField != null)
                    hashCode = hashCode * 59 + this.TriggerField.GetHashCode();
                if (this.WhoPaidCompensation != null)
                    hashCode = hashCode * 59 + this.WhoPaidCompensation.GetHashCode();
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
