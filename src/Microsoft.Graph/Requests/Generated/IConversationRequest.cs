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
    /// The interface IConversationRequest.
    /// </summary>
    public partial interface IConversationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Conversation using PUT.
        /// </summary>
        /// <param name="conversationToCreate">The Conversation to create.</param>
        /// <returns>The created Conversation.</returns>
        System.Threading.Tasks.Task<Conversation> CreateAsync(Conversation conversationToCreate);        /// <summary>
        /// Creates the specified Conversation using PUT.
        /// </summary>
        /// <param name="conversationToCreate">The Conversation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Conversation.</returns>
        System.Threading.Tasks.Task<Conversation> CreateAsync(Conversation conversationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Conversation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Conversation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Conversation.
        /// </summary>
        /// <returns>The Conversation.</returns>
        System.Threading.Tasks.Task<Conversation> GetAsync();

        /// <summary>
        /// Gets the specified Conversation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Conversation.</returns>
        System.Threading.Tasks.Task<Conversation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Conversation using PATCH.
        /// </summary>
        /// <param name="conversationToUpdate">The Conversation to update.</param>
        /// <returns>The updated Conversation.</returns>
        System.Threading.Tasks.Task<Conversation> UpdateAsync(Conversation conversationToUpdate);

        /// <summary>
        /// Updates the specified Conversation using PATCH.
        /// </summary>
        /// <param name="conversationToUpdate">The Conversation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Conversation.</returns>
        System.Threading.Tasks.Task<Conversation> UpdateAsync(Conversation conversationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConversationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConversationRequest Expand(Expression<Func<Conversation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConversationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConversationRequest Select(Expression<Func<Conversation, object>> selectExpression);

    }
}
