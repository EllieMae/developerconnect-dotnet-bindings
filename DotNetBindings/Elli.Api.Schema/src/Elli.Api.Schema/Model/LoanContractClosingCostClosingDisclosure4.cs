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
    /// LoanContractClosingCostClosingDisclosure4
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingCostClosingDisclosure4 :  IEquatable<LoanContractClosingCostClosingDisclosure4>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DemandFeature
        /// </summary>
        [DataMember(Name="demandFeature", EmitDefaultValue=false)]
        public string DemandFeature { get; set; }

        /// <summary>
        /// Gets or Sets NegativeAmortization
        /// </summary>
        [DataMember(Name="negativeAmortization", EmitDefaultValue=false)]
        public string NegativeAmortization { get; set; }

        /// <summary>
        /// Gets or Sets PartialPayment
        /// </summary>
        [DataMember(Name="partialPayment", EmitDefaultValue=false)]
        public string PartialPayment { get; set; }

        /// <summary>
        /// Gets or Sets Other1
        /// </summary>
        [DataMember(Name="other1", EmitDefaultValue=false)]
        public bool? Other1 { get; set; }

        /// <summary>
        /// Gets or Sets Other2
        /// </summary>
        [DataMember(Name="other2", EmitDefaultValue=false)]
        public bool? Other2 { get; set; }

        /// <summary>
        /// Gets or Sets Other3
        /// </summary>
        [DataMember(Name="other3", EmitDefaultValue=false)]
        public bool? Other3 { get; set; }

        /// <summary>
        /// Gets or Sets Lender
        /// </summary>
        [DataMember(Name="lender", EmitDefaultValue=false)]
        public bool? Lender { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedPropertyCosts
        /// </summary>
        [DataMember(Name="estimatedPropertyCosts", EmitDefaultValue=false)]
        public double? EstimatedPropertyCosts { get; set; }

        /// <summary>
        /// Gets or Sets EscrowIndicator
        /// </summary>
        [DataMember(Name="escrowIndicator", EmitDefaultValue=false)]
        public bool? EscrowIndicator { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyEscrowPayment
        /// </summary>
        [DataMember(Name="monthlyEscrowPayment", EmitDefaultValue=false)]
        public double? MonthlyEscrowPayment { get; set; }

        /// <summary>
        /// Gets or Sets InterestOnlyPayments
        /// </summary>
        [DataMember(Name="interestOnlyPayments", EmitDefaultValue=false)]
        public bool? InterestOnlyPayments { get; set; }

        /// <summary>
        /// Gets or Sets StepPayments
        /// </summary>
        [DataMember(Name="stepPayments", EmitDefaultValue=false)]
        public bool? StepPayments { get; set; }

        /// <summary>
        /// Gets or Sets StepPayment
        /// </summary>
        [DataMember(Name="stepPayment", EmitDefaultValue=false)]
        public int? StepPayment { get; set; }

        /// <summary>
        /// Gets or Sets SeasonalPayments
        /// </summary>
        [DataMember(Name="seasonalPayments", EmitDefaultValue=false)]
        public bool? SeasonalPayments { get; set; }

        /// <summary>
        /// Gets or Sets SeasonalPaymentFromYr
        /// </summary>
        [DataMember(Name="seasonalPaymentFromYr", EmitDefaultValue=false)]
        public string SeasonalPaymentFromYr { get; set; }

        /// <summary>
        /// Gets or Sets FirstChangeAmt
        /// </summary>
        [DataMember(Name="firstChangeAmt", EmitDefaultValue=false)]
        public string FirstChangeAmt { get; set; }

        /// <summary>
        /// Gets or Sets SubsequentChanges
        /// </summary>
        [DataMember(Name="subsequentChanges", EmitDefaultValue=false)]
        public string SubsequentChanges { get; set; }

        /// <summary>
        /// Gets or Sets MaximumPaymentAmt
        /// </summary>
        [DataMember(Name="maximumPaymentAmt", EmitDefaultValue=false)]
        public string MaximumPaymentAmt { get; set; }

        /// <summary>
        /// Gets or Sets FirstChangeMinAmt
        /// </summary>
        [DataMember(Name="firstChangeMinAmt", EmitDefaultValue=false)]
        public double? FirstChangeMinAmt { get; set; }

        /// <summary>
        /// Gets or Sets FirstChangeMaxAmt
        /// </summary>
        [DataMember(Name="firstChangeMaxAmt", EmitDefaultValue=false)]
        public double? FirstChangeMaxAmt { get; set; }

        /// <summary>
        /// Gets or Sets FirstChangePayment
        /// </summary>
        [DataMember(Name="firstChangePayment", EmitDefaultValue=false)]
        public string FirstChangePayment { get; set; }

        /// <summary>
        /// Gets or Sets MaxPaymentAmt
        /// </summary>
        [DataMember(Name="maxPaymentAmt", EmitDefaultValue=false)]
        public double? MaxPaymentAmt { get; set; }

        /// <summary>
        /// Gets or Sets MaxPayment
        /// </summary>
        [DataMember(Name="maxPayment", EmitDefaultValue=false)]
        public string MaxPayment { get; set; }

        /// <summary>
        /// Gets or Sets TotalDisbursed1YearConsummation
        /// </summary>
        [DataMember(Name="totalDisbursed1YearConsummation", EmitDefaultValue=false)]
        public double? TotalDisbursed1YearConsummation { get; set; }

        /// <summary>
        /// Gets or Sets NonEscrowedPropertyCosts1YearConsummation
        /// </summary>
        [DataMember(Name="nonEscrowedPropertyCosts1YearConsummation", EmitDefaultValue=false)]
        public double? NonEscrowedPropertyCosts1YearConsummation { get; set; }

        /// <summary>
        /// Gets or Sets PartialPaymentHoldUntilComplete
        /// </summary>
        [DataMember(Name="partialPaymentHoldUntilComplete", EmitDefaultValue=false)]
        public string PartialPaymentHoldUntilComplete { get; set; }

        /// <summary>
        /// Gets or Sets PartialPaymentNone
        /// </summary>
        [DataMember(Name="partialPaymentNone", EmitDefaultValue=false)]
        public string PartialPaymentNone { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreARMAdj
        /// </summary>
        [DataMember(Name="ignoreARMAdj", EmitDefaultValue=false)]
        public bool? IgnoreARMAdj { get; set; }

        /// <summary>
        /// Gets or Sets InitialEscrowPayment
        /// </summary>
        [DataMember(Name="initialEscrowPayment", EmitDefaultValue=false)]
        public double? InitialEscrowPayment { get; set; }

        /// <summary>
        /// Gets or Sets HOADuesIsEscrow
        /// </summary>
        [DataMember(Name="hOADuesIsEscrow", EmitDefaultValue=false)]
        public bool? HOADuesIsEscrow { get; set; }

        /// <summary>
        /// Gets or Sets InterestOnlyPaymentMonths
        /// </summary>
        [DataMember(Name="interestOnlyPaymentMonths", EmitDefaultValue=false)]
        public int? InterestOnlyPaymentMonths { get; set; }

        /// <summary>
        /// Gets or Sets InterestRateAdjustments
        /// </summary>
        [DataMember(Name="interestRateAdjustments", EmitDefaultValue=false)]
        public int? InterestRateAdjustments { get; set; }

        /// <summary>
        /// Gets or Sets StepRateFirstChange
        /// </summary>
        [DataMember(Name="stepRateFirstChange", EmitDefaultValue=false)]
        public double? StepRateFirstChange { get; set; }

        /// <summary>
        /// Gets or Sets MaximumARMPaymentAmount
        /// </summary>
        [DataMember(Name="maximumARMPaymentAmount", EmitDefaultValue=false)]
        public int? MaximumARMPaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets MaximumARMPaymentMonthReached
        /// </summary>
        [DataMember(Name="maximumARMPaymentMonthReached", EmitDefaultValue=false)]
        public int? MaximumARMPaymentMonthReached { get; set; }

        /// <summary>
        /// Gets or Sets EscrowedPropertyCostsBasis
        /// </summary>
        [DataMember(Name="escrowedPropertyCostsBasis", EmitDefaultValue=false)]
        public string EscrowedPropertyCostsBasis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingCostClosingDisclosure4 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DemandFeature: ").Append(DemandFeature).Append("\n");
            sb.Append("  NegativeAmortization: ").Append(NegativeAmortization).Append("\n");
            sb.Append("  PartialPayment: ").Append(PartialPayment).Append("\n");
            sb.Append("  Other1: ").Append(Other1).Append("\n");
            sb.Append("  Other2: ").Append(Other2).Append("\n");
            sb.Append("  Other3: ").Append(Other3).Append("\n");
            sb.Append("  Lender: ").Append(Lender).Append("\n");
            sb.Append("  EstimatedPropertyCosts: ").Append(EstimatedPropertyCosts).Append("\n");
            sb.Append("  EscrowIndicator: ").Append(EscrowIndicator).Append("\n");
            sb.Append("  MonthlyEscrowPayment: ").Append(MonthlyEscrowPayment).Append("\n");
            sb.Append("  InterestOnlyPayments: ").Append(InterestOnlyPayments).Append("\n");
            sb.Append("  StepPayments: ").Append(StepPayments).Append("\n");
            sb.Append("  StepPayment: ").Append(StepPayment).Append("\n");
            sb.Append("  SeasonalPayments: ").Append(SeasonalPayments).Append("\n");
            sb.Append("  SeasonalPaymentFromYr: ").Append(SeasonalPaymentFromYr).Append("\n");
            sb.Append("  FirstChangeAmt: ").Append(FirstChangeAmt).Append("\n");
            sb.Append("  SubsequentChanges: ").Append(SubsequentChanges).Append("\n");
            sb.Append("  MaximumPaymentAmt: ").Append(MaximumPaymentAmt).Append("\n");
            sb.Append("  FirstChangeMinAmt: ").Append(FirstChangeMinAmt).Append("\n");
            sb.Append("  FirstChangeMaxAmt: ").Append(FirstChangeMaxAmt).Append("\n");
            sb.Append("  FirstChangePayment: ").Append(FirstChangePayment).Append("\n");
            sb.Append("  MaxPaymentAmt: ").Append(MaxPaymentAmt).Append("\n");
            sb.Append("  MaxPayment: ").Append(MaxPayment).Append("\n");
            sb.Append("  TotalDisbursed1YearConsummation: ").Append(TotalDisbursed1YearConsummation).Append("\n");
            sb.Append("  NonEscrowedPropertyCosts1YearConsummation: ").Append(NonEscrowedPropertyCosts1YearConsummation).Append("\n");
            sb.Append("  PartialPaymentHoldUntilComplete: ").Append(PartialPaymentHoldUntilComplete).Append("\n");
            sb.Append("  PartialPaymentNone: ").Append(PartialPaymentNone).Append("\n");
            sb.Append("  IgnoreARMAdj: ").Append(IgnoreARMAdj).Append("\n");
            sb.Append("  InitialEscrowPayment: ").Append(InitialEscrowPayment).Append("\n");
            sb.Append("  HOADuesIsEscrow: ").Append(HOADuesIsEscrow).Append("\n");
            sb.Append("  InterestOnlyPaymentMonths: ").Append(InterestOnlyPaymentMonths).Append("\n");
            sb.Append("  InterestRateAdjustments: ").Append(InterestRateAdjustments).Append("\n");
            sb.Append("  StepRateFirstChange: ").Append(StepRateFirstChange).Append("\n");
            sb.Append("  MaximumARMPaymentAmount: ").Append(MaximumARMPaymentAmount).Append("\n");
            sb.Append("  MaximumARMPaymentMonthReached: ").Append(MaximumARMPaymentMonthReached).Append("\n");
            sb.Append("  EscrowedPropertyCostsBasis: ").Append(EscrowedPropertyCostsBasis).Append("\n");
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
            return this.Equals(input as LoanContractClosingCostClosingDisclosure4);
        }

        /// <summary>
        /// Returns true if LoanContractClosingCostClosingDisclosure4 instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingCostClosingDisclosure4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingCostClosingDisclosure4 input)
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
                    this.DemandFeature == input.DemandFeature ||
                    (this.DemandFeature != null &&
                    this.DemandFeature.Equals(input.DemandFeature))
                ) && 
                (
                    this.NegativeAmortization == input.NegativeAmortization ||
                    (this.NegativeAmortization != null &&
                    this.NegativeAmortization.Equals(input.NegativeAmortization))
                ) && 
                (
                    this.PartialPayment == input.PartialPayment ||
                    (this.PartialPayment != null &&
                    this.PartialPayment.Equals(input.PartialPayment))
                ) && 
                (
                    this.Other1 == input.Other1 ||
                    (this.Other1 != null &&
                    this.Other1.Equals(input.Other1))
                ) && 
                (
                    this.Other2 == input.Other2 ||
                    (this.Other2 != null &&
                    this.Other2.Equals(input.Other2))
                ) && 
                (
                    this.Other3 == input.Other3 ||
                    (this.Other3 != null &&
                    this.Other3.Equals(input.Other3))
                ) && 
                (
                    this.Lender == input.Lender ||
                    (this.Lender != null &&
                    this.Lender.Equals(input.Lender))
                ) && 
                (
                    this.EstimatedPropertyCosts == input.EstimatedPropertyCosts ||
                    (this.EstimatedPropertyCosts != null &&
                    this.EstimatedPropertyCosts.Equals(input.EstimatedPropertyCosts))
                ) && 
                (
                    this.EscrowIndicator == input.EscrowIndicator ||
                    (this.EscrowIndicator != null &&
                    this.EscrowIndicator.Equals(input.EscrowIndicator))
                ) && 
                (
                    this.MonthlyEscrowPayment == input.MonthlyEscrowPayment ||
                    (this.MonthlyEscrowPayment != null &&
                    this.MonthlyEscrowPayment.Equals(input.MonthlyEscrowPayment))
                ) && 
                (
                    this.InterestOnlyPayments == input.InterestOnlyPayments ||
                    (this.InterestOnlyPayments != null &&
                    this.InterestOnlyPayments.Equals(input.InterestOnlyPayments))
                ) && 
                (
                    this.StepPayments == input.StepPayments ||
                    (this.StepPayments != null &&
                    this.StepPayments.Equals(input.StepPayments))
                ) && 
                (
                    this.StepPayment == input.StepPayment ||
                    (this.StepPayment != null &&
                    this.StepPayment.Equals(input.StepPayment))
                ) && 
                (
                    this.SeasonalPayments == input.SeasonalPayments ||
                    (this.SeasonalPayments != null &&
                    this.SeasonalPayments.Equals(input.SeasonalPayments))
                ) && 
                (
                    this.SeasonalPaymentFromYr == input.SeasonalPaymentFromYr ||
                    (this.SeasonalPaymentFromYr != null &&
                    this.SeasonalPaymentFromYr.Equals(input.SeasonalPaymentFromYr))
                ) && 
                (
                    this.FirstChangeAmt == input.FirstChangeAmt ||
                    (this.FirstChangeAmt != null &&
                    this.FirstChangeAmt.Equals(input.FirstChangeAmt))
                ) && 
                (
                    this.SubsequentChanges == input.SubsequentChanges ||
                    (this.SubsequentChanges != null &&
                    this.SubsequentChanges.Equals(input.SubsequentChanges))
                ) && 
                (
                    this.MaximumPaymentAmt == input.MaximumPaymentAmt ||
                    (this.MaximumPaymentAmt != null &&
                    this.MaximumPaymentAmt.Equals(input.MaximumPaymentAmt))
                ) && 
                (
                    this.FirstChangeMinAmt == input.FirstChangeMinAmt ||
                    (this.FirstChangeMinAmt != null &&
                    this.FirstChangeMinAmt.Equals(input.FirstChangeMinAmt))
                ) && 
                (
                    this.FirstChangeMaxAmt == input.FirstChangeMaxAmt ||
                    (this.FirstChangeMaxAmt != null &&
                    this.FirstChangeMaxAmt.Equals(input.FirstChangeMaxAmt))
                ) && 
                (
                    this.FirstChangePayment == input.FirstChangePayment ||
                    (this.FirstChangePayment != null &&
                    this.FirstChangePayment.Equals(input.FirstChangePayment))
                ) && 
                (
                    this.MaxPaymentAmt == input.MaxPaymentAmt ||
                    (this.MaxPaymentAmt != null &&
                    this.MaxPaymentAmt.Equals(input.MaxPaymentAmt))
                ) && 
                (
                    this.MaxPayment == input.MaxPayment ||
                    (this.MaxPayment != null &&
                    this.MaxPayment.Equals(input.MaxPayment))
                ) && 
                (
                    this.TotalDisbursed1YearConsummation == input.TotalDisbursed1YearConsummation ||
                    (this.TotalDisbursed1YearConsummation != null &&
                    this.TotalDisbursed1YearConsummation.Equals(input.TotalDisbursed1YearConsummation))
                ) && 
                (
                    this.NonEscrowedPropertyCosts1YearConsummation == input.NonEscrowedPropertyCosts1YearConsummation ||
                    (this.NonEscrowedPropertyCosts1YearConsummation != null &&
                    this.NonEscrowedPropertyCosts1YearConsummation.Equals(input.NonEscrowedPropertyCosts1YearConsummation))
                ) && 
                (
                    this.PartialPaymentHoldUntilComplete == input.PartialPaymentHoldUntilComplete ||
                    (this.PartialPaymentHoldUntilComplete != null &&
                    this.PartialPaymentHoldUntilComplete.Equals(input.PartialPaymentHoldUntilComplete))
                ) && 
                (
                    this.PartialPaymentNone == input.PartialPaymentNone ||
                    (this.PartialPaymentNone != null &&
                    this.PartialPaymentNone.Equals(input.PartialPaymentNone))
                ) && 
                (
                    this.IgnoreARMAdj == input.IgnoreARMAdj ||
                    (this.IgnoreARMAdj != null &&
                    this.IgnoreARMAdj.Equals(input.IgnoreARMAdj))
                ) && 
                (
                    this.InitialEscrowPayment == input.InitialEscrowPayment ||
                    (this.InitialEscrowPayment != null &&
                    this.InitialEscrowPayment.Equals(input.InitialEscrowPayment))
                ) && 
                (
                    this.HOADuesIsEscrow == input.HOADuesIsEscrow ||
                    (this.HOADuesIsEscrow != null &&
                    this.HOADuesIsEscrow.Equals(input.HOADuesIsEscrow))
                ) && 
                (
                    this.InterestOnlyPaymentMonths == input.InterestOnlyPaymentMonths ||
                    (this.InterestOnlyPaymentMonths != null &&
                    this.InterestOnlyPaymentMonths.Equals(input.InterestOnlyPaymentMonths))
                ) && 
                (
                    this.InterestRateAdjustments == input.InterestRateAdjustments ||
                    (this.InterestRateAdjustments != null &&
                    this.InterestRateAdjustments.Equals(input.InterestRateAdjustments))
                ) && 
                (
                    this.StepRateFirstChange == input.StepRateFirstChange ||
                    (this.StepRateFirstChange != null &&
                    this.StepRateFirstChange.Equals(input.StepRateFirstChange))
                ) && 
                (
                    this.MaximumARMPaymentAmount == input.MaximumARMPaymentAmount ||
                    (this.MaximumARMPaymentAmount != null &&
                    this.MaximumARMPaymentAmount.Equals(input.MaximumARMPaymentAmount))
                ) && 
                (
                    this.MaximumARMPaymentMonthReached == input.MaximumARMPaymentMonthReached ||
                    (this.MaximumARMPaymentMonthReached != null &&
                    this.MaximumARMPaymentMonthReached.Equals(input.MaximumARMPaymentMonthReached))
                ) && 
                (
                    this.EscrowedPropertyCostsBasis == input.EscrowedPropertyCostsBasis ||
                    (this.EscrowedPropertyCostsBasis != null &&
                    this.EscrowedPropertyCostsBasis.Equals(input.EscrowedPropertyCostsBasis))
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
                if (this.DemandFeature != null)
                    hashCode = hashCode * 59 + this.DemandFeature.GetHashCode();
                if (this.NegativeAmortization != null)
                    hashCode = hashCode * 59 + this.NegativeAmortization.GetHashCode();
                if (this.PartialPayment != null)
                    hashCode = hashCode * 59 + this.PartialPayment.GetHashCode();
                if (this.Other1 != null)
                    hashCode = hashCode * 59 + this.Other1.GetHashCode();
                if (this.Other2 != null)
                    hashCode = hashCode * 59 + this.Other2.GetHashCode();
                if (this.Other3 != null)
                    hashCode = hashCode * 59 + this.Other3.GetHashCode();
                if (this.Lender != null)
                    hashCode = hashCode * 59 + this.Lender.GetHashCode();
                if (this.EstimatedPropertyCosts != null)
                    hashCode = hashCode * 59 + this.EstimatedPropertyCosts.GetHashCode();
                if (this.EscrowIndicator != null)
                    hashCode = hashCode * 59 + this.EscrowIndicator.GetHashCode();
                if (this.MonthlyEscrowPayment != null)
                    hashCode = hashCode * 59 + this.MonthlyEscrowPayment.GetHashCode();
                if (this.InterestOnlyPayments != null)
                    hashCode = hashCode * 59 + this.InterestOnlyPayments.GetHashCode();
                if (this.StepPayments != null)
                    hashCode = hashCode * 59 + this.StepPayments.GetHashCode();
                if (this.StepPayment != null)
                    hashCode = hashCode * 59 + this.StepPayment.GetHashCode();
                if (this.SeasonalPayments != null)
                    hashCode = hashCode * 59 + this.SeasonalPayments.GetHashCode();
                if (this.SeasonalPaymentFromYr != null)
                    hashCode = hashCode * 59 + this.SeasonalPaymentFromYr.GetHashCode();
                if (this.FirstChangeAmt != null)
                    hashCode = hashCode * 59 + this.FirstChangeAmt.GetHashCode();
                if (this.SubsequentChanges != null)
                    hashCode = hashCode * 59 + this.SubsequentChanges.GetHashCode();
                if (this.MaximumPaymentAmt != null)
                    hashCode = hashCode * 59 + this.MaximumPaymentAmt.GetHashCode();
                if (this.FirstChangeMinAmt != null)
                    hashCode = hashCode * 59 + this.FirstChangeMinAmt.GetHashCode();
                if (this.FirstChangeMaxAmt != null)
                    hashCode = hashCode * 59 + this.FirstChangeMaxAmt.GetHashCode();
                if (this.FirstChangePayment != null)
                    hashCode = hashCode * 59 + this.FirstChangePayment.GetHashCode();
                if (this.MaxPaymentAmt != null)
                    hashCode = hashCode * 59 + this.MaxPaymentAmt.GetHashCode();
                if (this.MaxPayment != null)
                    hashCode = hashCode * 59 + this.MaxPayment.GetHashCode();
                if (this.TotalDisbursed1YearConsummation != null)
                    hashCode = hashCode * 59 + this.TotalDisbursed1YearConsummation.GetHashCode();
                if (this.NonEscrowedPropertyCosts1YearConsummation != null)
                    hashCode = hashCode * 59 + this.NonEscrowedPropertyCosts1YearConsummation.GetHashCode();
                if (this.PartialPaymentHoldUntilComplete != null)
                    hashCode = hashCode * 59 + this.PartialPaymentHoldUntilComplete.GetHashCode();
                if (this.PartialPaymentNone != null)
                    hashCode = hashCode * 59 + this.PartialPaymentNone.GetHashCode();
                if (this.IgnoreARMAdj != null)
                    hashCode = hashCode * 59 + this.IgnoreARMAdj.GetHashCode();
                if (this.InitialEscrowPayment != null)
                    hashCode = hashCode * 59 + this.InitialEscrowPayment.GetHashCode();
                if (this.HOADuesIsEscrow != null)
                    hashCode = hashCode * 59 + this.HOADuesIsEscrow.GetHashCode();
                if (this.InterestOnlyPaymentMonths != null)
                    hashCode = hashCode * 59 + this.InterestOnlyPaymentMonths.GetHashCode();
                if (this.InterestRateAdjustments != null)
                    hashCode = hashCode * 59 + this.InterestRateAdjustments.GetHashCode();
                if (this.StepRateFirstChange != null)
                    hashCode = hashCode * 59 + this.StepRateFirstChange.GetHashCode();
                if (this.MaximumARMPaymentAmount != null)
                    hashCode = hashCode * 59 + this.MaximumARMPaymentAmount.GetHashCode();
                if (this.MaximumARMPaymentMonthReached != null)
                    hashCode = hashCode * 59 + this.MaximumARMPaymentMonthReached.GetHashCode();
                if (this.EscrowedPropertyCostsBasis != null)
                    hashCode = hashCode * 59 + this.EscrowedPropertyCostsBasis.GetHashCode();
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
