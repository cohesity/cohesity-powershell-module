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
    /// Each available extension is listed below along with the location of the proto file (relative to magneto/connectors) where it is defined.  DestroyCloneAppTaskInfoProto extension Location Extension &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D; sql::DestroyCloneTaskInfo::sql_destroy_clone_app_task_info sql/sql.proto 100 oracle::DestroyCloneTaskInfo::oracle_destroy_clone_app_task_info oracle/oracle.proto 101 ad::DestroyTaskInfo::ad_destroy_app_task_info ad/ad.proto 102 exchange::DestroyTaskInfo::exchange_destroy_app_task_info exchange/exchange.proto 103 &#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;&#x3D;
    /// </summary>
    [DataContract]
    public partial class DestroyCloneAppTaskInfoProto :  IEquatable<DestroyCloneAppTaskInfoProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestroyCloneAppTaskInfoProto" /> class.
        /// </summary>
        /// <param name="appEnv">The application environment..</param>
        /// <param name="error">error.</param>
        /// <param name="finished">This will be set to true if the task is complete on the slave..</param>
        /// <param name="targetEntity">targetEntity.</param>
        /// <param name="targetEntityCredentials">targetEntityCredentials.</param>
        public DestroyCloneAppTaskInfoProto(int? appEnv = default(int?), ErrorProto error = default(ErrorProto), bool? finished = default(bool?), EntityProto targetEntity = default(EntityProto), Credentials targetEntityCredentials = default(Credentials))
        {
            this.AppEnv = appEnv;
            this.Finished = finished;
            this.AppEnv = appEnv;
            this.Error = error;
            this.Finished = finished;
            this.TargetEntity = targetEntity;
            this.TargetEntityCredentials = targetEntityCredentials;
        }
        
        /// <summary>
        /// The application environment.
        /// </summary>
        /// <value>The application environment.</value>
        [DataMember(Name="appEnv", EmitDefaultValue=true)]
        public int? AppEnv { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorProto Error { get; set; }

        /// <summary>
        /// This will be set to true if the task is complete on the slave.
        /// </summary>
        /// <value>This will be set to true if the task is complete on the slave.</value>
        [DataMember(Name="finished", EmitDefaultValue=true)]
        public bool? Finished { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntity
        /// </summary>
        [DataMember(Name="targetEntity", EmitDefaultValue=false)]
        public EntityProto TargetEntity { get; set; }

        /// <summary>
        /// Gets or Sets TargetEntityCredentials
        /// </summary>
        [DataMember(Name="targetEntityCredentials", EmitDefaultValue=false)]
        public Credentials TargetEntityCredentials { get; set; }

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
            return this.Equals(input as DestroyCloneAppTaskInfoProto);
        }

        /// <summary>
        /// Returns true if DestroyCloneAppTaskInfoProto instances are equal
        /// </summary>
        /// <param name="input">Instance of DestroyCloneAppTaskInfoProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestroyCloneAppTaskInfoProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppEnv == input.AppEnv ||
                    (this.AppEnv != null &&
                    this.AppEnv.Equals(input.AppEnv))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Finished == input.Finished ||
                    (this.Finished != null &&
                    this.Finished.Equals(input.Finished))
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
                ) && 
                (
                    this.TargetEntityCredentials == input.TargetEntityCredentials ||
                    (this.TargetEntityCredentials != null &&
                    this.TargetEntityCredentials.Equals(input.TargetEntityCredentials))
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
                if (this.AppEnv != null)
                    hashCode = hashCode * 59 + this.AppEnv.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.TargetEntityCredentials != null)
                    hashCode = hashCode * 59 + this.TargetEntityCredentials.GetHashCode();
                return hashCode;
            }
        }

    }

}

