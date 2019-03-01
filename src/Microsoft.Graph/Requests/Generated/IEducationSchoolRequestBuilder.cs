// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEducationSchoolRequestBuilder.
    /// </summary>
    public partial interface IEducationSchoolRequestBuilder : IEducationOrganizationRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEducationSchoolRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEducationSchoolRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Classes.
        /// </summary>
        /// <returns>The <see cref="IEducationSchoolClassesCollectionWithReferencesRequestBuilder"/>.</returns>
        IEducationSchoolClassesCollectionWithReferencesRequestBuilder Classes { get; }

        /// <summary>
        /// Gets the request builder for Users.
        /// </summary>
        /// <returns>The <see cref="IEducationSchoolUsersCollectionWithReferencesRequestBuilder"/>.</returns>
        IEducationSchoolUsersCollectionWithReferencesRequestBuilder Users { get; }
    
    }
}
