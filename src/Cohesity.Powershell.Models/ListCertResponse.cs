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
    /// Specifies list of all certificates deployed from the cluster.
    /// </summary>
    [DataContract]
    public partial class ListCertResponse :  IEquatable<ListCertResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCertResponse" /> class.
        /// </summary>
        /// <param name="certificateList">certificateList.</param>
        public ListCertResponse(List<CertificateDetails> certificateList = default(List<CertificateDetails>))
        {
            this.CertificateList = certificateList;
        }
        
        /// <summary>
        /// Gets or Sets CertificateList
        /// </summary>
        [DataMember(Name="certificateList", EmitDefaultValue=false)]
        public List<CertificateDetails> CertificateList { get; set; }

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
            return this.Equals(input as ListCertResponse);
        }

        /// <summary>
        /// Returns true if ListCertResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListCertResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCertResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertificateList == input.CertificateList ||
                    this.CertificateList != null &&
                    this.CertificateList.Equals(input.CertificateList)
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
                if (this.CertificateList != null)
                    hashCode = hashCode * 59 + this.CertificateList.GetHashCode();
                return hashCode;
            }
        }

    }

}

