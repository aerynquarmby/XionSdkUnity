// <copyright file="IIframeController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace RestApiClient.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using RestApiClient.Standard;
    using RestApiClient.Standard.Http.Client;
    using RestApiClient.Standard.Http.Request;
    using RestApiClient.Standard.Http.Response;
    using RestApiClient.Standard.Utilities;

    /// <summary>
    /// IIframeController.
    /// </summary>
    public interface IIframeController
    {
        /// <summary>
        /// This endpoint is used to create iframe products.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List<Models.IframeProductsResponse> response from the API call.</returns>
        List<Models.IframeProductsResponse> CreateIframeProducts(
                List<Models.IframeProductsRequest> body = null);

        /// <summary>
        /// This endpoint is used to create iframe products.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<Models.IframeProductsResponse> response from the API call.</returns>
        Task<List<Models.IframeProductsResponse>> CreateIframeProductsAsync(
                List<Models.IframeProductsRequest> body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is used to get iframe products.
        /// </summary>
        /// <returns>Returns the List<Models.IframeProductsResponse> response from the API call.</returns>
        List<Models.IframeProductsResponse> GetIframeProducts();

        /// <summary>
        /// This endpoint is used to get iframe products.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<Models.IframeProductsResponse> response from the API call.</returns>
        Task<List<Models.IframeProductsResponse>> GetIframeProductsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is used to get product by code.
        /// </summary>
        /// <param name="referenceId">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Name of product.</param>
        /// <param name="price">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.IframeProductResponse response from the API call.</returns>
        Models.IframeProductResponse GetIframeProductByCode(
                string referenceId,
                string name = null,
                int? price = null);

        /// <summary>
        /// This endpoint is used to get product by code.
        /// </summary>
        /// <param name="referenceId">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Name of product.</param>
        /// <param name="price">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IframeProductResponse response from the API call.</returns>
        Task<Models.IframeProductResponse> GetIframeProductByCodeAsync(
                string referenceId,
                string name = null,
                int? price = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is used to get product.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List<Models.IframeProductsResponse> response from the API call.</returns>
        List<Models.IframeProductsResponse> UpdateIframeProducts(
                List<Models.IframeProductsRequest> body = null);

        /// <summary>
        /// This endpoint is used to get product.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List<Models.IframeProductsResponse> response from the API call.</returns>
        Task<List<Models.IframeProductsResponse>> UpdateIframeProductsAsync(
                List<Models.IframeProductsRequest> body = null,
                CancellationToken cancellationToken = default);
    }
}