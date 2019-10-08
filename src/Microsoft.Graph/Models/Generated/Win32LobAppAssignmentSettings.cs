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
    /// The type Win32LobAppAssignmentSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Win32LobAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppAssignmentSettings"/> class.
        /// </summary>
        public Win32LobAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.win32LobAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets notifications.
        /// The notification status for this app assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notifications", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppNotification? Notifications { get; set; }
    
    }
}
