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
    /// The type WorkbookFunctionsBeta_DistRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsBeta_DistRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsBeta_DistRequest>, IWorkbookFunctionsBeta_DistRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsBeta_DistRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="alpha">A alpha parameter for the OData method call.</param>
        /// <param name="beta">A beta parameter for the OData method call.</param>
        /// <param name="cumulative">A cumulative parameter for the OData method call.</param>
        /// <param name="A">A A parameter for the OData method call.</param>
        /// <param name="B">A B parameter for the OData method call.</param>
        public WorkbookFunctionsBeta_DistRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument x,
            System.Text.Json.JsonDocument alpha,
            System.Text.Json.JsonDocument beta,
            System.Text.Json.JsonDocument cumulative,
            System.Text.Json.JsonDocument A,
            System.Text.Json.JsonDocument B)
            : base(requestUrl, client)
        {
            this.SetParameter("x", x, true);
            this.SetParameter("alpha", alpha, true);
            this.SetParameter("beta", beta, true);
            this.SetParameter("cumulative", cumulative, true);
            this.SetParameter("a", A, true);
            this.SetParameter("b", B, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsBeta_DistRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsBeta_DistRequest(functionUrl, this.Client, options);

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<System.Text.Json.JsonDocument>("x");
            }

            if (this.HasParameter("alpha"))
            {
                request.RequestBody.Alpha = this.GetParameter<System.Text.Json.JsonDocument>("alpha");
            }

            if (this.HasParameter("beta"))
            {
                request.RequestBody.Beta = this.GetParameter<System.Text.Json.JsonDocument>("beta");
            }

            if (this.HasParameter("cumulative"))
            {
                request.RequestBody.Cumulative = this.GetParameter<System.Text.Json.JsonDocument>("cumulative");
            }

            if (this.HasParameter("a"))
            {
                request.RequestBody.A = this.GetParameter<System.Text.Json.JsonDocument>("a");
            }

            if (this.HasParameter("b"))
            {
                request.RequestBody.B = this.GetParameter<System.Text.Json.JsonDocument>("b");
            }

            return request;
        }
    }
}
