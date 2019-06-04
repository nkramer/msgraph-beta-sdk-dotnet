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
    /// The type IntuneBrandingProfileRequest.
    /// </summary>
    public partial class IntuneBrandingProfileRequest : BaseRequest, IIntuneBrandingProfileRequest
    {
        /// <summary>
        /// Constructs a new IntuneBrandingProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IntuneBrandingProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IntuneBrandingProfile using POST.
        /// </summary>
        /// <param name="intuneBrandingProfileToCreate">The IntuneBrandingProfile to create.</param>
        /// <returns>The created IntuneBrandingProfile.</returns>
        public System.Threading.Tasks.Task<IntuneBrandingProfile> CreateAsync(IntuneBrandingProfile intuneBrandingProfileToCreate)
        {
            return this.CreateAsync(intuneBrandingProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IntuneBrandingProfile using POST.
        /// </summary>
        /// <param name="intuneBrandingProfileToCreate">The IntuneBrandingProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IntuneBrandingProfile.</returns>
        public async System.Threading.Tasks.Task<IntuneBrandingProfile> CreateAsync(IntuneBrandingProfile intuneBrandingProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IntuneBrandingProfile>(intuneBrandingProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified IntuneBrandingProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IntuneBrandingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IntuneBrandingProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IntuneBrandingProfile.
        /// </summary>
        /// <returns>The IntuneBrandingProfile.</returns>
        public System.Threading.Tasks.Task<IntuneBrandingProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IntuneBrandingProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IntuneBrandingProfile.</returns>
        public async System.Threading.Tasks.Task<IntuneBrandingProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IntuneBrandingProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified IntuneBrandingProfile using PATCH.
        /// </summary>
        /// <param name="intuneBrandingProfileToUpdate">The IntuneBrandingProfile to update.</param>
        /// <returns>The updated IntuneBrandingProfile.</returns>
        public System.Threading.Tasks.Task<IntuneBrandingProfile> UpdateAsync(IntuneBrandingProfile intuneBrandingProfileToUpdate)
        {
            return this.UpdateAsync(intuneBrandingProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IntuneBrandingProfile using PATCH.
        /// </summary>
        /// <param name="intuneBrandingProfileToUpdate">The IntuneBrandingProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IntuneBrandingProfile.</returns>
        public async System.Threading.Tasks.Task<IntuneBrandingProfile> UpdateAsync(IntuneBrandingProfile intuneBrandingProfileToUpdate, CancellationToken cancellationToken)
        {
			if (intuneBrandingProfileToUpdate.AdditionalData != null)
			{
				if (intuneBrandingProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					intuneBrandingProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, intuneBrandingProfileToUpdate.GetType().Name)
						});
				}
			}
            if (intuneBrandingProfileToUpdate.AdditionalData != null)
            {
                if (intuneBrandingProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    intuneBrandingProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, intuneBrandingProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IntuneBrandingProfile>(intuneBrandingProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIntuneBrandingProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIntuneBrandingProfileRequest Expand(Expression<Func<IntuneBrandingProfile, object>> expandExpression)
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
        public IIntuneBrandingProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIntuneBrandingProfileRequest Select(Expression<Func<IntuneBrandingProfile, object>> selectExpression)
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
        /// <param name="intuneBrandingProfileToInitialize">The <see cref="IntuneBrandingProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IntuneBrandingProfile intuneBrandingProfileToInitialize)
        {

            if (intuneBrandingProfileToInitialize != null && intuneBrandingProfileToInitialize.AdditionalData != null)
            {

                if (intuneBrandingProfileToInitialize.Assignments != null && intuneBrandingProfileToInitialize.Assignments.CurrentPage != null)
                {
                    intuneBrandingProfileToInitialize.Assignments.AdditionalData = intuneBrandingProfileToInitialize.AdditionalData;

                    object nextPageLink;
                    intuneBrandingProfileToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        intuneBrandingProfileToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
