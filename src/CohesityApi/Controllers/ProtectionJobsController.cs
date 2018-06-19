using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cohesity.Models;

namespace CohesityApi.Controllers
{
    [Produces("application/json")]
    [Route("irisservices/api/v1/public/ProtectionJobs")]
    public class ProtectionJobsController : Controller
    {

        public ActionResult Get(GetProtectionJobs model)
        {
            var result = new[] { new ProtectionJob() {
                AlertingPolicy = new List<ProtectionJob.AlertingPolicyEnum> { ProtectionJob.AlertingPolicyEnum.KFailure },
                SummaryStats = new ProtectionJobSummaryStats(1,2,3,4,5,6,7,8,9)
            } };
            return Ok(result);
        }

        public class GetProtectionJobs
        {
            public IEnumerable<string> PolicyIds { get; set; }

            public IEnumerable<string> Environments { get; set; }

            public bool IsActive { get; set; }

            public bool IsDeleted { get; set; }

            public bool IncludeLastRunAndStats { get; set; }

            public IEnumerable<int> Ids { get; set; }

            public IEnumerable<string> Names { get; set; }
        }

    }
}