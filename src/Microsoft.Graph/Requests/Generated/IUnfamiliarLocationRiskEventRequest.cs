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
    /// The interface IUnfamiliarLocationRiskEventRequest.
    /// </summary>
    public partial interface IUnfamiliarLocationRiskEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnfamiliarLocationRiskEvent using PUT.
        /// </summary>
        /// <param name="unfamiliarLocationRiskEventToCreate">The UnfamiliarLocationRiskEvent to create.</param>
        /// <returns>The created UnfamiliarLocationRiskEvent.</returns>
        System.Threading.Tasks.Task<UnfamiliarLocationRiskEvent> CreateAsync(UnfamiliarLocationRiskEvent unfamiliarLocationRiskEventToCreate);        /// <summary>
        /// Creates the specified UnfamiliarLocationRiskEvent using PUT.
        /// </summary>
        /// <param name="unfamiliarLocationRiskEventToCreate">The UnfamiliarLocationRiskEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnfamiliarLocationRiskEvent.</returns>
        System.Threading.Tasks.Task<UnfamiliarLocationRiskEvent> CreateAsync(UnfamiliarLocationRiskEvent unfamiliarLocationRiskEventToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UnfamiliarLocationRiskEvent.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UnfamiliarLocationRiskEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnfamiliarLocationRiskEvent.
        /// </summary>
        /// <returns>The UnfamiliarLocationRiskEvent.</returns>
        System.Threading.Tasks.Task<UnfamiliarLocationRiskEvent> GetAsync();

        /// <summary>
        /// Gets the specified UnfamiliarLocationRiskEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnfamiliarLocationRiskEvent.</returns>
        System.Threading.Tasks.Task<UnfamiliarLocationRiskEvent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnfamiliarLocationRiskEvent using PATCH.
        /// </summary>
        /// <param name="unfamiliarLocationRiskEventToUpdate">The UnfamiliarLocationRiskEvent to update.</param>
        /// <returns>The updated UnfamiliarLocationRiskEvent.</returns>
        System.Threading.Tasks.Task<UnfamiliarLocationRiskEvent> UpdateAsync(UnfamiliarLocationRiskEvent unfamiliarLocationRiskEventToUpdate);

        /// <summary>
        /// Updates the specified UnfamiliarLocationRiskEvent using PATCH.
        /// </summary>
        /// <param name="unfamiliarLocationRiskEventToUpdate">The UnfamiliarLocationRiskEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnfamiliarLocationRiskEvent.</returns>
        System.Threading.Tasks.Task<UnfamiliarLocationRiskEvent> UpdateAsync(UnfamiliarLocationRiskEvent unfamiliarLocationRiskEventToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnfamiliarLocationRiskEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnfamiliarLocationRiskEventRequest Expand(Expression<Func<UnfamiliarLocationRiskEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnfamiliarLocationRiskEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnfamiliarLocationRiskEventRequest Select(Expression<Func<UnfamiliarLocationRiskEvent, object>> selectExpression);

    }
}
