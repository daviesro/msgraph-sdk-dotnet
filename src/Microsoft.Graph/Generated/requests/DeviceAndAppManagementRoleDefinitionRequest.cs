// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceAndAppManagementRoleDefinitionRequest.
    /// </summary>
    public partial class DeviceAndAppManagementRoleDefinitionRequest : BaseRequest, IDeviceAndAppManagementRoleDefinitionRequest
    {
        /// <summary>
        /// Constructs a new DeviceAndAppManagementRoleDefinitionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceAndAppManagementRoleDefinitionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceAndAppManagementRoleDefinition using POST.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleDefinitionToCreate">The DeviceAndAppManagementRoleDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceAndAppManagementRoleDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceAndAppManagementRoleDefinition> CreateAsync(DeviceAndAppManagementRoleDefinition deviceAndAppManagementRoleDefinitionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<DeviceAndAppManagementRoleDefinition>(deviceAndAppManagementRoleDefinitionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceAndAppManagementRoleDefinition using POST and returns a <see cref="GraphResponse{DeviceAndAppManagementRoleDefinition}"/> object.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleDefinitionToCreate">The DeviceAndAppManagementRoleDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAndAppManagementRoleDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementRoleDefinition>> CreateResponseAsync(DeviceAndAppManagementRoleDefinition deviceAndAppManagementRoleDefinitionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<DeviceAndAppManagementRoleDefinition>(deviceAndAppManagementRoleDefinitionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceAndAppManagementRoleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<DeviceAndAppManagementRoleDefinition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceAndAppManagementRoleDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceAndAppManagementRoleDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceAndAppManagementRoleDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceAndAppManagementRoleDefinition> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<DeviceAndAppManagementRoleDefinition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceAndAppManagementRoleDefinition and returns a <see cref="GraphResponse{DeviceAndAppManagementRoleDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAndAppManagementRoleDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementRoleDefinition>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<DeviceAndAppManagementRoleDefinition>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceAndAppManagementRoleDefinition using PATCH.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleDefinitionToUpdate">The DeviceAndAppManagementRoleDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceAndAppManagementRoleDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceAndAppManagementRoleDefinition> UpdateAsync(DeviceAndAppManagementRoleDefinition deviceAndAppManagementRoleDefinitionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<DeviceAndAppManagementRoleDefinition>(deviceAndAppManagementRoleDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceAndAppManagementRoleDefinition using PATCH and returns a <see cref="GraphResponse{DeviceAndAppManagementRoleDefinition}"/> object.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleDefinitionToUpdate">The DeviceAndAppManagementRoleDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceAndAppManagementRoleDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementRoleDefinition>> UpdateResponseAsync(DeviceAndAppManagementRoleDefinition deviceAndAppManagementRoleDefinitionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<DeviceAndAppManagementRoleDefinition>(deviceAndAppManagementRoleDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceAndAppManagementRoleDefinitionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceAndAppManagementRoleDefinitionRequest Expand(Expression<Func<DeviceAndAppManagementRoleDefinition, object>> expandExpression)
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
        public IDeviceAndAppManagementRoleDefinitionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceAndAppManagementRoleDefinitionRequest Select(Expression<Func<DeviceAndAppManagementRoleDefinition, object>> selectExpression)
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
        /// <param name="deviceAndAppManagementRoleDefinitionToInitialize">The <see cref="DeviceAndAppManagementRoleDefinition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceAndAppManagementRoleDefinition deviceAndAppManagementRoleDefinitionToInitialize)
        {

        }
    }
}
