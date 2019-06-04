// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedEBookCategoryWithReferenceRequest.
    /// </summary>
    public partial class ManagedEBookCategoryWithReferenceRequest : BaseRequest, IManagedEBookCategoryWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new ManagedEBookCategoryWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedEBookCategoryWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified ManagedEBookCategory.
        /// </summary>
        /// <returns>The ManagedEBookCategory.</returns>
        public System.Threading.Tasks.Task<ManagedEBookCategory> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ManagedEBookCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedEBookCategory.</returns>
        public async System.Threading.Tasks.Task<ManagedEBookCategory> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ManagedEBookCategory>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified ManagedEBookCategory using POST.
        /// </summary>
        /// <param name="managedEBookCategoryToCreate">The ManagedEBookCategory to create.</param>
        /// <returns>The created ManagedEBookCategory.</returns>
        public System.Threading.Tasks.Task<ManagedEBookCategory> CreateAsync(ManagedEBookCategory managedEBookCategoryToCreate)
        {
            return this.CreateAsync(managedEBookCategoryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ManagedEBookCategory using POST.
        /// </summary>
        /// <param name="managedEBookCategoryToCreate">The ManagedEBookCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedEBookCategory.</returns>
        public async System.Threading.Tasks.Task<ManagedEBookCategory> CreateAsync(ManagedEBookCategory managedEBookCategoryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ManagedEBookCategory>(managedEBookCategoryToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified ManagedEBookCategory using PATCH.
        /// </summary>
        /// <param name="managedEBookCategoryToUpdate">The ManagedEBookCategory to update.</param>
        /// <returns>The updated ManagedEBookCategory.</returns>
        public System.Threading.Tasks.Task<ManagedEBookCategory> UpdateAsync(ManagedEBookCategory managedEBookCategoryToUpdate)
        {
            return this.UpdateAsync(managedEBookCategoryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ManagedEBookCategory using PATCH.
        /// </summary>
        /// <param name="managedEBookCategoryToUpdate">The ManagedEBookCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedEBookCategory.</returns>
        public async System.Threading.Tasks.Task<ManagedEBookCategory> UpdateAsync(ManagedEBookCategory managedEBookCategoryToUpdate, CancellationToken cancellationToken)
        {
			if (managedEBookCategoryToUpdate.AdditionalData != null)
			{
				if (managedEBookCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					managedEBookCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedEBookCategoryToUpdate.GetType().Name)
						});
				}
			}
            if (managedEBookCategoryToUpdate.AdditionalData != null)
            {
                if (managedEBookCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    managedEBookCategoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedEBookCategoryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ManagedEBookCategory>(managedEBookCategoryToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified ManagedEBookCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ManagedEBookCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ManagedEBookCategory>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedEBookCategoryWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedEBookCategoryWithReferenceRequest Expand(Expression<Func<ManagedEBookCategory, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedEBookCategoryWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedEBookCategoryWithReferenceRequest Select(Expression<Func<ManagedEBookCategory, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

    }
}
