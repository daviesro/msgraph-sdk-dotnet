// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EntitlementManagementRequestBuilder.
    /// </summary>
    public partial class EntitlementManagementRequestBuilder : EntityRequestBuilder, IEntitlementManagementRequestBuilder
    {

        /// <summary>
        /// Constructs a new EntitlementManagementRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EntitlementManagementRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEntitlementManagementRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEntitlementManagementRequest Request(IEnumerable<Option> options)
        {
            return new EntitlementManagementRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentApprovals.
        /// </summary>
        /// <returns>The <see cref="IEntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder"/>.</returns>
        public IEntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder AccessPackageAssignmentApprovals
        {
            get
            {
                return new EntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentApprovals"), this.Client);
            }
        }
    
    }
}
