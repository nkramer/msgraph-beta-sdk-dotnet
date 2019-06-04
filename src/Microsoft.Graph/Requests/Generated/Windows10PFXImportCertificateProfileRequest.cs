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
    /// The type Windows10PFXImportCertificateProfileRequest.
    /// </summary>
    public partial class Windows10PFXImportCertificateProfileRequest : BaseRequest, IWindows10PFXImportCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new Windows10PFXImportCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows10PFXImportCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows10PFXImportCertificateProfile using POST.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToCreate">The Windows10PFXImportCertificateProfile to create.</param>
        /// <returns>The created Windows10PFXImportCertificateProfile.</returns>
        public System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> CreateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToCreate)
        {
            return this.CreateAsync(windows10PFXImportCertificateProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Windows10PFXImportCertificateProfile using POST.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToCreate">The Windows10PFXImportCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10PFXImportCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> CreateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Windows10PFXImportCertificateProfile>(windows10PFXImportCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Windows10PFXImportCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <returns>The Windows10PFXImportCertificateProfile.</returns>
        public System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10PFXImportCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Windows10PFXImportCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile to update.</param>
        /// <returns>The updated Windows10PFXImportCertificateProfile.</returns>
        public System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> UpdateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate)
        {
            return this.UpdateAsync(windows10PFXImportCertificateProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10PFXImportCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> UpdateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate, CancellationToken cancellationToken)
        {
			if (windows10PFXImportCertificateProfileToUpdate.AdditionalData != null)
			{
				if (windows10PFXImportCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windows10PFXImportCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10PFXImportCertificateProfileToUpdate.GetType().Name)
						});
				}
			}
            if (windows10PFXImportCertificateProfileToUpdate.AdditionalData != null)
            {
                if (windows10PFXImportCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windows10PFXImportCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10PFXImportCertificateProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Windows10PFXImportCertificateProfile>(windows10PFXImportCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10PFXImportCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10PFXImportCertificateProfileRequest Expand(Expression<Func<Windows10PFXImportCertificateProfile, object>> expandExpression)
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
        public IWindows10PFXImportCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10PFXImportCertificateProfileRequest Select(Expression<Func<Windows10PFXImportCertificateProfile, object>> selectExpression)
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
        /// <param name="windows10PFXImportCertificateProfileToInitialize">The <see cref="Windows10PFXImportCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToInitialize)
        {

        }
    }
}
