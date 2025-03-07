// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: StreamRequest.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ServiceAnnouncementAttachmentContentRequest.
    /// </summary>
    public partial class ServiceAnnouncementAttachmentContentRequest : BaseRequest, IServiceAnnouncementAttachmentContentRequest
    {
        /// <summary>
        /// Constructs a new ServiceAnnouncementAttachmentContentRequest.
        /// <param name="requestUrl">The request URL.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query option name value pairs for the request.</param>
        /// </summary>
        public ServiceAnnouncementAttachmentContentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The stream.</returns>
        public System.Threading.Tasks.Task<Stream> GetAsync(CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            this.Method = HttpMethods.GET;
            return this.SendStreamRequestAsync(null, cancellationToken, completionOption);
        }

        /// <summary>
        /// Gets the <see cref="GraphResponse"/> object of the request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse> GetResponseAsync(CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse(null, cancellationToken, completionOption);
        }
    
        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="content">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The object returned by the PUT call.</returns>
        public System.Threading.Tasks.Task<T> PutAsync<T>(Stream content, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead) where T : ServiceAnnouncementAttachment
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Stream;
            this.Method = HttpMethods.PUT;
            return this.SendAsync<T>(content, cancellationToken, completionOption);
        }

        /// <summary>
        /// PUTs the specified stream and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="content">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The <see cref="GraphResponse"/> object returned by the PUT call.</returns>
        public System.Threading.Tasks.Task<GraphResponse<T>> PutResponseAsync<T>(Stream content, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead) where T : ServiceAnnouncementAttachment
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Stream;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<T>(content, cancellationToken, completionOption);
        }
    
    }
}
