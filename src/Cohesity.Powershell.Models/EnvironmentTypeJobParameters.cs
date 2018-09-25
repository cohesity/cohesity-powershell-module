using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cohesity.Models
{
    /// <summary>
    /// Specifies additional parameters that are applicable to all Protection Sources in a Protection Job created for a particular environment type.
    /// </summary>
    [DataContract]
    public partial class EnvironmentTypeJobParameters : IEquatable<EnvironmentTypeJobParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTypeJobParameters" /> class.
        /// </summary>
        /// <param name="hypervParameters">Specifies additional special parameters that are applicable only to Types of &#39;kHyperV&#39; type..</param>
        /// <param name="nasParameters">Specifies additional special parameters that are applicable only to Types of &#39;kGenericNas&#39; type..</param>
        /// <param name="physicalParameters">Specifies additional special parameters that are applicable only to Sources of &#39;kPhysical&#39; type in a kPhysical environment..</param>
        /// <param name="pureParameters">Specifies additional special parameters that are applicable only to Types of &#39;kPure&#39; type..</param>
        /// <param name="sqlParameters">Specifies additional special parameters that are applicable only to Types of &#39;kSQL&#39; type..</param>
        /// <param name="vmwareParameters">Specifies additional special parameters that are applicable only to Types of &#39;kVMware&#39; type..</param>
        public EnvironmentTypeJobParameters(HypervEnvJobParameters hypervParameters = default(HypervEnvJobParameters), NasEnvJobParameters nasParameters = default(NasEnvJobParameters), PhysicalEnvJobParameters physicalParameters = default(PhysicalEnvJobParameters), PureEnvJobParameters pureParameters = default(PureEnvJobParameters), SqlEnvJobParameters sqlParameters = default(SqlEnvJobParameters), VmwareEnvJobParameters vmwareParameters = default(VmwareEnvJobParameters))
        {
            this.HypervParameters = hypervParameters;
            this.NasParameters = nasParameters;
            this.PhysicalParameters = physicalParameters;
            this.PureParameters = pureParameters;
            this.SqlParameters = sqlParameters;
            this.VmwareParameters = vmwareParameters;
        }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Types of &#39;kHyperV&#39; type.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Types of &#39;kHyperV&#39; type.</value>
        [DataMember(Name = "hypervParameters", EmitDefaultValue = false)]
        public HypervEnvJobParameters HypervParameters { get; set; }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Types of &#39;kGenericNas&#39; type.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Types of &#39;kGenericNas&#39; type.</value>
        [DataMember(Name = "nasParameters", EmitDefaultValue = false)]
        public NasEnvJobParameters NasParameters { get; set; }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Sources of &#39;kPhysical&#39; type in a kPhysical environment.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Sources of &#39;kPhysical&#39; type in a kPhysical environment.</value>
        [DataMember(Name = "physicalParameters", EmitDefaultValue = false)]
        public PhysicalEnvJobParameters PhysicalParameters { get; set; }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Types of &#39;kPure&#39; type.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Types of &#39;kPure&#39; type.</value>
        [DataMember(Name = "pureParameters", EmitDefaultValue = false)]
        public PureEnvJobParameters PureParameters { get; set; }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Types of &#39;kSQL&#39; type.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Types of &#39;kSQL&#39; type.</value>
        [DataMember(Name = "sqlParameters", EmitDefaultValue = false)]
        public SqlEnvJobParameters SqlParameters { get; set; }

        /// <summary>
        /// Specifies additional special parameters that are applicable only to Types of &#39;kVMware&#39; type.
        /// </summary>
        /// <value>Specifies additional special parameters that are applicable only to Types of &#39;kVMware&#39; type.</value>
        [DataMember(Name = "vmwareParameters", EmitDefaultValue = false)]
        public VmwareEnvJobParameters VmwareParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return ToJson();
        }
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class EnvironmentTypeJobParameters {\n");
        //    sb.Append("  HypervParameters: ").Append(HypervParameters).Append("\n");
        //    sb.Append("  NasParameters: ").Append(NasParameters).Append("\n");
        //    sb.Append("  PhysicalParameters: ").Append(PhysicalParameters).Append("\n");
        //    sb.Append("  PureParameters: ").Append(PureParameters).Append("\n");
        //    sb.Append("  SqlParameters: ").Append(SqlParameters).Append("\n");
        //    sb.Append("  VmwareParameters: ").Append(VmwareParameters).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}

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
            return this.Equals(input as EnvironmentTypeJobParameters);
        }

        /// <summary>
        /// Returns true if EnvironmentTypeJobParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvironmentTypeJobParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentTypeJobParameters input)
        {
            if (input == null)
                return false;

            return
                (
                    this.HypervParameters == input.HypervParameters ||
                    (this.HypervParameters != null &&
                    this.HypervParameters.Equals(input.HypervParameters))
                ) &&
                (
                    this.NasParameters == input.NasParameters ||
                    (this.NasParameters != null &&
                    this.NasParameters.Equals(input.NasParameters))
                ) &&
                (
                    this.PhysicalParameters == input.PhysicalParameters ||
                    (this.PhysicalParameters != null &&
                    this.PhysicalParameters.Equals(input.PhysicalParameters))
                ) &&
                (
                    this.PureParameters == input.PureParameters ||
                    (this.PureParameters != null &&
                    this.PureParameters.Equals(input.PureParameters))
                ) &&
                (
                    this.SqlParameters == input.SqlParameters ||
                    (this.SqlParameters != null &&
                    this.SqlParameters.Equals(input.SqlParameters))
                ) &&
                (
                    this.VmwareParameters == input.VmwareParameters ||
                    (this.VmwareParameters != null &&
                    this.VmwareParameters.Equals(input.VmwareParameters))
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
                if (this.HypervParameters != null)
                    hashCode = hashCode * 59 + this.HypervParameters.GetHashCode();
                if (this.NasParameters != null)
                    hashCode = hashCode * 59 + this.NasParameters.GetHashCode();
                if (this.PhysicalParameters != null)
                    hashCode = hashCode * 59 + this.PhysicalParameters.GetHashCode();
                if (this.PureParameters != null)
                    hashCode = hashCode * 59 + this.PureParameters.GetHashCode();
                if (this.SqlParameters != null)
                    hashCode = hashCode * 59 + this.SqlParameters.GetHashCode();
                if (this.VmwareParameters != null)
                    hashCode = hashCode * 59 + this.VmwareParameters.GetHashCode();
                return hashCode;
            }
        }

    }
}

