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
    /// The type DeviceConfigurationTargetedUserAndDevice.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceConfigurationTargetedUserAndDevice
    {

        /// <summary>
        /// Gets or sets deviceId.
        /// The id of the device in the checkin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets deviceName.
        /// The name of the device in the checkin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// The id of the user in the checkin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets userDisplayName.
        /// The display name of the user in the checkin
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// The UPN of the user in the checkin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets lastCheckinDateTime.
        /// Last checkin time for this user/device pair.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastCheckinDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastCheckinDateTime { get; set; }
    
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
