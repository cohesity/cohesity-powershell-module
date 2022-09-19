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
    /// Specifies information needed when restoring VMs in HyperV enviroment. This field defines the HyperV specific params for restore tasks of type kRecoverVMs.
    /// </summary>
    [DataContract]
    public partial class HypervRestoreParameters :  IEquatable<HypervRestoreParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HypervRestoreParameters" /> class.
        /// </summary>
        /// <param name="datastoreId">A datastore entity where the object&#39;s files should be restored to. This field is optional if object is being restored to its original parent source. If not specified, the object&#39;s files will be restored to their original datastore locations. This field is mandatory if object is being restored to a different resource entity or to a different parent source..</param>
        /// <param name="disableNetwork">Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it..</param>
        /// <param name="networkId">Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source..</param>
        /// <param name="poweredOn">Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off..</param>
        /// <param name="prefix">Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        /// <param name="preserveTags">Specifies whether or not to preserve tags during the operation..</param>
        /// <param name="resourceId">The resource (HyperV host) to which the restored VM will be attached.  This field is optional for a kRecoverVMs task if the VMs are being restored to its original parent source. If not specified, restored VMs will be attached to its original host. This field is mandatory if the VMs are being restored to a different parent source..</param>
        /// <param name="suffix">Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters..</param>
        public HypervRestoreParameters(long? datastoreId = default(long?), bool? disableNetwork = default(bool?), long? networkId = default(long?), bool? poweredOn = default(bool?), string prefix = default(string), bool? preserveTags = default(bool?), long? resourceId = default(long?), string suffix = default(string))
        {
            this.DatastoreId = datastoreId;
            this.DisableNetwork = disableNetwork;
            this.NetworkId = networkId;
            this.PoweredOn = poweredOn;
            this.Prefix = prefix;
            this.PreserveTags = preserveTags;
            this.ResourceId = resourceId;
            this.Suffix = suffix;
            this.DatastoreId = datastoreId;
            this.DisableNetwork = disableNetwork;
            this.NetworkId = networkId;
            this.PoweredOn = poweredOn;
            this.Prefix = prefix;
            this.PreserveTags = preserveTags;
            this.ResourceId = resourceId;
            this.Suffix = suffix;
        }
        
        /// <summary>
        /// A datastore entity where the object&#39;s files should be restored to. This field is optional if object is being restored to its original parent source. If not specified, the object&#39;s files will be restored to their original datastore locations. This field is mandatory if object is being restored to a different resource entity or to a different parent source.
        /// </summary>
        /// <value>A datastore entity where the object&#39;s files should be restored to. This field is optional if object is being restored to its original parent source. If not specified, the object&#39;s files will be restored to their original datastore locations. This field is mandatory if object is being restored to a different resource entity or to a different parent source.</value>
        [DataMember(Name="datastoreId", EmitDefaultValue=true)]
        public long? DatastoreId { get; set; }

        /// <summary>
        /// Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it.
        /// </summary>
        /// <value>Specifies whether the network should be left in disabled state. Attached network is enabled by default. Set this flag to true to disable it.</value>
        [DataMember(Name="disableNetwork", EmitDefaultValue=true)]
        public bool? DisableNetwork { get; set; }

        /// <summary>
        /// Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source.
        /// </summary>
        /// <value>Specifies a network configuration to be attached to the cloned or recovered object. For kCloneVMs and kRecoverVMs tasks, original network configuration is detached if the cloned or recovered object is kept under a different parent Protection Source or a different Resource Pool. By default, for kRecoverVMs task, original network configuration is preserved if the recovered object is kept under the same parent Protection Source and the same Resource Pool. Specify this field to override the preserved network configuration or to attach a new network configuration to the cloned or recovered objects. You can get the networkId of the kNetwork object by setting includeNetworks to &#39;true&#39; in the GET /public/protectionSources operation. In the response, get the id of the desired kNetwork object, the resource pool, and the registered parent Protection Source.</value>
        [DataMember(Name="networkId", EmitDefaultValue=true)]
        public long? NetworkId { get; set; }

        /// <summary>
        /// Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off.
        /// </summary>
        /// <value>Specifies the power state of the cloned or recovered objects. By default, the cloned or recovered objects are powered off.</value>
        [DataMember(Name="poweredOn", EmitDefaultValue=true)]
        public bool? PoweredOn { get; set; }

        /// <summary>
        /// Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a prefix to prepended to the source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="prefix", EmitDefaultValue=true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Specifies whether or not to preserve tags during the operation.
        /// </summary>
        /// <value>Specifies whether or not to preserve tags during the operation.</value>
        [DataMember(Name="preserveTags", EmitDefaultValue=true)]
        public bool? PreserveTags { get; set; }

        /// <summary>
        /// The resource (HyperV host) to which the restored VM will be attached.  This field is optional for a kRecoverVMs task if the VMs are being restored to its original parent source. If not specified, restored VMs will be attached to its original host. This field is mandatory if the VMs are being restored to a different parent source.
        /// </summary>
        /// <value>The resource (HyperV host) to which the restored VM will be attached.  This field is optional for a kRecoverVMs task if the VMs are being restored to its original parent source. If not specified, restored VMs will be attached to its original host. This field is mandatory if the VMs are being restored to a different parent source.</value>
        [DataMember(Name="resourceId", EmitDefaultValue=true)]
        public long? ResourceId { get; set; }

        /// <summary>
        /// Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.
        /// </summary>
        /// <value>Specifies a suffix to appended to the original source object name to derive a new name for the recovered or cloned object. By default, cloned or recovered objects retain their original name. Length of this field is limited to 8 characters.</value>
        [DataMember(Name="suffix", EmitDefaultValue=true)]
        public string Suffix { get; set; }

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
            return this.Equals(input as HypervRestoreParameters);
        }

        /// <summary>
        /// Returns true if HypervRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of HypervRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HypervRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreId == input.DatastoreId ||
                    (this.DatastoreId != null &&
                    this.DatastoreId.Equals(input.DatastoreId))
                ) && 
                (
                    this.DisableNetwork == input.DisableNetwork ||
                    (this.DisableNetwork != null &&
                    this.DisableNetwork.Equals(input.DisableNetwork))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.PoweredOn == input.PoweredOn ||
                    (this.PoweredOn != null &&
                    this.PoweredOn.Equals(input.PoweredOn))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.PreserveTags == input.PreserveTags ||
                    (this.PreserveTags != null &&
                    this.PreserveTags.Equals(input.PreserveTags))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
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
                if (this.DatastoreId != null)
                    hashCode = hashCode * 59 + this.DatastoreId.GetHashCode();
                if (this.DisableNetwork != null)
                    hashCode = hashCode * 59 + this.DisableNetwork.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.PoweredOn != null)
                    hashCode = hashCode * 59 + this.PoweredOn.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.PreserveTags != null)
                    hashCode = hashCode * 59 + this.PreserveTags.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                return hashCode;
            }
        }

    }

}

