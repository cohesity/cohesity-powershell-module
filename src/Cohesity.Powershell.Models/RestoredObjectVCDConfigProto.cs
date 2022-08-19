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
    /// RestoredObjectVCDConfigProto
    /// </summary>
    [DataContract]
    public partial class RestoredObjectVCDConfigProto :  IEquatable<RestoredObjectVCDConfigProto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestoredObjectVCDConfigProto" /> class.
        /// </summary>
        /// <param name="isVapp">Whether the restored object is a VApp..</param>
        /// <param name="isVappTemplate">Whether the restored object is a VApp template..</param>
        /// <param name="restoredVappInfo">restoredVappInfo.</param>
        /// <param name="restoredVappObject">restoredVappObject.</param>
        /// <param name="restoredVappTemplateInfo">restoredVappTemplateInfo.</param>
        /// <param name="restoredVappTemplateObject">restoredVappTemplateObject.</param>
        /// <param name="vappEntity">vappEntity.</param>
        /// <param name="vcenterConnectorParams">vcenterConnectorParams.</param>
        /// <param name="vdcEntity">vdcEntity.</param>
        public RestoredObjectVCDConfigProto(bool? isVapp = default(bool?), bool? isVappTemplate = default(bool?), EntityProto restoredVappInfo = default(EntityProto), RestoreObject restoredVappObject = default(RestoreObject), EntityProto restoredVappTemplateInfo = default(EntityProto), RestoreObject restoredVappTemplateObject = default(RestoreObject), EntityProto vappEntity = default(EntityProto), ConnectorParams vcenterConnectorParams = default(ConnectorParams), EntityProto vdcEntity = default(EntityProto))
        {
            this.IsVapp = isVapp;
            this.IsVappTemplate = isVappTemplate;
            this.RestoredVappInfo = restoredVappInfo;
            this.RestoredVappObject = restoredVappObject;
            this.RestoredVappTemplateInfo = restoredVappTemplateInfo;
            this.RestoredVappTemplateObject = restoredVappTemplateObject;
            this.VappEntity = vappEntity;
            this.VcenterConnectorParams = vcenterConnectorParams;
            this.VdcEntity = vdcEntity;
        }
        
        /// <summary>
        /// Whether the restored object is a VApp.
        /// </summary>
        /// <value>Whether the restored object is a VApp.</value>
        [DataMember(Name="isVapp", EmitDefaultValue=true)]
        public bool? IsVapp { get; set; }

        /// <summary>
        /// Whether the restored object is a VApp template.
        /// </summary>
        /// <value>Whether the restored object is a VApp template.</value>
        [DataMember(Name="isVappTemplate", EmitDefaultValue=true)]
        public bool? IsVappTemplate { get; set; }

        /// <summary>
        /// Gets or Sets RestoredVappInfo
        /// </summary>
        [DataMember(Name="restoredVappInfo", EmitDefaultValue=false)]
        public EntityProto RestoredVappInfo { get; set; }

        /// <summary>
        /// Gets or Sets RestoredVappObject
        /// </summary>
        [DataMember(Name="restoredVappObject", EmitDefaultValue=false)]
        public RestoreObject RestoredVappObject { get; set; }

        /// <summary>
        /// Gets or Sets RestoredVappTemplateInfo
        /// </summary>
        [DataMember(Name="restoredVappTemplateInfo", EmitDefaultValue=false)]
        public EntityProto RestoredVappTemplateInfo { get; set; }

        /// <summary>
        /// Gets or Sets RestoredVappTemplateObject
        /// </summary>
        [DataMember(Name="restoredVappTemplateObject", EmitDefaultValue=false)]
        public RestoreObject RestoredVappTemplateObject { get; set; }

        /// <summary>
        /// Gets or Sets VappEntity
        /// </summary>
        [DataMember(Name="vappEntity", EmitDefaultValue=false)]
        public EntityProto VappEntity { get; set; }

        /// <summary>
        /// Gets or Sets VcenterConnectorParams
        /// </summary>
        [DataMember(Name="vcenterConnectorParams", EmitDefaultValue=false)]
        public ConnectorParams VcenterConnectorParams { get; set; }

        /// <summary>
        /// Gets or Sets VdcEntity
        /// </summary>
        [DataMember(Name="vdcEntity", EmitDefaultValue=false)]
        public EntityProto VdcEntity { get; set; }

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
            return this.Equals(input as RestoredObjectVCDConfigProto);
        }

        /// <summary>
        /// Returns true if RestoredObjectVCDConfigProto instances are equal
        /// </summary>
        /// <param name="input">Instance of RestoredObjectVCDConfigProto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestoredObjectVCDConfigProto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsVapp == input.IsVapp ||
                    (this.IsVapp != null &&
                    this.IsVapp.Equals(input.IsVapp))
                ) && 
                (
                    this.IsVappTemplate == input.IsVappTemplate ||
                    (this.IsVappTemplate != null &&
                    this.IsVappTemplate.Equals(input.IsVappTemplate))
                ) && 
                (
                    this.RestoredVappInfo == input.RestoredVappInfo ||
                    (this.RestoredVappInfo != null &&
                    this.RestoredVappInfo.Equals(input.RestoredVappInfo))
                ) && 
                (
                    this.RestoredVappObject == input.RestoredVappObject ||
                    (this.RestoredVappObject != null &&
                    this.RestoredVappObject.Equals(input.RestoredVappObject))
                ) && 
                (
                    this.RestoredVappTemplateInfo == input.RestoredVappTemplateInfo ||
                    (this.RestoredVappTemplateInfo != null &&
                    this.RestoredVappTemplateInfo.Equals(input.RestoredVappTemplateInfo))
                ) && 
                (
                    this.RestoredVappTemplateObject == input.RestoredVappTemplateObject ||
                    (this.RestoredVappTemplateObject != null &&
                    this.RestoredVappTemplateObject.Equals(input.RestoredVappTemplateObject))
                ) && 
                (
                    this.VappEntity == input.VappEntity ||
                    (this.VappEntity != null &&
                    this.VappEntity.Equals(input.VappEntity))
                ) && 
                (
                    this.VcenterConnectorParams == input.VcenterConnectorParams ||
                    (this.VcenterConnectorParams != null &&
                    this.VcenterConnectorParams.Equals(input.VcenterConnectorParams))
                ) && 
                (
                    this.VdcEntity == input.VdcEntity ||
                    (this.VdcEntity != null &&
                    this.VdcEntity.Equals(input.VdcEntity))
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
                if (this.IsVapp != null)
                    hashCode = hashCode * 59 + this.IsVapp.GetHashCode();
                if (this.IsVappTemplate != null)
                    hashCode = hashCode * 59 + this.IsVappTemplate.GetHashCode();
                if (this.RestoredVappInfo != null)
                    hashCode = hashCode * 59 + this.RestoredVappInfo.GetHashCode();
                if (this.RestoredVappObject != null)
                    hashCode = hashCode * 59 + this.RestoredVappObject.GetHashCode();
                if (this.RestoredVappTemplateInfo != null)
                    hashCode = hashCode * 59 + this.RestoredVappTemplateInfo.GetHashCode();
                if (this.RestoredVappTemplateObject != null)
                    hashCode = hashCode * 59 + this.RestoredVappTemplateObject.GetHashCode();
                if (this.VappEntity != null)
                    hashCode = hashCode * 59 + this.VappEntity.GetHashCode();
                if (this.VcenterConnectorParams != null)
                    hashCode = hashCode * 59 + this.VcenterConnectorParams.GetHashCode();
                if (this.VdcEntity != null)
                    hashCode = hashCode * 59 + this.VdcEntity.GetHashCode();
                return hashCode;
            }
        }

    }

}

