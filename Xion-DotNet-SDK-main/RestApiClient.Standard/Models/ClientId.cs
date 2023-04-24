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

    public class ClientId
    {
        public ClientId()
        {
        }

        public ClientId(string clientIdProp = null, string name = null, DateTime? createdAt = null)
        {
            this.ClientIdProp = clientIdProp;
            this.Name = name;
            this.CreatedAt = createdAt;
        }

        [JsonProperty("clientId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIdProp { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClientId : ({string.Join(", ", toStringOutput)})";
        }

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

            return obj is ClientId other &&
                ((this.ClientIdProp == null && other.ClientIdProp == null) || (this.ClientIdProp?.Equals(other.ClientIdProp) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (this.ClientIdProp?.GetHashCode() ?? 0);
                hash = hash * 23 + (this.Name?.GetHashCode() ?? 0);
                hash = hash * 23 + (this.CreatedAt?.GetHashCode() ?? 0);
                return hash;
            }
        }

        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientIdProp = {(this.ClientIdProp == null ? "null" : this.ClientIdProp == string.Empty ? "" : this.ClientIdProp)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
        }
    }
}
