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
    /// The type Event Message Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EventMessageRequestObject : EventMessage
    {
    
        /// <summary>
        /// Gets or sets previous location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousLocation", Required = Newtonsoft.Json.Required.Default)]
        public Location PreviousLocation { get; set; }
    
        /// <summary>
        /// Gets or sets previous start date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousStartDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone PreviousStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets previous end date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previousEndDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone PreviousEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets response requested.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responseRequested", Required = Newtonsoft.Json.Required.Default)]
        public bool? ResponseRequested { get; set; }
    
    }
}

