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
    /// Struct containing vm-name and ui-name (to be displayed on the UI to get number of replicas as input) as members.
    /// </summary>
    [DataContract]
    public partial class VmNameInfo :  IEquatable<VmNameInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmNameInfo" /> class.
        /// </summary>
        /// <param name="uiName">UI-name. To be displayed on the UI..</param>
        /// <param name="vmName">Vm-name..</param>
        public VmNameInfo(string uiName = default(string), string vmName = default(string))
        {
            this.UiName = uiName;
            this.VmName = vmName;
            this.UiName = uiName;
            this.VmName = vmName;
        }
        
        /// <summary>
        /// UI-name. To be displayed on the UI.
        /// </summary>
        /// <value>UI-name. To be displayed on the UI.</value>
        [DataMember(Name="uiName", EmitDefaultValue=true)]
        public string UiName { get; set; }

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
            return this.Equals(input as VmNameInfo);
        }

        /// <summary>
        /// Returns true if VmNameInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VmNameInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmNameInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UiName == input.UiName ||
                    (this.UiName != null &&
                    this.UiName.Equals(input.UiName))
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
                if (this.UiName != null)
                    hashCode = hashCode * 59 + this.UiName.GetHashCode();
                if (this.VmName != null)
                    hashCode = hashCode * 59 + this.VmName.GetHashCode();
                return hashCode;
            }
        }

    }

}

