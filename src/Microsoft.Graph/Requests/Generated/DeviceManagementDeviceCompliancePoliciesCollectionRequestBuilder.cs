// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementDeviceCompliancePoliciesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceCompliancePoliciesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceCompliancePoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceCompliancePoliciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceCompliancePoliciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceCompliancePoliciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceCompliancePoliciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceCompliancePoliciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceCompliancePolicyRequestBuilder"/> for the specified DeviceManagementDeviceCompliancePolicy.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceCompliancePolicy.</param>
        /// <returns>The <see cref="IDeviceCompliancePolicyRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyRequestBuilder this[string id]
        {
            get
            {
                return new DeviceCompliancePolicyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyRefreshDeviceComplianceReportSummarization.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyRefreshDeviceComplianceReportSummarizationRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyRefreshDeviceComplianceReportSummarizationRequestBuilder RefreshDeviceComplianceReportSummarization()
        {
            return new DeviceCompliancePolicyRefreshDeviceComplianceReportSummarizationRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.refreshDeviceComplianceReportSummarization"),
                this.Client);
        }
    }
}
