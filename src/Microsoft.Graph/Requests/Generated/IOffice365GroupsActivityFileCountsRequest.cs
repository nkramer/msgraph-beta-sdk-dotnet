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
    /// The interface IOffice365GroupsActivityFileCountsRequest.
    /// </summary>
    public partial interface IOffice365GroupsActivityFileCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Office365GroupsActivityFileCounts using PUT.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToCreate">The Office365GroupsActivityFileCounts to create.</param>
        /// <returns>The created Office365GroupsActivityFileCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> CreateAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToCreate);        /// <summary>
        /// Creates the specified Office365GroupsActivityFileCounts using PUT.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToCreate">The Office365GroupsActivityFileCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365GroupsActivityFileCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> CreateAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Office365GroupsActivityFileCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Office365GroupsActivityFileCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Office365GroupsActivityFileCounts.
        /// </summary>
        /// <returns>The Office365GroupsActivityFileCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> GetAsync();

        /// <summary>
        /// Gets the specified Office365GroupsActivityFileCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365GroupsActivityFileCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Office365GroupsActivityFileCounts using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToUpdate">The Office365GroupsActivityFileCounts to update.</param>
        /// <returns>The updated Office365GroupsActivityFileCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> UpdateAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToUpdate);

        /// <summary>
        /// Updates the specified Office365GroupsActivityFileCounts using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityFileCountsToUpdate">The Office365GroupsActivityFileCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365GroupsActivityFileCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityFileCounts> UpdateAsync(Office365GroupsActivityFileCounts office365GroupsActivityFileCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityFileCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityFileCountsRequest Expand(Expression<Func<Office365GroupsActivityFileCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityFileCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityFileCountsRequest Select(Expression<Func<Office365GroupsActivityFileCounts, object>> selectExpression);

    }
}
