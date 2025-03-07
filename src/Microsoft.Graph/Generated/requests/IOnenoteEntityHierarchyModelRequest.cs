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
    /// The interface IOnenoteEntityHierarchyModelRequest.
    /// </summary>
    public partial interface IOnenoteEntityHierarchyModelRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnenoteEntityHierarchyModel using POST.
        /// </summary>
        /// <param name="onenoteEntityHierarchyModelToCreate">The OnenoteEntityHierarchyModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteEntityHierarchyModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityHierarchyModel> CreateAsync(OnenoteEntityHierarchyModel onenoteEntityHierarchyModelToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified OnenoteEntityHierarchyModel using POST and returns a <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntityHierarchyModelToCreate">The OnenoteEntityHierarchyModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteEntityHierarchyModel>> CreateResponseAsync(OnenoteEntityHierarchyModel onenoteEntityHierarchyModelToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OnenoteEntityHierarchyModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OnenoteEntityHierarchyModel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OnenoteEntityHierarchyModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteEntityHierarchyModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityHierarchyModel> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OnenoteEntityHierarchyModel and returns a <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteEntityHierarchyModel>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OnenoteEntityHierarchyModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntityHierarchyModelToUpdate">The OnenoteEntityHierarchyModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteEntityHierarchyModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntityHierarchyModel> UpdateAsync(OnenoteEntityHierarchyModel onenoteEntityHierarchyModelToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OnenoteEntityHierarchyModel using PATCH and returns a <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntityHierarchyModelToUpdate">The OnenoteEntityHierarchyModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteEntityHierarchyModel>> UpdateResponseAsync(OnenoteEntityHierarchyModel onenoteEntityHierarchyModelToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OnenoteEntityHierarchyModel using PUT.
        /// </summary>
        /// <param name="onenoteEntityHierarchyModelToUpdate">The OnenoteEntityHierarchyModel object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OnenoteEntityHierarchyModel> PutAsync(OnenoteEntityHierarchyModel onenoteEntityHierarchyModelToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OnenoteEntityHierarchyModel using PUT and returns a <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntityHierarchyModelToUpdate">The OnenoteEntityHierarchyModel object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OnenoteEntityHierarchyModel}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteEntityHierarchyModel>> PutResponseAsync(OnenoteEntityHierarchyModel onenoteEntityHierarchyModelToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityHierarchyModelRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityHierarchyModelRequest Expand(Expression<Func<OnenoteEntityHierarchyModel, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityHierarchyModelRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntityHierarchyModelRequest Select(Expression<Func<OnenoteEntityHierarchyModel, object>> selectExpression);

    }
}
