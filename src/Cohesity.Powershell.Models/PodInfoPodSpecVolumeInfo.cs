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
    /// Contains information about volumes of different types that can be mounted to a pod. Reference: https://kubernetes.io/docs/reference/generated/kubernetes-api/v1.19/
    /// </summary>
    [DataContract]
    public partial class PodInfoPodSpecVolumeInfo :  IEquatable<PodInfoPodSpecVolumeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodInfoPodSpecVolumeInfo" /> class.
        /// </summary>
        /// <param name="awsElasticBlockStore">awsElasticBlockStore.</param>
        /// <param name="azureDisk">azureDisk.</param>
        /// <param name="azureFile">azureFile.</param>
        /// <param name="cephfs">cephfs.</param>
        /// <param name="cinder">cinder.</param>
        /// <param name="configMap">configMap.</param>
        /// <param name="csi">csi.</param>
        /// <param name="downwardApi">downwardApi.</param>
        /// <param name="emptyDir">emptyDir.</param>
        /// <param name="ephemeral">ephemeral.</param>
        /// <param name="fc">fc.</param>
        /// <param name="flexVolume">flexVolume.</param>
        /// <param name="flocker">flocker.</param>
        /// <param name="gcePersistentDisk">gcePersistentDisk.</param>
        /// <param name="glusterfs">glusterfs.</param>
        /// <param name="hostPath">hostPath.</param>
        /// <param name="iscsi">iscsi.</param>
        /// <param name="local">local.</param>
        /// <param name="name">Name of the volume..</param>
        /// <param name="nfs">nfs.</param>
        /// <param name="persistentVolumeClaim">persistentVolumeClaim.</param>
        /// <param name="photonPersistentDisk">photonPersistentDisk.</param>
        /// <param name="portworxVolume">portworxVolume.</param>
        /// <param name="projected">projected.</param>
        /// <param name="quobyte">quobyte.</param>
        /// <param name="rbd">rbd.</param>
        /// <param name="scaleIo">scaleIo.</param>
        /// <param name="secret">secret.</param>
        /// <param name="storageos">storageos.</param>
        /// <param name="vsphereVolume">vsphereVolume.</param>
        public PodInfoPodSpecVolumeInfo(PodInfoPodSpecVolumeInfoAWSEBS awsElasticBlockStore = default(PodInfoPodSpecVolumeInfoAWSEBS), PodInfoPodSpecVolumeInfoAzureDisk azureDisk = default(PodInfoPodSpecVolumeInfoAzureDisk), PodInfoPodSpecVolumeInfoAzureFile azureFile = default(PodInfoPodSpecVolumeInfoAzureFile), PodInfoPodSpecVolumeInfoCephfs cephfs = default(PodInfoPodSpecVolumeInfoCephfs), PodInfoPodSpecVolumeInfoCinder cinder = default(PodInfoPodSpecVolumeInfoCinder), PodInfoPodSpecVolumeInfoConfigMap configMap = default(PodInfoPodSpecVolumeInfoConfigMap), PodInfoPodSpecVolumeInfoCSI csi = default(PodInfoPodSpecVolumeInfoCSI), PodInfoPodSpecVolumeInfoDownwardAPI downwardApi = default(PodInfoPodSpecVolumeInfoDownwardAPI), PodInfoPodSpecVolumeInfoEmptyDir emptyDir = default(PodInfoPodSpecVolumeInfoEmptyDir), PodInfoPodSpecVolumeInfoEphemeralVolumeSource ephemeral = default(PodInfoPodSpecVolumeInfoEphemeralVolumeSource), PodInfoPodSpecVolumeInfoFC fc = default(PodInfoPodSpecVolumeInfoFC), PodInfoPodSpecVolumeInfoFlex flexVolume = default(PodInfoPodSpecVolumeInfoFlex), PodInfoPodSpecVolumeInfoFlocker flocker = default(PodInfoPodSpecVolumeInfoFlocker), PodInfoPodSpecVolumeInfoGcePersistentDisk gcePersistentDisk = default(PodInfoPodSpecVolumeInfoGcePersistentDisk), PodInfoPodSpecVolumeInfoGlusterFs glusterfs = default(PodInfoPodSpecVolumeInfoGlusterFs), PodInfoPodSpecVolumeInfoHostPath hostPath = default(PodInfoPodSpecVolumeInfoHostPath), PodInfoPodSpecVolumeInfoISCSI iscsi = default(PodInfoPodSpecVolumeInfoISCSI), PodInfoPodSpecVolumeInfoLocal local = default(PodInfoPodSpecVolumeInfoLocal), string name = default(string), PodInfoPodSpecVolumeInfoNFS nfs = default(PodInfoPodSpecVolumeInfoNFS), PodInfoPodSpecVolumeInfoPVC persistentVolumeClaim = default(PodInfoPodSpecVolumeInfoPVC), PodInfoPodSpecVolumeInfoPhotonPersistentDisk photonPersistentDisk = default(PodInfoPodSpecVolumeInfoPhotonPersistentDisk), PodInfoPodSpecVolumeInfoPortworx portworxVolume = default(PodInfoPodSpecVolumeInfoPortworx), PodInfoPodSpecVolumeInfoProjected projected = default(PodInfoPodSpecVolumeInfoProjected), PodInfoPodSpecVolumeInfoQuobyte quobyte = default(PodInfoPodSpecVolumeInfoQuobyte), PodInfoPodSpecVolumeInfoRBD rbd = default(PodInfoPodSpecVolumeInfoRBD), PodInfoPodSpecVolumeInfoScaleIO scaleIo = default(PodInfoPodSpecVolumeInfoScaleIO), PodInfoPodSpecVolumeInfoConfigMap secret = default(PodInfoPodSpecVolumeInfoConfigMap), PodInfoPodSpecVolumeInfoStorageOS storageos = default(PodInfoPodSpecVolumeInfoStorageOS), PodInfoPodSpecVolumeInfoVsphereVirtualDisk vsphereVolume = default(PodInfoPodSpecVolumeInfoVsphereVirtualDisk))
        {
            this.AwsElasticBlockStore = awsElasticBlockStore;
            this.AzureDisk = azureDisk;
            this.AzureFile = azureFile;
            this.Cephfs = cephfs;
            this.Cinder = cinder;
            this.ConfigMap = configMap;
            this.Csi = csi;
            this.DownwardApi = downwardApi;
            this.EmptyDir = emptyDir;
            this.Ephemeral = ephemeral;
            this.Fc = fc;
            this.FlexVolume = flexVolume;
            this.Flocker = flocker;
            this.GcePersistentDisk = gcePersistentDisk;
            this.Glusterfs = glusterfs;
            this.HostPath = hostPath;
            this.Iscsi = iscsi;
            this.Local = local;
            this.Name = name;
            this.Nfs = nfs;
            this.PersistentVolumeClaim = persistentVolumeClaim;
            this.PhotonPersistentDisk = photonPersistentDisk;
            this.PortworxVolume = portworxVolume;
            this.Projected = projected;
            this.Quobyte = quobyte;
            this.Rbd = rbd;
            this.ScaleIo = scaleIo;
            this.Secret = secret;
            this.Storageos = storageos;
            this.VsphereVolume = vsphereVolume;
        }
        
        /// <summary>
        /// Gets or Sets AwsElasticBlockStore
        /// </summary>
        [DataMember(Name="awsElasticBlockStore", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoAWSEBS AwsElasticBlockStore { get; set; }

        /// <summary>
        /// Gets or Sets AzureDisk
        /// </summary>
        [DataMember(Name="azureDisk", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoAzureDisk AzureDisk { get; set; }

        /// <summary>
        /// Gets or Sets AzureFile
        /// </summary>
        [DataMember(Name="azureFile", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoAzureFile AzureFile { get; set; }

        /// <summary>
        /// Gets or Sets Cephfs
        /// </summary>
        [DataMember(Name="cephfs", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoCephfs Cephfs { get; set; }

        /// <summary>
        /// Gets or Sets Cinder
        /// </summary>
        [DataMember(Name="cinder", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoCinder Cinder { get; set; }

        /// <summary>
        /// Gets or Sets ConfigMap
        /// </summary>
        [DataMember(Name="configMap", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoConfigMap ConfigMap { get; set; }

        /// <summary>
        /// Gets or Sets Csi
        /// </summary>
        [DataMember(Name="csi", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoCSI Csi { get; set; }

        /// <summary>
        /// Gets or Sets DownwardApi
        /// </summary>
        [DataMember(Name="downwardApi", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoDownwardAPI DownwardApi { get; set; }

        /// <summary>
        /// Gets or Sets EmptyDir
        /// </summary>
        [DataMember(Name="emptyDir", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoEmptyDir EmptyDir { get; set; }

        /// <summary>
        /// Gets or Sets Ephemeral
        /// </summary>
        [DataMember(Name="ephemeral", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoEphemeralVolumeSource Ephemeral { get; set; }

        /// <summary>
        /// Gets or Sets Fc
        /// </summary>
        [DataMember(Name="fc", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoFC Fc { get; set; }

        /// <summary>
        /// Gets or Sets FlexVolume
        /// </summary>
        [DataMember(Name="flexVolume", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoFlex FlexVolume { get; set; }

        /// <summary>
        /// Gets or Sets Flocker
        /// </summary>
        [DataMember(Name="flocker", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoFlocker Flocker { get; set; }

        /// <summary>
        /// Gets or Sets GcePersistentDisk
        /// </summary>
        [DataMember(Name="gcePersistentDisk", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoGcePersistentDisk GcePersistentDisk { get; set; }

        /// <summary>
        /// Gets or Sets Glusterfs
        /// </summary>
        [DataMember(Name="glusterfs", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoGlusterFs Glusterfs { get; set; }

        /// <summary>
        /// Gets or Sets HostPath
        /// </summary>
        [DataMember(Name="hostPath", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoHostPath HostPath { get; set; }

        /// <summary>
        /// Gets or Sets Iscsi
        /// </summary>
        [DataMember(Name="iscsi", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoISCSI Iscsi { get; set; }

        /// <summary>
        /// Gets or Sets Local
        /// </summary>
        [DataMember(Name="local", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoLocal Local { get; set; }

        /// <summary>
        /// Name of the volume.
        /// </summary>
        /// <value>Name of the volume.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Nfs
        /// </summary>
        [DataMember(Name="nfs", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoNFS Nfs { get; set; }

        /// <summary>
        /// Gets or Sets PersistentVolumeClaim
        /// </summary>
        [DataMember(Name="persistentVolumeClaim", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoPVC PersistentVolumeClaim { get; set; }

        /// <summary>
        /// Gets or Sets PhotonPersistentDisk
        /// </summary>
        [DataMember(Name="photonPersistentDisk", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoPhotonPersistentDisk PhotonPersistentDisk { get; set; }

        /// <summary>
        /// Gets or Sets PortworxVolume
        /// </summary>
        [DataMember(Name="portworxVolume", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoPortworx PortworxVolume { get; set; }

        /// <summary>
        /// Gets or Sets Projected
        /// </summary>
        [DataMember(Name="projected", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoProjected Projected { get; set; }

        /// <summary>
        /// Gets or Sets Quobyte
        /// </summary>
        [DataMember(Name="quobyte", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoQuobyte Quobyte { get; set; }

        /// <summary>
        /// Gets or Sets Rbd
        /// </summary>
        [DataMember(Name="rbd", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoRBD Rbd { get; set; }

        /// <summary>
        /// Gets or Sets ScaleIo
        /// </summary>
        [DataMember(Name="scaleIo", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoScaleIO ScaleIo { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoConfigMap Secret { get; set; }

        /// <summary>
        /// Gets or Sets Storageos
        /// </summary>
        [DataMember(Name="storageos", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoStorageOS Storageos { get; set; }

        /// <summary>
        /// Gets or Sets VsphereVolume
        /// </summary>
        [DataMember(Name="vsphereVolume", EmitDefaultValue=false)]
        public PodInfoPodSpecVolumeInfoVsphereVirtualDisk VsphereVolume { get; set; }

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
            return this.Equals(input as PodInfoPodSpecVolumeInfo);
        }

        /// <summary>
        /// Returns true if PodInfoPodSpecVolumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PodInfoPodSpecVolumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodInfoPodSpecVolumeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsElasticBlockStore == input.AwsElasticBlockStore ||
                    (this.AwsElasticBlockStore != null &&
                    this.AwsElasticBlockStore.Equals(input.AwsElasticBlockStore))
                ) && 
                (
                    this.AzureDisk == input.AzureDisk ||
                    (this.AzureDisk != null &&
                    this.AzureDisk.Equals(input.AzureDisk))
                ) && 
                (
                    this.AzureFile == input.AzureFile ||
                    (this.AzureFile != null &&
                    this.AzureFile.Equals(input.AzureFile))
                ) && 
                (
                    this.Cephfs == input.Cephfs ||
                    (this.Cephfs != null &&
                    this.Cephfs.Equals(input.Cephfs))
                ) && 
                (
                    this.Cinder == input.Cinder ||
                    (this.Cinder != null &&
                    this.Cinder.Equals(input.Cinder))
                ) && 
                (
                    this.ConfigMap == input.ConfigMap ||
                    (this.ConfigMap != null &&
                    this.ConfigMap.Equals(input.ConfigMap))
                ) && 
                (
                    this.Csi == input.Csi ||
                    (this.Csi != null &&
                    this.Csi.Equals(input.Csi))
                ) && 
                (
                    this.DownwardApi == input.DownwardApi ||
                    (this.DownwardApi != null &&
                    this.DownwardApi.Equals(input.DownwardApi))
                ) && 
                (
                    this.EmptyDir == input.EmptyDir ||
                    (this.EmptyDir != null &&
                    this.EmptyDir.Equals(input.EmptyDir))
                ) && 
                (
                    this.Ephemeral == input.Ephemeral ||
                    (this.Ephemeral != null &&
                    this.Ephemeral.Equals(input.Ephemeral))
                ) && 
                (
                    this.Fc == input.Fc ||
                    (this.Fc != null &&
                    this.Fc.Equals(input.Fc))
                ) && 
                (
                    this.FlexVolume == input.FlexVolume ||
                    (this.FlexVolume != null &&
                    this.FlexVolume.Equals(input.FlexVolume))
                ) && 
                (
                    this.Flocker == input.Flocker ||
                    (this.Flocker != null &&
                    this.Flocker.Equals(input.Flocker))
                ) && 
                (
                    this.GcePersistentDisk == input.GcePersistentDisk ||
                    (this.GcePersistentDisk != null &&
                    this.GcePersistentDisk.Equals(input.GcePersistentDisk))
                ) && 
                (
                    this.Glusterfs == input.Glusterfs ||
                    (this.Glusterfs != null &&
                    this.Glusterfs.Equals(input.Glusterfs))
                ) && 
                (
                    this.HostPath == input.HostPath ||
                    (this.HostPath != null &&
                    this.HostPath.Equals(input.HostPath))
                ) && 
                (
                    this.Iscsi == input.Iscsi ||
                    (this.Iscsi != null &&
                    this.Iscsi.Equals(input.Iscsi))
                ) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Nfs == input.Nfs ||
                    (this.Nfs != null &&
                    this.Nfs.Equals(input.Nfs))
                ) && 
                (
                    this.PersistentVolumeClaim == input.PersistentVolumeClaim ||
                    (this.PersistentVolumeClaim != null &&
                    this.PersistentVolumeClaim.Equals(input.PersistentVolumeClaim))
                ) && 
                (
                    this.PhotonPersistentDisk == input.PhotonPersistentDisk ||
                    (this.PhotonPersistentDisk != null &&
                    this.PhotonPersistentDisk.Equals(input.PhotonPersistentDisk))
                ) && 
                (
                    this.PortworxVolume == input.PortworxVolume ||
                    (this.PortworxVolume != null &&
                    this.PortworxVolume.Equals(input.PortworxVolume))
                ) && 
                (
                    this.Projected == input.Projected ||
                    (this.Projected != null &&
                    this.Projected.Equals(input.Projected))
                ) && 
                (
                    this.Quobyte == input.Quobyte ||
                    (this.Quobyte != null &&
                    this.Quobyte.Equals(input.Quobyte))
                ) && 
                (
                    this.Rbd == input.Rbd ||
                    (this.Rbd != null &&
                    this.Rbd.Equals(input.Rbd))
                ) && 
                (
                    this.ScaleIo == input.ScaleIo ||
                    (this.ScaleIo != null &&
                    this.ScaleIo.Equals(input.ScaleIo))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Storageos == input.Storageos ||
                    (this.Storageos != null &&
                    this.Storageos.Equals(input.Storageos))
                ) && 
                (
                    this.VsphereVolume == input.VsphereVolume ||
                    (this.VsphereVolume != null &&
                    this.VsphereVolume.Equals(input.VsphereVolume))
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
                if (this.AwsElasticBlockStore != null)
                    hashCode = hashCode * 59 + this.AwsElasticBlockStore.GetHashCode();
                if (this.AzureDisk != null)
                    hashCode = hashCode * 59 + this.AzureDisk.GetHashCode();
                if (this.AzureFile != null)
                    hashCode = hashCode * 59 + this.AzureFile.GetHashCode();
                if (this.Cephfs != null)
                    hashCode = hashCode * 59 + this.Cephfs.GetHashCode();
                if (this.Cinder != null)
                    hashCode = hashCode * 59 + this.Cinder.GetHashCode();
                if (this.ConfigMap != null)
                    hashCode = hashCode * 59 + this.ConfigMap.GetHashCode();
                if (this.Csi != null)
                    hashCode = hashCode * 59 + this.Csi.GetHashCode();
                if (this.DownwardApi != null)
                    hashCode = hashCode * 59 + this.DownwardApi.GetHashCode();
                if (this.EmptyDir != null)
                    hashCode = hashCode * 59 + this.EmptyDir.GetHashCode();
                if (this.Ephemeral != null)
                    hashCode = hashCode * 59 + this.Ephemeral.GetHashCode();
                if (this.Fc != null)
                    hashCode = hashCode * 59 + this.Fc.GetHashCode();
                if (this.FlexVolume != null)
                    hashCode = hashCode * 59 + this.FlexVolume.GetHashCode();
                if (this.Flocker != null)
                    hashCode = hashCode * 59 + this.Flocker.GetHashCode();
                if (this.GcePersistentDisk != null)
                    hashCode = hashCode * 59 + this.GcePersistentDisk.GetHashCode();
                if (this.Glusterfs != null)
                    hashCode = hashCode * 59 + this.Glusterfs.GetHashCode();
                if (this.HostPath != null)
                    hashCode = hashCode * 59 + this.HostPath.GetHashCode();
                if (this.Iscsi != null)
                    hashCode = hashCode * 59 + this.Iscsi.GetHashCode();
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nfs != null)
                    hashCode = hashCode * 59 + this.Nfs.GetHashCode();
                if (this.PersistentVolumeClaim != null)
                    hashCode = hashCode * 59 + this.PersistentVolumeClaim.GetHashCode();
                if (this.PhotonPersistentDisk != null)
                    hashCode = hashCode * 59 + this.PhotonPersistentDisk.GetHashCode();
                if (this.PortworxVolume != null)
                    hashCode = hashCode * 59 + this.PortworxVolume.GetHashCode();
                if (this.Projected != null)
                    hashCode = hashCode * 59 + this.Projected.GetHashCode();
                if (this.Quobyte != null)
                    hashCode = hashCode * 59 + this.Quobyte.GetHashCode();
                if (this.Rbd != null)
                    hashCode = hashCode * 59 + this.Rbd.GetHashCode();
                if (this.ScaleIo != null)
                    hashCode = hashCode * 59 + this.ScaleIo.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Storageos != null)
                    hashCode = hashCode * 59 + this.Storageos.GetHashCode();
                if (this.VsphereVolume != null)
                    hashCode = hashCode * 59 + this.VsphereVolume.GetHashCode();
                return hashCode;
            }
        }

    }

}

