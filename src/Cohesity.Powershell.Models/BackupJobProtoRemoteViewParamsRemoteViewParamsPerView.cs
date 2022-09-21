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
    /// BackupJobProtoRemoteViewParamsRemoteViewParamsPerView
    /// </summary>
    [DataContract]
    public partial class BackupJobProtoRemoteViewParamsRemoteViewParamsPerView :  IEquatable<BackupJobProtoRemoteViewParamsRemoteViewParamsPerView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupJobProtoRemoteViewParamsRemoteViewParamsPerView" /> class.
        /// </summary>
        /// <param name="remoteViewName">If &#39;use_same_name_as_source_view&#39; is false, below name should be populated..</param>
        /// <param name="useSameNameAsSourceView">Whether remote view name will be same as the source view name..</param>
        public BackupJobProtoRemoteViewParamsRemoteViewParamsPerView(string remoteViewName = default(string), bool? useSameNameAsSourceView = default(bool?))
        {
            this.RemoteViewName = remoteViewName;
            this.UseSameNameAsSourceView = useSameNameAsSourceView;
            this.RemoteViewName = remoteViewName;
            this.UseSameNameAsSourceView = useSameNameAsSourceView;
        }
        
        /// <summary>
        /// If &#39;use_same_name_as_source_view&#39; is false, below name should be populated.
        /// </summary>
        /// <value>If &#39;use_same_name_as_source_view&#39; is false, below name should be populated.</value>
        [DataMember(Name="remoteViewName", EmitDefaultValue=true)]
        public string RemoteViewName { get; set; }

        /// <summary>
        /// Whether remote view name will be same as the source view name.
        /// </summary>
        /// <value>Whether remote view name will be same as the source view name.</value>
        [DataMember(Name="useSameNameAsSourceView", EmitDefaultValue=true)]
        public bool? UseSameNameAsSourceView { get; set; }

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
            return this.Equals(input as BackupJobProtoRemoteViewParamsRemoteViewParamsPerView);
        }

        /// <summary>
        /// Returns true if BackupJobProtoRemoteViewParamsRemoteViewParamsPerView instances are equal
        /// </summary>
        /// <param name="input">Instance of BackupJobProtoRemoteViewParamsRemoteViewParamsPerView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackupJobProtoRemoteViewParamsRemoteViewParamsPerView input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoteViewName == input.RemoteViewName ||
                    (this.RemoteViewName != null &&
                    this.RemoteViewName.Equals(input.RemoteViewName))
                ) && 
                (
                    this.UseSameNameAsSourceView == input.UseSameNameAsSourceView ||
                    (this.UseSameNameAsSourceView != null &&
                    this.UseSameNameAsSourceView.Equals(input.UseSameNameAsSourceView))
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
                if (this.RemoteViewName != null)
                    hashCode = hashCode * 59 + this.RemoteViewName.GetHashCode();
                if (this.UseSameNameAsSourceView != null)
                    hashCode = hashCode * 59 + this.UseSameNameAsSourceView.GetHashCode();
                return hashCode;
            }
        }

    }

}

