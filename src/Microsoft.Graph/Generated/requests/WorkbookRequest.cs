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
    /// The type WorkbookRequest.
    /// </summary>
    public partial class WorkbookRequest : BaseRequest, IWorkbookRequest
    {
        /// <summary>
        /// Constructs a new WorkbookRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Workbook using POST.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Workbook.</returns>
        public async System.Threading.Tasks.Task<Workbook> CreateAsync(Workbook workbookToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<Workbook>(workbookToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Workbook using POST and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Workbook>> CreateResponseAsync(Workbook workbookToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<Workbook>(workbookToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            await this.SendAsync<Workbook>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Workbook and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Workbook.</returns>
        public async System.Threading.Tasks.Task<Workbook> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<Workbook>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Workbook and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Workbook>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<Workbook>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Workbook using PATCH.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Workbook.</returns>
        public async System.Threading.Tasks.Task<Workbook> UpdateAsync(Workbook workbookToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<Workbook>(workbookToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Workbook using PATCH and returns a <see cref="GraphResponse{Workbook}"/> object.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Workbook}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Workbook>> UpdateResponseAsync(Workbook workbookToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<Workbook>(workbookToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRequest Expand(Expression<Func<Workbook, object>> expandExpression)
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
        public IWorkbookRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRequest Select(Expression<Func<Workbook, object>> selectExpression)
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
        /// <param name="workbookToInitialize">The <see cref="Workbook"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Workbook workbookToInitialize)
        {

            if (workbookToInitialize != null && workbookToInitialize.AdditionalData != null)
            {

                if (workbookToInitialize.Comments != null && workbookToInitialize.Comments.CurrentPage != null)
                {
                    workbookToInitialize.Comments.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("comments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Comments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookToInitialize.Names != null && workbookToInitialize.Names.CurrentPage != null)
                {
                    workbookToInitialize.Names.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("names@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Names.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookToInitialize.Operations != null && workbookToInitialize.Operations.CurrentPage != null)
                {
                    workbookToInitialize.Operations.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookToInitialize.Tables != null && workbookToInitialize.Tables.CurrentPage != null)
                {
                    workbookToInitialize.Tables.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("tables@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Tables.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookToInitialize.Worksheets != null && workbookToInitialize.Worksheets.CurrentPage != null)
                {
                    workbookToInitialize.Worksheets.AdditionalData = workbookToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookToInitialize.AdditionalData.TryGetValue("worksheets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookToInitialize.Worksheets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
