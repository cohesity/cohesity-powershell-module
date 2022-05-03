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
    /// Specifies settings required to create a task that restores the index and/or the Snapshots of a Protection Job from a remote Vault to the current Cluster.
    /// </summary>
    [DataContract]
    public partial class CreateRemoteVaultRestoreTaskParameters :  IEquatable<CreateRemoteVaultRestoreTaskParameters>
    {
        /// <summary>
        /// Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// </summary>
        /// <value>Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GlacierRetrievalTypeEnum
        {
            /// <summary>
            /// Enum KStandard for value: kStandard
            /// </summary>
            [EnumMember(Value = "kStandard")]
            KStandard = 1,

            /// <summary>
            /// Enum KBulk for value: kBulk
            /// </summary>
            [EnumMember(Value = "kBulk")]
            KBulk = 2,

            /// <summary>
            /// Enum KExpedited for value: kExpedited
            /// </summary>
            [EnumMember(Value = "kExpedited")]
            KExpedited = 3

        }

        /// <summary>
        /// Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// </summary>
        /// <value>Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes.</value>
        [DataMember(Name="glacierRetrievalType", EmitDefaultValue=false)]
        public GlacierRetrievalTypeEnum? GlacierRetrievalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRemoteVaultRestoreTaskParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRemoteVaultRestoreTaskParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRemoteVaultRestoreTaskParameters" /> class.
        /// </summary>
        /// <param name="glacierRetrievalType">Specifies the way data needs to be retrieved from the external target. This information will be filled in by Iris and Magneto will pass it along to the Icebox as it is to support bulk retrieval from Glacier. Specifies the type of Restore Task.  &#39;kStandard&#39; specifies retrievals that allow to access any of your archives within several hours. Standard retrievals typically complete within 3–5 hours. This is the default option for retrieval requests that do not specify the retrieval option. &#39;kBulk&#39; specifies retrievals that are Glacier’s lowest-cost retrieval option, which can be used to retrieve large amounts, even petabytes, of data inexpensively in a day. Bulk retrieval typically complete within 5–12 hours. &#39;kExpedited&#39; specifies retrievals that allows to quickly access your data when occasional urgent requests for a subset of archives are required. For all but the largest archives (250 MB+), data accessed using Expedited retrievals are typically made available within 1–5 minutes..</param>
        /// <param name="restoreObjects">Array of Restore Objects.  Specifies the list of Snapshots and the index to be restored from the remote Vault. The data on the remote Vault may have been originally archived from multiple remote Clusters..</param>
        /// <param name="searchJobUid">Specifies the unique id of the remote Vault search Job. (required).</param>
        /// <param name="taskName">Specifies a name of the restore task. (required).</param>
        /// <param name="vaultId">Specifies the id of the Vault that contains the index and Snapshots to restore to the current Cluster. This is the id assigned by the Cohesity Cluster when Vault was registered as an External Target. (required).</param>
        public CreateRemoteVaultRestoreTaskParameters(GlacierRetrievalTypeEnum? glacierRetrievalType = default(GlacierRetrievalTypeEnum?), List<IndexAndSnapshots> restoreObjects = default(List<IndexAndSnapshots>), UniversalId searchJobUid = default(UniversalId), string taskName = default(string), long? vaultId = default(long?))
        {
            // to ensure "searchJobUid" is required (not null)
            if (searchJobUid == null)
            {
                throw new InvalidDataException("searchJobUid is a required property for CreateRemoteVaultRestoreTaskParameters and cannot be null");
            }
            else
            {
                this.SearchJobUid = searchJobUid;
            }
            // to ensure "taskName" is required (not null)
            if (taskName == null)
            {
                throw new InvalidDataException("taskName is a required property for CreateRemoteVaultRestoreTaskParameters and cannot be null");
            }
            else
            {
                this.TaskName = taskName;
            }
            // to ensure "vaultId" is required (not null)
            if (vaultId == null)
            {
                throw new InvalidDataException("vaultId is a required property for CreateRemoteVaultRestoreTaskParameters and cannot be null");
            }
            else
            {
                this.VaultId = vaultId;
            }
            this.GlacierRetrievalType = glacierRetrievalType;
            this.RestoreObjects = restoreObjects;
        }
        

        /// <summary>
        /// Array of Restore Objects.  Specifies the list of Snapshots and the index to be restored from the remote Vault. The data on the remote Vault may have been originally archived from multiple remote Clusters.
        /// </summary>
        /// <value>Array of Restore Objects.  Specifies the list of Snapshots and the index to be restored from the remote Vault. The data on the remote Vault may have been originally archived from multiple remote Clusters.</value>
        [DataMember(Name="restoreObjects", EmitDefaultValue=false)]
        public List<IndexAndSnapshots> RestoreObjects { get; set; }

        /// <summary>
        /// Specifies the unique id of the remote Vault search Job.
        /// </summary>
        /// <value>Specifies the unique id of the remote Vault search Job.</value>
        [DataMember(Name="searchJobUid", EmitDefaultValue=false)]
        public UniversalId SearchJobUid { get; set; }

        /// <summary>
        /// Specifies a name of the restore task.
        /// </summary>
        /// <value>Specifies a name of the restore task.</value>
        [DataMember(Name="taskName", EmitDefaultValue=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Specifies the id of the Vault that contains the index and Snapshots to restore to the current Cluster. This is the id assigned by the Cohesity Cluster when Vault was registered as an External Target.
        /// </summary>
        /// <value>Specifies the id of the Vault that contains the index and Snapshots to restore to the current Cluster. This is the id assigned by the Cohesity Cluster when Vault was registered as an External Target.</value>
        [DataMember(Name="vaultId", EmitDefaultValue=false)]
        public long? VaultId { get; set; }

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
            return this.Equals(input as CreateRemoteVaultRestoreTaskParameters);
        }

        /// <summary>
        /// Returns true if CreateRemoteVaultRestoreTaskParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRemoteVaultRestoreTaskParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRemoteVaultRestoreTaskParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GlacierRetrievalType == input.GlacierRetrievalType ||
                    (this.GlacierRetrievalType != null &&
                    this.GlacierRetrievalType.Equals(input.GlacierRetrievalType))
                ) && 
                (
                    this.RestoreObjects == input.RestoreObjects ||
                    this.RestoreObjects != null &&
                    this.RestoreObjects.Equals(input.RestoreObjects)
                ) && 
                (
                    this.SearchJobUid == input.SearchJobUid ||
                    this.SearchJobUid != null &&
                    this.SearchJobUid.Equals(input.SearchJobUid)
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
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
                if (this.GlacierRetrievalType != null)
                    hashCode = hashCode * 59 + this.GlacierRetrievalType.GetHashCode();
                if (this.RestoreObjects != null)
                    hashCode = hashCode * 59 + this.RestoreObjects.GetHashCode();
                if (this.SearchJobUid != null)
                    hashCode = hashCode * 59 + this.SearchJobUid.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                return hashCode;
            }
        }

    }

}

