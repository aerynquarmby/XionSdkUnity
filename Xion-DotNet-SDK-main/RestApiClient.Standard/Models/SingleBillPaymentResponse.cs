// <copyright file="SingleBillPaymentResponse.cs" company="APIMatic">
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
    /// SingleBillPaymentResponse.
    /// </summary>
    public class SingleBillPaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleBillPaymentResponse"/> class.
        /// </summary>
        public SingleBillPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleBillPaymentResponse"/> class.
        /// </summary>
        /// <param name="orderCode">orderCode.</param>
        /// <param name="transactionHash">transactionHash.</param>
        /// <param name="status">status.</param>
        public SingleBillPaymentResponse(
            string orderCode = null,
            string transactionHash = null,
            string status = null)
        {
            this.OrderCode = orderCode;
            this.TransactionHash = transactionHash;
            this.Status = status;
        }

        /// <summary>
        /// Order code for single payment.
        /// </summary>
        [JsonProperty("orderCode", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderCode { get; set; }

        /// <summary>
        /// Transaction hash of the payment.
        /// </summary>
        [JsonProperty("transactionHash", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Status of the payment.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SingleBillPaymentResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is SingleBillPaymentResponse other &&
                ((this.OrderCode == null && other.OrderCode == null) || (this.OrderCode?.Equals(other.OrderCode) == true)) &&
                ((this.TransactionHash == null && other.TransactionHash == null) || (this.TransactionHash?.Equals(other.TransactionHash) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + (this.OrderCode != null ? this.OrderCode.GetHashCode() : 0);
        hash = hash * 23 + (this.TransactionHash != null ? this.TransactionHash.GetHashCode() : 0);
        hash = hash * 23 + (this.Status != null ? this.Status.GetHashCode() : 0);
        return hash;
    }
}

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OrderCode = {(this.OrderCode == null ? "null" : this.OrderCode == string.Empty ? "" : this.OrderCode)}");
            toStringOutput.Add($"this.TransactionHash = {(this.TransactionHash == null ? "null" : this.TransactionHash == string.Empty ? "" : this.TransactionHash)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
        }
    }
}