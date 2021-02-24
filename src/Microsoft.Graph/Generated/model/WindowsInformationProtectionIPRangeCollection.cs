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
    /// The type WindowsInformationProtectionIPRangeCollection.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsInformationProtectionIPRangeCollection>))]
    public partial class WindowsInformationProtectionIPRangeCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsInformationProtectionIPRangeCollection"/> class.
        /// </summary>
        public WindowsInformationProtectionIPRangeCollection()
        {
            this.ODataType = "microsoft.graph.windowsInformationProtectionIPRangeCollection";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// Display name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets ranges.
        /// Collection of Internet protocol address ranges
        /// </summary>
        [JsonPropertyName("ranges")]
        public IEnumerable<IpRange> Ranges { get; set; }
    
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
