using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Cohesity
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns a list of Cohesity cmdlets.
    /// </para>
    /// </summary>
    /// <example>
    ///   <para>C:PS&gt;</para>
    ///   <code>
    ///   Cohesity-ListCmdlets
    ///   </code>
    ///   <para>
    ///   Returns an array of cmdlet names.
    ///   </para>
    /// </example>
    [Cmdlet("Cohesity", "ListCmdlets")]
    [OutputType(typeof(string))]
    public class ListCmdlets : PSCmdlet
    {
        //private static readonly string[] CmdletsList = new[] {
        //    "Cohesity-Connect",
        //    "Cohesity-DataProtectionDeleteJob",
        //    "Cohesity-ListDataProtectionJobs",
        //    "Cohesity-PauseDataProtectionJob",
        //    "Cohesity-CreateDataProtectionJobs",
        //    "Cohesity-ListPolicies",
        //    "Cohesity-ListProtectionSources",
        //    "Cohesity-ListViewBox",
        //    "Cohesity-ListViews",
        //    "Cohesity-ListCmdlets"
        //};

        private IEnumerable<string> CmdletsList;

        /// <summary>
        /// Preprocess
        /// </summary>
        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            var assembly = typeof(ListCmdlets).Assembly;
            var allTypes = assembly.GetTypes();
            var publicTypes = from type in allTypes
                              where type.IsPublic
                              select type;
            CmdletsList = from type in publicTypes
                    let attr = System.Attribute.GetCustomAttribute(type, typeof(CmdletAttribute)) as CmdletAttribute
                    where  attr != null
                    select $"{attr.VerbName}-{attr.NounName}";
        }

        /// <summary>
        /// Process
        /// </summary>
        protected override void ProcessRecord()
        {
            var sortedList = CmdletsList.OrderBy(s => s);
            WriteObject(sortedList.ToArray(), true);
        }

    }
}
