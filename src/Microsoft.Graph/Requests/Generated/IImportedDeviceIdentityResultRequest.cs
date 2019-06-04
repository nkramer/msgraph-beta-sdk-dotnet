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
    /// The interface IImportedDeviceIdentityResultRequest.
    /// </summary>
    public partial interface IImportedDeviceIdentityResultRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ImportedDeviceIdentityResult using PUT.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToCreate">The ImportedDeviceIdentityResult to create.</param>
        /// <returns>The created ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> CreateAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToCreate);        /// <summary>
        /// Creates the specified ImportedDeviceIdentityResult using PUT.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToCreate">The ImportedDeviceIdentityResult to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> CreateAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ImportedDeviceIdentityResult.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ImportedDeviceIdentityResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ImportedDeviceIdentityResult.
        /// </summary>
        /// <returns>The ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> GetAsync();

        /// <summary>
        /// Gets the specified ImportedDeviceIdentityResult.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ImportedDeviceIdentityResult using PATCH.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToUpdate">The ImportedDeviceIdentityResult to update.</param>
        /// <returns>The updated ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> UpdateAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToUpdate);

        /// <summary>
        /// Updates the specified ImportedDeviceIdentityResult using PATCH.
        /// </summary>
        /// <param name="importedDeviceIdentityResultToUpdate">The ImportedDeviceIdentityResult to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ImportedDeviceIdentityResult.</returns>
        System.Threading.Tasks.Task<ImportedDeviceIdentityResult> UpdateAsync(ImportedDeviceIdentityResult importedDeviceIdentityResultToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Expand(Expression<Func<ImportedDeviceIdentityResult, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedDeviceIdentityResultRequest Select(Expression<Func<ImportedDeviceIdentityResult, object>> selectExpression);

    }
}
