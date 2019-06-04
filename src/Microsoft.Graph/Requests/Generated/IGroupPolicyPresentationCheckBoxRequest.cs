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
    /// The interface IGroupPolicyPresentationCheckBoxRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationCheckBoxRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationCheckBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationCheckBoxToCreate">The GroupPolicyPresentationCheckBox to create.</param>
        /// <returns>The created GroupPolicyPresentationCheckBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationCheckBox> CreateAsync(GroupPolicyPresentationCheckBox groupPolicyPresentationCheckBoxToCreate);        /// <summary>
        /// Creates the specified GroupPolicyPresentationCheckBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationCheckBoxToCreate">The GroupPolicyPresentationCheckBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationCheckBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationCheckBox> CreateAsync(GroupPolicyPresentationCheckBox groupPolicyPresentationCheckBoxToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationCheckBox.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationCheckBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationCheckBox.
        /// </summary>
        /// <returns>The GroupPolicyPresentationCheckBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationCheckBox> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationCheckBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationCheckBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationCheckBox> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationCheckBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationCheckBoxToUpdate">The GroupPolicyPresentationCheckBox to update.</param>
        /// <returns>The updated GroupPolicyPresentationCheckBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationCheckBox> UpdateAsync(GroupPolicyPresentationCheckBox groupPolicyPresentationCheckBoxToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationCheckBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationCheckBoxToUpdate">The GroupPolicyPresentationCheckBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationCheckBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationCheckBox> UpdateAsync(GroupPolicyPresentationCheckBox groupPolicyPresentationCheckBoxToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationCheckBoxRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationCheckBoxRequest Expand(Expression<Func<GroupPolicyPresentationCheckBox, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationCheckBoxRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationCheckBoxRequest Select(Expression<Func<GroupPolicyPresentationCheckBox, object>> selectExpression);

    }
}
