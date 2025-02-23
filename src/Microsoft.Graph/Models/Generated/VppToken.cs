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
    /// The type Vpp Token.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class VppToken : Entity
    {
    
        /// <summary>
        /// Gets or sets organization name.
        /// The organization associated with the Apple Volume Purchase Program Token
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizationName", Required = Newtonsoft.Json.Required.Default)]
        public string OrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token account type.
        /// The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppTokenAccountType", Required = Newtonsoft.Json.Required.Default)]
        public VppTokenAccountType? VppTokenAccountType { get; set; }
    
        /// <summary>
        /// Gets or sets apple id.
        /// The apple Id associated with the given Apple Volume Purchase Program Token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleId", Required = Newtonsoft.Json.Required.Default)]
        public string AppleId { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The expiration date time of the Apple Volume Purchase Program Token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The last time when an application sync was done with the Apple volume purchase program service using the Apple Volume Purchase Program Token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets token.
        /// The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "token", Required = Newtonsoft.Json.Required.Default)]
        public string Token { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modification date time associated with the Apple Volume Purchase Program Token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Current state of the Apple Volume Purchase Program Token. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public VppTokenState? State { get; set; }
    
        /// <summary>
        /// Gets or sets token action results.
        /// The collection of statuses of the actions performed on the Apple Volume Purchase Program Token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenActionResults", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VppTokenActionResult> TokenActionResults { get; set; }
    
        /// <summary>
        /// Gets or sets last sync status.
        /// Current sync status of the last application sync which was triggered using the Apple Volume Purchase Program Token. Possible values are: none, inProgress, completed, failed. Possible values are: none, inProgress, completed, failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncStatus", Required = Newtonsoft.Json.Required.Default)]
        public VppTokenSyncStatus? LastSyncStatus { get; set; }
    
        /// <summary>
        /// Gets or sets automatically update apps.
        /// Whether or not apps for the VPP token will be automatically updated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "automaticallyUpdateApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? AutomaticallyUpdateApps { get; set; }
    
        /// <summary>
        /// Gets or sets country or region.
        /// Whether or not apps for the VPP token will be automatically updated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryOrRegion", Required = Newtonsoft.Json.Required.Default)]
        public string CountryOrRegion { get; set; }
    
        /// <summary>
        /// Gets or sets data sharing consent granted.
        /// Consent granted for data sharing with the Apple Volume Purchase Program.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataSharingConsentGranted", Required = Newtonsoft.Json.Required.Default)]
        public bool? DataSharingConsentGranted { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// An admin specified token friendly name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets location name.
        /// Token location returned from Apple VPP.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locationName", Required = Newtonsoft.Json.Required.Default)]
        public string LocationName { get; set; }
    
        /// <summary>
        /// Gets or sets claim token management from external mdm.
        /// Admin consent to allow claiming token management from external MDM.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "claimTokenManagementFromExternalMdm", Required = Newtonsoft.Json.Required.Default)]
        public bool? ClaimTokenManagementFromExternalMdm { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// Role Scope Tags IDs assigned to this entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
    }
}

