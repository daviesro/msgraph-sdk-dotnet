// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Entitlement Management.
    /// </summary>
    public partial class EntitlementManagement : Entity
    {
    
        /// <summary>
        /// Gets or sets access package assignment approvals.
        /// </summary>
        [JsonPropertyName("accessPackageAssignmentApprovals")]
        public IEntitlementManagementAccessPackageAssignmentApprovalsCollectionPage AccessPackageAssignmentApprovals { get; set; }

        /// <summary>
        /// Gets or sets accessPackageAssignmentApprovalsNextLink.
        /// </summary>
        [JsonPropertyName("accessPackageAssignmentApprovals@odata.nextLink")]
        public string AccessPackageAssignmentApprovalsNextLink { get; set; }
    
    }
}

