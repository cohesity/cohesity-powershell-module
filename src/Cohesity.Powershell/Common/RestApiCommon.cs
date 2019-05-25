// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Linq;
using Cohesity.Model;

namespace Cohesity.Powershell.Common
{
    internal static class RestApiCommon
    {
        public static View GetViewByName(RestApiClient client, string name)
        {
            var qb = new QuerystringBuilder();
            qb.Add("includeInactive", true);

            var preparedUrl = $"/public/views{qb.Build()}";
            var result = client.Get<GetViewsResult>(preparedUrl);
            if (result == null)
                throw new Exception("View with matching name not found.");

            var view = result.Views.FirstOrDefault(i => i.Name.Equals(name));
            if (view == null)
                throw new Exception("View with matching name not found.");

            return view;
        }

        public static ProtectionJob GetProtectionJobByName(RestApiClient client, string name)
        {
            var qb = new QuerystringBuilder();
            qb.Add("includeLastRunAndStats", true);

            var preparedUrl = $"/public/protectionJobs{qb.Build()}";
            var jobs = client.Get<IEnumerable<ProtectionJob>>(preparedUrl);
            if (jobs == null || !jobs.Any())
                throw new Exception("Protection job with matching name not found.");

            var job = jobs.FirstOrDefault(i => i.Name.Equals(name));
            if (job == null)
                throw new Exception("Protection job with matching name not found.");

            return job;
        }

        public static ProtectionJob GetProtectionJobById(RestApiClient client, long id)
        {
            var qb = new QuerystringBuilder();
            qb.Add("ids", id);
            qb.Add("includeLastRunAndStats", true);

            var preparedUrl = $"/public/protectionJobs{qb.Build()}";
            var jobs = client.Get<IEnumerable<ProtectionJob>>(preparedUrl);
            if (jobs == null || !jobs.Any())
                throw new Exception("Protection job with matching id not found.");

            var job = jobs.FirstOrDefault(i => i.Id.Equals(id));
            if (job == null)
                throw new Exception("Protection job with matching id not found.");

            return job;
        }

        public static IEnumerable<ProtectionRunInstance> GetProtectionJobRunsByJobId(RestApiClient client, long jobId)
        {
            var qb = new QuerystringBuilder();
            qb.Add("jobId", jobId);

            var preparedUrl = $"/public/protectionRuns{qb.Build()}";
            var jobRuns = client.Get<IEnumerable<ProtectionRunInstance>>(preparedUrl);
            if (jobRuns == null || !jobRuns.Any())
                throw new Exception("Protection job runs with matching job id not found.");

            return jobRuns;
        }

        public static ProtectionPolicy GetPolicyByName(RestApiClient client, string name)
        {
            var preparedUrl = $"/public/protectionPolicies";
            var policies = client.Get<IEnumerable<ProtectionPolicy>>(preparedUrl);
            if (policies == null || !policies.Any())
                throw new Exception("Policy with matching name not found.");

            var policy = policies.FirstOrDefault(i => i.Name.Equals(name));
            if (policy == null)
                throw new Exception("Policy with matching name not found.");

            return policy;
        }

        public static ViewBox GetStorageDomainByName(RestApiClient client, string name)
        {
            var preparedUrl = $"/public/viewBoxes";
            var domains = client.Get<IEnumerable<ViewBox>>(preparedUrl);
            if (domains == null || !domains.Any())
                throw new Exception("Storage domain with matching name not found.");
            var domain = domains.FirstOrDefault(i => i.Name.Equals(name));
            if (domain == null)
                throw new Exception("Storage domain with matching name not found.");

            return domain;
        }

        public static long ConvertDateTimeToUsecs(DateTime dateTime)
        {
            DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            long microseconds = (dateTime.ToUniversalTime() - UnixEpoch).Ticks / (TimeSpan.TicksPerMillisecond / 1000);
            return microseconds;
        }

        public static DateTime ConvertUsecsToDateTime(long usecs)
        {
            long unixTime = usecs / 1000000;
            DateTime origin = DateTime.Parse("1970-01-01 00:00:00");
            return origin.AddSeconds(unixTime).ToLocalTime();
        }

    }
}
