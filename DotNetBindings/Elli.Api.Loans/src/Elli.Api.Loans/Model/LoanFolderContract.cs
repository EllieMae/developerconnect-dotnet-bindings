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
    /// LoanFolderContract
    /// </summary>
    [DataContract]
    public partial class LoanFolderContract :  IEquatable<LoanFolderContract>, IValidatableObject
    {
    
        
        /// <summary>
        /// Optional field for Moveloanfolder operation
        /// </summary>
        /// <value>Optional field for Moveloanfolder operation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ActivityRules
        /// </summary>
        [DataMember(Name="activityRules", EmitDefaultValue=false)]
        public List<LoanFolderContractActivityRules> ActivityRules { get; set; }

        /// <summary>
        /// optional field for Moveloanfolder operation
        /// </summary>
        /// <value>optional field for Moveloanfolder operation</value>
        [DataMember(Name="folderType", EmitDefaultValue=false)]
        public string FolderType { get; set; }

        /// <summary>
        /// Flag for IsExternalOrganization
        /// </summary>
        /// <value>Flag for IsExternalOrganization</value>
        [DataMember(Name="isExternalOrganization", EmitDefaultValue=false)]
        public bool? IsExternalOrganization { get; set; }

        /// <summary>
        /// Unique identifier of a loan
        /// </summary>
        /// <value>Unique identifier of a loan</value>
        [DataMember(Name="loanGuid", EmitDefaultValue=false)]
        public string LoanGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanFolderContract {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ActivityRules: ").Append(ActivityRules).Append("\n");
            sb.Append("  FolderType: ").Append(FolderType).Append("\n");
            sb.Append("  IsExternalOrganization: ").Append(IsExternalOrganization).Append("\n");
            sb.Append("  LoanGuid: ").Append(LoanGuid).Append("\n");
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
            return this.Equals(input as LoanFolderContract);
        }

        /// <summary>
        /// Returns true if LoanFolderContract instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanFolderContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanFolderContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ActivityRules == input.ActivityRules ||
                    this.ActivityRules != null &&
                    this.ActivityRules.SequenceEqual(input.ActivityRules)
                ) && 
                (
                    this.FolderType == input.FolderType ||
                    (this.FolderType != null &&
                    this.FolderType.Equals(input.FolderType))
                ) && 
                (
                    this.IsExternalOrganization == input.IsExternalOrganization ||
                    (this.IsExternalOrganization != null &&
                    this.IsExternalOrganization.Equals(input.IsExternalOrganization))
                ) && 
                (
                    this.LoanGuid == input.LoanGuid ||
                    (this.LoanGuid != null &&
                    this.LoanGuid.Equals(input.LoanGuid))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ActivityRules != null)
                    hashCode = hashCode * 59 + this.ActivityRules.GetHashCode();
                if (this.FolderType != null)
                    hashCode = hashCode * 59 + this.FolderType.GetHashCode();
                if (this.IsExternalOrganization != null)
                    hashCode = hashCode * 59 + this.IsExternalOrganization.GetHashCode();
                if (this.LoanGuid != null)
                    hashCode = hashCode * 59 + this.LoanGuid.GetHashCode();
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
