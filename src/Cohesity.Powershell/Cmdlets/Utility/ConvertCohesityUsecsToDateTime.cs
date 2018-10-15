// Copyright 2018 Cohesity Inc.
using System;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.Utility
{
    /// <summary>
    /// <para type="synopsis">
    /// Converts the unix timestamp in microseconds to DateTime format.
    /// </para>
    /// <para type="description">
    /// Converts the unix timestamp in microseconds to DateTime format.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Convert-CohesityUsecsToDateTime -Usecs 1537272612321018
    ///   </code>
    ///   <para>
    ///   Converts the unix timestamp in microseconds to its corresponding DateTime value such as: Tuesday, September 18, 2018 5:10:12 AM.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Convert, "CohesityUsecsToDateTime")]
    [OutputType(typeof(DateTime))]
    public class ConvertCohesityUsecsToDateTime : Cmdlet
    {

        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public long Usecs { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void ProcessRecord()
        {
            long unixTime = this.Usecs / 1000000;
            DateTime origin = DateTime.Parse("1970-01-01 00:00:00");
            WriteObject(origin.AddSeconds(unixTime).ToLocalTime());
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }

    }

}
