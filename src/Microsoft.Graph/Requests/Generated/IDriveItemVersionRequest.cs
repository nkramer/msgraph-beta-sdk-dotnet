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
    /// The interface IDriveItemVersionRequest.
    /// </summary>
    public partial interface IDriveItemVersionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DriveItemVersion using PUT.
        /// </summary>
        /// <param name="driveItemVersionToCreate">The DriveItemVersion to create.</param>
        /// <returns>The created DriveItemVersion.</returns>
        System.Threading.Tasks.Task<DriveItemVersion> CreateAsync(DriveItemVersion driveItemVersionToCreate);        /// <summary>
        /// Creates the specified DriveItemVersion using PUT.
        /// </summary>
        /// <param name="driveItemVersionToCreate">The DriveItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DriveItemVersion.</returns>
        System.Threading.Tasks.Task<DriveItemVersion> CreateAsync(DriveItemVersion driveItemVersionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DriveItemVersion.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DriveItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DriveItemVersion.
        /// </summary>
        /// <returns>The DriveItemVersion.</returns>
        System.Threading.Tasks.Task<DriveItemVersion> GetAsync();

        /// <summary>
        /// Gets the specified DriveItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DriveItemVersion.</returns>
        System.Threading.Tasks.Task<DriveItemVersion> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DriveItemVersion using PATCH.
        /// </summary>
        /// <param name="driveItemVersionToUpdate">The DriveItemVersion to update.</param>
        /// <returns>The updated DriveItemVersion.</returns>
        System.Threading.Tasks.Task<DriveItemVersion> UpdateAsync(DriveItemVersion driveItemVersionToUpdate);

        /// <summary>
        /// Updates the specified DriveItemVersion using PATCH.
        /// </summary>
        /// <param name="driveItemVersionToUpdate">The DriveItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DriveItemVersion.</returns>
        System.Threading.Tasks.Task<DriveItemVersion> UpdateAsync(DriveItemVersion driveItemVersionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemVersionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemVersionRequest Expand(Expression<Func<DriveItemVersion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemVersionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemVersionRequest Select(Expression<Func<DriveItemVersion, object>> selectExpression);

    }
}
