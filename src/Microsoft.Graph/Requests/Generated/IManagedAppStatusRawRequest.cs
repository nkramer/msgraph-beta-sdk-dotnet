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
    /// The interface IManagedAppStatusRawRequest.
    /// </summary>
    public partial interface IManagedAppStatusRawRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAppStatusRaw using PUT.
        /// </summary>
        /// <param name="managedAppStatusRawToCreate">The ManagedAppStatusRaw to create.</param>
        /// <returns>The created ManagedAppStatusRaw.</returns>
        System.Threading.Tasks.Task<ManagedAppStatusRaw> CreateAsync(ManagedAppStatusRaw managedAppStatusRawToCreate);        /// <summary>
        /// Creates the specified ManagedAppStatusRaw using PUT.
        /// </summary>
        /// <param name="managedAppStatusRawToCreate">The ManagedAppStatusRaw to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppStatusRaw.</returns>
        System.Threading.Tasks.Task<ManagedAppStatusRaw> CreateAsync(ManagedAppStatusRaw managedAppStatusRawToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedAppStatusRaw.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedAppStatusRaw.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAppStatusRaw.
        /// </summary>
        /// <returns>The ManagedAppStatusRaw.</returns>
        System.Threading.Tasks.Task<ManagedAppStatusRaw> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAppStatusRaw.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppStatusRaw.</returns>
        System.Threading.Tasks.Task<ManagedAppStatusRaw> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAppStatusRaw using PATCH.
        /// </summary>
        /// <param name="managedAppStatusRawToUpdate">The ManagedAppStatusRaw to update.</param>
        /// <returns>The updated ManagedAppStatusRaw.</returns>
        System.Threading.Tasks.Task<ManagedAppStatusRaw> UpdateAsync(ManagedAppStatusRaw managedAppStatusRawToUpdate);

        /// <summary>
        /// Updates the specified ManagedAppStatusRaw using PATCH.
        /// </summary>
        /// <param name="managedAppStatusRawToUpdate">The ManagedAppStatusRaw to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAppStatusRaw.</returns>
        System.Threading.Tasks.Task<ManagedAppStatusRaw> UpdateAsync(ManagedAppStatusRaw managedAppStatusRawToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRawRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRawRequest Expand(Expression<Func<ManagedAppStatusRaw, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRawRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppStatusRawRequest Select(Expression<Func<ManagedAppStatusRaw, object>> selectExpression);

    }
}
