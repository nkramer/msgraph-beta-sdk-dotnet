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
    /// The interface IUserConfigurationRequest.
    /// </summary>
    public partial interface IUserConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserConfiguration using PUT.
        /// </summary>
        /// <param name="userConfigurationToCreate">The UserConfiguration to create.</param>
        /// <returns>The created UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> CreateAsync(UserConfiguration userConfigurationToCreate);        /// <summary>
        /// Creates the specified UserConfiguration using PUT.
        /// </summary>
        /// <param name="userConfigurationToCreate">The UserConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> CreateAsync(UserConfiguration userConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserConfiguration.
        /// </summary>
        /// <returns>The UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified UserConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserConfiguration using PATCH.
        /// </summary>
        /// <param name="userConfigurationToUpdate">The UserConfiguration to update.</param>
        /// <returns>The updated UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> UpdateAsync(UserConfiguration userConfigurationToUpdate);

        /// <summary>
        /// Updates the specified UserConfiguration using PATCH.
        /// </summary>
        /// <param name="userConfigurationToUpdate">The UserConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserConfiguration.</returns>
        System.Threading.Tasks.Task<UserConfiguration> UpdateAsync(UserConfiguration userConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserConfigurationRequest Expand(Expression<Func<UserConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserConfigurationRequest Select(Expression<Func<UserConfiguration, object>> selectExpression);

    }
}
