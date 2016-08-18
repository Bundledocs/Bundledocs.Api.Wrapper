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
    /// UserGroupMemberBean
    /// </summary>
    [DataContract]
    public partial class UserGroupMemberBean :  IEquatable<UserGroupMemberBean>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupMemberBean" /> class.
        /// </summary>
        /// <param name="UserGroupPartitionKey">UserGroupPartitionKey.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Role">Role.</param>
        /// <param name="BriefsShared">BriefsShared.</param>
        /// <param name="BriefsCount">BriefsCount.</param>
        /// <param name="ForeignKey">ForeignKey.</param>
        /// <param name="Created">Created.</param>
        /// <param name="LastAccessedTimeStamp">LastAccessedTimeStamp.</param>
        /// <param name="PartitionKey">PartitionKey.</param>
        /// <param name="RowKey">RowKey.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="ETag">ETag.</param>
        public UserGroupMemberBean(string UserGroupPartitionKey = null, string Email = null, string Role = null, List<BriefBean> BriefsShared = null, int? BriefsCount = null, string ForeignKey = null, DateTime? Created = null, DateTime? LastAccessedTimeStamp = null, string PartitionKey = null, string RowKey = null, DateTime? Timestamp = null, string ETag = null)
        {
            this.UserGroupPartitionKey = UserGroupPartitionKey;
            this.Email = Email;
            this.Role = Role;
            this.BriefsShared = BriefsShared;
            this.BriefsCount = BriefsCount;
            this.ForeignKey = ForeignKey;
            this.Created = Created;
            this.LastAccessedTimeStamp = LastAccessedTimeStamp;
            this.PartitionKey = PartitionKey;
            this.RowKey = RowKey;
            this.Timestamp = Timestamp;
            this.ETag = ETag;
        }
        
        /// <summary>
        /// Gets or Sets UserGroupPartitionKey
        /// </summary>
        [DataMember(Name="UserGroupPartitionKey", EmitDefaultValue=false)]
        public string UserGroupPartitionKey { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="Role", EmitDefaultValue=false)]
        public string Role { get; set; }
        /// <summary>
        /// Gets or Sets BriefsShared
        /// </summary>
        [DataMember(Name="BriefsShared", EmitDefaultValue=false)]
        public List<BriefBean> BriefsShared { get; set; }
        /// <summary>
        /// Gets or Sets BriefsCount
        /// </summary>
        [DataMember(Name="BriefsCount", EmitDefaultValue=false)]
        public int? BriefsCount { get; set; }
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
            sb.Append("class UserGroupMemberBean {\n");
            sb.Append("  UserGroupPartitionKey: ").Append(UserGroupPartitionKey).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  BriefsShared: ").Append(BriefsShared).Append("\n");
            sb.Append("  BriefsCount: ").Append(BriefsCount).Append("\n");
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
            return this.Equals(obj as UserGroupMemberBean);
        }

        /// <summary>
        /// Returns true if UserGroupMemberBean instances are equal
        /// </summary>
        /// <param name="other">Instance of UserGroupMemberBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserGroupMemberBean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserGroupPartitionKey == other.UserGroupPartitionKey ||
                    this.UserGroupPartitionKey != null &&
                    this.UserGroupPartitionKey.Equals(other.UserGroupPartitionKey)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.BriefsShared == other.BriefsShared ||
                    this.BriefsShared != null &&
                    this.BriefsShared.SequenceEqual(other.BriefsShared)
                ) && 
                (
                    this.BriefsCount == other.BriefsCount ||
                    this.BriefsCount != null &&
                    this.BriefsCount.Equals(other.BriefsCount)
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
                if (this.UserGroupPartitionKey != null)
                    hash = hash * 59 + this.UserGroupPartitionKey.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.BriefsShared != null)
                    hash = hash * 59 + this.BriefsShared.GetHashCode();
                if (this.BriefsCount != null)
                    hash = hash * 59 + this.BriefsCount.GetHashCode();
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
