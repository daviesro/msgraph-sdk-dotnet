// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookRangeBorderRequest.
    /// </summary>
    public partial interface IWorkbookRangeBorderRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRangeBorder using POST.
        /// </summary>
        /// <param name="workbookRangeBorderToCreate">The WorkbookRangeBorder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeBorder.</returns>
        System.Threading.Tasks.Task<WorkbookRangeBorder> CreateAsync(WorkbookRangeBorder workbookRangeBorderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookRangeBorder using POST and returns a <see cref="GraphResponse{WorkbookRangeBorder}"/> object.
        /// </summary>
        /// <param name="workbookRangeBorderToCreate">The WorkbookRangeBorder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeBorder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeBorder>> CreateResponseAsync(WorkbookRangeBorder workbookRangeBorderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeBorder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeBorder and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeBorder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeBorder.</returns>
        System.Threading.Tasks.Task<WorkbookRangeBorder> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeBorder and returns a <see cref="GraphResponse{WorkbookRangeBorder}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeBorder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeBorder>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeBorder using PATCH.
        /// </summary>
        /// <param name="workbookRangeBorderToUpdate">The WorkbookRangeBorder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeBorder.</returns>
        System.Threading.Tasks.Task<WorkbookRangeBorder> UpdateAsync(WorkbookRangeBorder workbookRangeBorderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeBorder using PATCH and returns a <see cref="GraphResponse{WorkbookRangeBorder}"/> object.
        /// </summary>
        /// <param name="workbookRangeBorderToUpdate">The WorkbookRangeBorder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeBorder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeBorder>> UpdateResponseAsync(WorkbookRangeBorder workbookRangeBorderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeBorder using PUT.
        /// </summary>
        /// <param name="workbookRangeBorderToUpdate">The WorkbookRangeBorder object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookRangeBorder> PutAsync(WorkbookRangeBorder workbookRangeBorderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeBorder using PUT and returns a <see cref="GraphResponse{WorkbookRangeBorder}"/> object.
        /// </summary>
        /// <param name="workbookRangeBorderToUpdate">The WorkbookRangeBorder object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookRangeBorder}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeBorder>> PutResponseAsync(WorkbookRangeBorder workbookRangeBorderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeBorderRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeBorderRequest Expand(Expression<Func<WorkbookRangeBorder, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeBorderRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeBorderRequest Select(Expression<Func<WorkbookRangeBorder, object>> selectExpression);

    }
}
