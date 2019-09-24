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
    /// The type DeviceAppManagementRequest.
    /// </summary>
    public partial class DeviceAppManagementRequest : BaseRequest, IDeviceAppManagementRequest
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceAppManagementRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceAppManagement using POST.
        /// </summary>
        /// <param name="deviceAppManagementToCreate">The DeviceAppManagement to create.</param>
        /// <returns>The created DeviceAppManagement.</returns>
        public System.Threading.Tasks.Task<DeviceAppManagement> CreateAsync(DeviceAppManagement deviceAppManagementToCreate)
        {
            return this.CreateAsync(deviceAppManagementToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceAppManagement using POST.
        /// </summary>
        /// <param name="deviceAppManagementToCreate">The DeviceAppManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceAppManagement.</returns>
        public async System.Threading.Tasks.Task<DeviceAppManagement> CreateAsync(DeviceAppManagement deviceAppManagementToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceAppManagement>(deviceAppManagementToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DeviceAppManagement.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceAppManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceAppManagement>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceAppManagement.
        /// </summary>
        /// <returns>The DeviceAppManagement.</returns>
        public System.Threading.Tasks.Task<DeviceAppManagement> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceAppManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceAppManagement.</returns>
        public async System.Threading.Tasks.Task<DeviceAppManagement> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceAppManagement>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceAppManagement using PATCH.
        /// </summary>
        /// <param name="deviceAppManagementToUpdate">The DeviceAppManagement to update.</param>
        /// <returns>The updated DeviceAppManagement.</returns>
        public System.Threading.Tasks.Task<DeviceAppManagement> UpdateAsync(DeviceAppManagement deviceAppManagementToUpdate)
        {
            return this.UpdateAsync(deviceAppManagementToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceAppManagement using PATCH.
        /// </summary>
        /// <param name="deviceAppManagementToUpdate">The DeviceAppManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceAppManagement.</returns>
        public async System.Threading.Tasks.Task<DeviceAppManagement> UpdateAsync(DeviceAppManagement deviceAppManagementToUpdate, CancellationToken cancellationToken)
        {
			if (deviceAppManagementToUpdate.AdditionalData != null)
			{
				if (deviceAppManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceAppManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceAppManagementToUpdate.GetType().Name)
						});
				}
			}
            if (deviceAppManagementToUpdate.AdditionalData != null)
            {
                if (deviceAppManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceAppManagementToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceAppManagementToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceAppManagement>(deviceAppManagementToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceAppManagementRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceAppManagementRequest Expand(Expression<Func<DeviceAppManagement, object>> expandExpression)
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
        public IDeviceAppManagementRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceAppManagementRequest Select(Expression<Func<DeviceAppManagement, object>> selectExpression)
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
        /// <param name="deviceAppManagementToInitialize">The <see cref="DeviceAppManagement"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceAppManagement deviceAppManagementToInitialize)
        {

            if (deviceAppManagementToInitialize != null && deviceAppManagementToInitialize.AdditionalData != null)
            {

                if (deviceAppManagementToInitialize.ManagedEBooks != null && deviceAppManagementToInitialize.ManagedEBooks.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.ManagedEBooks.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("managedEBooks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.ManagedEBooks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.MobileApps != null && deviceAppManagementToInitialize.MobileApps.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.MobileApps.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("mobileApps@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.MobileApps.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.MobileAppCategories != null && deviceAppManagementToInitialize.MobileAppCategories.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.MobileAppCategories.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("mobileAppCategories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.MobileAppCategories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.EnterpriseCodeSigningCertificates != null && deviceAppManagementToInitialize.EnterpriseCodeSigningCertificates.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.EnterpriseCodeSigningCertificates.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("enterpriseCodeSigningCertificates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.EnterpriseCodeSigningCertificates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.IosLobAppProvisioningConfigurations != null && deviceAppManagementToInitialize.IosLobAppProvisioningConfigurations.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.IosLobAppProvisioningConfigurations.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("iosLobAppProvisioningConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.IosLobAppProvisioningConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.MobileAppConfigurations != null && deviceAppManagementToInitialize.MobileAppConfigurations.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.MobileAppConfigurations.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("mobileAppConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.MobileAppConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.ManagedEBookCategories != null && deviceAppManagementToInitialize.ManagedEBookCategories.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.ManagedEBookCategories.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("managedEBookCategories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.ManagedEBookCategories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.PolicySets != null && deviceAppManagementToInitialize.PolicySets.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.PolicySets.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("policySets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.PolicySets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.SideLoadingKeys != null && deviceAppManagementToInitialize.SideLoadingKeys.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.SideLoadingKeys.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("sideLoadingKeys@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.SideLoadingKeys.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.VppTokens != null && deviceAppManagementToInitialize.VppTokens.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.VppTokens.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("vppTokens@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.VppTokens.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.ManagedAppPolicies != null && deviceAppManagementToInitialize.ManagedAppPolicies.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.ManagedAppPolicies.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("managedAppPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.ManagedAppPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.IosManagedAppProtections != null && deviceAppManagementToInitialize.IosManagedAppProtections.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.IosManagedAppProtections.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("iosManagedAppProtections@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.IosManagedAppProtections.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.AndroidManagedAppProtections != null && deviceAppManagementToInitialize.AndroidManagedAppProtections.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.AndroidManagedAppProtections.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("androidManagedAppProtections@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.AndroidManagedAppProtections.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.DefaultManagedAppProtections != null && deviceAppManagementToInitialize.DefaultManagedAppProtections.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.DefaultManagedAppProtections.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("defaultManagedAppProtections@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.DefaultManagedAppProtections.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.TargetedManagedAppConfigurations != null && deviceAppManagementToInitialize.TargetedManagedAppConfigurations.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.TargetedManagedAppConfigurations.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("targetedManagedAppConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.TargetedManagedAppConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.MdmWindowsInformationProtectionPolicies != null && deviceAppManagementToInitialize.MdmWindowsInformationProtectionPolicies.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.MdmWindowsInformationProtectionPolicies.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("mdmWindowsInformationProtectionPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.MdmWindowsInformationProtectionPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.WindowsInformationProtectionPolicies != null && deviceAppManagementToInitialize.WindowsInformationProtectionPolicies.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.WindowsInformationProtectionPolicies.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("windowsInformationProtectionPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.WindowsInformationProtectionPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.ManagedAppRegistrations != null && deviceAppManagementToInitialize.ManagedAppRegistrations.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.ManagedAppRegistrations.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("managedAppRegistrations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.ManagedAppRegistrations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.ManagedAppStatuses != null && deviceAppManagementToInitialize.ManagedAppStatuses.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.ManagedAppStatuses.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("managedAppStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.ManagedAppStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.WindowsInformationProtectionDeviceRegistrations != null && deviceAppManagementToInitialize.WindowsInformationProtectionDeviceRegistrations.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.WindowsInformationProtectionDeviceRegistrations.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("windowsInformationProtectionDeviceRegistrations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.WindowsInformationProtectionDeviceRegistrations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.WindowsInformationProtectionWipeActions != null && deviceAppManagementToInitialize.WindowsInformationProtectionWipeActions.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.WindowsInformationProtectionWipeActions.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("windowsInformationProtectionWipeActions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.WindowsInformationProtectionWipeActions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceAppManagementToInitialize.DeviceAppManagementTasks != null && deviceAppManagementToInitialize.DeviceAppManagementTasks.CurrentPage != null)
                {
                    deviceAppManagementToInitialize.DeviceAppManagementTasks.AdditionalData = deviceAppManagementToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceAppManagementToInitialize.AdditionalData.TryGetValue("deviceAppManagementTasks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceAppManagementToInitialize.DeviceAppManagementTasks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
