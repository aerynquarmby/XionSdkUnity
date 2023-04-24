// <copyright file="IframeProductResponse.cs" company="APIMatic">
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
    /// IframeProductResponse.
    /// </summary>
    public class IframeProductResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IframeProductResponse"/> class.
        /// </summary>
        public IframeProductResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IframeProductResponse"/> class.
        /// </summary>
        /// <param name="referenceId">reference_id.</param>
        /// <param name="productCode">product_code.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="productPrice">product_price.</param>
        public IframeProductResponse(
            int? referenceId = null,
            string productCode = null,
            string productName = null,
            double? productPrice = null)
        {
            this.ReferenceId = referenceId;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }

        /// <summary>
        /// Gets or sets ReferenceId.
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReferenceId { get; set; }

        /// <summary>
        /// Gets or sets ProductCode.
        /// </summary>
        [JsonProperty("product_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets ProductPrice.
        /// </summary>
        [JsonProperty("product_price", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProductPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IframeProductResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is IframeProductResponse other &&
                ((this.ReferenceId == null && other.ReferenceId == null) || (this.ReferenceId?.Equals(other.ReferenceId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductPrice == null && other.ProductPrice == null) || (this.ProductPrice?.Equals(other.ProductPrice) == true));
        }
        public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + (this.ReferenceId?.GetHashCode() ?? 0);
        hash = hash * 23 + (this.ProductCode?.GetHashCode() ?? 0);
        hash = hash * 23 + (this.ProductName?.GetHashCode() ?? 0);
        hash = hash * 23 + (this.ProductPrice?.GetHashCode() ?? 0);
        return hash;
    }
}

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReferenceId = {(this.ReferenceId == null ? "null" : this.ReferenceId.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode == string.Empty ? "" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName == string.Empty ? "" : this.ProductName)}");
            toStringOutput.Add($"this.ProductPrice = {(this.ProductPrice == null ? "null" : this.ProductPrice.ToString())}");
        }
    }
}