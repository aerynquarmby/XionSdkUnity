// <copyright file="IframeController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace RestApiClient.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using RestApiClient.Standard;
    using RestApiClient.Standard.Authentication;
    using RestApiClient.Standard.Exceptions;
    using RestApiClient.Standard.Http.Client;
    using RestApiClient.Standard.Utilities;
    using System.Net.Http;

    /// <summary>
    /// IframeController.
    /// </summary>
    internal class IframeController : BaseController, IIframeController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IframeController"/> class.
        /// </summary>
        internal IframeController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint is used to create iframe products.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.IframeProductsResponse response from the API call.</returns>
        public List<Models.IframeProductsResponse> CreateIframeProducts(
                List<Models.IframeProductsRequest> body = null)
            => CoreHelper.RunTask(CreateIframeProductsAsync(body));

        /// <summary>
        /// This endpoint is used to create iframe products.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.IframeProductsResponse response from the API call.</returns>
        public async Task<List<Models.IframeProductsResponse>> CreateIframeProductsAsync(
                List<Models.IframeProductsRequest> body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.IframeProductsResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/iframe/create-product")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.IframeProductsResponse>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This endpoint is used to get iframe products.
        /// </summary>
        /// <returns>Returns the List of Models.IframeProductsResponse response from the API call.</returns>
        public List<Models.IframeProductsResponse> GetIframeProducts()
            => CoreHelper.RunTask(GetIframeProductsAsync());

        /// <summary>
        /// This endpoint is used to get iframe products.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.IframeProductsResponse response from the API call.</returns>
        public async Task<List<Models.IframeProductsResponse>> GetIframeProductsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.IframeProductsResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/iframe/products")
                  .WithAuth("global"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.IframeProductsResponse>>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This endpoint is used to get product by code.
        /// </summary>
        /// <param name="referenceId">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Name of product.</param>
        /// <param name="price">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.IframeProductResponse response from the API call.</returns>
        public Models.IframeProductResponse GetIframeProductByCode(
                string referenceId,
                string name = null,
                int? price = null)
            => CoreHelper.RunTask(GetIframeProductByCodeAsync(referenceId, name, price));

        /// <summary>
        /// This endpoint is used to get product by code.
        /// </summary>
        /// <param name="referenceId">Required parameter: Example: .</param>
        /// <param name="name">Optional parameter: Name of product.</param>
        /// <param name="price">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.IframeProductResponse response from the API call.</returns>
        public async Task<Models.IframeProductResponse> GetIframeProductByCodeAsync(
                string referenceId,
                string name = null,
                int? price = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.IframeProductResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/iframe/product/{referenceId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("referenceId", referenceId))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("price", price))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.IframeProductResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This endpoint is used to get product.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.IframeProductsResponse response from the API call.</returns>
        public List<Models.IframeProductsResponse> UpdateIframeProducts(
                List<Models.IframeProductsRequest> body = null)
            => CoreHelper.RunTask(UpdateIframeProductsAsync(body));

        /// <summary>
        /// This endpoint is used to get product.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.IframeProductsResponse response from the API call.</returns>
        public async Task<List<Models.IframeProductsResponse>> UpdateIframeProductsAsync(
                List<Models.IframeProductsRequest> body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.IframeProductsResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/iframe/update-product")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ErrorResponseException(_reason, _context)))
                  .Deserializer(_response => ApiHelper.JsonDeserialize<List<Models.IframeProductsResponse>>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}