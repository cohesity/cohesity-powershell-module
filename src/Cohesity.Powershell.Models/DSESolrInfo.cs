// Copyright 2019 Cohesity Inc.

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

namespace Cohesity.Model
{
    /// <summary>
    /// DSESolrInfo
    /// </summary>
    [DataContract]
    public partial class DSESolrInfo :  IEquatable<DSESolrInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DSESolrInfo" /> class.
        /// </summary>
        /// <param name="solrNodeVec">Solr node IP Addresses..</param>
        /// <param name="solrPort">Solr node Port..</param>
        public DSESolrInfo(List<string> solrNodeVec = default(List<string>), int? solrPort = default(int?))
        {
            this.SolrNodeVec = solrNodeVec;
            this.SolrPort = solrPort;
            this.SolrNodeVec = solrNodeVec;
            this.SolrPort = solrPort;
        }
        
        /// <summary>
        /// Solr node IP Addresses.
        /// </summary>
        /// <value>Solr node IP Addresses.</value>
        [DataMember(Name="solrNodeVec", EmitDefaultValue=true)]
        public List<string> SolrNodeVec { get; set; }

        /// <summary>
        /// Solr node Port.
        /// </summary>
        /// <value>Solr node Port.</value>
        [DataMember(Name="solrPort", EmitDefaultValue=true)]
        public int? SolrPort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() { return ToJson(); }
  
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
            return this.Equals(input as DSESolrInfo);
        }

        /// <summary>
        /// Returns true if DSESolrInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DSESolrInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSESolrInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SolrNodeVec == input.SolrNodeVec ||
                    this.SolrNodeVec != null &&
                    input.SolrNodeVec != null &&
                    this.SolrNodeVec.SequenceEqual(input.SolrNodeVec)
                ) && 
                (
                    this.SolrPort == input.SolrPort ||
                    (this.SolrPort != null &&
                    this.SolrPort.Equals(input.SolrPort))
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
                if (this.SolrNodeVec != null)
                    hashCode = hashCode * 59 + this.SolrNodeVec.GetHashCode();
                if (this.SolrPort != null)
                    hashCode = hashCode * 59 + this.SolrPort.GetHashCode();
                return hashCode;
            }
        }

    }

}

