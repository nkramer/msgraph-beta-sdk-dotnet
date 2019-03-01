// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WorkingHours.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WorkingHours
    {

        /// <summary>
        /// Gets or sets daysOfWeek.
        /// The days of the week on which the user works.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "daysOfWeek", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DayOfWeek> DaysOfWeek { get; set; }
    
        /// <summary>
        /// Gets or sets startTime.
        /// The time of the day that the user starts working.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay StartTime { get; set; }
    
        /// <summary>
        /// Gets or sets endTime.
        /// The time of the day that the user stops working.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay EndTime { get; set; }
    
        /// <summary>
        /// Gets or sets timeZone.
        /// The time zone to which the working hours apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeZone", Required = Newtonsoft.Json.Required.Default)]
        public TimeZoneBase TimeZone { get; set; }
    
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
