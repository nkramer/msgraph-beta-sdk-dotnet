// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceManagementDeviceConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementDeviceConfigurationsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementDeviceConfigurationsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementDeviceConfigurationsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationRequestBuilder"/> for the specified DeviceConfiguration.
        /// </summary>
        /// <param name="id">The ID for the DeviceConfiguration.</param>
        /// <returns>The <see cref="IDeviceConfigurationRequestBuilder"/>.</returns>
        IDeviceConfigurationRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for DeviceConfigurationHasPayloadLinks.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationHasPayloadLinksRequestBuilder"/>.</returns>
        IDeviceConfigurationHasPayloadLinksRequestBuilder HasPayloadLinks(
            IEnumerable<string> payloadIds = null);

        /// <summary>
        /// Gets the request builder for DeviceConfigurationGetTargetedUsersAndDevices.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationGetTargetedUsersAndDevicesRequestBuilder"/>.</returns>
        IDeviceConfigurationGetTargetedUsersAndDevicesRequestBuilder GetTargetedUsersAndDevices(
            IEnumerable<string> deviceConfigurationIds = null);
    }
}
