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
    /// The type Item Activity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ItemActivity : Entity
    {
    
        /// <summary>
        /// Gets or sets access.
        /// An item was accessed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "access", Required = Newtonsoft.Json.Required.Default)]
        public AccessAction Access { get; set; }
    
        /// <summary>
        /// Gets or sets activity date time.
        /// Details about when the activity took place. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets actor.
        /// Identity of who performed the action. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actor", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Actor { get; set; }
    
        /// <summary>
        /// Gets or sets drive item.
        /// Exposes the driveItem that was the target of this activity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "driveItem", Required = Newtonsoft.Json.Required.Default)]
        public DriveItem DriveItem { get; set; }
    
    }
}

