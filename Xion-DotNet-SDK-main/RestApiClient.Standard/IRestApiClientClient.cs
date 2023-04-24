// <copyright file="IRestApiClientClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace RestApiClient.Standard
{
    using System;
    using RestApiClient.Standard.Controllers;

    /// <summary>
    /// IRestApiClientClient.
    /// </summary>
    public interface IRestApiClientClient : IConfiguration
    {
        /// <summary>
        /// Gets instance for IAPIController.
        /// </summary>
        IAPIController APIController { get; }

        /// <summary>
        /// Gets instance for IIframeController.
        /// </summary>
        IIframeController IframeController { get; }
    }
}