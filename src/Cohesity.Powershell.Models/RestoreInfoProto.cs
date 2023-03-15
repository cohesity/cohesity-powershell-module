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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined. The extension applies to both RestoreInfoProto as well as RestoreEntity.  RestoreInfoProto extension                     Location            Extension &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; vmware::RestoreInfo::vmware_restore_info     vmware/vmware.proto       100 sql::RestoreInfo::sql_restore_info           sql/sql.proto             101 pure::RestoreInfo::pure_restore_info         pure/pure.proto           102 azure::RestoreInfo::azure_restore_info       azure/azure.proto         103 file::RestoreInfo::file_restore_info         file/file.proto           104 hyperv::RestoreInfo::hyperv_restore_info     hyperv/hyperv.proto       105 acropolis::RestoreInfo::acropolis_restore_info acropolis/acropolis.proto 106 kvm::RestoreInfo::kvm_restore_info           kvm/kvm.proto             107 aws::RestoreInfo::aws_restore_info           aws/aws.proto             108 physical::RestoreInfo::physical_restore_info physical.proto            109 oracle::RestoreInfo::oracle_restore_info     oracle/oracle.proto       110 outlook::RestoreInfo::outlook_restore_info   outlook/outlook.proto     111 gcp::RestoreInfo::gcp_restore_info           gcp/gcp.proto             112 ad::RestoreInfo::ad_restore_info             ad/ad.proto               113 kubernetes::RestoreInfo::kubernetes_restore_info kubernetes/kubernetes.proto 114 one_drive::RestoreInfo::one_drive_restore_info ms_graph/graph.proto      115 cdp::RestoreInfo::cdp_restore_info           cdp.proto                 116 exchange::RestoreInfo::exchange_restore_info exchange/exchange.proto   117 imanis::RestoreInfo::nosql_recovery_info     imanis/nosql.proto        118 o365::RestoreInfo::o365_restore_info o365/o365.proto      119 o365::RestoreInfo::o365_one_drive_restore_info o365/o365.proto      120 o365::PublicFolderRestoreInfoProto::public_folder_restore_info o365/o365.proto            121 uda::RestoreInfo::uda_recovery_info          uda/uda.proto              122 outlook::RestoreInfo::pst_convert_info       outlook/outlook.proto      123 o365::GroupRestoreInfo::group_restore_info   o365/o365.proto            124 o365::TeamsRestoreInfoProto::teams_restore_info o365/o365.proto            125 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;  RestoreInfoProto.RestoreEntity extension       Location            Extension &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; vmware::RestoreEntityInfo::vmware_restore_entity_info vmware/vmware.proto        100 azure::CloudDeployEntityInfo::azure_restore_entity_info azure/azure.proto          101 hyperv::RestoreEntityInfo::hyperv_restore_entity_info hyperv/hyperv.proto        102 acropolis::RestoreEntityInfo::acropolis_restore_entity_info acropolis/acropolis.proto  103 kvm::RestoreEntityInfo::kvm_restore_entity_info kvm/kvm.proto              104 aws::CloudDeployEntityInfo::aws_restore_entity_info aws/aws.proto              105 outlook::RestoreEntityInfo::outlook_restore_entity_info outlook/outlook.proto      106 gcp::CloudDeployEntityInfo::gcp_restore_entity_info gcp/gcp.proto              107 kubernetes::RestoreEntityInfo::kubernetes_restore_entity_info kuebrnetes/kubernetes.proto 108 one_drive::RestoreEntityInfo::one_drive_restore_entity_info ms_graph/graph.proto       109 imanis::RestoreEntityInfo::nosql_restore_entity_info imanis/nosql.proto         110 site::RestoreEntityInfo::site_restore_entity_info ms_graph/graph.proto       111 uda::RestoreEntityInfo::uda_restore_entity_info uda/uda.proto              112 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class RestoreInfoProto :  IEquatable<RestoreInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreInfoProto" /> class.
        /// </summary>
        /// <param name="postScriptStatus">postScriptStatus.</param>
        /// <param name="preScriptStatus">preScriptStatus.</param>
        /// <param name="restoreEntityVec">Contains the file paths and the information of the restored entities..</param>
        /// <param name="targetType">Specifies the target type for the task. The field is only valid if the task has got a permit..</param>
        /// <param name="type">The type of environment this restore info pertains to..</param>
        public RestoreInfoProto(ScriptExecutionStatus postScriptStatus = default(ScriptExecutionStatus), ScriptExecutionStatus preScriptStatus = default(ScriptExecutionStatus), List<RestoreInfoProtoRestoreEntity> restoreEntityVec = default(List<RestoreInfoProtoRestoreEntity>), int? targetType = default(int?), int? type = default(int?))
        {
            this.RestoreEntityVec = restoreEntityVec;
            this.TargetType = targetType;
            this.Type = type;
            this.PostScriptStatus = postScriptStatus;
            this.PreScriptStatus = preScriptStatus;
            this.RestoreEntityVec = restoreEntityVec;
            this.TargetType = targetType;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets PostScriptStatus
        /// </summary>
        [DataMember(Name="postScriptStatus", EmitDefaultValue=false)]
        public ScriptExecutionStatus PostScriptStatus { get; set; }

        /// <summary>
        /// Gets or Sets PreScriptStatus
        /// </summary>
        [DataMember(Name="preScriptStatus", EmitDefaultValue=false)]
        public ScriptExecutionStatus PreScriptStatus { get; set; }

        /// <summary>
        /// Contains the file paths and the information of the restored entities.
        /// </summary>
        /// <value>Contains the file paths and the information of the restored entities.</value>
        [DataMember(Name="restoreEntityVec", EmitDefaultValue=true)]
        public List<RestoreInfoProtoRestoreEntity> RestoreEntityVec { get; set; }

        /// <summary>
        /// Specifies the target type for the task. The field is only valid if the task has got a permit.
        /// </summary>
        /// <value>Specifies the target type for the task. The field is only valid if the task has got a permit.</value>
        [DataMember(Name="targetType", EmitDefaultValue=true)]
        public int? TargetType { get; set; }

        /// <summary>
        /// The type of environment this restore info pertains to.
        /// </summary>
        /// <value>The type of environment this restore info pertains to.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int? Type { get; set; }

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
            return this.Equals(input as RestoreInfoProto);
        }

        /// <summary>
        /// Returns true if RestoreInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoreInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoreInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostScriptStatus == input.PostScriptStatus ||
                    (this.PostScriptStatus != null &&
                    this.PostScriptStatus.Equals(input.PostScriptStatus))
                ) && 
                (
                    this.PreScriptStatus == input.PreScriptStatus ||
                    (this.PreScriptStatus != null &&
                    this.PreScriptStatus.Equals(input.PreScriptStatus))
                ) && 
                (
                    this.RestoreEntityVec == input.RestoreEntityVec ||
                    this.RestoreEntityVec != null &&
                    input.RestoreEntityVec != null &&
                    this.RestoreEntityVec.SequenceEqual(input.RestoreEntityVec)
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.PostScriptStatus != null)
                    hashCode = hashCode * 59 + this.PostScriptStatus.GetHashCode();
                if (this.PreScriptStatus != null)
                    hashCode = hashCode * 59 + this.PreScriptStatus.GetHashCode();
                if (this.RestoreEntityVec != null)
                    hashCode = hashCode * 59 + this.RestoreEntityVec.GetHashCode();
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}

