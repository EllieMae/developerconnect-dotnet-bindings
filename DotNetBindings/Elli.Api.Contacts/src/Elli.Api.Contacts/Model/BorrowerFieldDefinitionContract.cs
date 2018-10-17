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
    /// BorrowerFieldDefinitionContract
    /// </summary>
    [DataContract]
    public partial class BorrowerFieldDefinitionContract :  IEquatable<BorrowerFieldDefinitionContract>, IValidatableObject
    {
    
        
        /// <summary>
        /// This field is true when corresponding canonical field can be used only for filtering the contact. And is false, when corresponding canonical field can be used only for Selection and Sort
        /// </summary>
        /// <value>This field is true when corresponding canonical field can be used only for filtering the contact. And is false, when corresponding canonical field can be used only for Selection and Sort</value>
        [DataMember(Name="filterOnly", EmitDefaultValue=false)]
        public bool? FilterOnly { get; set; }

        /// <summary>
        /// Category of a field like Borrower Contact, Opportunity, Recent Events, Appointments, Loan, Trade, Milestone, Loan Folder, Pipeline, etc. 
        /// </summary>
        /// <value>Category of a field like Borrower Contact, Opportunity, Recent Events, Appointments, Loan, Trade, Milestone, Loan Folder, Pipeline, etc. </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// This is a detailed explanation what field represents
        /// </summary>
        /// <value>This is a detailed explanation what field represents</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Canonical name of field
        /// </summary>
        /// <value>Canonical name of field</value>
        [DataMember(Name="canonicalName", EmitDefaultValue=false)]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Type of a field like Integer, String, YN(checkbox), Datetime, etc.
        /// </summary>
        /// <value>Type of a field like Integer, String, YN(checkbox), Datetime, etc.</value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// Source of field Loan or BorrowerContact.
        /// </summary>
        /// <value>Source of field Loan or BorrowerContact.</value>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// If dataType is string,represents number of characters allowed
        /// </summary>
        /// <value>If dataType is string,represents number of characters allowed</value>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Represents possible options for field values
        /// </summary>
        /// <value>Represents possible options for field values</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BorrowerFieldDefinitionContract {\n");
            sb.Append("  FilterOnly: ").Append(FilterOnly).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CanonicalName: ").Append(CanonicalName).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as BorrowerFieldDefinitionContract);
        }

        /// <summary>
        /// Returns true if BorrowerFieldDefinitionContract instances are equal
        /// </summary>
        /// <param name="input">Instance of BorrowerFieldDefinitionContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BorrowerFieldDefinitionContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterOnly == input.FilterOnly ||
                    (this.FilterOnly != null &&
                    this.FilterOnly.Equals(input.FilterOnly))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CanonicalName == input.CanonicalName ||
                    (this.CanonicalName != null &&
                    this.CanonicalName.Equals(input.CanonicalName))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.FilterOnly != null)
                    hashCode = hashCode * 59 + this.FilterOnly.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CanonicalName != null)
                    hashCode = hashCode * 59 + this.CanonicalName.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.DataSource != null)
                    hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
