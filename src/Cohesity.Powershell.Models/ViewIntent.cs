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
    /// Specifies the Intent of the View.
    /// </summary>
    [DataContract]
    public partial class ViewIntent :  IEquatable<ViewIntent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewIntent" /> class.
        /// </summary>
        /// <param name="templateId">Specifies the template Id from which the View is created..</param>
        /// <param name="templateName">Specifies the template name from which the View is created..</param>
        public ViewIntent(long? templateId = default(long?), string templateName = default(string))
        {
            this.TemplateId = templateId;
            this.TemplateName = templateName;
            this.TemplateId = templateId;
            this.TemplateName = templateName;
        }
        
        /// <summary>
        /// Specifies the template Id from which the View is created.
        /// </summary>
        /// <value>Specifies the template Id from which the View is created.</value>
        [DataMember(Name="TemplateId", EmitDefaultValue=true)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// Specifies the template name from which the View is created.
        /// </summary>
        /// <value>Specifies the template name from which the View is created.</value>
        [DataMember(Name="TemplateName", EmitDefaultValue=true)]
        public string TemplateName { get; set; }

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
            return this.Equals(input as ViewIntent);
        }

        /// <summary>
        /// Returns true if ViewIntent instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewIntent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                return hashCode;
            }
        }

    }

}

