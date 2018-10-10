// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Linq;
using Cohesity.Models;

namespace Cohesity.Powershell.Common
{
    internal static class RestApiCommon
    {
        public static ProtectionPolicy GetPolicyByName(RestApiClient client, string name)
        {
            var qb = new QuerystringBuilder();
            qb.Add("names", name);

            var preparedUrl = $"/public/protectionPolicies{qb.Build()}";
            var policies = client.Get<IEnumerable<ProtectionPolicy>>(preparedUrl);
            if (policies == null || !policies.Any())
                throw new Exception("Policy with matching name not found.");

            if (policies.Count() > 1)
                throw new Exception("Found multiple policies with matching name.");

            return policies.First();
        }

        public static ViewBox GetStorageDomainByName(RestApiClient client, string name)
        {
            var qb = new QuerystringBuilder();
            qb.Add("names", new[] { name });

            var preparedUrl = $"/public/viewBoxes{qb.Build()}";
            var domains = client.Get<IEnumerable<ViewBox>>(preparedUrl);
            if (domains == null || !domains.Any())
                throw new Exception("Storage domain with matching name not found.");
            if (domains.Count() > 1)
                throw new Exception("Found multiple storage domains with matching name.");
            return domains.First();
        }

    }
}
