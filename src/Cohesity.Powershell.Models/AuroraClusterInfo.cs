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
    /// AuroraClusterInfo
    /// </summary>
    [DataContract]
    public partial class AuroraClusterInfo :  IEquatable<AuroraClusterInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuroraClusterInfo" /> class.
        /// </summary>
        /// <param name="awsRegion">Aws region of the Aurora DB cluster and S3 bucket..</param>
        /// <param name="databasePort">Contains the database port of the Aurora cluster..</param>
        /// <param name="dbAccessIamRoleArn">Contains the postgres db user IAM role Arn..</param>
        /// <param name="dbUserName">Database user for managing the databases on the Aurora cluster. This user will have exclusive access on all the databases created for the protection group and recovery for a particular tenant..</param>
        /// <param name="hostName">Contains the host name of the Aurora cluster. This is the writer end point of the Aurora cluster..</param>
        /// <param name="kmsKeyArn">Contains the kms encryption key used for encryption of data on the Aurora cluster..</param>
        public AuroraClusterInfo(string awsRegion = default(string), string databasePort = default(string), string dbAccessIamRoleArn = default(string), string dbUserName = default(string), string hostName = default(string), string kmsKeyArn = default(string))
        {
            this.AwsRegion = awsRegion;
            this.DatabasePort = databasePort;
            this.DbAccessIamRoleArn = dbAccessIamRoleArn;
            this.DbUserName = dbUserName;
            this.HostName = hostName;
            this.KmsKeyArn = kmsKeyArn;
            this.AwsRegion = awsRegion;
            this.DatabasePort = databasePort;
            this.DbAccessIamRoleArn = dbAccessIamRoleArn;
            this.DbUserName = dbUserName;
            this.HostName = hostName;
            this.KmsKeyArn = kmsKeyArn;
        }
        
        /// <summary>
        /// Aws region of the Aurora DB cluster and S3 bucket.
        /// </summary>
        /// <value>Aws region of the Aurora DB cluster and S3 bucket.</value>
        [DataMember(Name="awsRegion", EmitDefaultValue=true)]
        public string AwsRegion { get; set; }

        /// <summary>
        /// Contains the database port of the Aurora cluster.
        /// </summary>
        /// <value>Contains the database port of the Aurora cluster.</value>
        [DataMember(Name="databasePort", EmitDefaultValue=true)]
        public string DatabasePort { get; set; }

        /// <summary>
        /// Contains the postgres db user IAM role Arn.
        /// </summary>
        /// <value>Contains the postgres db user IAM role Arn.</value>
        [DataMember(Name="dbAccessIamRoleArn", EmitDefaultValue=true)]
        public string DbAccessIamRoleArn { get; set; }

        /// <summary>
        /// Database user for managing the databases on the Aurora cluster. This user will have exclusive access on all the databases created for the protection group and recovery for a particular tenant.
        /// </summary>
        /// <value>Database user for managing the databases on the Aurora cluster. This user will have exclusive access on all the databases created for the protection group and recovery for a particular tenant.</value>
        [DataMember(Name="dbUserName", EmitDefaultValue=true)]
        public string DbUserName { get; set; }

        /// <summary>
        /// Contains the host name of the Aurora cluster. This is the writer end point of the Aurora cluster.
        /// </summary>
        /// <value>Contains the host name of the Aurora cluster. This is the writer end point of the Aurora cluster.</value>
        [DataMember(Name="hostName", EmitDefaultValue=true)]
        public string HostName { get; set; }

        /// <summary>
        /// Contains the kms encryption key used for encryption of data on the Aurora cluster.
        /// </summary>
        /// <value>Contains the kms encryption key used for encryption of data on the Aurora cluster.</value>
        [DataMember(Name="kmsKeyArn", EmitDefaultValue=true)]
        public string KmsKeyArn { get; set; }

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
            return this.Equals(input as AuroraClusterInfo);
        }

        /// <summary>
        /// Returns true if AuroraClusterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AuroraClusterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuroraClusterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AwsRegion == input.AwsRegion ||
                    (this.AwsRegion != null &&
                    this.AwsRegion.Equals(input.AwsRegion))
                ) && 
                (
                    this.DatabasePort == input.DatabasePort ||
                    (this.DatabasePort != null &&
                    this.DatabasePort.Equals(input.DatabasePort))
                ) && 
                (
                    this.DbAccessIamRoleArn == input.DbAccessIamRoleArn ||
                    (this.DbAccessIamRoleArn != null &&
                    this.DbAccessIamRoleArn.Equals(input.DbAccessIamRoleArn))
                ) && 
                (
                    this.DbUserName == input.DbUserName ||
                    (this.DbUserName != null &&
                    this.DbUserName.Equals(input.DbUserName))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.KmsKeyArn == input.KmsKeyArn ||
                    (this.KmsKeyArn != null &&
                    this.KmsKeyArn.Equals(input.KmsKeyArn))
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
                if (this.AwsRegion != null)
                    hashCode = hashCode * 59 + this.AwsRegion.GetHashCode();
                if (this.DatabasePort != null)
                    hashCode = hashCode * 59 + this.DatabasePort.GetHashCode();
                if (this.DbAccessIamRoleArn != null)
                    hashCode = hashCode * 59 + this.DbAccessIamRoleArn.GetHashCode();
                if (this.DbUserName != null)
                    hashCode = hashCode * 59 + this.DbUserName.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.KmsKeyArn != null)
                    hashCode = hashCode * 59 + this.KmsKeyArn.GetHashCode();
                return hashCode;
            }
        }

    }

}

