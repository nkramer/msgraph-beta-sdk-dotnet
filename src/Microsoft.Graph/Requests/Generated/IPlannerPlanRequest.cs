// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPlannerPlanRequest.
    /// </summary>
    public partial interface IPlannerPlanRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerPlan using PUT.
        /// </summary>
        /// <param name="plannerPlanToCreate">The PlannerPlan to create.</param>
        /// <returns>The created PlannerPlan.</returns>
        System.Threading.Tasks.Task<PlannerPlan> CreateAsync(PlannerPlan plannerPlanToCreate);        /// <summary>
        /// Creates the specified PlannerPlan using PUT.
        /// </summary>
        /// <param name="plannerPlanToCreate">The PlannerPlan to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerPlan.</returns>
        System.Threading.Tasks.Task<PlannerPlan> CreateAsync(PlannerPlan plannerPlanToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerPlan.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlannerPlan.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerPlan.
        /// </summary>
        /// <returns>The PlannerPlan.</returns>
        System.Threading.Tasks.Task<PlannerPlan> GetAsync();

        /// <summary>
        /// Gets the specified PlannerPlan.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerPlan.</returns>
        System.Threading.Tasks.Task<PlannerPlan> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerPlan using PATCH.
        /// </summary>
        /// <param name="plannerPlanToUpdate">The PlannerPlan to update.</param>
        /// <returns>The updated PlannerPlan.</returns>
        System.Threading.Tasks.Task<PlannerPlan> UpdateAsync(PlannerPlan plannerPlanToUpdate);

        /// <summary>
        /// Updates the specified PlannerPlan using PATCH.
        /// </summary>
        /// <param name="plannerPlanToUpdate">The PlannerPlan to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerPlan.</returns>
        System.Threading.Tasks.Task<PlannerPlan> UpdateAsync(PlannerPlan plannerPlanToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanRequest Expand(Expression<Func<PlannerPlan, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanRequest Select(Expression<Func<PlannerPlan, object>> selectExpression);

    }
}
