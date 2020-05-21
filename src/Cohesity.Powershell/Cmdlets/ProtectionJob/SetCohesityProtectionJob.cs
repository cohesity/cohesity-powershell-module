// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Management.Automation;
using Cohesity.Powershell.Common;
using Cohesity.Model;

namespace Cohesity.Powershell.Cmdlets.ProtectionJob
{
    // PUT public/protectionJobs/{id}

    /// <summary>
    /// <para type="synopsis">
    /// Updates a protection job.
    /// </para>
    /// <para type="description">
    /// Returns the updated protection job.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Set-CohesityProtectionJob -ProtectionJob $job
    ///   </code>
    ///   <para>
    ///   Updates a protection job with the specified parameters.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Set, "CohesityProtectionJob")]
    [OutputType(typeof(Model.ProtectionJob))]
    public class SetCohesityProtectionJob : PSCmdlet
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
        /// The updated protection job.
        /// </para>
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public Model.ProtectionJob ProtectionJob { get; set; } = null;

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
            if(ProtectionJob.Environment == Model.ProtectionJob.EnvironmentEnum.KPhysicalFiles)
            {
                var job = RestApiCommon.GetProtectionJobById(Session.ApiClient,ProtectionJob.Id.Value);
                if(null != job)
                {
                    if(null != job.SourceSpecialParameters)
                    {
                        // assuming that there will be at least one source exists in the job and the job has ran at least once
                        PhysicalProtectionSource.HostTypeEnum hostType = (PhysicalProtectionSource.HostTypeEnum)
                            job.LastRun.BackupRun.SourceBackupStatus[0].Source.PhysicalProtectionSource.HostType;

                        List<SourceSpecialParameter> resp = ConstructSourceSpecialParameters(hostType,ProtectionJob.SourceIds, job.SourceIds);
                        ProtectionJob.SourceSpecialParameters.AddRange(resp);
                    }
                }
            }
            // PUT public/protectionJobs/{id}
            var preparedUrl = $"/public/protectionJobs/{ProtectionJob.Id.ToString()}";
            var result = Session.ApiClient.Put<Model.ProtectionJob>(preparedUrl, ProtectionJob);
            WriteObject(result);
        }

        private List<SourceSpecialParameter> ConstructSourceSpecialParameters(PhysicalProtectionSource.HostTypeEnum hostType,List<long> newSourceIds, List<long> existingSourceIds)
        {
            List<SourceSpecialParameter> ret = new List<SourceSpecialParameter>();
            foreach (long item in newSourceIds)
            {
                if(false == existingSourceIds.Contains(item))
                {
                    var sourceSpecialParameter = new SourceSpecialParameter();
                    sourceSpecialParameter.SourceId = item;
                    sourceSpecialParameter.PhysicalSpecialParameters = new Model.PhysicalSpecialParameters();
                    sourceSpecialParameter.PhysicalSpecialParameters.FilePaths = new System.Collections.Generic.List<FilePathParameters>();
                    if(hostType == PhysicalProtectionSource.HostTypeEnum.KWindows)
                    {
                        sourceSpecialParameter.PhysicalSpecialParameters.UsesSkipNestedVolumesVec = true;
                        sourceSpecialParameter.PhysicalSpecialParameters.FilePaths.Add(new FilePathParameters("/C/"));

                    }
                    if (hostType == PhysicalProtectionSource.HostTypeEnum.KLinux)
                    {
                        sourceSpecialParameter.PhysicalSpecialParameters.FilePaths.Add(new FilePathParameters("/",null,true));
                    }
                    ret.Add(sourceSpecialParameter);
                }
            }
            return ret;
        }

        #endregion

    }
}
