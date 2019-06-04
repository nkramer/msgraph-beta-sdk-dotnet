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
    /// The interface IDriveRequest.
    /// </summary>
    public partial interface IDriveRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Drive using PUT.
        /// </summary>
        /// <param name="driveToCreate">The Drive to create.</param>
        /// <returns>The created Drive.</returns>
        System.Threading.Tasks.Task<Drive> CreateAsync(Drive driveToCreate);        /// <summary>
        /// Creates the specified Drive using PUT.
        /// </summary>
        /// <param name="driveToCreate">The Drive to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Drive.</returns>
        System.Threading.Tasks.Task<Drive> CreateAsync(Drive driveToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Drive.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Drive.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Drive.
        /// </summary>
        /// <returns>The Drive.</returns>
        System.Threading.Tasks.Task<Drive> GetAsync();

        /// <summary>
        /// Gets the specified Drive.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Drive.</returns>
        System.Threading.Tasks.Task<Drive> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Drive using PATCH.
        /// </summary>
        /// <param name="driveToUpdate">The Drive to update.</param>
        /// <returns>The updated Drive.</returns>
        System.Threading.Tasks.Task<Drive> UpdateAsync(Drive driveToUpdate);

        /// <summary>
        /// Updates the specified Drive using PATCH.
        /// </summary>
        /// <param name="driveToUpdate">The Drive to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Drive.</returns>
        System.Threading.Tasks.Task<Drive> UpdateAsync(Drive driveToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriveRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriveRequest Expand(Expression<Func<Drive, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDriveRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDriveRequest Select(Expression<Func<Drive, object>> selectExpression);

    }
}
