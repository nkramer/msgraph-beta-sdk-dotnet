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
    /// The interface IDeviceAppManagementMobileAppsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceAppManagementMobileAppsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceAppManagementMobileAppsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceAppManagementMobileAppsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMobileAppRequestBuilder"/> for the specified MobileApp.
        /// </summary>
        /// <param name="id">The ID for the MobileApp.</param>
        /// <returns>The <see cref="IMobileAppRequestBuilder"/>.</returns>
        IMobileAppRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for MobileAppHasPayloadLinks.
        /// </summary>
        /// <returns>The <see cref="IMobileAppHasPayloadLinksRequestBuilder"/>.</returns>
        IMobileAppHasPayloadLinksRequestBuilder HasPayloadLinks(
            IEnumerable<string> payloadIds = null);

        /// <summary>
        /// Gets the request builder for MobileAppGetMobileAppCount.
        /// </summary>
        /// <returns>The <see cref="IMobileAppGetMobileAppCountRequestBuilder"/>.</returns>
        IMobileAppGetMobileAppCountRequestBuilder GetMobileAppCount(
            string status = null);

        /// <summary>
        /// Gets the request builder for MobileAppGetTopMobileApps.
        /// </summary>
        /// <returns>The <see cref="IMobileAppGetTopMobileAppsRequestBuilder"/>.</returns>
        IMobileAppGetTopMobileAppsRequestBuilder GetTopMobileApps(
            Int64 count,
            string status = null);
    }
}
