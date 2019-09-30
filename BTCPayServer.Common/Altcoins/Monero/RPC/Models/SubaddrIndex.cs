using Newtonsoft.Json;

namespace BTCPayServer.Altcoins.Monero.RPC.Models
{
    public partial class SubaddrIndex
    {
        [JsonProperty("major")] public long Major { get; set; }
        [JsonProperty("minor")] public long Minor { get; set; }
    }
}