// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITeamsAppWithReferenceRequest.
    /// </summary>
    public partial interface ITeamsAppWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified TeamsApp.
        /// </summary>
        /// <returns>The TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> GetAsync();

        /// <summary>
        /// Gets the specified TeamsApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified TeamsApp using PUT.
        /// </summary>
        /// <param name="teamsAppToCreate">The TeamsApp to create.</param>
        /// <returns>The created TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> CreateAsync(TeamsApp teamsAppToCreate);        /// <summary>
        /// Creates the specified TeamsApp using PUT.
        /// </summary>
        /// <param name="teamsAppToCreate">The TeamsApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> CreateAsync(TeamsApp teamsAppToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified TeamsApp using PATCH.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp to update.</param>
        /// <returns>The updated TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> UpdateAsync(TeamsApp teamsAppToUpdate);

        /// <summary>
        /// Updates the specified TeamsApp using PATCH.
        /// </summary>
        /// <param name="teamsAppToUpdate">The TeamsApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsApp.</returns>
        System.Threading.Tasks.Task<TeamsApp> UpdateAsync(TeamsApp teamsAppToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified TeamsApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TeamsApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppWithReferenceRequest Expand(Expression<Func<TeamsApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppWithReferenceRequest Select(Expression<Func<TeamsApp, object>> selectExpression);

    }
}
