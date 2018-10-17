// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Models;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Finds a list of objects (VMs and Databases) for restore based on the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no search pattern or filter parameters are specified, all objects currently found on the Cohesity Cluster are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Find-CohesityObjectsForRestore -Search "linux"
    ///   </code>
    ///   <para>
    ///   Returns only the objects that match the search pattern "linux".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Find, "CohesityObjectsForRestore")]
    [OutputType(typeof(ObjectSnapshotInfo))]
    public class FindCohesityObjectsForRestore : PSCmdlet
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

        /// <summary>
        /// <para type="description">
        /// Filter by environment types such as kVMware, kView, kSQL, etc. 
        /// Only jobs protecting the specified environment types are returned. 
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by searching for sub-strings in the object name.
        /// The specified string can match any part of the name.
        /// For example: “vm” or “123” both match the name of "vm-123".
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty()]
        public string Search { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by backup completion time by specifying a backup completion start and end times.
        /// Specified as a Unix epoch Timestamp (in microseconds).
        /// Only items created by backups that completed between the specified start and end times are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by backup completion time by specify a backup completion start and end times.
        /// Specified as a Unix epoch Timestamp (in microseconds).
        /// Only items created by backups that completed between the specified start and end times are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of protection job ids. Only objects backed up by the specified jobs are listed.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] JobIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of registered source ids. Only objects from the listed registered sources are returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] RegisteredSourceIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of storage domain (view box) ids. Only objects stored in the listed domains (view boxes) are returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public int[] StorageDomainIds { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var queries = new Dictionary<string, string>();

            if (StartTime.HasValue)
                queries.Add("startTimeUsecs", StartTime.ToString());

            if (EndTime.HasValue)
                queries.Add("endTimeUsecs", EndTime.ToString());

            if(Search != null)
                queries.Add("search", Search);

            if (Environments != null && Environments.Any())
                queries.Add("environments", string.Join(",", Environments));

            if (JobIds != null && JobIds.Any())
                queries.Add("jobIds", string.Join(",", JobIds));

            if (RegisteredSourceIds != null && RegisteredSourceIds.Any())
                queries.Add("registeredSourceIds", string.Join(",", RegisteredSourceIds));

            if (StorageDomainIds != null && StorageDomainIds.Any())
                queries.Add("viewBoxIds", string.Join(",", StorageDomainIds));

            var queryString = string.Empty;
            if (queries.Any())
                queryString = "?" + string.Join("&", queries.Select(q => $"{q.Key}={q.Value}"));

            var url = $"/public/restore/objects{queryString}";
            var result = Session.ApiClient.Get<ObjectSearchResults>(url);
            WriteObject(result.ObjectSnapshotInfo, true);
        }
    }
}
