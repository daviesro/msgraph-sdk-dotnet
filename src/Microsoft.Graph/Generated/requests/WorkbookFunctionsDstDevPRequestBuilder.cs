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
    /// The type WorkbookFunctionsDstDevPRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsDstDevPRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsDstDevPRequest>, IWorkbookFunctionsDstDevPRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsDstDevPRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="database">A database parameter for the OData method call.</param>
        /// <param name="field">A field parameter for the OData method call.</param>
        /// <param name="criteria">A criteria parameter for the OData method call.</param>
        public WorkbookFunctionsDstDevPRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument database,
            System.Text.Json.JsonDocument field,
            System.Text.Json.JsonDocument criteria)
            : base(requestUrl, client)
        {
            this.SetParameter("database", database, true);
            this.SetParameter("field", field, true);
            this.SetParameter("criteria", criteria, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsDstDevPRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsDstDevPRequest(functionUrl, this.Client, options);

            if (this.HasParameter("database"))
            {
                request.RequestBody.Database = this.GetParameter<System.Text.Json.JsonDocument>("database");
            }

            if (this.HasParameter("field"))
            {
                request.RequestBody.Field = this.GetParameter<System.Text.Json.JsonDocument>("field");
            }

            if (this.HasParameter("criteria"))
            {
                request.RequestBody.Criteria = this.GetParameter<System.Text.Json.JsonDocument>("criteria");
            }

            return request;
        }
    }
}
