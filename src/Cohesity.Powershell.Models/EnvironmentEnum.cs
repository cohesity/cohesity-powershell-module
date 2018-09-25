// Copyright 2018 Cohesity Inc.

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cohesity.Models
{
    /// <summary>
    /// Specifies the environment type (such as kVMware or kSQL) that contains the source to backup. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.
    /// </summary>
    /// <value>Specifies the environment type (such as kVMware or kSQL) that contains the source to backup. Supported environment types include &#39;kView&#39;, &#39;kSQL&#39;, &#39;kVMware&#39;, &#39;kPuppeteer&#39;, &#39;kPhysical&#39;, &#39;kPure&#39;, &#39;kNetapp, &#39;kGenericNas, &#39;kHyperV&#39;, &#39;kAcropolis&#39;, &#39;kAzure&#39;. NOTE: &#39;kPuppeteer&#39; refers to Cohesity&#39;s Remote Adapter.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnvironmentEnum
    {

        [EnumMember(Value = "kVMware")]
        kVMware = 1,

        [EnumMember(Value = "kHyperV")]
        kHyperV = 2,

        [EnumMember(Value = "kSQL")]
        kSQL = 3,

        [EnumMember(Value = "kView")]
        kView = 4,

        [EnumMember(Value = "kPuppeteer")]
        kPuppeteer = 5,

        [EnumMember(Value = "kPhysical")]
        kPhysical = 6,

        [EnumMember(Value = "kPure")]
        kPure = 7,

        [EnumMember(Value = "kAzure")]
        kAzure = 8,

        [EnumMember(Value = "kNetapp")]
        kNetapp = 9,

        [EnumMember(Value = "kAgent")]
        kAgent = 10,

        [EnumMember(Value = "kGenericNas")]
        kGenericNas = 11,

        [EnumMember(Value = "kAcropolis")]
        kAcropolis = 12,

        [EnumMember(Value = "kPhysicalFiles")]
        kPhysicalFiles = 13,

        [EnumMember(Value = "kIsilon")]
        kIsilon = 14,

        [EnumMember(Value = "kKVM")]
        kKVM = 15,

        [EnumMember(Value = "kAWS")]
        kAWS = 16,

        [EnumMember(Value = "kExchange")]
        kExchange = 17,

        [EnumMember(Value = "kHyperVVSS")]
        kHyperVVSS = 18,

        [EnumMember(Value = "kOracle")]
        kOracle = 19,

        [EnumMember(Value = "kGCP")]
        kGCP = 20,

        [EnumMember(Value = "kFlashBlade")]
        kFlashBlade = 21,

        [EnumMember(Value = "kAWSNative")]
        kAWSNative = 22,

        [EnumMember(Value = "kVCD")]
        kVCD = 23,

        [EnumMember(Value = "kO365")]
        kO365 = 24,

        [EnumMember(Value = "kO365Outlook")]
        kO365Outlook = 25,

        [EnumMember(Value = "kHyperFlex")]
        kHyperFlex = 26,

        [EnumMember(Value = "kGCPNative")]
        kGCPNative = 27
    }
}

