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
    /// The type MacOSEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial class MacOSEnterpriseWiFiConfigurationRequest : BaseRequest, IMacOSEnterpriseWiFiConfigurationRequest
    {
        /// <summary>
        /// Constructs a new MacOSEnterpriseWiFiConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSEnterpriseWiFiConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToCreate">The MacOSEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created MacOSEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> CreateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToCreate)
        {
            return this.CreateAsync(macOSEnterpriseWiFiConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MacOSEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToCreate">The MacOSEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> CreateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOSEnterpriseWiFiConfiguration>(macOSEnterpriseWiFiConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOSEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The MacOSEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOSEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToUpdate">The MacOSEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated MacOSEnterpriseWiFiConfiguration.</returns>
        public System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> UpdateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToUpdate)
        {
            return this.UpdateAsync(macOSEnterpriseWiFiConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MacOSEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSEnterpriseWiFiConfigurationToUpdate">The MacOSEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<MacOSEnterpriseWiFiConfiguration> UpdateAsync(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (macOSEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
			{
				if (macOSEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					macOSEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSEnterpriseWiFiConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (macOSEnterpriseWiFiConfigurationToUpdate.AdditionalData != null)
            {
                if (macOSEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    macOSEnterpriseWiFiConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, macOSEnterpriseWiFiConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOSEnterpriseWiFiConfiguration>(macOSEnterpriseWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSEnterpriseWiFiConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSEnterpriseWiFiConfigurationRequest Expand(Expression<Func<MacOSEnterpriseWiFiConfiguration, object>> expandExpression)
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
        public IMacOSEnterpriseWiFiConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSEnterpriseWiFiConfigurationRequest Select(Expression<Func<MacOSEnterpriseWiFiConfiguration, object>> selectExpression)
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
        /// <param name="macOSEnterpriseWiFiConfigurationToInitialize">The <see cref="MacOSEnterpriseWiFiConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSEnterpriseWiFiConfiguration macOSEnterpriseWiFiConfigurationToInitialize)
        {

        }
    }
}
