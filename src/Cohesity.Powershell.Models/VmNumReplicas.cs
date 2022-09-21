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
    /// VmNumReplicas
    /// </summary>
    [DataContract]
    public partial class VmNumReplicas :  IEquatable<VmNumReplicas>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmNumReplicas" /> class.
        /// </summary>
        /// <param name="numReplicas">Replica count..</param>
        /// <param name="vmName">Vm-name..</param>
        public VmNumReplicas(long? numReplicas = default(long?), string vmName = default(string))
        {
            this.NumReplicas = numReplicas;
            this.VmName = vmName;
            this.NumReplicas = numReplicas;
            this.VmName = vmName;
        }
        
        /// <summary>
        /// Replica count.
        /// </summary>
        /// <value>Replica count.</value>
        [DataMember(Name="numReplicas", EmitDefaultValue=true)]
        public long? NumReplicas { get; set; }

        /// <summary>
        /// Vm-name.
        /// </summary>
        /// <value>Vm-name.</value>
        [DataMember(Name="vmName", EmitDefaultValue=true)]
        public string VmName { get; set; }

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
            return this.Equals(input as VmNumReplicas);
        }

        /// <summary>
        /// Returns true if VmNumReplicas instances are equal
        /// </summary>
        /// <param name="input">Instance of VmNumReplicas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmNumReplicas input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumReplicas == input.NumReplicas ||
                    (this.NumReplicas != null &&
                    this.NumReplicas.Equals(input.NumReplicas))
                ) && 
                (
                    this.VmName == input.VmName ||
                    (this.VmName != null &&
                    this.VmName.Equals(input.VmName))
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
                if (this.NumReplicas != null)
                    hashCode = hashCode * 59 + this.NumReplicas.GetHashCode();
                if (this.VmName != null)
                    hashCode = hashCode * 59 + this.VmName.GetHashCode();
                return hashCode;
            }
        }

    }

}

