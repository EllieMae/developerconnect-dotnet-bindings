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
    /// LoanContractLockConfirmLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractLockConfirmLogs :  IEquatable<LoanContractLockConfirmLogs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AlertIndicator
        /// </summary>
        [DataMember(Name="alertIndicator", EmitDefaultValue=false)]
        public bool? AlertIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name="alerts", EmitDefaultValue=false)]
        public List<LoanContractAlerts> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets BuySideExpirationDate
        /// </summary>
        [DataMember(Name="buySideExpirationDate", EmitDefaultValue=false)]
        public DateTime? BuySideExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets CommentList
        /// </summary>
        [DataMember(Name="commentList", EmitDefaultValue=false)]
        public List<LoanContractLogRecordCommentList> CommentList { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedBy
        /// </summary>
        [DataMember(Name="confirmedBy", EmitDefaultValue=false)]
        public string ConfirmedBy { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedByIdIndicator
        /// </summary>
        [DataMember(Name="confirmedByIdIndicator", EmitDefaultValue=false)]
        public bool? ConfirmedByIdIndicator { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedById
        /// </summary>
        [DataMember(Name="confirmedById", EmitDefaultValue=false)]
        public string ConfirmedById { get; set; }

        /// <summary>
        /// Gets or Sets DateUtc
        /// </summary>
        [DataMember(Name="dateUtc", EmitDefaultValue=false)]
        public DateTime? DateUtc { get; set; }

        /// <summary>
        /// Gets or Sets FileAttachmentsMigrated
        /// </summary>
        [DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
        public bool? FileAttachmentsMigrated { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemSpecificIndicator
        /// </summary>
        [DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
        public bool? IsSystemSpecificIndicator { get; set; }

        /// <summary>
        /// Gets or Sets LogRecordIndex
        /// </summary>
        [DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
        public int? LogRecordIndex { get; set; }

        /// <summary>
        /// Gets or Sets RequestGuid
        /// </summary>
        [DataMember(Name="requestGuid", EmitDefaultValue=false)]
        public string RequestGuid { get; set; }

        /// <summary>
        /// Gets or Sets SellSideDeliveredBy
        /// </summary>
        [DataMember(Name="sellSideDeliveredBy", EmitDefaultValue=false)]
        public string SellSideDeliveredBy { get; set; }

        /// <summary>
        /// Gets or Sets SellSideDeliveryDate
        /// </summary>
        [DataMember(Name="sellSideDeliveryDate", EmitDefaultValue=false)]
        public DateTime? SellSideDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets SellSideExpirationDate
        /// </summary>
        [DataMember(Name="sellSideExpirationDate", EmitDefaultValue=false)]
        public DateTime? SellSideExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets SystemId
        /// </summary>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }

        /// <summary>
        /// Gets or Sets TimeConfirmed
        /// </summary>
        [DataMember(Name="timeConfirmed", EmitDefaultValue=false)]
        public string TimeConfirmed { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedDateUtc
        /// </summary>
        [DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractLockConfirmLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AlertIndicator: ").Append(AlertIndicator).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  BuySideExpirationDate: ").Append(BuySideExpirationDate).Append("\n");
            sb.Append("  CommentList: ").Append(CommentList).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  ConfirmedBy: ").Append(ConfirmedBy).Append("\n");
            sb.Append("  ConfirmedByIdIndicator: ").Append(ConfirmedByIdIndicator).Append("\n");
            sb.Append("  ConfirmedById: ").Append(ConfirmedById).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  FileAttachmentsMigrated: ").Append(FileAttachmentsMigrated).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IsSystemSpecificIndicator: ").Append(IsSystemSpecificIndicator).Append("\n");
            sb.Append("  LogRecordIndex: ").Append(LogRecordIndex).Append("\n");
            sb.Append("  RequestGuid: ").Append(RequestGuid).Append("\n");
            sb.Append("  SellSideDeliveredBy: ").Append(SellSideDeliveredBy).Append("\n");
            sb.Append("  SellSideDeliveryDate: ").Append(SellSideDeliveryDate).Append("\n");
            sb.Append("  SellSideExpirationDate: ").Append(SellSideExpirationDate).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  TimeConfirmed: ").Append(TimeConfirmed).Append("\n");
            sb.Append("  UpdatedDateUtc: ").Append(UpdatedDateUtc).Append("\n");
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
            return this.Equals(input as LoanContractLockConfirmLogs);
        }

        /// <summary>
        /// Returns true if LoanContractLockConfirmLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractLockConfirmLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractLockConfirmLogs input)
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
                    this.AlertIndicator == input.AlertIndicator ||
                    (this.AlertIndicator != null &&
                    this.AlertIndicator.Equals(input.AlertIndicator))
                ) && 
                (
                    this.Alerts == input.Alerts ||
                    this.Alerts != null &&
                    this.Alerts.SequenceEqual(input.Alerts)
                ) && 
                (
                    this.BuySideExpirationDate == input.BuySideExpirationDate ||
                    (this.BuySideExpirationDate != null &&
                    this.BuySideExpirationDate.Equals(input.BuySideExpirationDate))
                ) && 
                (
                    this.CommentList == input.CommentList ||
                    this.CommentList != null &&
                    this.CommentList.SequenceEqual(input.CommentList)
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.ConfirmedBy == input.ConfirmedBy ||
                    (this.ConfirmedBy != null &&
                    this.ConfirmedBy.Equals(input.ConfirmedBy))
                ) && 
                (
                    this.ConfirmedByIdIndicator == input.ConfirmedByIdIndicator ||
                    (this.ConfirmedByIdIndicator != null &&
                    this.ConfirmedByIdIndicator.Equals(input.ConfirmedByIdIndicator))
                ) && 
                (
                    this.ConfirmedById == input.ConfirmedById ||
                    (this.ConfirmedById != null &&
                    this.ConfirmedById.Equals(input.ConfirmedById))
                ) && 
                (
                    this.DateUtc == input.DateUtc ||
                    (this.DateUtc != null &&
                    this.DateUtc.Equals(input.DateUtc))
                ) && 
                (
                    this.FileAttachmentsMigrated == input.FileAttachmentsMigrated ||
                    (this.FileAttachmentsMigrated != null &&
                    this.FileAttachmentsMigrated.Equals(input.FileAttachmentsMigrated))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IsSystemSpecificIndicator == input.IsSystemSpecificIndicator ||
                    (this.IsSystemSpecificIndicator != null &&
                    this.IsSystemSpecificIndicator.Equals(input.IsSystemSpecificIndicator))
                ) && 
                (
                    this.LogRecordIndex == input.LogRecordIndex ||
                    (this.LogRecordIndex != null &&
                    this.LogRecordIndex.Equals(input.LogRecordIndex))
                ) && 
                (
                    this.RequestGuid == input.RequestGuid ||
                    (this.RequestGuid != null &&
                    this.RequestGuid.Equals(input.RequestGuid))
                ) && 
                (
                    this.SellSideDeliveredBy == input.SellSideDeliveredBy ||
                    (this.SellSideDeliveredBy != null &&
                    this.SellSideDeliveredBy.Equals(input.SellSideDeliveredBy))
                ) && 
                (
                    this.SellSideDeliveryDate == input.SellSideDeliveryDate ||
                    (this.SellSideDeliveryDate != null &&
                    this.SellSideDeliveryDate.Equals(input.SellSideDeliveryDate))
                ) && 
                (
                    this.SellSideExpirationDate == input.SellSideExpirationDate ||
                    (this.SellSideExpirationDate != null &&
                    this.SellSideExpirationDate.Equals(input.SellSideExpirationDate))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.TimeConfirmed == input.TimeConfirmed ||
                    (this.TimeConfirmed != null &&
                    this.TimeConfirmed.Equals(input.TimeConfirmed))
                ) && 
                (
                    this.UpdatedDateUtc == input.UpdatedDateUtc ||
                    (this.UpdatedDateUtc != null &&
                    this.UpdatedDateUtc.Equals(input.UpdatedDateUtc))
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
                if (this.AlertIndicator != null)
                    hashCode = hashCode * 59 + this.AlertIndicator.GetHashCode();
                if (this.Alerts != null)
                    hashCode = hashCode * 59 + this.Alerts.GetHashCode();
                if (this.BuySideExpirationDate != null)
                    hashCode = hashCode * 59 + this.BuySideExpirationDate.GetHashCode();
                if (this.CommentList != null)
                    hashCode = hashCode * 59 + this.CommentList.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.ConfirmedBy != null)
                    hashCode = hashCode * 59 + this.ConfirmedBy.GetHashCode();
                if (this.ConfirmedByIdIndicator != null)
                    hashCode = hashCode * 59 + this.ConfirmedByIdIndicator.GetHashCode();
                if (this.ConfirmedById != null)
                    hashCode = hashCode * 59 + this.ConfirmedById.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.FileAttachmentsMigrated != null)
                    hashCode = hashCode * 59 + this.FileAttachmentsMigrated.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IsSystemSpecificIndicator != null)
                    hashCode = hashCode * 59 + this.IsSystemSpecificIndicator.GetHashCode();
                if (this.LogRecordIndex != null)
                    hashCode = hashCode * 59 + this.LogRecordIndex.GetHashCode();
                if (this.RequestGuid != null)
                    hashCode = hashCode * 59 + this.RequestGuid.GetHashCode();
                if (this.SellSideDeliveredBy != null)
                    hashCode = hashCode * 59 + this.SellSideDeliveredBy.GetHashCode();
                if (this.SellSideDeliveryDate != null)
                    hashCode = hashCode * 59 + this.SellSideDeliveryDate.GetHashCode();
                if (this.SellSideExpirationDate != null)
                    hashCode = hashCode * 59 + this.SellSideExpirationDate.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.TimeConfirmed != null)
                    hashCode = hashCode * 59 + this.TimeConfirmed.GetHashCode();
                if (this.UpdatedDateUtc != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUtc.GetHashCode();
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
