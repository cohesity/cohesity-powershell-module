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
    /// Specifies the exchange restore parameters.
    /// </summary>
    [DataContract]
    public partial class ExchangeRestoreParameters :  IEquatable<ExchangeRestoreParameters>
    {
        /// <summary>
        /// Specifies the Exchange restore type. Specifies the type of Exchange restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kView&#39; specifies the option to create a view which cann be used by the external tools like Kroll to perform mailbox or mail-item recovery. &#39;kDatabase&#39; specifies the option to restore an Exchange database.
        /// </summary>
        /// <value>Specifies the Exchange restore type. Specifies the type of Exchange restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kView&#39; specifies the option to create a view which cann be used by the external tools like Kroll to perform mailbox or mail-item recovery. &#39;kDatabase&#39; specifies the option to restore an Exchange database.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum KNone for value: kNone
            /// </summary>
            [EnumMember(Value = "kNone")]
            KNone = 1,

            /// <summary>
            /// Enum KView for value: kView
            /// </summary>
            [EnumMember(Value = "kView")]
            KView = 2,

            /// <summary>
            /// Enum KDatabase for value: kDatabase
            /// </summary>
            [EnumMember(Value = "kDatabase")]
            KDatabase = 3

        }

        /// <summary>
        /// Specifies the Exchange restore type. Specifies the type of Exchange restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kView&#39; specifies the option to create a view which cann be used by the external tools like Kroll to perform mailbox or mail-item recovery. &#39;kDatabase&#39; specifies the option to restore an Exchange database.
        /// </summary>
        /// <value>Specifies the Exchange restore type. Specifies the type of Exchange restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kView&#39; specifies the option to create a view which cann be used by the external tools like Kroll to perform mailbox or mail-item recovery. &#39;kDatabase&#39; specifies the option to restore an Exchange database.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeRestoreParameters" /> class.
        /// </summary>
        /// <param name="type">Specifies the Exchange restore type. Specifies the type of Exchange restore.  &#39;kNone&#39; specifies no special behaviour. &#39;kView&#39; specifies the option to create a view which cann be used by the external tools like Kroll to perform mailbox or mail-item recovery. &#39;kDatabase&#39; specifies the option to restore an Exchange database..</param>
        /// <param name="viewParameters">viewParameters.</param>
        public ExchangeRestoreParameters(TypeEnum? type = default(TypeEnum?), ExchangeRestoreViewParameters viewParameters = default(ExchangeRestoreViewParameters))
        {
            this.Type = type;
            this.Type = type;
            this.ViewParameters = viewParameters;
        }
        
        /// <summary>
        /// Gets or Sets ViewParameters
        /// </summary>
        [DataMember(Name="viewParameters", EmitDefaultValue=false)]
        public ExchangeRestoreViewParameters ViewParameters { get; set; }

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
            return this.Equals(input as ExchangeRestoreParameters);
        }

        /// <summary>
        /// Returns true if ExchangeRestoreParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeRestoreParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeRestoreParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ViewParameters == input.ViewParameters ||
                    (this.ViewParameters != null &&
                    this.ViewParameters.Equals(input.ViewParameters))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ViewParameters != null)
                    hashCode = hashCode * 59 + this.ViewParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}

