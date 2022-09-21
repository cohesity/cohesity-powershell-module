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
    /// Specifies the remote view config for a view protected in a view job. This field is only used when the view job has a replication policy.
    /// </summary>
    [DataContract]
    public partial class RemoteViewConfig :  IEquatable<RemoteViewConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteViewConfig" /> class.
        /// </summary>
        /// <param name="sourceViewId">Specifies the view Id of the view protected by the view protection job..</param>
        /// <param name="useSameViewName">Specifies if the remote view name is same as the source view name. If this field is true, viewName is ignored as the remote view name is same as the source view name..</param>
        /// <param name="viewName">Specifies the remote view name of the view protected by a view protection job. If UseSameViewName is set to false, this field provides the remote view name to be used in the remote cluster..</param>
        public RemoteViewConfig(long? sourceViewId = default(long?), bool? useSameViewName = default(bool?), string viewName = default(string))
        {
            this.SourceViewId = sourceViewId;
            this.UseSameViewName = useSameViewName;
            this.ViewName = viewName;
            this.SourceViewId = sourceViewId;
            this.UseSameViewName = useSameViewName;
            this.ViewName = viewName;
        }
        
        /// <summary>
        /// Specifies the view Id of the view protected by the view protection job.
        /// </summary>
        /// <value>Specifies the view Id of the view protected by the view protection job.</value>
        [DataMember(Name="sourceViewId", EmitDefaultValue=true)]
        public long? SourceViewId { get; set; }

        /// <summary>
        /// Specifies if the remote view name is same as the source view name. If this field is true, viewName is ignored as the remote view name is same as the source view name.
        /// </summary>
        /// <value>Specifies if the remote view name is same as the source view name. If this field is true, viewName is ignored as the remote view name is same as the source view name.</value>
        [DataMember(Name="useSameViewName", EmitDefaultValue=true)]
        public bool? UseSameViewName { get; set; }

        /// <summary>
        /// Specifies the remote view name of the view protected by a view protection job. If UseSameViewName is set to false, this field provides the remote view name to be used in the remote cluster.
        /// </summary>
        /// <value>Specifies the remote view name of the view protected by a view protection job. If UseSameViewName is set to false, this field provides the remote view name to be used in the remote cluster.</value>
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
            return this.Equals(input as RemoteViewConfig);
        }

        /// <summary>
        /// Returns true if RemoteViewConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteViewConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteViewConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceViewId == input.SourceViewId ||
                    (this.SourceViewId != null &&
                    this.SourceViewId.Equals(input.SourceViewId))
                ) && 
                (
                    this.UseSameViewName == input.UseSameViewName ||
                    (this.UseSameViewName != null &&
                    this.UseSameViewName.Equals(input.UseSameViewName))
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
                if (this.SourceViewId != null)
                    hashCode = hashCode * 59 + this.SourceViewId.GetHashCode();
                if (this.UseSameViewName != null)
                    hashCode = hashCode * 59 + this.UseSameViewName.GetHashCode();
                if (this.ViewName != null)
                    hashCode = hashCode * 59 + this.ViewName.GetHashCode();
                return hashCode;
            }
        }

    }

}

