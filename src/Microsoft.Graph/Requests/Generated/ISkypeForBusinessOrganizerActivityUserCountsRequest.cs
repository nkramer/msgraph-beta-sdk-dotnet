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
    /// The interface ISkypeForBusinessOrganizerActivityUserCountsRequest.
    /// </summary>
    public partial interface ISkypeForBusinessOrganizerActivityUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessOrganizerActivityUserCounts using PUT.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToCreate">The SkypeForBusinessOrganizerActivityUserCounts to create.</param>
        /// <returns>The created SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> CreateAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToCreate);        /// <summary>
        /// Creates the specified SkypeForBusinessOrganizerActivityUserCounts using PUT.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToCreate">The SkypeForBusinessOrganizerActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> CreateAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <returns>The SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SkypeForBusinessOrganizerActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToUpdate">The SkypeForBusinessOrganizerActivityUserCounts to update.</param>
        /// <returns>The updated SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> UpdateAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToUpdate);

        /// <summary>
        /// Updates the specified SkypeForBusinessOrganizerActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToUpdate">The SkypeForBusinessOrganizerActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> UpdateAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Expand(Expression<Func<SkypeForBusinessOrganizerActivityUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Select(Expression<Func<SkypeForBusinessOrganizerActivityUserCounts, object>> selectExpression);

    }
}
