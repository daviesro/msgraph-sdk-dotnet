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
    /// The interface IParticipantLeftNotificationRequest.
    /// </summary>
    public partial interface IParticipantLeftNotificationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ParticipantLeftNotification using POST.
        /// </summary>
        /// <param name="participantLeftNotificationToCreate">The ParticipantLeftNotification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ParticipantLeftNotification.</returns>
        System.Threading.Tasks.Task<ParticipantLeftNotification> CreateAsync(ParticipantLeftNotification participantLeftNotificationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ParticipantLeftNotification using POST and returns a <see cref="GraphResponse{ParticipantLeftNotification}"/> object.
        /// </summary>
        /// <param name="participantLeftNotificationToCreate">The ParticipantLeftNotification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ParticipantLeftNotification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ParticipantLeftNotification>> CreateResponseAsync(ParticipantLeftNotification participantLeftNotificationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ParticipantLeftNotification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ParticipantLeftNotification and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ParticipantLeftNotification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ParticipantLeftNotification.</returns>
        System.Threading.Tasks.Task<ParticipantLeftNotification> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ParticipantLeftNotification and returns a <see cref="GraphResponse{ParticipantLeftNotification}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ParticipantLeftNotification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ParticipantLeftNotification>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ParticipantLeftNotification using PATCH.
        /// </summary>
        /// <param name="participantLeftNotificationToUpdate">The ParticipantLeftNotification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ParticipantLeftNotification.</returns>
        System.Threading.Tasks.Task<ParticipantLeftNotification> UpdateAsync(ParticipantLeftNotification participantLeftNotificationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ParticipantLeftNotification using PATCH and returns a <see cref="GraphResponse{ParticipantLeftNotification}"/> object.
        /// </summary>
        /// <param name="participantLeftNotificationToUpdate">The ParticipantLeftNotification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ParticipantLeftNotification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ParticipantLeftNotification>> UpdateResponseAsync(ParticipantLeftNotification participantLeftNotificationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ParticipantLeftNotification using PUT.
        /// </summary>
        /// <param name="participantLeftNotificationToUpdate">The ParticipantLeftNotification object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ParticipantLeftNotification> PutAsync(ParticipantLeftNotification participantLeftNotificationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ParticipantLeftNotification using PUT and returns a <see cref="GraphResponse{ParticipantLeftNotification}"/> object.
        /// </summary>
        /// <param name="participantLeftNotificationToUpdate">The ParticipantLeftNotification object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ParticipantLeftNotification}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ParticipantLeftNotification>> PutResponseAsync(ParticipantLeftNotification participantLeftNotificationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IParticipantLeftNotificationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IParticipantLeftNotificationRequest Expand(Expression<Func<ParticipantLeftNotification, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IParticipantLeftNotificationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IParticipantLeftNotificationRequest Select(Expression<Func<ParticipantLeftNotification, object>> selectExpression);

    }
}
