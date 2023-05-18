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
    /// Message to capture any additional backup params for Outlook within Office365 environment.
    /// </summary>
    [DataContract]
    public partial class OutlookBackupEnvParams :  IEquatable<OutlookBackupEnvParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookBackupEnvParams" /> class.
        /// </summary>
        /// <param name="attrFilterPolicy">attrFilterPolicy.</param>
        /// <param name="filteringPolicy">filteringPolicy.</param>
        /// <param name="shouldBackupMailbox">Specifies whether the mailbox for all the Office365 Users present in the protection job should be backed up..</param>
        public OutlookBackupEnvParams(AttributeFilterPolicy attrFilterPolicy = default(AttributeFilterPolicy), FilteringPolicyProto filteringPolicy = default(FilteringPolicyProto), bool? shouldBackupMailbox = default(bool?))
        {
            this.ShouldBackupMailbox = shouldBackupMailbox;
            this.AttrFilterPolicy = attrFilterPolicy;
            this.FilteringPolicy = filteringPolicy;
            this.ShouldBackupMailbox = shouldBackupMailbox;
        }
        
        /// <summary>
        /// Gets or Sets AttrFilterPolicy
        /// </summary>
        [DataMember(Name="attrFilterPolicy", EmitDefaultValue=false)]
        public AttributeFilterPolicy AttrFilterPolicy { get; set; }

        /// <summary>
        /// Gets or Sets FilteringPolicy
        /// </summary>
        [DataMember(Name="filteringPolicy", EmitDefaultValue=false)]
        public FilteringPolicyProto FilteringPolicy { get; set; }

        /// <summary>
        /// Specifies whether the mailbox for all the Office365 Users present in the protection job should be backed up.
        /// </summary>
        /// <value>Specifies whether the mailbox for all the Office365 Users present in the protection job should be backed up.</value>
        [DataMember(Name="shouldBackupMailbox", EmitDefaultValue=true)]
        public bool? ShouldBackupMailbox { get; set; }

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
            return this.Equals(input as OutlookBackupEnvParams);
        }

        /// <summary>
        /// Returns true if OutlookBackupEnvParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OutlookBackupEnvParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutlookBackupEnvParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttrFilterPolicy == input.AttrFilterPolicy ||
                    (this.AttrFilterPolicy != null &&
                    this.AttrFilterPolicy.Equals(input.AttrFilterPolicy))
                ) && 
                (
                    this.FilteringPolicy == input.FilteringPolicy ||
                    (this.FilteringPolicy != null &&
                    this.FilteringPolicy.Equals(input.FilteringPolicy))
                ) && 
                (
                    this.ShouldBackupMailbox == input.ShouldBackupMailbox ||
                    (this.ShouldBackupMailbox != null &&
                    this.ShouldBackupMailbox.Equals(input.ShouldBackupMailbox))
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
                if (this.AttrFilterPolicy != null)
                    hashCode = hashCode * 59 + this.AttrFilterPolicy.GetHashCode();
                if (this.FilteringPolicy != null)
                    hashCode = hashCode * 59 + this.FilteringPolicy.GetHashCode();
                if (this.ShouldBackupMailbox != null)
                    hashCode = hashCode * 59 + this.ShouldBackupMailbox.GetHashCode();
                return hashCode;
            }
        }

    }

}

