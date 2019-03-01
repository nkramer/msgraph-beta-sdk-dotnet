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
    /// The type Profile Photo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProfilePhoto : Entity
    {
    
        /// <summary>
        /// Gets or sets height.
        /// The height of the photo. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "height", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Height { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// The width of the photo. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "width", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Width { get; set; }
    
    }
}

