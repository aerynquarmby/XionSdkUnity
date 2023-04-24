// <copyright file="ProductId.cs" company="APIMatic">
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
    /// ProductId.
    /// </summary>
    public class ProductId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductId"/> class.
        /// </summary>
        public ProductId()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductId"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        public ProductId(
            int? id = null)
        {
            this.Id = id;
        }

        /// <summary>
        /// Id of product you will want to make payment for.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProductId : ({string.Join(", ", toStringOutput)})";
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

            return obj is ProductId other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        public override int GetHashCode()
{
    unchecked
    {
        int hash = 17;
        hash = hash * 23 + (this.Id != null ? this.Id.GetHashCode() : 0);
        return hash;
    }
}

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
        }
    }
}