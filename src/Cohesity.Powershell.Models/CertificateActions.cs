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
    /// CertificateActions is used for tracking certificate-related operations (e.g., ADD or DELETE) that are pending for an entity. These actions are recorded during operations such as register source, unregister source, rotate certificate, or update source.
    /// </summary>
    [DataContract]
    public partial class CertificateActions :  IEquatable<CertificateActions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateActions" /> class.
        /// </summary>
        /// <param name="actions">A map of composite keys to their corresponding action (ADD or DELETE). The key is a colon-separated string in the format: \&quot;tenant_id:source_name:app_id:certificate_id\&quot;. These references are stored in the cert_store to indicate that this certificate is used by a particular entity.  Note: &#39;app_id&#39; is used here as an example for an O365 workflow. This format may vary based on the specific integration or use case..</param>
        public CertificateActions(Dictionary<string, int> actions = default(Dictionary<string, int>))
        {
            this.Actions = actions;
            this.Actions = actions;
        }
        
        /// <summary>
        /// A map of composite keys to their corresponding action (ADD or DELETE). The key is a colon-separated string in the format: \&quot;tenant_id:source_name:app_id:certificate_id\&quot;. These references are stored in the cert_store to indicate that this certificate is used by a particular entity.  Note: &#39;app_id&#39; is used here as an example for an O365 workflow. This format may vary based on the specific integration or use case.
        /// </summary>
        /// <value>A map of composite keys to their corresponding action (ADD or DELETE). The key is a colon-separated string in the format: \&quot;tenant_id:source_name:app_id:certificate_id\&quot;. These references are stored in the cert_store to indicate that this certificate is used by a particular entity.  Note: &#39;app_id&#39; is used here as an example for an O365 workflow. This format may vary based on the specific integration or use case.</value>
        [DataMember(Name="actions", EmitDefaultValue=true)]
        public Dictionary<string, int> Actions { get; set; }

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
            return this.Equals(input as CertificateActions);
        }

        /// <summary>
        /// Returns true if CertificateActions instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateActions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }

    }

}

