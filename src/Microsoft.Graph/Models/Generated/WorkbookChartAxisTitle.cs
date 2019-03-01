// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook Chart Axis Title.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartAxisTitle : Entity
    {
    
        /// <summary>
        /// Gets or sets text.
        /// Represents the axis title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public string Text { get; set; }
    
        /// <summary>
        /// Gets or sets visible.
        /// A boolean that specifies the visibility of an axis title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visible", Required = Newtonsoft.Json.Required.Default)]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the formatting of chart axis title. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartAxisTitleFormat Format { get; set; }
    
    }
}

