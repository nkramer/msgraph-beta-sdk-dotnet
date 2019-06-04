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
    /// The interface IWindowsCertificateProfileBaseRequest.
    /// </summary>
    public partial interface IWindowsCertificateProfileBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsCertificateProfileBase using PUT.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToCreate">The WindowsCertificateProfileBase to create.</param>
        /// <returns>The created WindowsCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<WindowsCertificateProfileBase> CreateAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToCreate);        /// <summary>
        /// Creates the specified WindowsCertificateProfileBase using PUT.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToCreate">The WindowsCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<WindowsCertificateProfileBase> CreateAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsCertificateProfileBase.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsCertificateProfileBase.
        /// </summary>
        /// <returns>The WindowsCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<WindowsCertificateProfileBase> GetAsync();

        /// <summary>
        /// Gets the specified WindowsCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<WindowsCertificateProfileBase> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToUpdate">The WindowsCertificateProfileBase to update.</param>
        /// <returns>The updated WindowsCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<WindowsCertificateProfileBase> UpdateAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToUpdate);

        /// <summary>
        /// Updates the specified WindowsCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToUpdate">The WindowsCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<WindowsCertificateProfileBase> UpdateAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsCertificateProfileBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsCertificateProfileBaseRequest Expand(Expression<Func<WindowsCertificateProfileBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsCertificateProfileBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsCertificateProfileBaseRequest Select(Expression<Func<WindowsCertificateProfileBase, object>> selectExpression);

    }
}
