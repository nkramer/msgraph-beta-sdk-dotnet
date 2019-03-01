// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type VisualInfo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class VisualInfo
    {

        /// <summary>
        /// Gets or sets attribution.
        /// Optional. JSON object used to represent an icon which represents the application used to generate the activity
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attribution", Required = Newtonsoft.Json.Required.Default)]
        public ImageInfo Attribution { get; set; }
    
        /// <summary>
        /// Gets or sets backgroundColor.
        /// Optional. Background color used to render the activity in the UI - brand color for the application source of the activity. Must be a valid hex color
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "backgroundColor", Required = Newtonsoft.Json.Required.Default)]
        public string BackgroundColor { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Optional. Longer text description of the user's unique activity (example: document name, first sentence, and/or metadata)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets displayText.
        /// Required. Short text description of the user's unique activity (for example, document name in cases where an activity refers to document creation)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayText", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayText { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// Optional. Custom piece of data - JSON object used to provide custom content to render the activity in the Windows Shell UI
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Content { get; set; }
    
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
