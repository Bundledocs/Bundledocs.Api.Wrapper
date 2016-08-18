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
    /// BriefDocumentAnnotation
    /// </summary>
    [DataContract]
    public partial class BriefDocumentAnnotation :  IEquatable<BriefDocumentAnnotation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BriefDocumentAnnotation" /> class.
        /// </summary>
        /// <param name="AnnotationType">AnnotationType.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Content">Content.</param>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ForeignKey">ForeignKey.</param>
        /// <param name="Created">Created.</param>
        /// <param name="LastAccessedTimeStamp">LastAccessedTimeStamp.</param>
        /// <param name="PartitionKey">PartitionKey.</param>
        /// <param name="RowKey">RowKey.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="ETag">ETag.</param>
        public BriefDocumentAnnotation(int? AnnotationType = null, string Title = null, string Content = null, int? ContentType = null, string CreatedBy = null, string ForeignKey = null, DateTime? Created = null, DateTime? LastAccessedTimeStamp = null, string PartitionKey = null, string RowKey = null, DateTime? Timestamp = null, string ETag = null)
        {
            this.AnnotationType = AnnotationType;
            this.Title = Title;
            this.Content = Content;
            this.ContentType = ContentType;
            this.CreatedBy = CreatedBy;
            this.ForeignKey = ForeignKey;
            this.Created = Created;
            this.LastAccessedTimeStamp = LastAccessedTimeStamp;
            this.PartitionKey = PartitionKey;
            this.RowKey = RowKey;
            this.Timestamp = Timestamp;
            this.ETag = ETag;
        }
        
        /// <summary>
        /// Gets or Sets AnnotationType
        /// </summary>
        [DataMember(Name="AnnotationType", EmitDefaultValue=false)]
        public int? AnnotationType { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public string Content { get; set; }
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="ContentType", EmitDefaultValue=false)]
        public int? ContentType { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets ForeignKey
        /// </summary>
        [DataMember(Name="ForeignKey", EmitDefaultValue=false)]
        public string ForeignKey { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="Created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets LastAccessedTimeStamp
        /// </summary>
        [DataMember(Name="LastAccessedTimeStamp", EmitDefaultValue=false)]
        public DateTime? LastAccessedTimeStamp { get; set; }
        /// <summary>
        /// Gets or Sets PartitionKey
        /// </summary>
        [DataMember(Name="PartitionKey", EmitDefaultValue=false)]
        public string PartitionKey { get; set; }
        /// <summary>
        /// Gets or Sets RowKey
        /// </summary>
        [DataMember(Name="RowKey", EmitDefaultValue=false)]
        public string RowKey { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets ETag
        /// </summary>
        [DataMember(Name="ETag", EmitDefaultValue=false)]
        public string ETag { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BriefDocumentAnnotation {\n");
            sb.Append("  AnnotationType: ").Append(AnnotationType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ForeignKey: ").Append(ForeignKey).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastAccessedTimeStamp: ").Append(LastAccessedTimeStamp).Append("\n");
            sb.Append("  PartitionKey: ").Append(PartitionKey).Append("\n");
            sb.Append("  RowKey: ").Append(RowKey).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ETag: ").Append(ETag).Append("\n");
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
            return this.Equals(obj as BriefDocumentAnnotation);
        }

        /// <summary>
        /// Returns true if BriefDocumentAnnotation instances are equal
        /// </summary>
        /// <param name="other">Instance of BriefDocumentAnnotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BriefDocumentAnnotation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnnotationType == other.AnnotationType ||
                    this.AnnotationType != null &&
                    this.AnnotationType.Equals(other.AnnotationType)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.ForeignKey == other.ForeignKey ||
                    this.ForeignKey != null &&
                    this.ForeignKey.Equals(other.ForeignKey)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.LastAccessedTimeStamp == other.LastAccessedTimeStamp ||
                    this.LastAccessedTimeStamp != null &&
                    this.LastAccessedTimeStamp.Equals(other.LastAccessedTimeStamp)
                ) && 
                (
                    this.PartitionKey == other.PartitionKey ||
                    this.PartitionKey != null &&
                    this.PartitionKey.Equals(other.PartitionKey)
                ) && 
                (
                    this.RowKey == other.RowKey ||
                    this.RowKey != null &&
                    this.RowKey.Equals(other.RowKey)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.ETag == other.ETag ||
                    this.ETag != null &&
                    this.ETag.Equals(other.ETag)
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
                if (this.AnnotationType != null)
                    hash = hash * 59 + this.AnnotationType.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.ForeignKey != null)
                    hash = hash * 59 + this.ForeignKey.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.LastAccessedTimeStamp != null)
                    hash = hash * 59 + this.LastAccessedTimeStamp.GetHashCode();
                if (this.PartitionKey != null)
                    hash = hash * 59 + this.PartitionKey.GetHashCode();
                if (this.RowKey != null)
                    hash = hash * 59 + this.RowKey.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.ETag != null)
                    hash = hash * 59 + this.ETag.GetHashCode();
                return hash;
            }
        }
    }

}
