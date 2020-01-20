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
    /// Specifies the settings of an interface group.
    /// </summary>
    [DataContract]
    public partial class InterfaceGroup :  IEquatable<InterfaceGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceGroup" /> class.
        /// </summary>
        /// <param name="id">Interface group Id.  Specifies the id of the interface group..</param>
        /// <param name="modelInterfaceLists">Specifies the product model and interface lists..</param>
        /// <param name="name">Specifies the name of the interface group..</param>
        /// <param name="networkParams">networkParams.</param>
        public InterfaceGroup(int? id = default(int?), List<ProductModelInterfaceTuple> modelInterfaceLists = default(List<ProductModelInterfaceTuple>), string name = default(string), NetworkParams networkParams = default(NetworkParams))
        {
            this.Id = id;
            this.ModelInterfaceLists = modelInterfaceLists;
            this.Name = name;
            this.Id = id;
            this.ModelInterfaceLists = modelInterfaceLists;
            this.Name = name;
            this.NetworkParams = networkParams;
        }
        
        /// <summary>
        /// Interface group Id.  Specifies the id of the interface group.
        /// </summary>
        /// <value>Interface group Id.  Specifies the id of the interface group.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int? Id { get; set; }

        /// <summary>
        /// Specifies the product model and interface lists.
        /// </summary>
        /// <value>Specifies the product model and interface lists.</value>
        [DataMember(Name="modelInterfaceLists", EmitDefaultValue=true)]
        public List<ProductModelInterfaceTuple> ModelInterfaceLists { get; set; }

        /// <summary>
        /// Specifies the name of the interface group.
        /// </summary>
        /// <value>Specifies the name of the interface group.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NetworkParams
        /// </summary>
        [DataMember(Name="networkParams", EmitDefaultValue=false)]
        public NetworkParams NetworkParams { get; set; }

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
            return this.Equals(input as InterfaceGroup);
        }

        /// <summary>
        /// Returns true if InterfaceGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceGroup input)
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
                    this.ModelInterfaceLists == input.ModelInterfaceLists ||
                    this.ModelInterfaceLists != null &&
                    input.ModelInterfaceLists != null &&
                    this.ModelInterfaceLists.SequenceEqual(input.ModelInterfaceLists)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkParams == input.NetworkParams ||
                    (this.NetworkParams != null &&
                    this.NetworkParams.Equals(input.NetworkParams))
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
                if (this.ModelInterfaceLists != null)
                    hashCode = hashCode * 59 + this.ModelInterfaceLists.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkParams != null)
                    hashCode = hashCode * 59 + this.NetworkParams.GetHashCode();
                return hashCode;
            }
        }

    }

}

