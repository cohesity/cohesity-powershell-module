// Copyright 2018 Cohesity Inc.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cohesity.Powershell.Common
{
    class QuerystringBuilder
    {
        private SortedList<string, string> queries = new SortedList<string, string>();

        public void Add(string key, string value)
        {
            queries.Add(key, value);
        }

        public void Add(string key, Enum value)
        {
            queries.Add(key, value.ToString());
        }

        public void Add(string key, Enum[] value)
        {
            var valueString = string.Join(",", value.Select(e => e.ToString()));
            queries.Add(key, valueString);
        }

        public void Add(string key, int value)
        {
            queries.Add(key, value.ToString());
        }

        public void Add(string key, long value)
        {
            queries.Add(key, value.ToString());
        }

        public void Add(string key, bool value)
        {
            queries.Add(key, value.ToString());
        }

        public void Add(string key, IEnumerable<string> value)
        {
            queries.Add(key, string.Join(",", value));
        }

        public void Add(string key, int[] value)
        {
            queries.Add(key, string.Join(",", value));
        }

        public string Build()
        {
            if (queries.Any())
                return "?" + string.Join("&", queries.Select(q => $"{q.Key}={Uri.EscapeDataString(q.Value)}"));
            else
                return string.Empty;
        }

    }
}
