// Copyright 2018 Cohesity Inc.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;




namespace Cohesity.Models
{
    /// <summary>
    /// DashboardResponse
    /// </summary>
    [DataContract]
    public partial class DashboardResponse :  IEquatable<DashboardResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardResponse" /> class.
        /// </summary>
        /// <param name="dashboard">Specifies the dashboard of the local cluster or a remote cluster whose id is set in clusterId query parameter when the query parameter allClusters is not given or set to false. Otherwise this field is populated with aggregated dashboard values for all the dashboards in the dashboards field..</param>
        /// <param name="dashboards">Specifies a list of dashboards of all the clusters in the SPOG setup if the query parameter allClusters is set to true. Otherwise this field is not populated. When populated the dashboard field is also populated with aggregated dashboard values..</param>
        public DashboardResponse(Dashboard dashboard = default(Dashboard), List<Dashboard> dashboards = default(List<Dashboard>))
        {
            this.Dashboard = dashboard;
            this.Dashboards = dashboards;
        }
        
        /// <summary>
        /// Specifies the dashboard of the local cluster or a remote cluster whose id is set in clusterId query parameter when the query parameter allClusters is not given or set to false. Otherwise this field is populated with aggregated dashboard values for all the dashboards in the dashboards field.
        /// </summary>
        /// <value>Specifies the dashboard of the local cluster or a remote cluster whose id is set in clusterId query parameter when the query parameter allClusters is not given or set to false. Otherwise this field is populated with aggregated dashboard values for all the dashboards in the dashboards field.</value>
        [DataMember(Name="dashboard", EmitDefaultValue=false)]
        public Dashboard Dashboard { get; set; }

        /// <summary>
        /// Specifies a list of dashboards of all the clusters in the SPOG setup if the query parameter allClusters is set to true. Otherwise this field is not populated. When populated the dashboard field is also populated with aggregated dashboard values.
        /// </summary>
        /// <value>Specifies a list of dashboards of all the clusters in the SPOG setup if the query parameter allClusters is set to true. Otherwise this field is not populated. When populated the dashboard field is also populated with aggregated dashboard values.</value>
        [DataMember(Name="dashboards", EmitDefaultValue=false)]
        public List<Dashboard> Dashboards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DashboardResponse);
        }

        /// <summary>
        /// Returns true if DashboardResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dashboard == input.Dashboard ||
                    (this.Dashboard != null &&
                    this.Dashboard.Equals(input.Dashboard))
                ) && 
                (
                    this.Dashboards == input.Dashboards ||
                    this.Dashboards != null &&
                    this.Dashboards.SequenceEqual(input.Dashboards)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Dashboard != null)
                    hashCode = hashCode * 59 + this.Dashboard.GetHashCode();
                if (this.Dashboards != null)
                    hashCode = hashCode * 59 + this.Dashboards.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

