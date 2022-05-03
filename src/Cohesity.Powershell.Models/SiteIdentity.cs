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
    /// O365 Sharepoint online Site Identity. These may be obtained by Graph/REST or PnP cmdlets. All fields are case insensitive.
    /// </summary>
    [DataContract]
    public partial class SiteIdentity :  IEquatable<SiteIdentity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteIdentity" /> class.
        /// </summary>
        /// <param name="id">Unique guid for the site in SPO. This is a unqiue identifier that can be used to compare sites..</param>
        /// <param name="serverRelativeurl">Optional ServerRelativeUrl. Not required..</param>
        /// <param name="title">Optional Title of site for display and logging purpose. Not mandatory..</param>
        /// <param name="url">Full Url of the site. Its of the form https://yourtenant.sharepoint.com/sites/yoursite or https://yourtenant.sharepoint.com/yoursite This parameter is required for all PnP operations..</param>
        /// <param name="webid">Unique guid for the site root web..</param>
        public SiteIdentity(string id = default(string), string serverRelativeurl = default(string), string title = default(string), string url = default(string), string webid = default(string))
        {
            this.Id = id;
            this.ServerRelativeurl = serverRelativeurl;
            this.Title = title;
            this.Url = url;
            this.Webid = webid;
        }
        
        /// <summary>
        /// Unique guid for the site in SPO. This is a unqiue identifier that can be used to compare sites.
        /// </summary>
        /// <value>Unique guid for the site in SPO. This is a unqiue identifier that can be used to compare sites.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Optional ServerRelativeUrl. Not required.
        /// </summary>
        /// <value>Optional ServerRelativeUrl. Not required.</value>
        [DataMember(Name="serverRelativeurl", EmitDefaultValue=false)]
        public string ServerRelativeurl { get; set; }

        /// <summary>
        /// Optional Title of site for display and logging purpose. Not mandatory.
        /// </summary>
        /// <value>Optional Title of site for display and logging purpose. Not mandatory.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Full Url of the site. Its of the form https://yourtenant.sharepoint.com/sites/yoursite or https://yourtenant.sharepoint.com/yoursite This parameter is required for all PnP operations.
        /// </summary>
        /// <value>Full Url of the site. Its of the form https://yourtenant.sharepoint.com/sites/yoursite or https://yourtenant.sharepoint.com/yoursite This parameter is required for all PnP operations.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Unique guid for the site root web.
        /// </summary>
        /// <value>Unique guid for the site root web.</value>
        [DataMember(Name="webid", EmitDefaultValue=false)]
        public string Webid { get; set; }

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
            return this.Equals(input as SiteIdentity);
        }

        /// <summary>
        /// Returns true if SiteIdentity instances are equal
        /// </summary>
        /// <param name="input">Instance of SiteIdentity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteIdentity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ServerRelativeurl == input.ServerRelativeurl ||
                    (this.ServerRelativeurl != null &&
                    this.ServerRelativeurl.Equals(input.ServerRelativeurl))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Webid == input.Webid ||
                    (this.Webid != null &&
                    this.Webid.Equals(input.Webid))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServerRelativeurl != null)
                    hashCode = hashCode * 59 + this.ServerRelativeurl.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Webid != null)
                    hashCode = hashCode * 59 + this.Webid.GetHashCode();
                return hashCode;
            }
        }

    }

}

