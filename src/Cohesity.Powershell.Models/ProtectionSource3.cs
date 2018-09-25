// Copyright 2018 Cohesity Inc.

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




namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the leaf Protection Source Object (such as VM). Snapshot summary statistics are reported for this Protection Source Object.
    /// </summary>
    [DataContract]
    public partial class ProtectionSource3 :  IEquatable<ProtectionSource3>
    {

        /// <summary>
        /// Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
        /// </summary>
        /// <value>Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionSource3" /> class.
        /// </summary>
        /// <param name="acropolisProtectionSource">acropolisProtectionSource.</param>
        /// <param name="awsProtectionSource">awsProtectionSource.</param>
        /// <param name="azureProtectionSource">azureProtectionSource.</param>
        /// <param name="environment">Specifies the environment (such as &#39;kVMware&#39; or &#39;kSQL&#39;) where the Protection Source exists. Depending on the environment, one of the following Protection Sources are initialized.  NOTE: kPuppeteer refers to Cohesity&#39;s Remote Adapter. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter..</param>
        /// <param name="hypervProtectionSource">hypervProtectionSource.</param>
        /// <param name="id">Specifies an id of the Protection Source..</param>
        /// <param name="kvmProtectionSource">kvmProtectionSource.</param>
        /// <param name="name">Specifies a name of the Protection Source..</param>
        /// <param name="nasProtectionSource">nasProtectionSource.</param>
        /// <param name="netappProtectionSource">netappProtectionSource.</param>
        /// <param name="parentId">Specifies an id of the parent of the Protection Source..</param>
        /// <param name="physicalProtectionSource">physicalProtectionSource.</param>
        /// <param name="pureProtectionSource">pureProtectionSource.</param>
        /// <param name="sqlProtectionSource">sqlProtectionSource.</param>
        /// <param name="viewProtectionSource">viewProtectionSource.</param>
        /// <param name="vmWareProtectionSource">vmWareProtectionSource.</param>
        public ProtectionSource3(AcropolisProtectionSource_ acropolisProtectionSource = default(AcropolisProtectionSource_), AWSProtectionSource_ awsProtectionSource = default(AWSProtectionSource_), AzureProtectionSource_ azureProtectionSource = default(AzureProtectionSource_), EnvironmentEnum? environment = default(EnvironmentEnum?), HyperVProtectionSource_ hypervProtectionSource = default(HyperVProtectionSource_), long? id = default(long?), KVMProtectionSource_ kvmProtectionSource = default(KVMProtectionSource_), string name = default(string), GenericNASProtectionSource_ nasProtectionSource = default(GenericNASProtectionSource_), NetAppProtectionSource_ netappProtectionSource = default(NetAppProtectionSource_), long? parentId = default(long?), PhysicalProtectionSource_ physicalProtectionSource = default(PhysicalProtectionSource_), PureProtectionSource_ pureProtectionSource = default(PureProtectionSource_), SQLProtectionSource_ sqlProtectionSource = default(SQLProtectionSource_), ViewProtectionSource_ viewProtectionSource = default(ViewProtectionSource_), VMwareProtectionSource_ vmWareProtectionSource = default(VMwareProtectionSource_))
        {
            this.AcropolisProtectionSource = acropolisProtectionSource;
            this.AwsProtectionSource = awsProtectionSource;
            this.AzureProtectionSource = azureProtectionSource;
            this.Environment = environment;
            this.HypervProtectionSource = hypervProtectionSource;
            this.Id = id;
            this.KvmProtectionSource = kvmProtectionSource;
            this.Name = name;
            this.NasProtectionSource = nasProtectionSource;
            this.NetappProtectionSource = netappProtectionSource;
            this.ParentId = parentId;
            this.PhysicalProtectionSource = physicalProtectionSource;
            this.PureProtectionSource = pureProtectionSource;
            this.SqlProtectionSource = sqlProtectionSource;
            this.ViewProtectionSource = viewProtectionSource;
            this.VmWareProtectionSource = vmWareProtectionSource;
        }
        
        /// <summary>
        /// Gets or Sets AcropolisProtectionSource
        /// </summary>
        [DataMember(Name="acropolisProtectionSource", EmitDefaultValue=false)]
        public AcropolisProtectionSource_ AcropolisProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets AwsProtectionSource
        /// </summary>
        [DataMember(Name="awsProtectionSource", EmitDefaultValue=false)]
        public AWSProtectionSource_ AwsProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets AzureProtectionSource
        /// </summary>
        [DataMember(Name="azureProtectionSource", EmitDefaultValue=false)]
        public AzureProtectionSource_ AzureProtectionSource { get; set; }


        /// <summary>
        /// Gets or Sets HypervProtectionSource
        /// </summary>
        [DataMember(Name="hypervProtectionSource", EmitDefaultValue=false)]
        public HyperVProtectionSource_ HypervProtectionSource { get; set; }

        /// <summary>
        /// Specifies an id of the Protection Source.
        /// </summary>
        /// <value>Specifies an id of the Protection Source.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets KvmProtectionSource
        /// </summary>
        [DataMember(Name="kvmProtectionSource", EmitDefaultValue=false)]
        public KVMProtectionSource_ KvmProtectionSource { get; set; }

        /// <summary>
        /// Specifies a name of the Protection Source.
        /// </summary>
        /// <value>Specifies a name of the Protection Source.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NasProtectionSource
        /// </summary>
        [DataMember(Name="nasProtectionSource", EmitDefaultValue=false)]
        public GenericNASProtectionSource_ NasProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets NetappProtectionSource
        /// </summary>
        [DataMember(Name="netappProtectionSource", EmitDefaultValue=false)]
        public NetAppProtectionSource_ NetappProtectionSource { get; set; }

        /// <summary>
        /// Specifies an id of the parent of the Protection Source.
        /// </summary>
        /// <value>Specifies an id of the parent of the Protection Source.</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalProtectionSource
        /// </summary>
        [DataMember(Name="physicalProtectionSource", EmitDefaultValue=false)]
        public PhysicalProtectionSource_ PhysicalProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets PureProtectionSource
        /// </summary>
        [DataMember(Name="pureProtectionSource", EmitDefaultValue=false)]
        public PureProtectionSource_ PureProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets SqlProtectionSource
        /// </summary>
        [DataMember(Name="sqlProtectionSource", EmitDefaultValue=false)]
        public SQLProtectionSource_ SqlProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets ViewProtectionSource
        /// </summary>
        [DataMember(Name="viewProtectionSource", EmitDefaultValue=false)]
        public ViewProtectionSource_ ViewProtectionSource { get; set; }

        /// <summary>
        /// Gets or Sets VmWareProtectionSource
        /// </summary>
        [DataMember(Name="vmWareProtectionSource", EmitDefaultValue=false)]
        public VMwareProtectionSource_ VmWareProtectionSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
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
            return this.Equals(input as ProtectionSource3);
        }

        /// <summary>
        /// Returns true if ProtectionSource3 instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtectionSource3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtectionSource3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcropolisProtectionSource == input.AcropolisProtectionSource ||
                    (this.AcropolisProtectionSource != null &&
                    this.AcropolisProtectionSource.Equals(input.AcropolisProtectionSource))
                ) && 
                (
                    this.AwsProtectionSource == input.AwsProtectionSource ||
                    (this.AwsProtectionSource != null &&
                    this.AwsProtectionSource.Equals(input.AwsProtectionSource))
                ) && 
                (
                    this.AzureProtectionSource == input.AzureProtectionSource ||
                    (this.AzureProtectionSource != null &&
                    this.AzureProtectionSource.Equals(input.AzureProtectionSource))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.HypervProtectionSource == input.HypervProtectionSource ||
                    (this.HypervProtectionSource != null &&
                    this.HypervProtectionSource.Equals(input.HypervProtectionSource))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.KvmProtectionSource == input.KvmProtectionSource ||
                    (this.KvmProtectionSource != null &&
                    this.KvmProtectionSource.Equals(input.KvmProtectionSource))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NasProtectionSource == input.NasProtectionSource ||
                    (this.NasProtectionSource != null &&
                    this.NasProtectionSource.Equals(input.NasProtectionSource))
                ) && 
                (
                    this.NetappProtectionSource == input.NetappProtectionSource ||
                    (this.NetappProtectionSource != null &&
                    this.NetappProtectionSource.Equals(input.NetappProtectionSource))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.PhysicalProtectionSource == input.PhysicalProtectionSource ||
                    (this.PhysicalProtectionSource != null &&
                    this.PhysicalProtectionSource.Equals(input.PhysicalProtectionSource))
                ) && 
                (
                    this.PureProtectionSource == input.PureProtectionSource ||
                    (this.PureProtectionSource != null &&
                    this.PureProtectionSource.Equals(input.PureProtectionSource))
                ) && 
                (
                    this.SqlProtectionSource == input.SqlProtectionSource ||
                    (this.SqlProtectionSource != null &&
                    this.SqlProtectionSource.Equals(input.SqlProtectionSource))
                ) && 
                (
                    this.ViewProtectionSource == input.ViewProtectionSource ||
                    (this.ViewProtectionSource != null &&
                    this.ViewProtectionSource.Equals(input.ViewProtectionSource))
                ) && 
                (
                    this.VmWareProtectionSource == input.VmWareProtectionSource ||
                    (this.VmWareProtectionSource != null &&
                    this.VmWareProtectionSource.Equals(input.VmWareProtectionSource))
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
                if (this.AcropolisProtectionSource != null)
                    hashCode = hashCode * 59 + this.AcropolisProtectionSource.GetHashCode();
                if (this.AwsProtectionSource != null)
                    hashCode = hashCode * 59 + this.AwsProtectionSource.GetHashCode();
                if (this.AzureProtectionSource != null)
                    hashCode = hashCode * 59 + this.AzureProtectionSource.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.HypervProtectionSource != null)
                    hashCode = hashCode * 59 + this.HypervProtectionSource.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.KvmProtectionSource != null)
                    hashCode = hashCode * 59 + this.KvmProtectionSource.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NasProtectionSource != null)
                    hashCode = hashCode * 59 + this.NasProtectionSource.GetHashCode();
                if (this.NetappProtectionSource != null)
                    hashCode = hashCode * 59 + this.NetappProtectionSource.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.PhysicalProtectionSource != null)
                    hashCode = hashCode * 59 + this.PhysicalProtectionSource.GetHashCode();
                if (this.PureProtectionSource != null)
                    hashCode = hashCode * 59 + this.PureProtectionSource.GetHashCode();
                if (this.SqlProtectionSource != null)
                    hashCode = hashCode * 59 + this.SqlProtectionSource.GetHashCode();
                if (this.ViewProtectionSource != null)
                    hashCode = hashCode * 59 + this.ViewProtectionSource.GetHashCode();
                if (this.VmWareProtectionSource != null)
                    hashCode = hashCode * 59 + this.VmWareProtectionSource.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

