// <copyright file="IAPIController.cs" company="APIMatic">
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
    /// IAPIController.
    /// </summary>
    public interface IAPIController
    {
        /// <summary>
        /// This endpoint is use to check the health of the API.
        /// </summary>
        /// <returns>Returns the string response from the API call.</returns>
        string Health();

        /// <summary>
        /// This endpoint is use to check the health of the API.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        Task<string> HealthAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is use to register a new client access.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.RegisterTokenResponse response from the API call.</returns>
        Models.RegisterTokenResponse Register(
                Models.RegisterTokenRequest body = null);

        /// <summary>
        /// This endpoint is use to register a new client access.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RegisterTokenResponse response from the API call.</returns>
        Task<Models.RegisterTokenResponse> RegisterAsync(
                Models.RegisterTokenRequest body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is use to make a single bill payment.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SingleBillPaymentResponse response from the API call.</returns>
        Models.SingleBillPaymentResponse SingleBillPayment(
                Models.SingleBillPaymentRequest body = null);

        /// <summary>
        /// This endpoint is use to make a single bill payment.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SingleBillPaymentResponse response from the API call.</returns>
        Task<Models.SingleBillPaymentResponse> SingleBillPaymentAsync(
                Models.SingleBillPaymentRequest body = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is use to get a list of client Ids created by the merchant.
        /// </summary>
        /// <param name="merchantWalletAddress">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ListClientAppsResponse response from the API call.</returns>
        Models.ListClientAppsResponse GetClientIds(
                string merchantWalletAddress);

        /// <summary>
        /// This endpoint is use to get a list of client Ids created by the merchant.
        /// </summary>
        /// <param name="merchantWalletAddress">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListClientAppsResponse response from the API call.</returns>
        Task<Models.ListClientAppsResponse> GetClientIdsAsync(
                string merchantWalletAddress,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is use to delete a registered client app.
        /// </summary>
        /// <param name="merchantWalletAddress">Required parameter: Example: .</param>
        /// <param name="clientId">Required parameter: Example: .</param>
        /// <returns>Returns the string response from the API call.</returns>
        string DeleteClientApp(
                string merchantWalletAddress,
                string clientId);

        /// <summary>
        /// This endpoint is use to delete a registered client app.
        /// </summary>
        /// <param name="merchantWalletAddress">Required parameter: Example: .</param>
        /// <param name="clientId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        Task<string> DeleteClientAppAsync(
                string merchantWalletAddress,
                string clientId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// This endpoint is use to get the status of an order.
        /// </summary>
        /// <param name="orderCode">Required parameter: Example: .</param>
        /// <returns>Returns the string response from the API call.</returns>
        string GetOrderStatus(
                string orderCode);

        /// <summary>
        /// This endpoint is use to get the status of an order.
        /// </summary>
        /// <param name="orderCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        Task<string> GetOrderStatusAsync(
                string orderCode,
                CancellationToken cancellationToken = default);
    }
}