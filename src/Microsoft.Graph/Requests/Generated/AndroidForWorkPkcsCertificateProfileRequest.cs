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
    /// The type AndroidForWorkPkcsCertificateProfileRequest.
    /// </summary>
    public partial class AndroidForWorkPkcsCertificateProfileRequest : BaseRequest, IAndroidForWorkPkcsCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new AndroidForWorkPkcsCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidForWorkPkcsCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidForWorkPkcsCertificateProfile using POST.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToCreate">The AndroidForWorkPkcsCertificateProfile to create.</param>
        /// <returns>The created AndroidForWorkPkcsCertificateProfile.</returns>
        public System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> CreateAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToCreate)
        {
            return this.CreateAsync(androidForWorkPkcsCertificateProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidForWorkPkcsCertificateProfile using POST.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToCreate">The AndroidForWorkPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkPkcsCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> CreateAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidForWorkPkcsCertificateProfile>(androidForWorkPkcsCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AndroidForWorkPkcsCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidForWorkPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidForWorkPkcsCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidForWorkPkcsCertificateProfile.
        /// </summary>
        /// <returns>The AndroidForWorkPkcsCertificateProfile.</returns>
        public System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidForWorkPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkPkcsCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidForWorkPkcsCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidForWorkPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToUpdate">The AndroidForWorkPkcsCertificateProfile to update.</param>
        /// <returns>The updated AndroidForWorkPkcsCertificateProfile.</returns>
        public System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> UpdateAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToUpdate)
        {
            return this.UpdateAsync(androidForWorkPkcsCertificateProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidForWorkPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToUpdate">The AndroidForWorkPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkPkcsCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> UpdateAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToUpdate, CancellationToken cancellationToken)
        {
			if (androidForWorkPkcsCertificateProfileToUpdate.AdditionalData != null)
			{
				if (androidForWorkPkcsCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidForWorkPkcsCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidForWorkPkcsCertificateProfileToUpdate.GetType().Name)
						});
				}
			}
            if (androidForWorkPkcsCertificateProfileToUpdate.AdditionalData != null)
            {
                if (androidForWorkPkcsCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidForWorkPkcsCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidForWorkPkcsCertificateProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidForWorkPkcsCertificateProfile>(androidForWorkPkcsCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkPkcsCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkPkcsCertificateProfileRequest Expand(Expression<Func<AndroidForWorkPkcsCertificateProfile, object>> expandExpression)
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
        public IAndroidForWorkPkcsCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkPkcsCertificateProfileRequest Select(Expression<Func<AndroidForWorkPkcsCertificateProfile, object>> selectExpression)
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
        /// <param name="androidForWorkPkcsCertificateProfileToInitialize">The <see cref="AndroidForWorkPkcsCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToInitialize)
        {

            if (androidForWorkPkcsCertificateProfileToInitialize != null && androidForWorkPkcsCertificateProfileToInitialize.AdditionalData != null)
            {

                if (androidForWorkPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates != null && androidForWorkPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates.CurrentPage != null)
                {
                    androidForWorkPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates.AdditionalData = androidForWorkPkcsCertificateProfileToInitialize.AdditionalData;

                    object nextPageLink;
                    androidForWorkPkcsCertificateProfileToInitialize.AdditionalData.TryGetValue("managedDeviceCertificateStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        androidForWorkPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
