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
    /// The interface IEducationSynchronizationErrorRequest.
    /// </summary>
    public partial interface IEducationSynchronizationErrorRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationSynchronizationError using PUT.
        /// </summary>
        /// <param name="educationSynchronizationErrorToCreate">The EducationSynchronizationError to create.</param>
        /// <returns>The created EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> CreateAsync(EducationSynchronizationError educationSynchronizationErrorToCreate);        /// <summary>
        /// Creates the specified EducationSynchronizationError using PUT.
        /// </summary>
        /// <param name="educationSynchronizationErrorToCreate">The EducationSynchronizationError to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> CreateAsync(EducationSynchronizationError educationSynchronizationErrorToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EducationSynchronizationError.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EducationSynchronizationError.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EducationSynchronizationError.
        /// </summary>
        /// <returns>The EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> GetAsync();

        /// <summary>
        /// Gets the specified EducationSynchronizationError.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EducationSynchronizationError using PATCH.
        /// </summary>
        /// <param name="educationSynchronizationErrorToUpdate">The EducationSynchronizationError to update.</param>
        /// <returns>The updated EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> UpdateAsync(EducationSynchronizationError educationSynchronizationErrorToUpdate);

        /// <summary>
        /// Updates the specified EducationSynchronizationError using PATCH.
        /// </summary>
        /// <param name="educationSynchronizationErrorToUpdate">The EducationSynchronizationError to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> UpdateAsync(EducationSynchronizationError educationSynchronizationErrorToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Expand(Expression<Func<EducationSynchronizationError, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Select(Expression<Func<EducationSynchronizationError, object>> selectExpression);

    }
}
