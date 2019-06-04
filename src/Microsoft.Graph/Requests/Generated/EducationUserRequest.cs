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
    /// The type EducationUserRequest.
    /// </summary>
    public partial class EducationUserRequest : BaseRequest, IEducationUserRequest
    {
        /// <summary>
        /// Constructs a new EducationUserRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationUserRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationUser using POST.
        /// </summary>
        /// <param name="educationUserToCreate">The EducationUser to create.</param>
        /// <returns>The created EducationUser.</returns>
        public System.Threading.Tasks.Task<EducationUser> CreateAsync(EducationUser educationUserToCreate)
        {
            return this.CreateAsync(educationUserToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationUser using POST.
        /// </summary>
        /// <param name="educationUserToCreate">The EducationUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationUser.</returns>
        public async System.Threading.Tasks.Task<EducationUser> CreateAsync(EducationUser educationUserToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EducationUser>(educationUserToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified EducationUser.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EducationUser>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EducationUser.
        /// </summary>
        /// <returns>The EducationUser.</returns>
        public System.Threading.Tasks.Task<EducationUser> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationUser.</returns>
        public async System.Threading.Tasks.Task<EducationUser> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EducationUser>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified EducationUser using PATCH.
        /// </summary>
        /// <param name="educationUserToUpdate">The EducationUser to update.</param>
        /// <returns>The updated EducationUser.</returns>
        public System.Threading.Tasks.Task<EducationUser> UpdateAsync(EducationUser educationUserToUpdate)
        {
            return this.UpdateAsync(educationUserToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationUser using PATCH.
        /// </summary>
        /// <param name="educationUserToUpdate">The EducationUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationUser.</returns>
        public async System.Threading.Tasks.Task<EducationUser> UpdateAsync(EducationUser educationUserToUpdate, CancellationToken cancellationToken)
        {
			if (educationUserToUpdate.AdditionalData != null)
			{
				if (educationUserToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationUserToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationUserToUpdate.GetType().Name)
						});
				}
			}
            if (educationUserToUpdate.AdditionalData != null)
            {
                if (educationUserToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationUserToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationUserToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EducationUser>(educationUserToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationUserRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationUserRequest Expand(Expression<Func<EducationUser, object>> expandExpression)
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
        public IEducationUserRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationUserRequest Select(Expression<Func<EducationUser, object>> selectExpression)
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
        /// <param name="educationUserToInitialize">The <see cref="EducationUser"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationUser educationUserToInitialize)
        {

            if (educationUserToInitialize != null && educationUserToInitialize.AdditionalData != null)
            {

                if (educationUserToInitialize.Schools != null && educationUserToInitialize.Schools.CurrentPage != null)
                {
                    educationUserToInitialize.Schools.AdditionalData = educationUserToInitialize.AdditionalData;

                    object nextPageLink;
                    educationUserToInitialize.AdditionalData.TryGetValue("schools@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationUserToInitialize.Schools.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (educationUserToInitialize.Classes != null && educationUserToInitialize.Classes.CurrentPage != null)
                {
                    educationUserToInitialize.Classes.AdditionalData = educationUserToInitialize.AdditionalData;

                    object nextPageLink;
                    educationUserToInitialize.AdditionalData.TryGetValue("classes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationUserToInitialize.Classes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (educationUserToInitialize.TaughtClasses != null && educationUserToInitialize.TaughtClasses.CurrentPage != null)
                {
                    educationUserToInitialize.TaughtClasses.AdditionalData = educationUserToInitialize.AdditionalData;

                    object nextPageLink;
                    educationUserToInitialize.AdditionalData.TryGetValue("taughtClasses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationUserToInitialize.TaughtClasses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (educationUserToInitialize.Assignments != null && educationUserToInitialize.Assignments.CurrentPage != null)
                {
                    educationUserToInitialize.Assignments.AdditionalData = educationUserToInitialize.AdditionalData;

                    object nextPageLink;
                    educationUserToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationUserToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
