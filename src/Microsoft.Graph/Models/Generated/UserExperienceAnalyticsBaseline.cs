// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type User Experience Analytics Baseline.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserExperienceAnalyticsBaseline : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the user experience analytics baseline.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is built in.
        /// Signifies if the current baseline is the commercial median baseline or a custom baseline.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isBuiltIn", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsBuiltIn { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date the custom baseline was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device boot performance metrics.
        /// The user experience analytics device boot performance metrics.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceBootPerformanceMetrics", Required = Newtonsoft.Json.Required.Default)]
        public UserExperienceAnalyticsCategory DeviceBootPerformanceMetrics { get; set; }
    
        /// <summary>
        /// Gets or sets best practices metrics.
        /// The user experience analytics best practices metrics.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bestPracticesMetrics", Required = Newtonsoft.Json.Required.Default)]
        public UserExperienceAnalyticsCategory BestPracticesMetrics { get; set; }
    
    }
}

