// <copyright file="RegisterTokenRequest.cs" company="APIMatic">
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
    /// RegisterTokenRequest.
    /// </summary>
    public class RegisterTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterTokenRequest"/> class.
        /// </summary>
        public RegisterTokenRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterTokenRequest"/> class.
        /// </summary>
        /// <param name="merchantWalletAddress">merchantWalletAddress.</param>
        /// <param name="name">name.</param>
        public RegisterTokenRequest(
            string merchantWalletAddress = null,
            string name = null)
        {
            this.MerchantWalletAddress = merchantWalletAddress;
            this.Name = name;
        }

        /// <summary>
        /// Wallet address of merchant.
        /// </summary>
        [JsonProperty("merchantWalletAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantWalletAddress { get; set; }

        /// <summary>
        /// Unique name for the third-party application going to use the access token.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegisterTokenRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is RegisterTokenRequest other &&
                ((this.MerchantWalletAddress == null && other.MerchantWalletAddress == null) || (this.MerchantWalletAddress?.Equals(other.MerchantWalletAddress) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
         /// <inheritdoc/>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            int hash = 17;
            // Suitable nullity checks etc, of course :)
            hash = hash * 23 + (this.MerchantWalletAddress?.GetHashCode() ?? 0);
            hash = hash * 23 + (this.Name?.GetHashCode() ?? 0);
            return hash;
        }
    }
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantWalletAddress = {(this.MerchantWalletAddress == null ? "null" : this.MerchantWalletAddress == string.Empty ? "" : this.MerchantWalletAddress)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
        }
    }
}