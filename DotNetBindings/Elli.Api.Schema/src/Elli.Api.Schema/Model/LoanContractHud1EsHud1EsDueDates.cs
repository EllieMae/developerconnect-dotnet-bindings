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
    /// LoanContractHud1EsHud1EsDueDates
    /// </summary>
    [DataContract]
    public partial class LoanContractHud1EsHud1EsDueDates :  IEquatable<LoanContractHud1EsHud1EsDueDates>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AnnualFee
        /// </summary>
        [DataMember(Name="annualFee", EmitDefaultValue=false)]
        public DateTime? AnnualFee { get; set; }

        /// <summary>
        /// Gets or Sets FloodInsDisb
        /// </summary>
        [DataMember(Name="floodInsDisb", EmitDefaultValue=false)]
        public DateTime? FloodInsDisb { get; set; }

        /// <summary>
        /// Gets or Sets HazInsDisb
        /// </summary>
        [DataMember(Name="hazInsDisb", EmitDefaultValue=false)]
        public DateTime? HazInsDisb { get; set; }

        /// <summary>
        /// Gets or Sets Hud1EsDueDateIndex
        /// </summary>
        [DataMember(Name="hud1EsDueDateIndex", EmitDefaultValue=false)]
        public int? Hud1EsDueDateIndex { get; set; }

        /// <summary>
        /// Gets or Sets MtgInsDisb
        /// </summary>
        [DataMember(Name="mtgInsDisb", EmitDefaultValue=false)]
        public DateTime? MtgInsDisb { get; set; }

        /// <summary>
        /// Gets or Sets SchoolTaxes
        /// </summary>
        [DataMember(Name="schoolTaxes", EmitDefaultValue=false)]
        public DateTime? SchoolTaxes { get; set; }

        /// <summary>
        /// Gets or Sets TaxDisb
        /// </summary>
        [DataMember(Name="taxDisb", EmitDefaultValue=false)]
        public DateTime? TaxDisb { get; set; }

        /// <summary>
        /// Gets or Sets UserDefined1
        /// </summary>
        [DataMember(Name="userDefined1", EmitDefaultValue=false)]
        public DateTime? UserDefined1 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefined2
        /// </summary>
        [DataMember(Name="userDefined2", EmitDefaultValue=false)]
        public DateTime? UserDefined2 { get; set; }

        /// <summary>
        /// Gets or Sets UserDefined3
        /// </summary>
        [DataMember(Name="userDefined3", EmitDefaultValue=false)]
        public DateTime? UserDefined3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractHud1EsHud1EsDueDates {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AnnualFee: ").Append(AnnualFee).Append("\n");
            sb.Append("  FloodInsDisb: ").Append(FloodInsDisb).Append("\n");
            sb.Append("  HazInsDisb: ").Append(HazInsDisb).Append("\n");
            sb.Append("  Hud1EsDueDateIndex: ").Append(Hud1EsDueDateIndex).Append("\n");
            sb.Append("  MtgInsDisb: ").Append(MtgInsDisb).Append("\n");
            sb.Append("  SchoolTaxes: ").Append(SchoolTaxes).Append("\n");
            sb.Append("  TaxDisb: ").Append(TaxDisb).Append("\n");
            sb.Append("  UserDefined1: ").Append(UserDefined1).Append("\n");
            sb.Append("  UserDefined2: ").Append(UserDefined2).Append("\n");
            sb.Append("  UserDefined3: ").Append(UserDefined3).Append("\n");
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
            return this.Equals(input as LoanContractHud1EsHud1EsDueDates);
        }

        /// <summary>
        /// Returns true if LoanContractHud1EsHud1EsDueDates instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractHud1EsHud1EsDueDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractHud1EsHud1EsDueDates input)
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
                    this.AnnualFee == input.AnnualFee ||
                    (this.AnnualFee != null &&
                    this.AnnualFee.Equals(input.AnnualFee))
                ) && 
                (
                    this.FloodInsDisb == input.FloodInsDisb ||
                    (this.FloodInsDisb != null &&
                    this.FloodInsDisb.Equals(input.FloodInsDisb))
                ) && 
                (
                    this.HazInsDisb == input.HazInsDisb ||
                    (this.HazInsDisb != null &&
                    this.HazInsDisb.Equals(input.HazInsDisb))
                ) && 
                (
                    this.Hud1EsDueDateIndex == input.Hud1EsDueDateIndex ||
                    (this.Hud1EsDueDateIndex != null &&
                    this.Hud1EsDueDateIndex.Equals(input.Hud1EsDueDateIndex))
                ) && 
                (
                    this.MtgInsDisb == input.MtgInsDisb ||
                    (this.MtgInsDisb != null &&
                    this.MtgInsDisb.Equals(input.MtgInsDisb))
                ) && 
                (
                    this.SchoolTaxes == input.SchoolTaxes ||
                    (this.SchoolTaxes != null &&
                    this.SchoolTaxes.Equals(input.SchoolTaxes))
                ) && 
                (
                    this.TaxDisb == input.TaxDisb ||
                    (this.TaxDisb != null &&
                    this.TaxDisb.Equals(input.TaxDisb))
                ) && 
                (
                    this.UserDefined1 == input.UserDefined1 ||
                    (this.UserDefined1 != null &&
                    this.UserDefined1.Equals(input.UserDefined1))
                ) && 
                (
                    this.UserDefined2 == input.UserDefined2 ||
                    (this.UserDefined2 != null &&
                    this.UserDefined2.Equals(input.UserDefined2))
                ) && 
                (
                    this.UserDefined3 == input.UserDefined3 ||
                    (this.UserDefined3 != null &&
                    this.UserDefined3.Equals(input.UserDefined3))
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
                if (this.AnnualFee != null)
                    hashCode = hashCode * 59 + this.AnnualFee.GetHashCode();
                if (this.FloodInsDisb != null)
                    hashCode = hashCode * 59 + this.FloodInsDisb.GetHashCode();
                if (this.HazInsDisb != null)
                    hashCode = hashCode * 59 + this.HazInsDisb.GetHashCode();
                if (this.Hud1EsDueDateIndex != null)
                    hashCode = hashCode * 59 + this.Hud1EsDueDateIndex.GetHashCode();
                if (this.MtgInsDisb != null)
                    hashCode = hashCode * 59 + this.MtgInsDisb.GetHashCode();
                if (this.SchoolTaxes != null)
                    hashCode = hashCode * 59 + this.SchoolTaxes.GetHashCode();
                if (this.TaxDisb != null)
                    hashCode = hashCode * 59 + this.TaxDisb.GetHashCode();
                if (this.UserDefined1 != null)
                    hashCode = hashCode * 59 + this.UserDefined1.GetHashCode();
                if (this.UserDefined2 != null)
                    hashCode = hashCode * 59 + this.UserDefined2.GetHashCode();
                if (this.UserDefined3 != null)
                    hashCode = hashCode * 59 + this.UserDefined3.GetHashCode();
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
