// <copyright file="SingleBillPaymentRequest.cs" company="APIMatic">
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
    /// SingleBillPaymentRequest.
    /// </summary>
    public class SingleBillPaymentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleBillPaymentRequest"/> class.
        /// </summary>
        public SingleBillPaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleBillPaymentRequest"/> class.
        /// </summary>
        /// <param name="productName">productName.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="buyerAddress">buyerAddress.</param>
        public SingleBillPaymentRequest(
            string productName = null,
            double? amount = null,
            string currency = null,
            string buyerAddress = null)
        {
            this.ProductName = productName;
            this.Amount = amount;
            this.Currency = currency;
            this.BuyerAddress = buyerAddress;
        }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [JsonProperty("productName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// Amount to be paid (USD).
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// Currency of the amount to paid.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Buyer's wallet address.
        /// </summary>
        [JsonProperty("buyerAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SingleBillPaymentRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is SingleBillPaymentRequest other &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.BuyerAddress == null && other.BuyerAddress == null) || (this.BuyerAddress?.Equals(other.BuyerAddress) == true));
        }
        public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + (this.ProductName != null ? this.ProductName.GetHashCode() : 0);
        hash = hash * 23 + this.Amount.GetHashCode();
        hash = hash * 23 + (this.Currency != null ? this.Currency.GetHashCode() : 0);
        hash = hash * 23 + (this.BuyerAddress != null ? this.BuyerAddress.GetHashCode() : 0);
        return hash;
    }
}

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName == string.Empty ? "" : this.ProductName)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency == string.Empty ? "" : this.Currency)}");
            toStringOutput.Add($"this.BuyerAddress = {(this.BuyerAddress == null ? "null" : this.BuyerAddress == string.Empty ? "" : this.BuyerAddress)}");
        }
    }
}