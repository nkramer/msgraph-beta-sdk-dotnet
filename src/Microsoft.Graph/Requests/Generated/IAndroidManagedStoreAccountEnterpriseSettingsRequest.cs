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
    /// The interface IAndroidManagedStoreAccountEnterpriseSettingsRequest.
    /// </summary>
    public partial interface IAndroidManagedStoreAccountEnterpriseSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidManagedStoreAccountEnterpriseSettings using PUT.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToCreate">The AndroidManagedStoreAccountEnterpriseSettings to create.</param>
        /// <returns>The created AndroidManagedStoreAccountEnterpriseSettings.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> CreateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToCreate);        /// <summary>
        /// Creates the specified AndroidManagedStoreAccountEnterpriseSettings using PUT.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToCreate">The AndroidManagedStoreAccountEnterpriseSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidManagedStoreAccountEnterpriseSettings.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> CreateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <returns>The AndroidManagedStoreAccountEnterpriseSettings.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> GetAsync();

        /// <summary>
        /// Gets the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidManagedStoreAccountEnterpriseSettings.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAccountEnterpriseSettings using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToUpdate">The AndroidManagedStoreAccountEnterpriseSettings to update.</param>
        /// <returns>The updated AndroidManagedStoreAccountEnterpriseSettings.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> UpdateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToUpdate);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAccountEnterpriseSettings using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToUpdate">The AndroidManagedStoreAccountEnterpriseSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidManagedStoreAccountEnterpriseSettings.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> UpdateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAccountEnterpriseSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAccountEnterpriseSettingsRequest Expand(Expression<Func<AndroidManagedStoreAccountEnterpriseSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAccountEnterpriseSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAccountEnterpriseSettingsRequest Select(Expression<Func<AndroidManagedStoreAccountEnterpriseSettings, object>> selectExpression);

    }
}
