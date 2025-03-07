// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsGammaRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsGammaRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsGammaRequest>, IWorkbookFunctionsGammaRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsGammaRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        public WorkbookFunctionsGammaRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument x)
            : base(requestUrl, client)
        {
            this.SetParameter("x", x, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsGammaRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsGammaRequest(functionUrl, this.Client, options);

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<System.Text.Json.JsonDocument>("x");
            }

            return request;
        }
    }
}
