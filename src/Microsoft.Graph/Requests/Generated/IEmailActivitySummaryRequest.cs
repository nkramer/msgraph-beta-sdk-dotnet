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
    /// The interface IEmailActivitySummaryRequest.
    /// </summary>
    public partial interface IEmailActivitySummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmailActivitySummary using PUT.
        /// </summary>
        /// <param name="emailActivitySummaryToCreate">The EmailActivitySummary to create.</param>
        /// <returns>The created EmailActivitySummary.</returns>
        System.Threading.Tasks.Task<EmailActivitySummary> CreateAsync(EmailActivitySummary emailActivitySummaryToCreate);        /// <summary>
        /// Creates the specified EmailActivitySummary using PUT.
        /// </summary>
        /// <param name="emailActivitySummaryToCreate">The EmailActivitySummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailActivitySummary.</returns>
        System.Threading.Tasks.Task<EmailActivitySummary> CreateAsync(EmailActivitySummary emailActivitySummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EmailActivitySummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EmailActivitySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EmailActivitySummary.
        /// </summary>
        /// <returns>The EmailActivitySummary.</returns>
        System.Threading.Tasks.Task<EmailActivitySummary> GetAsync();

        /// <summary>
        /// Gets the specified EmailActivitySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailActivitySummary.</returns>
        System.Threading.Tasks.Task<EmailActivitySummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EmailActivitySummary using PATCH.
        /// </summary>
        /// <param name="emailActivitySummaryToUpdate">The EmailActivitySummary to update.</param>
        /// <returns>The updated EmailActivitySummary.</returns>
        System.Threading.Tasks.Task<EmailActivitySummary> UpdateAsync(EmailActivitySummary emailActivitySummaryToUpdate);

        /// <summary>
        /// Updates the specified EmailActivitySummary using PATCH.
        /// </summary>
        /// <param name="emailActivitySummaryToUpdate">The EmailActivitySummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmailActivitySummary.</returns>
        System.Threading.Tasks.Task<EmailActivitySummary> UpdateAsync(EmailActivitySummary emailActivitySummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivitySummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivitySummaryRequest Expand(Expression<Func<EmailActivitySummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivitySummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivitySummaryRequest Select(Expression<Func<EmailActivitySummary, object>> selectExpression);

    }
}
