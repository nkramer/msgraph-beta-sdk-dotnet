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
    /// The type Targeted Managed App Policy Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TargetedManagedAppPolicyAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets target.
        /// Identifier for deployment of a group or app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// Type of resource used for deployment to a group, direct or parcel/policySet
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentSource? Source { get; set; }
    
        /// <summary>
        /// Gets or sets source id.
        /// Identifier for resource used for deployment to a group
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceId", Required = Newtonsoft.Json.Required.Default)]
        public string SourceId { get; set; }
    
    }
}

