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
    /// The type Windows10SecureAssessmentConfigurationRequest.
    /// </summary>
    public partial class Windows10SecureAssessmentConfigurationRequest : BaseRequest, IWindows10SecureAssessmentConfigurationRequest
    {
        /// <summary>
        /// Constructs a new Windows10SecureAssessmentConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows10SecureAssessmentConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows10SecureAssessmentConfiguration using POST.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToCreate">The Windows10SecureAssessmentConfiguration to create.</param>
        /// <returns>The created Windows10SecureAssessmentConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> CreateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToCreate)
        {
            return this.CreateAsync(windows10SecureAssessmentConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Windows10SecureAssessmentConfiguration using POST.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToCreate">The Windows10SecureAssessmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10SecureAssessmentConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> CreateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Windows10SecureAssessmentConfiguration>(windows10SecureAssessmentConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Windows10SecureAssessmentConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <returns>The Windows10SecureAssessmentConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10SecureAssessmentConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Windows10SecureAssessmentConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration to update.</param>
        /// <returns>The updated Windows10SecureAssessmentConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> UpdateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate)
        {
            return this.UpdateAsync(windows10SecureAssessmentConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10SecureAssessmentConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> UpdateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (windows10SecureAssessmentConfigurationToUpdate.AdditionalData != null)
			{
				if (windows10SecureAssessmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windows10SecureAssessmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10SecureAssessmentConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (windows10SecureAssessmentConfigurationToUpdate.AdditionalData != null)
            {
                if (windows10SecureAssessmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windows10SecureAssessmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10SecureAssessmentConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Windows10SecureAssessmentConfiguration>(windows10SecureAssessmentConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10SecureAssessmentConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10SecureAssessmentConfigurationRequest Expand(Expression<Func<Windows10SecureAssessmentConfiguration, object>> expandExpression)
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
        public IWindows10SecureAssessmentConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10SecureAssessmentConfigurationRequest Select(Expression<Func<Windows10SecureAssessmentConfiguration, object>> selectExpression)
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
        /// <param name="windows10SecureAssessmentConfigurationToInitialize">The <see cref="Windows10SecureAssessmentConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToInitialize)
        {

        }
    }
}
