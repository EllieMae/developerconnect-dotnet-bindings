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
    /// LoanContractAssets
    /// </summary>
    [DataContract]
    public partial class LoanContractAssets :  IEquatable<LoanContractAssets>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntityDeleted
        /// </summary>
        [DataMember(Name="entityDeleted", EmitDefaultValue=false)]
        public bool? EntityDeleted { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentifier
        /// </summary>
        [DataMember(Name="accountIdentifier", EmitDefaultValue=false)]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AltId
        /// </summary>
        [DataMember(Name="altId", EmitDefaultValue=false)]
        public string AltId { get; set; }

        /// <summary>
        /// Gets or Sets AssetIndex
        /// </summary>
        [DataMember(Name="assetIndex", EmitDefaultValue=false)]
        public int? AssetIndex { get; set; }

        /// <summary>
        /// Gets or Sets AssetType
        /// </summary>
        [DataMember(Name="assetType", EmitDefaultValue=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name="attention", EmitDefaultValue=false)]
        public string Attention { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerId
        /// </summary>
        [DataMember(Name="borrowerId", EmitDefaultValue=false)]
        public string BorrowerId { get; set; }

        /// <summary>
        /// Gets or Sets CashOrMarketValueAmount
        /// </summary>
        [DataMember(Name="cashOrMarketValueAmount", EmitDefaultValue=false)]
        public double? CashOrMarketValueAmount { get; set; }

        /// <summary>
        /// Gets or Sets DepositoryAccountName
        /// </summary>
        [DataMember(Name="depositoryAccountName", EmitDefaultValue=false)]
        public string DepositoryAccountName { get; set; }

        /// <summary>
        /// Gets or Sets DepositoryRequestDate
        /// </summary>
        [DataMember(Name="depositoryRequestDate", EmitDefaultValue=false)]
        public DateTime? DepositoryRequestDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets HolderAddressCity
        /// </summary>
        [DataMember(Name="holderAddressCity", EmitDefaultValue=false)]
        public string HolderAddressCity { get; set; }

        /// <summary>
        /// Gets or Sets HolderAddressPostalCode
        /// </summary>
        [DataMember(Name="holderAddressPostalCode", EmitDefaultValue=false)]
        public string HolderAddressPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets HolderAddressState
        /// </summary>
        [DataMember(Name="holderAddressState", EmitDefaultValue=false)]
        public string HolderAddressState { get; set; }

        /// <summary>
        /// Gets or Sets HolderAddressStreetLine1
        /// </summary>
        [DataMember(Name="holderAddressStreetLine1", EmitDefaultValue=false)]
        public string HolderAddressStreetLine1 { get; set; }

        /// <summary>
        /// Gets or Sets HolderComments
        /// </summary>
        [DataMember(Name="holderComments", EmitDefaultValue=false)]
        public string HolderComments { get; set; }

        /// <summary>
        /// Gets or Sets HolderEmail
        /// </summary>
        [DataMember(Name="holderEmail", EmitDefaultValue=false)]
        public string HolderEmail { get; set; }

        /// <summary>
        /// Gets or Sets HolderFax
        /// </summary>
        [DataMember(Name="holderFax", EmitDefaultValue=false)]
        public string HolderFax { get; set; }

        /// <summary>
        /// Gets or Sets HolderName
        /// </summary>
        [DataMember(Name="holderName", EmitDefaultValue=false)]
        public string HolderName { get; set; }

        /// <summary>
        /// Gets or Sets HolderPhone
        /// </summary>
        [DataMember(Name="holderPhone", EmitDefaultValue=false)]
        public string HolderPhone { get; set; }

        /// <summary>
        /// Gets or Sets IsEmpty
        /// </summary>
        [DataMember(Name="isEmpty", EmitDefaultValue=false)]
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Gets or Sets IsVod
        /// </summary>
        [DataMember(Name="isVod", EmitDefaultValue=false)]
        public bool? IsVod { get; set; }

        /// <summary>
        /// Gets or Sets LifeInsuranceFaceValueAmount
        /// </summary>
        [DataMember(Name="lifeInsuranceFaceValueAmount", EmitDefaultValue=false)]
        public double? LifeInsuranceFaceValueAmount { get; set; }

        /// <summary>
        /// Gets or Sets NameInAccount
        /// </summary>
        [DataMember(Name="nameInAccount", EmitDefaultValue=false)]
        public string NameInAccount { get; set; }

        /// <summary>
        /// Gets or Sets NoLinkToDocTrackIndicator
        /// </summary>
        [DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets PrintAttachmentIndicator
        /// </summary>
        [DataMember(Name="printAttachmentIndicator", EmitDefaultValue=false)]
        public bool? PrintAttachmentIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PrintUserNameIndicator
        /// </summary>
        [DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
        public bool? PrintUserNameIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TitleFax
        /// </summary>
        [DataMember(Name="titleFax", EmitDefaultValue=false)]
        public string TitleFax { get; set; }

        /// <summary>
        /// Gets or Sets TitlePhone
        /// </summary>
        [DataMember(Name="titlePhone", EmitDefaultValue=false)]
        public string TitlePhone { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double? Total { get; set; }

        /// <summary>
        /// Gets or Sets VodIndex
        /// </summary>
        [DataMember(Name="vodIndex", EmitDefaultValue=false)]
        public int? VodIndex { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public EntityRefContract Contact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractAssets {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityDeleted: ").Append(EntityDeleted).Append("\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
            sb.Append("  AltId: ").Append(AltId).Append("\n");
            sb.Append("  AssetIndex: ").Append(AssetIndex).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  BorrowerId: ").Append(BorrowerId).Append("\n");
            sb.Append("  CashOrMarketValueAmount: ").Append(CashOrMarketValueAmount).Append("\n");
            sb.Append("  DepositoryAccountName: ").Append(DepositoryAccountName).Append("\n");
            sb.Append("  DepositoryRequestDate: ").Append(DepositoryRequestDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HolderAddressCity: ").Append(HolderAddressCity).Append("\n");
            sb.Append("  HolderAddressPostalCode: ").Append(HolderAddressPostalCode).Append("\n");
            sb.Append("  HolderAddressState: ").Append(HolderAddressState).Append("\n");
            sb.Append("  HolderAddressStreetLine1: ").Append(HolderAddressStreetLine1).Append("\n");
            sb.Append("  HolderComments: ").Append(HolderComments).Append("\n");
            sb.Append("  HolderEmail: ").Append(HolderEmail).Append("\n");
            sb.Append("  HolderFax: ").Append(HolderFax).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  HolderPhone: ").Append(HolderPhone).Append("\n");
            sb.Append("  IsEmpty: ").Append(IsEmpty).Append("\n");
            sb.Append("  IsVod: ").Append(IsVod).Append("\n");
            sb.Append("  LifeInsuranceFaceValueAmount: ").Append(LifeInsuranceFaceValueAmount).Append("\n");
            sb.Append("  NameInAccount: ").Append(NameInAccount).Append("\n");
            sb.Append("  NoLinkToDocTrackIndicator: ").Append(NoLinkToDocTrackIndicator).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PrintAttachmentIndicator: ").Append(PrintAttachmentIndicator).Append("\n");
            sb.Append("  PrintUserNameIndicator: ").Append(PrintUserNameIndicator).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleFax: ").Append(TitleFax).Append("\n");
            sb.Append("  TitlePhone: ").Append(TitlePhone).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  VodIndex: ").Append(VodIndex).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
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
            return this.Equals(input as LoanContractAssets);
        }

        /// <summary>
        /// Returns true if LoanContractAssets instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractAssets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractAssets input)
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
                    this.EntityDeleted == input.EntityDeleted ||
                    (this.EntityDeleted != null &&
                    this.EntityDeleted.Equals(input.EntityDeleted))
                ) && 
                (
                    this.AccountIdentifier == input.AccountIdentifier ||
                    (this.AccountIdentifier != null &&
                    this.AccountIdentifier.Equals(input.AccountIdentifier))
                ) && 
                (
                    this.AltId == input.AltId ||
                    (this.AltId != null &&
                    this.AltId.Equals(input.AltId))
                ) && 
                (
                    this.AssetIndex == input.AssetIndex ||
                    (this.AssetIndex != null &&
                    this.AssetIndex.Equals(input.AssetIndex))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.Attention == input.Attention ||
                    (this.Attention != null &&
                    this.Attention.Equals(input.Attention))
                ) && 
                (
                    this.BorrowerId == input.BorrowerId ||
                    (this.BorrowerId != null &&
                    this.BorrowerId.Equals(input.BorrowerId))
                ) && 
                (
                    this.CashOrMarketValueAmount == input.CashOrMarketValueAmount ||
                    (this.CashOrMarketValueAmount != null &&
                    this.CashOrMarketValueAmount.Equals(input.CashOrMarketValueAmount))
                ) && 
                (
                    this.DepositoryAccountName == input.DepositoryAccountName ||
                    (this.DepositoryAccountName != null &&
                    this.DepositoryAccountName.Equals(input.DepositoryAccountName))
                ) && 
                (
                    this.DepositoryRequestDate == input.DepositoryRequestDate ||
                    (this.DepositoryRequestDate != null &&
                    this.DepositoryRequestDate.Equals(input.DepositoryRequestDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HolderAddressCity == input.HolderAddressCity ||
                    (this.HolderAddressCity != null &&
                    this.HolderAddressCity.Equals(input.HolderAddressCity))
                ) && 
                (
                    this.HolderAddressPostalCode == input.HolderAddressPostalCode ||
                    (this.HolderAddressPostalCode != null &&
                    this.HolderAddressPostalCode.Equals(input.HolderAddressPostalCode))
                ) && 
                (
                    this.HolderAddressState == input.HolderAddressState ||
                    (this.HolderAddressState != null &&
                    this.HolderAddressState.Equals(input.HolderAddressState))
                ) && 
                (
                    this.HolderAddressStreetLine1 == input.HolderAddressStreetLine1 ||
                    (this.HolderAddressStreetLine1 != null &&
                    this.HolderAddressStreetLine1.Equals(input.HolderAddressStreetLine1))
                ) && 
                (
                    this.HolderComments == input.HolderComments ||
                    (this.HolderComments != null &&
                    this.HolderComments.Equals(input.HolderComments))
                ) && 
                (
                    this.HolderEmail == input.HolderEmail ||
                    (this.HolderEmail != null &&
                    this.HolderEmail.Equals(input.HolderEmail))
                ) && 
                (
                    this.HolderFax == input.HolderFax ||
                    (this.HolderFax != null &&
                    this.HolderFax.Equals(input.HolderFax))
                ) && 
                (
                    this.HolderName == input.HolderName ||
                    (this.HolderName != null &&
                    this.HolderName.Equals(input.HolderName))
                ) && 
                (
                    this.HolderPhone == input.HolderPhone ||
                    (this.HolderPhone != null &&
                    this.HolderPhone.Equals(input.HolderPhone))
                ) && 
                (
                    this.IsEmpty == input.IsEmpty ||
                    (this.IsEmpty != null &&
                    this.IsEmpty.Equals(input.IsEmpty))
                ) && 
                (
                    this.IsVod == input.IsVod ||
                    (this.IsVod != null &&
                    this.IsVod.Equals(input.IsVod))
                ) && 
                (
                    this.LifeInsuranceFaceValueAmount == input.LifeInsuranceFaceValueAmount ||
                    (this.LifeInsuranceFaceValueAmount != null &&
                    this.LifeInsuranceFaceValueAmount.Equals(input.LifeInsuranceFaceValueAmount))
                ) && 
                (
                    this.NameInAccount == input.NameInAccount ||
                    (this.NameInAccount != null &&
                    this.NameInAccount.Equals(input.NameInAccount))
                ) && 
                (
                    this.NoLinkToDocTrackIndicator == input.NoLinkToDocTrackIndicator ||
                    (this.NoLinkToDocTrackIndicator != null &&
                    this.NoLinkToDocTrackIndicator.Equals(input.NoLinkToDocTrackIndicator))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.PrintAttachmentIndicator == input.PrintAttachmentIndicator ||
                    (this.PrintAttachmentIndicator != null &&
                    this.PrintAttachmentIndicator.Equals(input.PrintAttachmentIndicator))
                ) && 
                (
                    this.PrintUserNameIndicator == input.PrintUserNameIndicator ||
                    (this.PrintUserNameIndicator != null &&
                    this.PrintUserNameIndicator.Equals(input.PrintUserNameIndicator))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TitleFax == input.TitleFax ||
                    (this.TitleFax != null &&
                    this.TitleFax.Equals(input.TitleFax))
                ) && 
                (
                    this.TitlePhone == input.TitlePhone ||
                    (this.TitlePhone != null &&
                    this.TitlePhone.Equals(input.TitlePhone))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.VodIndex == input.VodIndex ||
                    (this.VodIndex != null &&
                    this.VodIndex.Equals(input.VodIndex))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
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
                if (this.EntityDeleted != null)
                    hashCode = hashCode * 59 + this.EntityDeleted.GetHashCode();
                if (this.AccountIdentifier != null)
                    hashCode = hashCode * 59 + this.AccountIdentifier.GetHashCode();
                if (this.AltId != null)
                    hashCode = hashCode * 59 + this.AltId.GetHashCode();
                if (this.AssetIndex != null)
                    hashCode = hashCode * 59 + this.AssetIndex.GetHashCode();
                if (this.AssetType != null)
                    hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.Attention != null)
                    hashCode = hashCode * 59 + this.Attention.GetHashCode();
                if (this.BorrowerId != null)
                    hashCode = hashCode * 59 + this.BorrowerId.GetHashCode();
                if (this.CashOrMarketValueAmount != null)
                    hashCode = hashCode * 59 + this.CashOrMarketValueAmount.GetHashCode();
                if (this.DepositoryAccountName != null)
                    hashCode = hashCode * 59 + this.DepositoryAccountName.GetHashCode();
                if (this.DepositoryRequestDate != null)
                    hashCode = hashCode * 59 + this.DepositoryRequestDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HolderAddressCity != null)
                    hashCode = hashCode * 59 + this.HolderAddressCity.GetHashCode();
                if (this.HolderAddressPostalCode != null)
                    hashCode = hashCode * 59 + this.HolderAddressPostalCode.GetHashCode();
                if (this.HolderAddressState != null)
                    hashCode = hashCode * 59 + this.HolderAddressState.GetHashCode();
                if (this.HolderAddressStreetLine1 != null)
                    hashCode = hashCode * 59 + this.HolderAddressStreetLine1.GetHashCode();
                if (this.HolderComments != null)
                    hashCode = hashCode * 59 + this.HolderComments.GetHashCode();
                if (this.HolderEmail != null)
                    hashCode = hashCode * 59 + this.HolderEmail.GetHashCode();
                if (this.HolderFax != null)
                    hashCode = hashCode * 59 + this.HolderFax.GetHashCode();
                if (this.HolderName != null)
                    hashCode = hashCode * 59 + this.HolderName.GetHashCode();
                if (this.HolderPhone != null)
                    hashCode = hashCode * 59 + this.HolderPhone.GetHashCode();
                if (this.IsEmpty != null)
                    hashCode = hashCode * 59 + this.IsEmpty.GetHashCode();
                if (this.IsVod != null)
                    hashCode = hashCode * 59 + this.IsVod.GetHashCode();
                if (this.LifeInsuranceFaceValueAmount != null)
                    hashCode = hashCode * 59 + this.LifeInsuranceFaceValueAmount.GetHashCode();
                if (this.NameInAccount != null)
                    hashCode = hashCode * 59 + this.NameInAccount.GetHashCode();
                if (this.NoLinkToDocTrackIndicator != null)
                    hashCode = hashCode * 59 + this.NoLinkToDocTrackIndicator.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.PrintAttachmentIndicator != null)
                    hashCode = hashCode * 59 + this.PrintAttachmentIndicator.GetHashCode();
                if (this.PrintUserNameIndicator != null)
                    hashCode = hashCode * 59 + this.PrintUserNameIndicator.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleFax != null)
                    hashCode = hashCode * 59 + this.TitleFax.GetHashCode();
                if (this.TitlePhone != null)
                    hashCode = hashCode * 59 + this.TitlePhone.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.VodIndex != null)
                    hashCode = hashCode * 59 + this.VodIndex.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
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
