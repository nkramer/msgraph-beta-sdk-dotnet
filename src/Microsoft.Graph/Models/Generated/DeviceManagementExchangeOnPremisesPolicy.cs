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
    /// The type Device Management Exchange On Premises Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementExchangeOnPremisesPolicy : Entity
    {
    
        /// <summary>
        /// Gets or sets notification content.
        /// Notification text that will be sent to users quarantined by this policy. This is UTF8 encoded byte array HTML.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationContent", Required = Newtonsoft.Json.Required.Default)]
        public byte[] NotificationContent { get; set; }
    
        /// <summary>
        /// Gets or sets default access level.
        /// Default access state in Exchange. This rule applies globally to the entire Exchange organization
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultAccessLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementExchangeAccessLevel? DefaultAccessLevel { get; set; }
    
        /// <summary>
        /// Gets or sets access rules.
        /// The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessRules", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceManagementExchangeAccessRule> AccessRules { get; set; }
    
        /// <summary>
        /// Gets or sets known device classes.
        /// The list of device classes known to Exchange
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "knownDeviceClasses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceManagementExchangeDeviceClass> KnownDeviceClasses { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access settings.
        /// The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessSettings", Required = Newtonsoft.Json.Required.Default)]
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
    
    }
}

