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
    /// Specifies the arguments for updating the directory quota policies. This structure can be used for adding, updating and removing the policies.
    /// </summary>
    [DataContract]
    public partial class UpdateDirQuotaArgs :  IEquatable<UpdateDirQuotaArgs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDirQuotaArgs" /> class.
        /// </summary>
        /// <param name="disableDirQuota">Specifies directory quota to be disabled on the view..</param>
        /// <param name="quota">quota.</param>
        /// <param name="viewName">Specifies the name of the view..</param>
        public UpdateDirQuotaArgs(bool? disableDirQuota = default(bool?), DirQuotaPolicy quota = default(DirQuotaPolicy), string viewName = default(string))
        {
            this.DisableDirQuota = disableDirQuota;
            this.ViewName = viewName;
            this.DisableDirQuota = disableDirQuota;
            this.Quota = quota;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies directory quota to be disabled on the view.
        /// </summary>
        /// <value>Specifies directory quota to be disabled on the view.</value>
        [DataMember(Name="disableDirQuota", EmitDefaultValue=true)]
        public bool? DisableDirQuota { get; set; }

        /// <summary>
        /// Gets or Sets Quota
        /// </summary>
        [DataMember(Name="quota", EmitDefaultValue=false)]
        public DirQuotaPolicy Quota { get; set; }

        /// <summary>
        /// Specifies the name of the view.
        /// </summary>
        /// <value>Specifies the name of the view.</value>
        [DataMember(Name="viewName", EmitDefaultValue=true)]
        public string ViewName { get; set; }

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
            return this.Equals(input as UpdateDirQuotaArgs);
        }

        /// <summary>
        /// Returns true if UpdateDirQuotaArgs instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateDirQuotaArgs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDirQuotaArgs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisableDirQuota == input.DisableDirQuota ||
                    (this.DisableDirQuota != null &&
                    this.DisableDirQuota.Equals(input.DisableDirQuota))
                ) && 
                (
                    this.Quota == input.Quota ||
                    (this.Quota != null &&
                    this.Quota.Equals(input.Quota))
                ) && 
                (
                    this.ViewName == input.ViewName ||
                    (this.ViewName != null &&
                    this.ViewName.Equals(input.ViewName))
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
                if (this.DisableDirQuota != null)
                    hashCode = hashCode * 59 + this.DisableDirQuota.GetHashCode();
                if (this.Quota != null)
                    hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

