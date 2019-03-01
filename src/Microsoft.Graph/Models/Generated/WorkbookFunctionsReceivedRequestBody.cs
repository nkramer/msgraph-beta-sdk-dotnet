// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsReceivedRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsReceivedRequestBody
    {
    
        /// <summary>
        /// Gets or sets Settlement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settlement", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Settlement { get; set; }
    
        /// <summary>
        /// Gets or sets Maturity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maturity", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Maturity { get; set; }
    
        /// <summary>
        /// Gets or sets Investment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "investment", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Investment { get; set; }
    
        /// <summary>
        /// Gets or sets Discount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discount", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Discount { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "basis", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Basis { get; set; }
    
    }
}
