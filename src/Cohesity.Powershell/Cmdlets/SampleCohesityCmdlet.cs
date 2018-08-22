/******************************************************************************

 --------------------------------------------
 Template for writing a new a Cohesity Cmdlet
 --------------------------------------------

using System.Management.Automation;

namespace Cohesity.Powershell.Cmdlets
{
    /// <summary>
    ///   <para type="synopsis">
    ///   </para>
    ///   <para type="description">
    ///   </para>
    /// </summary>
    /// <example>
    ///   <para>PS&gt;</para>
    ///     <code>
    ///     </code>
    ///   <para>
    ///   </para>
    /// </example>
    [Cmdlet("Verb", "CohesityNoun")]
    [OutputType(typeof(Models.CohesityObject))]
    class TemplateCohesityCmdlet : PSCmdlet
    {
        private Session Session
        {
            get
            {
                if (!(SessionState.PSVariable.GetValue("Session") is Session result))
                {
                    result = new Session();
                    SessionState.PSVariable.Set("Session", result);
                }
                return result;
            }
        }

        #region Params
        
        /// <summary>
        ///   <para type="description">
        ///   </para>
        /// </summary>
        [Parameter(Mandatory = true)]
        [ValidateRange(1, long.MaxValue)]
        public long Id { get; set; }

        #endregion

        #region Processing

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            // Verify authentication with the Cohesity Cluster
            Session.AssertAuthentication();
        }

        protected override void ProcessRecord()
        {
            // Call Cohesity REST API, handle errors and process results
        }

        #endregion
    }
}

******************************************************************************/
