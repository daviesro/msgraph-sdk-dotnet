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
    /// The type Agreement File.
    /// </summary>
    public partial class AgreementFile : AgreementFileProperties
    {
    
        /// <summary>
        /// Gets or sets localizations.
        /// The localized version of the terms of use agreement files attached to the agreement.
        /// </summary>
        [JsonPropertyName("localizations")]
        public IAgreementFileLocalizationsCollectionPage Localizations { get; set; }

        /// <summary>
        /// Gets or sets localizationsNextLink.
        /// </summary>
        [JsonPropertyName("localizations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string LocalizationsNextLink { get; set; }
    
    }
}

