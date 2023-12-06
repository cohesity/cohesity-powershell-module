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
    /// App provides information about an application.
    /// </summary>
    [DataContract]
    public partial class App :  IEquatable<App>
    {
        /// <summary>
        /// Specifies app installation status. Specifies status of the app installation. kNotInstalled - App yet to be installed. kInstallInProgress - App installation is in progress. kInstalled - App is installed successfully and can be launched. kInstallFailed - App installation failed. kUninstallInProgress - App uninstallation is in progress. kUninstallFailed - App uninstallation failed. kDownloadNotStarted - App download has not started. kDownloadInProgress - App download in progress. kDownloadComplete - App download completed. kDownloadFailed - App download failed.
        /// </summary>
        /// <value>Specifies app installation status. Specifies status of the app installation. kNotInstalled - App yet to be installed. kInstallInProgress - App installation is in progress. kInstalled - App is installed successfully and can be launched. kInstallFailed - App installation failed. kUninstallInProgress - App uninstallation is in progress. kUninstallFailed - App uninstallation failed. kDownloadNotStarted - App download has not started. kDownloadInProgress - App download in progress. kDownloadComplete - App download completed. kDownloadFailed - App download failed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstallStateEnum
        {
            /// <summary>
            /// Enum KNotInstalled for value: kNotInstalled
            /// </summary>
            [EnumMember(Value = "kNotInstalled")]
            KNotInstalled = 1,

            /// <summary>
            /// Enum KInstallInProgress for value: kInstallInProgress
            /// </summary>
            [EnumMember(Value = "kInstallInProgress")]
            KInstallInProgress = 2,

            /// <summary>
            /// Enum KInstalled for value: kInstalled
            /// </summary>
            [EnumMember(Value = "kInstalled")]
            KInstalled = 3,

            /// <summary>
            /// Enum KInstallFailed for value: kInstallFailed
            /// </summary>
            [EnumMember(Value = "kInstallFailed")]
            KInstallFailed = 4,

            /// <summary>
            /// Enum KUninstallInProgress for value: kUninstallInProgress
            /// </summary>
            [EnumMember(Value = "kUninstallInProgress")]
            KUninstallInProgress = 5,

            /// <summary>
            /// Enum KUninstallFailed for value: kUninstallFailed
            /// </summary>
            [EnumMember(Value = "kUninstallFailed")]
            KUninstallFailed = 6,

            /// <summary>
            /// Enum KDownloadNotStarted for value: kDownloadNotStarted
            /// </summary>
            [EnumMember(Value = "kDownloadNotStarted")]
            KDownloadNotStarted = 7,

            /// <summary>
            /// Enum KDownloadInProgress for value: kDownloadInProgress
            /// </summary>
            [EnumMember(Value = "kDownloadInProgress")]
            KDownloadInProgress = 8,

            /// <summary>
            /// Enum KDownloadComplete for value: kDownloadComplete
            /// </summary>
            [EnumMember(Value = "kDownloadComplete")]
            KDownloadComplete = 9,

            /// <summary>
            /// Enum KDownloadFailed for value: kDownloadFailed
            /// </summary>
            [EnumMember(Value = "kDownloadFailed")]
            KDownloadFailed = 10

        }

        /// <summary>
        /// Specifies app installation status. Specifies status of the app installation. kNotInstalled - App yet to be installed. kInstallInProgress - App installation is in progress. kInstalled - App is installed successfully and can be launched. kInstallFailed - App installation failed. kUninstallInProgress - App uninstallation is in progress. kUninstallFailed - App uninstallation failed. kDownloadNotStarted - App download has not started. kDownloadInProgress - App download in progress. kDownloadComplete - App download completed. kDownloadFailed - App download failed.
        /// </summary>
        /// <value>Specifies app installation status. Specifies status of the app installation. kNotInstalled - App yet to be installed. kInstallInProgress - App installation is in progress. kInstalled - App is installed successfully and can be launched. kInstallFailed - App installation failed. kUninstallInProgress - App uninstallation is in progress. kUninstallFailed - App uninstallation failed. kDownloadNotStarted - App download has not started. kDownloadInProgress - App download in progress. kDownloadComplete - App download completed. kDownloadFailed - App download failed.</value>
        [DataMember(Name="installState", EmitDefaultValue=true)]
        public InstallStateEnum? InstallState { get; set; }
        /// <summary>
        /// Defines RequiredPrivileges
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequiredPrivilegesEnum
        {
            /// <summary>
            /// Enum KReadAccess for value: kReadAccess
            /// </summary>
            [EnumMember(Value = "kReadAccess")]
            KReadAccess = 1,

            /// <summary>
            /// Enum KReadWriteAccess for value: kReadWriteAccess
            /// </summary>
            [EnumMember(Value = "kReadWriteAccess")]
            KReadWriteAccess = 2,

            /// <summary>
            /// Enum KManagementAccess for value: kManagementAccess
            /// </summary>
            [EnumMember(Value = "kManagementAccess")]
            KManagementAccess = 3,

            /// <summary>
            /// Enum KAutoMountAccess for value: kAutoMountAccess
            /// </summary>
            [EnumMember(Value = "kAutoMountAccess")]
            KAutoMountAccess = 4,

            /// <summary>
            /// Enum KUnrestrictedAppUIAccess for value: kUnrestrictedAppUIAccess
            /// </summary>
            [EnumMember(Value = "kUnrestrictedAppUIAccess")]
            KUnrestrictedAppUIAccess = 5,

            /// <summary>
            /// Enum KAuditLogViewReadAccess for value: kAuditLogViewReadAccess
            /// </summary>
            [EnumMember(Value = "kAuditLogViewReadAccess")]
            KAuditLogViewReadAccess = 6,

            /// <summary>
            /// Enum KProtectedObjectAccess for value: kProtectedObjectAccess
            /// </summary>
            [EnumMember(Value = "kProtectedObjectAccess")]
            KProtectedObjectAccess = 7

        }


        /// <summary>
        /// Specifies privileges that are required for this app. App privilege information.  Specifies privileges that are required for this app. kReadAccess - App needs views for read access. kReadWriteAccess - App needs views for Read/write access. kManagementAccess - App needs management access via iris API. kAutoMountAccess - Whether to allow auto-mounting all the views. kUnrestrictedAppUIAccess - Whether app requires unrestricted UI access (i.e. without passing app access token in URL). kAuditLogViewReadAccess - Whether app requires read access to the internal audit log view. kProtectedObjectAccess - Whether app requires read access to protected objects.
        /// </summary>
        /// <value>Specifies privileges that are required for this app. App privilege information.  Specifies privileges that are required for this app. kReadAccess - App needs views for read access. kReadWriteAccess - App needs views for Read/write access. kManagementAccess - App needs management access via iris API. kAutoMountAccess - Whether to allow auto-mounting all the views. kUnrestrictedAppUIAccess - Whether app requires unrestricted UI access (i.e. without passing app access token in URL). kAuditLogViewReadAccess - Whether app requires read access to the internal audit log view. kProtectedObjectAccess - Whether app requires read access to protected objects.</value>
        [DataMember(Name="requiredPrivileges", EmitDefaultValue=true)]
        public List<RequiredPrivilegesEnum> RequiredPrivileges { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        /// <param name="appId">Specifies unique id allocated by the AppStore..</param>
        /// <param name="clusters">Specifies the list of clusters on which the app is installed for a particular account Id..</param>
        /// <param name="downloadProgressPct">Specifies app download progress percentage..</param>
        /// <param name="externalIpRequired">Specifies if an external ip is required for the app..</param>
        /// <param name="externalNetworks">List of external network information available for the app..</param>
        /// <param name="installState">Specifies app installation status. Specifies status of the app installation. kNotInstalled - App yet to be installed. kInstallInProgress - App installation is in progress. kInstalled - App is installed successfully and can be launched. kInstallFailed - App installation failed. kUninstallInProgress - App uninstallation is in progress. kUninstallFailed - App uninstallation failed. kDownloadNotStarted - App download has not started. kDownloadInProgress - App download in progress. kDownloadComplete - App download completed. kDownloadFailed - App download failed..</param>
        /// <param name="installTime">Specifies timestamp when the app was installed..</param>
        /// <param name="instanceSizes">List of applicable instance size specifications (e.g. small/medium/large) for the app. Used to determine container resources..</param>
        /// <param name="isLatest">Specifies whether the app currently installed on all clusters is the latest version or not..</param>
        /// <param name="latestVersion">Specifies application version assigned by the AppStore for the latest version of an app..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="requiredPrivileges">Specifies privileges that are required for this app. App privilege information.  Specifies privileges that are required for this app. kReadAccess - App needs views for read access. kReadWriteAccess - App needs views for Read/write access. kManagementAccess - App needs management access via iris API. kAutoMountAccess - Whether to allow auto-mounting all the views. kUnrestrictedAppUIAccess - Whether app requires unrestricted UI access (i.e. without passing app access token in URL). kAuditLogViewReadAccess - Whether app requires read access to the internal audit log view. kProtectedObjectAccess - Whether app requires read access to protected objects..</param>
        /// <param name="uninstallTime">Specifies timestamp when the app was uninstalled..</param>
        /// <param name="version">Specifies application version assigned by the AppStore..</param>
        /// <param name="vmNameInfoList">List of vm name info objects..</param>
        public App(long? appId = default(long?), List<ClusterInfo> clusters = default(List<ClusterInfo>), double? downloadProgressPct = default(double?), bool? externalIpRequired = default(bool?), List<ExternalNetworkInfo> externalNetworks = default(List<ExternalNetworkInfo>), InstallStateEnum? installState = default(InstallStateEnum?), long? installTime = default(long?), List<string> instanceSizes = default(List<string>), bool? isLatest = default(bool?), long? latestVersion = default(long?), AppMetadata metadata = default(AppMetadata), List<RequiredPrivilegesEnum> requiredPrivileges = default(List<RequiredPrivilegesEnum>), long? uninstallTime = default(long?), long? version = default(long?), List<VmNameInfo> vmNameInfoList = default(List<VmNameInfo>))
        {
            this.AppId = appId;
            this.Clusters = clusters;
            this.DownloadProgressPct = downloadProgressPct;
            this.ExternalIpRequired = externalIpRequired;
            this.ExternalNetworks = externalNetworks;
            this.InstallState = installState;
            this.InstallTime = installTime;
            this.InstanceSizes = instanceSizes;
            this.IsLatest = isLatest;
            this.LatestVersion = latestVersion;
            this.RequiredPrivileges = requiredPrivileges;
            this.UninstallTime = uninstallTime;
            this.Version = version;
            this.VmNameInfoList = vmNameInfoList;
            this.AppId = appId;
            this.Clusters = clusters;
            this.DownloadProgressPct = downloadProgressPct;
            this.ExternalIpRequired = externalIpRequired;
            this.ExternalNetworks = externalNetworks;
            this.InstallState = installState;
            this.InstallTime = installTime;
            this.InstanceSizes = instanceSizes;
            this.IsLatest = isLatest;
            this.LatestVersion = latestVersion;
            this.Metadata = metadata;
            this.RequiredPrivileges = requiredPrivileges;
            this.UninstallTime = uninstallTime;
            this.Version = version;
            this.VmNameInfoList = vmNameInfoList;
        }
        
        /// <summary>
        /// Specifies unique id allocated by the AppStore.
        /// </summary>
        /// <value>Specifies unique id allocated by the AppStore.</value>
        [DataMember(Name="appId", EmitDefaultValue=true)]
        public long? AppId { get; set; }

        /// <summary>
        /// Specifies the list of clusters on which the app is installed for a particular account Id.
        /// </summary>
        /// <value>Specifies the list of clusters on which the app is installed for a particular account Id.</value>
        [DataMember(Name="clusters", EmitDefaultValue=true)]
        public List<ClusterInfo> Clusters { get; set; }

        /// <summary>
        /// Specifies app download progress percentage.
        /// </summary>
        /// <value>Specifies app download progress percentage.</value>
        [DataMember(Name="downloadProgressPct", EmitDefaultValue=true)]
        public double? DownloadProgressPct { get; set; }

        /// <summary>
        /// Specifies if an external ip is required for the app.
        /// </summary>
        /// <value>Specifies if an external ip is required for the app.</value>
        [DataMember(Name="externalIpRequired", EmitDefaultValue=true)]
        public bool? ExternalIpRequired { get; set; }

        /// <summary>
        /// List of external network information available for the app.
        /// </summary>
        /// <value>List of external network information available for the app.</value>
        [DataMember(Name="externalNetworks", EmitDefaultValue=true)]
        public List<ExternalNetworkInfo> ExternalNetworks { get; set; }

        /// <summary>
        /// Specifies timestamp when the app was installed.
        /// </summary>
        /// <value>Specifies timestamp when the app was installed.</value>
        [DataMember(Name="installTime", EmitDefaultValue=true)]
        public long? InstallTime { get; set; }

        /// <summary>
        /// List of applicable instance size specifications (e.g. small/medium/large) for the app. Used to determine container resources.
        /// </summary>
        /// <value>List of applicable instance size specifications (e.g. small/medium/large) for the app. Used to determine container resources.</value>
        [DataMember(Name="instanceSizes", EmitDefaultValue=true)]
        public List<string> InstanceSizes { get; set; }

        /// <summary>
        /// Specifies whether the app currently installed on all clusters is the latest version or not.
        /// </summary>
        /// <value>Specifies whether the app currently installed on all clusters is the latest version or not.</value>
        [DataMember(Name="isLatest", EmitDefaultValue=true)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// Specifies application version assigned by the AppStore for the latest version of an app.
        /// </summary>
        /// <value>Specifies application version assigned by the AppStore for the latest version of an app.</value>
        [DataMember(Name="latestVersion", EmitDefaultValue=true)]
        public long? LatestVersion { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public AppMetadata Metadata { get; set; }

        /// <summary>
        /// Specifies timestamp when the app was uninstalled.
        /// </summary>
        /// <value>Specifies timestamp when the app was uninstalled.</value>
        [DataMember(Name="uninstallTime", EmitDefaultValue=true)]
        public long? UninstallTime { get; set; }

        /// <summary>
        /// Specifies application version assigned by the AppStore.
        /// </summary>
        /// <value>Specifies application version assigned by the AppStore.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public long? Version { get; set; }

        /// <summary>
        /// List of vm name info objects.
        /// </summary>
        /// <value>List of vm name info objects.</value>
        [DataMember(Name="vmNameInfoList", EmitDefaultValue=true)]
        public List<VmNameInfo> VmNameInfoList { get; set; }

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
            return this.Equals(input as App);
        }

        /// <summary>
        /// Returns true if App instances are equal
        /// </summary>
        /// <param name="input">Instance of App to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(App input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Clusters == input.Clusters ||
                    this.Clusters != null &&
                    input.Clusters != null &&
                    this.Clusters.SequenceEqual(input.Clusters)
                ) && 
                (
                    this.DownloadProgressPct == input.DownloadProgressPct ||
                    (this.DownloadProgressPct != null &&
                    this.DownloadProgressPct.Equals(input.DownloadProgressPct))
                ) && 
                (
                    this.ExternalIpRequired == input.ExternalIpRequired ||
                    (this.ExternalIpRequired != null &&
                    this.ExternalIpRequired.Equals(input.ExternalIpRequired))
                ) && 
                (
                    this.ExternalNetworks == input.ExternalNetworks ||
                    this.ExternalNetworks != null &&
                    input.ExternalNetworks != null &&
                    this.ExternalNetworks.SequenceEqual(input.ExternalNetworks)
                ) && 
                (
                    this.InstallState == input.InstallState ||
                    this.InstallState.Equals(input.InstallState)
                ) && 
                (
                    this.InstallTime == input.InstallTime ||
                    (this.InstallTime != null &&
                    this.InstallTime.Equals(input.InstallTime))
                ) && 
                (
                    this.InstanceSizes == input.InstanceSizes ||
                    this.InstanceSizes != null &&
                    input.InstanceSizes != null &&
                    this.InstanceSizes.SequenceEqual(input.InstanceSizes)
                ) && 
                (
                    this.IsLatest == input.IsLatest ||
                    (this.IsLatest != null &&
                    this.IsLatest.Equals(input.IsLatest))
                ) && 
                (
                    this.LatestVersion == input.LatestVersion ||
                    (this.LatestVersion != null &&
                    this.LatestVersion.Equals(input.LatestVersion))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.RequiredPrivileges == input.RequiredPrivileges ||
                    this.RequiredPrivileges.SequenceEqual(input.RequiredPrivileges)
                ) && 
                (
                    this.UninstallTime == input.UninstallTime ||
                    (this.UninstallTime != null &&
                    this.UninstallTime.Equals(input.UninstallTime))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VmNameInfoList == input.VmNameInfoList ||
                    this.VmNameInfoList != null &&
                    input.VmNameInfoList != null &&
                    this.VmNameInfoList.SequenceEqual(input.VmNameInfoList)
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
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Clusters != null)
                    hashCode = hashCode * 59 + this.Clusters.GetHashCode();
                if (this.DownloadProgressPct != null)
                    hashCode = hashCode * 59 + this.DownloadProgressPct.GetHashCode();
                if (this.ExternalIpRequired != null)
                    hashCode = hashCode * 59 + this.ExternalIpRequired.GetHashCode();
                if (this.ExternalNetworks != null)
                    hashCode = hashCode * 59 + this.ExternalNetworks.GetHashCode();
                hashCode = hashCode * 59 + this.InstallState.GetHashCode();
                if (this.InstallTime != null)
                    hashCode = hashCode * 59 + this.InstallTime.GetHashCode();
                if (this.InstanceSizes != null)
                    hashCode = hashCode * 59 + this.InstanceSizes.GetHashCode();
                if (this.IsLatest != null)
                    hashCode = hashCode * 59 + this.IsLatest.GetHashCode();
                if (this.LatestVersion != null)
                    hashCode = hashCode * 59 + this.LatestVersion.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                hashCode = hashCode * 59 + this.RequiredPrivileges.GetHashCode();
                if (this.UninstallTime != null)
                    hashCode = hashCode * 59 + this.UninstallTime.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VmNameInfoList != null)
                    hashCode = hashCode * 59 + this.VmNameInfoList.GetHashCode();
                return hashCode;
            }
        }

    }

}

