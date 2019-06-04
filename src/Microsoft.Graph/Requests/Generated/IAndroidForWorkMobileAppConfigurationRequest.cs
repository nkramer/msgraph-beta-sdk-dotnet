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
    /// The interface IAndroidForWorkMobileAppConfigurationRequest.
    /// </summary>
    public partial interface IAndroidForWorkMobileAppConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkMobileAppConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkMobileAppConfigurationToCreate">The AndroidForWorkMobileAppConfiguration to create.</param>
        /// <returns>The created AndroidForWorkMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkMobileAppConfiguration> CreateAsync(AndroidForWorkMobileAppConfiguration androidForWorkMobileAppConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidForWorkMobileAppConfiguration using PUT.
        /// </summary>
        /// <param name="androidForWorkMobileAppConfigurationToCreate">The AndroidForWorkMobileAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkMobileAppConfiguration> CreateAsync(AndroidForWorkMobileAppConfiguration androidForWorkMobileAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidForWorkMobileAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidForWorkMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkMobileAppConfiguration.
        /// </summary>
        /// <returns>The AndroidForWorkMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkMobileAppConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkMobileAppConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkMobileAppConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkMobileAppConfigurationToUpdate">The AndroidForWorkMobileAppConfiguration to update.</param>
        /// <returns>The updated AndroidForWorkMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkMobileAppConfiguration> UpdateAsync(AndroidForWorkMobileAppConfiguration androidForWorkMobileAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidForWorkMobileAppConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkMobileAppConfigurationToUpdate">The AndroidForWorkMobileAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkMobileAppConfiguration> UpdateAsync(AndroidForWorkMobileAppConfiguration androidForWorkMobileAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkMobileAppConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkMobileAppConfigurationRequest Expand(Expression<Func<AndroidForWorkMobileAppConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkMobileAppConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkMobileAppConfigurationRequest Select(Expression<Func<AndroidForWorkMobileAppConfiguration, object>> selectExpression);

    }
}
