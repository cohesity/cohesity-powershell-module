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
    /// Specifies the information of activated alias views created for a view.
    /// </summary>
    [DataContract]
    public partial class ActivateViewAliasesResult :  IEquatable<ActivateViewAliasesResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateViewAliasesResult" /> class.
        /// </summary>
        /// <param name="aliases">Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name..</param>
        public ActivateViewAliasesResult(List<ViewAlias> aliases = default(List<ViewAlias>))
        {
            this.Aliases = aliases;
            this.Aliases = aliases;
        }
        
        /// <summary>
        /// Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name.
        /// </summary>
        /// <value>Aliases created for the view. A view alias allows a directory path inside a view to be mounted using the alias name.</value>
        [DataMember(Name="aliases", EmitDefaultValue=true)]
        public List<ViewAlias> Aliases { get; set; }

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
            return this.Equals(input as ActivateViewAliasesResult);
        }

        /// <summary>
        /// Returns true if ActivateViewAliasesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivateViewAliasesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivateViewAliasesResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aliases == input.Aliases ||
                    this.Aliases != null &&
                    input.Aliases != null &&
                    this.Aliases.SequenceEqual(input.Aliases)
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
                if (this.Aliases != null)
                    hashCode = hashCode * 59 + this.Aliases.GetHashCode();
                return hashCode;
            }
        }

    }

}

