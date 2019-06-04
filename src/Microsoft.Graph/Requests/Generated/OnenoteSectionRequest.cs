// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type OnenoteSectionRequest.
    /// </summary>
    public partial class OnenoteSectionRequest : BaseRequest, IOnenoteSectionRequest
    {
        /// <summary>
        /// Constructs a new OnenoteSectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OnenoteSectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OnenoteSection using POST.
        /// </summary>
        /// <param name="onenoteSectionToCreate">The OnenoteSection to create.</param>
        /// <returns>The created OnenoteSection.</returns>
        public System.Threading.Tasks.Task<OnenoteSection> CreateAsync(OnenoteSection onenoteSectionToCreate)
        {
            return this.CreateAsync(onenoteSectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OnenoteSection using POST.
        /// </summary>
        /// <param name="onenoteSectionToCreate">The OnenoteSection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteSection.</returns>
        public async System.Threading.Tasks.Task<OnenoteSection> CreateAsync(OnenoteSection onenoteSectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OnenoteSection>(onenoteSectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified OnenoteSection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OnenoteSection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OnenoteSection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OnenoteSection.
        /// </summary>
        /// <returns>The OnenoteSection.</returns>
        public System.Threading.Tasks.Task<OnenoteSection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OnenoteSection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteSection.</returns>
        public async System.Threading.Tasks.Task<OnenoteSection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OnenoteSection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OnenoteSection using PATCH.
        /// </summary>
        /// <param name="onenoteSectionToUpdate">The OnenoteSection to update.</param>
        /// <returns>The updated OnenoteSection.</returns>
        public System.Threading.Tasks.Task<OnenoteSection> UpdateAsync(OnenoteSection onenoteSectionToUpdate)
        {
            return this.UpdateAsync(onenoteSectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OnenoteSection using PATCH.
        /// </summary>
        /// <param name="onenoteSectionToUpdate">The OnenoteSection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteSection.</returns>
        public async System.Threading.Tasks.Task<OnenoteSection> UpdateAsync(OnenoteSection onenoteSectionToUpdate, CancellationToken cancellationToken)
        {
			if (onenoteSectionToUpdate.AdditionalData != null)
			{
				if (onenoteSectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					onenoteSectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteSectionToUpdate.GetType().Name)
						});
				}
			}
            if (onenoteSectionToUpdate.AdditionalData != null)
            {
                if (onenoteSectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    onenoteSectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteSectionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OnenoteSection>(onenoteSectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteSectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteSectionRequest Expand(Expression<Func<OnenoteSection, object>> expandExpression)
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
        public IOnenoteSectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteSectionRequest Select(Expression<Func<OnenoteSection, object>> selectExpression)
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

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="onenoteSectionToInitialize">The <see cref="OnenoteSection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OnenoteSection onenoteSectionToInitialize)
        {

            if (onenoteSectionToInitialize != null && onenoteSectionToInitialize.AdditionalData != null)
            {

                if (onenoteSectionToInitialize.Pages != null && onenoteSectionToInitialize.Pages.CurrentPage != null)
                {
                    onenoteSectionToInitialize.Pages.AdditionalData = onenoteSectionToInitialize.AdditionalData;

                    object nextPageLink;
                    onenoteSectionToInitialize.AdditionalData.TryGetValue("pages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onenoteSectionToInitialize.Pages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
