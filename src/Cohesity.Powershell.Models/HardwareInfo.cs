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
    /// Hardware JSON file serves as cache for hardware info to reduce hardware polling which takes time.
    /// </summary>
    [DataContract]
    public partial class HardwareInfo :  IEquatable<HardwareInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareInfo" /> class.
        /// </summary>
        /// <param name="chassisModel">chassisModel.</param>
        /// <param name="chassisSerial">chassisSerial.</param>
        /// <param name="chassisType">chassisType.</param>
        /// <param name="hbaModel">hbaModel.</param>
        /// <param name="ipmiLanChannel">ipmiLanChannel.</param>
        /// <param name="maxSlots">maxSlots.</param>
        /// <param name="nodeModel">nodeModel.</param>
        /// <param name="nodeSerial">nodeSerial.</param>
        /// <param name="primaryBondName">primaryBondName.</param>
        /// <param name="productModel">productModel.</param>
        /// <param name="secondaryBondName">secondaryBondName.</param>
        /// <param name="slotNumber">slotNumber.</param>
        public HardwareInfo(string chassisModel = default(string), string chassisSerial = default(string), string chassisType = default(string), string hbaModel = default(string), string ipmiLanChannel = default(string), string maxSlots = default(string), string nodeModel = default(string), string nodeSerial = default(string), string primaryBondName = default(string), string productModel = default(string), List<string> secondaryBondName = default(List<string>), string slotNumber = default(string))
        {
            this.ChassisModel = chassisModel;
            this.ChassisSerial = chassisSerial;
            this.ChassisType = chassisType;
            this.HbaModel = hbaModel;
            this.IpmiLanChannel = ipmiLanChannel;
            this.MaxSlots = maxSlots;
            this.NodeModel = nodeModel;
            this.NodeSerial = nodeSerial;
            this.PrimaryBondName = primaryBondName;
            this.ProductModel = productModel;
            this.SecondaryBondName = secondaryBondName;
            this.SlotNumber = slotNumber;
        }
        
        /// <summary>
        /// Gets or Sets ChassisModel
        /// </summary>
        [DataMember(Name="chassisModel", EmitDefaultValue=false)]
        public string ChassisModel { get; set; }

        /// <summary>
        /// Gets or Sets ChassisSerial
        /// </summary>
        [DataMember(Name="chassisSerial", EmitDefaultValue=false)]
        public string ChassisSerial { get; set; }

        /// <summary>
        /// Gets or Sets ChassisType
        /// </summary>
        [DataMember(Name="chassisType", EmitDefaultValue=false)]
        public string ChassisType { get; set; }

        /// <summary>
        /// Gets or Sets HbaModel
        /// </summary>
        [DataMember(Name="hbaModel", EmitDefaultValue=false)]
        public string HbaModel { get; set; }

        /// <summary>
        /// Gets or Sets IpmiLanChannel
        /// </summary>
        [DataMember(Name="ipmiLanChannel", EmitDefaultValue=false)]
        public string IpmiLanChannel { get; set; }

        /// <summary>
        /// Gets or Sets MaxSlots
        /// </summary>
        [DataMember(Name="maxSlots", EmitDefaultValue=false)]
        public string MaxSlots { get; set; }

        /// <summary>
        /// Gets or Sets NodeModel
        /// </summary>
        [DataMember(Name="nodeModel", EmitDefaultValue=false)]
        public string NodeModel { get; set; }

        /// <summary>
        /// Gets or Sets NodeSerial
        /// </summary>
        [DataMember(Name="nodeSerial", EmitDefaultValue=false)]
        public string NodeSerial { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryBondName
        /// </summary>
        [DataMember(Name="primaryBondName", EmitDefaultValue=false)]
        public string PrimaryBondName { get; set; }

        /// <summary>
        /// Gets or Sets ProductModel
        /// </summary>
        [DataMember(Name="productModel", EmitDefaultValue=false)]
        public string ProductModel { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryBondName
        /// </summary>
        [DataMember(Name="secondaryBondName", EmitDefaultValue=false)]
        public List<string> SecondaryBondName { get; set; }

        /// <summary>
        /// Gets or Sets SlotNumber
        /// </summary>
        [DataMember(Name="slotNumber", EmitDefaultValue=false)]
        public string SlotNumber { get; set; }

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
            return this.Equals(input as HardwareInfo);
        }

        /// <summary>
        /// Returns true if HardwareInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of HardwareInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HardwareInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChassisModel == input.ChassisModel ||
                    (this.ChassisModel != null &&
                    this.ChassisModel.Equals(input.ChassisModel))
                ) && 
                (
                    this.ChassisSerial == input.ChassisSerial ||
                    (this.ChassisSerial != null &&
                    this.ChassisSerial.Equals(input.ChassisSerial))
                ) && 
                (
                    this.ChassisType == input.ChassisType ||
                    (this.ChassisType != null &&
                    this.ChassisType.Equals(input.ChassisType))
                ) && 
                (
                    this.HbaModel == input.HbaModel ||
                    (this.HbaModel != null &&
                    this.HbaModel.Equals(input.HbaModel))
                ) && 
                (
                    this.IpmiLanChannel == input.IpmiLanChannel ||
                    (this.IpmiLanChannel != null &&
                    this.IpmiLanChannel.Equals(input.IpmiLanChannel))
                ) && 
                (
                    this.MaxSlots == input.MaxSlots ||
                    (this.MaxSlots != null &&
                    this.MaxSlots.Equals(input.MaxSlots))
                ) && 
                (
                    this.NodeModel == input.NodeModel ||
                    (this.NodeModel != null &&
                    this.NodeModel.Equals(input.NodeModel))
                ) && 
                (
                    this.NodeSerial == input.NodeSerial ||
                    (this.NodeSerial != null &&
                    this.NodeSerial.Equals(input.NodeSerial))
                ) && 
                (
                    this.PrimaryBondName == input.PrimaryBondName ||
                    (this.PrimaryBondName != null &&
                    this.PrimaryBondName.Equals(input.PrimaryBondName))
                ) && 
                (
                    this.ProductModel == input.ProductModel ||
                    (this.ProductModel != null &&
                    this.ProductModel.Equals(input.ProductModel))
                ) && 
                (
                    this.SecondaryBondName == input.SecondaryBondName ||
                    this.SecondaryBondName != null &&
                    this.SecondaryBondName.SequenceEqual(input.SecondaryBondName)
                ) && 
                (
                    this.SlotNumber == input.SlotNumber ||
                    (this.SlotNumber != null &&
                    this.SlotNumber.Equals(input.SlotNumber))
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
                if (this.ChassisModel != null)
                    hashCode = hashCode * 59 + this.ChassisModel.GetHashCode();
                if (this.ChassisSerial != null)
                    hashCode = hashCode * 59 + this.ChassisSerial.GetHashCode();
                if (this.ChassisType != null)
                    hashCode = hashCode * 59 + this.ChassisType.GetHashCode();
                if (this.HbaModel != null)
                    hashCode = hashCode * 59 + this.HbaModel.GetHashCode();
                if (this.IpmiLanChannel != null)
                    hashCode = hashCode * 59 + this.IpmiLanChannel.GetHashCode();
                if (this.MaxSlots != null)
                    hashCode = hashCode * 59 + this.MaxSlots.GetHashCode();
                if (this.NodeModel != null)
                    hashCode = hashCode * 59 + this.NodeModel.GetHashCode();
                if (this.NodeSerial != null)
                    hashCode = hashCode * 59 + this.NodeSerial.GetHashCode();
                if (this.PrimaryBondName != null)
                    hashCode = hashCode * 59 + this.PrimaryBondName.GetHashCode();
                if (this.ProductModel != null)
                    hashCode = hashCode * 59 + this.ProductModel.GetHashCode();
                if (this.SecondaryBondName != null)
                    hashCode = hashCode * 59 + this.SecondaryBondName.GetHashCode();
                if (this.SlotNumber != null)
                    hashCode = hashCode * 59 + this.SlotNumber.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

