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
    /// The type SignInStatus.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SignInStatus>))]
    public partial class SignInStatus
    {

        /// <summary>
        /// Gets or sets additionalDetails.
        /// Provides additional details on the sign-in activity
        /// </summary>
        [JsonPropertyName("additionalDetails")]
        public string AdditionalDetails { get; set; }
    
        /// <summary>
        /// Gets or sets errorCode.
        /// Provides the 5-6 digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public Int32? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets failureReason.
        /// Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
        /// </summary>
        [JsonPropertyName("failureReason")]
        public string FailureReason { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
