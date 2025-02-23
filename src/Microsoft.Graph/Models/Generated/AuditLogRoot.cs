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
    /// The type Audit Log Root.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AuditLogRoot : Entity
    {
    
        /// <summary>
        /// Gets or sets sign ins.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signIns", Required = Newtonsoft.Json.Required.Default)]
        public IAuditLogRootSignInsCollectionPage SignIns { get; set; }
    
        /// <summary>
        /// Gets or sets directory audits.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directoryAudits", Required = Newtonsoft.Json.Required.Default)]
        public IAuditLogRootDirectoryAuditsCollectionPage DirectoryAudits { get; set; }
    
        /// <summary>
        /// Gets or sets restricted sign ins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restrictedSignIns", Required = Newtonsoft.Json.Required.Default)]
        public IAuditLogRootRestrictedSignInsCollectionPage RestrictedSignIns { get; set; }
    
        /// <summary>
        /// Gets or sets directory provisioning.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directoryProvisioning", Required = Newtonsoft.Json.Required.Default)]
        public IAuditLogRootDirectoryProvisioningCollectionPage DirectoryProvisioning { get; set; }
    
        /// <summary>
        /// Gets or sets provisioning.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisioning", Required = Newtonsoft.Json.Required.Default)]
        public IAuditLogRootProvisioningCollectionPage Provisioning { get; set; }
    
    }
}

