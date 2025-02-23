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
    /// The type SensitivityLabelSublabelsCollectionRequestBuilder.
    /// </summary>
    public partial class SensitivityLabelSublabelsCollectionRequestBuilder : BaseRequestBuilder, ISensitivityLabelSublabelsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SensitivityLabelSublabelsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SensitivityLabelSublabelsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISensitivityLabelSublabelsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISensitivityLabelSublabelsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SensitivityLabelSublabelsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISensitivityLabelRequestBuilder"/> for the specified SensitivityLabelSensitivityLabel.
        /// </summary>
        /// <param name="id">The ID for the SensitivityLabelSensitivityLabel.</param>
        /// <returns>The <see cref="ISensitivityLabelRequestBuilder"/>.</returns>
        public ISensitivityLabelRequestBuilder this[string id]
        {
            get
            {
                return new SensitivityLabelRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SensitivityLabelEvaluate.
        /// </summary>
        /// <returns>The <see cref="ISensitivityLabelEvaluateRequestBuilder"/>.</returns>
        public ISensitivityLabelEvaluateRequestBuilder Evaluate(
            IEnumerable<DiscoveredSensitiveType> discoveredSensitiveTypes = null)
        {
            return new SensitivityLabelEvaluateRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.evaluate"),
                this.Client,
                discoveredSensitiveTypes);
        }
    }
}
