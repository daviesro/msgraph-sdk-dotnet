// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IExternalConnectionRequest.
    /// </summary>
    public partial interface IExternalConnectionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExternalConnection using POST.
        /// </summary>
        /// <param name="externalConnectionToCreate">The ExternalConnection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalConnection.</returns>
        System.Threading.Tasks.Task<ExternalConnection> CreateAsync(ExternalConnection externalConnectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ExternalConnection using POST and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="externalConnectionToCreate">The ExternalConnection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> CreateResponseAsync(ExternalConnection externalConnectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ExternalConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ExternalConnection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ExternalConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExternalConnection.</returns>
        System.Threading.Tasks.Task<ExternalConnection> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ExternalConnection and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalConnection using PATCH.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExternalConnection.</returns>
        System.Threading.Tasks.Task<ExternalConnection> UpdateAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalConnection using PATCH and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> UpdateResponseAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalConnection using PUT.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ExternalConnection> PutAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ExternalConnection using PUT and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ExternalConnection}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> PutResponseAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionRequest Expand(Expression<Func<ExternalConnection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionRequest Select(Expression<Func<ExternalConnection, object>> selectExpression);

    }
}
