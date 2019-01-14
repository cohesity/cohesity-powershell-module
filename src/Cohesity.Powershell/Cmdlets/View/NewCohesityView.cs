// Copyright 2018 Cohesity Inc.
using Cohesity.Powershell.Common;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.View
{
    /// <summary>
    /// <para type="synopsis">
    /// Creates a new Cohesity View.
    /// </para>
    /// <para type="description">
    /// Returns the created Cohesity View.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   New-CohesityView -Name 'Test-View' -AccessProtocol KS3Only -StorageDomainName 'Test-Storage-Domain'
    ///   </code>
    ///   <para>
    ///   Creates a new Cohesity View only accessible via S3 protocol using Storage Domain with name 'Test-Storage-Domain'.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.New, "CohesityView")]
    [OutputType(typeof(Models.View))]
    public class NewCohesityView: PSCmdlet
    {
        private Session Session
        {
            get
            {
                var result = SessionState.PSVariable.GetValue("Session") as Session;
                if (result == null)
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        #region Params

        /// <summary>
        /// <para type="description">
        /// Specifies the name of the View to be created.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string Name { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the description for this View.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Description { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies the supported protocols for this View.
        /// If not specified, default is kAll which means all protocols are supported.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateSet("KAll", "KNFSOnly", "KSMBOnly", "KS3Only")]
        public Models.View.ProtocolAccessEnum AccessProtocol { get; set; }
            = Models.View.ProtocolAccessEnum.KAll;

        /// <summary>
        /// <para type="description">
        /// Specifies the Quality of Service (QoS) Policy for this View.
        /// If not specified, the default is 'Backup Target Low'
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public string QosPolicy { get; set; } = "Backup Target Low";

        /// <summary>
        /// <para type="description">
        /// Specifies the Storage Domain name for this View.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty()]
        public string StorageDomainName { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies an optional quota limit on the usage allowed for this view. This limit is specified in bytes. If no value is specified, there is no limit.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? LogicalQuotaInBytes { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specifies if an alert should be triggered when the usage of this view exceeds this quota limit.
        /// This limit is optional and is specified in bytes. If no value is specified, there is no limit.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? AlertQuotaInBytes { get; set; } = null;

        /// <summary>
        /// <para type="description">
        /// Specifies whether to support case insensitive file/folder names.
        /// This is not enabled by default.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter CaseInsensitiveNames { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether the shares from this View are browsable.
        /// This is not enabled by default.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter BrowsableShares { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether SMB Access Based Enumeration is enabled.
        /// This is not enabled by default.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter SmbAccessBasedEnumeration { get; set; }

        /// <summary>
        /// <para type="description">
        /// Specifies whether inline deduplication and compression settings inherited from the Storage Domain should be disabled for this View.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter DisableInlineDedupAndCompression { get; set; }

        #endregion

        #region Processing

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            var domain = RestApiCommon.GetStorageDomainByName(Session.ApiClient, StorageDomainName);
            long storageDomainId = (long)domain.Id;

            var request = new Models.CreateViewRequest(name: Name, viewBoxId: storageDomainId)
            {
                Description = Description,
                ProtocolAccess = (Models.CreateViewRequest.ProtocolAccessEnum)AccessProtocol,
                Qos = new Models.QoS(principalName: QosPolicy),
                CaseInsensitiveNamesEnabled = CaseInsensitiveNames.IsPresent,
                EnableSmbViewDiscovery = BrowsableShares.IsPresent,
                EnableSmbAccessBasedEnumeration = SmbAccessBasedEnumeration.IsPresent,
                StoragePolicyOverride = new Models.StoragePolicyOverride(DisableInlineDedupAndCompression.IsPresent)
            };

            if (LogicalQuotaInBytes != null || AlertQuotaInBytes != null)
            {
                request.LogicalQuota = new Models.QuotaPolicy();

                if(LogicalQuotaInBytes != null)
                {
                    request.LogicalQuota.HardLimitBytes = LogicalQuotaInBytes;
                }

                if (AlertQuotaInBytes != null)
                {
                    request.LogicalQuota.AlertLimitBytes = AlertQuotaInBytes;
                }
            }

            var preparedUrl = $"/public/views";
            var result = Session.ApiClient.Post<Models.View>(preparedUrl, request);
            WriteObject(result);
        }

        #endregion
    }
}
