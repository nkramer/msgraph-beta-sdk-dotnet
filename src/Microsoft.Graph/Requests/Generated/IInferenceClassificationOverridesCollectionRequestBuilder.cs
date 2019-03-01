// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IInferenceClassificationOverridesCollectionRequestBuilder.
    /// </summary>
    public partial interface IInferenceClassificationOverridesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IInferenceClassificationOverridesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IInferenceClassificationOverridesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IInferenceClassificationOverrideRequestBuilder"/> for the specified InferenceClassificationOverride.
        /// </summary>
        /// <param name="id">The ID for the InferenceClassificationOverride.</param>
        /// <returns>The <see cref="IInferenceClassificationOverrideRequestBuilder"/>.</returns>
        IInferenceClassificationOverrideRequestBuilder this[string id] { get; }

        
    }
}
