// <copyright file="RestApiClientClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace RestApiClient.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using RestApiClient.Standard.Authentication;
    using RestApiClient.Standard.Controllers;
    using RestApiClient.Standard.Http.Client;
    using RestApiClient.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class RestApiClientClient : IRestApiClientClient
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://prodp-api.xion.app/api/v2" },
                }
            },
            {
                Environment.Sandbox, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://devp-api.xion.app/api/v2" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "xionglobal-sdk v2.0.0 - DotNet";
        private readonly BearerAuthManager bearerAuthManager;
        private readonly Lazy<IAPIController> client;
        private readonly Lazy<IIframeController> iframe;

        private RestApiClientClient(
            Environment environment,
            string accessToken,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.HttpClientConfiguration = httpClientConfiguration;
            bearerAuthManager = new BearerAuthManager(accessToken);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", bearerAuthManager}
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();


            this.client = new Lazy<IAPIController>(
                () => new APIController(globalConfiguration));
            this.iframe = new Lazy<IIframeController>(
                () => new IframeController(globalConfiguration));
        }

        /// <summary>
        /// Gets APIController controller.
        /// </summary>
        public IAPIController APIController => this.client.Value;

        /// <summary>
        /// Gets IframeController controller.
        /// </summary>
        public IIframeController IframeController => this.iframe.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }


        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        private IBearerAuthCredentials BearerAuthCredentials => this.bearerAuthManager;

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the RestApiClientClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .AccessToken(BearerAuthCredentials.AccessToken)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> RestApiClientClient.</returns>
        internal static RestApiClientClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("REST_API_CLIENT_STANDARD_ENVIRONMENT");
            string accessToken = System.Environment.GetEnvironmentVariable("REST_API_CLIENT_STANDARD_ACCESS_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (accessToken != null)
            {
                builder.AccessToken(accessToken);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = RestApiClient.Standard.Environment.Sandbox;
            private string accessToken = "";
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            public Builder AccessToken(string accessToken)
            {
                this.accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Creates an object of the RestApiClientClient using the values provided for the builder.
            /// </summary>
            /// <returns>RestApiClientClient.</returns>
            public RestApiClientClient Build()
            {

                return new RestApiClientClient(
                    environment,
                    accessToken,
                    httpClientConfig.Build());
            }
        }
    }
}
