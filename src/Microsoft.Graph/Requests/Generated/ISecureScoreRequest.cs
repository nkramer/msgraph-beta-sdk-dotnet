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
    /// The interface ISecureScoreRequest.
    /// </summary>
    public partial interface ISecureScoreRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecureScore using PUT.
        /// </summary>
        /// <param name="secureScoreToCreate">The SecureScore to create.</param>
        /// <returns>The created SecureScore.</returns>
        System.Threading.Tasks.Task<SecureScore> CreateAsync(SecureScore secureScoreToCreate);        /// <summary>
        /// Creates the specified SecureScore using PUT.
        /// </summary>
        /// <param name="secureScoreToCreate">The SecureScore to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecureScore.</returns>
        System.Threading.Tasks.Task<SecureScore> CreateAsync(SecureScore secureScoreToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecureScore.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SecureScore.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecureScore.
        /// </summary>
        /// <returns>The SecureScore.</returns>
        System.Threading.Tasks.Task<SecureScore> GetAsync();

        /// <summary>
        /// Gets the specified SecureScore.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecureScore.</returns>
        System.Threading.Tasks.Task<SecureScore> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecureScore using PATCH.
        /// </summary>
        /// <param name="secureScoreToUpdate">The SecureScore to update.</param>
        /// <returns>The updated SecureScore.</returns>
        System.Threading.Tasks.Task<SecureScore> UpdateAsync(SecureScore secureScoreToUpdate);

        /// <summary>
        /// Updates the specified SecureScore using PATCH.
        /// </summary>
        /// <param name="secureScoreToUpdate">The SecureScore to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecureScore.</returns>
        System.Threading.Tasks.Task<SecureScore> UpdateAsync(SecureScore secureScoreToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreRequest Expand(Expression<Func<SecureScore, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreRequest Select(Expression<Func<SecureScore, object>> selectExpression);

    }
}
