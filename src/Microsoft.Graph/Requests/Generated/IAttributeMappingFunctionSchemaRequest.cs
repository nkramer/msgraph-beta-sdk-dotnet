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
    /// The interface IAttributeMappingFunctionSchemaRequest.
    /// </summary>
    public partial interface IAttributeMappingFunctionSchemaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AttributeMappingFunctionSchema using PUT.
        /// </summary>
        /// <param name="attributeMappingFunctionSchemaToCreate">The AttributeMappingFunctionSchema to create.</param>
        /// <returns>The created AttributeMappingFunctionSchema.</returns>
        System.Threading.Tasks.Task<AttributeMappingFunctionSchema> CreateAsync(AttributeMappingFunctionSchema attributeMappingFunctionSchemaToCreate);        /// <summary>
        /// Creates the specified AttributeMappingFunctionSchema using PUT.
        /// </summary>
        /// <param name="attributeMappingFunctionSchemaToCreate">The AttributeMappingFunctionSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AttributeMappingFunctionSchema.</returns>
        System.Threading.Tasks.Task<AttributeMappingFunctionSchema> CreateAsync(AttributeMappingFunctionSchema attributeMappingFunctionSchemaToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AttributeMappingFunctionSchema.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AttributeMappingFunctionSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AttributeMappingFunctionSchema.
        /// </summary>
        /// <returns>The AttributeMappingFunctionSchema.</returns>
        System.Threading.Tasks.Task<AttributeMappingFunctionSchema> GetAsync();

        /// <summary>
        /// Gets the specified AttributeMappingFunctionSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AttributeMappingFunctionSchema.</returns>
        System.Threading.Tasks.Task<AttributeMappingFunctionSchema> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AttributeMappingFunctionSchema using PATCH.
        /// </summary>
        /// <param name="attributeMappingFunctionSchemaToUpdate">The AttributeMappingFunctionSchema to update.</param>
        /// <returns>The updated AttributeMappingFunctionSchema.</returns>
        System.Threading.Tasks.Task<AttributeMappingFunctionSchema> UpdateAsync(AttributeMappingFunctionSchema attributeMappingFunctionSchemaToUpdate);

        /// <summary>
        /// Updates the specified AttributeMappingFunctionSchema using PATCH.
        /// </summary>
        /// <param name="attributeMappingFunctionSchemaToUpdate">The AttributeMappingFunctionSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AttributeMappingFunctionSchema.</returns>
        System.Threading.Tasks.Task<AttributeMappingFunctionSchema> UpdateAsync(AttributeMappingFunctionSchema attributeMappingFunctionSchemaToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAttributeMappingFunctionSchemaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAttributeMappingFunctionSchemaRequest Expand(Expression<Func<AttributeMappingFunctionSchema, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAttributeMappingFunctionSchemaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAttributeMappingFunctionSchemaRequest Select(Expression<Func<AttributeMappingFunctionSchema, object>> selectExpression);

    }
}
