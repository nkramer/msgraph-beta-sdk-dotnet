// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceManagementApplicabilityRuleOsVersion.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceManagementApplicabilityRuleOsVersion
    {

        /// <summary>
        /// Gets or sets minOSVersion.
        /// Min OS version for Applicability Rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minOSVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinOSVersion { get; set; }
    
        /// <summary>
        /// Gets or sets maxOSVersion.
        /// Max OS version for Applicability Rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxOSVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MaxOSVersion { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name for object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets ruleType.
        /// Applicability Rule type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ruleType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementApplicabilityRuleType? RuleType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
