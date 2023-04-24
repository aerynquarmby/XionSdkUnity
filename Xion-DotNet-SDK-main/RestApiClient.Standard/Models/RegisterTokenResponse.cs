// <copyright file="RegisterTokenResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace RestApiClient.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using RestApiClient.Standard;
    using RestApiClient.Standard.Utilities;

    /// <summary>
    /// RegisterTokenResponse.
    /// </summary>
    public class RegisterTokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterTokenResponse"/> class.
        /// </summary>
        public RegisterTokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterTokenResponse"/> class.
        /// </summary>
        /// <param name="clientId">clientId.</param>
        /// <param name="jwtToken">jwtToken.</param>
        public RegisterTokenResponse(
            string clientId = null,
            string jwtToken = null)
        {
            this.ClientId = clientId;
            this.JwtToken = jwtToken;
        }

        /// <summary>
        /// key for the accessing endpoint.
        /// </summary>
        [JsonProperty("clientId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// secret(JWT) for accessing endpoint should be kept safe.
        /// </summary>
        [JsonProperty("jwtToken", NullValueHandling = NullValueHandling.Ignore)]
        public string JwtToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegisterTokenResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is RegisterTokenResponse other &&
                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.JwtToken == null && other.JwtToken == null) || (this.JwtToken?.Equals(other.JwtToken) == true));
        }
        public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + (this.ClientId != null ? this.ClientId.GetHashCode() : 0);
        hash = hash * 23 + (this.JwtToken != null ? this.JwtToken.GetHashCode() : 0);
        return hash;
    }
}

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId == string.Empty ? "" : this.ClientId)}");
            toStringOutput.Add($"this.JwtToken = {(this.JwtToken == null ? "null" : this.JwtToken == string.Empty ? "" : this.JwtToken)}");
        }
    }
}