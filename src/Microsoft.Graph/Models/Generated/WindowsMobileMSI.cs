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
    /// The type Windows Mobile MSI.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsMobileMSI : MobileLobApp
    {
    
        /// <summary>
        /// Gets or sets command line.
        /// The command line.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "commandLine", Required = Newtonsoft.Json.Required.Default)]
        public string CommandLine { get; set; }
    
        /// <summary>
        /// Gets or sets product code.
        /// The product code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productCode", Required = Newtonsoft.Json.Required.Default)]
        public string ProductCode { get; set; }
    
        /// <summary>
        /// Gets or sets product version.
        /// The product version of Windows Mobile MSI Line of Business (LoB) app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ProductVersion { get; set; }
    
        /// <summary>
        /// Gets or sets ignore version detection.
        /// A boolean to control whether the app's version will be used to detect the app after it is installed on a device. Set this to true for Windows Mobile MSI Line of Business (LoB) apps that use a self update feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ignoreVersionDetection", Required = Newtonsoft.Json.Required.Default)]
        public bool? IgnoreVersionDetection { get; set; }
    
    }
}

