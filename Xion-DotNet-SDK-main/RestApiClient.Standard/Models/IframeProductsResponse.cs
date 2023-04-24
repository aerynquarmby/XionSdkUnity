// <copyright file="IframeProductsResponse.cs" company="APIMatic">
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
    /// IframeProductsResponse.
    /// </summary>
    public class IframeProductsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IframeProductsResponse"/> class.
        /// </summary>
        public IframeProductsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IframeProductsResponse"/> class.
        /// </summary>
        /// <param name="referenceId">reference_id.</param>
        /// <param name="productCode">product_code.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="productPrice">product_price.</param>
        /// <param name="remarks">remarks.</param>
        public IframeProductsResponse(
            int? referenceId = null,
            string productCode = null,
            string productName = null,
            double? productPrice = null,
            string remarks = null)
        {
            this.ReferenceId = referenceId;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.Remarks = remarks;
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

        /// <summary>
        /// Gets or sets Remarks.
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IframeProductsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is IframeProductsResponse other &&
                ((this.ReferenceId == null && other.ReferenceId == null) || (this.ReferenceId?.Equals(other.ReferenceId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductPrice == null && other.ProductPrice == null) || (this.ProductPrice?.Equals(other.ProductPrice) == true)) &&
                ((this.Remarks == null && other.Remarks == null) || (this.Remarks?.Equals(other.Remarks) == true));
        }
        public override int GetHashCode()
{
    int hash = 17;
    hash = hash * 23 + (ReferenceId?.GetHashCode() ?? 0);
    hash = hash * 23 + (ProductCode?.GetHashCode() ?? 0);
    hash = hash * 23 + (ProductName?.GetHashCode() ?? 0);
    hash = hash * 23 + (ProductPrice?.GetHashCode() ?? 0);
    hash = hash * 23 + (Remarks?.GetHashCode() ?? 0);
    return hash;
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
            toStringOutput.Add($"this.Remarks = {(this.Remarks == null ? "null" : this.Remarks == string.Empty ? "" : this.Remarks)}");
        }
    }
}