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
    /// The type Chat.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Chat : Entity
    {
    
        /// <summary>
        /// Gets or sets topic.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topic", Required = Newtonsoft.Json.Required.Default)]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets installed apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedApps", Required = Newtonsoft.Json.Required.Default)]
        public IChatInstalledAppsCollectionPage InstalledApps { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IChatMembersCollectionPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messages", Required = Newtonsoft.Json.Required.Default)]
        public IChatMessagesCollectionPage Messages { get; set; }
    
    }
}

