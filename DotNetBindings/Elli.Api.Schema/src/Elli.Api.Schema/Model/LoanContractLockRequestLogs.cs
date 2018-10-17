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
    /// LoanContractLockRequestLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractLockRequestLogs :  IEquatable<LoanContractLockRequestLogs>, IValidatableObject
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
        /// Gets or Sets BuySideExpirationDate
        /// </summary>
        [DataMember(Name="buySideExpirationDate", EmitDefaultValue=false)]
        public DateTime? BuySideExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets BuySideNewLockExtensionDate
        /// </summary>
        [DataMember(Name="buySideNewLockExtensionDate", EmitDefaultValue=false)]
        public DateTime? BuySideNewLockExtensionDate { get; set; }

        /// <summary>
        /// Gets or Sets BuySideNumDayExtended
        /// </summary>
        [DataMember(Name="buySideNumDayExtended", EmitDefaultValue=false)]
        public int? BuySideNumDayExtended { get; set; }

        /// <summary>
        /// Gets or Sets ReLockSequenceNumberForInactiveLock
        /// </summary>
        [DataMember(Name="reLockSequenceNumberForInactiveLock", EmitDefaultValue=false)]
        public int? ReLockSequenceNumberForInactiveLock { get; set; }

        /// <summary>
        /// Gets or Sets BuySideNumDayLocked
        /// </summary>
        [DataMember(Name="buySideNumDayLocked", EmitDefaultValue=false)]
        public int? BuySideNumDayLocked { get; set; }

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
        /// Gets or Sets CumulatedDaystoExtend
        /// </summary>
        [DataMember(Name="cumulatedDaystoExtend", EmitDefaultValue=false)]
        public int? CumulatedDaystoExtend { get; set; }

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
        /// Gets or Sets HideLogIndicator
        /// </summary>
        [DataMember(Name="hideLogIndicator", EmitDefaultValue=false)]
        public bool? HideLogIndicator { get; set; }

        /// <summary>
        /// Gets or Sets InvestorName
        /// </summary>
        [DataMember(Name="investorName", EmitDefaultValue=false)]
        public string InvestorName { get; set; }

        /// <summary>
        /// Gets or Sets IsFakeRequestIndicator
        /// </summary>
        [DataMember(Name="isFakeRequestIndicator", EmitDefaultValue=false)]
        public bool? IsFakeRequestIndicator { get; set; }

        /// <summary>
        /// Gets or Sets IsLockCancellationIndicator
        /// </summary>
        [DataMember(Name="isLockCancellationIndicator", EmitDefaultValue=false)]
        public bool? IsLockCancellationIndicator { get; set; }

        /// <summary>
        /// Gets or Sets IsLockExtensionIndicator
        /// </summary>
        [DataMember(Name="isLockExtensionIndicator", EmitDefaultValue=false)]
        public bool? IsLockExtensionIndicator { get; set; }

        /// <summary>
        /// Gets or Sets IsReLockIndicator
        /// </summary>
        [DataMember(Name="isReLockIndicator", EmitDefaultValue=false)]
        public bool? IsReLockIndicator { get; set; }

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
        /// Gets or Sets NumDayLocked
        /// </summary>
        [DataMember(Name="numDayLocked", EmitDefaultValue=false)]
        public int? NumDayLocked { get; set; }

        /// <summary>
        /// Gets or Sets ParentLockGuid
        /// </summary>
        [DataMember(Name="parentLockGuid", EmitDefaultValue=false)]
        public string ParentLockGuid { get; set; }

        /// <summary>
        /// Gets or Sets RateLockAction
        /// </summary>
        [DataMember(Name="rateLockAction", EmitDefaultValue=false)]
        public string RateLockAction { get; set; }

        /// <summary>
        /// Gets or Sets RequestedBy
        /// </summary>
        [DataMember(Name="requestedBy", EmitDefaultValue=false)]
        public string RequestedBy { get; set; }

        /// <summary>
        /// Gets or Sets RequestedName
        /// </summary>
        [DataMember(Name="requestedName", EmitDefaultValue=false)]
        public string RequestedName { get; set; }

        /// <summary>
        /// Gets or Sets RequestedStatus
        /// </summary>
        [DataMember(Name="requestedStatus", EmitDefaultValue=false)]
        public string RequestedStatus { get; set; }

        /// <summary>
        /// Gets or Sets ReviseAction
        /// </summary>
        [DataMember(Name="reviseAction", EmitDefaultValue=false)]
        public string ReviseAction { get; set; }

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
        /// Gets or Sets SellSideNewLockExtensionDate
        /// </summary>
        [DataMember(Name="sellSideNewLockExtensionDate", EmitDefaultValue=false)]
        public DateTime? SellSideNewLockExtensionDate { get; set; }

        /// <summary>
        /// Gets or Sets SellSideNumDayExtended
        /// </summary>
        [DataMember(Name="sellSideNumDayExtended", EmitDefaultValue=false)]
        public int? SellSideNumDayExtended { get; set; }

        /// <summary>
        /// Gets or Sets SystemId
        /// </summary>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }

        /// <summary>
        /// Gets or Sets TimeRequested
        /// </summary>
        [DataMember(Name="timeRequested", EmitDefaultValue=false)]
        public string TimeRequested { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedDateUtc
        /// </summary>
        [DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUtc { get; set; }

        /// <summary>
        /// Gets or Sets InvestorCommitment
        /// </summary>
        [DataMember(Name="investorCommitment", EmitDefaultValue=false)]
        public string InvestorCommitment { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotXml
        /// </summary>
        [DataMember(Name="snapshotXml", EmitDefaultValue=false)]
        public string SnapshotXml { get; set; }

        /// <summary>
        /// Gets or Sets AlertsXml
        /// </summary>
        [DataMember(Name="alertsXml", EmitDefaultValue=false)]
        public string AlertsXml { get; set; }

        /// <summary>
        /// Gets or Sets CommentListXml
        /// </summary>
        [DataMember(Name="commentListXml", EmitDefaultValue=false)]
        public string CommentListXml { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractLockRequestLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  BuySideExpirationDate: ").Append(BuySideExpirationDate).Append("\n");
            sb.Append("  BuySideNewLockExtensionDate: ").Append(BuySideNewLockExtensionDate).Append("\n");
            sb.Append("  BuySideNumDayExtended: ").Append(BuySideNumDayExtended).Append("\n");
            sb.Append("  ReLockSequenceNumberForInactiveLock: ").Append(ReLockSequenceNumberForInactiveLock).Append("\n");
            sb.Append("  BuySideNumDayLocked: ").Append(BuySideNumDayLocked).Append("\n");
            sb.Append("  CommentList: ").Append(CommentList).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CumulatedDaystoExtend: ").Append(CumulatedDaystoExtend).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  FileAttachmentsMigrated: ").Append(FileAttachmentsMigrated).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  HideLogIndicator: ").Append(HideLogIndicator).Append("\n");
            sb.Append("  InvestorName: ").Append(InvestorName).Append("\n");
            sb.Append("  IsFakeRequestIndicator: ").Append(IsFakeRequestIndicator).Append("\n");
            sb.Append("  IsLockCancellationIndicator: ").Append(IsLockCancellationIndicator).Append("\n");
            sb.Append("  IsLockExtensionIndicator: ").Append(IsLockExtensionIndicator).Append("\n");
            sb.Append("  IsReLockIndicator: ").Append(IsReLockIndicator).Append("\n");
            sb.Append("  IsSystemSpecificIndicator: ").Append(IsSystemSpecificIndicator).Append("\n");
            sb.Append("  LogRecordIndex: ").Append(LogRecordIndex).Append("\n");
            sb.Append("  NumDayLocked: ").Append(NumDayLocked).Append("\n");
            sb.Append("  ParentLockGuid: ").Append(ParentLockGuid).Append("\n");
            sb.Append("  RateLockAction: ").Append(RateLockAction).Append("\n");
            sb.Append("  RequestedBy: ").Append(RequestedBy).Append("\n");
            sb.Append("  RequestedName: ").Append(RequestedName).Append("\n");
            sb.Append("  RequestedStatus: ").Append(RequestedStatus).Append("\n");
            sb.Append("  ReviseAction: ").Append(ReviseAction).Append("\n");
            sb.Append("  SellSideDeliveredBy: ").Append(SellSideDeliveredBy).Append("\n");
            sb.Append("  SellSideDeliveryDate: ").Append(SellSideDeliveryDate).Append("\n");
            sb.Append("  SellSideExpirationDate: ").Append(SellSideExpirationDate).Append("\n");
            sb.Append("  SellSideNewLockExtensionDate: ").Append(SellSideNewLockExtensionDate).Append("\n");
            sb.Append("  SellSideNumDayExtended: ").Append(SellSideNumDayExtended).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  TimeRequested: ").Append(TimeRequested).Append("\n");
            sb.Append("  UpdatedDateUtc: ").Append(UpdatedDateUtc).Append("\n");
            sb.Append("  InvestorCommitment: ").Append(InvestorCommitment).Append("\n");
            sb.Append("  SnapshotXml: ").Append(SnapshotXml).Append("\n");
            sb.Append("  AlertsXml: ").Append(AlertsXml).Append("\n");
            sb.Append("  CommentListXml: ").Append(CommentListXml).Append("\n");
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
            return this.Equals(input as LoanContractLockRequestLogs);
        }

        /// <summary>
        /// Returns true if LoanContractLockRequestLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractLockRequestLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractLockRequestLogs input)
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
                    this.BuySideExpirationDate == input.BuySideExpirationDate ||
                    (this.BuySideExpirationDate != null &&
                    this.BuySideExpirationDate.Equals(input.BuySideExpirationDate))
                ) && 
                (
                    this.BuySideNewLockExtensionDate == input.BuySideNewLockExtensionDate ||
                    (this.BuySideNewLockExtensionDate != null &&
                    this.BuySideNewLockExtensionDate.Equals(input.BuySideNewLockExtensionDate))
                ) && 
                (
                    this.BuySideNumDayExtended == input.BuySideNumDayExtended ||
                    (this.BuySideNumDayExtended != null &&
                    this.BuySideNumDayExtended.Equals(input.BuySideNumDayExtended))
                ) && 
                (
                    this.ReLockSequenceNumberForInactiveLock == input.ReLockSequenceNumberForInactiveLock ||
                    (this.ReLockSequenceNumberForInactiveLock != null &&
                    this.ReLockSequenceNumberForInactiveLock.Equals(input.ReLockSequenceNumberForInactiveLock))
                ) && 
                (
                    this.BuySideNumDayLocked == input.BuySideNumDayLocked ||
                    (this.BuySideNumDayLocked != null &&
                    this.BuySideNumDayLocked.Equals(input.BuySideNumDayLocked))
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
                    this.CumulatedDaystoExtend == input.CumulatedDaystoExtend ||
                    (this.CumulatedDaystoExtend != null &&
                    this.CumulatedDaystoExtend.Equals(input.CumulatedDaystoExtend))
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
                    this.HideLogIndicator == input.HideLogIndicator ||
                    (this.HideLogIndicator != null &&
                    this.HideLogIndicator.Equals(input.HideLogIndicator))
                ) && 
                (
                    this.InvestorName == input.InvestorName ||
                    (this.InvestorName != null &&
                    this.InvestorName.Equals(input.InvestorName))
                ) && 
                (
                    this.IsFakeRequestIndicator == input.IsFakeRequestIndicator ||
                    (this.IsFakeRequestIndicator != null &&
                    this.IsFakeRequestIndicator.Equals(input.IsFakeRequestIndicator))
                ) && 
                (
                    this.IsLockCancellationIndicator == input.IsLockCancellationIndicator ||
                    (this.IsLockCancellationIndicator != null &&
                    this.IsLockCancellationIndicator.Equals(input.IsLockCancellationIndicator))
                ) && 
                (
                    this.IsLockExtensionIndicator == input.IsLockExtensionIndicator ||
                    (this.IsLockExtensionIndicator != null &&
                    this.IsLockExtensionIndicator.Equals(input.IsLockExtensionIndicator))
                ) && 
                (
                    this.IsReLockIndicator == input.IsReLockIndicator ||
                    (this.IsReLockIndicator != null &&
                    this.IsReLockIndicator.Equals(input.IsReLockIndicator))
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
                    this.NumDayLocked == input.NumDayLocked ||
                    (this.NumDayLocked != null &&
                    this.NumDayLocked.Equals(input.NumDayLocked))
                ) && 
                (
                    this.ParentLockGuid == input.ParentLockGuid ||
                    (this.ParentLockGuid != null &&
                    this.ParentLockGuid.Equals(input.ParentLockGuid))
                ) && 
                (
                    this.RateLockAction == input.RateLockAction ||
                    (this.RateLockAction != null &&
                    this.RateLockAction.Equals(input.RateLockAction))
                ) && 
                (
                    this.RequestedBy == input.RequestedBy ||
                    (this.RequestedBy != null &&
                    this.RequestedBy.Equals(input.RequestedBy))
                ) && 
                (
                    this.RequestedName == input.RequestedName ||
                    (this.RequestedName != null &&
                    this.RequestedName.Equals(input.RequestedName))
                ) && 
                (
                    this.RequestedStatus == input.RequestedStatus ||
                    (this.RequestedStatus != null &&
                    this.RequestedStatus.Equals(input.RequestedStatus))
                ) && 
                (
                    this.ReviseAction == input.ReviseAction ||
                    (this.ReviseAction != null &&
                    this.ReviseAction.Equals(input.ReviseAction))
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
                    this.SellSideNewLockExtensionDate == input.SellSideNewLockExtensionDate ||
                    (this.SellSideNewLockExtensionDate != null &&
                    this.SellSideNewLockExtensionDate.Equals(input.SellSideNewLockExtensionDate))
                ) && 
                (
                    this.SellSideNumDayExtended == input.SellSideNumDayExtended ||
                    (this.SellSideNumDayExtended != null &&
                    this.SellSideNumDayExtended.Equals(input.SellSideNumDayExtended))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.TimeRequested == input.TimeRequested ||
                    (this.TimeRequested != null &&
                    this.TimeRequested.Equals(input.TimeRequested))
                ) && 
                (
                    this.UpdatedDateUtc == input.UpdatedDateUtc ||
                    (this.UpdatedDateUtc != null &&
                    this.UpdatedDateUtc.Equals(input.UpdatedDateUtc))
                ) && 
                (
                    this.InvestorCommitment == input.InvestorCommitment ||
                    (this.InvestorCommitment != null &&
                    this.InvestorCommitment.Equals(input.InvestorCommitment))
                ) && 
                (
                    this.SnapshotXml == input.SnapshotXml ||
                    (this.SnapshotXml != null &&
                    this.SnapshotXml.Equals(input.SnapshotXml))
                ) && 
                (
                    this.AlertsXml == input.AlertsXml ||
                    (this.AlertsXml != null &&
                    this.AlertsXml.Equals(input.AlertsXml))
                ) && 
                (
                    this.CommentListXml == input.CommentListXml ||
                    (this.CommentListXml != null &&
                    this.CommentListXml.Equals(input.CommentListXml))
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
                if (this.BuySideExpirationDate != null)
                    hashCode = hashCode * 59 + this.BuySideExpirationDate.GetHashCode();
                if (this.BuySideNewLockExtensionDate != null)
                    hashCode = hashCode * 59 + this.BuySideNewLockExtensionDate.GetHashCode();
                if (this.BuySideNumDayExtended != null)
                    hashCode = hashCode * 59 + this.BuySideNumDayExtended.GetHashCode();
                if (this.ReLockSequenceNumberForInactiveLock != null)
                    hashCode = hashCode * 59 + this.ReLockSequenceNumberForInactiveLock.GetHashCode();
                if (this.BuySideNumDayLocked != null)
                    hashCode = hashCode * 59 + this.BuySideNumDayLocked.GetHashCode();
                if (this.CommentList != null)
                    hashCode = hashCode * 59 + this.CommentList.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CumulatedDaystoExtend != null)
                    hashCode = hashCode * 59 + this.CumulatedDaystoExtend.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.FileAttachmentsMigrated != null)
                    hashCode = hashCode * 59 + this.FileAttachmentsMigrated.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.HideLogIndicator != null)
                    hashCode = hashCode * 59 + this.HideLogIndicator.GetHashCode();
                if (this.InvestorName != null)
                    hashCode = hashCode * 59 + this.InvestorName.GetHashCode();
                if (this.IsFakeRequestIndicator != null)
                    hashCode = hashCode * 59 + this.IsFakeRequestIndicator.GetHashCode();
                if (this.IsLockCancellationIndicator != null)
                    hashCode = hashCode * 59 + this.IsLockCancellationIndicator.GetHashCode();
                if (this.IsLockExtensionIndicator != null)
                    hashCode = hashCode * 59 + this.IsLockExtensionIndicator.GetHashCode();
                if (this.IsReLockIndicator != null)
                    hashCode = hashCode * 59 + this.IsReLockIndicator.GetHashCode();
                if (this.IsSystemSpecificIndicator != null)
                    hashCode = hashCode * 59 + this.IsSystemSpecificIndicator.GetHashCode();
                if (this.LogRecordIndex != null)
                    hashCode = hashCode * 59 + this.LogRecordIndex.GetHashCode();
                if (this.NumDayLocked != null)
                    hashCode = hashCode * 59 + this.NumDayLocked.GetHashCode();
                if (this.ParentLockGuid != null)
                    hashCode = hashCode * 59 + this.ParentLockGuid.GetHashCode();
                if (this.RateLockAction != null)
                    hashCode = hashCode * 59 + this.RateLockAction.GetHashCode();
                if (this.RequestedBy != null)
                    hashCode = hashCode * 59 + this.RequestedBy.GetHashCode();
                if (this.RequestedName != null)
                    hashCode = hashCode * 59 + this.RequestedName.GetHashCode();
                if (this.RequestedStatus != null)
                    hashCode = hashCode * 59 + this.RequestedStatus.GetHashCode();
                if (this.ReviseAction != null)
                    hashCode = hashCode * 59 + this.ReviseAction.GetHashCode();
                if (this.SellSideDeliveredBy != null)
                    hashCode = hashCode * 59 + this.SellSideDeliveredBy.GetHashCode();
                if (this.SellSideDeliveryDate != null)
                    hashCode = hashCode * 59 + this.SellSideDeliveryDate.GetHashCode();
                if (this.SellSideExpirationDate != null)
                    hashCode = hashCode * 59 + this.SellSideExpirationDate.GetHashCode();
                if (this.SellSideNewLockExtensionDate != null)
                    hashCode = hashCode * 59 + this.SellSideNewLockExtensionDate.GetHashCode();
                if (this.SellSideNumDayExtended != null)
                    hashCode = hashCode * 59 + this.SellSideNumDayExtended.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.TimeRequested != null)
                    hashCode = hashCode * 59 + this.TimeRequested.GetHashCode();
                if (this.UpdatedDateUtc != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUtc.GetHashCode();
                if (this.InvestorCommitment != null)
                    hashCode = hashCode * 59 + this.InvestorCommitment.GetHashCode();
                if (this.SnapshotXml != null)
                    hashCode = hashCode * 59 + this.SnapshotXml.GetHashCode();
                if (this.AlertsXml != null)
                    hashCode = hashCode * 59 + this.AlertsXml.GetHashCode();
                if (this.CommentListXml != null)
                    hashCode = hashCode * 59 + this.CommentListXml.GetHashCode();
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
