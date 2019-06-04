// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPrivilegedRoleSettingsWithReferenceRequest.
    /// </summary>
    public partial interface IPrivilegedRoleSettingsWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified PrivilegedRoleSettings.
        /// </summary>
        /// <returns>The PrivilegedRoleSettings.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSettings> GetAsync();

        /// <summary>
        /// Gets the specified PrivilegedRoleSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedRoleSettings.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSettings> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified PrivilegedRoleSettings using PUT.
        /// </summary>
        /// <param name="privilegedRoleSettingsToCreate">The PrivilegedRoleSettings to create.</param>
        /// <returns>The created PrivilegedRoleSettings.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSettings> CreateAsync(PrivilegedRoleSettings privilegedRoleSettingsToCreate);        /// <summary>
        /// Creates the specified PrivilegedRoleSettings using PUT.
        /// </summary>
        /// <param name="privilegedRoleSettingsToCreate">The PrivilegedRoleSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedRoleSettings.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSettings> CreateAsync(PrivilegedRoleSettings privilegedRoleSettingsToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified PrivilegedRoleSettings using PATCH.
        /// </summary>
        /// <param name="privilegedRoleSettingsToUpdate">The PrivilegedRoleSettings to update.</param>
        /// <returns>The updated PrivilegedRoleSettings.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSettings> UpdateAsync(PrivilegedRoleSettings privilegedRoleSettingsToUpdate);

        /// <summary>
        /// Updates the specified PrivilegedRoleSettings using PATCH.
        /// </summary>
        /// <param name="privilegedRoleSettingsToUpdate">The PrivilegedRoleSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrivilegedRoleSettings.</returns>
        System.Threading.Tasks.Task<PrivilegedRoleSettings> UpdateAsync(PrivilegedRoleSettings privilegedRoleSettingsToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified PrivilegedRoleSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrivilegedRoleSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSettingsWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSettingsWithReferenceRequest Expand(Expression<Func<PrivilegedRoleSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSettingsWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedRoleSettingsWithReferenceRequest Select(Expression<Func<PrivilegedRoleSettings, object>> selectExpression);

    }
}
