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
    /// The interface IDeviceManagementSettingCategoryRequest.
    /// </summary>
    public partial interface IDeviceManagementSettingCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementSettingCategory using PUT.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToCreate">The DeviceManagementSettingCategory to create.</param>
        /// <returns>The created DeviceManagementSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingCategory> CreateAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToCreate);        /// <summary>
        /// Creates the specified DeviceManagementSettingCategory using PUT.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToCreate">The DeviceManagementSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingCategory> CreateAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementSettingCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementSettingCategory.
        /// </summary>
        /// <returns>The DeviceManagementSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingCategory> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingCategory> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementSettingCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToUpdate">The DeviceManagementSettingCategory to update.</param>
        /// <returns>The updated DeviceManagementSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingCategory> UpdateAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementSettingCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementSettingCategoryToUpdate">The DeviceManagementSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingCategory> UpdateAsync(DeviceManagementSettingCategory deviceManagementSettingCategoryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingCategoryRequest Expand(Expression<Func<DeviceManagementSettingCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingCategoryRequest Select(Expression<Func<DeviceManagementSettingCategory, object>> selectExpression);

    }
}
