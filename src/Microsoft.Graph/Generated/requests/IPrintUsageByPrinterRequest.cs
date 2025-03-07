// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPrintUsageByPrinterRequest.
    /// </summary>
    public partial interface IPrintUsageByPrinterRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrintUsageByPrinter using POST.
        /// </summary>
        /// <param name="printUsageByPrinterToCreate">The PrintUsageByPrinter to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintUsageByPrinter.</returns>
        System.Threading.Tasks.Task<PrintUsageByPrinter> CreateAsync(PrintUsageByPrinter printUsageByPrinterToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified PrintUsageByPrinter using POST and returns a <see cref="GraphResponse{PrintUsageByPrinter}"/> object.
        /// </summary>
        /// <param name="printUsageByPrinterToCreate">The PrintUsageByPrinter to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintUsageByPrinter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintUsageByPrinter>> CreateResponseAsync(PrintUsageByPrinter printUsageByPrinterToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrintUsageByPrinter.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrintUsageByPrinter and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrintUsageByPrinter.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintUsageByPrinter.</returns>
        System.Threading.Tasks.Task<PrintUsageByPrinter> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrintUsageByPrinter and returns a <see cref="GraphResponse{PrintUsageByPrinter}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintUsageByPrinter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintUsageByPrinter>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintUsageByPrinter using PATCH.
        /// </summary>
        /// <param name="printUsageByPrinterToUpdate">The PrintUsageByPrinter to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintUsageByPrinter.</returns>
        System.Threading.Tasks.Task<PrintUsageByPrinter> UpdateAsync(PrintUsageByPrinter printUsageByPrinterToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintUsageByPrinter using PATCH and returns a <see cref="GraphResponse{PrintUsageByPrinter}"/> object.
        /// </summary>
        /// <param name="printUsageByPrinterToUpdate">The PrintUsageByPrinter to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrintUsageByPrinter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintUsageByPrinter>> UpdateResponseAsync(PrintUsageByPrinter printUsageByPrinterToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintUsageByPrinter using PUT.
        /// </summary>
        /// <param name="printUsageByPrinterToUpdate">The PrintUsageByPrinter object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PrintUsageByPrinter> PutAsync(PrintUsageByPrinter printUsageByPrinterToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrintUsageByPrinter using PUT and returns a <see cref="GraphResponse{PrintUsageByPrinter}"/> object.
        /// </summary>
        /// <param name="printUsageByPrinterToUpdate">The PrintUsageByPrinter object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PrintUsageByPrinter}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintUsageByPrinter>> PutResponseAsync(PrintUsageByPrinter printUsageByPrinterToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageByPrinterRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageByPrinterRequest Expand(Expression<Func<PrintUsageByPrinter, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageByPrinterRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageByPrinterRequest Select(Expression<Func<PrintUsageByPrinter, object>> selectExpression);

    }
}
