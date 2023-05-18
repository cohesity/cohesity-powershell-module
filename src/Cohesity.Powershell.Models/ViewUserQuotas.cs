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
    /// Specifies the Result parameters for all user quotas of a view.
    /// </summary>
    [DataContract]
    public partial class ViewUserQuotas :  IEquatable<ViewUserQuotas>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewUserQuotas" /> class.
        /// </summary>
        /// <param name="cookie">This cookie can be used in the succeeding call to list user quotas and usages to get the next set of user quota overrides. If set to nil, it means that there&#39;s no more results that the server could provide..</param>
        /// <param name="quotaAndUsageInAllViews">The quota and usage information for a user in all his views..</param>
        /// <param name="summaryForUser">summaryForUser.</param>
        /// <param name="summaryForView">summaryForView.</param>
        /// <param name="userQuotaSettings">userQuotaSettings.</param>
        /// <param name="usersQuotaAndUsage">The list of user quota policies/overrides and usages..</param>
        public ViewUserQuotas(string cookie = default(string), List<QuotaAndUsageInView> quotaAndUsageInAllViews = default(List<QuotaAndUsageInView>), UserQuotaSummaryForUser summaryForUser = default(UserQuotaSummaryForUser), UserQuotaSummaryForView summaryForView = default(UserQuotaSummaryForView), UserQuotaSettings userQuotaSettings = default(UserQuotaSettings), List<UserQuotaAndUsage> usersQuotaAndUsage = default(List<UserQuotaAndUsage>))
        {
            this.Cookie = cookie;
            this.QuotaAndUsageInAllViews = quotaAndUsageInAllViews;
            this.UsersQuotaAndUsage = usersQuotaAndUsage;
            this.Cookie = cookie;
            this.QuotaAndUsageInAllViews = quotaAndUsageInAllViews;
            this.SummaryForUser = summaryForUser;
            this.SummaryForView = summaryForView;
            this.UserQuotaSettings = userQuotaSettings;
            this.UsersQuotaAndUsage = usersQuotaAndUsage;
        }
        
        /// <summary>
        /// This cookie can be used in the succeeding call to list user quotas and usages to get the next set of user quota overrides. If set to nil, it means that there&#39;s no more results that the server could provide.
        /// </summary>
        /// <value>This cookie can be used in the succeeding call to list user quotas and usages to get the next set of user quota overrides. If set to nil, it means that there&#39;s no more results that the server could provide.</value>
        [DataMember(Name="cookie", EmitDefaultValue=true)]
        public string Cookie { get; set; }

        /// <summary>
        /// The quota and usage information for a user in all his views.
        /// </summary>
        /// <value>The quota and usage information for a user in all his views.</value>
        [DataMember(Name="quotaAndUsageInAllViews", EmitDefaultValue=true)]
        public List<QuotaAndUsageInView> QuotaAndUsageInAllViews { get; set; }

        /// <summary>
        /// Gets or Sets SummaryForUser
        /// </summary>
        [DataMember(Name="summaryForUser", EmitDefaultValue=false)]
        public UserQuotaSummaryForUser SummaryForUser { get; set; }

        /// <summary>
        /// Gets or Sets SummaryForView
        /// </summary>
        [DataMember(Name="summaryForView", EmitDefaultValue=false)]
        public UserQuotaSummaryForView SummaryForView { get; set; }

        /// <summary>
        /// Gets or Sets UserQuotaSettings
        /// </summary>
        [DataMember(Name="userQuotaSettings", EmitDefaultValue=false)]
        public UserQuotaSettings UserQuotaSettings { get; set; }

        /// <summary>
        /// The list of user quota policies/overrides and usages.
        /// </summary>
        /// <value>The list of user quota policies/overrides and usages.</value>
        [DataMember(Name="usersQuotaAndUsage", EmitDefaultValue=true)]
        public List<UserQuotaAndUsage> UsersQuotaAndUsage { get; set; }

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
            return this.Equals(input as ViewUserQuotas);
        }

        /// <summary>
        /// Returns true if ViewUserQuotas instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewUserQuotas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewUserQuotas input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cookie == input.Cookie ||
                    (this.Cookie != null &&
                    this.Cookie.Equals(input.Cookie))
                ) && 
                (
                    this.QuotaAndUsageInAllViews == input.QuotaAndUsageInAllViews ||
                    this.QuotaAndUsageInAllViews != null &&
                    input.QuotaAndUsageInAllViews != null &&
                    this.QuotaAndUsageInAllViews.SequenceEqual(input.QuotaAndUsageInAllViews)
                ) && 
                (
                    this.SummaryForUser == input.SummaryForUser ||
                    (this.SummaryForUser != null &&
                    this.SummaryForUser.Equals(input.SummaryForUser))
                ) && 
                (
                    this.SummaryForView == input.SummaryForView ||
                    (this.SummaryForView != null &&
                    this.SummaryForView.Equals(input.SummaryForView))
                ) && 
                (
                    this.UserQuotaSettings == input.UserQuotaSettings ||
                    (this.UserQuotaSettings != null &&
                    this.UserQuotaSettings.Equals(input.UserQuotaSettings))
                ) && 
                (
                    this.UsersQuotaAndUsage == input.UsersQuotaAndUsage ||
                    this.UsersQuotaAndUsage != null &&
                    input.UsersQuotaAndUsage != null &&
                    this.UsersQuotaAndUsage.SequenceEqual(input.UsersQuotaAndUsage)
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
                if (this.Cookie != null)
                    hashCode = hashCode * 59 + this.Cookie.GetHashCode();
                if (this.QuotaAndUsageInAllViews != null)
                    hashCode = hashCode * 59 + this.QuotaAndUsageInAllViews.GetHashCode();
                if (this.SummaryForUser != null)
                    hashCode = hashCode * 59 + this.SummaryForUser.GetHashCode();
                if (this.SummaryForView != null)
                    hashCode = hashCode * 59 + this.SummaryForView.GetHashCode();
                if (this.UserQuotaSettings != null)
                    hashCode = hashCode * 59 + this.UserQuotaSettings.GetHashCode();
                if (this.UsersQuotaAndUsage != null)
                    hashCode = hashCode * 59 + this.UsersQuotaAndUsage.GetHashCode();
                return hashCode;
            }
        }

    }

}

