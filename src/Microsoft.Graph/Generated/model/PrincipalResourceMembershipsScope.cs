// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PrincipalResourceMembershipsScope.
    /// </summary>
    public partial class PrincipalResourceMembershipsScope : AccessReviewScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalResourceMembershipsScope"/> class.
        /// </summary>
        public PrincipalResourceMembershipsScope()
        {
            this.ODataType = "microsoft.graph.principalResourceMembershipsScope";
        }

        /// <summary>
        /// Gets or sets principalScopes.
        /// Defines the scopes of the principals whose access to resources are reviewed in the access review.
        /// </summary>
        [JsonPropertyName("principalScopes")]
        public IEnumerable<AccessReviewScope> PrincipalScopes { get; set; }
    
        /// <summary>
        /// Gets or sets resourceScopes.
        /// Defines the scopes of the resources for which access is reviewed.
        /// </summary>
        [JsonPropertyName("resourceScopes")]
        public IEnumerable<AccessReviewScope> ResourceScopes { get; set; }
    
    }
}
