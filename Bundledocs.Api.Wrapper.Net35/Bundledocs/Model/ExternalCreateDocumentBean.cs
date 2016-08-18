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
    /// ExternalCreateDocumentBean
    /// </summary>
    [DataContract]
    public partial class ExternalCreateDocumentBean :  IEquatable<ExternalCreateDocumentBean>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalCreateDocumentBean" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Url">Url.</param>
        /// <param name="FileUploadKey">FileUploadKey.</param>
        /// <param name="SourceDomain">SourceDomain.</param>
        /// <param name="DocordoNodeId">DocordoNodeId.</param>
        /// <param name="DocordoFileName">DocordoFileName.</param>
        /// <param name="GoogleOAuthToken">GoogleOAuthToken.</param>
        /// <param name="NetDocumentsId">NetDocumentsId.</param>
        public ExternalCreateDocumentBean(string Name = null, string Url = null, string FileUploadKey = null, string SourceDomain = null, string DocordoNodeId = null, string DocordoFileName = null, string GoogleOAuthToken = null, string NetDocumentsId = null)
        {
            this.Name = Name;
            this.Url = Url;
            this.FileUploadKey = FileUploadKey;
            this.SourceDomain = SourceDomain;
            this.DocordoNodeId = DocordoNodeId;
            this.DocordoFileName = DocordoFileName;
            this.GoogleOAuthToken = GoogleOAuthToken;
            this.NetDocumentsId = NetDocumentsId;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or Sets FileUploadKey
        /// </summary>
        [DataMember(Name="FileUploadKey", EmitDefaultValue=false)]
        public string FileUploadKey { get; set; }
        /// <summary>
        /// Gets or Sets SourceDomain
        /// </summary>
        [DataMember(Name="SourceDomain", EmitDefaultValue=false)]
        public string SourceDomain { get; set; }
        /// <summary>
        /// Gets or Sets DocordoNodeId
        /// </summary>
        [DataMember(Name="DocordoNodeId", EmitDefaultValue=false)]
        public string DocordoNodeId { get; set; }
        /// <summary>
        /// Gets or Sets DocordoFileName
        /// </summary>
        [DataMember(Name="DocordoFileName", EmitDefaultValue=false)]
        public string DocordoFileName { get; set; }
        /// <summary>
        /// Gets or Sets GoogleOAuthToken
        /// </summary>
        [DataMember(Name="GoogleOAuthToken", EmitDefaultValue=false)]
        public string GoogleOAuthToken { get; set; }
        /// <summary>
        /// Gets or Sets NetDocumentsId
        /// </summary>
        [DataMember(Name="NetDocumentsId", EmitDefaultValue=false)]
        public string NetDocumentsId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalCreateDocumentBean {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FileUploadKey: ").Append(FileUploadKey).Append("\n");
            sb.Append("  SourceDomain: ").Append(SourceDomain).Append("\n");
            sb.Append("  DocordoNodeId: ").Append(DocordoNodeId).Append("\n");
            sb.Append("  DocordoFileName: ").Append(DocordoFileName).Append("\n");
            sb.Append("  GoogleOAuthToken: ").Append(GoogleOAuthToken).Append("\n");
            sb.Append("  NetDocumentsId: ").Append(NetDocumentsId).Append("\n");
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
            return this.Equals(obj as ExternalCreateDocumentBean);
        }

        /// <summary>
        /// Returns true if ExternalCreateDocumentBean instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalCreateDocumentBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalCreateDocumentBean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.FileUploadKey == other.FileUploadKey ||
                    this.FileUploadKey != null &&
                    this.FileUploadKey.Equals(other.FileUploadKey)
                ) && 
                (
                    this.SourceDomain == other.SourceDomain ||
                    this.SourceDomain != null &&
                    this.SourceDomain.Equals(other.SourceDomain)
                ) && 
                (
                    this.DocordoNodeId == other.DocordoNodeId ||
                    this.DocordoNodeId != null &&
                    this.DocordoNodeId.Equals(other.DocordoNodeId)
                ) && 
                (
                    this.DocordoFileName == other.DocordoFileName ||
                    this.DocordoFileName != null &&
                    this.DocordoFileName.Equals(other.DocordoFileName)
                ) && 
                (
                    this.GoogleOAuthToken == other.GoogleOAuthToken ||
                    this.GoogleOAuthToken != null &&
                    this.GoogleOAuthToken.Equals(other.GoogleOAuthToken)
                ) && 
                (
                    this.NetDocumentsId == other.NetDocumentsId ||
                    this.NetDocumentsId != null &&
                    this.NetDocumentsId.Equals(other.NetDocumentsId)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.FileUploadKey != null)
                    hash = hash * 59 + this.FileUploadKey.GetHashCode();
                if (this.SourceDomain != null)
                    hash = hash * 59 + this.SourceDomain.GetHashCode();
                if (this.DocordoNodeId != null)
                    hash = hash * 59 + this.DocordoNodeId.GetHashCode();
                if (this.DocordoFileName != null)
                    hash = hash * 59 + this.DocordoFileName.GetHashCode();
                if (this.GoogleOAuthToken != null)
                    hash = hash * 59 + this.GoogleOAuthToken.GetHashCode();
                if (this.NetDocumentsId != null)
                    hash = hash * 59 + this.NetDocumentsId.GetHashCode();
                return hash;
            }
        }
    }

}