using Compori.Shopware.Attributes;
using Compori.Shopware.Entities;
using Newtonsoft.Json;

namespace Compori.Shopware.Plugins.GbMedia.LabelEnEV.Entities
{
    [ShopwareEntity(name: "gbmed_enev", api: "gbmed-enev")]
    public class Label : Entity
    {
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "productId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        [JsonProperty(PropertyName = "eprelId", NullValueHandling = NullValueHandling.Ignore)]
        public long EprelId { get; set; }

        [JsonProperty(PropertyName = "eprelGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string EprelGroup { get; set; }

        [JsonProperty(PropertyName = "active", NullValueHandling = NullValueHandling.Ignore)]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "class", NullValueHandling = NullValueHandling.Ignore)]
        public string EegClass { get; set; }

        [JsonProperty(PropertyName = "spectrumFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string SpectrumFrom { get; set; }

        [JsonProperty(PropertyName = "spectrumTo", NullValueHandling = NullValueHandling.Ignore)]
        public string SpectrumTo { get; set; }

        [JsonProperty(PropertyName = "color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "eprelMedia", NullValueHandling = NullValueHandling.Ignore)]
        public string EprelMedia { get; set; }

        [JsonProperty(PropertyName = "eprelDatasheed", NullValueHandling = NullValueHandling.Ignore)]
        public string EprelDatasheed { get; set; }

        [JsonProperty(PropertyName = "oldRegulation", NullValueHandling = NullValueHandling.Ignore)]
        public bool OldRegulation { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            var result = base.ToString();
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                result = this.Name + " EprelId: " + EprelId.ToString();
                if (!string.IsNullOrWhiteSpace(this.EprelGroup))
                {
                    result += " (" + this.EprelGroup + ")";
                }
                if (!string.IsNullOrWhiteSpace(this.Id))
                {
                    result += " Id: " + this.Id;
                }
            }
            return result;
        }
    }
}
