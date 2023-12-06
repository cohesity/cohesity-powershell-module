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
    /// Sequencer used to identify pieces of data sent to Atom. It is expected that different enviroment protos will be added to this  to define their own sequencers like one is added for VMware below.
    /// </summary>
    [DataContract]
    public partial class Sequencer :  IEquatable<Sequencer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sequencer" /> class.
        /// </summary>
        /// <param name="mongodbSequencer">mongodbSequencer.</param>
        /// <param name="vmwareSequencer">vmwareSequencer.</param>
        public Sequencer(SequenceNumber mongodbSequencer = default(SequenceNumber), SequenceNumber vmwareSequencer = default(SequenceNumber))
        {
            this.MongodbSequencer = mongodbSequencer;
            this.VmwareSequencer = vmwareSequencer;
        }
        
        /// <summary>
        /// Gets or Sets MongodbSequencer
        /// </summary>
        [DataMember(Name="mongodbSequencer", EmitDefaultValue=false)]
        public SequenceNumber MongodbSequencer { get; set; }

        /// <summary>
        /// Gets or Sets VmwareSequencer
        /// </summary>
        [DataMember(Name="vmwareSequencer", EmitDefaultValue=false)]
        public SequenceNumber VmwareSequencer { get; set; }

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
            return this.Equals(input as Sequencer);
        }

        /// <summary>
        /// Returns true if Sequencer instances are equal
        /// </summary>
        /// <param name="input">Instance of Sequencer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sequencer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MongodbSequencer == input.MongodbSequencer ||
                    (this.MongodbSequencer != null &&
                    this.MongodbSequencer.Equals(input.MongodbSequencer))
                ) && 
                (
                    this.VmwareSequencer == input.VmwareSequencer ||
                    (this.VmwareSequencer != null &&
                    this.VmwareSequencer.Equals(input.VmwareSequencer))
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
                if (this.MongodbSequencer != null)
                    hashCode = hashCode * 59 + this.MongodbSequencer.GetHashCode();
                if (this.VmwareSequencer != null)
                    hashCode = hashCode * 59 + this.VmwareSequencer.GetHashCode();
                return hashCode;
            }
        }

    }

}

