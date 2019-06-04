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
    /// The interface IPrivilegedRoleSummaryRequest.
    /// </summary>
    public partial interface IPrivilegedRoleSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrivilegedRoleSummary using PUT.
        /// </summary>
        /// <param name="privilegedRoleSummaryToCreate">The PrivilegedRoleSummary to create.</param>
        /// <returns>The created PrivilegedRoleSummary.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSummary> CreateAsync(PrivilegedRoleSummary privilegedRoleSummaryToCreate);        /// <summary>
        /// Creates the specified PrivilegedRoleSummary using PUT.
        /// </summary>
        /// <param name="privilegedRoleSummaryToCreate">The PrivilegedRoleSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedRoleSummary.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSummary> CreateAsync(PrivilegedRoleSummary privilegedRoleSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrivilegedRoleSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrivilegedRoleSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrivilegedRoleSummary.
        /// </summary>
        /// <returns>The PrivilegedRoleSummary.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSummary> GetAsync();

        /// <summary>
        /// Gets the specified PrivilegedRoleSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedRoleSummary.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrivilegedRoleSummary using PATCH.
        /// </summary>
        /// <param name="privilegedRoleSummaryToUpdate">The PrivilegedRoleSummary to update.</param>
        /// <returns>The updated PrivilegedRoleSummary.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSummary> UpdateAsync(PrivilegedRoleSummary privilegedRoleSummaryToUpdate);

        /// <summary>
        /// Updates the specified PrivilegedRoleSummary using PATCH.
        /// </summary>
        /// <param name="privilegedRoleSummaryToUpdate">The PrivilegedRoleSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrivilegedRoleSummary.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSummary> UpdateAsync(PrivilegedRoleSummary privilegedRoleSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSummaryRequest Expand(Expression<Func<PrivilegedRoleSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSummaryRequest Select(Expression<Func<PrivilegedRoleSummary, object>> selectExpression);

    }
}
