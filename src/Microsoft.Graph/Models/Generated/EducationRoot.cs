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
    /// The type Education Root.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationRoot : Entity
    {
    
        /// <summary>
        /// Gets or sets synchronization profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "synchronizationProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IEducationRootSynchronizationProfilesCollectionPage SynchronizationProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets classes.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classes", Required = Newtonsoft.Json.Required.Default)]
        public IEducationRootClassesCollectionPage Classes { get; set; }
    
        /// <summary>
        /// Gets or sets schools.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schools", Required = Newtonsoft.Json.Required.Default)]
        public IEducationRootSchoolsCollectionPage Schools { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "users", Required = Newtonsoft.Json.Required.Default)]
        public IEducationRootUsersCollectionPage Users { get; set; }
    
        /// <summary>
        /// Gets or sets me.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "me", Required = Newtonsoft.Json.Required.Default)]
        public EducationUser Me { get; set; }
    
    }
}

