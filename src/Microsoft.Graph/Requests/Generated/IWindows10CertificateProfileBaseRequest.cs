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
    /// The interface IWindows10CertificateProfileBaseRequest.
    /// </summary>
    public partial interface IWindows10CertificateProfileBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10CertificateProfileBase using PUT.
        /// </summary>
        /// <param name="windows10CertificateProfileBaseToCreate">The Windows10CertificateProfileBase to create.</param>
        /// <returns>The created Windows10CertificateProfileBase.</returns>
        System.Threading.Tasks.Task<Windows10CertificateProfileBase> CreateAsync(Windows10CertificateProfileBase windows10CertificateProfileBaseToCreate);        /// <summary>
        /// Creates the specified Windows10CertificateProfileBase using PUT.
        /// </summary>
        /// <param name="windows10CertificateProfileBaseToCreate">The Windows10CertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10CertificateProfileBase.</returns>
        System.Threading.Tasks.Task<Windows10CertificateProfileBase> CreateAsync(Windows10CertificateProfileBase windows10CertificateProfileBaseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10CertificateProfileBase.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10CertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10CertificateProfileBase.
        /// </summary>
        /// <returns>The Windows10CertificateProfileBase.</returns>
        System.Threading.Tasks.Task<Windows10CertificateProfileBase> GetAsync();

        /// <summary>
        /// Gets the specified Windows10CertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10CertificateProfileBase.</returns>
        System.Threading.Tasks.Task<Windows10CertificateProfileBase> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10CertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="windows10CertificateProfileBaseToUpdate">The Windows10CertificateProfileBase to update.</param>
        /// <returns>The updated Windows10CertificateProfileBase.</returns>
        System.Threading.Tasks.Task<Windows10CertificateProfileBase> UpdateAsync(Windows10CertificateProfileBase windows10CertificateProfileBaseToUpdate);

        /// <summary>
        /// Updates the specified Windows10CertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="windows10CertificateProfileBaseToUpdate">The Windows10CertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10CertificateProfileBase.</returns>
        System.Threading.Tasks.Task<Windows10CertificateProfileBase> UpdateAsync(Windows10CertificateProfileBase windows10CertificateProfileBaseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CertificateProfileBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CertificateProfileBaseRequest Expand(Expression<Func<Windows10CertificateProfileBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CertificateProfileBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CertificateProfileBaseRequest Select(Expression<Func<Windows10CertificateProfileBase, object>> selectExpression);

    }
}
