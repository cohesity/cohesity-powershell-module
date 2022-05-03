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
    /// Rolling up or Down sampling is performed on timeseries data to reduce space usage by timeseries. Rollup Granularity is defined per entity schema but rollup function is not defined. Instead we create rolledup values for all the rollup functions.
    /// </summary>
    [DataContract]
    public partial class EntitySchemaProtoGranularity :  IEquatable<EntitySchemaProtoGranularity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySchemaProtoGranularity" /> class.
        /// </summary>
        /// <param name="rollupIntervalSecs">Defines the rollup interval or a bucket size. All data points within one time bucket are rolled up to one summary data point using the defined rollup function. For example, say, raw metric is published at ~30 secs granularity. To generate a hourly or a daily summary time series, client can define rolled up metrics having interval 3600 secs and 86400 secs respectively..</param>
        /// <param name="timeToLiveSecs">Defines the duration for which the rolled up data is to be stored. Once the lifespan has elapsed, expired data is garbage collected..</param>
        public EntitySchemaProtoGranularity(int? rollupIntervalSecs = default(int?), long? timeToLiveSecs = default(long?))
        {
            this.RollupIntervalSecs = rollupIntervalSecs;
            this.TimeToLiveSecs = timeToLiveSecs;
        }
        
        /// <summary>
        /// Defines the rollup interval or a bucket size. All data points within one time bucket are rolled up to one summary data point using the defined rollup function. For example, say, raw metric is published at ~30 secs granularity. To generate a hourly or a daily summary time series, client can define rolled up metrics having interval 3600 secs and 86400 secs respectively.
        /// </summary>
        /// <value>Defines the rollup interval or a bucket size. All data points within one time bucket are rolled up to one summary data point using the defined rollup function. For example, say, raw metric is published at ~30 secs granularity. To generate a hourly or a daily summary time series, client can define rolled up metrics having interval 3600 secs and 86400 secs respectively.</value>
        [DataMember(Name="rollupIntervalSecs", EmitDefaultValue=false)]
        public int? RollupIntervalSecs { get; set; }

        /// <summary>
        /// Defines the duration for which the rolled up data is to be stored. Once the lifespan has elapsed, expired data is garbage collected.
        /// </summary>
        /// <value>Defines the duration for which the rolled up data is to be stored. Once the lifespan has elapsed, expired data is garbage collected.</value>
        [DataMember(Name="timeToLiveSecs", EmitDefaultValue=false)]
        public long? TimeToLiveSecs { get; set; }

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
            return this.Equals(input as EntitySchemaProtoGranularity);
        }

        /// <summary>
        /// Returns true if EntitySchemaProtoGranularity instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySchemaProtoGranularity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySchemaProtoGranularity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RollupIntervalSecs == input.RollupIntervalSecs ||
                    (this.RollupIntervalSecs != null &&
                    this.RollupIntervalSecs.Equals(input.RollupIntervalSecs))
                ) && 
                (
                    this.TimeToLiveSecs == input.TimeToLiveSecs ||
                    (this.TimeToLiveSecs != null &&
                    this.TimeToLiveSecs.Equals(input.TimeToLiveSecs))
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
                if (this.RollupIntervalSecs != null)
                    hashCode = hashCode * 59 + this.RollupIntervalSecs.GetHashCode();
                if (this.TimeToLiveSecs != null)
                    hashCode = hashCode * 59 + this.TimeToLiveSecs.GetHashCode();
                return hashCode;
            }
        }

    }

}

