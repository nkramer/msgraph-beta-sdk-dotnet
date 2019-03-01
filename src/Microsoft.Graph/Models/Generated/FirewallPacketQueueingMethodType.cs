// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum FirewallPacketQueueingMethodType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FirewallPacketQueueingMethodType
    {
    
        /// <summary>
        /// device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// disabled
        /// </summary>
        Disabled = 1,
	
        /// <summary>
        /// queue Inbound
        /// </summary>
        QueueInbound = 2,
	
        /// <summary>
        /// queue Outbound
        /// </summary>
        QueueOutbound = 3,
	
        /// <summary>
        /// queue Both
        /// </summary>
        QueueBoth = 4,
	
    }
}
