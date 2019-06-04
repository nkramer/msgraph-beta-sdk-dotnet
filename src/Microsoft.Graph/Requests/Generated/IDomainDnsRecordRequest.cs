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
    /// The interface IDomainDnsRecordRequest.
    /// </summary>
    public partial interface IDomainDnsRecordRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DomainDnsRecord using PUT.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <returns>The created DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> CreateAsync(DomainDnsRecord domainDnsRecordToCreate);        /// <summary>
        /// Creates the specified DomainDnsRecord using PUT.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> CreateAsync(DomainDnsRecord domainDnsRecordToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DomainDnsRecord.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DomainDnsRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DomainDnsRecord.
        /// </summary>
        /// <returns>The DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> GetAsync();

        /// <summary>
        /// Gets the specified DomainDnsRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <returns>The updated DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> UpdateAsync(DomainDnsRecord domainDnsRecordToUpdate);

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> UpdateAsync(DomainDnsRecord domainDnsRecordToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Expand(Expression<Func<DomainDnsRecord, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Select(Expression<Func<DomainDnsRecord, object>> selectExpression);

    }
}
