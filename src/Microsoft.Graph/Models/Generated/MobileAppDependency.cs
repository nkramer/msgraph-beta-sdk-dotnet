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
    /// The type Mobile App Dependency.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppDependency : MobileAppRelationship
    {
    
        /// <summary>
        /// Gets or sets dependency type.
        /// The type of dependency relationship between the parent and child apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dependencyType", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppDependencyType? DependencyType { get; set; }
    
        /// <summary>
        /// Gets or sets dependent app count.
        /// The total number of dependencies the child app has.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dependentAppCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DependentAppCount { get; set; }
    
    }
}

