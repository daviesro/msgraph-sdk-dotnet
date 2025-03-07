// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IDeviceManagementReportsGetPolicyNonComplianceSummaryReportRequest.
    /// </summary>
    public partial interface IDeviceManagementReportsGetPolicyNonComplianceSummaryReportRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the request body.
        /// </summary>
        DeviceManagementReportsGetPolicyNonComplianceSummaryReportRequestBody RequestBody { get; }


        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="httpCompletionOption">The <see cref="HttpCompletionOption"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<Stream> PostAsync(
            CancellationToken cancellationToken = default,
            HttpCompletionOption httpCompletionOption = HttpCompletionOption.ResponseContentRead);

        /// <summary>
        /// Issues the POST request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse> PostResponseAsync(CancellationToken cancellationToken = default);



    }
}
