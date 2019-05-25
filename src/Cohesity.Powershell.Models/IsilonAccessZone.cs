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
    /// Specifies information about access zone in an Isilon Cluster.
    /// </summary>
    [DataContract]
    public partial class IsilonAccessZone :  IEquatable<IsilonAccessZone>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsilonAccessZone" /> class.
        /// </summary>
        /// <param name="id">Specifies the id of the access zone..</param>
        /// <param name="name">Specifies the name of the access zone..</param>
        /// <param name="path">Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;..</param>
        public IsilonAccessZone(long? id = default(long?), string name = default(string), string path = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Path = path;
            this.Id = id;
            this.Name = name;
            this.Path = path;
        }
        
        /// <summary>
        /// Specifies the id of the access zone.
        /// </summary>
        /// <value>Specifies the id of the access zone.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Specifies the name of the access zone.
        /// </summary>
        /// <value>Specifies the name of the access zone.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;.
        /// </summary>
        /// <value>Specifies the path of the access zone in ifs. This should include the leading \&quot;/ifs/\&quot;.</value>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsilonAccessZone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
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
            return this.Equals(input as IsilonAccessZone);
        }

        /// <summary>
        /// Returns true if IsilonAccessZone instances are equal
        /// </summary>
        /// <param name="input">Instance of IsilonAccessZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsilonAccessZone input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }

    }

}
