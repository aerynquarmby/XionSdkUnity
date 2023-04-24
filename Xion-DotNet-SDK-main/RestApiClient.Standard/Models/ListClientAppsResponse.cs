// <copyright file="ListClientAppsResponse.cs" company="APIMatic">
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
    /// ListClientAppsResponse.
    /// </summary>
    public class ListClientAppsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListClientAppsResponse"/> class.
        /// </summary>
        public ListClientAppsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClientAppsResponse"/> class.
        /// </summary>
        /// <param name="merchantWalletAddress">merchantWalletAddress.</param>
        /// <param name="clientIds">clientIds.</param>
        public ListClientAppsResponse(
            string merchantWalletAddress = null,
            List<Models.ClientId> clientIds = null)
        {
            this.MerchantWalletAddress = merchantWalletAddress;
            this.ClientIds = clientIds;
        }

        /// <summary>
        /// Wallet address of merchant.
        /// </summary>
        [JsonProperty("merchantWalletAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantWalletAddress { get; set; }

        /// <summary>
        /// List of client Ids created by the merchant.
        /// </summary>
        [JsonProperty("clientIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ClientId> ClientIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListClientAppsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is ListClientAppsResponse other &&
                ((this.MerchantWalletAddress == null && other.MerchantWalletAddress == null) || (this.MerchantWalletAddress?.Equals(other.MerchantWalletAddress) == true)) &&
                ((this.ClientIds == null && other.ClientIds == null) || (this.ClientIds?.Equals(other.ClientIds) == true));
        }
        public override int GetHashCode()
{
    unchecked
    {
        int hashCode = 17;
        hashCode = (hashCode * 23) + (this.MerchantWalletAddress != null ? this.MerchantWalletAddress.GetHashCode() : 0);
        hashCode = (hashCode * 23) + (this.ClientIds != null ? this.ClientIds.GetHashCode() : 0);
        return hashCode;
    }
}

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantWalletAddress = {(this.MerchantWalletAddress == null ? "null" : this.MerchantWalletAddress == string.Empty ? "" : this.MerchantWalletAddress)}");
            toStringOutput.Add($"this.ClientIds = {(this.ClientIds == null ? "null" : $"[{string.Join(", ", this.ClientIds)} ]")}");
        }
    }
}