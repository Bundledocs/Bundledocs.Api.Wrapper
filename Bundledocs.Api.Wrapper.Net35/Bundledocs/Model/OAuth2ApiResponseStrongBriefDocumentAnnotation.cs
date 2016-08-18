/* 
 * Bundledocs.Web.Api
 *
 * Bundledocs Web Api (v1)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bundledocs.Model
{
    /// <summary>
    /// OAuth2ApiResponseStrongBriefDocumentAnnotation
    /// </summary>
    [DataContract]
    public partial class OAuth2ApiResponseStrongBriefDocumentAnnotation :  IEquatable<OAuth2ApiResponseStrongBriefDocumentAnnotation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ApiResponseStrongBriefDocumentAnnotation" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Errors">Errors.</param>
        /// <param name="Messages">Messages.</param>
        public OAuth2ApiResponseStrongBriefDocumentAnnotation(List<BriefDocumentAnnotation> Data = null, List<OAuthApiMessage> Errors = null, List<OAuthApiMessage> Messages = null)
        {
            this.Data = Data;
            this.Errors = Errors;
            this.Messages = Messages;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<BriefDocumentAnnotation> Data { get; set; }
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<OAuthApiMessage> Errors { get; set; }
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<OAuthApiMessage> Messages { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuth2ApiResponseStrongBriefDocumentAnnotation {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OAuth2ApiResponseStrongBriefDocumentAnnotation);
        }

        /// <summary>
        /// Returns true if OAuth2ApiResponseStrongBriefDocumentAnnotation instances are equal
        /// </summary>
        /// <param name="other">Instance of OAuth2ApiResponseStrongBriefDocumentAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2ApiResponseStrongBriefDocumentAnnotation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                return hash;
            }
        }
    }

}
