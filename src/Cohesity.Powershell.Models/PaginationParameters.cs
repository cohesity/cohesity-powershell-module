// Copyright 2019 Cohesity Inc.


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



namespace Cohesity.Model
{
    /// <summary>
    /// Specifies the cursor based pagination parameters for Protection Source and its children. Pagination is supported at a given level within the Protection Source Hierarchy with the help of before or after cursors. A Cursor will always refer to a specific source within the source dataset but will be invalidated if the item is removed.
    /// </summary>
    [DataContract]
    public partial class PaginationParameters :  IEquatable<PaginationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationParameters" /> class.
        /// </summary>
        /// <param name="afterCursorEntityId">Specifies the entity id starting from which the items are to be returned..</param>
        /// <param name="beforeCursorEntityId">Specifies the entity id upto which the items are to be returned..</param>
        /// <param name="nodeId">Specifies the entity id for the Node at any level within the Source entity hierarchy whose children are to be paginated..</param>
        /// <param name="pageSize">Specifies the maximum number of entities to be returned within the page..</param>
        public PaginationParameters(long? afterCursorEntityId = default(long?), long? beforeCursorEntityId = default(long?), long? nodeId = default(long?), long? pageSize = default(long?))
        {
            this.AfterCursorEntityId = afterCursorEntityId;
            this.BeforeCursorEntityId = beforeCursorEntityId;
            this.NodeId = nodeId;
            this.PageSize = pageSize;
        }
        
        /// <summary>
        /// Specifies the entity id starting from which the items are to be returned.
        /// </summary>
        /// <value>Specifies the entity id starting from which the items are to be returned.</value>
        [DataMember(Name="afterCursorEntityId", EmitDefaultValue=false)]
        public long? AfterCursorEntityId { get; set; }

        /// <summary>
        /// Specifies the entity id upto which the items are to be returned.
        /// </summary>
        /// <value>Specifies the entity id upto which the items are to be returned.</value>
        [DataMember(Name="beforeCursorEntityId", EmitDefaultValue=false)]
        public long? BeforeCursorEntityId { get; set; }

        /// <summary>
        /// Specifies the entity id for the Node at any level within the Source entity hierarchy whose children are to be paginated.
        /// </summary>
        /// <value>Specifies the entity id for the Node at any level within the Source entity hierarchy whose children are to be paginated.</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// Specifies the maximum number of entities to be returned within the page.
        /// </summary>
        /// <value>Specifies the maximum number of entities to be returned within the page.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as PaginationParameters);
        }

        /// <summary>
        /// Returns true if PaginationParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AfterCursorEntityId == input.AfterCursorEntityId ||
                    (this.AfterCursorEntityId != null &&
                    this.AfterCursorEntityId.Equals(input.AfterCursorEntityId))
                ) && 
                (
                    this.BeforeCursorEntityId == input.BeforeCursorEntityId ||
                    (this.BeforeCursorEntityId != null &&
                    this.BeforeCursorEntityId.Equals(input.BeforeCursorEntityId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
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
                if (this.AfterCursorEntityId != null)
                    hashCode = hashCode * 59 + this.AfterCursorEntityId.GetHashCode();
                if (this.BeforeCursorEntityId != null)
                    hashCode = hashCode * 59 + this.BeforeCursorEntityId.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                return hashCode;
            }
        }

    }

}

