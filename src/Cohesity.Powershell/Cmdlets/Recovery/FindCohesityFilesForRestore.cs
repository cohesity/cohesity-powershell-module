// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Model;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.Recovery
{
    /// <summary>
    /// <para type="synopsis">
    /// Finds a list of files and folders for restore based on the specified parameters.
    /// </para>
    /// <para type="description">
    /// If no search pattern or filter parameters are specified, all files and folders currently found on the Cohesity Cluster are returned.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Find-CohesityFilesForRestore -Search "*txt"
    ///   </code>
    ///   <para>
    ///   Returns only the files and folders that match the search pattern "txt".
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Find, "CohesityFilesForRestore")]
    [OutputType(typeof(FileSearchResult))]
    public class FindCohesityFilesForRestore : PSCmdlet
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
        public Model.ProtectionJob.EnvironmentEnum[] Environments { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by folders or files.
        /// If true, only folders are returned.
        /// If false, only files are returned.
        /// If not specified, both files and folders are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public bool? FolderOnly { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by searching for sub-strings in the item name.
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
        public long? StartTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by backup completion time by specify a backup completion start and end times.
        /// Specified as a Unix epoch Timestamp (in microseconds).
        /// Only items created by backups that completed between the specified start and end times are returned.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of protection job ids.Only items backed up by the specified jobs are listed.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] JobIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by source ids. Only files and folders found in the listed sources (such as VMs) are returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] SourceIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of registered source ids. Only items from the listed registered sources are returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] RegisteredSourceIds { get; set; }

        /// <summary>
        /// <para type="description">
        /// Filter by a list of storage domain (view box) ids. Only items stored in the listed domains (view boxes) are returned.
        /// </para> 
        /// </summary>
        [Parameter(Mandatory = false)]
        public long[] StorageDomainIds { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            var queries = new Dictionary<string, string>();

            if (StartTime.HasValue)
            {
                if(false == IsValidTime(StartTime))
                {
                    WriteObject("Invalid start time : "+ StartTime.ToString());
                    return;
                }
                queries.Add("startTimeUsecs", StartTime.ToString());
            }

            if (EndTime.HasValue)
            {
                if (false == IsValidTime(EndTime))
                {
                    WriteObject("Invalid end time : " + EndTime.ToString());
                    return;
                }
                queries.Add("endTimeUsecs", EndTime.ToString());
            }

            if (Search != null)
                queries.Add("search", Search);

            if (FolderOnly != null && FolderOnly.HasValue)
                queries.Add("folderOnly", FolderOnly.ToString());

            if (Environments != null && Environments.Any())
            {
                List<string> envs = Environments.ToList().ConvertAll<string>(x => x.ToString().First().ToString().ToLower() + x.ToString().Substring(1));
                queries.Add("environments", string.Join(",", envs));
            }

            if (JobIds != null && JobIds.Any())
                queries.Add("jobIds", string.Join(",", JobIds));

            if (SourceIds != null && SourceIds.Any())
                queries.Add("sourceIds", string.Join(",", SourceIds));

            if (RegisteredSourceIds != null && RegisteredSourceIds.Any())
                queries.Add("registeredSourceIds", string.Join(",", RegisteredSourceIds));

            if (StorageDomainIds != null && StorageDomainIds.Any())
                queries.Add("viewBoxIds", string.Join(",", StorageDomainIds));

            var queryString = string.Empty;
            if (queries.Any())
                queryString = "?" + string.Join("&", queries.Select(q => $"{q.Key}={q.Value}"));

            var url = $"/public/restore/files{queryString}";
            var result = Session.ApiClient.Get<FileSearchResults>(url);
            WriteObject(result.Files, true);
        }

        private bool IsValidTime(long? time)
        {
            bool valid = true;
            try
            {
                RestApiCommon.ConvertUsecsToDateTime((long)time);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
    }
}
