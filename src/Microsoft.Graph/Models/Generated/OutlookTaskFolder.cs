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
    /// The type Outlook Task Folder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OutlookTaskFolder : Entity
    {
    
        /// <summary>
        /// Gets or sets change key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "changeKey", Required = Newtonsoft.Json.Required.Default)]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets is default folder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefaultFolder", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefaultFolder { get; set; }
    
        /// <summary>
        /// Gets or sets parent group key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentGroupKey", Required = Newtonsoft.Json.Required.Default)]
        public Guid? ParentGroupKey { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tasks", Required = Newtonsoft.Json.Required.Default)]
        public IOutlookTaskFolderTasksCollectionPage Tasks { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IOutlookTaskFolderSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IOutlookTaskFolderMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
    }
}

