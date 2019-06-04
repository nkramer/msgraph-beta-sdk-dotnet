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
    /// The interface IMacOSWiFiConfigurationRequest.
    /// </summary>
    public partial interface IMacOSWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToCreate">The MacOSWiFiConfiguration to create.</param>
        /// <returns>The created MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> CreateAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToCreate);        /// <summary>
        /// Creates the specified MacOSWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToCreate">The MacOSWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> CreateAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSWiFiConfiguration.
        /// </summary>
        /// <returns>The MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToUpdate">The MacOSWiFiConfiguration to update.</param>
        /// <returns>The updated MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> UpdateAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSWiFiConfigurationToUpdate">The MacOSWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSWiFiConfiguration> UpdateAsync(MacOSWiFiConfiguration macOSWiFiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Expand(Expression<Func<MacOSWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSWiFiConfigurationRequest Select(Expression<Func<MacOSWiFiConfiguration, object>> selectExpression);

    }
}
