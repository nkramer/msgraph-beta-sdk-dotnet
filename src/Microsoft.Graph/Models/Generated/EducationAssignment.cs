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
    /// The type Education Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets class id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classId", Required = Newtonsoft.Json.Required.Default)]
        public string ClassId { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets instructions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instructions", Required = Newtonsoft.Json.Required.Default)]
        public EducationItemBody Instructions { get; set; }
    
        /// <summary>
        /// Gets or sets due date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dueDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DueDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets assign date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AssignDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets assigned date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AssignedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets grading.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "grading", Required = Newtonsoft.Json.Required.Default)]
        public EducationAssignmentGradeType Grading { get; set; }
    
        /// <summary>
        /// Gets or sets assign to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignTo", Required = Newtonsoft.Json.Required.Default)]
        public EducationAssignmentRecipient AssignTo { get; set; }
    
        /// <summary>
        /// Gets or sets allow late submissions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowLateSubmissions", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowLateSubmissions { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets allow students to add resources to submission.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowStudentsToAddResourcesToSubmission", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowStudentsToAddResourcesToSubmission { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public EducationAssignmentStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets resources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resources", Required = Newtonsoft.Json.Required.Default)]
        public IEducationAssignmentResourcesCollectionPage Resources { get; set; }
    
        /// <summary>
        /// Gets or sets submissions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "submissions", Required = Newtonsoft.Json.Required.Default)]
        public IEducationAssignmentSubmissionsCollectionPage Submissions { get; set; }
    
        /// <summary>
        /// Gets or sets categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "categories", Required = Newtonsoft.Json.Required.Default)]
        public IEducationAssignmentCategoriesCollectionPage Categories { get; set; }
    
        /// <summary>
        /// Gets or sets rubric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rubric", Required = Newtonsoft.Json.Required.Default)]
        public EducationRubric Rubric { get; set; }
    
    }
}

