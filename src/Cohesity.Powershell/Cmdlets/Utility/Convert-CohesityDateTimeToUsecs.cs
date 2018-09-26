using System;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.Utility
{
    /// <summary>
    /// <para type="synopsis">
    /// Converts the DateTime format to unix timestamp in microseconds.
    /// </para>
    /// <para type="description">
    /// Converts the DateTime format to unix timestamp in microseconds.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Convert-CohesityDateTimeToUsecs -DateTime "Tuesday, September 18, 2018 5:40:12 PM"
    ///   </code>
    ///   <para>
    ///   Converts the DateTime format to its corresponding unix timestamp in microseconds such as: 1537272612000000.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Convert, "CohesityDateTimeToUsecs")]
    [OutputType(typeof(long))]
    public class ConvertCohesityDateTimeToUsecs : Cmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipeline = true)]
        public DateTime DateTime { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            long microseconds = (this.DateTime.ToUniversalTime() - UnixEpoch).Ticks / (TimeSpan.TicksPerMillisecond / 1000);
            WriteObject(microseconds);
        }
    }
}
