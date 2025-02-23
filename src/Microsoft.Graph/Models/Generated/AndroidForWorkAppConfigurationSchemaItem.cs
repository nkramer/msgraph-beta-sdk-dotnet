// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AndroidForWorkAppConfigurationSchemaItem.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AndroidForWorkAppConfigurationSchemaItem
    {

        /// <summary>
        /// Gets or sets schemaItemKey.
        /// Unique key the application uses to identify the item
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schemaItemKey", Required = Newtonsoft.Json.Required.Default)]
        public string SchemaItemKey { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Human readable name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of what the item controls within the application
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets defaultBoolValue.
        /// Default value for boolean type items, if specified by the app developer
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultBoolValue", Required = Newtonsoft.Json.Required.Default)]
        public bool? DefaultBoolValue { get; set; }
    
        /// <summary>
        /// Gets or sets defaultIntValue.
        /// Default value for integer type items, if specified by the app developer
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultIntValue", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DefaultIntValue { get; set; }
    
        /// <summary>
        /// Gets or sets defaultStringValue.
        /// Default value for string type items, if specified by the app developer
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultStringValue", Required = Newtonsoft.Json.Required.Default)]
        public string DefaultStringValue { get; set; }
    
        /// <summary>
        /// Gets or sets defaultStringArrayValue.
        /// Default value for string array type items, if specified by the app developer
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultStringArrayValue", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DefaultStringArrayValue { get; set; }
    
        /// <summary>
        /// Gets or sets dataType.
        /// The type of value this item describes
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkAppConfigurationSchemaItemDataType? DataType { get; set; }
    
        /// <summary>
        /// Gets or sets selections.
        /// List of human readable name/value pairs for the valid values that can be set for this item (Choice and Multiselect items only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "selections", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> Selections { get; set; }
    
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
