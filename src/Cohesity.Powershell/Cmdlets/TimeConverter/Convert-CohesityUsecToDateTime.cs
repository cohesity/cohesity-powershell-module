using System;
using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets.TimeConverter
{
    /// <summary>
    /// <para type="synopsis">
    /// Converts the Microseconds value to DateTime format.
    /// </para>
    /// <para type="description">
    /// Converts the Microseconds value to DateTime format.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///   <code>
    ///   Convert-CohesityUsecToDateTime -Usec 1537272612321018
    ///   </code>
    ///   <para>
    ///   Gives the datetime value of 1537272612321018.
    ///   </para>
    /// </example>
    [Cmdlet(VerbsData.Convert, "CohesityUsecToDateTime")]
    [OutputType(typeof(DateTime))]
    public class ConvertCohesityUsecToDateTime : Cmdlet
    {

        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public double Usec { get; set; }

        [Parameter(ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [PSDefaultValue(Value = "1970-01-01 00:00:00")]
        public string Origin { get; set; }

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
            //base.ProcessRecord();
            double unixTime = this.Usec / 1000000;
            DateTime origin = DateTime.Parse("1970-01-01 00:00:00");
            WriteObject(origin.AddSeconds(unixTime).ToLocalTime());
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }

    }

}
