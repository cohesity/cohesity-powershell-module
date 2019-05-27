// Copyright 2018 Cohesity Inc.
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Cohesity.Powershell.Common;

namespace Cohesity.Powershell.Cmdlets.ProtectionSource
{
    /// <summary>
    /// <para type="synopsis">
    /// Gets a list of the MS SQL objects known to the Cohesity Cluster.
    /// </para>
    /// <para type="description">
    /// Returns all the MS SQL objects (databases, instances) known to the Cohesity Cluster.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Get-CohesityMSSQLObject
    ///   </code>
    ///   <para>
    ///   Gets a list of the MS SQL objects known to the Cohesity Cluster.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CohesityMSSQLObject")]
    [OutputType(typeof(Model.ProtectionSource))]
    public class GetCohesityMSSQLObject : PSCmdlet
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
        /// Begin Processing
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            Session.AssertAuthentication();
        }

        /// <summary>
        /// Process Record
        /// </summary>
        protected override void ProcessRecord()
        {
            var qb = new QuerystringBuilder();
            qb.Add("application", "kSQL");

            var url = $"/public/protectionSources/applicationServers{ qb.Build()}";
            var results = Session.ApiClient.Get<IEnumerable<Model.RegisteredApplicationServer>>(url);

            var protectionSources = new List<Model.ProtectionSource>();

            if(results != null)
            {
                foreach (var result in results)
                {
                    protectionSources.Add(result.RegisteredProtectionSource);
                    protectionSources.Add(result.ApplicationServer.ProtectionSource);

                    if (result.ApplicationServer.ApplicationNodes != null)
                    {
                        foreach (var applicationNode in result.ApplicationServer.ApplicationNodes)
                        {
                           protectionSources.Add(applicationNode.ProtectionSource);

                            if(applicationNode.Nodes != null)
                            {
                                foreach (var node in applicationNode.Nodes)
                                {
                                    protectionSources.Add(node.ProtectionSource);
                                }
                            }
                        }
                    }
                }
            }

            // Only include kSQL environment type
            protectionSources = protectionSources.Where(x => x.Environment == Model.ProtectionSource.EnvironmentEnum.KSQL).ToList();

            // Make sure each source id is only listed once
            var sources = protectionSources.GroupBy(x => x.Id).Select(y => y.FirstOrDefault());
            WriteObject(sources, true);
        }
    }
}
