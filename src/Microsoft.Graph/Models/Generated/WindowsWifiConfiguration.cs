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
    /// The type Windows Wifi Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsWifiConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets pre shared key.
        /// This is the pre-shared key for WPA Personal Wi-Fi network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preSharedKey", Required = Newtonsoft.Json.Required.Default)]
        public string PreSharedKey { get; set; }
    
        /// <summary>
        /// Gets or sets wifi security type.
        /// Specify the Wifi Security Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiSecurityType", Required = Newtonsoft.Json.Required.Default)]
        public WiFiSecurityType? WifiSecurityType { get; set; }
    
        /// <summary>
        /// Gets or sets metered connection limit.
        /// Specify the metered connection limit type for the wifi connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meteredConnectionLimit", Required = Newtonsoft.Json.Required.Default)]
        public MeteredConnectionLimitType? MeteredConnectionLimit { get; set; }
    
        /// <summary>
        /// Gets or sets ssid.
        /// Specify the SSID of the wifi connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ssid", Required = Newtonsoft.Json.Required.Default)]
        public string Ssid { get; set; }
    
        /// <summary>
        /// Gets or sets network name.
        /// Specify the network configuration name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkName", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets connect automatically.
        /// Specify whether the wifi connection should connect automatically when in range.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectAutomatically", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets connect to preferred network.
        /// Specify whether the wifi connection should connect to more preferred networks when already connected to this one.  Requires ConnectAutomatically to be true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectToPreferredNetwork", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectToPreferredNetwork { get; set; }
    
        /// <summary>
        /// Gets or sets connect when network name is hidden.
        /// Specify whether the wifi connection should connect automatically even when the SSID is not broadcasting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectWhenNetworkNameIsHidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets proxy setting.
        /// Specify the proxy setting for Wi-Fi configuration
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxySetting", Required = Newtonsoft.Json.Required.Default)]
        public WiFiProxySetting? ProxySetting { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual address.
        /// Specify the IP address for the proxy server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyManualAddress", Required = Newtonsoft.Json.Required.Default)]
        public string ProxyManualAddress { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual port.
        /// Specify the port for the proxy server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyManualPort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ProxyManualPort { get; set; }
    
        /// <summary>
        /// Gets or sets proxy automatic configuration url.
        /// Specify the URL for the proxy server configuration script.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyAutomaticConfigurationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ProxyAutomaticConfigurationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets force fipscompliance.
        /// Specify whether to force FIPS compliance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "forceFIPSCompliance", Required = Newtonsoft.Json.Required.Default)]
        public bool? ForceFIPSCompliance { get; set; }
    
    }
}

