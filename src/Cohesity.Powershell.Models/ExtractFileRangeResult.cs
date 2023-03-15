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
    /// This will capture output of ExtractFileRange and ExtractNFSFileRange.
    /// </summary>
    [DataContract]
    public partial class ExtractFileRangeResult :  IEquatable<ExtractFileRangeResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractFileRangeResult" /> class.
        /// </summary>
        /// <param name="data">The actual data bytes..</param>
        /// <param name="eof">Will be true if start_offset &gt; file length or EOF is reached. This is an alternative to using file_length to determine when entire file is read. Used when fetching from a view..</param>
        /// <param name="error">error.</param>
        /// <param name="fileLength">The total length of the file. This field would be set provided no error had occurred (indicated by error field above)..</param>
        /// <param name="startOffset">The offset from which data was read..</param>
        public ExtractFileRangeResult(List<int> data = default(List<int>), bool? eof = default(bool?), ErrorProto error = default(ErrorProto), long? fileLength = default(long?), long? startOffset = default(long?))
        {
            this.Data = data;
            this.Eof = eof;
            this.FileLength = fileLength;
            this.StartOffset = startOffset;
            this.Data = data;
            this.Eof = eof;
            this.Error = error;
            this.FileLength = fileLength;
            this.StartOffset = startOffset;
        }
        
        /// <summary>
        /// The actual data bytes.
        /// </summary>
        /// <value>The actual data bytes.</value>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<int> Data { get; set; }

        /// <summary>
        /// Will be true if start_offset &gt; file length or EOF is reached. This is an alternative to using file_length to determine when entire file is read. Used when fetching from a view.
        /// </summary>
        /// <value>Will be true if start_offset &gt; file length or EOF is reached. This is an alternative to using file_length to determine when entire file is read. Used when fetching from a view.</value>
        [DataMember(Name="eof", EmitDefaultValue=true)]
        public bool? Eof { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// The total length of the file. This field would be set provided no error had occurred (indicated by error field above).
        /// </summary>
        /// <value>The total length of the file. This field would be set provided no error had occurred (indicated by error field above).</value>
        [DataMember(Name="fileLength", EmitDefaultValue=true)]
        public long? FileLength { get; set; }

        /// <summary>
        /// The offset from which data was read.
        /// </summary>
        /// <value>The offset from which data was read.</value>
        [DataMember(Name="startOffset", EmitDefaultValue=true)]
        public long? StartOffset { get; set; }

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
            return this.Equals(input as ExtractFileRangeResult);
        }

        /// <summary>
        /// Returns true if ExtractFileRangeResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtractFileRangeResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtractFileRangeResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Eof == input.Eof ||
                    (this.Eof != null &&
                    this.Eof.Equals(input.Eof))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.FileLength == input.FileLength ||
                    (this.FileLength != null &&
                    this.FileLength.Equals(input.FileLength))
                ) && 
                (
                    this.StartOffset == input.StartOffset ||
                    (this.StartOffset != null &&
                    this.StartOffset.Equals(input.StartOffset))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Eof != null)
                    hashCode = hashCode * 59 + this.Eof.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.FileLength != null)
                    hashCode = hashCode * 59 + this.FileLength.GetHashCode();
                if (this.StartOffset != null)
                    hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                return hashCode;
            }
        }

    }

}

