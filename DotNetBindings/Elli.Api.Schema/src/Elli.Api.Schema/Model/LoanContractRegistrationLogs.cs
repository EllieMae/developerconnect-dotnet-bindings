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
    /// LoanContractRegistrationLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractRegistrationLogs :  IEquatable<LoanContractRegistrationLogs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name="alerts", EmitDefaultValue=false)]
        public List<LoanContractAlerts> Alerts { get; set; }

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
        /// Gets or Sets CurrentIndicator
        /// </summary>
        [DataMember(Name="currentIndicator", EmitDefaultValue=false)]
        public bool? CurrentIndicator { get; set; }

        /// <summary>
        /// Gets or Sets DateUtc
        /// </summary>
        [DataMember(Name="dateUtc", EmitDefaultValue=false)]
        public DateTime? DateUtc { get; set; }

        /// <summary>
        /// Gets or Sets ExpiredDate
        /// </summary>
        [DataMember(Name="expiredDate", EmitDefaultValue=false)]
        public DateTime? ExpiredDate { get; set; }

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
        /// Gets or Sets InvestorName
        /// </summary>
        [DataMember(Name="investorName", EmitDefaultValue=false)]
        public string InvestorName { get; set; }

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
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredById
        /// </summary>
        [DataMember(Name="registeredById", EmitDefaultValue=false)]
        public string RegisteredById { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredByName
        /// </summary>
        [DataMember(Name="registeredByName", EmitDefaultValue=false)]
        public string RegisteredByName { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredDate
        /// </summary>
        [DataMember(Name="registeredDate", EmitDefaultValue=false)]
        public DateTime? RegisteredDate { get; set; }

        /// <summary>
        /// Gets or Sets SystemId
        /// </summary>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }

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
            sb.Append("class LoanContractRegistrationLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  CommentList: ").Append(CommentList).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CurrentIndicator: ").Append(CurrentIndicator).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  ExpiredDate: ").Append(ExpiredDate).Append("\n");
            sb.Append("  FileAttachmentsMigrated: ").Append(FileAttachmentsMigrated).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  InvestorName: ").Append(InvestorName).Append("\n");
            sb.Append("  IsSystemSpecificIndicator: ").Append(IsSystemSpecificIndicator).Append("\n");
            sb.Append("  LogRecordIndex: ").Append(LogRecordIndex).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RegisteredById: ").Append(RegisteredById).Append("\n");
            sb.Append("  RegisteredByName: ").Append(RegisteredByName).Append("\n");
            sb.Append("  RegisteredDate: ").Append(RegisteredDate).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
            return this.Equals(input as LoanContractRegistrationLogs);
        }

        /// <summary>
        /// Returns true if LoanContractRegistrationLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractRegistrationLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractRegistrationLogs input)
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
                    this.Alerts == input.Alerts ||
                    this.Alerts != null &&
                    this.Alerts.SequenceEqual(input.Alerts)
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
                    this.CurrentIndicator == input.CurrentIndicator ||
                    (this.CurrentIndicator != null &&
                    this.CurrentIndicator.Equals(input.CurrentIndicator))
                ) && 
                (
                    this.DateUtc == input.DateUtc ||
                    (this.DateUtc != null &&
                    this.DateUtc.Equals(input.DateUtc))
                ) && 
                (
                    this.ExpiredDate == input.ExpiredDate ||
                    (this.ExpiredDate != null &&
                    this.ExpiredDate.Equals(input.ExpiredDate))
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
                    this.InvestorName == input.InvestorName ||
                    (this.InvestorName != null &&
                    this.InvestorName.Equals(input.InvestorName))
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
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.RegisteredById == input.RegisteredById ||
                    (this.RegisteredById != null &&
                    this.RegisteredById.Equals(input.RegisteredById))
                ) && 
                (
                    this.RegisteredByName == input.RegisteredByName ||
                    (this.RegisteredByName != null &&
                    this.RegisteredByName.Equals(input.RegisteredByName))
                ) && 
                (
                    this.RegisteredDate == input.RegisteredDate ||
                    (this.RegisteredDate != null &&
                    this.RegisteredDate.Equals(input.RegisteredDate))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
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
                if (this.Alerts != null)
                    hashCode = hashCode * 59 + this.Alerts.GetHashCode();
                if (this.CommentList != null)
                    hashCode = hashCode * 59 + this.CommentList.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CurrentIndicator != null)
                    hashCode = hashCode * 59 + this.CurrentIndicator.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.ExpiredDate != null)
                    hashCode = hashCode * 59 + this.ExpiredDate.GetHashCode();
                if (this.FileAttachmentsMigrated != null)
                    hashCode = hashCode * 59 + this.FileAttachmentsMigrated.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.InvestorName != null)
                    hashCode = hashCode * 59 + this.InvestorName.GetHashCode();
                if (this.IsSystemSpecificIndicator != null)
                    hashCode = hashCode * 59 + this.IsSystemSpecificIndicator.GetHashCode();
                if (this.LogRecordIndex != null)
                    hashCode = hashCode * 59 + this.LogRecordIndex.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.RegisteredById != null)
                    hashCode = hashCode * 59 + this.RegisteredById.GetHashCode();
                if (this.RegisteredByName != null)
                    hashCode = hashCode * 59 + this.RegisteredByName.GetHashCode();
                if (this.RegisteredDate != null)
                    hashCode = hashCode * 59 + this.RegisteredDate.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
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
