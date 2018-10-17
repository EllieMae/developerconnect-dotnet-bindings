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
 * Contacts
 *
 * Represents borrower and business contacts
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
using SwaggerDateConverter = Elli.Api.Contacts.Client.SwaggerDateConverter;

namespace Elli.Api.Contacts.Model
{
    /// <summary>
    /// ContactNoteContract
    /// </summary>
    [DataContract]
    public partial class ContactNoteContract :  IEquatable<ContactNoteContract>, IValidatableObject
    {
    
        
        /// <summary>
        /// Unique identifier of the note assigned to the note when it was created.
        /// </summary>
        /// <value>Unique identifier of the note assigned to the note when it was created.</value>
        [DataMember(Name="noteId", EmitDefaultValue=false)]
        public int? NoteId { get; set; }

        /// <summary>
        /// Subject or title of the note.
        /// </summary>
        /// <value>Subject or title of the note.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Date and time the note was created. For example, 2017-06-23T16:59:52.893Z
        /// </summary>
        /// <value>Date and time the note was created. For example, 2017-06-23T16:59:52.893Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Text for the note.
        /// </summary>
        /// <value>Text for the note.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactNoteContract {\n");
            sb.Append("  NoteId: ").Append(NoteId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as ContactNoteContract);
        }

        /// <summary>
        /// Returns true if ContactNoteContract instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactNoteContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactNoteContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NoteId == input.NoteId ||
                    (this.NoteId != null &&
                    this.NoteId.Equals(input.NoteId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.NoteId != null)
                    hashCode = hashCode * 59 + this.NoteId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
