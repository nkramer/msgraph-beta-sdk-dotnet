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
    /// The type ScheduleRequest.
    /// </summary>
    public partial class ScheduleRequest : BaseRequest, IScheduleRequest
    {
        /// <summary>
        /// Constructs a new ScheduleRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ScheduleRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Schedule using POST.
        /// </summary>
        /// <param name="scheduleToCreate">The Schedule to create.</param>
        /// <returns>The created Schedule.</returns>
        public System.Threading.Tasks.Task<Schedule> CreateAsync(Schedule scheduleToCreate)
        {
            return this.CreateAsync(scheduleToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Schedule using POST.
        /// </summary>
        /// <param name="scheduleToCreate">The Schedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Schedule.</returns>
        public async System.Threading.Tasks.Task<Schedule> CreateAsync(Schedule scheduleToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Schedule>(scheduleToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Schedule.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Schedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Schedule>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Schedule.
        /// </summary>
        /// <returns>The Schedule.</returns>
        public System.Threading.Tasks.Task<Schedule> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Schedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Schedule.</returns>
        public async System.Threading.Tasks.Task<Schedule> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Schedule>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Schedule using PATCH.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule to update.</param>
        /// <returns>The updated Schedule.</returns>
        public System.Threading.Tasks.Task<Schedule> UpdateAsync(Schedule scheduleToUpdate)
        {
            return this.UpdateAsync(scheduleToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Schedule using PATCH.
        /// </summary>
        /// <param name="scheduleToUpdate">The Schedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Schedule.</returns>
        public async System.Threading.Tasks.Task<Schedule> UpdateAsync(Schedule scheduleToUpdate, CancellationToken cancellationToken)
        {
			if (scheduleToUpdate.AdditionalData != null)
			{
				if (scheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					scheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, scheduleToUpdate.GetType().Name)
						});
				}
			}
            if (scheduleToUpdate.AdditionalData != null)
            {
                if (scheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    scheduleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, scheduleToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Schedule>(scheduleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IScheduleRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IScheduleRequest Expand(Expression<Func<Schedule, object>> expandExpression)
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
        public IScheduleRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IScheduleRequest Select(Expression<Func<Schedule, object>> selectExpression)
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
        /// <param name="scheduleToInitialize">The <see cref="Schedule"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Schedule scheduleToInitialize)
        {

            if (scheduleToInitialize != null && scheduleToInitialize.AdditionalData != null)
            {

                if (scheduleToInitialize.Shifts != null && scheduleToInitialize.Shifts.CurrentPage != null)
                {
                    scheduleToInitialize.Shifts.AdditionalData = scheduleToInitialize.AdditionalData;

                    object nextPageLink;
                    scheduleToInitialize.AdditionalData.TryGetValue("shifts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        scheduleToInitialize.Shifts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (scheduleToInitialize.TimesOff != null && scheduleToInitialize.TimesOff.CurrentPage != null)
                {
                    scheduleToInitialize.TimesOff.AdditionalData = scheduleToInitialize.AdditionalData;

                    object nextPageLink;
                    scheduleToInitialize.AdditionalData.TryGetValue("timesOff@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        scheduleToInitialize.TimesOff.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (scheduleToInitialize.TimeOffReasons != null && scheduleToInitialize.TimeOffReasons.CurrentPage != null)
                {
                    scheduleToInitialize.TimeOffReasons.AdditionalData = scheduleToInitialize.AdditionalData;

                    object nextPageLink;
                    scheduleToInitialize.AdditionalData.TryGetValue("timeOffReasons@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        scheduleToInitialize.TimeOffReasons.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (scheduleToInitialize.SchedulingGroups != null && scheduleToInitialize.SchedulingGroups.CurrentPage != null)
                {
                    scheduleToInitialize.SchedulingGroups.AdditionalData = scheduleToInitialize.AdditionalData;

                    object nextPageLink;
                    scheduleToInitialize.AdditionalData.TryGetValue("schedulingGroups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        scheduleToInitialize.SchedulingGroups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (scheduleToInitialize.SwapShiftsChangeRequests != null && scheduleToInitialize.SwapShiftsChangeRequests.CurrentPage != null)
                {
                    scheduleToInitialize.SwapShiftsChangeRequests.AdditionalData = scheduleToInitialize.AdditionalData;

                    object nextPageLink;
                    scheduleToInitialize.AdditionalData.TryGetValue("swapShiftsChangeRequests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        scheduleToInitialize.SwapShiftsChangeRequests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (scheduleToInitialize.TimeOffRequests != null && scheduleToInitialize.TimeOffRequests.CurrentPage != null)
                {
                    scheduleToInitialize.TimeOffRequests.AdditionalData = scheduleToInitialize.AdditionalData;

                    object nextPageLink;
                    scheduleToInitialize.AdditionalData.TryGetValue("timeOffRequests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        scheduleToInitialize.TimeOffRequests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
