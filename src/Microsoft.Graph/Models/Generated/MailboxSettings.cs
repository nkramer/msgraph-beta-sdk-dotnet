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
    /// The type MailboxSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MailboxSettings
    {

        /// <summary>
        /// Gets or sets automaticRepliesSetting.
        /// Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "automaticRepliesSetting", Required = Newtonsoft.Json.Required.Default)]
        public AutomaticRepliesSetting AutomaticRepliesSetting { get; set; }
    
        /// <summary>
        /// Gets or sets archiveFolder.
        /// Folder ID of an archive folder for the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "archiveFolder", Required = Newtonsoft.Json.Required.Default)]
        public string ArchiveFolder { get; set; }
    
        /// <summary>
        /// Gets or sets timeZone.
        /// The default time zone for the user's mailbox.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeZone", Required = Newtonsoft.Json.Required.Default)]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// The locale information for the user, including the preferred language and country/region.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "language", Required = Newtonsoft.Json.Required.Default)]
        public LocaleInfo Language { get; set; }
    
        /// <summary>
        /// Gets or sets workingHours.
        /// The days of the week and hours in a specific time zone that the user works.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "workingHours", Required = Newtonsoft.Json.Required.Default)]
        public WorkingHours WorkingHours { get; set; }
    
        /// <summary>
        /// Gets or sets dateFormat.
        /// The date format for the user's mailbox.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dateFormat", Required = Newtonsoft.Json.Required.Default)]
        public string DateFormat { get; set; }
    
        /// <summary>
        /// Gets or sets timeFormat.
        /// The time format for the user's mailbox.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeFormat", Required = Newtonsoft.Json.Required.Default)]
        public string TimeFormat { get; set; }
    
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
