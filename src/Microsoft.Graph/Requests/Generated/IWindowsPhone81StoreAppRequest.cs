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
    /// The interface IWindowsPhone81StoreAppRequest.
    /// </summary>
    public partial interface IWindowsPhone81StoreAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsPhone81StoreApp using PUT.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToCreate">The WindowsPhone81StoreApp to create.</param>
        /// <returns>The created WindowsPhone81StoreApp.</returns>
        System.Threading.Tasks.Task<WindowsPhone81StoreApp> CreateAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToCreate);        /// <summary>
        /// Creates the specified WindowsPhone81StoreApp using PUT.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToCreate">The WindowsPhone81StoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81StoreApp.</returns>
        System.Threading.Tasks.Task<WindowsPhone81StoreApp> CreateAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsPhone81StoreApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsPhone81StoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsPhone81StoreApp.
        /// </summary>
        /// <returns>The WindowsPhone81StoreApp.</returns>
        System.Threading.Tasks.Task<WindowsPhone81StoreApp> GetAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81StoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81StoreApp.</returns>
        System.Threading.Tasks.Task<WindowsPhone81StoreApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsPhone81StoreApp using PATCH.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToUpdate">The WindowsPhone81StoreApp to update.</param>
        /// <returns>The updated WindowsPhone81StoreApp.</returns>
        System.Threading.Tasks.Task<WindowsPhone81StoreApp> UpdateAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToUpdate);

        /// <summary>
        /// Updates the specified WindowsPhone81StoreApp using PATCH.
        /// </summary>
        /// <param name="windowsPhone81StoreAppToUpdate">The WindowsPhone81StoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81StoreApp.</returns>
        System.Threading.Tasks.Task<WindowsPhone81StoreApp> UpdateAsync(WindowsPhone81StoreApp windowsPhone81StoreAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81StoreAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81StoreAppRequest Expand(Expression<Func<WindowsPhone81StoreApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81StoreAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81StoreAppRequest Select(Expression<Func<WindowsPhone81StoreApp, object>> selectExpression);

    }
}
