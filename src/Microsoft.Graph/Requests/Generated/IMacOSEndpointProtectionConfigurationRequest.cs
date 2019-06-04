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
    /// The interface IMacOSEndpointProtectionConfigurationRequest.
    /// </summary>
    public partial interface IMacOSEndpointProtectionConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSEndpointProtectionConfiguration using PUT.
        /// </summary>
        /// <param name="macOSEndpointProtectionConfigurationToCreate">The MacOSEndpointProtectionConfiguration to create.</param>
        /// <returns>The created MacOSEndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEndpointProtectionConfiguration> CreateAsync(MacOSEndpointProtectionConfiguration macOSEndpointProtectionConfigurationToCreate);        /// <summary>
        /// Creates the specified MacOSEndpointProtectionConfiguration using PUT.
        /// </summary>
        /// <param name="macOSEndpointProtectionConfigurationToCreate">The MacOSEndpointProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSEndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEndpointProtectionConfiguration> CreateAsync(MacOSEndpointProtectionConfiguration macOSEndpointProtectionConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSEndpointProtectionConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSEndpointProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSEndpointProtectionConfiguration.
        /// </summary>
        /// <returns>The MacOSEndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEndpointProtectionConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSEndpointProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSEndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEndpointProtectionConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSEndpointProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSEndpointProtectionConfigurationToUpdate">The MacOSEndpointProtectionConfiguration to update.</param>
        /// <returns>The updated MacOSEndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEndpointProtectionConfiguration> UpdateAsync(MacOSEndpointProtectionConfiguration macOSEndpointProtectionConfigurationToUpdate);

        /// <summary>
        /// Updates the specified MacOSEndpointProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSEndpointProtectionConfigurationToUpdate">The MacOSEndpointProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSEndpointProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSEndpointProtectionConfiguration> UpdateAsync(MacOSEndpointProtectionConfiguration macOSEndpointProtectionConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEndpointProtectionConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEndpointProtectionConfigurationRequest Expand(Expression<Func<MacOSEndpointProtectionConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEndpointProtectionConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSEndpointProtectionConfigurationRequest Select(Expression<Func<MacOSEndpointProtectionConfiguration, object>> selectExpression);

    }
}
