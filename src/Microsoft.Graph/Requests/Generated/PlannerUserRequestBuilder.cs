// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PlannerUserRequestBuilder.
    /// </summary>
    public partial class PlannerUserRequestBuilder : EntityRequestBuilder, IPlannerUserRequestBuilder
    {

        /// <summary>
        /// Constructs a new PlannerUserRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerUserRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPlannerUserRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPlannerUserRequest Request(IEnumerable<Option> options)
        {
            return new PlannerUserRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserTasksCollectionRequestBuilder"/>.</returns>
        public IPlannerUserTasksCollectionRequestBuilder Tasks
        {
            get
            {
                return new PlannerUserTasksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Plans.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserPlansCollectionRequestBuilder"/>.</returns>
        public IPlannerUserPlansCollectionRequestBuilder Plans
        {
            get
            {
                return new PlannerUserPlansCollectionRequestBuilder(this.AppendSegmentToRequestUrl("plans"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for FavoritePlans.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserFavoritePlansCollectionRequestBuilder"/>.</returns>
        public IPlannerUserFavoritePlansCollectionRequestBuilder FavoritePlans
        {
            get
            {
                return new PlannerUserFavoritePlansCollectionRequestBuilder(this.AppendSegmentToRequestUrl("favoritePlans"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RecentPlans.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserRecentPlansCollectionRequestBuilder"/>.</returns>
        public IPlannerUserRecentPlansCollectionRequestBuilder RecentPlans
        {
            get
            {
                return new PlannerUserRecentPlansCollectionRequestBuilder(this.AppendSegmentToRequestUrl("recentPlans"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for All.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserAllCollectionRequestBuilder"/>.</returns>
        public IPlannerUserAllCollectionRequestBuilder All
        {
            get
            {
                return new PlannerUserAllCollectionRequestBuilder(this.AppendSegmentToRequestUrl("all"), this.Client);
            }
        }
    
    }
}
