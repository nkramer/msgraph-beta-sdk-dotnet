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
    /// The type UnitOfMeasureRequest.
    /// </summary>
    public partial class UnitOfMeasureRequest : BaseRequest, IUnitOfMeasureRequest
    {
        /// <summary>
        /// Constructs a new UnitOfMeasureRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnitOfMeasureRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnitOfMeasure using POST.
        /// </summary>
        /// <param name="unitOfMeasureToCreate">The UnitOfMeasure to create.</param>
        /// <returns>The created UnitOfMeasure.</returns>
        public System.Threading.Tasks.Task<UnitOfMeasure> CreateAsync(UnitOfMeasure unitOfMeasureToCreate)
        {
            return this.CreateAsync(unitOfMeasureToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UnitOfMeasure using POST.
        /// </summary>
        /// <param name="unitOfMeasureToCreate">The UnitOfMeasure to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnitOfMeasure.</returns>
        public async System.Threading.Tasks.Task<UnitOfMeasure> CreateAsync(UnitOfMeasure unitOfMeasureToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UnitOfMeasure>(unitOfMeasureToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified UnitOfMeasure.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UnitOfMeasure.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UnitOfMeasure>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified UnitOfMeasure.
        /// </summary>
        /// <returns>The UnitOfMeasure.</returns>
        public System.Threading.Tasks.Task<UnitOfMeasure> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UnitOfMeasure.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnitOfMeasure.</returns>
        public async System.Threading.Tasks.Task<UnitOfMeasure> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UnitOfMeasure>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified UnitOfMeasure using PATCH.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure to update.</param>
        /// <returns>The updated UnitOfMeasure.</returns>
        public System.Threading.Tasks.Task<UnitOfMeasure> UpdateAsync(UnitOfMeasure unitOfMeasureToUpdate)
        {
            return this.UpdateAsync(unitOfMeasureToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UnitOfMeasure using PATCH.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnitOfMeasure.</returns>
        public async System.Threading.Tasks.Task<UnitOfMeasure> UpdateAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken)
        {
			if (unitOfMeasureToUpdate.AdditionalData != null)
			{
				if (unitOfMeasureToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					unitOfMeasureToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unitOfMeasureToUpdate.GetType().Name)
						});
				}
			}
            if (unitOfMeasureToUpdate.AdditionalData != null)
            {
                if (unitOfMeasureToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    unitOfMeasureToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unitOfMeasureToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UnitOfMeasure>(unitOfMeasureToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnitOfMeasureRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnitOfMeasureRequest Expand(Expression<Func<UnitOfMeasure, object>> expandExpression)
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
        public IUnitOfMeasureRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnitOfMeasureRequest Select(Expression<Func<UnitOfMeasure, object>> selectExpression)
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
        /// <param name="unitOfMeasureToInitialize">The <see cref="UnitOfMeasure"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnitOfMeasure unitOfMeasureToInitialize)
        {

        }
    }
}
