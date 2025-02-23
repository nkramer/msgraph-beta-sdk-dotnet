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
    /// The type Directory.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Directory : Entity
    {
    
        /// <summary>
        /// Gets or sets deleted items.
        /// Recently deleted items. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deletedItems", Required = Newtonsoft.Json.Required.Default)]
        public IDirectoryDeletedItemsCollectionPage DeletedItems { get; set; }
    
        /// <summary>
        /// Gets or sets feature rollout policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureRolloutPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDirectoryFeatureRolloutPoliciesCollectionPage FeatureRolloutPolicies { get; set; }
    
    }
}

